namespace Hospital_Management_Scientific_Session
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            Doctor = new PictureBox();
            DoctorLabel = new Label();
            PatientLabel = new Label();
            PatientInfo = new PictureBox();
            DiagnosisLabel = new Label();
            Diagnosis = new PictureBox();
            LogOut = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)Doctor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PatientInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Diagnosis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogOut).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(32, 50);
            label1.Name = "label1";
            label1.Size = new Size(421, 29);
            label1.TabIndex = 0;
            label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // Doctor
            // 
            Doctor.BackColor = Color.Transparent;
            Doctor.Image = Properties.Resources.doctor_svgrepo_com;
            Doctor.Location = new Point(45, 148);
            Doctor.Name = "Doctor";
            Doctor.Size = new Size(100, 97);
            Doctor.SizeMode = PictureBoxSizeMode.Zoom;
            Doctor.TabIndex = 1;
            Doctor.TabStop = false;
            Doctor.Click += Doctor_Click;
            // 
            // DoctorLabel
            // 
            DoctorLabel.AutoSize = true;
            DoctorLabel.BackColor = Color.Transparent;
            DoctorLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DoctorLabel.Location = new Point(57, 248);
            DoctorLabel.Name = "DoctorLabel";
            DoctorLabel.Size = new Size(73, 22);
            DoctorLabel.TabIndex = 2;
            DoctorLabel.Text = "Doctor";
            DoctorLabel.Click += label2_Click;
            // 
            // PatientLabel
            // 
            PatientLabel.AutoSize = true;
            PatientLabel.BackColor = Color.Transparent;
            PatientLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatientLabel.Location = new Point(324, 248);
            PatientLabel.Name = "PatientLabel";
            PatientLabel.Size = new Size(74, 22);
            PatientLabel.TabIndex = 3;
            PatientLabel.Text = "Patient";
            PatientLabel.Click += patient_Click;
            // 
            // PatientInfo
            // 
            PatientInfo.BackColor = Color.Transparent;
            PatientInfo.Image = (Image)resources.GetObject("PatientInfo.Image");
            PatientInfo.Location = new Point(311, 149);
            PatientInfo.Name = "PatientInfo";
            PatientInfo.Size = new Size(100, 96);
            PatientInfo.SizeMode = PictureBoxSizeMode.Zoom;
            PatientInfo.TabIndex = 4;
            PatientInfo.TabStop = false;
            PatientInfo.Click += PatientInfo_Click;
            // 
            // DiagnosisLabel
            // 
            DiagnosisLabel.AutoSize = true;
            DiagnosisLabel.BackColor = Color.Transparent;
            DiagnosisLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DiagnosisLabel.Location = new Point(183, 390);
            DiagnosisLabel.Name = "DiagnosisLabel";
            DiagnosisLabel.Size = new Size(103, 22);
            DiagnosisLabel.TabIndex = 5;
            DiagnosisLabel.Text = "Diagnosis";
            DiagnosisLabel.Click += Consult_Click;
            // 
            // Diagnosis
            // 
            Diagnosis.BackColor = Color.Transparent;
            Diagnosis.Image = (Image)resources.GetObject("Diagnosis.Image");
            Diagnosis.Location = new Point(186, 285);
            Diagnosis.Name = "Diagnosis";
            Diagnosis.Size = new Size(100, 102);
            Diagnosis.SizeMode = PictureBoxSizeMode.Zoom;
            Diagnosis.TabIndex = 6;
            Diagnosis.TabStop = false;
            Diagnosis.Click += Diagnosis_Click;
            // 
            // LogOut
            // 
            LogOut.BackColor = Color.Transparent;
            LogOut.Image = (Image)resources.GetObject("LogOut.Image");
            LogOut.Location = new Point(45, 455);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(45, 57);
            LogOut.SizeMode = PictureBoxSizeMode.Zoom;
            LogOut.TabIndex = 7;
            LogOut.TabStop = false;
            LogOut.Click += pictureBox3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.InactiveCaptionText;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(29, 29);
            label5.TabIndex = 16;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_ld222kld222kld221;
            ClientSize = new Size(972, 548);
            Controls.Add(label5);
            Controls.Add(LogOut);
            Controls.Add(Diagnosis);
            Controls.Add(DiagnosisLabel);
            Controls.Add(PatientInfo);
            Controls.Add(PatientLabel);
            Controls.Add(DoctorLabel);
            Controls.Add(Doctor);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)Doctor).EndInit();
            ((System.ComponentModel.ISupportInitialize)PatientInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)Diagnosis).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox Doctor;
        private Label DoctorLabel;
        private Label PatientLabel;
        private PictureBox PatientInfo;
        private Label DiagnosisLabel;
        private PictureBox Diagnosis;
        private PictureBox LogOut;
        private Label label5;
    }
}