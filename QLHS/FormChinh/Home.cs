using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS.FormChinh
{
    public partial class Home : Form
    {
        //FMain f;

        public Home()
        {
            InitializeComponent();
            //f = new FMain();
        }

        private void btQuyDinh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("khong duoc roi");
            //f.LoadFormQuyDinh();
            //f.ShowDialog();
        }

        private void btTraCuu_Click(object sender, EventArgs e)
        {
            //f.LoadFormTimKiem();
        }


    }
}
