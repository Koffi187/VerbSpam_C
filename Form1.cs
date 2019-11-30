using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VerbSpam
{
    public partial class Form1 : Form
    {

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        private void move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #region Form
        public Form1()
        {
            this.MouseDown += new MouseEventHandler(move_window);
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys vkey);


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                Form.ActiveForm.TopMost = true;
            }
            if (!this.checkBox1.Checked)
            {
                Form.ActiveForm.TopMost = false;
            }
        }
        #endregion
        #region Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(Keys.F1) != 0)
            {
                Sabre();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(Keys.F2) != 0)
            {
                Viser();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(Keys.F3) != 0)
            {
                Hagar();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(Keys.F4) != 0)
            {
                Doli();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(Keys.F5) != 0)
            {
                Fanta();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(Keys.F6) != 0)
            {
                Taxi();
            }
        }
        #endregion
        #region Code
        private void Sabre()
        {
            SendKeys.Send(":eq ak47");
            SendKeys.Send("{ENTER}");
            SendKeys.Send(":crier † SPAM BY VERB NVL GEN †");
            SendKeys.Send("{ENTER}");
        }

        private void Viser()
        {
            SendKeys.Send("x");
            SendKeys.Send("{enter}");
            SendKeys.Send("x");
            SendKeys.Send("{enter}");
        }

        private void Hagar()
        {
            SendKeys.Send("x");
            SendKeys.Send("{enter}");
            SendKeys.Send("x");
            SendKeys.Send("{enter}");
            SendKeys.Send("x");
            SendKeys.Send("{enter}");
            SendKeys.Send("x");
            SendKeys.Send("{enter}");
            SendKeys.Send(":doliprane");
            SendKeys.Send("{enter}");
            SendKeys.Send(":boire coca");
            SendKeys.Send("{enter}");
        }

        private void Doli()
        {
            SendKeys.Send(":doliprane");
            SendKeys.Send("{ENTER}");
            SendKeys.Send(":doliprane");
            SendKeys.Send("{ENTER}");
            SendKeys.Send(":doliprane");
            SendKeys.Send("{ENTER}");
        }

        private void Fanta()
        {
            SendKeys.Send(":boire coca");
            SendKeys.Send("{ENTER}");
            SendKeys.Send(":boire coca");
            SendKeys.Send("{ENTER}");
            SendKeys.Send(":boire coca");
            SendKeys.Send("{ENTER}");
            SendKeys.Send(":boire coca");
            SendKeys.Send("{ENTER}");
            SendKeys.Send(":boire coca");
            SendKeys.Send("{ENTER}");
            SendKeys.Send(":boire coca");
            SendKeys.Send("{ENTER}");
        }

        private void Taxi()
        {
            SendKeys.Send(":taxi ");
            SendKeys.Send(this.textBox1.Text);
            SendKeys.Send("{ENTER}");
        }
        #endregion
        #region Bouton
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int value;

            if (int.TryParse(textBox2.Text, out value))
            {
        
                if (value > 0)
                {
                    timer3.Interval = value;
                    timer1.Interval = value;
                }
            }
        }
        #endregion
    }
}
