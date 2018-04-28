using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace QLHS.FormChinh
{
    public partial class QuanLyMonHoc : Form
    {
        public QuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            //load source cac mon hoc len combobox
            MonHocBLL monhoc = new MonHocBLL();
            List<MonHoc> listMonHoc = monhoc.GetListMonHoc();

            List<string> listTenMH = new List<string>();
            listTenMH.Add("tat ca cac mon");

            foreach(MonHoc mon in listMonHoc)
            {
                listTenMH.Add(mon.TenMonHoc);
            }

            cbDanhSachMonHoc.DataSource = listTenMH;
        }
    }
}
