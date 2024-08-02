namespace GUI
{
    partial class voucher
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
            lblTongTien = new Label();
            cbbVoucher = new ComboBox();
            lbvoucher = new Label();
            lblTongTienSauGiam = new Label();
            button1 = new Button();
            button2 = new Button();
            lblTienGiam = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.Red;
            lblTongTien.Location = new Point(228, 29);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(27, 31);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "0";
            // 
            // cbbVoucher
            // 
            cbbVoucher.Font = new Font("Segoe UI", 13F);
            cbbVoucher.FormattingEnabled = true;
            cbbVoucher.Location = new Point(528, 29);
            cbbVoucher.Name = "cbbVoucher";
            cbbVoucher.Size = new Size(162, 31);
            cbbVoucher.TabIndex = 2;
            cbbVoucher.SelectedIndexChanged += cbbVoucher_SelectedIndexChanged;
            // 
            // lbvoucher
            // 
            lbvoucher.AutoSize = true;
            lbvoucher.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbvoucher.Location = new Point(528, 77);
            lbvoucher.Name = "lbvoucher";
            lbvoucher.Size = new Size(0, 25);
            lbvoucher.TabIndex = 3;
            // 
            // lblTongTienSauGiam
            // 
            lblTongTienSauGiam.AutoSize = true;
            lblTongTienSauGiam.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTongTienSauGiam.ForeColor = Color.Red;
            lblTongTienSauGiam.Location = new Point(141, 130);
            lblTongTienSauGiam.Name = "lblTongTienSauGiam";
            lblTongTienSauGiam.Size = new Size(27, 31);
            lblTongTienSauGiam.TabIndex = 4;
            lblTongTienSauGiam.Text = "0";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(412, 128);
            button1.Name = "button1";
            button1.Size = new Size(134, 41);
            button1.TabIndex = 5;
            button1.Text = "App Voucher";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 13F);
            button2.Location = new Point(12, 185);
            button2.Name = "button2";
            button2.Size = new Size(141, 41);
            button2.TabIndex = 6;
            button2.Text = "Thanh Toán";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblTienGiam
            // 
            lblTienGiam.AutoSize = true;
            lblTienGiam.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTienGiam.ForeColor = Color.Red;
            lblTienGiam.Location = new Point(228, 77);
            lblTienGiam.Name = "lblTienGiam";
            lblTienGiam.Size = new Size(27, 31);
            lblTienGiam.TabIndex = 7;
            lblTienGiam.Text = "0";
            lblTienGiam.Click += lblTienGiam_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(193, 31);
            label1.TabIndex = 8;
            label1.Text = "Số tiền tạm tính:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(216, 31);
            label2.TabIndex = 9;
            label2.Text = "Số tiền được giảm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(412, 29);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 10;
            label3.Text = "Mã Voucher:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(412, 77);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 11;
            label4.Text = "Mô tả:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label5.Location = new Point(12, 130);
            label5.Name = "label5";
            label5.Size = new Size(123, 31);
            label5.TabIndex = 12;
            label5.Text = "Tổng tiền:";
            // 
            // voucher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 254);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTienGiam);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblTongTienSauGiam);
            Controls.Add(lbvoucher);
            Controls.Add(cbbVoucher);
            Controls.Add(lblTongTien);
            Name = "voucher";
            Text = "voucher";
            Load += voucher_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTongTien;
        private ComboBox cbbVoucher;
        private Label lbvoucher;
        private Label lblTongTienSauGiam;
        private Button button1;
        private Button button2;
        private Label lblTienGiam;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}