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
    public partial class CSDL : Form
    {
        public CSDL()
        {
            InitializeComponent();
        }

        private void CSDL_Load(object sender, EventArgs e)
        {
            cboKieuXacThuc.Items.AddRange(new string[]
            {
                "Xác thực của Windows",
                "Xác thực của SQL Server"
            });

            cboKieuXacThuc.SelectedIndex = 0;
        }

        private void cboKieuXacThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenDangNhap.Enabled = txtMatKhau.Enabled = cboKieuXacThuc.SelectedIndex == 1;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
