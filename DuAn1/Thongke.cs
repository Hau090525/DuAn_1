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

namespace GUI
{
    public partial class Thongke : Form
    {
        public Hoadonservice Hoadonservice;
        public Thongke()
        {
            InitializeComponent();
            Hoadonservice = new Hoadonservice();
        }

        private void Thongke_Load(object sender, EventArgs e)
        {

        }
        private void LoadData(dynamic data)
        {
            dataGridView1.Rows.Clear();

            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "ID"; dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].Name = "Idkhach"; dataGridView1.Columns[1].HeaderText = "ID khách hàng";
            dataGridView1.Columns[2].Name = "Idban"; dataGridView1.Columns[2].HeaderText = "ID bàn ăn";
            dataGridView1.Columns[3].Name = "Tenmon"; dataGridView1.Columns[3].HeaderText = "Tên món ăn";
            dataGridView1.Columns[4].Name = "Tiengiam"; dataGridView1.Columns[4].HeaderText = "Tiền giảm";
            dataGridView1.Columns[5].Name = "tongtien"; dataGridView1.Columns[5].HeaderText = "Tổng tiền";
            dataGridView1.Columns[6].Name = "trangthai"; dataGridView1.Columns[6].HeaderText = "Trạng thái";


            foreach (var item in data)
            {
                dataGridView1.Rows.Add(item.IdHoaDon, item.IdKh, item.IdBan, item.TenMonAn, item.TienGiam, item.TongTien, item.TrangThai);

            }

        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            LoadData(Hoadonservice.getallhoadon());
        }
    }
}
