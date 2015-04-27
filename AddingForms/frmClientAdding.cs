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

        public void init()
        {
            if (adding)
            {
                this.Text = "Добавление клиента";
            }
            else
            {
                this.Text = "Редактирование клиента";

            }
        }

    }
}
