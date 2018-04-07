namespace QLHS.FormChinh
{
    partial class TongKetMon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnBoard = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.lbLapBaoCao = new System.Windows.Forms.Label();
            this.lbMon = new System.Windows.Forms.Label();
            this.lbHK = new System.Windows.Forms.Label();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvTongKetMon = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SiSo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SLDat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TiLe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnTop.SuspendLayout();
            this.pnBoard.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.lbLapBaoCao);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1039, 52);
            this.pnTop.TabIndex = 0;
            // 
            // pnBoard
            // 
            this.pnBoard.Controls.Add(this.panel2);
            this.pnBoard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBoard.Location = new System.Drawing.Point(0, 104);
            this.pnBoard.Name = "pnBoard";
            this.pnBoard.Size = new System.Drawing.Size(1039, 362);
            this.pnBoard.TabIndex = 2;
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.cbHocKy);
            this.pnMenu.Controls.Add(this.cbMonHoc);
            this.pnMenu.Controls.Add(this.lbHK);
            this.pnMenu.Controls.Add(this.lbMon);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMenu.Location = new System.Drawing.Point(0, 52);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(1039, 52);
            this.pnMenu.TabIndex = 3;
            // 
            // lbLapBaoCao
            // 
            this.lbLapBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLapBaoCao.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLapBaoCao.Location = new System.Drawing.Point(0, 0);
            this.lbLapBaoCao.Name = "lbLapBaoCao";
            this.lbLapBaoCao.Size = new System.Drawing.Size(1039, 52);
            this.lbLapBaoCao.TabIndex = 0;
            this.lbLapBaoCao.Text = "Lập báo cáo môn học";
            this.lbLapBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMon
            // 
            this.lbMon.AutoSize = true;
            this.lbMon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMon.Location = new System.Drawing.Point(295, 13);
            this.lbMon.Name = "lbMon";
            this.lbMon.Size = new System.Drawing.Size(87, 21);
            this.lbMon.TabIndex = 0;
            this.lbMon.Text = "Môn học :";
            // 
            // lbHK
            // 
            this.lbHK.AutoSize = true;
            this.lbHK.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHK.Location = new System.Drawing.Point(558, 13);
            this.lbHK.Name = "lbHK";
            this.lbHK.Size = new System.Drawing.Size(74, 21);
            this.lbHK.TabIndex = 1;
            this.lbHK.Text = "Học kỳ :";
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(379, 13);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(121, 21);
            this.cbMonHoc.TabIndex = 2;
            // 
            // cbHocKy
            // 
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(629, 13);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(121, 21);
            this.cbHocKy.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvTongKetMon);
            this.panel2.Location = new System.Drawing.Point(196, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 325);
            this.panel2.TabIndex = 0;
            // 
            // lvTongKetMon
            // 
            this.lvTongKetMon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.Lop,
            this.SiSo,
            this.SLDat,
            this.TiLe});
            this.lvTongKetMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTongKetMon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTongKetMon.FullRowSelect = true;
            this.lvTongKetMon.GridLines = true;
            this.lvTongKetMon.Location = new System.Drawing.Point(0, 0);
            this.lvTongKetMon.Name = "lvTongKetMon";
            this.lvTongKetMon.Size = new System.Drawing.Size(669, 325);
            this.lvTongKetMon.TabIndex = 0;
            this.lvTongKetMon.UseCompatibleStateImageBehavior = false;
            this.lvTongKetMon.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            // 
            // Lop
            // 
            this.Lop.Text = "Lớp";
            this.Lop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Lop.Width = 150;
            // 
            // SiSo
            // 
            this.SiSo.Text = "Sĩ số";
            this.SiSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SiSo.Width = 150;
            // 
            // SLDat
            // 
            this.SLDat.Text = "Số lượng đạt";
            this.SLDat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SLDat.Width = 150;
            // 
            // TiLe
            // 
            this.TiLe.Text = "Tỉ lệ";
            this.TiLe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TiLe.Width = 150;
            // 
            // TongKetMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(213)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1039, 466);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnBoard);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TongKetMon";
            this.Text = "TongKetMon";
            this.pnTop.ResumeLayout(false);
            this.pnBoard.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbLapBaoCao;
        private System.Windows.Forms.Panel pnBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvTongKetMon;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader Lop;
        private System.Windows.Forms.ColumnHeader SiSo;
        private System.Windows.Forms.ColumnHeader SLDat;
        private System.Windows.Forms.ColumnHeader TiLe;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.Label lbHK;
        private System.Windows.Forms.Label lbMon;
    }
}