using System;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Models;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL taikhoanDAL=new TaiKhoanDAL();
        public bool ValidateEmployeeUser(string email, string password, out int employeeId)
        {
            // Giả sử bạn đã có một phương thức xác thực và lấy ID nhân viên từ DAL
            return taikhoanDAL.ValidateEmployeeUser(email, password, out employeeId);
        }

        // Lấy tên nhân viên theo ID
        public string GetEmployeeNameById(int employeeId)
        {
            return taikhoanDAL.GetEmployeeNameById(employeeId); // Phương thức này sẽ được thực hiện trong DAL
        }

        public bool AddTaiKhoan(int id, string email, string matkhau, string trangthai, string vaicho, string diachi, string sdt)
        {
            var taikhoan = new Taikhoan
            {
                IdNd = id,
                Email = email,
                MatKhau = matkhau,
                TrangThai = trangthai,
                VaiTro = vaicho,
                DiaChi = diachi,
                Sdt = sdt
            };
            return taikhoanDAL.AddTaiKhoan(taikhoan);
        }
    }
}
