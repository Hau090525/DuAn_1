namespace DuAn1
{
    partial class QuanLiThucDon
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
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtID = new TextBox();
            txtTen = new TextBox();
            button1 = new Button();
            txtTimkiem = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            txtGia = new TextBox();
            txtTrangThai = new TextBox();
            label7 = new Label();
            txtLoai = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvLoad).BeginInit();
            SuspendLayout();
            // 
            // dgvLoad
            // 
            dgvLoad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoad.Location = new Point(56, 288);
            dgvLoad.Name = "dgvLoad";
            dgvLoad.RowHeadersWidth = 51;
            dgvLoad.Size = new Size(689, 150);
            dgvLoad.TabIndex = 29;
            dgvLoad.CellClick += dgvLoad_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(126, 237);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 28;
            label5.Text = "Loại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(126, 150);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 27;
            label4.Text = "Tên món ăn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(126, 121);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 26;
            label3.Text = "ID";
            label3.Click += label3_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(475, 259);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 24;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(357, 259);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 23;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(233, 259);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 22;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(233, 113);
            txtID.Name = "txtID";
            txtID.Size = new Size(375, 23);
            txtID.TabIndex = 20;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(233, 142);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(375, 23);
            txtTen.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(512, 75);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "Tìm Kiếm";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(250, 75);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(215, 23);
            txtTimkiem.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 79);
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
            label1.Size = new Size(201, 25);
            label1.TabIndex = 15;
            label1.Text = "QUẢN LÝ THỰC ĐƠN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(126, 179);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 30;
            label6.Text = "Giá thành";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(233, 171);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(375, 23);
            txtGia.TabIndex = 31;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(233, 200);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(375, 23);
            txtTrangThai.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(126, 208);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 33;
            label7.Text = "Trạng thái";
            // 
            // txtLoai
            // 
            txtLoai.Location = new Point(233, 229);
            txtLoai.Name = "txtLoai";
            txtLoai.Size = new Size(375, 23);
            txtLoai.TabIndex = 34;
            // 
            // QuanLiThucDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLoai);
            Controls.Add(label7);
            Controls.Add(txtTrangThai);
            Controls.Add(txtGia);
            Controls.Add(label6);
            Controls.Add(dgvLoad);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtID);
            Controls.Add(txtTen);
            Controls.Add(button1);
            Controls.Add(txtTimkiem);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "QuanLiThucDon";
            Text = "QuanLiThucDon";
            Load += QuanLiThucDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLoad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLoad;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private ComboBox cbbTrangthai;
        private TextBox txtID;
        private TextBox txtTen;
        private Button button1;
        private TextBox txtTimkiem;
        private Label label2;
        private Label label1;
        private Label label6;
        private TextBox txtGia;
        private TextBox txtTrangThai;
        private Label label7;
        private TextBox txtLoai;
    }
}