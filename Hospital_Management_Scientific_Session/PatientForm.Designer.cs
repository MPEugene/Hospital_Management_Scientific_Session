namespace Hospital_Management_Scientific_Session
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            PatId = new TextBox();
            PatName = new TextBox();
            PatAd = new TextBox();
            PatPhone = new TextBox();
            PatAge = new TextBox();
            GenderCb = new ComboBox();
            BloodCb = new ComboBox();
            MajorTb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            PatientGV = new DataGridView();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PatientGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1236, 114);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1081, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(29, 63);
            label2.Name = "label2";
            label2.Size = new Size(157, 41);
            label2.TabIndex = 2;
            label2.Text = "PATIENT";
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
            // PatId
            // 
            PatId.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatId.Location = new Point(29, 179);
            PatId.Name = "PatId";
            PatId.Size = new Size(321, 29);
            PatId.TabIndex = 2;
            PatId.Text = "PatientID: ";
            // 
            // PatName
            // 
            PatName.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatName.Location = new Point(29, 214);
            PatName.Name = "PatName";
            PatName.Size = new Size(321, 29);
            PatName.TabIndex = 3;
            PatName.Text = "Patient Name: ";
            // 
            // PatAd
            // 
            PatAd.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatAd.Location = new Point(29, 249);
            PatAd.Name = "PatAd";
            PatAd.Size = new Size(321, 29);
            PatAd.TabIndex = 4;
            PatAd.Text = "Patient Adress: ";
            // 
            // PatPhone
            // 
            PatPhone.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatPhone.Location = new Point(29, 284);
            PatPhone.Name = "PatPhone";
            PatPhone.Size = new Size(321, 29);
            PatPhone.TabIndex = 5;
            PatPhone.Text = "Patient Phone: ";
            // 
            // PatAge
            // 
            PatAge.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatAge.Location = new Point(29, 319);
            PatAge.Name = "PatAge";
            PatAge.Size = new Size(321, 29);
            PatAge.TabIndex = 6;
            PatAge.Text = "Patient Age: ";
            PatAge.TextChanged += textBox4_TextChanged;
            // 
            // GenderCb
            // 
            GenderCb.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenderCb.FormattingEnabled = true;
            GenderCb.Items.AddRange(new object[] { "Male ", "Female" });
            GenderCb.Location = new Point(29, 378);
            GenderCb.Name = "GenderCb";
            GenderCb.Size = new Size(321, 30);
            GenderCb.TabIndex = 7;
            GenderCb.Text = "Gender";
            GenderCb.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // BloodCb
            // 
            BloodCb.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BloodCb.FormattingEnabled = true;
            BloodCb.Items.AddRange(new object[] { "A+", "0+", "B+", "AB+", "A-", "B-", "AB-" });
            BloodCb.Location = new Point(29, 414);
            BloodCb.Name = "BloodCb";
            BloodCb.Size = new Size(321, 30);
            BloodCb.TabIndex = 8;
            BloodCb.Text = "Blood Group";
            // 
            // MajorTb
            // 
            MajorTb.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MajorTb.Location = new Point(29, 450);
            MajorTb.Name = "MajorTb";
            MajorTb.Size = new Size(321, 29);
            MajorTb.TabIndex = 9;
            MajorTb.Text = "Major Disease: ";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(29, 501);
            button1.Name = "button1";
            button1.Size = new Size(91, 35);
            button1.TabIndex = 11;
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
            button2.Location = new Point(255, 501);
            button2.Name = "button2";
            button2.Size = new Size(95, 35);
            button2.TabIndex = 12;
            button2.Text = "Delete";
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
            button3.Location = new Point(139, 501);
            button3.Name = "button3";
            button3.Size = new Size(91, 35);
            button3.TabIndex = 13;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(714, 126);
            label3.Name = "label3";
            label3.Size = new Size(264, 41);
            label3.TabIndex = 15;
            label3.Text = "PATIENTS LIST";
            // 
            // PatientGV
            // 
            PatientGV.BackgroundColor = SystemColors.ActiveCaption;
            PatientGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PatientGV.Location = new Point(370, 170);
            PatientGV.Name = "PatientGV";
            PatientGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PatientGV.Size = new Size(843, 519);
            PatientGV.TabIndex = 16;
            PatientGV.CellContentClick += PatientGV_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.InactiveCaptionText;
            label5.Location = new Point(1204, 9);
            label5.Name = "label5";
            label5.Size = new Size(29, 29);
            label5.TabIndex = 17;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 774);
            Controls.Add(PatientGV);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(MajorTb);
            Controls.Add(BloodCb);
            Controls.Add(GenderCb);
            Controls.Add(PatAge);
            Controls.Add(PatPhone);
            Controls.Add(PatAd);
            Controls.Add(PatName);
            Controls.Add(PatId);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PatientForm";
            Text = "PatientForm";
            Load += PatientForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PatientGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox PatId;
        private TextBox PatName;
        private TextBox PatAd;
        private TextBox PatPhone;
        private TextBox PatAge;
        private ComboBox GenderCb;
        private ComboBox BloodCb;
        private TextBox MajorTb;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label3;
        private DataGridView PatientGV;
        private Label label5;
    }
}