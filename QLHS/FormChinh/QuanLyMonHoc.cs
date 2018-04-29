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

            int soTT = 1;
            foreach (HinhThucKiemTra hinhThuc in listHinhThucKiemTra)
            {
                ListViewItem lvi = new ListViewItem(soTT + "");
                lvi.SubItems.Add(hinhThuc.MaHTKT);
                lvi.SubItems.Add(hinhThuc.TenHTKT);
                lvi.SubItems.Add(hinhThuc.HeSo + "");

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
            foreach (ChuongTrinhDaoTao ct in listCTDT)
            {
                ListViewItem lvi = new ListViewItem(STT + "");
                lvi.SubItems.Add(ct.MaKhoiLop);
                lvi.SubItems.Add(ct.MaMonHoc);
                lvi.SubItems.Add(ct.HeSoMon + "");

                lvCTDT.Items.Add(lvi);
                STT++;
            }
        }

        void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMonHoc_DanhSachMonHoc();
            }
            catch
            {
                MessageBox.Show("Không thể kết nối tới CSDL,vui lòng cài đặt lại kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Load CSDL lên form khi click vào tab-control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tcQuanLyMonHoc_Selected(object sender, TabControlEventArgs e)
        {
            try
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
            catch
            {
                MessageBox.Show("Không thể kết nối tới CSDL,vui lòng cài đặt lại kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Them mon hoc vao CSDL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btThemMH_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbMaMH.Text)|| string.IsNullOrEmpty(tbTenMH.Text))
                MessageBox.Show("Thêm thất bại,phải điền đầy đủ thông tin !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MonHocBLL mhbll = new MonHocBLL();
                if (mhbll.ThemMonHoc(tbMaMH.Text, tbTenMH.Text) == true)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //cap nhat du lieu len giao dien
                    LoadMonHoc_DanhSachMonHoc();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại,Môn học này đã có !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        /// <summary>
        /// sửa môn học đã chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSuaMH_Click(object sender, EventArgs e)
        {
            if (lvDanhSachMonHoc.SelectedItems.Count > 0)
            {
                MonHocBLL mhbll = new MonHocBLL();
                if (mhbll.SuaMonHoc(tbMaMH.Text, tbTenMH.Text) == true)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //cap nhat du lieu len giao dien
                    LoadMonHoc_DanhSachMonHoc();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại,Mã môn học này đang sử dụng !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Bạn phải chọn 1 môn học để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Xóa môn học được click ( mã)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoaMonHoc_Click(object sender, EventArgs e)
        {
            if (lvDanhSachMonHoc.SelectedItems.Count > 0)
            {
                MonHocBLL mh = new MonHocBLL();
                string ma = tbMaMH.Text;

                if (mh.XoaMonHoc(ma) == true)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //cap nhat du lieu len giao dien
                    LoadMonHoc_DanhSachMonHoc();
                }
                else
                    MessageBox.Show("Xóa thất bại,Bạn không thể xóa môn học còn đang sử dụng giảng dạy !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Bạn phải chọn 1 môn học để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// load dữ liệu lên texbox khi click vào 1 dòng trên listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvDanhSachMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSachMonHoc.SelectedItems.Count > 0)
            {
                ListViewItem lv = lvDanhSachMonHoc.SelectedItems[0];
                string ma = lv.SubItems[1].Text;
                string ten = lv.SubItems[2].Text;

                tbMaMH.Text = ma;
                tbTenMH.Text = ten;
            }
        }

        /// <summary>
        /// thêm hình thức kiểm tra từ texbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThemHTKT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTenHTKT.Text) || string.IsNullOrEmpty(tbMaHTKT.Text)|| string.IsNullOrEmpty(tbHesoHTKT.Text))
                MessageBox.Show("Thêm thất bại,phải điền đầy đủ thông tin !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                HinhThucKiemTraBLL mhbll = new HinhThucKiemTraBLL();
                if (mhbll.ThemHinhThucKiemTra(tbMaHTKT.Text, tbTenHTKT.Text, Int32.Parse(tbHesoHTKT.Text)) == true)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //cap nhat du lieu len giao dien
                    LoadHinhThucKiemtra();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại,Hình thức kiểm tra này đã có !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        /// <summary>
        /// đưa thông tin hình thức kiểm tra lên texbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvHinhThucKT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHinhThucKT.SelectedItems.Count > 0)
            {
                ListViewItem lv = lvHinhThucKT.SelectedItems[0];
                string ma = lv.SubItems[1].Text;
                string ten = lv.SubItems[2].Text;
                string heso = lv.SubItems[3].Text;

                tbMaHTKT.Text = ma;
                tbTenHTKT.Text = ten;
                tbHesoHTKT.Text = heso;
            }
        }

        private void btnSuaHTKT_Click(object sender, EventArgs e)
        {
            if (lvHinhThucKT.SelectedItems.Count > 0)
            {
                HinhThucKiemTraBLL mhbll = new HinhThucKiemTraBLL();
                if (mhbll.SuaHinhThucKiemTra(tbMaHTKT.Text, tbTenHTKT.Text, Int32.Parse(tbHesoHTKT.Text)) == true)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //cap nhat du lieu len giao dien
                    LoadHinhThucKiemtra();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại,Hình thức kiểm tra này đang sử dụng !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Bạn phải chọn 1 hình thức kiểm tra  để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaHTKT_Click(object sender, EventArgs e)
        {
            if (lvHinhThucKT.SelectedItems.Count > 0)
            {
                HinhThucKiemTraBLL mh = new HinhThucKiemTraBLL();
                string ma = tbMaHTKT.Text;

                if (mh.XoaHinhThucKiemTra(ma) == true)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //cap nhat du lieu len giao dien
                    LoadMonHoc_DanhSachMonHoc();
                }
                else
                    MessageBox.Show("Xóa thất bại,Bạn không thể hình thức kiểm tra còn đang sử dụng giảng dạy !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Bạn phải chọn 1 hình thức kiểm tra để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //__________________________________________________________________________________
        private void lvCTDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCTDT.SelectedItems.Count > 0)
            {
                ListViewItem lv = lvCTDT.SelectedItems[0];
                string maKhoi = lv.SubItems[1].Text;
                string MaMon = lv.SubItems[2].Text;
                string heSo = lv.SubItems[3].Text;

                tbMaKhoiLop_CTDT.Text = maKhoi;
                tbMaMonHocCTDT.Text = MaMon;
                tbHeSoCTDT.Text = heSo;
            }
        }

        private void btnThemCTDT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaKhoiLop_CTDT.Text) || string.IsNullOrEmpty(tbMaMonHocCTDT.Text) || string.IsNullOrEmpty(tbHeSoCTDT.Text))
                MessageBox.Show("Thêm thất bại,phải điền đầy đủ thông tin !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ChuongTrinhDaoTaoBLL mhbll = new ChuongTrinhDaoTaoBLL();
                if (mhbll.ThemCTDT(tbMaKhoiLop_CTDT.Text, tbMaMonHocCTDT.Text, Int32.Parse(tbHeSoCTDT.Text)) == true)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //cap nhat du lieu len giao dien
                    LoadChuongTrinhDaoTao();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại,Chương trình đào tạo này đã có !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void btnSuaCTDT_Click(object sender, EventArgs e)
        {
            if (lvCTDT.SelectedItems.Count > 0)
            {
                ChuongTrinhDaoTaoBLL ctdt = new ChuongTrinhDaoTaoBLL();
                if (ctdt.SuaCTDT(tbMaKhoiLop_CTDT.Text, tbMaMonHocCTDT.Text, Int32.Parse(tbHeSoCTDT.Text)) == true)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //cap nhat du lieu len giao dien
                    LoadChuongTrinhDaoTao();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại,Chương trình đào tạo này đang sử dụng !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Bạn phải chọn 1 Chương trình đào tạo  để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaCTDT_Click(object sender, EventArgs e)
        {
            if (lvCTDT.SelectedItems.Count > 0)
            {
                ChuongTrinhDaoTaoBLL ctdt = new ChuongTrinhDaoTaoBLL();
                string mamon = tbMaKhoiLop_CTDT.Text;
                string makhoi = tbMaMonHocCTDT.Text;

                if (ctdt.XoaCTDT(makhoi,mamon) == true)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //cap nhat du lieu len giao dien
                    LoadChuongTrinhDaoTao();
                }
                else
                    MessageBox.Show("Xóa thất bại,Bạn không thể xóa CTDT còn đang sử dụng giảng dạy !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Bạn phải chọn 1 Chương trình đào tạo để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
