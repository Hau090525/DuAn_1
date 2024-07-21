namespace DuAn1
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
            cbbChucVu = new ComboBox();
            label7 = new Label();
            txtTinhTrang = new TextBox();
            label6 = new Label();
            dtpNgayVL = new DateTimePicker();
            txtSDT = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtMa = new TextBox();
            txtTen = new TextBox();
            btnThayDoi = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(322, 29);
            label1.Name = "label1";
            label1.Size = new Size(301, 35);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(106, 113);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 48;
            label8.Text = "Chức vụ";
            // 
            // cbbChucVu
            // 
            cbbChucVu.FormattingEnabled = true;
            cbbChucVu.Items.AddRange(new object[] { "Nhan Vien", "Khach Hang" });
            cbbChucVu.Location = new Point(211, 110);
            cbbChucVu.Margin = new Padding(3, 4, 3, 4);
            cbbChucVu.Name = "cbbChucVu";
            cbbChucVu.Size = new Size(428, 28);
            cbbChucVu.TabIndex = 47;
            cbbChucVu.SelectedIndexChanged += cbbChucVu_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(106, 315);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 46;
            label7.Text = "Tình trạng";
            // 
            // txtTinhTrang
            // 
            txtTinhTrang.Location = new Point(211, 304);
            txtTinhTrang.Margin = new Padding(3, 4, 3, 4);
            txtTinhTrang.Name = "txtTinhTrang";
            txtTinhTrang.Size = new Size(428, 27);
            txtTinhTrang.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(106, 276);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 44;
            label6.Text = "SDT";
            // 
            // dtpNgayVL
            // 
            dtpNgayVL.Location = new Point(211, 227);
            dtpNgayVL.Margin = new Padding(3, 4, 3, 4);
            dtpNgayVL.Name = "dtpNgayVL";
            dtpNgayVL.Size = new Size(428, 27);
            dtpNgayVL.TabIndex = 43;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(211, 265);
            txtSDT.Margin = new Padding(3, 4, 3, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(428, 27);
            txtSDT.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(106, 237);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 41;
            label5.Text = "Ngày Vào Làm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(106, 199);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 40;
            label4.Text = "Tên ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(106, 152);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 39;
            label3.Text = "ID";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(211, 148);
            txtMa.Margin = new Padding(3, 4, 3, 4);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(428, 27);
            txtMa.TabIndex = 38;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(211, 188);
            txtTen.Margin = new Padding(3, 4, 3, 4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(428, 27);
            txtTen.TabIndex = 37;
            // 
            // btnThayDoi
            // 
            btnThayDoi.Location = new Point(449, 393);
            btnThayDoi.Margin = new Padding(3, 4, 3, 4);
            btnThayDoi.Name = "btnThayDoi";
            btnThayDoi.Size = new Size(190, 31);
            btnThayDoi.TabIndex = 49;
            btnThayDoi.Text = "Save";
            btnThayDoi.UseVisualStyleBackColor = true;
            // 
            // TaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnThayDoi);
            Controls.Add(label8);
            Controls.Add(cbbChucVu);
            Controls.Add(label7);
            Controls.Add(txtTinhTrang);
            Controls.Add(label6);
            Controls.Add(dtpNgayVL);
            Controls.Add(txtSDT);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtMa);
            Controls.Add(txtTen);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TaiKhoan";
            Text = "TaiKhoan";
            Load += TaiKhoan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label8;
        private ComboBox cbbChucVu;
        private Label label7;
        private TextBox txtTinhTrang;
        private Label label6;
        private DateTimePicker dtpNgayVL;
        private TextBox txtSDT;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtMa;
        private TextBox txtTen;
        private Button btnThayDoi;
    }
}