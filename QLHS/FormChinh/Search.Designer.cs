namespace QLHS.FormChinh
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.listViewResult = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TB1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TB2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbKeySearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbListSearch = new System.Windows.Forms.ComboBox();
            this.pnListSearch = new System.Windows.Forms.Panel();
            this.gbListSearch = new System.Windows.Forms.GroupBox();
            this.pnDetailSearch = new System.Windows.Forms.Panel();
            this.gbDetailSearch = new System.Windows.Forms.GroupBox();
            this.lbEmail_ = new System.Windows.Forms.Label();
            this.lbDC_ = new System.Windows.Forms.Label();
            this.lbGT_ = new System.Windows.Forms.Label();
            this.lbNS_ = new System.Windows.Forms.Label();
            this.lbDTB2_ = new System.Windows.Forms.Label();
            this.lbDTB1_ = new System.Windows.Forms.Label();
            this.lbLop_ = new System.Windows.Forms.Label();
            this.lbTen_ = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbGT = new System.Windows.Forms.Label();
            this.lbNS = new System.Windows.Forms.Label();
            this.lbTBhk2 = new System.Windows.Forms.Label();
            this.lbTBhk1 = new System.Windows.Forms.Label();
            this.lbLop = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.pbGuideSearch = new System.Windows.Forms.PictureBox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnListSearch.SuspendLayout();
            this.gbListSearch.SuspendLayout();
            this.pnDetailSearch.SuspendLayout();
            this.gbDetailSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuideSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewResult
            // 
            this.listViewResult.AutoArrange = false;
            this.listViewResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewResult.CheckBoxes = true;
            this.listViewResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.HoTen,
            this.Lop,
            this.TB1,
            this.TB2});
            this.listViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewResult.FullRowSelect = true;
            this.listViewResult.GridLines = true;
            this.listViewResult.Location = new System.Drawing.Point(3, 25);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(617, 290);
            this.listViewResult.TabIndex = 0;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 50;
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ và Tên";
            this.HoTen.Width = 170;
            // 
            // Lop
            // 
            this.Lop.Text = "Lớp";
            this.Lop.Width = 130;
            // 
            // TB1
            // 
            this.TB1.Text = "TB học kỳ 1";
            this.TB1.Width = 120;
            // 
            // TB2
            // 
            this.TB2.Text = "TB Học kỳ 2";
            this.TB2.Width = 120;
            // 
            // tbKeySearch
            // 
            this.tbKeySearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbKeySearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbKeySearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKeySearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbKeySearch.HintForeColor = System.Drawing.Color.Empty;
            this.tbKeySearch.HintText = "";
            this.tbKeySearch.isPassword = false;
            this.tbKeySearch.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbKeySearch.LineIdleColor = System.Drawing.Color.Gray;
            this.tbKeySearch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbKeySearch.LineThickness = 4;
            this.tbKeySearch.Location = new System.Drawing.Point(365, 35);
            this.tbKeySearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbKeySearch.Name = "tbKeySearch";
            this.tbKeySearch.Size = new System.Drawing.Size(339, 38);
            this.tbKeySearch.TabIndex = 2;
            this.tbKeySearch.Text = "Nhập từ khóa cần tìm";
            this.tbKeySearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbListSearch
            // 
            this.cbListSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbListSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListSearch.FormattingEnabled = true;
            this.cbListSearch.ItemHeight = 29;
            this.cbListSearch.Location = new System.Drawing.Point(204, 37);
            this.cbListSearch.Name = "cbListSearch";
            this.cbListSearch.Size = new System.Drawing.Size(156, 37);
            this.cbListSearch.TabIndex = 3;
            // 
            // pnListSearch
            // 
            this.pnListSearch.AllowDrop = true;
            this.pnListSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnListSearch.AutoScroll = true;
            this.pnListSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnListSearch.Controls.Add(this.gbListSearch);
            this.pnListSearch.Location = new System.Drawing.Point(19, 122);
            this.pnListSearch.Name = "pnListSearch";
            this.pnListSearch.Size = new System.Drawing.Size(623, 318);
            this.pnListSearch.TabIndex = 6;
            // 
            // gbListSearch
            // 
            this.gbListSearch.AutoSize = true;
            this.gbListSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbListSearch.Controls.Add(this.listViewResult);
            this.gbListSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbListSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListSearch.Location = new System.Drawing.Point(0, 0);
            this.gbListSearch.Name = "gbListSearch";
            this.gbListSearch.Size = new System.Drawing.Size(623, 318);
            this.gbListSearch.TabIndex = 0;
            this.gbListSearch.TabStop = false;
            this.gbListSearch.Text = "Kết quả tìm kiếm";
            // 
            // pnDetailSearch
            // 
            this.pnDetailSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDetailSearch.Controls.Add(this.gbDetailSearch);
            this.pnDetailSearch.Location = new System.Drawing.Point(687, 122);
            this.pnDetailSearch.Name = "pnDetailSearch";
            this.pnDetailSearch.Size = new System.Drawing.Size(341, 318);
            this.pnDetailSearch.TabIndex = 7;
            // 
            // gbDetailSearch
            // 
            this.gbDetailSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbDetailSearch.Controls.Add(this.lbEmail_);
            this.gbDetailSearch.Controls.Add(this.lbDC_);
            this.gbDetailSearch.Controls.Add(this.lbGT_);
            this.gbDetailSearch.Controls.Add(this.lbNS_);
            this.gbDetailSearch.Controls.Add(this.lbDTB2_);
            this.gbDetailSearch.Controls.Add(this.lbDTB1_);
            this.gbDetailSearch.Controls.Add(this.lbLop_);
            this.gbDetailSearch.Controls.Add(this.lbTen_);
            this.gbDetailSearch.Controls.Add(this.lbEmail);
            this.gbDetailSearch.Controls.Add(this.lbDiaChi);
            this.gbDetailSearch.Controls.Add(this.lbGT);
            this.gbDetailSearch.Controls.Add(this.lbNS);
            this.gbDetailSearch.Controls.Add(this.lbTBhk2);
            this.gbDetailSearch.Controls.Add(this.lbTBhk1);
            this.gbDetailSearch.Controls.Add(this.lbLop);
            this.gbDetailSearch.Controls.Add(this.lbTen);
            this.gbDetailSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDetailSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetailSearch.Location = new System.Drawing.Point(0, 0);
            this.gbDetailSearch.Name = "gbDetailSearch";
            this.gbDetailSearch.Size = new System.Drawing.Size(341, 318);
            this.gbDetailSearch.TabIndex = 0;
            this.gbDetailSearch.TabStop = false;
            this.gbDetailSearch.Text = "Thông tin chi tiết";
            // 
            // lbEmail_
            // 
            this.lbEmail_.AutoSize = true;
            this.lbEmail_.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbEmail_.Location = new System.Drawing.Point(118, 293);
            this.lbEmail_.Name = "lbEmail_";
            this.lbEmail_.Size = new System.Drawing.Size(14, 21);
            this.lbEmail_.TabIndex = 15;
            this.lbEmail_.Text = ":";
            // 
            // lbDC_
            // 
            this.lbDC_.AutoSize = true;
            this.lbDC_.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDC_.Location = new System.Drawing.Point(118, 263);
            this.lbDC_.Name = "lbDC_";
            this.lbDC_.Size = new System.Drawing.Size(14, 21);
            this.lbDC_.TabIndex = 14;
            this.lbDC_.Text = ":";
            // 
            // lbGT_
            // 
            this.lbGT_.AutoSize = true;
            this.lbGT_.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbGT_.Location = new System.Drawing.Point(118, 227);
            this.lbGT_.Name = "lbGT_";
            this.lbGT_.Size = new System.Drawing.Size(14, 21);
            this.lbGT_.TabIndex = 13;
            this.lbGT_.Text = ":";
            // 
            // lbNS_
            // 
            this.lbNS_.AutoSize = true;
            this.lbNS_.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNS_.Location = new System.Drawing.Point(118, 194);
            this.lbNS_.Name = "lbNS_";
            this.lbNS_.Size = new System.Drawing.Size(14, 21);
            this.lbNS_.TabIndex = 12;
            this.lbNS_.Text = ":";
            // 
            // lbDTB2_
            // 
            this.lbDTB2_.AutoSize = true;
            this.lbDTB2_.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDTB2_.Location = new System.Drawing.Point(118, 161);
            this.lbDTB2_.Name = "lbDTB2_";
            this.lbDTB2_.Size = new System.Drawing.Size(14, 21);
            this.lbDTB2_.TabIndex = 11;
            this.lbDTB2_.Text = ":";
            // 
            // lbDTB1_
            // 
            this.lbDTB1_.AutoSize = true;
            this.lbDTB1_.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDTB1_.Location = new System.Drawing.Point(118, 128);
            this.lbDTB1_.Name = "lbDTB1_";
            this.lbDTB1_.Size = new System.Drawing.Size(14, 21);
            this.lbDTB1_.TabIndex = 10;
            this.lbDTB1_.Text = ":";
            // 
            // lbLop_
            // 
            this.lbLop_.AutoSize = true;
            this.lbLop_.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbLop_.Location = new System.Drawing.Point(118, 95);
            this.lbLop_.Name = "lbLop_";
            this.lbLop_.Size = new System.Drawing.Size(14, 21);
            this.lbLop_.TabIndex = 9;
            this.lbLop_.Text = ":";
            // 
            // lbTen_
            // 
            this.lbTen_.AutoSize = true;
            this.lbTen_.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTen_.Location = new System.Drawing.Point(118, 62);
            this.lbTen_.Name = "lbTen_";
            this.lbTen_.Size = new System.Drawing.Size(14, 21);
            this.lbTen_.TabIndex = 8;
            this.lbTen_.Text = ":";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbEmail.Location = new System.Drawing.Point(5, 293);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(56, 21);
            this.lbEmail.TabIndex = 7;
            this.lbEmail.Text = "Email ";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDiaChi.Location = new System.Drawing.Point(5, 260);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(70, 21);
            this.lbDiaChi.TabIndex = 6;
            this.lbDiaChi.Text = "Địa chỉ ";
            // 
            // lbGT
            // 
            this.lbGT.AutoSize = true;
            this.lbGT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbGT.Location = new System.Drawing.Point(5, 227);
            this.lbGT.Name = "lbGT";
            this.lbGT.Size = new System.Drawing.Size(88, 21);
            this.lbGT.TabIndex = 5;
            this.lbGT.Text = "Giới Tính ";
            // 
            // lbNS
            // 
            this.lbNS.AutoSize = true;
            this.lbNS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNS.Location = new System.Drawing.Point(5, 194);
            this.lbNS.Name = "lbNS";
            this.lbNS.Size = new System.Drawing.Size(92, 21);
            this.lbNS.TabIndex = 4;
            this.lbNS.Text = "Ngày Sinh ";
            // 
            // lbTBhk2
            // 
            this.lbTBhk2.AutoSize = true;
            this.lbTBhk2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTBhk2.Location = new System.Drawing.Point(5, 161);
            this.lbTBhk2.Name = "lbTBhk2";
            this.lbTBhk2.Size = new System.Drawing.Size(119, 21);
            this.lbTBhk2.TabIndex = 3;
            this.lbTBhk2.Text = "Điểm TB HK2";
            // 
            // lbTBhk1
            // 
            this.lbTBhk1.AutoSize = true;
            this.lbTBhk1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTBhk1.Location = new System.Drawing.Point(5, 128);
            this.lbTBhk1.Name = "lbTBhk1";
            this.lbTBhk1.Size = new System.Drawing.Size(124, 21);
            this.lbTBhk1.TabIndex = 2;
            this.lbTBhk1.Text = "Điểm TB HK1 ";
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbLop.Location = new System.Drawing.Point(5, 95);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(56, 21);
            this.lbLop.TabIndex = 1;
            this.lbLop.Text = "Lớp   ";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbTen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTen.Location = new System.Drawing.Point(5, 62);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(94, 21);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "Họ và Tên ";
            // 
            // pbGuideSearch
            // 
            this.pbGuideSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGuideSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbGuideSearch.BackgroundImage")));
            this.pbGuideSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbGuideSearch.Location = new System.Drawing.Point(986, 35);
            this.pbGuideSearch.Name = "pbGuideSearch";
            this.pbGuideSearch.Size = new System.Drawing.Size(34, 33);
            this.pbGuideSearch.TabIndex = 5;
            this.pbGuideSearch.TabStop = false;
            this.pbGuideSearch.Click += new System.EventHandler(this.pbGuideSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(108)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "   Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSearch.Iconimage")));
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 10;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 70D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(711, 35);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(108)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(156, 38);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "   Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(213)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1055, 505);
            this.Controls.Add(this.pnDetailSearch);
            this.Controls.Add(this.pnListSearch);
            this.Controls.Add(this.pbGuideSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbListSearch);
            this.Controls.Add(this.tbKeySearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.Text = "Search";
            this.pnListSearch.ResumeLayout(false);
            this.pnListSearch.PerformLayout();
            this.gbListSearch.ResumeLayout(false);
            this.pnDetailSearch.ResumeLayout(false);
            this.gbDetailSearch.ResumeLayout(false);
            this.gbDetailSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuideSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox tbKeySearch;
        private System.Windows.Forms.ComboBox cbListSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private System.Windows.Forms.PictureBox pbGuideSearch;
        private System.Windows.Forms.Panel pnListSearch;
        private System.Windows.Forms.GroupBox gbListSearch;
        private System.Windows.Forms.Panel pnDetailSearch;
        private System.Windows.Forms.GroupBox gbDetailSearch;
        private System.Windows.Forms.Label lbTBhk2;
        private System.Windows.Forms.Label lbTBhk1;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbGT;
        private System.Windows.Forms.Label lbNS;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbEmail_;
        private System.Windows.Forms.Label lbDC_;
        private System.Windows.Forms.Label lbGT_;
        private System.Windows.Forms.Label lbNS_;
        private System.Windows.Forms.Label lbDTB2_;
        private System.Windows.Forms.Label lbDTB1_;
        private System.Windows.Forms.Label lbLop_;
        private System.Windows.Forms.Label lbTen_;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader Lop;
        private System.Windows.Forms.ColumnHeader TB1;
        private System.Windows.Forms.ColumnHeader TB2;
        private System.Windows.Forms.ListView listViewResult;
    }
}