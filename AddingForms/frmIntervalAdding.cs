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
    public partial class frmIntervalAdding : Form
    {
        public frmIntervalAdding()
        {
            InitializeComponent();
            fpanels = createPanels(grbFact);
            epanels = createPanels(grbPlan);
            btnSave.Click += new EventHandler(btnSave_Click);
            btnCancel.Click += new EventHandler(btnCancel_Click);
            AcceptButton = btnSave;
            CancelButton = btnCancel;

        }

        public bool adding = true;
        public EntInterval interval = null;
        public bool success = false;
        public long passign = -1;


        #region код, связанный с добавлением интервала

        public void init()
        {
            txtEstime.Text = "";
            txtEetime.Text = "";
            dtpEdate.Value = DateTime.Today;
            chbEdate.Checked = true;

            txtFstime.Text = "";
            txtFetime.Text = "";
            dtpFdate.Value = DateTime.Today;
            chbFdate.Checked = true;
            chbMark.Checked = false;

            if (adding)
            {
                this.Text = "Добавление записи";
                interval = null;
            }
            else
            {
                this.Text = "Редактирование записи";
                chbMark.Checked = interval.emark;

                if (!interval.edate.Equals(DateTime.MinValue))
                {
                    txtEstime.Text = "" + interval.estime;
                    txtEetime.Text = "" + interval.eetime;
                    dtpEdate.Value = interval.edate;
                    chbEdate.Checked = false;
                }

                if (!interval.fdate.Equals(DateTime.MinValue))
                {
                    txtFstime.Text = "" + interval.fstime;
                    txtFetime.Text = "" + interval.fetime;
                    dtpFdate.Value = interval.fdate;
                    chbFdate.Checked = false;
                }

            }
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
            DateTime edate = chbEdate.Checked ? DateTime.MinValue : (dtpEdate.Value);
            DateTime fdate = chbFdate.Checked ? DateTime.MinValue : (dtpFdate.Value);
            long estime = -1;
            long eetime = -1;
            long fstime = -1;
            long fetime = -1;
            bool emark = chbMark.Checked;
            try
            {
                estime = chbEdate.Checked ? -1 : long.Parse(txtEstime.Text);
                eetime = chbEdate.Checked ? -1 : long.Parse(txtEetime.Text);
                fstime = chbFdate.Checked ? -1 : long.Parse(txtFstime.Text);
                fetime = chbFdate.Checked ? -1 : long.Parse(txtFetime.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Значения времени должны быть указаны целым количеством часов.\n" + 
                    exc.Message);
                return false;
            }
            if (EntInterval.check(passign, edate, fdate, emark, estime, eetime, fstime, fetime))
                if (adding)
                {
                    try
                    {
                        interval = new EntInterval(passign, edate, fdate, estime, eetime, 
                            fstime, fetime, emark);
                        interval.save();
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
                        interval.update(passign, edate, fdate, emark, estime, eetime,
                            fstime, fetime);
                        interval.save();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void chbEdate_CheckedChanged(object sender, EventArgs e)
        {
            dtpEdate.Enabled = txtEetime.Enabled = txtEstime.Enabled = !chbEdate.Checked;
        }

        private void chbFdate_CheckedChanged(object sender, EventArgs e)
        {
            dtpFdate.Enabled = txtFetime.Enabled = txtFstime.Enabled = !chbFdate.Checked;
        }

        #endregion

        #region panels code

        Panel[] fpanels;
        Panel[] epanels;
        int starthour = RData.startHour;
        int hours = RData.hoursCnt;
        int panelInterval = 6;

        Panel[] createPanels(GroupBox cgrb)
        {
            Panel[] panels;
            int gwidth = cgrb.ClientSize.Width;
            int gheight = cgrb.ClientSize.Height;

            int panelWidth = (gwidth - panelInterval * (hours + 1)) / hours;
            //this.Text = "" + panelWidth;
            panels = new Panel[hours];

            for (int i = 0; i < hours; i++)
            {
                Panel cpan = panels[i] = new Panel();
                cpan.SuspendLayout();
                cgrb.Controls.Add(cpan);
                cpan.Location = new Point(panelInterval * (i + 1) + panelWidth * i, 
                    gheight - panelInterval - panelWidth);
                cpan.Size = new Size(panelWidth, panelWidth);
                cpan.BackColor = Color.White;

                Label clab = new Label();
                clab.SuspendLayout();
                cpan.Controls.Add(clab);
                clab.Location = new Point(3, 3);
                clab.Text = "" + (starthour + i);

                clab.ResumeLayout(false);
                clab.PerformLayout();
                cpan.ResumeLayout(false);
                cpan.PerformLayout();
            }

            return panels;
        }

        #endregion




    }
}
