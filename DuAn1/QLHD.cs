using BLL;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using DTO.Models;
using static System.Net.Mime.MediaTypeNames;


namespace GUI
{
    public partial class QLHD : Form
    {
        public QLHD()
        {
            InitializeComponent();
        }
        QLHDBLL hoaDonBLL = new QLHDBLL();
        DataTable dt = new DataTable();
        DataTable dtKH = new DataTable();
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

            }
            if (dtKH.Columns.Count == 0)
            {

                dtKH.Columns.Add("IdKh", typeof(int));
                dtKH.Columns.Add("TenKh", typeof(string));
                dtKH.Columns.Add("DiemTichLuy", typeof(int));
                dtKH.Columns.Add("Sdt", typeof(string));
                dtKH.Columns.Add("TenNv", typeof(string));
                dtKH.Columns.Add("Sdtnv", typeof(string));

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
            dgvKhachHang.DataSource = dtKH;
            dgvHoaDon.DataSource = dt;
            dgvXuat.DataSource = dthd;

        }
        public void loaddulieu()
        {
            dt.Rows.Clear();
            var result = hoaDonBLL.getAllHD().ToList();
            foreach (var item in result)
            {
                DataRow dr = dt.NewRow();

                dr["IdHoaDon"] = item.IdHoaDon;
                dr["IdKh"] = item.IdKh;
                dr["TenMonAn"] = item.TenMonAn;
                dr["TongTien"] = item.TongTien;
                dr["TienGiam"] = item.TienGiam;
                dr["NgayHoaDon"] = item.NgayHoaDon;
                dr["TrangThai"] = item.TrangThai;
                dt.Rows.Add(dr);
            }
        }
        public void loaddulieuloc(string trangthai, DateOnly ngaytu,DateOnly ngayden)
        {
            dt.Rows.Clear();
            var result = from hd in hoaDonBLL.getAllHD()
                         where hd.NgayHoaDon >= ngaytu &&
                               hd.NgayHoaDon <= ngayden &&
                               hd.TrangThai == trangthai
                         select new
                         {
                             hd.IdHoaDon,
                             hd.IdKh,
                             hd.TenMonAn,
                             hd.TongTien,
                             hd.TienGiam,
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
                dr["TienGiam"] = item.TienGiam;
                dr["NgayHoaDon"] = item.NgayHoaDon;
                dr["TrangThai"] = item.TrangThai;
                dt.Rows.Add(dr);
            }
        }
        public void loadkhachhang(int id)
        {
            dtKH.Rows.Clear();

            var result = from kh in hoaDonBLL.getAllKhachhang()
                         join nv in hoaDonBLL.getAllnhanvien()
                         on kh.IdKh equals nv.IdNd
                         where kh.IdKh == id
                         select new
                         {
                             kh.IdKh,
                             kh.TenKh,
                             kh.DiemTichLuy,
                             kh.Sdt,
                             nv.TenNv,
                             sodt = nv.Sdt,
                             
                         };
            foreach (var item in result)
            {
                DataRow dr = dtKH.NewRow();
                dr["IdKh"] = item.IdKh;
                dr["TenKh"] = item.TenKh;
                dr["DiemTichLuy"] = item.DiemTichLuy;
                dr["Sdt"] = item.Sdt;
                dr["TenNv"] = item.TenNv;
                dr["Sdtnv"] = item.sodt;
                dtKH.Rows.Add(dr);
            }
            dgvKhachHang.DataSource = dtKH;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            loaddulieu();
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
                loaddulieuloc(trangthai, ngaylocc, ngaysau);
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
                loadkhachhang(idKh);
                loadhoadonxuat(idKh);
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
                    string tenMonAn = selectedRow.Cells["TenMonAn"].Value.ToString();
                    decimal tongTien = (decimal)selectedRow.Cells["TongTien"].Value;
                    decimal tienGiam = (decimal)selectedRow.Cells["TienGiam"].Value;
                    DateOnly ngayHoaDon = (DateOnly)selectedRow.Cells["NgayHoaDon"].Value;

                    string message = $"Hóa đơn cần thanh toán:\n\n" +
                                     $"ID Hóa Đơn: {idHoaDon}\n" +
                                     $"Tên Khách Hàng: {tenKh}\n" +
                                     $"Tên Món Ăn: {tenMonAn}\n" +
                                     $"Tổng Tiền: {tongTien:C}\n" +
                                     $"Tiền Giảm: {tienGiam:C}\n" +
                                     $"Ngày Hóa Đơn: {ngayHoaDon:dd/MM/yyyy}\n\n" +
                                     $"Xác nhận thanh toán?";

                    DialogResult result = MessageBox.Show(message, "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        selectedRow.Cells["TrangThai"].Value = "Đã thanh toán";
                        MessageBox.Show("Hóa đơn đã được thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Cập nhật trạng thái trong cơ sở dữ liệu
                        hoaDonBLL.update(idHoaDon, "Đã thanh toán");
                    }
                }
            }
        }
        private void ExportToPDF(DataGridView dataGridView, string filePath)
        {
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            PdfPTable table = new PdfPTable(dataGridView.Columns.Count);

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                table.AddCell(cell);
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    table.AddCell(cell.Value?.ToString());
                }
            }

            document.Add(table);
            document.Close();
            writer.Close();
        }

        

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bool trangthai = true;

            foreach (DataGridViewRow row in dgvXuat.Rows)
            {
                if (row.Cells["TrangThai"].Value?.ToString() != "Đã Thanh Toán")
                {
                    trangthai = false;
                    break;
                }
            }

            if (!trangthai)
            {
                MessageBox.Show("Chỉ những hóa đơn đã thanh toán mới được xuất ra file PDF.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Save a PDF File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToPDF(dgvXuat, saveFileDialog.FileName);
                MessageBox.Show("Dữ liệu đã được xuất ra file PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void loadhoadonxuat(int id)
        {
            dthd.Rows.Clear();
            var result = from hd in hoaDonBLL.getAllHD()
                         join kh in hoaDonBLL.getAllKhachhang()
                         on hd.IdKh equals kh.IdKh
                         where id == hd.IdKh
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
                dr["TenMonAn"] = item.TenMonAn;
                dr["TongTien"] = item.TongTien;
                dr["NgayHoaDon"] = item.NgayHoaDon;
                dr["TrangThai"] = item.TrangThai;
                dthd.Rows.Add(dr);
            }
            dgvXuat.DataSource = dthd;
        }
    }
}
