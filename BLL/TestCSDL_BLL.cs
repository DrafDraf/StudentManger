using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TestCSDL_BLL
    {
        TestCSDLAccess t = new TestCSDLAccess();
        public List<TestMonHoc> GetListMonHoc()
        {
            return t.GetListMonHoc();
        }
    }
}
