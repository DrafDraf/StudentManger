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
    public partial class QuanLyLopHoc : Form
    {
        LopBLL lophoc;
        KhoiLopBLL khoilop;
        HocKyBLL hocky;
        NamHocBLL namhoc;
        public QuanLyLopHoc()
        {
            InitializeComponent();
            lophoc = new LopBLL();
            khoilop = new KhoiLopBLL();
            hocky = new HocKyBLL();
            namhoc = new NamHocBLL();

        }
        void Loadlophoc_Danhsachhocsinh()
        {

            List<Lop> listLophoc = lophoc.GetListLop();

            //load source cac lop hoc len combobox tab-page bang diem mon hic
            List<string> listTenLophoc = new List<string>();
            listTenLophoc.Add("tat ca cac lop");
            foreach (Lop lop in listLophoc)
            {
                listTenLophoc.Add(lop.TenLop);
            }
        }
        
       
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
