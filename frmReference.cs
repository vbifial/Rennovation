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
            /*
            btnWorkerAdd.Click += new EventHandler(btnWorkerAdd_Click);
            btnWorkerEdit.Click += new EventHandler(btnWorkerEdit_Click);
            btnWorkerDelete.Click += new EventHandler(btnWorkerDelete_Click);
             * */
        }


        private void frmReference_Shown(object sender, EventArgs e)
        {
            tbcTabs.SelectedTab = tabWorktypes;
            renewAll();
        }

        private void renewAll()
        {
            renewCustomers();
            renewWorktypes();
            renewWorkers();
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
            btnCustomerAdd.Enabled = true;
            btnCustomerDelete.Enabled = btnCustomerEdit.Enabled = 
                lstCustomers.SelectedIndex != -1;
            if (lstCustomers.SelectedIndex == -1)
                txtCustomerInfo.Lines = null;
            lstCustomers.PerformLayout();
            lstCustomers.Refresh();
        }

        private void btnClientAdd_Click(object sender, EventArgs e)
        {
            frmCustomerAdding frmNew = RData.clientAddingForm;
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
            frmCustomerAdding frmEdit = RData.clientAddingForm;
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

        #region код, связанный с работами

        private void renewWorktypes()
        {
            lstWorktypes.Items.Clear();
            foreach (EntWorktype wktp in EntWorktype.getAll())
                lstWorktypes.Items.Add(wktp);
            updateWorktypesLayout();
        }

        private void updateWorktypesLayout()
        {
            btnWorktypeAdd.Enabled = true;
            btnWorktypeDelete.Enabled = btnWorktypeEdit.Enabled =
                lstWorktypes.SelectedIndex != -1;
            lstWorktypes.PerformLayout();
            lstWorktypes.Refresh();
        }

        private void lstWorktypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = lstWorktypes.SelectedIndex;
            if (idx > -1)
            {
                // todo ////////////////////////////////////////////////////////////////////
            }

            updateWorktypesLayout();

        }

        private void btnWorktypeAdd_Click(object sender, EventArgs e)
        {
            
            frmWorktypeAdding frmNew = RData.worktypeAddingForm;
            frmNew.adding = true;
            frmNew.init();
            frmNew.ShowDialog();
            if (frmNew.success)
            {
                lstWorktypes.Items.Add(frmNew.worktype);
                updateWorktypesLayout();
            }
            
        }

        private void btnWorktypeDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ((EntWorktype)lstWorktypes.SelectedItem).delete();
                lstWorktypes.Items.RemoveAt(lstWorktypes.SelectedIndex);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Не удаётся удалить клиента.\n" + exc.Message);
            }

        }

        private void btnWorktypeEdit_Click(object sender, EventArgs e)
        {
            
            frmWorktypeAdding frmEdit = RData.worktypeAddingForm;
            frmEdit.adding = false;
            frmEdit.worktype = ((EntWorktype)lstWorktypes.SelectedItem);
            frmEdit.init();
            frmEdit.ShowDialog();
            if (frmEdit.success)
            {
                renewWorktypes();
            }
            
        }


        #endregion

        #region код, связанный с исполнителями


        private void renewWorkers()
        {
            lstWorkers.Items.Clear();
            txtWorkerInfo.Lines = null;
            foreach (EntWorker worker in EntWorker.getAll())
                lstWorkers.Items.Add(worker);
            updateWorkersLayout();
        }

        private void updateWorkersLayout()
        {
            btnWorkerAdd.Enabled = true;
            btnWorkerDelete.Enabled = btnWorkerEdit.Enabled =
                lstWorkers.SelectedIndex != -1;
            if (lstWorkers.SelectedIndex == -1)
                txtWorkerInfo.Lines = null;
            lstWorkers.PerformLayout();
            lstWorkers.Refresh();
        }

        private void lstWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = lstWorkers.SelectedIndex;
            txtWorkerInfo.Lines = null;
            if (idx > -1)
                txtWorkerInfo.Lines = ((EntWorker)lstWorkers.Items[idx]).infoLines();
            updateWorkersLayout();
        }

        private void btnWorkerAdd_Click(object sender, EventArgs e)
        {
            frmWorkerAdding frmNew = RData.workerAddingForm;
            frmNew.adding = true;
            frmNew.init();
            frmNew.ShowDialog();
            if (frmNew.success)
            {
                lstWorkers.Items.Add(frmNew.worker);
                updateWorkersLayout();
            }
        }

        private void btnWorkerDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ((EntWorker)lstWorkers.SelectedItem).delete();
                lstWorkers.Items.RemoveAt(lstWorkers.SelectedIndex);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Не удаётся удалить клиента.\n" + exc.Message);
            }
        }

        private void btnWorkerEdit_Click(object sender, EventArgs e)
        {
            frmWorkerAdding frmEdit = RData.workerAddingForm;
            frmEdit.adding = false;
            frmEdit.worker = ((EntWorker)lstWorkers.SelectedItem);
            frmEdit.init();
            frmEdit.ShowDialog();
            if (frmEdit.success)
            {
                renewWorkers();
            }
        }

        #endregion


    }
}
