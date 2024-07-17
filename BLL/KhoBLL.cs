using System;
using DAL;
using DTO.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace BLL
{
    public class KhoBLL
    {
        Nguyenlieu nguyenlieu = new Nguyenlieu();
        Kho kho = new Kho();
        KhoDAL khoDAL = new KhoDAL();

        public List<Kho> GetAllKho()
        {
            return khoDAL.GetAllKho().ToList();
        }
        public List<Nguyenlieu> GetAllNL()
        {
            return khoDAL.GetAllNguyenlieu().ToList();
        }
        public string add(int id,string ten , decimal dongia, int  soluong,string donvitinh, int idkho )
        {
            Nguyenlieu nguyenlieu = new Nguyenlieu()
            {
                IdNl = id,
                TenNl = ten,
                DonGia = dongia,
                DonViTinh = donvitinh,
                SoLuong = soluong,

                IdKho = idkho,
            };
            var kho = khoDAL.GetAllKho().FirstOrDefault(k => k.IdKho == nguyenlieu.IdKho);
            if (kho == null)
            {
                // Nếu không tìm thấy kho, trả về thông báo lỗi
                return "Kho không tồn tại.";
            }
            if (khoDAL.AddNguyenlieu(nguyenlieu,soluong,idkho))
            {
                return "Them thanh cong";

            }
            else return "Them that bai";
        }
        public string update(int id, string ten, decimal dongia, int soluong, string donvitinh, int idkho)
        {
            Nguyenlieu nguyenlieu = new Nguyenlieu()
            {
                IdNl = id,
                TenNl = ten,
                DonGia = dongia,
                DonViTinh = donvitinh,
                SoLuong = soluong,
                IdKho=idkho,

               
            };
            var kho = khoDAL.GetAllKho().FirstOrDefault(k => k.IdKho == nguyenlieu.IdKho);
            if (kho == null)
            {
                // Nếu không tìm thấy kho, trả về thông báo lỗi
                return "Kho không tồn tại.";
            }
            if (khoDAL.UpdateNguyenlieu(nguyenlieu, soluong,idkho ))
            {
                return "Sua thanh cong";

            }
            else return "Sua that bai";
        }
        public string delete(int id,int soluong,int idkho)
        {

            if (khoDAL.DeleteNguyenlieu(id,soluong,idkho))
            {
                return "Xoa thanh cong";

            }
            else return "Xoa that bai";
        }
    }
    }

