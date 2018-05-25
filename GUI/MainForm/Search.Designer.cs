namespace GUI.MainForm
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
            this.btnThoat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbTieuChiTimKiem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbNgaySinh = new System.Windows.Forms.TextBox();
            this.tbGioiTinh = new System.Windows.Forms.TextBox();
            this.tbLop = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvdshs = new System.Windows.Forms.ListView();
            this.clSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clMaHocSinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbTuKhoaTimKiem = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbHoVaTen = new System.Windows.Forms.TextBox();
            this.tbMaHocSinh = new System.Windows.Forms.TextBox();
            this.labelmail = new System.Windows.Forms.Label();
            this.labeldiachi = new System.Windows.Forms.Label();
            this.labelngsinh = new System.Windows.Forms.Label();
            this.labelgioitinh = new System.Windows.Forms.Label();
            this.labellop = new System.Windows.Forms.Label();
            this.labelhoten = new System.Windows.Forms.Label();
            this.labelmahs = new System.Windows.Forms.Label();
            this.groupthongtin = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupthongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(66)))), ((int)(((byte)(244)))));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.BorderRadius = 0;
            this.btnThoat.ButtonText = "Thoát";
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.DisabledColor = System.Drawing.Color.Gray;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThoat.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnThoat.Iconimage")));
            this.btnThoat.Iconimage_right = null;
            this.btnThoat.Iconimage_right_Selected = null;
            this.btnThoat.Iconimage_Selected = null;
            this.btnThoat.IconMarginLeft = 0;
            this.btnThoat.IconMarginRight = 0;
            this.btnThoat.IconRightVisible = false;
            this.btnThoat.IconRightZoom = 0D;
            this.btnThoat.IconVisible = true;
            this.btnThoat.IconZoom = 70D;
            this.btnThoat.IsTab = true;
            this.btnThoat.Location = new System.Drawing.Point(113, 36);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(66)))), ((int)(((byte)(244)))));
            this.btnThoat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(26)))), ((int)(((byte)(95)))));
            this.btnThoat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThoat.selected = false;
            this.btnThoat.Size = new System.Drawing.Size(156, 38);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThoat.Textcolor = System.Drawing.Color.White;
            this.btnThoat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(791, 429);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 100);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tùy chọn";
            // 
            // cbTieuChiTimKiem
            // 
            this.cbTieuChiTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTieuChiTimKiem.FormattingEnabled = true;
            this.cbTieuChiTimKiem.Location = new System.Drawing.Point(278, 27);
            this.cbTieuChiTimKiem.Name = "cbTieuChiTimKiem";
            this.cbTieuChiTimKiem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbTieuChiTimKiem.Size = new System.Drawing.Size(152, 28);
            this.cbTieuChiTimKiem.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(213)))), ((int)(((byte)(246)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tiêu chí tìm kiếm :";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.Menu;
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(139, 280);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(185, 29);
            this.tbEmail.TabIndex = 13;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.BackColor = System.Drawing.SystemColors.Menu;
            this.tbDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaChi.Location = new System.Drawing.Point(139, 238);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(185, 29);
            this.tbDiaChi.TabIndex = 12;
            // 
            // tbNgaySinh
            // 
            this.tbNgaySinh.BackColor = System.Drawing.SystemColors.Menu;
            this.tbNgaySinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNgaySinh.Location = new System.Drawing.Point(139, 197);
            this.tbNgaySinh.Name = "tbNgaySinh";
            this.tbNgaySinh.Size = new System.Drawing.Size(185, 29);
            this.tbNgaySinh.TabIndex = 11;
            // 
            // tbGioiTinh
            // 
            this.tbGioiTinh.BackColor = System.Drawing.SystemColors.Menu;
            this.tbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGioiTinh.Location = new System.Drawing.Point(139, 153);
            this.tbGioiTinh.Name = "tbGioiTinh";
            this.tbGioiTinh.Size = new System.Drawing.Size(185, 29);
            this.tbGioiTinh.TabIndex = 10;
            // 
            // tbLop
            // 
            this.tbLop.BackColor = System.Drawing.SystemColors.Menu;
            this.tbLop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLop.Location = new System.Drawing.Point(139, 115);
            this.tbLop.Name = "tbLop";
            this.tbLop.Size = new System.Drawing.Size(185, 29);
            this.tbLop.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(213)))), ((int)(((byte)(246)))));
            this.groupBox1.Controls.Add(this.lvdshs);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(735, 442);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng danh sách học sinh";
            // 
            // lvdshs
            // 
            this.lvdshs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clSTT,
            this.clMaHocSinh,
            this.colHoTen,
            this.colLop});
            this.lvdshs.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lvdshs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvdshs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvdshs.FullRowSelect = true;
            this.lvdshs.GridLines = true;
            this.lvdshs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvdshs.LabelEdit = true;
            this.lvdshs.Location = new System.Drawing.Point(3, 25);
            this.lvdshs.Name = "lvdshs";
            this.lvdshs.Size = new System.Drawing.Size(729, 414);
            this.lvdshs.TabIndex = 0;
            this.lvdshs.UseCompatibleStateImageBehavior = false;
            this.lvdshs.View = System.Windows.Forms.View.Details;
            this.lvdshs.SelectedIndexChanged += new System.EventHandler(this.lvdshs_SelectedIndexChanged);
            // 
            // clSTT
            // 
            this.clSTT.Text = "STT";
            this.clSTT.Width = 41;
            // 
            // clMaHocSinh
            // 
            this.clMaHocSinh.Text = "Mã học sinh";
            this.clMaHocSinh.Width = 0;
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ Và Tên";
            this.colHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHoTen.Width = 190;
            // 
            // colLop
            // 
            this.colLop.Text = "Lớp";
            this.colLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLop.Width = 97;
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(66)))), ((int)(((byte)(244)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "Search";
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
            this.btnSearch.IconRightVisible = false;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 70D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(804, 16);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(66)))), ((int)(((byte)(244)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(156, 38);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbTuKhoaTimKiem
            // 
            this.tbTuKhoaTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTuKhoaTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTuKhoaTimKiem.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTuKhoaTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTuKhoaTimKiem.HintForeColor = System.Drawing.Color.Empty;
            this.tbTuKhoaTimKiem.HintText = "";
            this.tbTuKhoaTimKiem.isPassword = false;
            this.tbTuKhoaTimKiem.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.tbTuKhoaTimKiem.LineIdleColor = System.Drawing.Color.Gray;
            this.tbTuKhoaTimKiem.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.tbTuKhoaTimKiem.LineThickness = 4;
            this.tbTuKhoaTimKiem.Location = new System.Drawing.Point(456, 16);
            this.tbTuKhoaTimKiem.Margin = new System.Windows.Forms.Padding(5);
            this.tbTuKhoaTimKiem.Name = "tbTuKhoaTimKiem";
            this.tbTuKhoaTimKiem.Size = new System.Drawing.Size(339, 38);
            this.tbTuKhoaTimKiem.TabIndex = 26;
            this.tbTuKhoaTimKiem.Text = "Nhập từ khóa cần tìm";
            this.tbTuKhoaTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbHoVaTen
            // 
            this.tbHoVaTen.BackColor = System.Drawing.SystemColors.Menu;
            this.tbHoVaTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoVaTen.Location = new System.Drawing.Point(139, 77);
            this.tbHoVaTen.Name = "tbHoVaTen";
            this.tbHoVaTen.Size = new System.Drawing.Size(185, 29);
            this.tbHoVaTen.TabIndex = 8;
            // 
            // tbMaHocSinh
            // 
            this.tbMaHocSinh.BackColor = System.Drawing.SystemColors.Menu;
            this.tbMaHocSinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaHocSinh.Location = new System.Drawing.Point(139, 37);
            this.tbMaHocSinh.Name = "tbMaHocSinh";
            this.tbMaHocSinh.Size = new System.Drawing.Size(185, 29);
            this.tbMaHocSinh.TabIndex = 7;
            // 
            // labelmail
            // 
            this.labelmail.AutoSize = true;
            this.labelmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmail.Location = new System.Drawing.Point(4, 279);
            this.labelmail.Name = "labelmail";
            this.labelmail.Size = new System.Drawing.Size(55, 21);
            this.labelmail.TabIndex = 6;
            this.labelmail.Text = "Email :";
            // 
            // labeldiachi
            // 
            this.labeldiachi.AutoSize = true;
            this.labeldiachi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldiachi.Location = new System.Drawing.Point(4, 238);
            this.labeldiachi.Name = "labeldiachi";
            this.labeldiachi.Size = new System.Drawing.Size(67, 21);
            this.labeldiachi.TabIndex = 5;
            this.labeldiachi.Text = "Địa Chỉ :";
            // 
            // labelngsinh
            // 
            this.labelngsinh.AutoSize = true;
            this.labelngsinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelngsinh.Location = new System.Drawing.Point(4, 197);
            this.labelngsinh.Name = "labelngsinh";
            this.labelngsinh.Size = new System.Drawing.Size(89, 21);
            this.labelngsinh.TabIndex = 4;
            this.labelngsinh.Text = "Ngày Sinh :";
            // 
            // labelgioitinh
            // 
            this.labelgioitinh.AutoSize = true;
            this.labelgioitinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgioitinh.Location = new System.Drawing.Point(4, 158);
            this.labelgioitinh.Name = "labelgioitinh";
            this.labelgioitinh.Size = new System.Drawing.Size(80, 21);
            this.labelgioitinh.TabIndex = 3;
            this.labelgioitinh.Text = "Giới Tính :";
            // 
            // labellop
            // 
            this.labellop.AutoSize = true;
            this.labellop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellop.Location = new System.Drawing.Point(4, 118);
            this.labellop.Name = "labellop";
            this.labellop.Size = new System.Drawing.Size(44, 21);
            this.labellop.TabIndex = 2;
            this.labellop.Text = "Lớp :";
            // 
            // labelhoten
            // 
            this.labelhoten.AutoSize = true;
            this.labelhoten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhoten.Location = new System.Drawing.Point(4, 77);
            this.labelhoten.Name = "labelhoten";
            this.labelhoten.Size = new System.Drawing.Size(85, 21);
            this.labelhoten.TabIndex = 1;
            this.labelhoten.Text = "Họ Và Tên :";
            // 
            // labelmahs
            // 
            this.labelmahs.AutoSize = true;
            this.labelmahs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmahs.Location = new System.Drawing.Point(4, 40);
            this.labelmahs.Name = "labelmahs";
            this.labelmahs.Size = new System.Drawing.Size(105, 21);
            this.labelmahs.TabIndex = 0;
            this.labelmahs.Text = "Mã Học Sinh :";
            // 
            // groupthongtin
            // 
            this.groupthongtin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(213)))), ((int)(((byte)(246)))));
            this.groupthongtin.Controls.Add(this.tbEmail);
            this.groupthongtin.Controls.Add(this.tbDiaChi);
            this.groupthongtin.Controls.Add(this.tbNgaySinh);
            this.groupthongtin.Controls.Add(this.tbGioiTinh);
            this.groupthongtin.Controls.Add(this.tbLop);
            this.groupthongtin.Controls.Add(this.tbHoVaTen);
            this.groupthongtin.Controls.Add(this.tbMaHocSinh);
            this.groupthongtin.Controls.Add(this.labelmail);
            this.groupthongtin.Controls.Add(this.labeldiachi);
            this.groupthongtin.Controls.Add(this.labelngsinh);
            this.groupthongtin.Controls.Add(this.labelgioitinh);
            this.groupthongtin.Controls.Add(this.labellop);
            this.groupthongtin.Controls.Add(this.labelhoten);
            this.groupthongtin.Controls.Add(this.labelmahs);
            this.groupthongtin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupthongtin.Location = new System.Drawing.Point(791, 87);
            this.groupthongtin.Name = "groupthongtin";
            this.groupthongtin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupthongtin.Size = new System.Drawing.Size(329, 325);
            this.groupthongtin.TabIndex = 30;
            this.groupthongtin.TabStop = false;
            this.groupthongtin.Text = "Thông tin chi tiết";
            // 
            // Search
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(213)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1144, 541);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cbTieuChiTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbTuKhoaTimKiem);
            this.Controls.Add(this.groupthongtin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Search";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Search_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupthongtin.ResumeLayout(false);
            this.groupthongtin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnThoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbTieuChiTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbNgaySinh;
        private System.Windows.Forms.TextBox tbGioiTinh;
        private System.Windows.Forms.TextBox tbLop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvdshs;
        private System.Windows.Forms.ColumnHeader clSTT;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colLop;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbTuKhoaTimKiem;
        private System.Windows.Forms.TextBox tbHoVaTen;
        private System.Windows.Forms.TextBox tbMaHocSinh;
        private System.Windows.Forms.Label labelmail;
        private System.Windows.Forms.Label labeldiachi;
        private System.Windows.Forms.Label labelngsinh;
        private System.Windows.Forms.Label labelgioitinh;
        private System.Windows.Forms.Label labellop;
        private System.Windows.Forms.Label labelhoten;
        private System.Windows.Forms.Label labelmahs;
        private System.Windows.Forms.GroupBox groupthongtin;
        private System.Windows.Forms.ColumnHeader clMaHocSinh;
    }
}