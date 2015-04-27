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
    public partial class frmReference : Form
    {
        public frmReference()
        {
            InitializeComponent();
        }


        private void frmReference_Shown(object sender, EventArgs e)
        {
            tbcTabs.SelectedTab = tabClients;
            renewCustomers();
        }

        #region код, связанный с клиентами

        //List<EntCustomer> listCustomers;
        //EntCustomer[] customers;

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = lstCustomers.SelectedIndex;
            txtCustomerInfo.Lines = null;
            if (idx > -1)
                txtCustomerInfo.Lines = ((EntCustomer)lstCustomers.Items[idx]).infoLines();

            updateCustomersLayout();
            //String[] lines = new String[1];
            //lines[0] = "";
            //if (idx > -1)
            //    lines[0] = ((EntCustomer)lstCustomers.Items[idx]).info();
            //txtCustomerInfo.Lines = lines;
            
            //this.Text = "" + lstCustomers.SelectedIndex;
        }

        private void renewCustomers()
        {
            //listCustomers = ;
            lstCustomers.Items.Clear();
            txtCustomerInfo.Lines = null;

            foreach (EntCustomer cust in EntCustomer.getAll())
                lstCustomers.Items.Add(cust);

            //this.Text = "" + lstCustomers.SelectedIndex;
            updateCustomersLayout();
        }

        private void updateCustomersLayout()
        {
            btnClientAdd.Enabled = true;
            btnClientDelete.Enabled = btnClientEdit.Enabled = 
                lstCustomers.SelectedIndex != -1;
            if (lstCustomers.SelectedIndex == -1)
                txtCustomerInfo.Lines = null;
            lstCustomers.PerformLayout();
            lstCustomers.Refresh();
            //lstCustomers.GetItemText(lstCustomers.SelectedItem);
            //lstCustomers.chan
        }

        private void btnClientAdd_Click(object sender, EventArgs e)
        {
            frmClientAdding frmNew = RData.clientAddingForm;
            frmNew.adding = true;
            frmNew.init();
            frmNew.ShowDialog();
            if (frmNew.success)
            {
                lstCustomers.Items.Add(frmNew.customer);
                updateCustomersLayout();
            }
        }

        private void btnClientDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ((EntCustomer)lstCustomers.SelectedItem).delete();
                lstCustomers.Items.RemoveAt(lstCustomers.SelectedIndex);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Не удаётся удалить клиента.\n" + exc.Message);
            }
        }

        private void btnClientEdit_Click(object sender, EventArgs e)
        {
            frmClientAdding frmEdit = RData.clientAddingForm;
            frmEdit.adding = false;
            frmEdit.customer = ((EntCustomer)lstCustomers.SelectedItem);
            frmEdit.init();
            frmEdit.ShowDialog();
            if (frmEdit.success)
            {
                renewCustomers();
            }
        }

        #endregion

        #region код, связанный с исполнителями

        private void btnWorkerAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnWorkerDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnWorkerEdit_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
