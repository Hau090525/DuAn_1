﻿namespace DuAn1
{
    partial class TaiKhoan
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
            label1 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtMa = new TextBox();
            txtTen = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(282, 22);
            label1.Name = "label1";
            label1.Size = new Size(240, 28);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(93, 85);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 48;
            label8.Text = "Chức vụ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(185, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(375, 23);
            comboBox1.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(93, 236);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 46;
            label7.Text = "Tình trạng";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(185, 228);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(375, 23);
            textBox2.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(93, 207);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 44;
            label6.Text = "SDT";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(185, 170);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(375, 23);
            dateTimePicker1.TabIndex = 43;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(375, 23);
            textBox1.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(93, 178);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 41;
            label5.Text = "Ngày Vào Làm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(93, 149);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 40;
            label4.Text = "Tên ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(93, 114);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 39;
            label3.Text = "ID";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(185, 111);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(375, 23);
            txtMa.TabIndex = 38;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(185, 141);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(375, 23);
            txtTen.TabIndex = 37;
            // 
            // button1
            // 
            button1.Location = new Point(429, 299);
            button1.Name = "button1";
            button1.Size = new Size(166, 23);
            button1.TabIndex = 49;
            button1.Text = "Thay đổi mật khẩu";
            button1.UseVisualStyleBackColor = true;
            // 
            // TaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtMa);
            Controls.Add(txtTen);
            Controls.Add(label1);
            Name = "TaiKhoan";
            Text = "TaiKhoan";
            Load += this.TaiKhoan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label8;
        private ComboBox comboBox1;
        private Label label7;
        private TextBox textBox2;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtMa;
        private TextBox txtTen;
        private Button button1;
    }
}