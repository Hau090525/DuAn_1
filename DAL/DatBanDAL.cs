using System;
using DTO.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Azure;

namespace DAL
{
    public class DatBanDAL
    {
        QlNhaHangContext dbcontext = new QlNhaHangContext();

        public List<Monan> gettenmonan()
        {
            return dbcontext.Monans.ToList();
        }
        public List<Ban> getban()
        {
            return dbcontext.Bans.ToList();
        }
        public List<Hoadonchitiet> gethdct()
        {
            return dbcontext.Hoadonchitiets.ToList();
        }
       
        public void LuuThongTinDatBan(Hoadon hoadon)
        {
           
                dbcontext.Hoadons.Add(hoadon);
                dbcontext.SaveChanges();
           
        }
        public void themmonan(Hoadonchitiet hoadonchitiet)
        {
            dbcontext.Hoadonchitiets.Add(hoadonchitiet);
            dbcontext.SaveChanges();
        }

        public decimal Tinhtien(int idHD)
        {
            var thanhTien = dbcontext.Hoadonchitiets
                .Where(hdct => hdct.IdHoaDon == idHD)
                .Sum(hdct => (decimal?)hdct.ThanhTien) ?? 0m;

            return thanhTien;
        }
        public int gethoadon(int idban)
        {
                var hoaDon = dbcontext.Hoadons
                                     .FirstOrDefault(hd => hd.IdBan == idban && hd.TrangThai == "Chưa thanh toán");
                return hoaDon?.IdHoaDon ?? 0; 
        }
        public void CatNhatTrangThai(int idban, string trangthai)
        {
            var ban = dbcontext.Bans.FirstOrDefault(b => b.IdBan == idban);
            if (ban != null)
            {
                ban.TrangThai = trangthai;
                dbcontext.SaveChanges();
            }
        }
        public void CapNhatThongTinHoaDon(int idHoaDon)
        {
            var hoaDon = dbcontext.Hoadons
        .Include(hd => hd.Hoadonchitiets)
        .FirstOrDefault(hd => hd.IdHoaDon == idHoaDon);

            if (hoaDon != null)
            {
                hoaDon.TongTien = Tinhtien(idHoaDon);

                var tenMonAnList = dbcontext.Hoadonchitiets
                    .Where(ct => ct.IdHoaDon == idHoaDon)
                    .Select(ct => ct.IdMonAnNavigation.TenMon)
                    .Distinct()
                    .ToList();

                hoaDon.TenMonAn = string.Join(", ", tenMonAnList);

                dbcontext.SaveChanges();
            }
        }

        public void CapNhatTienGiam(int idHoaDon, decimal tienGiam)
        {
           
                var hoaDon = dbcontext.Hoadons.FirstOrDefault(hd => hd.IdHoaDon == idHoaDon);
                if (hoaDon != null)
                {
                    hoaDon.TienGiam = tienGiam;
                    dbcontext.SaveChanges();
                
            }
        }
    }
}
