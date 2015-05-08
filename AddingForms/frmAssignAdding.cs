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
    public partial class frmAssignAdding : Form
    {
        public frmAssignAdding()
        {
            InitializeComponent();
            btnSave.Click += new EventHandler(btnSave_Click);
            btnCancel.Click += new EventHandler(btnCancel_Click);
            AcceptButton = btnSave;
            CancelButton = btnCancel;
        }

        public bool adding = true;
        public EntAssign assign = null;
        public bool success = false;
        public long ppoint = -1;


        EntWorker cworker = null;
        long cwk = -1;


        private void frmAssignAdding_Shown(object sender, EventArgs e)
        {
            if (cmbWorker.Items.Count == 0)
            {
                MessageBox.Show("Нет свободных работников, обладающих необходимой квалификацией.");
                this.Hide();
            }
        }


        #region код, связанный с добавлением пунктов

        public void init()
        {
            if (adding)
            {
                this.Text = "Добавление записи";
                txtAmount.Text = "";
                assign = null;
                cwk = -1;
            }
            else
            {
                this.Text = "Редактирование записи";
                cworker = assign.getWorker();
                cwk = cworker.pworker;
                txtAmount.Text = "" + assign.amount;
                //this.Text = "" + cwt + " " + cql + " " + csp;
            }
            loadWorkers();
            success = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tryToSave())
            {
                success = true;
                this.Hide();
            }
        }

        private bool saved()
        {
            if (!adding)
                return true;

            if (tryToSave())
                return true;

            return false;
        }

        private bool tryToSave()
        {

            if (cmbWorker.SelectedItem == null)
            {
                MessageBox.Show("Не выбран работник.");
                return false;
            }
            long pworker = ((EntWorker)(cmbWorker.SelectedItem)).pworker;
            long amount = -1;
            try
            {
                amount = long.Parse(txtAmount.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Значение объема должно быть целым числом. " + exc.Message);
                return false;
            }
            if (EntAssign.check(ppoint, pworker, amount))
                if (adding)
                {
                    try
                    {
                        assign = new EntAssign(ppoint, pworker, amount);
                        assign.save();
                        success = true;
                        adding = false;
                        return true;
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
                        assign.update(ppoint, pworker, amount);
                        assign.save();
                        success = true;
                        adding = false;
                        return true;
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Error:\n" + exc.Message);
                    }
                }


            return false;
        }

        private void loadWorkers()
        {
            cmbWorker.Items.Clear();
            foreach (EntWorker w in EntWorker.getForPoint(ppoint))
            {
                int cur = cmbWorker.Items.Add(w);
                if (w.pworker == cwk)
                    cmbWorker.SelectedIndex = cur;
            }
        }

        private void cmbWorktype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion
    }
}
