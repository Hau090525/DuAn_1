﻿namespace DuAn1
{
    partial class DangNhap
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
            panel1 = new Panel();
            button1 = new Button();
            txtMatKhau = new TextBox();
            txtEmail = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(txtEmail);
            panel1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            panel1.Location = new Point(2, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 142);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(93, 87);
            button1.Name = "button1";
            button1.Size = new Size(169, 37);
            button1.TabIndex = 5;
            button1.Text = "Đăng Nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(18, 13);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(313, 27);
            txtMatKhau.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(18, 46);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(313, 27);
            txtEmail.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.Location = new Point(105, 9);
            label4.Name = "label4";
            label4.Size = new Size(134, 28);
            label4.TabIndex = 7;
            label4.Text = "ĐĂNG NHẬP";
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 193);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "DangNhap";
            Text = "DangNhap";
            Load += DangNhap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox txtMatKhau;
        private TextBox txtEmail;
        private Panel myPanel;
        private Button btnDangNhap;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
    }
}