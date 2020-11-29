using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WK.Libraries.HotkeyListenerNS;

namespace TheoClicker
{
    public partial class MainForm : Form
    {
        internal static HotkeyListener hotkeyListener = new HotkeyListener();
        internal static Hotkey hkStart = new Hotkey("Control+F1");
        internal static Hotkey hkStop = new Hotkey("Control+F2");

        public int count { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSeconds.Value = 1;

            hotkeyListener.Add(new[] { hkStart, hkStop });
            hotkeyListener.HotkeyPressed += Hkl_HotkeyPressed;

            mainTimer.Tick += MainTimer_Run;
            delayTimer.Tick += DelayTimer_Run;

            UpdateStatus();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            hotkeyListener.RemoveAll();
            mainTimer.Dispose();
        }

        private void DblClick_CheckChanged(object sender, EventArgs e)
        {
            txtDelay.Enabled = chkDblClick.Checked;
        } 

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopTimer();
        }

        private void StartTimer()
        {
            if (mainTimer.Enabled || txtSeconds.Value < 0.5m)
                return;

            if (DblClickEnabled())
            {
                delayTimer.Interval = (int)(txtDelay.Value * 1000);
            }


            mainTimer.Interval = (int)(txtSeconds.Value*1000);
            mainTimer.Start();
            UpdateStatus();
        }

        private bool DblClickEnabled()
        {
            return chkDblClick.Enabled && txtDelay.Value < txtSeconds.Value && txtDelay.Value > 0;
        }

        private void StopTimer()
        {
            if (!mainTimer.Enabled)
                return;

            mainTimer.Stop();
            delayTimer.Stop();
            count = 0;
            UpdateStatus();
        }

        private void MainTimer_Run(object sender, EventArgs e)
        {
            count++;
            UpdateStatus();
            DoMouseClick();
            delayTimer.Start();
        }

        private void DelayTimer_Run(object sender, EventArgs e)
        {
            DoMouseClick();
            delayTimer.Stop();
        }

        private void UpdateStatus()
        {
            string status = mainTimer.Enabled ? $"Running {count}" : "Stopped";
            lblStatus.Text = $"Status: {status}";
        }

        private void Hkl_HotkeyPressed(object sender, HotkeyEventArgs e)
        {
            if (e.Hotkey == hkStart)
                StartTimer();

            if (e.Hotkey == hkStop)
                StopTimer();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        public void DoMouseClick()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }
    }
}
