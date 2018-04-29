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
using QLHS.FormBoSung;

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
            lvDanhSachMonHoc.Items.Clear();
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
            lvHinhThucKT.Items.Clear();
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
                soTT++;
            }
        }

        /// <summary>
        /// Load danh sach chuong trinh dao tao len tab-page CTDD
        /// </summary>
        void LoadChuongTrinhDaoTao()
        {
            lvCTDT.Items.Clear();
            ChuongTrinhDaoTaoBLL ctdt = new ChuongTrinhDaoTaoBLL();
            List<ChuongTrinhDaoTao> listCTDT = new List<ChuongTrinhDaoTao>();
            listCTDT = ctdt.GetAllCTDT();

            int STT = 1;
            foreach(ChuongTrinhDaoTao ct in listCTDT)
            {
                ListViewItem lvi = new ListViewItem(STT + "");
                lvi.SubItems.Add(ct.MaKhoiLop);
                lvi.SubItems.Add(ct.MaMonHoc);
                lvi.SubItems.Add(ct.HeSoMon+"");

                lvCTDT.Items.Add(lvi);
                STT++;
            }
        }

        void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            LoadMonHoc_DanhSachMonHoc(); 
        }
        


        private void tcQuanLyMonHoc_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1)
            {
                LoadMonHoc_BangDiemMonHoc();
            }
            else
                if (e.TabPageIndex == 2)
            {
                LoadHinhThucKiemtra();
            }
            else
                LoadChuongTrinhDaoTao();
        }

        /// <summary>
        /// Them mon hoc vao CSDL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btThemMH_Click(object sender, EventArgs e)
        {
            //open form them mon hoc
            ThemMonHoc themMH = new ThemMonHoc();
            themMH.Show();
        }

        private void btSuaMH_Click(object sender, EventArgs e)
        {
            if (lvDanhSachMonHoc.SelectedItems.Count > 0)
            {
                //load form sua truyen thong tin tu selected item qua
            }
            else
                MessageBox.Show("Bạn phải chọn 1 môn học để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaMonHoc_Click(object sender, EventArgs e)
        {
            if (lvDanhSachMonHoc.SelectedItems.Count > 0)
            {
                MonHocBLL mh = new MonHocBLL();
                ListViewItem lv = lvDanhSachMonHoc.SelectedItems[0];
                string ma = lv.SubItems[1].Text;
                if (mh.XoaMonHoc(ma) == true)
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại,Bạn không thể xóa môn học còn đang sử dụng giảng dạy !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Bạn phải chọn 1 môn học để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
