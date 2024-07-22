using DTO.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class taikhoanrepos
    {
        public QlNhaHangContext dbcontext;
        public taikhoanrepos()
        {
            dbcontext = new QlNhaHangContext();
        }
        public Taikhoan gettaikhoan(string email, string matkhau)
        {
            return dbcontext.Taikhoans
                           .FirstOrDefault(u => u.Email == email && u.MatKhau == matkhau);
        }
        public bool addtaikhoan(Taikhoan taikhoan)
        {
            dbcontext.Taikhoans.Add(taikhoan);
            dbcontext.SaveChanges();
            return true;
        }
       
    }
}
