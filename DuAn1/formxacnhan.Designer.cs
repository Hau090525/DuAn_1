namespace GUI
{
    partial class formxacnhan
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
            txtEmail = new TextBox();
            txtMaXacNhan = new TextBox();
            txtMatKhauMoi = new TextBox();
            btnXacNhan = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(259, 95);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 0;
            // 
            // txtMaXacNhan
            // 
            txtMaXacNhan.Location = new Point(259, 144);
            txtMaXacNhan.Name = "txtMaXacNhan";
            txtMaXacNhan.Size = new Size(100, 23);
            txtMaXacNhan.TabIndex = 1;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(259, 193);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(100, 23);
            txtMatKhauMoi.TabIndex = 2;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(287, 248);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(75, 23);
            btnXacNhan.TabIndex = 3;
            btnXacNhan.Text = "Xác Nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // formxacnhan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXacNhan);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(txtMaXacNhan);
            Controls.Add(txtEmail);
            Name = "formxacnhan";
            Text = "formxacnhan";
            Load += formxacnhan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtMaXacNhan;
        private TextBox txtMatKhauMoi;
        private Button btnXacNhan;
    }
}