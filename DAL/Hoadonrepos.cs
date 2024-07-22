using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAL
{
    public class Hoadonrepos
    {
        public QlNhaHangContext dbcontext;
        public Hoadonrepos()
        {
            dbcontext = new QlNhaHangContext();
        }
        public List<Hoadon> getallhoadon()
        {
            return dbcontext.Hoadons.ToList();
        }
    }

}
