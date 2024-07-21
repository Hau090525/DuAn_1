using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
    {
        QlNhaHangContext dbcontex = new QlNhaHangContext();

        NhanVien nhanVien = new NhanVien();
        
        public List<NhanVien> getAllnhanvien()
        {
            var nhanVien = dbcontex.NhanViens.ToList();
            return nhanVien;
        }
    }
}
