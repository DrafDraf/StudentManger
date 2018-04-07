namespace QLHS.FormChinh
{
    partial class NhapBangDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapBangDiem));
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbBangdiem = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.pnmenuBangDiem = new System.Windows.Forms.Panel();
            this.pnBoardBangDiem = new System.Windows.Forms.Panel();
            this.lbLop = new System.Windows.Forms.Label();
            this.lbHK = new System.Windows.Forms.Label();
            this.lbMonHoc = new System.Windows.Forms.Label();
            this.cbHK = new System.Windows.Forms.ComboBox();
            this.cbMH = new System.Windows.Forms.ComboBox();
            this.pbGuideNhapDiem = new System.Windows.Forms.PictureBox();
            this.pnList = new System.Windows.Forms.Panel();
            this.lvList = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diem15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diem1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DTB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnTop.SuspendLayout();
            this.pnmenuBangDiem.SuspendLayout();
            this.pnBoardBangDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuideNhapDiem)).BeginInit();
            this.pnList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(213)))), ((int)(((byte)(246)))));
            this.pnTop.Controls.Add(this.pbGuideNhapDiem);
            this.pnTop.Controls.Add(this.lbBangdiem);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1039, 52);
            this.pnTop.TabIndex = 0;
            // 
            // lbBangdiem
            // 
            this.lbBangdiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBangdiem.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBangdiem.Location = new System.Drawing.Point(0, 0);
            this.lbBangdiem.Name = "lbBangdiem";
            this.lbBangdiem.Size = new System.Drawing.Size(1039, 52);
            this.lbBangdiem.TabIndex = 0;
            this.lbBangdiem.Text = "Bảng điểm môn học";
            this.lbBangdiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbLop
            // 
            this.cbLop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(243, 24);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(121, 21);
            this.cbLop.TabIndex = 1;
            // 
            // pnmenuBangDiem
            // 
            this.pnmenuBangDiem.Controls.Add(this.cbMH);
            this.pnmenuBangDiem.Controls.Add(this.cbHK);
            this.pnmenuBangDiem.Controls.Add(this.lbMonHoc);
            this.pnmenuBangDiem.Controls.Add(this.lbHK);
            this.pnmenuBangDiem.Controls.Add(this.lbLop);
            this.pnmenuBangDiem.Controls.Add(this.cbLop);
            this.pnmenuBangDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnmenuBangDiem.Location = new System.Drawing.Point(0, 52);
            this.pnmenuBangDiem.Name = "pnmenuBangDiem";
            this.pnmenuBangDiem.Size = new System.Drawing.Size(1039, 414);
            this.pnmenuBangDiem.TabIndex = 2;
            // 
            // pnBoardBangDiem
            // 
            this.pnBoardBangDiem.Controls.Add(this.pnList);
            this.pnBoardBangDiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBoardBangDiem.Location = new System.Drawing.Point(0, 119);
            this.pnBoardBangDiem.Name = "pnBoardBangDiem";
            this.pnBoardBangDiem.Size = new System.Drawing.Size(1039, 347);
            this.pnBoardBangDiem.TabIndex = 3;
            // 
            // lbLop
            // 
            this.lbLop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbLop.AutoSize = true;
            this.lbLop.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLop.Location = new System.Drawing.Point(186, 22);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(50, 21);
            this.lbLop.TabIndex = 2;
            this.lbLop.Text = "Lớp :";
            // 
            // lbHK
            // 
            this.lbHK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbHK.AutoSize = true;
            this.lbHK.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHK.Location = new System.Drawing.Point(414, 22);
            this.lbHK.Name = "lbHK";
            this.lbHK.Size = new System.Drawing.Size(74, 21);
            this.lbHK.TabIndex = 3;
            this.lbHK.Text = "Học kỳ :";
            // 
            // lbMonHoc
            // 
            this.lbMonHoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMonHoc.AutoSize = true;
            this.lbMonHoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonHoc.Location = new System.Drawing.Point(655, 24);
            this.lbMonHoc.Name = "lbMonHoc";
            this.lbMonHoc.Size = new System.Drawing.Size(87, 21);
            this.lbMonHoc.TabIndex = 4;
            this.lbMonHoc.Text = "Môn học :";
            // 
            // cbHK
            // 
            this.cbHK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbHK.FormattingEnabled = true;
            this.cbHK.Location = new System.Drawing.Point(495, 22);
            this.cbHK.Name = "cbHK";
            this.cbHK.Size = new System.Drawing.Size(121, 21);
            this.cbHK.TabIndex = 2;
            // 
            // cbMH
            // 
            this.cbMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMH.FormattingEnabled = true;
            this.cbMH.Location = new System.Drawing.Point(748, 22);
            this.cbMH.Name = "cbMH";
            this.cbMH.Size = new System.Drawing.Size(121, 21);
            this.cbMH.TabIndex = 2;
            // 
            // pbGuideNhapDiem
            // 
            this.pbGuideNhapDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGuideNhapDiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbGuideNhapDiem.BackgroundImage")));
            this.pbGuideNhapDiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbGuideNhapDiem.Location = new System.Drawing.Point(880, 12);
            this.pbGuideNhapDiem.Name = "pbGuideNhapDiem";
            this.pbGuideNhapDiem.Size = new System.Drawing.Size(34, 33);
            this.pbGuideNhapDiem.TabIndex = 6;
            this.pbGuideNhapDiem.TabStop = false;
            // 
            // pnList
            // 
            this.pnList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnList.Controls.Add(this.lvList);
            this.pnList.Location = new System.Drawing.Point(133, 20);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(804, 281);
            this.pnList.TabIndex = 0;
            // 
            // lvList
            // 
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.HoTen,
            this.Diem15,
            this.Diem1,
            this.DTB});
            this.lvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvList.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.Location = new System.Drawing.Point(0, 0);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(804, 281);
            this.lvList.TabIndex = 0;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 70;
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ và tên";
            this.HoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HoTen.Width = 250;
            // 
            // Diem15
            // 
            this.Diem15.Text = "Điểm 15 phút";
            this.Diem15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Diem15.Width = 160;
            // 
            // Diem1
            // 
            this.Diem1.Text = "Điểm 1 tiết";
            this.Diem1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Diem1.Width = 160;
            // 
            // DTB
            // 
            this.DTB.Text = "Điểm trung bình";
            this.DTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DTB.Width = 160;
            // 
            // NhapBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(213)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1039, 466);
            this.Controls.Add(this.pnBoardBangDiem);
            this.Controls.Add(this.pnmenuBangDiem);
            this.Controls.Add(this.pnTop);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhapBangDiem";
            this.Text = "NhapBangDiem";
            this.pnTop.ResumeLayout(false);
            this.pnmenuBangDiem.ResumeLayout(false);
            this.pnmenuBangDiem.PerformLayout();
            this.pnBoardBangDiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGuideNhapDiem)).EndInit();
            this.pnList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbBangdiem;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Panel pnmenuBangDiem;
        private System.Windows.Forms.Panel pnBoardBangDiem;
        private System.Windows.Forms.ComboBox cbMH;
        private System.Windows.Forms.ComboBox cbHK;
        private System.Windows.Forms.Label lbMonHoc;
        private System.Windows.Forms.Label lbHK;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.PictureBox pbGuideNhapDiem;
        private System.Windows.Forms.Panel pnList;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader Diem15;
        private System.Windows.Forms.ColumnHeader Diem1;
        private System.Windows.Forms.ColumnHeader DTB;
    }
}