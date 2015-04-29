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
    public partial class frmLevelAdding : Form
    {
        public frmLevelAdding()
        {
            InitializeComponent();
            btnSave.Click += new EventHandler(btnSave_Click);
            btnCancel.Click += new EventHandler(btnCancel_Click);
        }

        public bool adding = true;
        public EntLevel level = null;
        public bool success = false;
        public long pworktype = 0;

        public void init()
        {
            if (adding)
            {
                this.Text = "Добавление уровня";
                txtName.Text = null;
                txtValue.Text = null;
            }
            else
            {
                this.Text = "Редактирование уровня";
                txtName.Text = level.name;
                txtValue.Text = "" + level.value;
            }
            success = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            long value = 0;
            try
            {
                value = long.Parse(txtValue.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Значения показателя и оплаты должны быть целыми числами.\n" + exc.Message);
                return;
            }
            if (EntLevel.check(name, value))
                if (adding)
                {
                    try
                    {
                        level = new EntLevel(name, value, pworktype);
                        level.save();
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
                        level.name = name;
                        level.value = value;
                        level.save();
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
