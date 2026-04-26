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
            MedicineTb = new TextBox();
            PatientIdCb = new ComboBox();
            SymptomsTb = new TextBox();
            DiagnosisTb = new TextBox();
            PatientTb = new TextBox();
            DiagId = new TextBox();
            pictureBox1 = new PictureBox();
            PatientInfo = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            diagsummary = new Panel();
            label10 = new Label();
            Diagnosislbl = new Label();
            medicineslbl = new Label();
            Symptomslbl = new Label();
            PatientNamelbl = new Label();
            label4 = new Label();
            DiagnosisGV = new DataGridView();
            button4 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PatientInfo).BeginInit();
            panel1.SuspendLayout();
            diagsummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DiagnosisGV).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(12, 460);
            label3.Name = "label3";
            label3.Size = new Size(175, 24);
            label3.TabIndex = 29;
            label3.Text = "DIAGNOSIS LIST";
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
            button3.Click += button3_Click;
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
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(28, 375);
            button1.Name = "button1";
            button1.Size = new Size(91, 35);
            button1.TabIndex = 26;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MedicineTb
            // 
            MedicineTb.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MedicineTb.Location = new Point(29, 281);
            MedicineTb.Name = "MedicineTb";
            MedicineTb.Size = new Size(321, 29);
            MedicineTb.TabIndex = 24;
            MedicineTb.Text = "Medicines: ";
            // 
            // PatientIdCb
            // 
            PatientIdCb.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatientIdCb.FormattingEnabled = true;
            PatientIdCb.Location = new Point(29, 175);
            PatientIdCb.Name = "PatientIdCb";
            PatientIdCb.Size = new Size(321, 30);
            PatientIdCb.TabIndex = 22;
            PatientIdCb.Text = "PatientID: ";
            PatientIdCb.SelectionChangeCommitted += PatientIdCb_SelectionChangeCommitted;
            // 
            // SymptomsTb
            // 
            SymptomsTb.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SymptomsTb.Location = new Point(29, 246);
            SymptomsTb.Name = "SymptomsTb";
            SymptomsTb.Size = new Size(321, 29);
            SymptomsTb.TabIndex = 21;
            SymptomsTb.Text = "Symptoms: ";
            // 
            // DiagnosisTb
            // 
            DiagnosisTb.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DiagnosisTb.Location = new Point(29, 316);
            DiagnosisTb.Name = "DiagnosisTb";
            DiagnosisTb.Size = new Size(321, 29);
            DiagnosisTb.TabIndex = 19;
            DiagnosisTb.Text = "Diagnosis: ";
            // 
            // PatientTb
            // 
            PatientTb.Enabled = false;
            PatientTb.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatientTb.Location = new Point(29, 211);
            PatientTb.Name = "PatientTb";
            PatientTb.Size = new Size(321, 29);
            PatientTb.TabIndex = 18;
            PatientTb.Text = "Patient Name: ";
            PatientTb.TextChanged += textBox1_TextChanged;
            // 
            // DiagId
            // 
            DiagId.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DiagId.Location = new Point(29, 140);
            DiagId.Name = "DiagId";
            DiagId.Size = new Size(321, 29);
            DiagId.TabIndex = 17;
            DiagId.Text = "DiagnosisID: ";
            DiagId.TextChanged += DoctorId_TextChanged;
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
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(PatientInfo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1092, 114);
            panel1.TabIndex = 16;
            // 
            // diagsummary
            // 
            diagsummary.Controls.Add(label10);
            diagsummary.Controls.Add(Diagnosislbl);
            diagsummary.Controls.Add(medicineslbl);
            diagsummary.Controls.Add(Symptomslbl);
            diagsummary.Controls.Add(PatientNamelbl);
            diagsummary.Controls.Add(label4);
            diagsummary.Location = new Point(365, 120);
            diagsummary.Name = "diagsummary";
            diagsummary.Size = new Size(556, 344);
            diagsummary.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.InactiveCaptionText;
            label10.Location = new Point(205, 314);
            label10.Name = "label10";
            label10.Size = new Size(348, 16);
            label10.TabIndex = 9;
            label10.Text = "Hospital Management System by: Eugen and Andreea";
            // 
            // Diagnosislbl
            // 
            Diagnosislbl.AutoSize = true;
            Diagnosislbl.BackColor = Color.Transparent;
            Diagnosislbl.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Diagnosislbl.ForeColor = SystemColors.InactiveCaptionText;
            Diagnosislbl.Location = new Point(197, 71);
            Diagnosislbl.Name = "Diagnosislbl";
            Diagnosislbl.Size = new Size(103, 22);
            Diagnosislbl.TabIndex = 7;
            Diagnosislbl.Text = "Diagnosis";
            // 
            // medicineslbl
            // 
            medicineslbl.AutoSize = true;
            medicineslbl.BackColor = Color.Transparent;
            medicineslbl.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            medicineslbl.ForeColor = SystemColors.InactiveCaptionText;
            medicineslbl.Location = new Point(195, 176);
            medicineslbl.Name = "medicineslbl";
            medicineslbl.Size = new Size(105, 22);
            medicineslbl.TabIndex = 6;
            medicineslbl.Text = "Medicines";
            // 
            // Symptomslbl
            // 
            Symptomslbl.AutoSize = true;
            Symptomslbl.BackColor = Color.Transparent;
            Symptomslbl.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Symptomslbl.ForeColor = SystemColors.InactiveCaptionText;
            Symptomslbl.Location = new Point(24, 176);
            Symptomslbl.Name = "Symptomslbl";
            Symptomslbl.Size = new Size(109, 22);
            Symptomslbl.TabIndex = 5;
            Symptomslbl.Text = "Symptoms";
            // 
            // PatientNamelbl
            // 
            PatientNamelbl.AutoSize = true;
            PatientNamelbl.BackColor = Color.Transparent;
            PatientNamelbl.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatientNamelbl.ForeColor = SystemColors.InactiveCaptionText;
            PatientNamelbl.Location = new Point(24, 71);
            PatientNamelbl.Name = "PatientNamelbl";
            PatientNamelbl.Size = new Size(136, 22);
            PatientNamelbl.TabIndex = 4;
            PatientNamelbl.Text = "Patient Name ";
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
            // DiagnosisGV
            // 
            DiagnosisGV.BackgroundColor = SystemColors.ActiveCaption;
            DiagnosisGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DiagnosisGV.Location = new Point(12, 487);
            DiagnosisGV.Name = "DiagnosisGV";
            DiagnosisGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DiagnosisGV.Size = new Size(892, 297);
            DiagnosisGV.TabIndex = 17;
            DiagnosisGV.CellContentClick += DiagnosisGV_CellContentClick;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.MenuHighlight;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(927, 458);
            button4.Name = "button4";
            button4.Size = new Size(89, 29);
            button4.TabIndex = 31;
            button4.Text = "Print";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.InactiveCaptionText;
            label5.Location = new Point(987, 22);
            label5.Name = "label5";
            label5.Size = new Size(29, 29);
            label5.TabIndex = 15;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // DiagnosisForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 779);
            Controls.Add(button4);
            Controls.Add(DiagnosisGV);
            Controls.Add(diagsummary);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(MedicineTb);
            Controls.Add(PatientIdCb);
            Controls.Add(SymptomsTb);
            Controls.Add(DiagnosisTb);
            Controls.Add(PatientTb);
            Controls.Add(DiagId);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DiagnosisForms";
            Text = "DiagnosisForms";
            Load += DiagnosisForms_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PatientInfo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            diagsummary.ResumeLayout(false);
            diagsummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DiagnosisGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox MedicineTb;
        private ComboBox PatientIdCb;
        private TextBox SymptomsTb;
        private TextBox DiagnosisTb;
        private TextBox PatientTb;
        private TextBox DiagId;
        private PictureBox pictureBox1;
        private PictureBox PatientInfo;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel diagsummary;
        private Label label4;
        private Label Diagnosislbl;
        private Label medicineslbl;
        private Label Symptomslbl;
        private Label PatientNamelbl;
        private Label label10;
        private DataGridView DiagnosisGV;
        private Button button4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label label5;
    }
}