namespace DuAn1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            myPanel = new Panel();
            btnDangKY = new Button();
            btnDangNhap = new Button();
            lbDoi = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            loadform = new Panel();
            myPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // myPanel
            // 
            myPanel.BackColor = SystemColors.Control;
            myPanel.Controls.Add(btnDangKY);
            myPanel.Controls.Add(btnDangNhap);
            myPanel.Controls.Add(lbDoi);
            myPanel.Controls.Add(label2);
            myPanel.Controls.Add(label1);
            myPanel.Controls.Add(pictureBox1);
            myPanel.Dock = DockStyle.Left;
            myPanel.Location = new Point(0, 0);
            myPanel.Name = "myPanel";
            myPanel.Size = new Size(283, 450);
            myPanel.TabIndex = 1;
            // 
            // btnDangKY
            // 
            btnDangKY.Location = new Point(61, 373);
            btnDangKY.Name = "btnDangKY";
            btnDangKY.Size = new Size(161, 37);
            btnDangKY.TabIndex = 5;
            btnDangKY.Text = "Đăng Ký";
            btnDangKY.UseVisualStyleBackColor = true;
            btnDangKY.Click += btnDangKY_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(61, 373);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(161, 37);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // lbDoi
            // 
            lbDoi.AutoSize = true;
            lbDoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbDoi.ForeColor = SystemColors.ActiveCaptionText;
            lbDoi.Location = new Point(83, 345);
            lbDoi.Name = "lbDoi";
            lbDoi.Size = new Size(113, 15);
            lbDoi.TabIndex = 3;
            lbDoi.Text = "Vui lòng đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(61, 298);
            label2.Name = "label2";
            label2.Size = new Size(161, 28);
            label2.TabIndex = 2;
            label2.Text = "Royal TheDHPA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(11, 264);
            label1.Name = "label1";
            label1.Size = new Size(269, 21);
            label1.TabIndex = 1;
            label1.Text = "Chào mừng bạn đến với nhà hàng";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // loadform
            // 
            loadform.Location = new Point(360, 129);
            loadform.Name = "loadform";
            loadform.Size = new Size(374, 197);
            loadform.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(myPanel);
            Controls.Add(loadform);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            myPanel.ResumeLayout(false);
            myPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel loadform;
        private Panel myPanel;
        private Button btnDangNhap;
        private Label lbDoi;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox textBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Button btnDangKY;
    }
}
