namespace Hospital_Management_Scientific_Session
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            LoginButton = new Button();
            DocNameTb = new TextBox();
            PassTb = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 82);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(102, 27);
            label1.Name = "label1";
            label1.Size = new Size(80, 34);
            label1.TabIndex = 0;
            label1.Text = "HMS";
            label1.Click += label1_Click;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = SystemColors.Highlight;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = SystemColors.ButtonFace;
            LoginButton.Location = new Point(48, 254);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(202, 44);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // DocNameTb
            // 
            DocNameTb.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DocNameTb.ForeColor = SystemColors.InfoText;
            DocNameTb.Location = new Point(47, 117);
            DocNameTb.Name = "DocNameTb";
            DocNameTb.Size = new Size(202, 29);
            DocNameTb.TabIndex = 3;
            DocNameTb.Text = "DocName: ";
            DocNameTb.TextChanged += textBox2_TextChanged;
            // 
            // PassTb
            // 
            PassTb.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PassTb.ForeColor = SystemColors.InfoText;
            PassTb.Location = new Point(47, 188);
            PassTb.Name = "PassTb";
            PassTb.Size = new Size(202, 29);
            PassTb.TabIndex = 4;
            PassTb.Text = "DocPassword: ";
            PassTb.UseSystemPasswordChar = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(120, 316);
            label2.Name = "label2";
            label2.Size = new Size(62, 24);
            label2.TabIndex = 5;
            label2.Text = "Clear";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(281, 374);
            Controls.Add(label2);
            Controls.Add(PassTb);
            Controls.Add(DocNameTb);
            Controls.Add(LoginButton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button LoginButton;
        private TextBox DocNameTb;
        private TextBox PassTb;
        private ContextMenuStrip contextMenuStrip1;
        private Label label2;
    }
}
