using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Hoadonservice
    {
        public Hoadonrepos Hoadonrepos;
        public Hoadonservice()
        {
            Hoadonrepos = new Hoadonrepos();
        }
        public List<Hoadon> getallhoadon()
        {
            return Hoadonrepos.getallhoadon();
        }
    }
}
