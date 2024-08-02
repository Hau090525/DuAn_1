using DTO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class formxacnhan : Form
    {
        public formxacnhan()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string emailNguoiDung = txtEmail.Text;
            string maXacNhan = txtMaXacNhan.Text;
            string matKhauMoi = txtMatKhauMoi.Text;

            if (string.IsNullOrEmpty(emailNguoiDung) || string.IsNullOrEmpty(maXacNhan) || string.IsNullOrEmpty(matKhauMoi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            using (var context = new QlNhaHangContext())
            {
                var user = context.Taikhoans.FirstOrDefault(u => u.Email == emailNguoiDung && u.MatKhau == maXacNhan);
                if (user != null)
                {
                    user.MatKhau = matKhauMoi;
                    //user.VerificationCode = null;
                    //user.CodeExpiration = null;
                    context.SaveChanges();

                    MessageBox.Show("Mật khẩu của bạn đã được đặt lại thành công.");
                }
                else
                {
                    MessageBox.Show("Mã xác nhận không hợp lệ hoặc đã hết hạn.");
                }
            }
        }

        private void formxacnhan_Load(object sender, EventArgs e)
        {

        }
    }
}

