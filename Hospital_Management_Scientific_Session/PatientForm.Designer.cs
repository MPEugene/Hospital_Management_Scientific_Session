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
            label2 = new Label();
            label1 = new Label();
            DoctorId = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox5 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(945, 114);
            panel1.TabIndex = 1;
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
            // DoctorId
            // 
            DoctorId.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DoctorId.Location = new Point(29, 179);
            DoctorId.Name = "DoctorId";
            DoctorId.Size = new Size(321, 29);
            DoctorId.TabIndex = 2;
            DoctorId.Text = "PatientID: ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(29, 214);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 29);
            textBox1.TabIndex = 3;
            textBox1.Text = "Patient Name: ";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(29, 249);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(321, 29);
            textBox2.TabIndex = 4;
            textBox2.Text = "Patient Adress: ";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(29, 284);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(321, 29);
            textBox3.TabIndex = 5;
            textBox3.Text = "Patient Phone: ";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(29, 319);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(321, 29);
            textBox4.TabIndex = 6;
            textBox4.Text = "Patient Age: ";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male ", "Female" });
            comboBox1.Location = new Point(29, 378);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(321, 30);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "Gender";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "A+", "0+", "B+", "AB+", "A-", "B-", "AB-" });
            comboBox2.Location = new Point(29, 414);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(321, 30);
            comboBox2.TabIndex = 8;
            comboBox2.Text = "Blood Group";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(29, 450);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(321, 29);
            textBox5.TabIndex = 9;
            textBox5.Text = "Major Disease: ";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(385, 179);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(527, 389);
            dataGridView1.TabIndex = 10;
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
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(524, 126);
            label3.Name = "label3";
            label3.Size = new Size(264, 41);
            label3.TabIndex = 15;
            label3.Text = "PATIENTS LIST";
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 597);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox5);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(DoctorId);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PatientForm";
            Text = "PatientForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox DoctorId;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox5;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label3;
    }
}