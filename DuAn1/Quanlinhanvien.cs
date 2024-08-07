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

    public partial class Quanlinhanvien : Form
    {
        QlNhaHangContext db = new QlNhaHangContext();
        public Quanlinhanvien()
        {
            InitializeComponent();
            LoadEmployeeData();
        }

        private void Quanlinhanvien_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ChucVu",
                HeaderText = "Chức Vụ"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ID",
                HeaderText = "ID"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Ten",
                HeaderText = "Tên"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NgayVaoLam",
                HeaderText = "Ngày Vào Làm"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SDT",
                HeaderText = "SDT"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TinhTrang",
                HeaderText = "Tình Trạng"
            });

            LoadEmployeeData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void LoadEmployeeData()
        {
            using (var context = new QlNhaHangContext())
            {
                var employees = context.NhanViens.ToList();
                dataGridView1.DataSource = employees;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy hàng được click
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Hiển thị dữ liệu lên các TextBox và DateTimePicker
                txtChucVu.Text = row.Cells["ChucVu"].Value?.ToString();
                txtID.Text = row.Cells["IdNv"].Value?.ToString();
                txtTen.Text = row.Cells["TenNv"].Value?.ToString();
                txtNgayVaoLam.Text = row.Cells["NgayVaoLam"].Value.ToString();
                txtSDT.Text = row.Cells["Sdt"].Value?.ToString();
                txtTrangThai.Text = row.Cells["TinhTrang"].Value?.ToString();
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimkiem.Text.ToLower();

            var filteredEmployees = db.NhanViens
                .Where(emp => emp.TenNv.ToLower().Contains(keyword) ||
                              emp.ChucVu.ToLower().Contains(keyword) ||
                              emp.Sdt.Contains(keyword) ||
                              emp.TinhTrang.ToLower().Contains(keyword))
                .ToList();

            dataGridView1.DataSource = filteredEmployees;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(txtNgayVaoLam.Text, out DateTime ngayVaoLam))
            {
                var newEmployee = new NhanVien
                {
                    ChucVu = txtChucVu.Text,
                    TenNv = txtTen.Text,
                    NgayVaoLam = DateOnly.FromDateTime(ngayVaoLam), // Chuyển đổi từ DateTime sang DateOnly
                    Sdt = txtSDT.Text,
                    TinhTrang = txtTrangThai.Text
                };

                db.NhanViens.Add(newEmployee);
                db.SaveChanges();

                LoadEmployeeData();
            }
            else
            {
                MessageBox.Show("Ngày vào làm không hợp lệ!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id) && DateTime.TryParse(txtNgayVaoLam.Text, out DateTime ngayVaoLam))
            {
                var employee = db.NhanViens.Find(id);

                if (employee != null)
                {
                    employee.ChucVu = txtChucVu.Text;
                    employee.TenNv = txtTen.Text;
                    employee.NgayVaoLam = DateOnly.FromDateTime(ngayVaoLam); // Chuyển đổi từ DateTime sang DateOnly
                    employee.Sdt = txtSDT.Text;
                    employee.TinhTrang = txtTrangThai.Text;

                    db.SaveChanges();

                    LoadEmployeeData();
                }
            }
            else
            {
                MessageBox.Show("ID hoặc Ngày vào làm không hợp lệ!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id))
            {
                // Tìm nhân viên theo ID
                var employee = db.NhanViens.Find(id);

                // Nếu nhân viên tồn tại trong cơ sở dữ liệu
                if (employee != null)
                {
                    // Xóa nhân viên khỏi cơ sở dữ liệu
                    db.NhanViens.Remove(employee);
                    db.SaveChanges();

                    // Cập nhật lại dữ liệu trên DataGridView
                    LoadEmployeeData();
                }
                else
                {
                    MessageBox.Show("Nhân viên không tồn tại!");
                }
            }
            else
            {
                MessageBox.Show("ID không hợp lệ!");
            }
        }
    }
}
