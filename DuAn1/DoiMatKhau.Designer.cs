namespace GUI
{
    partial class DoiMatKhau
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
            txtEmail = new TextBox();
            btnGui = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(308, 116);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(182, 23);
            txtEmail.TabIndex = 0;
            // 
            // btnGui
            // 
            btnGui.Location = new Point(360, 145);
            btnGui.Name = "btnGui";
            btnGui.Size = new Size(75, 23);
            btnGui.TabIndex = 1;
            btnGui.Text = "Xác nhận";
            btnGui.UseVisualStyleBackColor = true;
            btnGui.Click += btnGui_Click;
            // 
            // DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGui);
            Controls.Add(txtEmail);
            Name = "DoiMatKhau";
            Text = "DoiMatKhau";
           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Button btnGui;
    }
}