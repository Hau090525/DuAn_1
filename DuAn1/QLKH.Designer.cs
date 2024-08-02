namespace DuAn1
{
    partial class QLKH
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
            dgvKH = new DataGridView();
            txtTK = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKH).BeginInit();
            SuspendLayout();
            // 
            // dgvKH
            // 
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKH.Location = new Point(3, 44);
            dgvKH.Name = "dgvKH";
            dgvKH.Size = new Size(516, 183);
            dgvKH.TabIndex = 0;
            // 
            // txtTK
            // 
            txtTK.Location = new Point(98, 12);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(320, 23);
            txtTK.TabIndex = 1;
            txtTK.TextChanged += txtTK_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 15);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 2;
            label1.Text = "Tìm kiếm";
            // 
            // QLKH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 227);
            Controls.Add(label1);
            Controls.Add(txtTK);
            Controls.Add(dgvKH);
            Name = "QLKH";
            Text = "QLKH";
            Load += QLKH_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKH;
        private TextBox txtTK;
        private Label label1;
    }
}