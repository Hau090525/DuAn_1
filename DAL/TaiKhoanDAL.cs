using System;
using DTO.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class TaiKhoanDAL
    {
        QlNhaHangContext dbcontext=new QlNhaHangContext();
        public bool ValidateEmployeeUser(string email, string password, out int employeeId)
        {
            var user = dbcontext.Taikhoans
                .FirstOrDefault(e => e.Email == email && e.MatKhau == password );

            if (user != null)
            {
                employeeId = user.IdNv ??0; 
                return true;
            }
            else
            {
                employeeId = 0;
                return false;
            }
        }
        public string GetEmployeeNameById(int employeeId)
        {
            var employee = dbcontext.NhanViens.Find(employeeId);
            return employee?.TenNv; // Giả sử Employee có thuộc tính Name
        }
        public bool AddTaiKhoan(Taikhoan taikhoan)
        {
            try
            {
                dbcontext.Taikhoans.Add(taikhoan);
                return dbcontext.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool IsEmployeeAccount(int idNd)
        {
            var taikhoan = dbcontext.Taikhoans
               .FirstOrDefault(t => t.IdNd == idNd);

            return taikhoan != null && taikhoan.IdNv.HasValue;
        }
    }
}
