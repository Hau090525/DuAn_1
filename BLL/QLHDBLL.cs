using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class QLHDBLL
    {
        QLHDDAL qlhdDAL = new QLHDDAL();
        public List<Hoadon> getAllHD()
        {
            return qlhdDAL.getallHD().ToList();
        }
        public List<Khachhang> getAllKhachhang()
        {
            return qlhdDAL.getallKH().ToList();


        }
        public List<Ban> getBan()
        {
            return qlhdDAL.getban().ToList();


        }
       public List<NhanVien> getallnv()
        {
            return qlhdDAL.getallNV().ToList();
        }
        public string update(int id,string trangthai)
        {
            Hoadon hoadon = new Hoadon()
            {
                IdHoaDon = id,
                TrangThai = trangthai,
            };
            if (qlhdDAL.update(hoadon))
            {
                return "thanh toan thanh cong";

            }
            else return "thanh toan that bai";
        }
        public void UpdateBanStatus(int idBan, string trangThai)
        {
            qlhdDAL.UpdateBanStatus(idBan, trangThai);
        }
    }
}
