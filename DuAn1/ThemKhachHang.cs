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
    public partial class ThemKhachHang : Form
    {
        public int KhachHangId { get; private set; }

        public ThemKhachHang()
        {
            InitializeComponent();
        }

        //private void btnLuu_Click(object sender, EventArgs e)
        //{
        //    
        //}
        private void ThemKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenKh = txtTenKH.Text;
            string sdt = txtSdt.Text;
            if (sdt.Length > 10)
            {
                MessageBox.Show("Số điện thoại không được vượt quá 10 ký tự.");
                return;
            }
            // Thêm khách hàng vào cơ sở dữ liệu và lấy ID của khách hàng mới
            using (var context = new QlNhaHangContext())
            {
                int maxId = context.Khachhangs.Max(kh => (int?)kh.IdKh) ?? 0;
                int newId = maxId + 1;

                var khachHang = new Khachhang
                {
                    IdKh = newId,
                    TenKh = tenKh,
                    Sdt = sdt
                };

                try
                {
                    context.Khachhangs.Add(khachHang);
                    context.SaveChanges();

                    KhachHangId = khachHang.IdKh; // Lấy ID của khách hàng mới
                    MessageBox.Show("ID khách hàng mới: " + KhachHangId);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu khách hàng: " + ex.Message);
                }
            }
        }
    }
}
