using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class MonHocBLL:DatabaseBLL
    {
        public MonHocBLL() : base()
        { }

       public List<MonHoc> GetListMonHoc()
        {
            MonHocAccess monHocAccess = new MonHocAccess();
            return monHocAccess.GetAllMonHoc();
        }
    }
}
