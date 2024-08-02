using BLL;
using DAL;
using GUI;
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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();

        }
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        private void DangNhap_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtemaillogin.Text;
            string matkhau = txtmklogin.Text;

            int employeeId;
            if (taiKhoanBLL.ValidateEmployeeUser(email, matkhau, out employeeId))
            {
                // Lấy tên nhân viên từ ID
                string employeeName = taiKhoanBLL.GetEmployeeNameById(employeeId);

                MessageBox.Show("Đăng nhập thành công!");

                // Chuyển tên nhân viên cho FormLoad
                FormLoad formload = new FormLoad(employeeName);
                formload.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản không hợp lệ hoặc không phải của nhân viên.");
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            doiMatKhau.ShowDialog();
        }
    }
}
