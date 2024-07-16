using System;
using DAL;
using DTO.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
    }
}
