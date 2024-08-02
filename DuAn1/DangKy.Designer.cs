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
            txtemailsignup = new TextBox();
            txtmksignup = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtsdtsignup = new TextBox();
            txtdiachisignup = new TextBox();
            button1 = new Button();
            cbbvaitro = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.Location = new Point(137, 9);
            label4.Name = "label4";
            label4.Size = new Size(169, 28);
            label4.TabIndex = 1;
            label4.Text = "TẠO TÀI KHOẢN";
            // 
            // txtemailsignup
            // 
            txtemailsignup.Location = new Point(98, 8);
            txtemailsignup.Name = "txtemailsignup";
            txtemailsignup.Size = new Size(313, 27);
            txtemailsignup.TabIndex = 2;
            // 
            // txtmksignup
            // 
            txtmksignup.Location = new Point(98, 41);
            txtmksignup.Name = "txtmksignup";
            txtmksignup.Size = new Size(313, 27);
            txtmksignup.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbbvaitro);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtsdtsignup);
            panel1.Controls.Add(txtdiachisignup);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtemailsignup);
            panel1.Controls.Add(txtmksignup);
            panel1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            panel1.Location = new Point(-7, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 227);
            panel1.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 48);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 14;
            label6.Text = "Mật Khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 147);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 13;
            label5.Text = "SDT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 114);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 12;
            label3.Text = "Vai Trò";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 81);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 11;
            label2.Text = "Địa Chỉ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 15);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 10;
            label1.Text = "Email";
            // 
            // txtsdtsignup
            // 
            txtsdtsignup.Location = new Point(98, 140);
            txtsdtsignup.Name = "txtsdtsignup";
            txtsdtsignup.Size = new Size(313, 27);
            txtsdtsignup.TabIndex = 9;
            // 
            // txtdiachisignup
            // 
            txtdiachisignup.Location = new Point(98, 74);
            txtdiachisignup.Name = "txtdiachisignup";
            txtdiachisignup.Size = new Size(313, 27);
            txtdiachisignup.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(144, 173);
            button1.Name = "button1";
            button1.Size = new Size(169, 37);
            button1.TabIndex = 6;
            button1.Text = "Đăng Ký";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbbvaitro
            // 
            cbbvaitro.FormattingEnabled = true;
            cbbvaitro.Location = new Point(98, 107);
            cbbvaitro.Name = "cbbvaitro";
            cbbvaitro.Size = new Size(313, 28);
            cbbvaitro.TabIndex = 15;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 271);
            Controls.Add(panel1);
            Controls.Add(label4);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "DangKy";
            Text = "DangKy";
            Load += DangNhap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private TextBox txtemailsignup;
        private TextBox txtmksignup;
        private Panel panel1;
        private Button button1;
        private TextBox txtsdtsignup;
        private TextBox txtdiachisignup;
        private Label label6;
        private Label label5;
        private ComboBox cbbvaitro;
    }
}