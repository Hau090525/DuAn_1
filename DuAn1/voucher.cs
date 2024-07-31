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
    public partial class voucher : Form
    {
        public event Action<int>? PaymentConfirmed;
        private int _idHoaDon;
        private decimal _tongTien;
        private decimal _tienGiam;
        private decimal _tongtienSauGiam;
        public voucher(int idHoaDon, decimal tongTien)
        {
            InitializeComponent();
            _idHoaDon = idHoaDon;
            _tongTien = tongTien;
            lblTongTien.Text = _tongTien.ToString("N0") + " VND";

            LoadVouchers();
        }

        private void LoadVouchers()
        {
            using (var context = new QlNhaHangContext())
            {
                var today = DateTime.Now;
                var vouchers = context.Vouchers
                    .Where(v => v.StartDate.HasValue && v.EndDate.HasValue &&
                                v.StartDate.Value <= today &&
                                v.EndDate.Value >= today)
                    .ToList();

                cbbVoucher.DataSource = vouchers;
                cbbVoucher.DisplayMember = "CodeVoucher";
                cbbVoucher.ValueMember = "CodeVoucher";
            }
        }
        private void voucher_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string voucherCode = cbbVoucher.SelectedValue.ToString();
            try
            {
                decimal phanTramGiamGia = ApplyVoucher(voucherCode);

                // Tính số tiền giảm giá
                decimal tienGiam = (_tongTien * phanTramGiamGia) / 100;
                lblTienGiam.Text = tienGiam.ToString("N0") + " VND";

                // Tính tổng tiền sau khi giảm giá
                decimal tongTienSauGiam = _tongTien - tienGiam;
                lblTongTienSauGiam.Text = tongTienSauGiam.ToString("N0") + " VND";
                _tongtienSauGiam = tongTienSauGiam;
                // Lưu giá trị giảm giá để sử dụng sau này nếu cần
                _tienGiam = tienGiam;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new QlNhaHangContext())
            {
                var hoaDon = context.Hoadons.FirstOrDefault(h => h.IdHoaDon == _idHoaDon);
                if (hoaDon != null)
                {
                    hoaDon.TrangThai = "Đã thanh toán";
                    hoaDon.TienGiam = _tienGiam;
                    hoaDon.TongTien = _tongtienSauGiam;
                    hoaDon.CodeVoucher = cbbVoucher.Text;
                    context.SaveChanges();
                }

                var ban = context.Bans.FirstOrDefault(b => b.IdBan == hoaDon.IdBan);
                if (ban != null)
                {
                    ban.TrangThai = "Trống";
                    context.SaveChanges();
                }
            }

            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (_idHoaDon > 0) // hoặc bất kỳ điều kiện nào phù hợp với ứng dụng của bạn
            {
                PaymentConfirmed?.Invoke(_idHoaDon);
            } // Kích hoạt sự kiện khi thanh toán thành công
            this.Close();
        }
        private decimal ApplyVoucher(string voucherCode)
        {
            using (var context = new QlNhaHangContext())
            {
                var voucher = context.Vouchers.FirstOrDefault(v => v.CodeVoucher == voucherCode
          && v.StartDate <= DateTime.Now
          && v.EndDate >= DateTime.Now);

                if (voucher != null)
                {
                    return (decimal)(voucher.PhanTram ?? 0); // Assuming PhanTram is the discount percentage or amount
                }
                else
                {
                    throw new Exception("Voucher không hợp lệ hoặc đã hết hạn.");
                }
            }
        }

        private void cbbVoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbVoucher.SelectedItem != null)
            {
                var selectedVoucher = (Voucher)cbbVoucher.SelectedItem;
                lbvoucher.Text = selectedVoucher.MoTa;
            }
        }

        private void lblTienGiam_Click(object sender, EventArgs e)
        {

        }
    }
}
