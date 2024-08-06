using BLL;
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

namespace DuAn1
{
    public partial class TaiKhoan : Form
    {
        QlNhaHangContext db = new QlNhaHangContext();
        public TaiKhoan()
        {
            InitializeComponent();
        }
        //NhanVienBLL nhanVienBLL = new NhanVienBLL();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            var emails = db.Taikhoans.Select(u => u.Email).ToList();
            cbbEmail.DataSource = emails;
        }

        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEmail = cbbEmail.SelectedItem.ToString();

            using (var context = new QlNhaHangContext())
            {
                var user = context.Taikhoans.FirstOrDefault(u => u.Email == selectedEmail);
                if (user != null)
                {

                    txtDiaChi.Text = user.DiaChi;
                    txtMatKhau.Text = user.MatKhau;
                    txtSDT.Text = user.Sdt;
                    txtTrangThai.Text = user.TrangThai;
                    txtVaiTro.Text = user.VaiTro;
                }
            }
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            string email = cbbEmail.Text;
            var user = db.Taikhoans.FirstOrDefault(u => u.Email == email);

            if (user != null)
            {

                user.DiaChi = txtDiaChi.Text;
                user.Sdt = txtSDT.Text;
                user.MatKhau = txtMatKhau.Text;
                user.VaiTro = txtVaiTro.Text;
                user.TrangThai = txtTrangThai.Text;

                db.SaveChanges();
                MessageBox.Show("User information updated successfully!");
            }
            else
            {
                MessageBox.Show("User not found!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string email = cbbEmail.Text;
            if (db.Taikhoans.Any(u => u.Email == email))
            {
                MessageBox.Show("User with this email already exists!");
            }
            else
            {
                var newUser = new Taikhoan
                {


                    DiaChi = txtDiaChi.Text,
                    Sdt = txtSDT.Text,
                    MatKhau = txtMatKhau.Text,
                    VaiTro = txtVaiTro.Text,
                    TrangThai = txtTrangThai.Text
                };

                db.Taikhoans.Add(newUser);
                db.SaveChanges();
                MessageBox.Show("User added successfully!");

                // Refresh combobox
                var emails = db.Taikhoans.Select(u => u.Email).ToList();
                cbbEmail.DataSource = emails;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string email = cbbEmail.Text;
            var user = db.Taikhoans.FirstOrDefault(u => u.Email == email);

            if (user != null)
            {
                db.Taikhoans.Remove(user);
                db.SaveChanges();
                MessageBox.Show("User deleted successfully!");

                // Clear textboxes


                txtDiaChi.Clear();
                txtMatKhau.Clear();
                txtMatKhau.Clear();
                txtTrangThai.Clear();
                txtVaiTro.Clear();

                // Refresh combobox
                var emails = db.Taikhoans.Select(u => u.Email).ToList();
                cbbEmail.DataSource = emails;
            }
            else
            {
                MessageBox.Show("User not found!");
            }
        }
    }
}
