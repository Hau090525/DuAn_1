using System;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Models;

namespace BLL
{
    public class DatBanBLL
    {
        DatBanDAL datbanDAL = new DatBanDAL();
        Hoadon hoadon = new Hoadon();
        Monan monan = new Monan();
        private int GetNextIdHoaDon()
        {
            using (var context = new QlNhaHangContext())
            {
                var maxId = context.Hoadons.Max(hd => (int?)hd.IdHoaDon) ?? 0;
                return maxId + 1;
            }
        }
        public void luuthongtin(int idban, int idkhachhang, DateOnly ngaydat,int? idnv)
        {
            int newHoaDonId = GetNextIdHoaDon();
            var hoadon = new Hoadon()
            {
                IdHoaDon = newHoaDonId,

                IdBan = idban,
                IdKh = idkhachhang,
                NgayHoaDon = ngaydat,
                TrangThai = "Chưa thanh toán",
                IdNv= idnv
                
                
            };


            Console.WriteLine($"Tạo hóa đơn mới: IdHoaDon = {hoadon.IdHoaDon}, IdBan = {hoadon.IdBan}");

            datbanDAL.LuuThongTinDatBan(hoadon);
        }
        public void CapNhatThongTinHoaDon(int idHoaDon)
        {
            datbanDAL.CapNhatThongTinHoaDon(idHoaDon);
        }

        public void themmonanvaohd(int idhd, int idmonan,  int soluong)
        {
          
               
                var donGia = datbanDAL.gettenmonan()
                    .Where(ma => ma.IdMonAn == idmonan)
                    .Select(ma => ma.DonGia)
                    .FirstOrDefault();

              
                var chiTietHoaDon = datbanDAL.gethdct()
                    .FirstOrDefault(ct => ct.IdHoaDon == idhd && ct.IdMonAn == idmonan);

                if (chiTietHoaDon != null)
                {
                   
                    chiTietHoaDon.SoLuong += soluong;
                    chiTietHoaDon.ThanhTien = chiTietHoaDon.SoLuong * donGia;
                }
                else
                {
                   
                    var chitiethd = new Hoadonchitiet()
                    {
                        IdHoaDon = idhd,
                        IdMonAn = idmonan,
                        SoLuong = soluong,
                        ThanhTien = soluong * donGia
                    };

                    datbanDAL.themmonan(chitiethd);
                }

              

               
                CapNhatThongTinHoaDon(idhd);
            
        }
        public decimal TinhTongTien(int idHoaDon)
        {
            return datbanDAL.Tinhtien(idHoaDon);
        }

        public int GetHoaDonIdByBan(int idBan)
        {
            return datbanDAL.gethoadon(idBan);
        }

        public void CapNhatTrangThaiBan(int idBan, string trangThai)
        {
            datbanDAL.CatNhatTrangThai(idBan, trangThai);
        }
        public List<Monan> gettenma()
        {
            return datbanDAL.gettenmonan().ToList();
        }
        public decimal TinhTongTienForMonAn(int idMonAn, int soLuong)
        {
            
                var donGia = datbanDAL.gettenmonan().FirstOrDefault(m => m.IdMonAn == idMonAn)?.DonGia ?? 0;
                return donGia * soLuong;
            
        }
        public List<Ban> ban()
        {
            var ban=datbanDAL.getban().ToList();
            return ban;
            
        }
    }
}
