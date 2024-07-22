namespace DuAn1
{
    partial class DangKy
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
            label4 = new Label();
            button1 = new Button();
            txtsdtsignup = new TextBox();
            txtdiachisignup = new TextBox();
            txtmksignup = new TextBox();
            txtemailsignup = new TextBox();
            txtmkchecksignup = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.Location = new Point(173, 7);
            label4.Name = "label4";
            label4.Size = new Size(212, 35);
            label4.TabIndex = 1;
            label4.Text = "TẠO TÀI KHOẢN";
            // 
            // button1
            // 
            button1.Location = new Point(196, 281);
            button1.Name = "button1";
            button1.Size = new Size(169, 37);
            button1.TabIndex = 6;
            button1.Text = "Đăng Ký";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtsdtsignup
            // 
            txtsdtsignup.Location = new Point(34, 156);
            txtsdtsignup.Name = "txtsdtsignup";
            txtsdtsignup.Size = new Size(311, 27);
            txtsdtsignup.TabIndex = 8;
            txtsdtsignup.Text = "Phone number";
            // 
            // txtdiachisignup
            // 
            txtdiachisignup.Location = new Point(34, 111);
            txtdiachisignup.Name = "txtdiachisignup";
            txtdiachisignup.Size = new Size(311, 27);
            txtdiachisignup.TabIndex = 9;
            txtdiachisignup.Text = "Address";
            // 
            // txtmksignup
            // 
            txtmksignup.Location = new Point(34, 204);
            txtmksignup.Name = "txtmksignup";
            txtmksignup.Size = new Size(311, 27);
            txtmksignup.TabIndex = 10;
            txtmksignup.Text = "Password";
            // 
            // txtemailsignup
            // 
            txtemailsignup.Location = new Point(34, 64);
            txtemailsignup.Name = "txtemailsignup";
            txtemailsignup.Size = new Size(311, 27);
            txtemailsignup.TabIndex = 11;
            txtemailsignup.Text = "Email";
            // 
            // txtmkchecksignup
            // 
            txtmkchecksignup.Location = new Point(34, 248);
            txtmkchecksignup.Name = "txtmkchecksignup";
            txtmkchecksignup.Size = new Size(311, 27);
            txtmkchecksignup.TabIndex = 12;
            txtmkchecksignup.Text = "confirm password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(351, 251);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 13;
            label1.Text = "label1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "khách hàng", "nhân viên" });
            comboBox1.Location = new Point(351, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 14;
            comboBox1.Text = "vaitro";
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 330);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(txtmkchecksignup);
            Controls.Add(txtemailsignup);
            Controls.Add(txtmksignup);
            Controls.Add(txtdiachisignup);
            Controls.Add(txtsdtsignup);
            Controls.Add(button1);
            Controls.Add(label4);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "DangKy";
            Text = "DangKy";
            Load += DangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel myPanel;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button btnDangNhap;
        private Label label4;
        private Button button1;
        private TextBox txtsdtsignup;
        private TextBox txtdiachisignup;
        private TextBox txtmksignup;
        private TextBox txtemailsignup;
        private TextBox txtmkchecksignup;
        private ComboBox comboBox1;
    }
}