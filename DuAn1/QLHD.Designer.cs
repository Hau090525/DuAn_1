namespace GUI
{
    partial class QLHD
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
            dgvHoaDon = new DataGridView();
            label1 = new Label();
            ngayloc = new DateTimePicker();
            label2 = new Label();
            cbbTrangThai = new ComboBox();
            btnQuayLai = new Button();
            btnLoc = new Button();
            label3 = new Label();
            dgvKhachHang = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            btnXuat = new Button();
            dgvXuat = new DataGridView();
            label6 = new Label();
            ngaysauu = new DateTimePicker();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvXuat).BeginInit();
            SuspendLayout();
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(0, 95);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.Size = new Size(571, 150);
            dgvHoaDon.TabIndex = 0;
            dgvHoaDon.CellClick += dgvHoaDon_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(588, 84);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Từ ngày";
            // 
            // ngayloc
            // 
            ngayloc.Format = DateTimePickerFormat.Custom;
            ngayloc.Location = new Point(588, 102);
            ngayloc.Name = "ngayloc";
            ngayloc.Size = new Size(200, 23);
            ngayloc.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(588, 175);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 3;
            label2.Text = "Trạng thái";
            // 
            // cbbTrangThai
            // 
            cbbTrangThai.FormattingEnabled = true;
            cbbTrangThai.Location = new Point(588, 193);
            cbbTrangThai.Name = "cbbTrangThai";
            cbbTrangThai.Size = new Size(200, 23);
            cbbTrangThai.TabIndex = 4;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(588, 58);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(87, 23);
            btnQuayLai.TabIndex = 5;
            btnQuayLai.Text = "Quay Lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(691, 58);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(97, 23);
            btnLoc.TabIndex = 6;
            btnLoc.Text = "Lọc Dữ Liệu";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(0, 71);
            label3.Name = "label3";
            label3.Size = new Size(158, 21);
            label3.TabIndex = 7;
            label3.Text = "Thông Tin Hóa Đơn";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(0, 302);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.Size = new Size(443, 78);
            dgvKhachHang.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(0, 278);
            label4.Name = "label4";
            label4.Size = new Size(149, 21);
            label4.TabIndex = 9;
            label4.Text = "Thông Tin Chi Tiết";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label5.Location = new Point(295, 9);
            label5.Name = "label5";
            label5.Size = new Size(202, 25);
            label5.TabIndex = 10;
            label5.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(679, 276);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(116, 23);
            btnXuat.TabIndex = 11;
            btnXuat.Text = "Xuất Hóa Đơn";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // dgvXuat
            // 
            dgvXuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvXuat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvXuat.Location = new Point(449, 302);
            dgvXuat.Name = "dgvXuat";
            dgvXuat.Size = new Size(346, 78);
            dgvXuat.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(449, 278);
            label6.Name = "label6";
            label6.Size = new Size(116, 21);
            label6.TabIndex = 13;
            label6.Text = "Hóa Đơn Xuất";
            // 
            // ngaysauu
            // 
            ngaysauu.Format = DateTimePickerFormat.Custom;
            ngaysauu.Location = new Point(588, 149);
            ngaysauu.Name = "ngaysauu";
            ngaysauu.Size = new Size(200, 23);
            ngaysauu.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(588, 131);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 15;
            label7.Text = "Đến ngày";
            // 
            // QLHD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(ngaysauu);
            Controls.Add(label6);
            Controls.Add(dgvXuat);
            Controls.Add(btnXuat);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgvKhachHang);
            Controls.Add(label3);
            Controls.Add(btnLoc);
            Controls.Add(btnQuayLai);
            Controls.Add(cbbTrangThai);
            Controls.Add(label2);
            Controls.Add(ngayloc);
            Controls.Add(label1);
            Controls.Add(dgvHoaDon);
            Name = "QLHD";
            Text = "QLHD";
            Load += QLHD_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvXuat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHoaDon;
        private Label label1;
        private DateTimePicker ngayloc;
        private Label label2;
        private ComboBox cbbTrangThai;
        private Button btnQuayLai;
        private Button btnLoc;
        private Label label3;
        private DataGridView dgvKhachHang;
        private Label label4;
        private Label label5;
        private Button btnXuat;
        private DataGridView dgvXuat;
        private Label label6;
        private DateTimePicker ngaysauu;
        private Label label7;
    }
}