using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Rennovation
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            RData.mainForm = this;
            InitializeComponent();
            RData.referenceForm = new frmReference();
            RData.clientAddingForm = new frmCustomerAdding();
            RData.worktypeAddingForm = new frmWorktypeAdding();
            RData.workerAddingForm = new frmWorkerAdding();
            RData.qualAddingForm = new frmQualAdding();

            RData.checkTables();
            RData.enableForeignKeysSupport();

            RData.referenceForm.ShowDialog();

            
            //RData.getConnection().LastInsertRowId;


        }

        public void mstReferenceClick(object sender, EventArgs e)
        {
            RData.referenceForm.ShowDialog();
        }
    }
}
