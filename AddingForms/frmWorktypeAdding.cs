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
    public partial class frmWorktypeAdding : Form
    {
        public frmWorktypeAdding()
        {
            InitializeComponent();
        }

        public bool adding = true;
        public EntWorktype worktype = null;
        public bool success = false;

        public void init()
        {
            if (adding)
            {
                this.Text = "Добавление типа работы";
                txtName.Text = null;
            }
            else
            {
                this.Text = "Редактирование типа работы";
                txtName.Text = worktype.name;
            }
            success = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            if (EntWorktype.check(name))
                if (adding)
                {
                    try
                    {
                        worktype = new EntWorktype(name);
                        worktype.save();
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
                        worktype.name = name;
                        worktype.save();
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
