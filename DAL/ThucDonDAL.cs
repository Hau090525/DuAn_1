using System;
using DTO.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThucDonDAL
    {

        QlNhaHangContext dbcontex = new QlNhaHangContext();

        Monan monan= new Monan();

        public List<Monan> getallmonan()
        {
            var monan= dbcontex.Monans.ToList();
            return monan;
        }

        public bool addmonan(Monan monan)
        {
            dbcontex.Monans .Add(monan);
            return dbcontex.SaveChanges()>0;
        }
        public bool updateMonAn(Monan monan)
        {
            var update = dbcontex.Monans.Find(monan.IdMonAn);
            update.IdMonAn=monan.IdMonAn;
            update.TenMon=monan.TenMon;
            update.DonGia=monan.DonGia;
            update.Loai=monan.Loai;
            update.TrangThai=monan.TrangThai;


            dbcontex.Monans.Update(update);
            return dbcontex.SaveChanges()>0;
        }
        public bool deleteMonan(int id)     
        {
            var delete = dbcontex.Monans.Find(id);
            dbcontex.Monans.Remove(delete);
            return dbcontex.SaveChanges()>0;

        }
    }
}
