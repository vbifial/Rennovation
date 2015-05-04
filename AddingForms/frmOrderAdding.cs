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
    public partial class frmOrderAdding : Form
    {
        public frmOrderAdding()
        {
            InitializeComponent();
            btnSave.Click += new EventHandler(btnSave_Click);
            btnCancel.Click += new EventHandler(btnCancel_Click);
            AcceptButton = btnSave;
            CancelButton = btnCancel;
        }

        public bool adding = true;
        public EntOrder order = null;
        public bool success = false;

        long ccus = -1;

        public void init()
        {
            if (adding)
            {
                this.Text = "Добавление записи";
                txtName.Text = null;
                txtObject.Lines = null;
                chbFMark.Checked = false;
                dtpCdate.Value = DateTime.Today;
                dtpBdate.Value = DateTime.Today;
                dtpEdate.Value = DateTime.Today;
                chbCdate.Checked = true;
                chbBdate.Checked = true;
                chbEdate.Checked = true;
                ccus = -1;
                txtEcost.Text = "";
                txtFcost.Text = "";
            }
            else
            {
                this.Text = "Редактирование записи";
                txtName.Text = order.name;
                txtObject.Lines = RData.stringToLines(order.objectS);
                chbFMark.Checked = order.fmark;
                ccus = order.pcustomer;
                chbCdate.Checked = order.cdate.Equals(DateTime.MinValue);
                dtpCdate.Value = (order.cdate.Equals(DateTime.MinValue)) ? DateTime.Today : order.cdate;
                chbBdate.Checked = order.bdate.Equals(DateTime.MinValue);
                dtpBdate.Value = (order.bdate.Equals(DateTime.MinValue)) ? DateTime.Today : order.bdate;
                chbEdate.Checked = order.edate.Equals(DateTime.MinValue);
                dtpEdate.Value = (order.edate.Equals(DateTime.MinValue)) ? DateTime.Today : order.edate;
                txtEcost.Text = "" + ((order.ecost == -1) ? "" : "" + order.ecost);
                txtFcost.Text = "" + ((order.fcost == -1) ? "" : "" + order.fcost);
            }
            loadCustomers();
            success = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedItem == null)
            {
                MessageBox.Show("Не выбран заказчик.");
                return;
            }
            long pcustomer = ((EntCustomer)(cmbCustomer.SelectedItem)).pcustomer;
            DateTime edate = chbEdate.Checked ? DateTime.MinValue : (dtpEdate.Value);
            DateTime bdate = chbBdate.Checked ? DateTime.MinValue : (dtpBdate.Value);
            DateTime cdate = chbCdate.Checked ? DateTime.MinValue : (dtpCdate.Value);
            String name = txtName.Text;
            String objectS = RData.linesToString(txtObject.Lines);
            bool fmark = chbFMark.Checked;
            long ecost = -1;
            long fcost = -1;
            try
            {
                ecost = txtEcost.Text.Equals("") ? -1 : long.Parse(txtEcost.Text);
                fcost = txtFcost.Text.Equals("") ? -1 : long.Parse(txtFcost.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Значения показателя и оплаты должны быть целыми числами.\n"
                      + exc.Message);
                return;
            }

            if (EntOrder.check(pcustomer, edate, bdate, cdate, name, 
                    objectS, fmark, ecost, fcost))
                if (adding)
                {
                    try
                    {
                        order = new EntOrder(pcustomer, edate, bdate, cdate, name, 
                            objectS, fmark, ecost, fcost);
                        order.save();
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
                        order.update(pcustomer, edate, bdate, cdate, name,
                            objectS, fmark, ecost, fcost);
                        order.save();
                        success = true;
                        this.Hide();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Error:\n" + exc.Message);
                    }
                }
        }

        private void loadCustomers()
        {
            cmbCustomer.Items.Clear();
            foreach (EntCustomer cus in EntCustomer.getAll())
            {
                int cur = cmbCustomer.Items.Add(cus);
                if (cus.pcustomer == ccus)
                    cmbCustomer.SelectedIndex = cur;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void chbCdate_CheckedChanged(object sender, EventArgs e)
        {
            dtpCdate.Enabled = !chbCdate.Checked;
        }

        private void chbBdate_CheckedChanged(object sender, EventArgs e)
        {
            dtpBdate.Enabled = !chbBdate.Checked;
        }

        private void chbEdate_CheckedChanged(object sender, EventArgs e)
        {
            dtpEdate.Enabled = !chbEdate.Checked;
        }

    }
}
