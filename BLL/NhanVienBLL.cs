using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL nhanVienDAL = new NhanVienDAL();
        NhanVien nhanVien = new NhanVien();

        public List<NhanVien> getAllnhanvien()
        {
            
           return nhanVienDAL.getAllnhanvien().ToList();

        }
        


    }
}
