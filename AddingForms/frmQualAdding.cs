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
    public partial class frmQualAdding : Form
    {
        public frmQualAdding()
        {
            InitializeComponent();
            btnSave.Click += new EventHandler(btnSave_Click);
            btnCancel.Click += new EventHandler(btnCancel_Click);
        }

        public bool adding = true;
        public EntQual qual = null;
        public bool success = false;
        public long pworktype = 0;

        public void init()
        {
            if (adding)
            {
                this.Text = "Добавление квалификации";
                txtName.Text = null;
                txtLValue.Text = null;
                txtValue.Text = null;
                qual = null;
            }
            else
            {
                this.Text = "Редактирование квалификации";
                txtName.Text = qual.name;
                txtLValue.Text = "" + qual.lvalue;
                txtValue.Text = "" + qual.value;
            }
            success = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            long lvalue = 0;
            long value = 0;
            try
            {
                lvalue = long.Parse(txtLValue.Text);
                value = long.Parse(txtValue.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Значения показателя и оплаты должны быть целыми числами.\n" + exc.Message);
                return;
            }
            if (EntQual.check((qual == null) ? -1 : qual.pqual, name, lvalue, value))
                if (adding)
                {
                    try
                    {
                        qual = new EntQual(name, lvalue, value, pworktype);
                        qual.save();
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
                        qual.name = name;
                        qual.lvalue = lvalue;
                        qual.value = value;
                        qual.save();
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
