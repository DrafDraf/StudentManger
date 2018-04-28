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
        MonHocBLL monhoc;

        public QuanLyMonHoc()
        {
            InitializeComponent();
            monhoc = new MonHocBLL();
        }

        /// <summary>
        /// load source cac mon hoc len combobox tab-page bang diem mon hic
        /// </summary>
        void LoadMonHoc_BangDiemMonHoc()
        {
            List<MonHoc> listMonHoc = monhoc.GetListMonHoc();

            //load source cac mon hoc len combobox tab-page bang diem mon hic
            List<string> listTenMH = new List<string>();
            listTenMH.Add("tat ca cac mon");
            foreach (MonHoc mon in listMonHoc)
            {
                listTenMH.Add(mon.TenMonHoc);
            }
            cbDanhSachMonHoc.DataSource = listTenMH;
        }

        /// <summary>
        /// Load danh sach mon hoc len tab-page danh sach mon hoc
        /// </summary>
        void LoadMonHoc_DanhSachMonHoc()
        {
            List<MonHoc> listMonHoc = monhoc.GetListMonHoc();
            
            int soThuTu = 1;
            foreach (MonHoc mon in listMonHoc)
            {
                ListViewItem lvi = new ListViewItem(soThuTu + "");
                lvi.SubItems.Add(mon.MaMonHoc);
                lvi.SubItems.Add(mon.TenMonHoc);
                soThuTu++;

                lvDanhSachMonHoc.Items.Add(lvi);
            }
        }

        /// <summary>
        /// Load toan bo hinh thuc kiem tra len tab-page hinh thuc kt
        /// </summary>
        void LoadHinhThucKiemtra()
        {
            HinhThucKiemTraBLL htkt = new HinhThucKiemTraBLL();

            List<HinhThucKiemTra> listHinhThucKiemTra = new List<HinhThucKiemTra>();
            listHinhThucKiemTra = htkt.GetAllHinhThucKiemTra();

            int soTT=1;
            foreach(HinhThucKiemTra hinhThuc in listHinhThucKiemTra)
            {
                ListViewItem lvi = new ListViewItem(soTT + "");
                lvi.SubItems.Add(hinhThuc.MaHTKT);
                lvi.SubItems.Add(hinhThuc.TenHTKT);
                lvi.SubItems.Add(hinhThuc.HeSo+"");

                lvHinhThucKT.Items.Add(lvi);
            }
        }
        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            LoadMonHoc_BangDiemMonHoc();
            LoadMonHoc_DanhSachMonHoc();
            LoadHinhThucKiemtra();
        }
    }
}
