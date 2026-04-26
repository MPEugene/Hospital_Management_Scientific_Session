using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_Scientific_Session
{
    public partial class SplashForms : Form
    {
        public SplashForms()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            Myprogressbar.Value = startpoint;
            if (Myprogressbar.Value == 100)
            {
                Myprogressbar.Value = 0;
                timer1.Stop();
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }

        }

        private void SplashForms_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
