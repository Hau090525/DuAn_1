using DTO.Models;
using Microsoft.EntityFrameworkCore;
using System;
using BLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using static Azure.Core.HttpHeader;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;
using Org.BouncyCastle.Crypto;

namespace DuAn1
{
    public partial class DatBan : Form
    {
        public string EmployeeName { get; set; }
        private int? idNhanVien;



        public DatBan(string employeeName) : this()
        {
            EmployeeName = employeeName;
            lbtennv.Text = employeeName;
            

            idNhanVien = GetIDNhanVienFromName(employeeName);
        }
        private int? GetIDNhanVienFromName(string tenNhanVien)
        {
            using (var context = new QlNhaHangContext())
            {
                var nhanVien = context.NhanViens
                    .Where(h => h.TenNv == tenNhanVien)
                    .Select(h => h.IdNv)
                    .FirstOrDefault();

                return nhanVien;
            }
        }
        private DatBan()
        {
            InitializeComponent();
        }
        private int selectedTableId = 0;
        private int currentHoaDonId = 0;
        DatBanBLL datbanBLL = new DatBanBLL();
        QLHDBLL dbLL = new QLHDBLL();



        private void InitializeCheckboxes()
        {

            foreach (Control control in panel1.Controls)
            {
                if (control is CheckBox checkBox)
                {

                    int tableId = GetTableIdFromCheckBoxName(checkBox.Name);
                    checkBox.Tag = tableId;
                    checkBox.CheckedChanged += CheckBox_CheckedChanged;
                }
            }
        }

        private int GetTableIdFromCheckBoxName(string checkBoxName)
        {
            // Phân tích tên CheckBox để lấy ID bàn
            if (int.TryParse(checkBoxName.Replace("cbBan", ""), out int tableId))
            {
                return tableId;
            }
            return 0;
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb != null)
            {
                if (cb.Checked)
                {
                    selectedTableId = (int)cb.Tag;
                    lbSoBAn.Text = $"ID Bàn: {selectedTableId}";
                    // Hiển thị thông tin liên quan nếu cần
                    DisplayTableInfo(selectedTableId);
                }
                else
                {
                    // Reset thông tin nếu cần khi bỏ chọn
                    lbSoBAn.Text = "0";
                }
            }
        }
        

        private void DisplayTableInfo(int tableId)
        {

            var tableInfo = GetTableInfo(tableId);
            lbSoBAn.Text = tableInfo;
        }

        private string GetTableInfo(int tableId)
        {

            return $"{tableId}";
        }
        private void DatBan_Load(object sender, EventArgs e)
        {
            InitializeCheckboxes();
            cb1.Tag = 1;
            cb2.Tag = 2;
            cb3.Tag = 3;
            cb4.Tag = 4;
            cb5.Tag = 5;
            cb6.Tag = 6;
            cb7.Tag = 7;
            cb8.Tag = 8;
            cb9.Tag = 9;
            cb10.Tag = 10;
            LoadDanhSachDatBan();
            var monan = datbanBLL.gettenma();
            cbbMon.DataSource = monan;
            cbbMon.DisplayMember = "TenMon";
            cbbMon.ValueMember = "IdMonAn";

        }
        private void LoadDanhSachDatBan()
        {
            using (var context = new QlNhaHangContext())
            {
                var danhSachBanDangSuDung = datbanBLL.ban()
                                            .Join(
                                            context.Hoadons,
                                             ban => ban.IdBan,
                                              hd => hd.IdBan,
                                             (ban, hd) => new { ban, hd }
                                             ).Join(
                                            context.Khachhangs,
                                            x => x.hd.IdKh,
                                            kh => kh.IdKh,
                                            (x, kh) => new { x.ban, x.hd, kh })
                                            .Where(x => x.ban.TrangThai == "Đang sử dụng" && x.hd.TrangThai == "Chưa thanh toán")
                                            .GroupBy(x => new { x.ban.IdBan, x.ban.TenBan })
                                            .Select(g => new
                                            {

                                                IdKh = g.OrderByDescending(x => x.hd.NgayHoaDon).FirstOrDefault()?.hd.IdKh,
                                                IdHoaDon = g.OrderByDescending(x => x.hd.IdHoaDon).FirstOrDefault()?.hd.IdHoaDon,
                                                IdBan = g.Key.IdBan,
                                                tenban = g.Key.TenBan,
                                                NgayHoaDon = g.OrderByDescending(x => x.hd.NgayHoaDon).FirstOrDefault()?.hd.NgayHoaDon
                                            })
                                            .ToList();

                dgvDatBan.DataSource = danhSachBanDangSuDung;

            }


        }
        public void GetHoaDonDetails(int idHoaDon)
        {

            using (var context = new QlNhaHangContext())
            {
                var query = from hdct in context.Hoadonchitiets
                            join ma in context.Monans on hdct.IdMonAn equals ma.IdMonAn
                            join hd in context.Hoadons on hdct.IdHoaDon equals hd.IdHoaDon
                            join b in context.Bans on hd.IdBan equals b.IdBan
                            where hdct.IdHoaDon == idHoaDon && b.TrangThai == "Đang sử dụng"
                            select new
                            {
                                TenMon = ma.TenMon,
                                ThanhTien = hdct.ThanhTien,
                                SoLuong = hdct.SoLuong,
                                TenBan = b.TenBan
                            };

                var result = query.ToList();
               

                dgvLoadMonAn.DataSource = result;
            }
        }

