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
            pictureBox1 = new PictureBox();
            PatientInfo = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            DocId = new TextBox();
            DocExp = new TextBox();
            DocName = new TextBox();
            DocPass = new TextBox();
            DoctorGV = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PatientInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DoctorGV).BeginInit();
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
            pictureBox1.Click += pictureBox1_Click;
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
            // DocId
            // 
            DocId.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DocId.Location = new Point(29, 183);
            DocId.Name = "DocId";
            DocId.Size = new Size(400, 35);
            DocId.TabIndex = 1;
            DocId.Text = "DoctorID: ";
            DocId.TextChanged += DoctorId_TextChanged;
            // 
            // DocExp
            // 
            DocExp.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DocExp.Location = new Point(29, 317);
            DocExp.Name = "DocExp";
            DocExp.Size = new Size(400, 35);
            DocExp.TabIndex = 2;
            DocExp.Text = "Years of Experience: ";
            DocExp.TextChanged += textBox1_TextChanged;
            // 
            // DocName
            // 
            DocName.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DocName.Location = new Point(29, 251);
            DocName.Name = "DocName";
            DocName.Size = new Size(400, 35);
            DocName.TabIndex = 3;
            DocName.Text = "Doctor Name: ";
            // 
            // DocPass
            // 
            DocPass.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DocPass.Location = new Point(29, 386);
            DocPass.Name = "DocPass";
            DocPass.Size = new Size(400, 35);
            DocPass.TabIndex = 4;
            DocPass.Text = "Password: ";
            DocPass.TextChanged += DocPass_TextChanged;
            // 
            // DoctorGV
            // 
            DoctorGV.BackgroundColor = SystemColors.ActiveCaption;
            DoctorGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DoctorGV.Location = new Point(468, 133);
            DoctorGV.Name = "DoctorGV";
            DoctorGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DoctorGV.Size = new Size(444, 432);
            DoctorGV.TabIndex = 5;
            DoctorGV.CellContentClick += DoctorGV_CellContentClick;
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
            button1.Click += button1_Click;
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
            button2.Click += button2_Click;
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
            button3.Click += button3_Click;
            // 
            // Doctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 597);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(DoctorGV);
            Controls.Add(DocPass);
            Controls.Add(DocName);
            Controls.Add(DocExp);
            Controls.Add(DocId);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Doctor";
            Text = "Doctor";
            Load += Doctor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PatientInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)DoctorGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox DocId;
        private TextBox DocExp;
        private TextBox DocName;
        private TextBox DocPass;
        private DataGridView DoctorGV;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox PatientInfo;
        private PictureBox pictureBox1;
    }
}