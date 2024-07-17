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
                dt.Columns.Add("IDKho", typeof(int));
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
                        y.h.SoLuong,
                        y.h.DonViTinh,
                        y.h.IdKho
                    }
                ).ToList();

            foreach (var t in result)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = t.IdNl;
                dr["Tên"] = t.TenNl;
                dr["Đơn Giá"] = t.DonGia;
                dr["Số Lượng"] = t.SoLuong;
                dr["Đơn Vị Tính"] = t.DonViTinh;
                dr["IDKho"] = t.IdKho;

                dt.Rows.Add(dr);
            }

            dgvLoad.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("ban co chac chan khong?", "them moi", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                string hau = KhoBLL.add(Convert.ToInt32(txtID.Text), txtTen.Text, Convert.ToDecimal(txtDonGia.Text), Convert.ToInt32(txtSoLuong.Text), txtDonViTinh.Text, Convert.ToInt32(txtIDKho.Text));
                MessageBox.Show("them thanh cong");
                LoadDuLieu();
            }
            else MessageBox.Show("them that bai");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("ban co chac chan khong?", "them moi", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                string hau = KhoBLL.add(Convert.ToInt32(txtID.Text), txtTen.Text, Convert.ToDecimal(txtDonGia.Text), Convert.ToInt32(txtSoLuong.Text), txtDonViTinh.Text, Convert.ToInt32(txtIDKho.Text));
                MessageBox.Show("them thanh cong");
                LoadDuLieu();
            }
            else MessageBox.Show("them that bai");
        }
        private void dgvLoad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chon = e.RowIndex;
            var duocchon = dgvLoad.Rows[chon];
            txtID.Text = duocchon.Cells[0].Value.ToString();
            txtTen.Text = duocchon.Cells[1].Value.ToString();
            txtDonGia.Text = duocchon.Cells[2].Value.ToString();
            txtSoLuong.Text = duocchon.Cells[3].Value.ToString();
            txtDonViTinh.Text = duocchon.Cells[4].Value.ToString();
            txtIDKho.Text = duocchon.Cells[5].Value.ToString();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("ban co chac chan khong?", "them moi", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                string hau = KhoBLL.update(Convert.ToInt32(txtID.Text), txtTen.Text, Convert.ToDecimal(txtDonGia.Text), Convert.ToInt32(txtSoLuong.Text), txtDonViTinh.Text, Convert.ToInt32(txtIDKho.Text));
                MessageBox.Show("Sua thanh cong");
                LoadDuLieu();
            }
            else MessageBox.Show("Sua that bai");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("ban co chac chan khong?", "them moi", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                string hau = KhoBLL.delete(Convert.ToInt32(txtID.Text), Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(txtIDKho.Text));
                MessageBox.Show("Xoa thanh cong");
                LoadDuLieu();
            }
            else MessageBox.Show("Xoa that bai");

        }
    }
}
