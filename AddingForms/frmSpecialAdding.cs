using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rennovation.REntities;

namespace Rennovation
{
    public partial class frmSpecialAdding : Form
    {
        public frmSpecialAdding()
        {
            InitializeComponent();
            btnSave.Click += new EventHandler(btnSave_Click);
            btnCancel.Click += new EventHandler(btnCancel_Click);
            AcceptButton = btnSave;
            CancelButton = btnCancel;
            cmbWorktype.SelectedIndexChanged += new EventHandler(cmbWorktype_SelectedIndexChanged);
        }

        public bool adding = true;
        public EntSpecial special = null;
        public bool success = false;
        public long pworker = -1;

        EntQual cqual = null;
        long cwt = -1;
        long cql = -1;
        long csp = -1;

        public void init()
        {
            if (adding)
            {
                this.Text = "Добавление записи";
                cwt = -1;
                cql = -1;
                csp = -1;
            }
            else
            {
                this.Text = "Редактирование записи";
                cqual = special.getQual();
                cwt = cqual.pworktype;
                cql = cqual.pqual;
                csp = special.pspecial;
                //this.Text = "" + cwt + " " + cql + " " + csp;
            }
            loadWorktypes();
            success = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbQual.SelectedItem == null)
            {
                MessageBox.Show("Не выбрана квалификация.");
                return;
            }
            long pqual = ((EntQual)(cmbQual.SelectedItem)).pqual;
            //try
            //{
            //    lvalue = long.Parse(txtLValue.Text);
            //    value = long.Parse(txtValue.Text);
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show("Значения показателя и оплаты должны быть целыми числами.\n" + exc.Message);
            //    return;
            //}
            if (EntSpecial.check(csp, pworker, pqual))
                if (adding)
                {
                    try
                    {
                        special = new EntSpecial(pworker, pqual);
                        special.save();
                        success = true;
                        this.Hide();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Error:\n" + exc.Message);
                    }
                }
                else
                {
                    try
                    {
                        special.pqual = pqual;
                        special.save();
                        success = true;
                        this.Hide();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Error:\n" + exc.Message);
                    }
                }
        }

        private void loadWorktypes()
        {
            cmbWorktype.Items.Clear();
            foreach (EntWorktype w in EntWorktype.getAll())
            {
                int cur = cmbWorktype.Items.Add(w);
                if (w.pworktype == cwt)
                    cmbWorktype.SelectedIndex = cur;
            }
            loadQuals();
        }

        private void cmbWorktype_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadQuals();
        }

        private void loadQuals()
        {
            cmbQual.Items.Clear();
            if (cmbWorktype.SelectedIndex != -1)
            {
                EntWorktype worktype = (EntWorktype)(cmbWorktype.SelectedItem);
                foreach (EntQual q in EntQual.getWithWorktype(worktype.pworktype))
                {
                    int cur = cmbQual.Items.Add(q);
                    if (q.pqual == cql)
                        cmbQual.SelectedIndex = cur;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
