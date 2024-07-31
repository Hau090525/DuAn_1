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
        Hoadon hoadon = new Hoadon();
        Hoadonchitiet hdct = new Hoadonchitiet();
        Monan monan = new Monan();
        Ban ban = new Ban();
        Voucher voucher = new Voucher();
        Khachhang khachhang = new Khachhang();
        NhanVien nhanVien = new NhanVien();

        public List<NhanVien> getallnhanvien()
        {
            return dbcontext.NhanViens.ToList();
        }
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
        public Khachhang GetKhachhang(int idkh)
        {
            return dbcontext.Khachhangs.FirstOrDefault(kh => kh.IdKh == idkh);
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
