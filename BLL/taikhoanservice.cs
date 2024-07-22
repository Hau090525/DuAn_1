using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class taikhoanservice
    {
        private taikhoanrepos taikhoanrepos;

        public taikhoanservice()
        {
            taikhoanrepos = new taikhoanrepos();
        }

        public bool ValidateUser(string email, string matkhau)
        {
            var taikhoan = taikhoanrepos.gettaikhoan(email, matkhau);
            return taikhoan != null;
        }
        public bool Addtaikhoan(int id,string email, string matkhau, string trangthai, string vaicho, string diachi,string sdt) // truyền vào các thuộc tính
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
           return taikhoanrepos.addtaikhoan(taikhoan);
        }
    }
}
