namespace DuAn1
{
    partial class Kho
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
            dgvLoad = new DataGridView();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnclead = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtDonViTinh = new ComboBox();
            txtID = new TextBox();
            txtTen = new TextBox();
            button1 = new Button();
            txtTimkiem = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            label7 = new Label();
            txtIDKho = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLoad).BeginInit();
            SuspendLayout();
            // 
            // dgvLoad
            // 
            dgvLoad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoad.Location = new Point(62, 280);
            dgvLoad.Name = "dgvLoad";
            dgvLoad.Size = new Size(689, 150);
            dgvLoad.TabIndex = 29;
            dgvLoad.CellClick += dgvLoad_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(126, 230);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 28;
            label5.Text = "Đơn vị tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(126, 115);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 27;
            label4.Text = "Tên NL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(126, 86);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 26;
            label3.Text = "ID";
            // 
            // btnclead
            // 
            btnclead.Location = new Point(565, 251);
            btnclead.Name = "btnclead";
            btnclead.Size = new Size(75, 23);
            btnclead.TabIndex = 25;
            btnclead.Text = "Clead";
            btnclead.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(453, 251);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 24;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click_1;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(349, 251);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 23;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(233, 251);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 22;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.FormattingEnabled = true;
            txtDonViTinh.Location = new Point(233, 222);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.Size = new Size(375, 23);
            txtDonViTinh.TabIndex = 21;
            // 
            // txtID
            // 
            txtID.Location = new Point(233, 78);
            txtID.Name = "txtID";
            txtID.Size = new Size(375, 23);
            txtID.TabIndex = 20;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(233, 107);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(375, 23);
            txtTen.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(512, 49);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "Tìm Kiếm";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(246, 49);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(260, 23);
            txtTimkiem.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 53);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 16;
            label2.Text = "Tìm Kiếm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(319, 21);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 15;
            label1.Text = "QUẢN LÝ KHO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(126, 150);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 30;
            label6.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(233, 142);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(375, 23);
            txtDonGia.TabIndex = 31;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(233, 176);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(375, 23);
            txtSoLuong.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(126, 184);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 33;
            label7.Text = "Số lượng";
            // 
            // txtIDKho
            // 
            txtIDKho.Location = new Point(38, 184);
            txtIDKho.Name = "txtIDKho";
            txtIDKho.Size = new Size(82, 23);
            txtIDKho.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(38, 166);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 35;
            label8.Text = "IDKHo";
            // 
            // Kho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(txtIDKho);
            Controls.Add(label7);
            Controls.Add(txtSoLuong);
            Controls.Add(txtDonGia);
            Controls.Add(label6);
            Controls.Add(dgvLoad);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnclead);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtDonViTinh);
            Controls.Add(txtID);
            Controls.Add(txtTen);
            Controls.Add(button1);
            Controls.Add(txtTimkiem);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Kho";
            Text = "Kho";
            Load += Kho_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLoad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvLoad;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnclead;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private ComboBox txtDonViTinh;
        private TextBox txtID;
        private TextBox txtTen;
        private Button button1;
        private TextBox txtTimkiem;
        private Label label2;
        private Label label1;
        private Label label6;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private Label label7;
        private TextBox txtIDKho;
        private Label label8;
    }
}