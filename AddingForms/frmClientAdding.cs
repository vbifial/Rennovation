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
    public partial class frmClientAdding : Form
    {
        public frmClientAdding()
        {
            InitializeComponent();
        }

        public bool adding = true;
        public EntCustomer customer = null;
        public bool success = false;

        public void init()
        {
            if (adding)
            {
                this.Text = "Добавление клиента";
                txtName.Text = null;
                txtContacts.Text = null;
            }
            else
            {
                this.Text = "Редактирование клиента";
                txtName.Text = customer.name;
                txtContacts.Lines = RData.stringToLines(customer.contacts);
            }
            success = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String cont = RData.linesToString(txtContacts.Lines);
            if (EntCustomer.check(name, cont))
                if (adding)
                {
                    try
                    {
                        customer = new EntCustomer(name, cont);
                        customer.save();
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
                        customer.name = name;
                        customer.contacts = cont;
                        customer.save();
                        success = true;
                        this.Hide();
                    }
                    catch (Exception exc) {
                        MessageBox.Show("Error:\n" + exc.Message);
                    }
                }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
