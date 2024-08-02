using BLL;
using System;

using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Font.Constants;
using iText.IO.Font;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO.Models;
using static System.Net.Mime.MediaTypeNames;
using iText.Kernel.Font;
using iText.Layout.Properties;
using DuAn1;


namespace GUI
{
    public partial class QLHD : Form
    {
        public string EmployeeName { get; set; }
        public QLHD()
        {
            InitializeComponent();
        }
        QLHDBLL hoaDonBLL = new QLHDBLL();
        DataTable dt = new DataTable();
        
        DataTable dthd = new DataTable();

        private void QLHD_Load(object sender, EventArgs e)
        {

            cbbTrangThai.Items.Add("Đã thanh toán");
            cbbTrangThai.Items.Add("Chưa thanh toán");
            if (dt.Columns.Count == 0)
            {

                dt.Columns.Add("IdHoaDon", typeof(int));
                dt.Columns.Add("IdKh", typeof(int));
                dt.Columns.Add("TenMonAn", typeof(string));
                dt.Columns.Add("TongTien", typeof(decimal));
                dt.Columns.Add("TienGiam", typeof(decimal));

                dt.Columns.Add("NgayHoaDon", typeof(DateOnly));
                dt.Columns.Add("TrangThai", typeof(string));
                dt.Columns.Add("Tennv", typeof(string));
                

            }
            
            if (dthd.Columns.Count == 0)
            {

                dthd.Columns.Add("IdHoaDon", typeof(int));
                dthd.Columns.Add("TenKh", typeof(string));
                dthd.Columns.Add("TenMonAn", typeof(string));
                dthd.Columns.Add("TongTien", typeof(decimal));
                dthd.Columns.Add("NgayHoaDon", typeof(DateOnly));
                dthd.Columns.Add("TrangThai", typeof(string));

            }
            loaddulieu();
           
            
            dgvXuat.DataSource = dthd;

        }
        public void loaddulieu()
        {
           
            var result = from hd in hoaDonBLL.getAllHD()
                         
                         join nv   in hoaDonBLL.getallnv()
                            on hd.IdNv equals nv.IdNv
                         select new
                         {
                             hd.IdHoaDon,
                             hd.IdKh,
                             hd.TenMonAn,
                             hd.TongTien,
                             hd.TienGiam,
                             hd.NgayHoaDon,
                             hd.TrangThai,
                             nv.TenNv,
                         };
            dt.Rows.Clear();
            foreach (var item in result)
            {
                DataRow dr = dt.NewRow();

                dr["IdHoaDon"] = item.IdHoaDon;
                dr["IdKh"] = item.IdKh;
                dr["TenMonAn"] = item.TenMonAn != null ? (object)item.TenMonAn : DBNull.Value;
                dr["TongTien"] = item.TongTien.HasValue ? (object)item.TongTien.Value : DBNull.Value;
                dr["TienGiam"] = item.TienGiam.HasValue ? (object)item.TienGiam.Value : DBNull.Value;

                dr["NgayHoaDon"] = item.NgayHoaDon;
                dr["TrangThai"] = item.TrangThai;
                dr["Tennv"] = item.TenNv;
               
                dt.Rows.Add(dr);
            }
            dgvHoaDon.DataSource = dt;
            dgvHoaDon.Refresh();
        }
        public void loaddulieuloc(string trangthai)//, DateOnly ngaytu, DateOnly ngayden)
        {
            dt.Rows.Clear();
            var result = from hd in hoaDonBLL.getAllHD()
                         where //hd.NgayHoaDon >= ngaytu &&
                         //      hd.NgayHoaDon <= ngayden &&
                               hd.TrangThai == trangthai
                         select new
                         {
                             hd.IdHoaDon,
                             hd.IdKh,
                             hd.TenMonAn,
                             hd.TongTien,

                             hd.NgayHoaDon,
                             hd.TrangThai,
                         };
            foreach (var item in result)
            {
                DataRow dr = dt.NewRow();

                dr["IdHoaDon"] = item.IdHoaDon;
                dr["IdKh"] = item.IdKh;
                dr["TenMonAn"] = item.TenMonAn;
                dr["TongTien"] = item.TongTien;

                dr["NgayHoaDon"] = item.NgayHoaDon;
                dr["TrangThai"] = item.TrangThai;
                dt.Rows.Add(dr);
            }
        }


