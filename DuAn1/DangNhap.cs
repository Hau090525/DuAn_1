using BLL;
using DTO.Models;
using Microsoft.EntityFrameworkCore;
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
using DTO;

namespace DuAn1
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();

            
        }
        

        private void DangNhap_Load(object sender, EventArgs e)
        {
           
                   
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var email = txtemaillogin.Text;
            var matkhau = txtmklogin.Text;

            taikhoanservice taikhoanservice = new taikhoanservice();

            if (taikhoanservice.ValidateUser(email, matkhau))
            {
                MessageBox.Show("Đăng nhập thành công!");
                FormLoad formload = new FormLoad();
                formload.ShowDialog();
         
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }
    }
}
