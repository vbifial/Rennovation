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
    public partial class frmPointAdding : Form
    {
        public frmPointAdding()
        {
            InitializeComponent();
            btnSave.Click += new EventHandler(btnSave_Click);
            btnCancel.Click += new EventHandler(btnCancel_Click);
            AcceptButton = btnSave;
            CancelButton = btnCancel;
            cmbWorktype.SelectedIndexChanged += new EventHandler(cmbWorktype_SelectedIndexChanged);
        }

        public bool adding = true;
        public EntPoint point = null;
        public bool success = false;
        public long porder = -1;

        EntLevel clevel = null;
        long cwt = -1;
        long clvl = -1;
        long cpoint = -1;

        public void init()
        {
            if (adding)
            {
                this.Text = "Добавление записи";
                cwt = -1;
                clvl = -1;
                cpoint = -1;
                txtDescr.Text = "";
                txtAmount.Text = "";
                txtEcost.Text = "";
                txtFcost.Text = "";
                dtpEdate.Value = DateTime.Today;
                chbEdate.Checked = true;
            }
            else
            {
                this.Text = "Редактирование записи";
                clevel = point.getLevel();
                cwt = clevel.pworktype;
                clvl = clevel.plevel;
                cpoint = point.ppoint;
                txtDescr.Text = point.descript;
                txtAmount.Text = "" + point.amount;
                txtEcost.Text = (point.ecost == -1) ? "" : ("" + point.ecost);
                txtFcost.Text = (point.fcost == -1) ? "" : ("" + point.fcost);
                dtpEdate.Value = (point.edate.Equals(DateTime.MinValue)) ? 
                    DateTime.Today : point.edate;
                chbEdate.Checked = (point.edate.Equals(DateTime.MinValue));

                //this.Text = "" + cwt + " " + cql + " " + csp;
            }
            loadWorktypes();
            success = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbLevel.SelectedItem == null)
            {
                MessageBox.Show("Не выбран требуемый уровень.");
                return;
            }
            long plevel = ((EntLevel)(cmbLevel.SelectedItem)).plevel;
            String descript = txtDescr.Text;
            long amount = -1;
            long ecost = -1;
            long fcost = -1;
            DateTime edate = chbEdate.Checked ? DateTime.MinValue : (dtpEdate.Value);
            try
            {
                ecost = txtEcost.Text.Equals("") ? -1 : long.Parse(txtEcost.Text);
                fcost = txtFcost.Text.Equals("") ? -1 : long.Parse(txtFcost.Text);
                amount = long.Parse(txtAmount.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Значения объема и стоимостей должны быть целыми числами. " + 
                    "Если стоимость не указана, оставьте строку пустой\n" + exc.Message);
                return;
            }
            if (EntPoint.check(plevel, porder, edate, descript, amount, ecost, fcost))
                if (adding)
                {
                    try
                    {
                        point = new EntPoint(plevel, porder, edate, descript, amount, ecost, fcost);
                        point.save();
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
                        point.update(plevel, porder, edate, descript, amount, ecost, fcost);
                        point.save();
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
            loadLevels();
        }

        private void cmbWorktype_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLevels();
        }

        private void loadLevels()
        {
            cmbLevel.Items.Clear();
            if (cmbWorktype.SelectedIndex != -1)
            {
                EntWorktype worktype = (EntWorktype)(cmbWorktype.SelectedItem);
                foreach (EntLevel l in EntLevel.getWithWorktype(worktype.pworktype))
                {
                    int cur = cmbLevel.Items.Add(l);
                    if (l.plevel == clvl)
                        cmbLevel.SelectedIndex = cur;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void chbEdate_CheckedChanged(object sender, EventArgs e)
        {
            dtpEdate.Enabled = !chbEdate.Checked;
        }

    }
}
