using System;
using BLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DuAn1
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();

        }
        TaiKhoanBLL TaiKhoanBLL = new TaiKhoanBLL();
        //private void MyPanel_Paint(object sender, PaintEventArgs e)
        //{
        //    Panel panel = sender as Panel;
        //    if (panel != null)
        //    {
                
        //        using (LinearGradientBrush brush = new LinearGradientBrush(panel.ClientRectangle, Color.FromArgb(216, 90, 144), Color.FromArgb(68, 55, 146), 90F))
        //        {
        //            e.Graphics.FillRectangle(brush, panel.ClientRectangle);
        //        }
        //    }
        //}

        private void DangNhap_Load(object sender, EventArgs e)
        {
            cbbvaitro.Items.Add("Admin");
            cbbvaitro.Items.Add("Nhan vien");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            string email = txtemailsignup.Text;
            string matkhau = txtmksignup.Text;
            string diachi = txtdiachisignup.Text;
            string vaitro = cbbvaitro.SelectedItem.ToString();
            string trangthai = "Active";
            string sdt = txtsdtsignup.Text;
            bool add = TaiKhoanBLL.AddTaiKhoan(id, email, matkhau, diachi, trangthai, vaitro, sdt);
            if (add) MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
