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
            RData.levelAddingForm = new frmLevelAdding();
            RData.specialAddingForm = new frmSpecialAdding();

            RData.checkTables();
            RData.enableForeignKeysSupport();

            //DateTime dt = DateTime.FromBinary(DateTime.Now.Ticks);
            //this.Text = dt.ToLongTimeString();
            //RData.referenceForm.ShowDialog();

            
            //RData.getConnection().LastInsertRowId;


        }

        #region код, связанный с функционированием меню

        public void mstReferenceClick(object sender, EventArgs e)
        {
            RData.referenceForm.ShowDialog();
        }

        #endregion

        #region код, связанный с CRUD заказов

        private void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.FromBinary(DateTime.Now.Ticks);
            this.Text = dt.ToLongTimeString();
            //this.Text = "" + DateTime.MinValue.Equals(DateTime.FromBinary(0L));

        }

        private void btnOrderAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderEdit_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
