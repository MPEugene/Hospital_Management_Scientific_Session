namespace Hospital_Management_Scientific_Session
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            DoctorId = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            PatientInfo = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PatientInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(29, 63);
            label2.Name = "label2";
            label2.Size = new Size(165, 41);
            label2.TabIndex = 2;
            label2.Text = "DOCTOR";
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
            label1.Click += label1_Click;
            // 
            // DoctorId
            // 
            DoctorId.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DoctorId.Location = new Point(29, 183);
            DoctorId.Name = "DoctorId";
            DoctorId.Size = new Size(400, 35);
            DoctorId.TabIndex = 1;
            DoctorId.Text = "DoctorID: ";
            DoctorId.TextChanged += DoctorId_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(29, 317);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 35);
            textBox1.TabIndex = 2;
            textBox1.Text = "Years of Experience: ";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(29, 251);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(400, 35);
            textBox2.TabIndex = 3;
            textBox2.Text = "Doctor Name: ";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(29, 386);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(400, 35);
            textBox3.TabIndex = 4;
            textBox3.Text = "Password: ";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(468, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(444, 432);
            dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(29, 440);
            button1.Name = "button1";
            button1.Size = new Size(107, 49);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(171, 440);
            button2.Name = "button2";
            button2.Size = new Size(111, 49);
            button2.TabIndex = 7;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuHighlight;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(324, 440);
            button3.Name = "button3";
            button3.Size = new Size(105, 49);
            button3.TabIndex = 8;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(840, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Doctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 597);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(DoctorId);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Doctor";
            Text = "Doctor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PatientInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox DoctorId;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox PatientInfo;
        private PictureBox pictureBox1;
    }
}