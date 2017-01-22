using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTrackingHelper
{
    public partial class CurrentStatus : Form
    {
        private readonly Session currentSession;
        
        public CurrentStatus(Session currentSession)
        {
            InitializeComponent();
            this.currentSession = currentSession;
        }

        public void UpdateStatus()
        {
            butChangeStatus.BackColor = currentSession.CurrentStatus.GetColor();
            labRestLength.ForeColor = currentSession.CurrentStatus.GetColor();
            if (currentSession.CurrentStatus==SessionStatus.Resting)
            {
                Size=new Size(300,20);
                labRestLength.Text = currentSession.CurrentSessionPart.Length.ToText();
            }
            else
            {
                Size=new Size(20,20);
                labRestLength.Text = "";
            }
            Update();
        }

        private void butChangeStatus_Click(object sender, EventArgs e)
        {
            currentSession.StartSessionPart(currentSession.CurrentStatus == SessionStatus.Working
                ? SessionPartType.Rest
                : SessionPartType.Work);
            UpdateStatus();
        }

        //This ensures that window will be allways on top
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private void CurrentStatus_Load(object sender, EventArgs e)
        {
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            UpdateStatus();
        }
    }
}
