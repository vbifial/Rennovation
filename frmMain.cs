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
using Rennovation.REntities;

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
            RData.orderAddingForm = new frmOrderAdding();

            RData.checkTables();
            RData.enableForeignKeysSupport();

            renewOrders();

            //DateTime dt = DateTime.FromBinary(DateTime.Now.Ticks);
            //this.Text = "" + DateTime.FromBinary(0L).ToLongDateString();
            //this.Text = "" + DateTime.MinValue;
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
        
        private void renewOrders()
        {
            lstOrders.Items.Clear();
            txtOrderInfo.Lines = null;
            foreach (EntOrder order in EntOrder.getAll())
                lstOrders.Items.Add(order);
            updateOrdersLayout();
        }

        private void updateOrdersLayout()
        {
            btnOrderAdd.Enabled = true;
            btnOrderDelete.Enabled = btnOrderEdit.Enabled =
                lstOrders.SelectedIndex != -1;
            if (lstOrders.SelectedIndex == -1)
            {
                txtOrderInfo.Lines = null;
            }
            lstOrders.PerformLayout();
            lstOrders.Refresh();
        }

        private void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DateTime dt = DateTime.FromBinary(DateTime.Now.Ticks);
            //this.Text = dt.ToLongTimeString();
            //this.Text = "" + DateTime.MinValue.Equals(DateTime.FromBinary(0L));
            int idx = lstOrders.SelectedIndex;
            txtOrderInfo.Lines = null;
            if (idx > -1)
                txtOrderInfo.Lines = ((EntOrder)lstOrders.Items[idx]).infoLines();
            updateOrdersLayout();
        }

        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            frmOrderAdding frmNew = RData.orderAddingForm;
            frmNew.adding = true;
            frmNew.init();
            frmNew.ShowDialog();
            if (frmNew.success)
            {
                lstOrders.Items.Add(frmNew.order);
                updateOrdersLayout();
            }
        }

        private void btnOrderDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ((EntOrder)lstOrders.SelectedItem).delete();
                lstOrders.Items.RemoveAt(lstOrders.SelectedIndex);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Не удаётся удалить заказ.\n" + exc.Message);
            }
        }

        private void btnOrderEdit_Click(object sender, EventArgs e)
        {
            frmOrderAdding frmEdit = RData.orderAddingForm;
            frmEdit.adding = false;
            frmEdit.order = ((EntOrder)lstOrders.SelectedItem);
            frmEdit.init();
            frmEdit.ShowDialog();
            if (frmEdit.success)
            {
                renewOrders();
            }
        }

        #endregion
    }
}
