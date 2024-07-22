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
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            cbbTrangthai = new ComboBox();
            txtMa = new TextBox();
            txtTen = new TextBox();
            button1 = new Button();
            txtTimkiem = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(64, 384);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(787, 200);
            dataGridView1.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(144, 316);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 28;
            label5.Text = "Loại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(144, 200);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 27;
            label4.Text = "Tên món ăn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(144, 161);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 26;
            label3.Text = "ID";
            label3.Click += label3_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(645, 345);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(86, 31);
            btnLuu.TabIndex = 25;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(509, 345);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 31);
            btnSua.TabIndex = 24;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(399, 345);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 31);
            btnXoa.TabIndex = 23;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(266, 345);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 31);
            btnThem.TabIndex = 22;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // cbbTrangthai
            // 
            cbbTrangthai.FormattingEnabled = true;
            cbbTrangthai.Location = new Point(266, 305);
            cbbTrangthai.Margin = new Padding(3, 4, 3, 4);
            cbbTrangthai.Name = "cbbTrangthai";
            cbbTrangthai.Size = new Size(428, 28);
            cbbTrangthai.TabIndex = 21;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(266, 151);
            txtMa.Margin = new Padding(3, 4, 3, 4);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(428, 27);
            txtMa.TabIndex = 20;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(266, 189);
            txtTen.Margin = new Padding(3, 4, 3, 4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(428, 27);
            txtTen.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(585, 100);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 18;
            button1.Text = "Tìm Kiếm";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(286, 100);
            txtTimkiem.Margin = new Padding(3, 4, 3, 4);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(245, 27);
            txtTimkiem.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 105);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 16;
            label2.Text = "Tìm Kiếm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(365, 28);
            label1.Name = "label1";
            label1.Size = new Size(254, 32);
            label1.TabIndex = 15;
            label1.Text = "QUẢN LÝ THỰC ĐƠN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(144, 239);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 30;
            label6.Text = "Giá thành";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(266, 228);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(428, 27);
            textBox1.TabIndex = 31;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(266, 267);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(428, 27);
            textBox2.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(144, 277);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 33;
            label7.Text = "Trạng thái";
            // 
            // QuanLiThucDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnLuu);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(cbbTrangthai);
            Controls.Add(txtMa);
            Controls.Add(txtTen);
            Controls.Add(button1);
            Controls.Add(txtTimkiem);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "QuanLiThucDon";
            Text = "QuanLiThucDon";
            Load += QuanLiThucDon_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private ComboBox cbbTrangthai;
        private TextBox txtMa;
        private TextBox txtTen;
        private Button button1;
        private TextBox txtTimkiem;
        private Label label2;
        private Label label1;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label7;
    }
}