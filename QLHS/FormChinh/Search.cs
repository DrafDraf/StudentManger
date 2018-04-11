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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void pbGuideSearch_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TestCSDL_BLL t = new TestCSDL_BLL();
            List<TestMonHoc> li = new List<TestMonHoc>();
            li = t.GetListMonHoc();
            listViewResult.Items.Clear();

            foreach (TestMonHoc temp in li)
            {
                ListViewItem lvi = new ListViewItem(temp.MaMH);
                lvi.SubItems.Add(temp.TenMH);
                listViewResult.Items.Add(lvi);
            }
        }
    }
}
