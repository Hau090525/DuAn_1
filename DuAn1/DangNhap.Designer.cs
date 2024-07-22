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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtemaillogin);
            panel1.Controls.Add(txtmklogin);
            panel1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            panel1.Location = new Point(2, 53);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 189);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(106, 116);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(193, 49);
            button1.TabIndex = 5;
            button1.Text = "Đăng Nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtemaillogin
            // 
            txtemaillogin.Location = new Point(21, 17);
            txtemaillogin.Margin = new Padding(3, 4, 3, 4);
            txtemaillogin.Name = "txtemaillogin";
            txtemaillogin.Size = new Size(357, 32);
            txtemaillogin.TabIndex = 2;
            // 
            // txtmklogin
            // 
            txtmklogin.Location = new Point(21, 61);
            txtmklogin.Margin = new Padding(3, 4, 3, 4);
            txtmklogin.Name = "txtmklogin";
            txtmklogin.Size = new Size(357, 32);
            txtmklogin.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.Location = new Point(120, 12);
            label4.Name = "label4";
            label4.Size = new Size(168, 35);
            label4.TabIndex = 7;
            label4.Text = "ĐĂNG NHẬP";
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 257);
            Controls.Add(label4);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}