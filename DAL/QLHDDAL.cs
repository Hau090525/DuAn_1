using System;
using DTO.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class QLHDDAL
    {
        QlNhaHangContext dbcontext = new QlNhaHangContext();
        
      
        public List<Ban> getban()
        {
            return dbcontext.Bans.ToList();
        }
        public List<Hoadon> getallHD()
        {
            return dbcontext.Hoadons.ToList();
        }
        public List<Khachhang> getallKH()
        {
            return dbcontext.Khachhangs.ToList();
        }
        public List<NhanVien> getallNV()
        {
            return dbcontext.NhanViens.ToList();
        }
       
        public bool update(Hoadon hoadon)
        {
            var update = dbcontext.Hoadons.Find(hoadon.IdHoaDon);
            update.TrangThai=hoadon.TrangThai;

            dbcontext.Hoadons.Update(update);
            return dbcontext.SaveChanges()>0;
        }
       
        public void UpdateBanStatus(int idBan, string trangThai)
        {
            var ban = dbcontext.Bans.FirstOrDefault(b => b.IdBan == idBan);
            if (ban != null)
            {
                ban.TrangThai = trangThai;
                dbcontext.SaveChanges();
            }
        }
    }
}
