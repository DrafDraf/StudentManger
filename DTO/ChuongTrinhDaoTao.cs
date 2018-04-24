using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChuongTrinhDaoTao
    {
        string MaKhoiLop;
		string MaMonHoc ;
		int HeSoMon ;

        public ChuongTrinhDaoTao(string kl,string mh,int hs)
        {
            this.MaKhoiLop = kl;
            this.MaMonHoc = mh;
            this.HeSoMon = hs;
        }
    }
}
