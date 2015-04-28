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
    public partial class frmWorkerAdding : Form
    {
        public frmWorkerAdding()
        {
            InitializeComponent();
            btnSave.Click += new EventHandler(btnSave_Click);
            btnCancel.Click += new EventHandler(btnCancel_Click);
        }

        public bool adding = true;
        public EntWorker worker = null;
        public bool success = false;

        public void init()
        {
            if (adding)
            {
                this.Text = "Добавление исполнителя";
                txtName.Text = null;
                txtContacts.Text = null;
            }
            else
            {
                this.Text = "Редактирование исполнителя";
                txtName.Text = worker.name;
                txtContacts.Lines = RData.stringToLines(worker.contacts);
            }
            success = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String cont = RData.linesToString(txtContacts.Lines);
            if (EntWorker.check(name, cont))
                if (adding)
                {
                    try
                    {
                        worker = new EntWorker(name, cont);
                        worker.save();
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
                        worker.name = name;
                        worker.contacts = cont;
                        worker.save();
                        success = true;
                        this.Hide();
                    }
                    catch (Exception exc)
                    {
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
