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

       
    }
}
