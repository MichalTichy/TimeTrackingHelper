using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTrackingHelper
{
    public partial class TimeTrackingHelper : Form
    {
        private Session session;
        private CurrentStatus currentStatusForm;
        public TimeTrackingHelper()
        {
            InitializeComponent();
            Reset();
        }

        private void UpdateUi()
        {
            if (session == null)
                Reset();

            lStatus.Text = session.CurrentStatus.ToText();
            lStatus.ForeColor = session.CurrentStatus.GetColor();

            lWStarted.Text = session.Parts.Any() ? session.Parts.First().Start.ToText() : "";
            lEfficiency.Text = $@"{(int) session.Efficiency}%";
            lTotalTime.Text = session.TotalTime.ToText();
            lTotalWorkTime.Text = session.TotalWorkingTime.ToText();
            lTotelRestTime.Text = session.TotalWorkingTime.ToText();
            lAwerageWorkLenght.Text = session.AverageWorkTime.ToText();
            lAwerageRestLenght.Text = session.AverageRestTime.ToText();

            lCurrentRestTime.Text = session.CurrentStatus==SessionStatus.Resting ?session.CurrentSessionPart.Length.ToText() : "";

            butPauseControl.ForeColor = session.CurrentStatus.GetColor();
            butPauseControl.Visible = session.CurrentStatus != SessionStatus.Stopped;
            butPauseControl.Text = session.CurrentStatus == SessionStatus.Resting ? "end pause" : "start pause";

            butWorkControl.Text = session.CurrentStatus == SessionStatus.Stopped ? "START" : "END";
        }

        public void UpdateTable()
        {
            listView.Items.Clear();
            listView.Items.AddRange(session.Parts.Select(t=>t.ToListViewItem()).ToArray());
            Update();
        }

        private void Reset()
        {
            session=new Session();
            UpdateUi();
        }

        private void TimeTrackingHelper_SizeChanged(object sender, EventArgs e)
        {
            timerUIUpdate.Enabled = WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized ||
                                    currentStatusForm.WindowState ==FormWindowState.Normal || currentStatusForm.WindowState==FormWindowState.Maximized;
        }

        private void butWorkControl_Click(object sender, EventArgs e)
        {
            if (session == null)
                Reset();

            if (session.CurrentStatus == SessionStatus.Stopped)
            {
                session = new Session();
                session.StartSessionPart(SessionPartType.Work);
                currentStatusForm=new CurrentStatus(session);
                currentStatusForm.Show();
            }
            else
            {
                session.EndSession();
                currentStatusForm.Close();
            }


            UpdateTable();

        }

        private void butPauseControl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            session.StartSessionPart(session.CurrentStatus == SessionStatus.Working
                ? SessionPartType.Rest
                : SessionPartType.Work);
        }

        private void timerUIUpdate_Tick(object sender, EventArgs e)
        {
            UpdateUi();
            UpdateTable();
            currentStatusForm?.UpdateStatus();
        }

        private void TimeTrackingHelper_Shown(object sender, EventArgs e)
        {
            timerUIUpdate.Start();
            session = IOManager.LoadLastSession();
        }
    }
}
