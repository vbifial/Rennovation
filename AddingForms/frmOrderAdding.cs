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
                ccus = -1;
            }
            else
            {
                this.Text = "Редактирование записи";
                txtName.Text = order.name;
                txtObject.Lines = RData.stringToLines(order.objectS);
                chbFMark.Checked = order.fmark;
                ccus = order.pcustomer;
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
            DateTime edate = DateTime.MinValue;
            DateTime bdate = DateTime.MinValue;
            DateTime cdate = DateTime.MinValue;
            String name = txtName.Text;
            String objectS = RData.linesToString(txtObject.Lines);
            bool fmark = chbFMark.Checked;
            long ecost = -1;
            long fcost = -1;
            //try
            //{
            //    lvalue = long.Parse(txtLValue.Text);
            //    value = long.Parse(txtValue.Text);
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show("Значения показателя и оплаты должны быть целыми числами.\n" 
            //          + exc.Message);
            //    return;
            //}
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

    }
}
