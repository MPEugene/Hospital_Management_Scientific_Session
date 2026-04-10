namespace Hospital_Management_Scientific_Session
{
    partial class DiagnosisForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosisForms));
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            DoctorId = new TextBox();
            pictureBox1 = new PictureBox();
            PatientInfo = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PatientInfo).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(29, 440);
            label3.Name = "label3";
            label3.Size = new Size(159, 24);
            label3.TabIndex = 29;
            label3.Text = "PATIENTS LIST";
            label3.Click += label3_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuHighlight;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(138, 375);
            button3.Name = "button3";
            button3.Size = new Size(99, 35);
            button3.TabIndex = 28;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(255, 375);
            button2.Name = "button2";
            button2.Size = new Size(95, 35);
            button2.TabIndex = 27;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(29, 375);
            button1.Name = "button1";
            button1.Size = new Size(91, 35);
            button1.TabIndex = 26;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 481);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(892, 204);
            dataGridView1.TabIndex = 25;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(29, 281);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(321, 29);
            textBox5.TabIndex = 24;
            textBox5.Text = "Medicines: ";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(29, 175);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(321, 30);
            comboBox1.TabIndex = 22;
            comboBox1.Text = "PatientID: ";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(29, 246);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(321, 29);
            textBox4.TabIndex = 21;
            textBox4.Text = "Symptoms: ";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(29, 316);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(321, 29);
            textBox2.TabIndex = 19;
            textBox2.Text = "Diagnosis: ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(29, 211);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 29);
            textBox1.TabIndex = 18;
            textBox1.Text = "Patient Name: ";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // DoctorId
            // 
            DoctorId.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DoctorId.Location = new Point(29, 140);
            DoctorId.Name = "DoctorId";
            DoctorId.Size = new Size(321, 29);
            DoctorId.TabIndex = 17;
            DoctorId.Text = "DiagnosisID: ";
            DoctorId.TextChanged += DoctorId_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(840, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // PatientInfo
            // 
            PatientInfo.BackColor = Color.Transparent;
            PatientInfo.Image = (Image)resources.GetObject("PatientInfo.Image");
            PatientInfo.Location = new Point(1109, 22);
            PatientInfo.Name = "PatientInfo";
            PatientInfo.Size = new Size(88, 66);
            PatientInfo.SizeMode = PictureBoxSizeMode.Zoom;
            PatientInfo.TabIndex = 9;
            PatientInfo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(29, 63);
            label2.Name = "label2";
            label2.Size = new Size(208, 41);
            label2.TabIndex = 2;
            label2.Text = "DIAGNOSIS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(29, 22);
            label1.Name = "label1";
            label1.Size = new Size(595, 41);
            label1.TabIndex = 1;
            label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(PatientInfo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(945, 114);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(365, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(556, 344);
            panel2.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(142, 10);
            label4.Name = "label4";
            label4.Size = new Size(277, 29);
            label4.TabIndex = 3;
            label4.Text = "DIAGNOSIS SUMMARY";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.InactiveCaptionText;
            label5.Location = new Point(24, 71);
            label5.Name = "label5";
            label5.Size = new Size(136, 22);
            label5.TabIndex = 4;
            label5.Text = "Patient Name ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.InactiveCaptionText;
            label6.Location = new Point(24, 176);
            label6.Name = "label6";
            label6.Size = new Size(109, 22);
            label6.TabIndex = 5;
            label6.Text = "Symptoms";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.InactiveCaptionText;
            label7.Location = new Point(195, 176);
            label7.Name = "label7";
            label7.Size = new Size(105, 22);
            label7.TabIndex = 6;
            label7.Text = "Medicines";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.InactiveCaptionText;
            label8.Location = new Point(197, 71);
            label8.Name = "label8";
            label8.Size = new Size(103, 22);
            label8.TabIndex = 7;
            label8.Text = "Diagnosis";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.InactiveCaptionText;
            label9.Location = new Point(448, 10);
            label9.Name = "label9";
            label9.Size = new Size(36, 16);
            label9.TabIndex = 8;
            label9.Text = "Date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.InactiveCaptionText;
            label10.Location = new Point(202, 320);
            label10.Name = "label10";
            label10.Size = new Size(351, 16);
            label10.TabIndex = 9;
            label10.Text = "Hospital Management Sysyem by: Eugen and Andreea";
            // 
            // DiagnosisForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 717);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox5);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(DoctorId);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DiagnosisForms";
            Text = "DiagnosisForms";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PatientInfo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox DoctorId;
        private PictureBox pictureBox1;
        private PictureBox PatientInfo;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label10;
        private Label label9;
    }
}