using BLL;
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
    public partial class Kho : Form
    {
        public Kho()
        {
            InitializeComponent();
        }
        KhoBLL KhoBLL = new KhoBLL();
        DataTable dt = new DataTable();
        private void Kho_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        public void LoadDuLieu()
        {
            dt.Rows.Clear();
            if (dt.Columns.Count == 0) // Chỉ cần thêm cột nếu chưa có
            {
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Tên", typeof(string));
                dt.Columns.Add("Đơn Giá", typeof(decimal));
                dt.Columns.Add("Số Lượng", typeof(int));
                dt.Columns.Add("Đơn Vị Tính", typeof(string));
            }
            var result = KhoBLL.GetAllNL().ToList()
                .GroupJoin(KhoBLL.GetAllKho().ToList(),
                    x => x.IdKho,
                    kho => kho.IdKho,
                    (h, khos) => new { h, khos = khos.DefaultIfEmpty() })
                .SelectMany(
                    y => y.khos,
                    (y, khos) => new
                    {
                        y.h.IdNl,
                        y.h.TenNl,
                        y.h.DonGia,
                        khos = khos != null ? khos.SoLuongTon : (int?)null, 
                        y.h.DonViTinh,
                    }
                ).ToList();

            foreach (var t in result)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = t.IdNl;
                dr["Tên"] = t.TenNl;
                dr["Đơn Giá"] = t.DonGia;
                dr["Số Lượng"] = t.khos ?? 0; 
                dr["Đơn Vị Tính"] = t.DonViTinh;
                dt.Rows.Add(dr); 
            }

            dgvLoad.DataSource = dt;
        }

    }
}
