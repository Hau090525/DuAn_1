using System;
using DTO.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class KhoDAL
    {
        QlNhaHangContext dbcontext = new QlNhaHangContext();

        public List<Kho> GetAllKho()
        {
            var kho = dbcontext.Khos.ToList();
            return kho;
        }
        public List<Nguyenlieu> GetAllNguyenlieu()
        {
            var nguyenlieu = dbcontext.Nguyenlieus.ToList();
            return nguyenlieu;
        }
        public bool AddNguyenlieu(Nguyenlieu nguyenlieu, int SoLuong, int id)
        {

            var kho = dbcontext.Khos.FirstOrDefault(k => k.IdKho == nguyenlieu.IdKho);
            if (kho == null)
            {

                return false;
            }


            kho.SoLuongTon = (kho.SoLuongTon ?? 0) - SoLuong;


            dbcontext.Nguyenlieus.Add(nguyenlieu);


            return dbcontext.SaveChanges() > 0;
        }

        public bool UpdateNguyenlieu(Nguyenlieu nguyenlieu, int soLuongMoi, int idKhoMoi)
        {
           
               
                var existingNguyenlieu = dbcontext.Nguyenlieus.FirstOrDefault(nl => nl.IdNl == nguyenlieu.IdNl);

                if (existingNguyenlieu != null)
                {
                   
                    if (dbcontext.Entry(existingNguyenlieu).State == EntityState.Detached)
                    {
                        dbcontext.Attach(existingNguyenlieu);
                    }

                    
                    existingNguyenlieu.TenNl = nguyenlieu.TenNl;
                    existingNguyenlieu.DonGia = nguyenlieu.DonGia;
                    existingNguyenlieu.DonViTinh = nguyenlieu.DonViTinh;
                    existingNguyenlieu.IdKho = idKhoMoi;
                    existingNguyenlieu.SoLuong = soLuongMoi;

                    
                    var kho = dbcontext.Khos.FirstOrDefault(k => k.IdKho == idKhoMoi);
                    if (kho == null)
                    {
                        return false; 
                    }

                   
                    kho.SoLuongTon = (kho.SoLuongTon ?? 0) - nguyenlieu.SoLuong + soLuongMoi;

                    
                    int affectedRows = dbcontext.SaveChanges();

                    
                    return affectedRows > 0;
                }
                else
                {
                    return false; 
                }
            }
            
        
        public bool DeleteNguyenlieu(int idNl, int soLuong, int idKho)
        {
           
                var nguyenlieuToDelete = dbcontext.Nguyenlieus.FirstOrDefault(nl => nl.IdNl == idNl);

                if (nguyenlieuToDelete != null)
                {
                    
                    var kho = dbcontext.Khos.FirstOrDefault(k => k.IdKho == idKho);
                if (kho == null)
                {
                    return false;
                }
                    kho.SoLuongTon = (kho.SoLuongTon ?? 0) - soLuong;

                    
                    dbcontext.Nguyenlieus.Remove(nguyenlieuToDelete);

                    
                    int affectedRows = dbcontext.SaveChanges();

                    
                    return affectedRows > 0;
                }
                else
                {
                    return false; 
                }
            }
           
    }
}
