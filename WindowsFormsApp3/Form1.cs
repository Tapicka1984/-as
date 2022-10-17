using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Hide();
        }

        DateTime Start = new DateTime();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Hide();
            button2.Show();

            Start = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Show();
            button2.Hide();
            DateTime Konec = new DateTime();
            Konec = DateTime.Now;
            TimeSpan cas = Konec - Start;
            MessageBox.Show("Od startu ubehlo " + cas.Minutes + "minut " + cas.Seconds + " sekund");
            timer1.Stop();
            timer2.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
            timer2.Start();
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
            timer1.Start();
            timer2.Stop();
        }
    }
}
