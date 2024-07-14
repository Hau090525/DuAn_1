namespace DuAn1
{
    partial class Quanliban
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
            label2 = new Label();
            txtTimkiem = new TextBox();
            button1 = new Button();
            txtTen = new TextBox();
            txtMa = new TextBox();
            cbbTrangthai = new ComboBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(318, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ BÀN ĂN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 67);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Tìm Kiếm";
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(249, 63);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(215, 23);
            txtTimkiem.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(511, 63);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Tìm Kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(232, 168);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(375, 23);
            txtTen.TabIndex = 4;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(232, 124);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(375, 23);
            txtMa.TabIndex = 5;
            // 
            // cbbTrangthai
            // 
            cbbTrangthai.FormattingEnabled = true;
            cbbTrangthai.Location = new Point(232, 210);
            cbbTrangthai.Name = "cbbTrangthai";
            cbbTrangthai.Size = new Size(375, 23);
            cbbTrangthai.TabIndex = 6;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(232, 239);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(348, 239);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(452, 239);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(564, 239);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(125, 132);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 11;
            label3.Text = "Mã bàn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(125, 176);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 12;
            label4.Text = "Tên bàn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(125, 218);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 13;
            label5.Text = "Trạng thái";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 268);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(689, 150);
            dataGridView1.TabIndex = 14;
            // 
            // Quanliban
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Quanliban";
            Text = "Quanliban";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTimkiem;
        private Button button1;
        private TextBox txtTen;
        private TextBox txtMa;
        private ComboBox cbbTrangthai;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
    }
}