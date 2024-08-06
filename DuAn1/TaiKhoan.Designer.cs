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
            cbbEmail = new ComboBox();
            label7 = new Label();
            txtTrangThai = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtDiaChi = new TextBox();
            txtMatKhau = new TextBox();
            btnThayDoi = new Button();
            txtSDT = new TextBox();
            txtVaiTro = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
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
            label8.Size = new Size(47, 20);
            label8.TabIndex = 48;
            label8.Text = "Email";
            // 
            // cbbEmail
            // 
            cbbEmail.FormattingEnabled = true;
            cbbEmail.Items.AddRange(new object[] { "Nhan Vien", "Khach Hang" });
            cbbEmail.Location = new Point(211, 110);
            cbbEmail.Margin = new Padding(3, 4, 3, 4);
            cbbEmail.Name = "cbbEmail";
            cbbEmail.Size = new Size(428, 28);
            cbbEmail.TabIndex = 47;
            cbbEmail.SelectedIndexChanged += cbbChucVu_SelectedIndexChanged;
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
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(211, 304);
            txtTrangThai.Margin = new Padding(3, 4, 3, 4);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(428, 27);
            txtTrangThai.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(106, 276);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 44;
            label6.Text = "Vai Trò";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(106, 237);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 41;
            label5.Text = "SDT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(106, 195);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 40;
            label4.Text = "Mật Khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(106, 152);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 39;
            label3.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(211, 148);
            txtDiaChi.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(428, 27);
            txtDiaChi.TabIndex = 38;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(211, 188);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(428, 27);
            txtMatKhau.TabIndex = 37;
            // 
            // btnThayDoi
            // 
            btnThayDoi.Location = new Point(211, 358);
            btnThayDoi.Margin = new Padding(3, 4, 3, 4);
            btnThayDoi.Name = "btnThayDoi";
            btnThayDoi.Size = new Size(123, 31);
            btnThayDoi.TabIndex = 49;
            btnThayDoi.Text = "Save";
            btnThayDoi.UseVisualStyleBackColor = true;
            btnThayDoi.Click += btnThayDoi_Click;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(211, 234);
            txtSDT.Margin = new Padding(3, 4, 3, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(428, 27);
            txtSDT.TabIndex = 42;
            // 
            // txtVaiTro
            // 
            txtVaiTro.Location = new Point(211, 269);
            txtVaiTro.Margin = new Padding(3, 4, 3, 4);
            txtVaiTro.Name = "txtVaiTro";
            txtVaiTro.Size = new Size(428, 27);
            txtVaiTro.TabIndex = 50;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(365, 358);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 31);
            btnAdd.TabIndex = 51;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(514, 358);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 31);
            btnDelete.TabIndex = 52;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // TaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtVaiTro);
            Controls.Add(btnThayDoi);
            Controls.Add(label8);
            Controls.Add(cbbEmail);
            Controls.Add(label7);
            Controls.Add(txtTrangThai);
            Controls.Add(label6);
            Controls.Add(txtSDT);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDiaChi);
            Controls.Add(txtMatKhau);
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
        private ComboBox cbbEmail;
        private Label label7;
        private TextBox txtTrangThai;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtDiaChi;
        private TextBox txtMatKhau;
        private Button btnThayDoi;
        private TextBox txtSDT;
        private TextBox txtVaiTro;
        private Button btnAdd;
        private Button btnDelete;
    }
}