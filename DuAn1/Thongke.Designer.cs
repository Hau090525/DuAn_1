namespace GUI
{
    partial class Thongke
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
            myPanel = new Panel();
            btnHoaDon = new Button();
            btnNhanVien = new Button();
            btnKHO = new Button();
            btnTD = new Button();
            btnQLBA = new Button();
            btnDatBan = new Button();
            btnQLMA = new Button();
            loadform = new Panel();
            btnthongke = new Button();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            myPanel.SuspendLayout();
            loadform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // myPanel
            // 
            myPanel.BackColor = SystemColors.Control;
            myPanel.Controls.Add(btnHoaDon);
            myPanel.Controls.Add(btnNhanVien);
            myPanel.Controls.Add(btnKHO);
            myPanel.Controls.Add(btnTD);
            myPanel.Controls.Add(btnQLBA);
            myPanel.Controls.Add(btnDatBan);
            myPanel.Controls.Add(btnQLMA);
            myPanel.Dock = DockStyle.Left;
            myPanel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            myPanel.ForeColor = Color.FromArgb(255, 192, 255);
            myPanel.Location = new Point(0, 0);
            myPanel.Margin = new Padding(3, 4, 3, 4);
            myPanel.Name = "myPanel";
            myPanel.Size = new Size(230, 635);
            myPanel.TabIndex = 4;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Location = new Point(0, 527);
            btnHoaDon.Margin = new Padding(3, 4, 3, 4);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(230, 65);
            btnHoaDon.TabIndex = 6;
            btnHoaDon.Text = "Hóa Đơn";
            btnHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Location = new Point(0, 453);
            btnNhanVien.Margin = new Padding(3, 4, 3, 4);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(230, 65);
            btnNhanVien.TabIndex = 5;
            btnNhanVien.Text = "Quản Lý Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnKHO
            // 
            btnKHO.Location = new Point(0, 381);
            btnKHO.Margin = new Padding(3, 4, 3, 4);
            btnKHO.Name = "btnKHO";
            btnKHO.Size = new Size(230, 64);
            btnKHO.TabIndex = 4;
            btnKHO.Text = "Thống kê";
            btnKHO.UseVisualStyleBackColor = true;
            // 
            // btnTD
            // 
            btnTD.Location = new Point(0, 309);
            btnTD.Margin = new Padding(3, 4, 3, 4);
            btnTD.Name = "btnTD";
            btnTD.Size = new Size(230, 64);
            btnTD.TabIndex = 3;
            btnTD.Text = "Quản Lý Thực Đơn";
            btnTD.UseVisualStyleBackColor = true;
            // 
            // btnQLBA
            // 
            btnQLBA.Location = new Point(0, 237);
            btnQLBA.Margin = new Padding(3, 4, 3, 4);
            btnQLBA.Name = "btnQLBA";
            btnQLBA.Size = new Size(230, 64);
            btnQLBA.TabIndex = 2;
            btnQLBA.Text = "Quản Lý Bàn Ăn";
            btnQLBA.UseVisualStyleBackColor = true;
            // 
            // btnDatBan
            // 
            btnDatBan.BackColor = SystemColors.Control;
            btnDatBan.ForeColor = Color.FromArgb(255, 192, 255);
            btnDatBan.Location = new Point(0, 165);
            btnDatBan.Margin = new Padding(3, 4, 3, 4);
            btnDatBan.Name = "btnDatBan";
            btnDatBan.Size = new Size(230, 64);
            btnDatBan.TabIndex = 1;
            btnDatBan.Text = "Đặt Bàn";
            btnDatBan.UseVisualStyleBackColor = false;
            // 
            // btnQLMA
            // 
            btnQLMA.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnQLMA.ForeColor = Color.FromArgb(255, 192, 255);
            btnQLMA.Location = new Point(0, 93);
            btnQLMA.Margin = new Padding(3, 4, 3, 4);
            btnQLMA.Name = "btnQLMA";
            btnQLMA.Size = new Size(230, 64);
            btnQLMA.TabIndex = 0;
            btnQLMA.Text = "Quản Lý Món Ăn";
            btnQLMA.UseVisualStyleBackColor = true;
            // 
            // loadform
            // 
            loadform.BorderStyle = BorderStyle.FixedSingle;
            loadform.Controls.Add(btnthongke);
            loadform.Controls.Add(label2);
            loadform.Controls.Add(label1);
            loadform.Controls.Add(dateTimePicker2);
            loadform.Controls.Add(dateTimePicker1);
            loadform.Controls.Add(dataGridView1);
            loadform.ImeMode = ImeMode.Disable;
            loadform.Location = new Point(239, 1);
            loadform.Margin = new Padding(3, 4, 3, 4);
            loadform.Name = "loadform";
            loadform.Size = new Size(924, 633);
            loadform.TabIndex = 3;
            // 
            // btnthongke
            // 
            btnthongke.Location = new Point(135, 153);
            btnthongke.Name = "btnthongke";
            btnthongke.Size = new Size(94, 29);
            btnthongke.TabIndex = 10;
            btnthongke.Text = "Show";
            btnthongke.UseVisualStyleBackColor = true;
            btnthongke.Click += btnthongke_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 96);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 9;
            label2.Text = "Đến";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(356, 29);
            label1.Name = "label1";
            label1.Size = new Size(201, 44);
            label1.TabIndex = 8;
            label1.Text = "Thống kê";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(481, 91);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(135, 91);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 227);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(924, 406);
            dataGridView1.TabIndex = 5;
            // 
            // Thongke
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 635);
            Controls.Add(myPanel);
            Controls.Add(loadform);
            Name = "Thongke";
            Text = "Thongke";
            Load += Thongke_Load;
            myPanel.ResumeLayout(false);
            loadform.ResumeLayout(false);
            loadform.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel myPanel;
        private Button btnHoaDon;
        private Button btnNhanVien;
        private Button btnKHO;
        private Button btnTD;
        private Button btnQLBA;
        private Button btnDatBan;
        private Button btnQLMA;
        private Panel loadform;
        private Button btnthongke;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
    }
}