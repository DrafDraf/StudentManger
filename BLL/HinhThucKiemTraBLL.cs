using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class HinhThucKiemTraBLL:DatabaseBLL
    {
        public HinhThucKiemTraBLL() : base() { }

        public List<HinhThucKiemTra> GetAllHinhThucKiemTra()
        {
            HinhThucKiemTraAccess hinhThucKiemTra = new HinhThucKiemTraAccess();
            return hinhThucKiemTra.GetAllHinhThucKiemTra();
        }
    }
}
