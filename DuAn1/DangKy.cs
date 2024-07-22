using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1
{
    public partial class DangKy : Form
    {
        taikhoanservice taikhoanservice = new taikhoanservice();
        public DangKy()
        {
            InitializeComponent();

        }
        private void MyPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                // Vẽ gradient màu từ hồng sang tím
                using (LinearGradientBrush brush = new LinearGradientBrush(panel.ClientRectangle, Color.FromArgb(216, 90, 144), Color.FromArgb(68, 55, 146), 90F))
                {
                    e.Graphics.FillRectangle(brush, panel.ClientRectangle);
                }
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
           

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int id = 0;
            string email = txtemailsignup.Text;
            string matkhau = txtmksignup.Text;
            string diachi = txtdiachisignup.Text;
            string vaitro = comboBox1.SelectedItem.ToString();
            string trangthai = "Active";
            string sdt = txtsdtsignup.Text;
            bool add = taikhoanservice.Addtaikhoan(id,email, matkhau, diachi, trangthai,vaitro ,sdt);
            if (add) MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
