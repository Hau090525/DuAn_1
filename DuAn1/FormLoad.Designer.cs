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
            loadform = new Panel();
            myPanel = new Panel();
            btnNhanVien = new Button();
            btnKHO = new Button();
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
            myPanel.Name = "myPanel";
            myPanel.Size = new Size(201, 476);
            myPanel.TabIndex = 2;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Location = new Point(0, 354);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(201, 48);
            btnNhanVien.TabIndex = 5;
            btnNhanVien.Text = "Quản Lý Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnKHO
            // 
            btnKHO.Location = new Point(0, 300);
            btnKHO.Name = "btnKHO";
            btnKHO.Size = new Size(201, 48);
            btnKHO.TabIndex = 4;
            btnKHO.Text = "Quản Lý Kho";
            btnKHO.UseVisualStyleBackColor = true;
            btnKHO.Click += btnKHO_Click;
            // 
            // btnTD
            // 
            btnTD.Location = new Point(0, 246);
            btnTD.Name = "btnTD";
            btnTD.Size = new Size(201, 48);
            btnTD.TabIndex = 3;
            btnTD.Text = "Quản Lý Thực Đơn";
            btnTD.UseVisualStyleBackColor = true;
            btnTD.Click += btnTD_Click;
            // 
            // btnQLBA
            // 
            btnQLBA.Location = new Point(0, 192);
            btnQLBA.Name = "btnQLBA";
            btnQLBA.Size = new Size(201, 48);
            btnQLBA.TabIndex = 2;
            btnQLBA.Text = "Quản Lý Bàn Ăn";
            btnQLBA.UseVisualStyleBackColor = true;
            btnQLBA.Click += btnQLBA_Click;
            // 
            // btnDatBan
            // 
            btnDatBan.BackColor = SystemColors.Control;
            btnDatBan.ForeColor = Color.FromArgb(255, 192, 255);
            btnDatBan.Location = new Point(0, 138);
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
            btnQLMA.Location = new Point(0, 84);
            btnQLMA.Name = "btnQLMA";
            btnQLMA.Size = new Size(201, 48);
            btnQLMA.TabIndex = 0;
            btnQLMA.Text = "Quản Lý Món Ăn";
            btnQLMA.UseVisualStyleBackColor = true;
            btnQLMA.Click += btnQLMA_Click;
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
            ResumeLayout(false);
        }

        #endregion
        private Panel loadform;
        private Panel myPanel;
        private Button btnQLMA;
        private Button btnNhanVien;
        private Button btnKHO;
        private Button btnTD;
        private Button btnQLBA;
        private Button btnDatBan;
    }
}