        public void ReloadForm()
        {
            this.Hide();
            QLHD newForm = new QLHD();
            newForm.Show();
            this.Close(); // Đóng form hiện tại nếu không cần thiết nữa
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            ReloadForm();
            dthd.Rows.Clear();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            DateTime datetimeFrom = ngayloc.Value;
            DateTime datetimeTo = ngaysauu.Value;

            DateOnly ngaylocc = DateOnly.FromDateTime(datetimeFrom);
            DateOnly ngaysau = DateOnly.FromDateTime(datetimeTo);

            if (ngaysau < ngaylocc)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string trangthai = cbbTrangThai.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(trangthai))
            {
                loaddulieuloc(trangthai);//, ngaylocc, ngaysau);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn trạng thái.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvHoaDon.Rows[e.RowIndex];
                int idKh = Convert.ToInt32(selectedRow.Cells["IdKh"].Value);
                int idhd = Convert.ToInt32(selectedRow.Cells["IdHoaDon"].Value);
               
                loadhoadonxuat(idhd);
            }
            else
            {
                MessageBox.Show("Không có dòng nào được chọn.");
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvHoaDon.Rows[e.RowIndex];
                string trangThai = selectedRow.Cells["TrangThai"].Value.ToString();

                if (trangThai == "Chưa thanh toán")
                {
                    int idHoaDon = (int)selectedRow.Cells["IdHoaDon"].Value;
                    string tenKh = selectedRow.Cells["IdKh"].Value.ToString();
                    string tenMonAn = selectedRow.Cells["TenMonAn"].Value != DBNull.Value ? selectedRow.Cells["TenMonAn"].Value.ToString() : null;
                    decimal tongTien = selectedRow.Cells["TongTien"].Value != DBNull.Value ? Convert.ToDecimal(selectedRow.Cells["TongTien"].Value) : 0;

                    if (string.IsNullOrEmpty(tenMonAn) || tongTien == 0)
                    {
                        MessageBox.Show("Hóa đơn chưa có gọi món hoặc thông tin món ăn không hợp lệ.");
                        return;
                    }

                    DateOnly ngayHoaDon = (DateOnly)selectedRow.Cells["NgayHoaDon"].Value;

                    string message = $"Hóa đơn cần thanh toán:\n\n" +
                                     $"ID Hóa Đơn: {idHoaDon}\n" +
                                     $"Tên Khách Hàng: {tenKh}\n" +
                                     $"Tên Món Ăn: {tenMonAn}\n" +
                                     $"Tổng Tiền: {tongTien:C}\n" +

                                     $"Ngày Hóa Đơn: {ngayHoaDon:dd/MM/yyyy}\n\n" +
                                     $"Xác nhận thanh toán?";

                    DialogResult result = MessageBox.Show(message, "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {


                        var voucherForm = new voucher(idHoaDon, tongTien,EmployeeName);
                        voucherForm.FormClosed += (s, e) => loaddulieu();
                        voucherForm.ShowDialog();
                        FormLoad form = new FormLoad(EmployeeName);
                        this.Close();
                    }
                }

            }
        }
        
