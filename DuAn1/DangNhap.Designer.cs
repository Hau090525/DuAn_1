namespace DuAn1
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
            txtemaillogin = new TextBox();
            txtmklogin = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtemaillogin);
            panel1.Controls.Add(txtmklogin);
            panel1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            panel1.Location = new Point(44, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 168);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(78, 87);
            button1.Name = "button1";
            button1.Size = new Size(169, 37);
            button1.TabIndex = 5;
            button1.Text = "Đăng Nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtemaillogin
            // 
            txtemaillogin.Location = new Point(18, 13);
            txtemaillogin.Name = "txtemaillogin";
            txtemaillogin.Size = new Size(313, 27);
            txtemaillogin.TabIndex = 2;
            // 
            // txtmklogin
            // 
            txtmklogin.Location = new Point(18, 46);
            txtmklogin.Name = "txtmklogin";
            txtmklogin.Size = new Size(313, 27);
            txtmklogin.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.Location = new Point(147, 57);
            label4.Name = "label4";
            label4.Size = new Size(134, 28);
            label4.TabIndex = 7;
            label4.Text = "ĐĂNG NHẬP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(103, 127);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 6;
            label5.Text = "Quên mật khẩu?";
            label5.Click += label5_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 281);
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
        private TextBox txtemaillogin;
        private TextBox txtmklogin;
        private Panel myPanel;
        private Button btnDangNhap;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
    }
}