        private void btnSuadoi_Click(object sender, EventArgs e)
        {
            if (selectedTableId == 0)
            {
                MessageBox.Show("Vui lòng chọn bàn!");
                return;
            }

            int customerId = GetCustomerId();
            if (customerId == 0)
            {
                return;
            }
            int? idNhanVien = GetIDNhanVienFromName(lbtennv.Text);
            datbanBLL.luuthongtin(selectedTableId, customerId, DateOnly.FromDateTime(DateTime.Now),idNhanVien);
            MessageBox.Show("Đặt bàn thành công!");
            datbanBLL.CapNhatTrangThaiBan(selectedTableId, "Đang sử dụng");
            LoadDanhSachDatBan();
        }
        private int GetCustomerId()
        {
            if (int.TryParse(txtIDKH.Text, out int customerId))
            {
                return customerId;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng hợp lệ!");
                return 0;
            }
        }

        private void btnGoimon_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(lbSoBAn.Text.Replace("ID Bàn: ", ""), out int selectedTableId))
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi gọi món!");
                return;
            }

            // Lấy thông tin khách hàng từ txtIDKH
            if (!int.TryParse(txtIDKH.Text, out int selectedCustomerId))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng hợp lệ!");
                return;
            }


            using (var context = new QlNhaHangContext())
            {
                var hoaDon = context.Hoadons
                    .FirstOrDefault(hd => hd.IdBan == selectedTableId && hd.IdKh == selectedCustomerId && hd.TrangThai == "Chưa thanh toán");

                if (hoaDon == null)
                {
                    MessageBox.Show("Khách hàng không phải là người đã đặt bàn hoặc bàn chưa được đặt. Vui lòng kiểm tra lại.");
                    return;
                }


                string tenMonAn = cbbMon.Text;
                int idMonAn = int.Parse(cbbMon.SelectedValue.ToString());
                int soLuong = int.Parse(txtSluong.Text);

                try
                {
                    datbanBLL.themmonanvaohd(hoaDon.IdHoaDon, idMonAn, soLuong);
                    MessageBox.Show("Thêm món ăn thành công!");

                    CapNhatTongTien(hoaDon.IdHoaDon);
                    datbanBLL.CapNhatThongTinHoaDon(hoaDon.IdHoaDon);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                }
            }
            
           
        }
        private void CapNhatTongTien(int idHoaDon)
        {
            
        }
       
        private void dgvDatBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDatBan.Rows[e.RowIndex];

                int selectedTableId = (int)selectedRow.Cells["IdBan"].Value;
                int customerId = (int)selectedRow.Cells["IdKh"].Value;
                int idhoadon = (int)selectedRow.Cells["IdHoaDon"].Value;

                lbSoBAn.Text = $"{selectedTableId}";
                lbSoBAn1.Text = $"{selectedTableId}";
                txtIDKH.Text = customerId.ToString();

                GetHoaDonDetails(idhoadon);

                // Debugging
                Console.WriteLine($"Selected IdHoaDon: {idhoadon}");

                using (var dbContext = new QlNhaHangContext())
                {
                    decimal? tien = (from hd in dbContext.Hoadons
                                     where hd.IdHoaDon == idhoadon
                                     select hd.TongTien).FirstOrDefault();

                    if (tien.HasValue)
                    {
                        lbTongTien.Text = tien.Value.ToString("N0") + " VND";
                        Console.WriteLine($"TongTien: {tien.Value}");
                    }
                    else
                    {
                        lbTongTien.Text = "Không có dữ liệu";
                        Console.WriteLine("No data found for TongTien.");
                    }
                }
            }


        

    }

        private void txtSluong_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lbtennv_Click(object sender, EventArgs e)
        {

        }

        private void cbbMon_TextChanged(object sender, EventArgs e)
        {
            if (cbbMon.SelectedItem != null)
            {
                var selectedMonAn = (dynamic)cbbMon.SelectedItem;
                decimal giaTien = selectedMonAn.DonGia;

                lbGIaTien.Text = giaTien.ToString("N0") + " VND";
            }
        }

        private void dgvDatBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            QLKH qlkh= new QLKH();
            qlkh.ShowDialog();
        }
    }
}