        //private void OnPaymentConfirmed(int idHoaDon)
        //{
        //    // Tìm hàng đã chọn trong DataGridView và cập nhật trạng thái
        //    foreach (DataGridViewRow row in dgvHoaDon.Rows)
        //    {
        //        if ((int)row.Cells["IdHoaDon"].Value == idHoaDon)
        //        {
        //            row.Cells["TrangThai"].Value = "Đã thanh toán";
        //            break;
        //        }
        //    }
        //    loaddulieu();
        //}
        public void CreateInvoicePDF(DataGridView dataGridView, string filePath)
        {
            using (PdfWriter writer = new PdfWriter(filePath))
            using (PdfDocument pdf = new PdfDocument(writer))
            {
                Document document = new Document(pdf);

                string fontPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fonts", "arial.ttf");
                PdfFont font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);


                document.Add(new Paragraph("HÓA ĐƠN")
                    .SetFont(font)
                    .SetFontSize(16)
                    .SetBold()
                    .SetTextAlignment(TextAlignment.CENTER));

                document.Add(new Paragraph("Thông tin hóa đơn:")
                    .SetFont(font)
                    .SetFontSize(12)
                    .SetBold());

                Table table = new Table(dataGridView.Columns.Count);

                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    table.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText).SetFont(font).SetBold()));
                }

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            table.AddCell(new Cell().Add(new Paragraph(cell.Value?.ToString() ?? string.Empty).SetFont(font)));
                        }
                    }
                }

                document.Add(table);

                decimal totalAmount = GetTotalAmount(dataGridView);
                document.Add(new Paragraph($"Tổng tiền: {totalAmount:N0} VND")
                    .SetFont(font)
                    .SetFontSize(12)
                    .SetBold());

                document.Close();
            }
        }


        private decimal GetTotalAmount(DataGridView dataGridView)
        {
            decimal totalAmount = 0m;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var cellValue = row.Cells["TongTien"].Value;
                    if (cellValue != null && decimal.TryParse(cellValue.ToString(), out decimal amount))
                    {
                        totalAmount += amount;
                    }
                }
            }
            return totalAmount;
        }


        private void btnXuat_Click(object sender, EventArgs e)
        {


            bool allPaid = true;

            foreach (DataGridViewRow row in dgvXuat.Rows)
            {
                if (row.IsNewRow) continue;

                string trangThai = row.Cells["TrangThai"].Value?.ToString();
                if (trangThai == null)
                {
                    MessageBox.Show($"Hóa đơn với ID {row.Cells["IdHoaDon"].Value} có trạng thái không hợp lệ.",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    allPaid = false;
                    break;
                }

                if (!trangThai.Equals("Đã thanh toán", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Hóa đơn với ID {row.Cells["IdHoaDon"].Value} chưa thanh toán.",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    allPaid = false;
                    break;
                }
            }

            if (allPaid)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files|*.pdf";
                    saveFileDialog.Title = "Lưu File PDF";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        CreateInvoicePDF(dgvXuat, saveFileDialog.FileName);
                        MessageBox.Show("Dữ liệu đã được xuất ra file PDF thành công!",
                                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chỉ những hóa đơn đã thanh toán mới được xuất ra file PDF.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public void loadhoadonxuat(int id)
        {
            dthd.Rows.Clear();
            var result = from hd in hoaDonBLL.getAllHD()
                         join kh in hoaDonBLL.getAllKhachhang()
                         on hd.IdKh equals kh.IdKh
                         where id == hd.IdHoaDon
                         select new
                         {
                             hd.IdHoaDon,
                             kh.TenKh,
                             hd.TenMonAn,
                             hd.TongTien,
                             hd.NgayHoaDon,
                             hd.TrangThai,
                         };

            foreach (var item in result)
            {
                DataRow dr = dthd.NewRow();
                dr["IdHoaDon"] = item.IdHoaDon;
                dr["TenKh"] = item.TenKh;
                dr["TenMonAn"] = item.TenMonAn != null ? (object)item.TenMonAn : DBNull.Value;
                dr["TongTien"] = item.TongTien.HasValue ? (object)item.TongTien.Value : DBNull.Value;
                dr["NgayHoaDon"] = item.NgayHoaDon;
                dr["TrangThai"] = item.TrangThai;
                dthd.Rows.Add(dr);
            }
            dgvXuat.DataSource = dthd;

        }

        private void cbbTrangThai_TextChanged(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            string searchBy = cbbTrangThai.SelectedItem?.ToString();
            var result = from hd in hoaDonBLL.getAllHD()
                         where //hd.NgayHoaDon >= ngaytu &&
                         //      hd.NgayHoaDon <= ngayden &&
                               hd.TrangThai == searchBy
                         select new
                         {
                             hd.IdHoaDon,
                             hd.IdKh,
                             hd.TenMonAn,
                             hd.TongTien,

                             hd.NgayHoaDon,
                             hd.TrangThai,
                         };
            foreach (var item in result)
            {
                DataRow dr = dt.NewRow();

                dr["IdHoaDon"] = item.IdHoaDon;
                dr["IdKh"] = item.IdKh;
                dr["TenMonAn"] = item.TenMonAn != null ? (object)item.TenMonAn : DBNull.Value;
                dr["TongTien"] = item.TongTien.HasValue ? (object)item.TongTien.Value : DBNull.Value;

                dr["NgayHoaDon"] = item.NgayHoaDon;
                dr["TrangThai"] = item.TrangThai;
                dt.Rows.Add(dr);
            }
        }
    }
}
