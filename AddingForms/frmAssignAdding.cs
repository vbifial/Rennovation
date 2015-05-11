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
    public partial class frmAssignAdding : Form
    {
        public frmAssignAdding()
        {
            InitializeComponent();
            btnSave.Click += new EventHandler(btnSave_Click);
            btnCancel.Click += new EventHandler(btnCancel_Click);
            AcceptButton = btnSave;
            CancelButton = btnCancel;
            //dgrIntervals.Rows.Add();
        }

        public bool adding = true;
        public EntAssign assign = null;
        public bool success = false;
        public long ppoint = -1;


        EntWorker cworker = null;
        long cwk = -1;


        private void frmAssignAdding_Shown(object sender, EventArgs e)
        {
            if (cmbWorker.Items.Count == 0)
            {
                MessageBox.Show("Нет свободных работников, обладающих необходимой квалификацией.");
                this.Hide();
            }
        }


        #region код, связанный с добавлением назначений

        public void init()
        {
            if (adding)
            {
                this.Text = "Добавление записи";
                txtAmount.Text = "";
                assign = null;
                cwk = -1;
            }
            else
            {
                this.Text = "Редактирование записи";
                cworker = assign.getWorker();
                cwk = cworker.pworker;
                txtAmount.Text = "" + assign.amount;
                //this.Text = "" + cwt + " " + cql + " " + csp;
            }
            loadWorkers();
            reloadIntervals();
            success = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tryToSave())
            {
                success = true;
                this.Hide();
            }
        }

        private bool saved()
        {
            if (!adding)
                return true;

            if (tryToSave())
                return true;

            return false;
        }

        private bool tryToSave()
        {

            if (cmbWorker.SelectedItem == null)
            {
                MessageBox.Show("Не выбран работник.");
                return false;
            }
            long pworker = ((EntWorker)(cmbWorker.SelectedItem)).pworker;
            long amount = -1;
            try
            {
                amount = long.Parse(txtAmount.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Значение объема должно быть целым числом. " + exc.Message);
                return false;
            }
            if (EntAssign.check(ppoint, pworker, amount))
                if (adding)
                {
                    try
                    {
                        assign = new EntAssign(ppoint, pworker, amount);
                        assign.save();
                        success = true;
                        adding = false;
                        return true;
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
                        assign.update(ppoint, pworker, amount);
                        assign.save();
                        success = true;
                        adding = false;
                        return true;
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Error:\n" + exc.Message);
                    }
                }


            return false;
        }

        private void loadWorkers()
        {
            cmbWorker.Items.Clear();
            foreach (EntWorker w in EntWorker.getForPoint(ppoint))
            {
                int cur = cmbWorker.Items.Add(w);
                if (w.pworker == cwk)
                    cmbWorker.SelectedIndex = cur;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion

        #region код, связанный с интервалами

        private void addIntervalToGrid(EntInterval inter) {
            int rid = dgrIntervals.Rows.Add();
            DataGridViewCellCollection c = dgrIntervals.Rows[rid].Cells;
            c[colInterval.Index].Value = inter;
            bool e = !inter.edate.Equals(DateTime.MinValue);
            bool f = !inter.fdate.Equals(DateTime.MinValue);
            c[colEdate.Index].Value = e ? inter.edate.ToShortDateString() : "n/a";
            c[colFdate.Index].Value = f ? inter.fdate.ToShortDateString() : "n/a";
            c[colEstime.Index].Value = e ? "" + inter.estime : "";
            c[colEetime.Index].Value = e ? "" + inter.eetime : "";
            c[colFstime.Index].Value = f ? "" + inter.fstime : "";
            c[colFetime.Index].Value = f ? "" + inter.fetime : "";
            c[colMark.Index].Value = inter.emark;
        }

        private void reloadIntervals()
        {
            dgrIntervals.Rows.Clear();
            if (assign != null)
            {
                foreach (EntInterval inter in EntInterval.getWithAssign(assign.passign))
                {
                    addIntervalToGrid(inter);
                }
            }
            updateIntervalsLayout();
        }

        private void updateIntervalsLayout()
        {
            btnIntervalAdd.Enabled = true;
            btnIntervalDelete.Enabled = btnIntervalEdit.Enabled =
                dgrIntervals.SelectedRows.Count != 0;
            cmbWorker.Enabled =
                dgrIntervals.Rows.Count == 0;
            dgrIntervals.PerformLayout();
            dgrIntervals.Refresh();
        }

        private void dgrIntervals_SelectionChanged(object sender, EventArgs e)
        {
            updateIntervalsLayout();
        }

        private void btnIntervalAdd_Click(object sender, EventArgs e)
        {
            if (saved())
            {
                frmIntervalAdding frmNew = RData.intervalAddingForm;
                frmNew.adding = true;
                frmNew.passign = assign.passign;
                frmNew.init();
                frmNew.ShowDialog();
                if (frmNew.success)
                {
                    addIntervalToGrid(frmNew.interval);
                    updateIntervalsLayout();
                }
            }
        }

        private void btnIntervalEdit_Click(object sender, EventArgs e)
        {
            frmIntervalAdding frmEdit = RData.intervalAddingForm;
            frmEdit.adding = false;
            frmEdit.interval = (EntInterval)(dgrIntervals.SelectedRows[0].Cells[colInterval.Index].Value);
            frmEdit.passign = assign.passign;
            frmEdit.init();
            frmEdit.ShowDialog();
            if (frmEdit.success)
            {
                reloadIntervals();
            }
        }

        private void btnIntervalDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int idx = dgrIntervals.SelectedRows[0].Index;
                ((EntInterval)dgrIntervals.SelectedRows[0].Cells[colInterval.Index].Value).delete();
                dgrIntervals.Rows.RemoveAt(idx);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Не удаётся удалить пункт.\n" + exc.Message);
            }
        }

        #endregion

    }
}
