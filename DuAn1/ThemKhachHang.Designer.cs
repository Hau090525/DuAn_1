namespace GUI
{
    partial class ThemKhachHang
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
            txtTenKH = new TextBox();
            txtSdt = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(232, 96);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(100, 23);
            txtTenKH.TabIndex = 0;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(232, 140);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(100, 23);
            txtSdt.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(423, 172);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ThemKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtSdt);
            Controls.Add(txtTenKH);
            Name = "ThemKhachHang";
            Text = "ThemKhachHang";
            Load += ThemKhachHang_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenKH;
        private TextBox txtSdt;
        private Button button1;
    }
}