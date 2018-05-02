using QLHS.FormChinh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class FMain : Form
    {
        int Width_pandUser = 193;
        bool Hident = true;

        public FormWindowState Minimized { get; private set; }

        public FMain()
        {
            InitializeComponent();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            //timerUser.Start();
        }

        private void timerUser_Tick(object sender, EventArgs e)
        {
            if (Hident)
            {
                pnUser.Width += 5;
                if (pnUser.Width >= Width_pandUser)
                {
                    Hident = false;
                    timerUser.Stop();
                }
                //pnUser.Refresh();
            }
            else
            {
                pnUser.Width -= 5;
                if (pnUser.Width <= 0)
                {
                    Hident = true;
                    timerUser.Stop();
                   // pnUser.Refresh();
                }
               
            }
        }

        private void pnUser_MouseLeave(object sender, EventArgs e)
        {
            //timerUser.Start();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbHident_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pbUser_Click(object sender, EventArgs e)
        {
            timerUser.Start();
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            FormChinh.Home h = new FormChinh.Home() { Dock = DockStyle.Fill, TopLevel = false };
            pnBoard.Controls.Clear();
            pnBoard.Controls.Add(h);
            h.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            timerUser.Start();
        }

        private void pbClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadFormTimKiem()
        {
            Search s = new Search() { Dock = DockStyle.Fill, TopLevel = false };
            pnBoard.Controls.Clear();
            pnBoard.Controls.Add(s);
            s.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadFormTimKiem();
        }

         public  void LoadFormQuyDinh()
        {
            QuiDinh q = new QuiDinh() { Dock = DockStyle.Fill, TopLevel = false};
            pnBoard.Controls.Clear();
            pnBoard.Controls.Add(q);
            q.Show();
        }
        private void btnQuyDinh_Click(object sender, EventArgs e)
        {
            LoadFormQuyDinh();
        }

        /// <summary>
        /// Load form quan ly mon hoc
        /// </summary>
        void LoadQuanLyMonHoc()
        {
            QuanLyMonHoc bd = new QuanLyMonHoc() { /*Dock = DockStyle.Fill,*/ TopLevel = false };
            pnBoard.Controls.Clear();
            pnBoard.Controls.Add(bd);
            bd.Show();
        }
        private void btnQuanlyMonHoc_Click(object sender, EventArgs e)
        {
            LoadQuanLyMonHoc();
        }

        void LoadBaoCaoMon()
        {
            TongKetMon tk = new TongKetMon() { Dock = DockStyle.Fill, TopLevel = false };
            pnBoard.Controls.Clear();
            pnBoard.Controls.Add(tk);
            tk.Show();
        }
        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            LoadBaoCaoMon();
        }

        private void btnCoSoDuLieu_Click(object sender, EventArgs e)
        {
            CSDL csdl = new CSDL();
            csdl.ShowDialog();
        }
        void LoadQuanLyLopHoc()
        {
            QuanLyLopHoc lh = new QuanLyLopHoc() {/* Dock = DockStyle.Fill, */TopLevel = false };
            pnBoard.Controls.Clear();
            pnBoard.Controls.Add(lh);
            lh.Show();
        }
    
        private void btnQuanLyLop_Click(object sender, EventArgs e)
        {
            LoadQuanLyLopHoc();
        }
    }
}
