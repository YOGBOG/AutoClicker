using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class Main : Form
    {

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        public const int MOUSEEVENTF_LEFTUP = 0x0004;
        public int min = 10;
        public int max = 20;
        public int random = 0;

        public Main()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            this.KeyUp += new KeyEventHandler(KeyEvent);
        }

        private void KeyEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                timer1.Enabled = false;
                StartButton.Text = "START";
            }
        }

        private void MouseClickLeft()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            Thread.Sleep(80);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        private int ClickRange(int minCPS, int maxCPS)
        {
            Random r = new Random();
            int rangeInt = r.Next(minCPS, maxCPS+1);
            return rangeInt;
        }

        private void StartClicking(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void MinCpsValue_Click(object sender, EventArgs e)
        {

        }

        private void MaxCpsValue_Click(object sender, EventArgs e)
        {

        }

        private void siticoneTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (siticoneTrackBar1.Value == 0)
            {
                siticoneTrackBar1.Value = 1;
            }
            else if (siticoneTrackBar1.Value > siticoneTrackBar2.Value)
            {
                siticoneTrackBar1.Value = siticoneTrackBar2.Value - 1;
            }
            else if (siticoneTrackBar1.Value == siticoneTrackBar2.Value)
            {
                siticoneTrackBar1.Value = siticoneTrackBar2.Value - 1;
            }

            min = siticoneTrackBar1.Value;

            MinCpsValue.Text = siticoneTrackBar1.Value.ToString();
        }

        private void siticoneTrackBar2_Scroll(object sender, ScrollEventArgs e)
        {
            if (siticoneTrackBar2.Value < siticoneTrackBar1.Value)
            {
                siticoneTrackBar2.Value = siticoneTrackBar1.Value + 1;
            }
            else if (siticoneTrackBar2.Value == siticoneTrackBar1.Value)
            {
                siticoneTrackBar2.Value = siticoneTrackBar1.Value + 1;
            }

            max = siticoneTrackBar2.Value;

            MaxCpsValue.Text = siticoneTrackBar2.Value.ToString();
        }

        private void Closedown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (StartButton.Text == "START")
            {
                timer1.Enabled = true;
                StartButton.Text = "STOP";
            }
            else
            {
                timer1.Enabled = false;
                StartButton.Text = "START";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            random = ClickRange(min, max);
            range.Text = random.ToString();

            for (int i = 0; i < random; i++)
            {
                MouseClickLeft();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
