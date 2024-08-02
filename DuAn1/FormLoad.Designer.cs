namespace DuAn1
{
    partial class FormLoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoad));
            loadform = new Panel();
            myPanel = new Panel();
            lbtennv = new Label();
            btnHoaDon = new Button();
            btnNhanVien = new Button();
            btnTK = new Button();
            btnTD = new Button();
            btnQLBA = new Button();
            btnDatBan = new Button();
            btnQLMA = new Button();
            myPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loadform
            // 
            loadform.BorderStyle = BorderStyle.FixedSingle;
            loadform.ImeMode = ImeMode.Disable;
            loadform.Location = new Point(207, 1);
            loadform.Name = "loadform";
            loadform.Size = new Size(809, 475);
            loadform.TabIndex = 1;
            loadform.Paint += loadform_Paint;
            // 
            // myPanel
            // 
            myPanel.BackColor = SystemColors.Control;
            myPanel.Controls.Add(lbtennv);
            myPanel.Controls.Add(btnHoaDon);
            myPanel.Controls.Add(btnNhanVien);
            myPanel.Controls.Add(btnTK);
            myPanel.Controls.Add(btnTD);
            myPanel.Controls.Add(btnQLBA);
            myPanel.Controls.Add(btnDatBan);
            myPanel.Controls.Add(btnQLMA);
            myPanel.Dock = DockStyle.Left;
            myPanel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            myPanel.ForeColor = Color.FromArgb(255, 192, 255);
            myPanel.Location = new Point(0, 0);
            myPanel.Name = "myPanel";
            myPanel.Size = new Size(201, 476);
            myPanel.TabIndex = 2;
            // 
            // lbtennv
            // 
            lbtennv.AutoSize = true;
            lbtennv.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbtennv.ForeColor = Color.FromArgb(255, 128, 255);
            lbtennv.Image = (Image)resources.GetObject("lbtennv.Image");
            lbtennv.Location = new Point(40, 33);
            lbtennv.Name = "lbtennv";
            lbtennv.Size = new Size(117, 21);
            lbtennv.TabIndex = 7;
            lbtennv.Text = "Tên nhân viên";
            // 
            // btnHoaDon
            // 
            btnHoaDon.Location = new Point(0, 395);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(201, 49);
            btnHoaDon.TabIndex = 6;
            btnHoaDon.Text = "Hóa Đơn";
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Location = new Point(0, 340);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(201, 49);
            btnNhanVien.TabIndex = 5;
            btnNhanVien.Text = "Quản Lý Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnTK
            // 
            btnTK.Location = new Point(0, 286);
            btnTK.Name = "btnTK";
            btnTK.Size = new Size(201, 48);
            btnTK.TabIndex = 4;
            btnTK.Text = "Quản Lý Doanh Thu";
            btnTK.UseVisualStyleBackColor = true;
            // 
            // btnTD
            // 
            btnTD.Location = new Point(0, 232);
            btnTD.Name = "btnTD";
            btnTD.Size = new Size(201, 48);
            btnTD.TabIndex = 3;
            btnTD.Text = "Quản Lý Thực Đơn";
            btnTD.UseVisualStyleBackColor = true;
            btnTD.Click += btnTD_Click;
            // 
            // btnQLBA
            // 
            btnQLBA.Location = new Point(0, 178);
            btnQLBA.Name = "btnQLBA";
            btnQLBA.Size = new Size(201, 48);
            btnQLBA.TabIndex = 2;
            btnQLBA.Text = "Quản Lý Bàn Ăn";
            btnQLBA.UseVisualStyleBackColor = true;
            // 
            // btnDatBan
            // 
            btnDatBan.BackColor = SystemColors.Control;
            btnDatBan.ForeColor = Color.FromArgb(255, 192, 255);
            btnDatBan.Location = new Point(0, 124);
            btnDatBan.Name = "btnDatBan";
            btnDatBan.Size = new Size(201, 48);
            btnDatBan.TabIndex = 1;
            btnDatBan.Text = "Đặt Bàn";
            btnDatBan.UseVisualStyleBackColor = false;
            btnDatBan.Click += btnDatBan_Click;
            // 
            // btnQLMA
            // 
            btnQLMA.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnQLMA.ForeColor = Color.FromArgb(255, 192, 255);
            btnQLMA.Location = new Point(0, 70);
            btnQLMA.Name = "btnQLMA";
            btnQLMA.Size = new Size(201, 48);
            btnQLMA.TabIndex = 0;
            btnQLMA.Text = "Tài Khoản";
            btnQLMA.UseVisualStyleBackColor = true;
            // 
            // FormLoad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 476);
            Controls.Add(myPanel);
            Controls.Add(loadform);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FormLoad";
            Text = "FormLoad";
            Load += FormLoad_Load;
            myPanel.ResumeLayout(false);
            myPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel loadform;
        private Panel myPanel;
        private Button btnQLMA;
        private Button btnNhanVien;
        private Button btnTK;
        private Button btnTD;
        private Button btnQLBA;
        private Button btnDatBan;
        private Button btnHoaDon;
        private Label lbtennv;
    }
}