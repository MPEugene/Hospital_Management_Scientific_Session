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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Consult_Click(object sender, EventArgs e)
        {

        }

        private void patient_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 h = new Form1();
            h.Show();
        }

        private void PatientInfo_Click(object sender, EventArgs e)
        {
            PatientForm Pat = new PatientForm();
            Pat.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Doctor_Click(object sender, EventArgs e)
        {
            Doctor Doc = new Doctor();
            Doc.Show();
            this.Hide();

        }

        private void Diagnosis_Click(object sender, EventArgs e)
        {
            DiagnosisForms Diag = new DiagnosisForms();
            Diag.Show();
            this.Hide();
        }
    }
}
