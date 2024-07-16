using System;
using DTO.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhoDAL
    {
        QlNhaHangContext dbcontext = new QlNhaHangContext();

        public List<Kho> GetAllKho()
        {
            var kho=dbcontext.Khos.ToList();
            return kho;
        }
        public List<Nguyenlieu> GetAllNguyenlieu()
        {
            var nguyenlieu =dbcontext.Nguyenlieus.ToList();
            return nguyenlieu;
        }
       public bool AddCuaHang(Nguyenlieu nguyenlieu)
        {
            dbcontext.Nguyenlieus.Add(nguyenlieu);
            return dbcontext.SaveChanges()>0;
        }
       
    }
}
