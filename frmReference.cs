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
            txtCustomerInfo.Lines = ((EntCustomer)lstCustomers.Items[idx]).infoLines();
            
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

            foreach (EntCustomer cust in EntCustomer.getAll())
                lstCustomers.Items.Add(cust);

            //this.Text = "" + lstCustomers.SelectedIndex;

        }

        #endregion
    }
}
