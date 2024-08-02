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
            return qlhdDAL.getallHD();
        }
        public List<Khachhang> getAllKhachhang()
        {
            return qlhdDAL.getallKH();


        }
      
       public List<NhanVien> getallnv()
        {
            return qlhdDAL.getallNV().ToList();
        }
        
    }
}
