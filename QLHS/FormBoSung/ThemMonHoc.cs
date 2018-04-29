using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS.FormBoSung
{
    public partial class ThemMonHoc : Form
    {
        public ThemMonHoc()
        {
            InitializeComponent();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //luu du lieu xuong CSDL
           // MessageBox.Show(this.ToString());
            this.Hide();
        }
    }
}
