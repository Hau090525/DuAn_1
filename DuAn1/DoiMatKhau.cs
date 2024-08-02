using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO.Models;

namespace GUI
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            string emailNguoiDung = txtEmail.Text;
            if (string.IsNullOrEmpty(emailNguoiDung))
            {
                MessageBox.Show("Vui lòng nhập email của bạn.");
                return;
            }

            string maXacNhan = GenerateVerificationCode();
            SaveVerificationCode(emailNguoiDung, maXacNhan);
            SendVerificationCode(emailNguoiDung, maXacNhan);

            MessageBox.Show("Mã xác nhận đã được gửi đến email của bạn.");
            formxacnhan formXacNhanMa = new formxacnhan();
            formXacNhanMa.Show();
        }

        private string GenerateVerificationCode()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 999999).ToString();
        }

        private void SaveVerificationCode(string email, string code)
        {
            using (var context = new QlNhaHangContext())
            {
                var user = context.Taikhoans.FirstOrDefault(u => u.Email == email);
                if (user != null)
                {
                    user.MatKhau = code;

                    context.SaveChanges();
                }
            }
        }

        private void SendVerificationCode(string emailNguoiDung, string maXacNhan)
        {
            var fromAddress = new MailAddress("your-email@example.com", "Your Name");
            var toAddress = new MailAddress(emailNguoiDung);
            const string fromPassword = "your-email-password";
            const string subject = "Mã Xác Nhận Đổi Mật Khẩu";
            string body = $"Mã xác nhận của bạn là: {maXacNhan}";

            var smtp = new SmtpClient
            {
                Host = "smtp.example.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
    }
