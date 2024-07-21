using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using BLL;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DuAn1
{
    public partial class QuanLiThucDon : Form
    {
        public QuanLiThucDon()
        {
            InitializeComponent();
        }
        ThucDonBLL thucdonBLL = new ThucDonBLL();
        DataTable dt = new DataTable();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void loaddulieu()
        {
            dt.Rows.Clear();

            if (dt.Columns.Count == 0)
            {

                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Ten", typeof(string));
                dt.Columns.Add("Gia", typeof(decimal));
                dt.Columns.Add("Loai", typeof(string));
                dt.Columns.Add("TrangThai", typeof(string));

            }
            var result = thucdonBLL.getallmonan().ToList();
            foreach (var t in result)
            {
                DataRow dr = dt.NewRow();


                dr["ID"] = t.IdMonAn;
                dr["Ten"] = t.TenMon;
                dr["Gia"] = t.DonGia;
                dr["Loai"] = t.Loai;
                dr["TrangThai"] = t.TrangThai;

                dt.Rows.Add(dr);
            }
            dgvLoad.DataSource = dt;

        }
        private void QuanLiThucDon_Load(object sender, EventArgs e)
        {
            loaddulieu();
        }

        private void dgvLoad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chon = e.RowIndex;
            var duocchon = dgvLoad.Rows[chon];
            txtLabel.Text = duocchon.Cells[0].Value.ToString();
            txtTen.Text = duocchon.Cells[1].Value.ToString();
            txtGia.Text = duocchon.Cells[2].Value.ToString();
            txtLoai.Text = duocchon.Cells[3].Value.ToString();
            txtTrangThai.Text = duocchon.Cells[4].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("ban co chac chan khong?", "them moi", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                string hau = thucdonBLL.add(Convert.ToInt32(txtLabel.Text), txtTen.Text, Convert.ToDecimal(txtGia.Text), txtLoai.Text, txtTrangThai.Text);
                MessageBox.Show("them thanh cong");
                loaddulieu();
            }
            else MessageBox.Show("them that bai");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("ban co chac chan khong?", "them moi", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                string hau = thucdonBLL.update(Convert.ToInt32(txtLabel.Text), txtTen.Text, Convert.ToDecimal(txtGia.Text), txtLoai.Text, txtTrangThai.Text);
                MessageBox.Show("Sua thanh cong");
                loaddulieu();
            }
            else MessageBox.Show("Sua that bai");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("ban co chac chan khong?", "Xoa ", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                string hau = thucdonBLL.delete(Convert.ToInt32(txtLabel.Text));
                MessageBox.Show("Xoa thanh cong");
                loaddulieu();
            }
            else MessageBox.Show("Xoa that bai");
        }
    }
}
