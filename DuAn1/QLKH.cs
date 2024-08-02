using DTO.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class QLKH : Form
    {
        public QLKH()
        {
            InitializeComponent();
        }
        DataTable dthd = new DataTable();
        private void QLKH_Load(object sender, EventArgs e)
        {
            if (dthd.Columns.Count == 0)
            {

                dthd.Columns.Add("Idkh", typeof(int));
                dthd.Columns.Add("TenKh", typeof(string));
                dthd.Columns.Add("sdt", typeof(string));

            }
            dgvKH.DataSource = dthd;
            loaddulieu();
        }
        public void loaddulieu()
        {
            dthd.Rows.Clear();
            using (var context = new QlNhaHangContext())
            {
                var result = from hd in context.Khachhangs
                             select new
                             {

                                 hd.IdKh,
                                 hd.TenKh,
                                 hd.Sdt
                             };
                foreach (var item in result)
                {
                    DataRow dr = dthd.NewRow();


                    dr["IdKh"] = item.IdKh;
                    dr["TenKh"] = item.TenKh;
                    dr["sdt"] = item.Sdt;
                    dthd.Rows.Add(dr);
                }
            }
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtTK.Text;
            dthd.Rows.Clear();

            using (var context = new QlNhaHangContext())
            {
                var result = context.Khachhangs
                    .Where(h => h.TenKh.Contains(searchText))
                    .Select(h => new
                    {
                        h.IdKh,
                        h.TenKh,
                        h.Sdt,
                       
                    })
                    .ToList();

                foreach (var kh in result)
                {
                    dthd.Rows.Add(kh.IdKh, kh.TenKh, kh.Sdt);
                }
            }
        }
    }
}
