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

        List<EntCustomer> list;
        EntCustomer[] customers;

        private void frmReference_Shown(object sender, EventArgs e)
        {
            tbcTabs.SelectedTab = tabClients;
            list = EntCustomer.getAll();
            lstCustomers.Items.Clear();

            //lstCustomers.Items.AddRange(list);
            foreach (EntCustomer cust in list)
                lstCustomers.Items.Add(cust);

            //this.Text = "" + lstCustomers.SelectedIndex;
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] lines = new String[1];
            lines[0] = ((EntCustomer)lstCustomers.Items[lstCustomers.SelectedIndex]).info();
            txtCustomerInfo.Lines = lines;
            //this.Text = "" + lstCustomers.SelectedIndex;
        }
    }
}
