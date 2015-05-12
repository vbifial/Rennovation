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

            RData.initForms();

            RData.checkTables();
            RData.enableForeignKeysSupport();

            renewOrders();

            //this.Text = "" + DateTime.Today.ToLongDateString() + " " + DateTime.Today.ToLongTimeString();

            //RData.intervalAddingForm.Show();

            //DateTime dt = DateTime.FromBinary(DateTime.Now.Ticks);
            //this.Text = "" + DateTime.FromBinary(0L).ToLongDateString();

            //this.Text = "" + DateTime.MinValue.Ticks + " " + 
            //    DateTime.MinValue.AddMilliseconds(1).Ticks;

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
            //lstOrders.Refresh();
            renewPoints();
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
                if (exc.HResult == RData.foreignCode)
                {
                    DialogResult res = MessageBox.Show("У заказа есть зависимые элементы. " +
                        "Удалить вместе с зависимостями?", "", MessageBoxButtons.YesNo);
                    if (res == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            ((EntOrder)lstOrders.SelectedItem).deleteCascade();
                            lstOrders.Items.RemoveAt(lstOrders.SelectedIndex);
                        }
                        catch (Exception exc2)
                        {
                            MessageBox.Show("Не удаётся удалить заказ.\n" +
                                exc2.Message/* + "\n" + exc.HResult*/);
                        }
                    }
                }
                else
                    MessageBox.Show("Не удаётся удалить заказ.\n" +
                        exc.Message/* + "\n" + exc.HResult*/);
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

        #region код, связанный с CRUD пунктов

        private void addPointToGrid(EntPoint point)
        {
            int idx = dgrPoints.Rows.Add();
            DataGridViewCellCollection c = dgrPoints.Rows[idx].Cells;
            c[colPoint.Index].Value = point;
            c[colAmount.Index].Value = point.amount;
            c[colDescr.Index].Value = point.descript;
            c[colWorktype.Index].Value = point.getLevel().getWorktype().name;
        }

        private void renewPoints()
        {
            dgrPoints.Rows.Clear();
            if (lstOrders.SelectedIndex != -1)
            {
                EntOrder order = (EntOrder)(lstOrders.SelectedItem);
                foreach (EntPoint point in EntPoint.getWithOrder(order.porder))
                    addPointToGrid(point);
            }
            updatePointsLayout();
        }

        private void updatePointsLayout()
        {
            btnPointAdd.Enabled = lstOrders.SelectedIndex != -1;
            btnPointDelete.Enabled = btnPointEdit.Enabled =
                dgrPoints.SelectedRows.Count != 0;
            dgrPoints.PerformLayout();
            dgrPoints.Refresh();
        }


        private void dgrPoints_SelectionChanged(object sender, EventArgs e)
        {
            //int sc = dgrPoints.SelectedRows.Count;
            //if (idx > -1)
            //    txtOrderInfo.Lines = ((EntOrder)lstOrders.Items[idx]).infoLines();
            updatePointsLayout();
        }

        private void btnPointAdd_Click(object sender, EventArgs e)
        {
            frmPointAdding frmNew = RData.pointAddingForm;
            frmNew.adding = true;
            frmNew.porder = ((EntOrder)lstOrders.SelectedItem).porder;
            frmNew.init();
            frmNew.ShowDialog();
            if (frmNew.success)
            {
                addPointToGrid(frmNew.point);
                updatePointsLayout();
            }
        }

        private void btnPointDelete_Click(object sender, EventArgs e)
        {
            int idx = dgrPoints.SelectedRows[0].Index;
            try
            {
                ((EntPoint)dgrPoints.SelectedRows[0].Cells[colPoint.Index].Value).delete();
                dgrPoints.Rows.RemoveAt(idx);
            }
            catch (Exception exc)
            {
                if (exc.HResult == RData.foreignCode)
                {
                    DialogResult res = MessageBox.Show("У пункта есть зависимые элементы. " +
                        "Удалить вместе с зависимостями?", "", MessageBoxButtons.YesNo);
                    if (res == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            ((EntPoint)dgrPoints.SelectedRows[0].Cells[colPoint.Index].Value)
                                .deleteCascade();
                            dgrPoints.Rows.RemoveAt(idx);
                        }
                        catch (Exception exc2)
                        {
                            MessageBox.Show("Не удаётся удалить пункт.\n" +
                                exc2.Message/* + "\n" + exc.HResult*/);
                        }
                    }
                }
                else
                    MessageBox.Show("Не удаётся удалить пункт.\n" +
                        exc.Message/* + "\n" + exc.HResult*/);
            }
        }

        private void btnPointEdit_Click(object sender, EventArgs e)
        {
            frmPointAdding frmEdit = RData.pointAddingForm;
            frmEdit.adding = false;
            frmEdit.point = ((EntPoint)dgrPoints.SelectedRows[0].Cells[colPoint.Index].Value);
            frmEdit.porder = ((EntOrder)lstOrders.SelectedItem).porder;
            frmEdit.init();
            frmEdit.ShowDialog();
            if (frmEdit.success)
            {
                renewPoints();
            }
        }

        #endregion



    }
}
