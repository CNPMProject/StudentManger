﻿namespace GUI.MainForm
{
    partial class LapBaoCaoTongKet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LapBaoCaoTongKet));
            this.cbNamHoc_BCHK = new System.Windows.Forms.ComboBox();
            this.cbHocKy_BCHK = new System.Windows.Forms.ComboBox();
            this.lbnamhoc = new System.Windows.Forms.Label();
            this.lbhocky = new System.Windows.Forms.Label();
            this.gbboloc = new System.Windows.Forms.GroupBox();
            this.btnTaoBaoCaoHocKy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbHocKy_BCMH = new System.Windows.Forms.ComboBox();
            this.cbMonHoc_BCMH = new System.Windows.Forms.ComboBox();
            this.lbnamhc = new System.Windows.Forms.Label();
            this.lbhcky = new System.Windows.Forms.Label();
            this.lbbaocaohocky = new System.Windows.Forms.Label();
            this.tbbaocaohocky = new System.Windows.Forms.TabPage();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gbbaocaohocky = new System.Windows.Forms.GroupBox();
            this.rpBaoCaoHocKy = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbNamHoc_BCMH = new System.Windows.Forms.ComboBox();
            this.lbmonhc = new System.Windows.Forms.Label();
            this.gbbolocmon = new System.Windows.Forms.GroupBox();
            this.btnXemBaoCaoMon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gbnoidungbaocao = new System.Windows.Forms.GroupBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnThoat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbbcaomonhoc = new System.Windows.Forms.Label();
            this.tbbaocaomon = new System.Windows.Forms.TabControl();
            this.rpBaoCaoMon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbboloc.SuspendLayout();
            this.tbbaocaohocky.SuspendLayout();
            this.gbbaocaohocky.SuspendLayout();
            this.gbbolocmon.SuspendLayout();
            this.gbnoidungbaocao.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbbaocaomon.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbNamHoc_BCHK
            // 
            this.cbNamHoc_BCHK.FormattingEnabled = true;
            this.cbNamHoc_BCHK.Location = new System.Drawing.Point(408, 25);
            this.cbNamHoc_BCHK.Name = "cbNamHoc_BCHK";
            this.cbNamHoc_BCHK.Size = new System.Drawing.Size(158, 28);
            this.cbNamHoc_BCHK.TabIndex = 3;
            // 
            // cbHocKy_BCHK
            // 
            this.cbHocKy_BCHK.FormattingEnabled = true;
            this.cbHocKy_BCHK.Location = new System.Drawing.Point(121, 25);
            this.cbHocKy_BCHK.Name = "cbHocKy_BCHK";
            this.cbHocKy_BCHK.Size = new System.Drawing.Size(158, 28);
            this.cbHocKy_BCHK.TabIndex = 2;
            // 
            // lbnamhoc
            // 
            this.lbnamhoc.AutoSize = true;
            this.lbnamhoc.Location = new System.Drawing.Point(319, 33);
            this.lbnamhoc.Name = "lbnamhoc";
            this.lbnamhoc.Size = new System.Drawing.Size(83, 20);
            this.lbnamhoc.TabIndex = 1;
            this.lbnamhoc.Text = "Năm Học :";
            // 
            // lbhocky
            // 
            this.lbhocky.AutoSize = true;
            this.lbhocky.Location = new System.Drawing.Point(48, 28);
            this.lbhocky.Name = "lbhocky";
            this.lbhocky.Size = new System.Drawing.Size(67, 20);
            this.lbhocky.TabIndex = 0;
            this.lbhocky.Text = "Học Kỳ :";
            // 
            // gbboloc
            // 
            this.gbboloc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbboloc.Controls.Add(this.btnTaoBaoCaoHocKy);
            this.gbboloc.Controls.Add(this.cbNamHoc_BCHK);
            this.gbboloc.Controls.Add(this.cbHocKy_BCHK);
            this.gbboloc.Controls.Add(this.lbnamhoc);
            this.gbboloc.Controls.Add(this.lbhocky);
            this.gbboloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbboloc.Location = new System.Drawing.Point(117, 50);
            this.gbboloc.Name = "gbboloc";
            this.gbboloc.Size = new System.Drawing.Size(883, 74);
            this.gbboloc.TabIndex = 2;
            this.gbboloc.TabStop = false;
            this.gbboloc.Text = "Bộ lọc";
            // 
            // btnTaoBaoCaoHocKy
            // 
            this.btnTaoBaoCaoHocKy.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTaoBaoCaoHocKy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTaoBaoCaoHocKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(66)))), ((int)(((byte)(244)))));
            this.btnTaoBaoCaoHocKy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTaoBaoCaoHocKy.BorderRadius = 0;
            this.btnTaoBaoCaoHocKy.ButtonText = "Xem báo cáo";
            this.btnTaoBaoCaoHocKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoBaoCaoHocKy.DisabledColor = System.Drawing.Color.Gray;
            this.btnTaoBaoCaoHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoBaoCaoHocKy.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTaoBaoCaoHocKy.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTaoBaoCaoHocKy.Iconimage")));
            this.btnTaoBaoCaoHocKy.Iconimage_right = null;
            this.btnTaoBaoCaoHocKy.Iconimage_right_Selected = null;
            this.btnTaoBaoCaoHocKy.Iconimage_Selected = null;
            this.btnTaoBaoCaoHocKy.IconMarginLeft = 0;
            this.btnTaoBaoCaoHocKy.IconMarginRight = 0;
            this.btnTaoBaoCaoHocKy.IconRightVisible = false;
            this.btnTaoBaoCaoHocKy.IconRightZoom = 0D;
            this.btnTaoBaoCaoHocKy.IconVisible = false;
            this.btnTaoBaoCaoHocKy.IconZoom = 70D;
            this.btnTaoBaoCaoHocKy.IsTab = true;
            this.btnTaoBaoCaoHocKy.Location = new System.Drawing.Point(627, 17);
            this.btnTaoBaoCaoHocKy.Name = "btnTaoBaoCaoHocKy";
            this.btnTaoBaoCaoHocKy.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(66)))), ((int)(((byte)(244)))));
            this.btnTaoBaoCaoHocKy.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(26)))), ((int)(((byte)(95)))));
            this.btnTaoBaoCaoHocKy.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTaoBaoCaoHocKy.selected = false;
            this.btnTaoBaoCaoHocKy.Size = new System.Drawing.Size(168, 36);
            this.btnTaoBaoCaoHocKy.TabIndex = 4;
            this.btnTaoBaoCaoHocKy.Text = "Xem báo cáo";
            this.btnTaoBaoCaoHocKy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTaoBaoCaoHocKy.Textcolor = System.Drawing.Color.White;
            this.btnTaoBaoCaoHocKy.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoBaoCaoHocKy.Click += new System.EventHandler(this.btnTaoBaoCaoHocKy_Click);
            // 
            // cbHocKy_BCMH
            // 
            this.cbHocKy_BCMH.FormattingEnabled = true;
            this.cbHocKy_BCMH.Location = new System.Drawing.Point(321, 20);
            this.cbHocKy_BCMH.Name = "cbHocKy_BCMH";
            this.cbHocKy_BCMH.Size = new System.Drawing.Size(87, 28);
            this.cbHocKy_BCMH.TabIndex = 7;
            // 
            // cbMonHoc_BCMH
            // 
            this.cbMonHoc_BCMH.FormattingEnabled = true;
            this.cbMonHoc_BCMH.Location = new System.Drawing.Point(103, 20);
            this.cbMonHoc_BCMH.Name = "cbMonHoc_BCMH";
            this.cbMonHoc_BCMH.Size = new System.Drawing.Size(100, 28);
            this.cbMonHoc_BCMH.TabIndex = 6;
            // 
            // lbnamhc
            // 
            this.lbnamhc.AutoSize = true;
            this.lbnamhc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnamhc.Location = new System.Drawing.Point(435, 25);
            this.lbnamhc.Name = "lbnamhc";
            this.lbnamhc.Size = new System.Drawing.Size(83, 20);
            this.lbnamhc.TabIndex = 4;
            this.lbnamhc.Text = "Năm Học :";
            // 
            // lbhcky
            // 
            this.lbhcky.AutoSize = true;
            this.lbhcky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhcky.Location = new System.Drawing.Point(244, 25);
            this.lbhcky.Name = "lbhcky";
            this.lbhcky.Size = new System.Drawing.Size(71, 20);
            this.lbhcky.TabIndex = 5;
            this.lbhcky.Text = "Học Kỳ  :";
            // 
            // lbbaocaohocky
            // 
            this.lbbaocaohocky.AutoSize = true;
            this.lbbaocaohocky.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbaocaohocky.Location = new System.Drawing.Point(415, 7);
            this.lbbaocaohocky.Name = "lbbaocaohocky";
            this.lbbaocaohocky.Size = new System.Drawing.Size(299, 29);
            this.lbbaocaohocky.TabIndex = 3;
            this.lbbaocaohocky.Text = "Báo Cáo Tổng Kết Học Kỳ ";
            // 
            // tbbaocaohocky
            // 
            this.tbbaocaohocky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(213)))), ((int)(((byte)(246)))));
            this.tbbaocaohocky.Controls.Add(this.bunifuFlatButton1);
            this.tbbaocaohocky.Controls.Add(this.lbbaocaohocky);
            this.tbbaocaohocky.Controls.Add(this.gbboloc);
            this.tbbaocaohocky.Controls.Add(this.gbbaocaohocky);
            this.tbbaocaohocky.Location = new System.Drawing.Point(4, 22);
            this.tbbaocaohocky.Name = "tbbaocaohocky";
            this.tbbaocaohocky.Padding = new System.Windows.Forms.Padding(3);
            this.tbbaocaohocky.Size = new System.Drawing.Size(1136, 515);
            this.tbbaocaohocky.TabIndex = 1;
            this.tbbaocaohocky.Text = "Báo Cáo Học Kỳ";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(66)))), ((int)(((byte)(244)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Thoát";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = false;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(1003, 463);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(66)))), ((int)(((byte)(244)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(26)))), ((int)(((byte)(95)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(130, 38);
            this.bunifuFlatButton1.TabIndex = 25;
            this.bunifuFlatButton1.Text = "Thoát";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // gbbaocaohocky
            // 
            this.gbbaocaohocky.Controls.Add(this.rpBaoCaoHocKy);
            this.gbbaocaohocky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbbaocaohocky.Location = new System.Drawing.Point(117, 130);
            this.gbbaocaohocky.Name = "gbbaocaohocky";
            this.gbbaocaohocky.Size = new System.Drawing.Size(883, 377);
            this.gbbaocaohocky.TabIndex = 1;
            this.gbbaocaohocky.TabStop = false;
            this.gbbaocaohocky.Text = "Nội dung báo cáo";
            // 
            // rpBaoCaoHocKy
            // 
            this.rpBaoCaoHocKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpBaoCaoHocKy.Location = new System.Drawing.Point(3, 22);
            this.rpBaoCaoHocKy.Name = "rpBaoCaoHocKy";
            this.rpBaoCaoHocKy.Size = new System.Drawing.Size(877, 352);
            this.rpBaoCaoHocKy.TabIndex = 0;
            // 
            // cbNamHoc_BCMH
            // 
            this.cbNamHoc_BCMH.FormattingEnabled = true;
            this.cbNamHoc_BCMH.Location = new System.Drawing.Point(524, 20);
            this.cbNamHoc_BCMH.Name = "cbNamHoc_BCMH";
            this.cbNamHoc_BCMH.Size = new System.Drawing.Size(108, 28);
            this.cbNamHoc_BCMH.TabIndex = 1;
            // 
            // lbmonhc
            // 
            this.lbmonhc.AutoSize = true;
            this.lbmonhc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmonhc.Location = new System.Drawing.Point(25, 28);
            this.lbmonhc.Name = "lbmonhc";
            this.lbmonhc.Size = new System.Drawing.Size(81, 20);
            this.lbmonhc.TabIndex = 2;
            this.lbmonhc.Text = "Môn Học :";
            // 
            // gbbolocmon
            // 
            this.gbbolocmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbbolocmon.Controls.Add(this.btnXemBaoCaoMon);
            this.gbbolocmon.Controls.Add(this.cbHocKy_BCMH);
            this.gbbolocmon.Controls.Add(this.cbMonHoc_BCMH);
            this.gbbolocmon.Controls.Add(this.lbnamhc);
            this.gbbolocmon.Controls.Add(this.lbhcky);
            this.gbbolocmon.Controls.Add(this.cbNamHoc_BCMH);
            this.gbbolocmon.Controls.Add(this.lbmonhc);
            this.gbbolocmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbbolocmon.Location = new System.Drawing.Point(158, 48);
            this.gbbolocmon.Name = "gbbolocmon";
            this.gbbolocmon.Size = new System.Drawing.Size(817, 72);
            this.gbbolocmon.TabIndex = 6;
            this.gbbolocmon.TabStop = false;
            this.gbbolocmon.Text = "Bộ Lọc";
            // 
            // btnXemBaoCaoMon
            // 
            this.btnXemBaoCaoMon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnXemBaoCaoMon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXemBaoCaoMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(66)))), ((int)(((byte)(244)))));
            this.btnXemBaoCaoMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXemBaoCaoMon.BorderRadius = 0;
            this.btnXemBaoCaoMon.ButtonText = "Xem báo cáo";
            this.btnXemBaoCaoMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemBaoCaoMon.DisabledColor = System.Drawing.Color.Gray;
            this.btnXemBaoCaoMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBaoCaoMon.Iconcolor = System.Drawing.Color.Transparent;
            this.btnXemBaoCaoMon.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnXemBaoCaoMon.Iconimage")));
            this.btnXemBaoCaoMon.Iconimage_right = null;
            this.btnXemBaoCaoMon.Iconimage_right_Selected = null;
            this.btnXemBaoCaoMon.Iconimage_Selected = null;
            this.btnXemBaoCaoMon.IconMarginLeft = 0;
            this.btnXemBaoCaoMon.IconMarginRight = 0;
            this.btnXemBaoCaoMon.IconRightVisible = false;
            this.btnXemBaoCaoMon.IconRightZoom = 0D;
            this.btnXemBaoCaoMon.IconVisible = false;
            this.btnXemBaoCaoMon.IconZoom = 70D;
            this.btnXemBaoCaoMon.IsTab = true;
            this.btnXemBaoCaoMon.Location = new System.Drawing.Point(657, 12);
            this.btnXemBaoCaoMon.Name = "btnXemBaoCaoMon";
            this.btnXemBaoCaoMon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(66)))), ((int)(((byte)(244)))));
            this.btnXemBaoCaoMon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(26)))), ((int)(((byte)(95)))));
            this.btnXemBaoCaoMon.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXemBaoCaoMon.selected = false;
            this.btnXemBaoCaoMon.Size = new System.Drawing.Size(141, 36);
            this.btnXemBaoCaoMon.TabIndex = 8;
            this.btnXemBaoCaoMon.Text = "Xem báo cáo";
            this.btnXemBaoCaoMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXemBaoCaoMon.Textcolor = System.Drawing.Color.White;
            this.btnXemBaoCaoMon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBaoCaoMon.Click += new System.EventHandler(this.btnXemBaoCaoMon_Click);
            // 
            // gbnoidungbaocao
            // 
            this.gbnoidungbaocao.Controls.Add(this.rpBaoCaoMon);
            this.gbnoidungbaocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbnoidungbaocao.Location = new System.Drawing.Point(158, 126);
            this.gbnoidungbaocao.Name = "gbnoidungbaocao";
            this.gbnoidungbaocao.Size = new System.Drawing.Size(817, 383);
            this.gbnoidungbaocao.TabIndex = 10;
            this.gbnoidungbaocao.TabStop = false;
            this.gbnoidungbaocao.Text = "Nội Dung Báo Cáo";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(213)))), ((int)(((byte)(246)))));
            this.tabPage1.Controls.Add(this.btnThoat);
            this.tabPage1.Controls.Add(this.gbnoidungbaocao);
            this.tabPage1.Controls.Add(this.gbbolocmon);
            this.tabPage1.Controls.Add(this.lbbcaomonhoc);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1136, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Báo Cáo Môn Học";
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
            this.btnThoat.IconVisible = false;
            this.btnThoat.IconZoom = 70D;
            this.btnThoat.IsTab = true;
            this.btnThoat.Location = new System.Drawing.Point(998, 469);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(66)))), ((int)(((byte)(244)))));
            this.btnThoat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(26)))), ((int)(((byte)(95)))));
            this.btnThoat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThoat.selected = false;
            this.btnThoat.Size = new System.Drawing.Size(130, 38);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThoat.Textcolor = System.Drawing.Color.White;
            this.btnThoat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbbcaomonhoc
            // 
            this.lbbcaomonhoc.AutoSize = true;
            this.lbbcaomonhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lbbcaomonhoc.Location = new System.Drawing.Point(426, 12);
            this.lbbcaomonhoc.Name = "lbbcaomonhoc";
            this.lbbcaomonhoc.Size = new System.Drawing.Size(314, 29);
            this.lbbcaomonhoc.TabIndex = 3;
            this.lbbcaomonhoc.Text = "BÁO CÁO TỔNG KẾT MÔN";
            this.lbbcaomonhoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbbaocaomon
            // 
            this.tbbaocaomon.Controls.Add(this.tabPage1);
            this.tbbaocaomon.Controls.Add(this.tbbaocaohocky);
            this.tbbaocaomon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbbaocaomon.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbbaocaomon.Location = new System.Drawing.Point(0, 0);
            this.tbbaocaomon.Name = "tbbaocaomon";
            this.tbbaocaomon.SelectedIndex = 0;
            this.tbbaocaomon.Size = new System.Drawing.Size(1144, 541);
            this.tbbaocaomon.TabIndex = 1;
            this.tbbaocaomon.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbbaocaomon_Selected);
            // 
            // rpBaoCaoMon
            // 
            this.rpBaoCaoMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpBaoCaoMon.Location = new System.Drawing.Point(3, 22);
            this.rpBaoCaoMon.Name = "rpBaoCaoMon";
            this.rpBaoCaoMon.Size = new System.Drawing.Size(811, 358);
            this.rpBaoCaoMon.TabIndex = 0;
            // 
            // LapBaoCaoTongKet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 541);
            this.Controls.Add(this.tbbaocaomon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LapBaoCaoTongKet";
            this.Text = "LapBaoCaoTongKet";
            this.Load += new System.EventHandler(this.LapBaoCaoTongKet_Load);
            this.gbboloc.ResumeLayout(false);
            this.gbboloc.PerformLayout();
            this.tbbaocaohocky.ResumeLayout(false);
            this.tbbaocaohocky.PerformLayout();
            this.gbbaocaohocky.ResumeLayout(false);
            this.gbbolocmon.ResumeLayout(false);
            this.gbbolocmon.PerformLayout();
            this.gbnoidungbaocao.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tbbaocaomon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNamHoc_BCHK;
        private System.Windows.Forms.ComboBox cbHocKy_BCHK;
        private System.Windows.Forms.Label lbnamhoc;
        private System.Windows.Forms.Label lbhocky;
        private System.Windows.Forms.GroupBox gbboloc;
        private System.Windows.Forms.ComboBox cbHocKy_BCMH;
        private System.Windows.Forms.ComboBox cbMonHoc_BCMH;
        private System.Windows.Forms.Label lbnamhc;
        private System.Windows.Forms.Label lbhcky;
        private System.Windows.Forms.Label lbbaocaohocky;
        private System.Windows.Forms.TabPage tbbaocaohocky;
        private System.Windows.Forms.GroupBox gbbaocaohocky;
        private System.Windows.Forms.ComboBox cbNamHoc_BCMH;
        private System.Windows.Forms.Label lbmonhc;
        private System.Windows.Forms.GroupBox gbbolocmon;
        private System.Windows.Forms.GroupBox gbnoidungbaocao;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbbcaomonhoc;
        private System.Windows.Forms.TabControl tbbaocaomon;
        private Microsoft.Reporting.WinForms.ReportViewer rpBaoCaoHocKy;
        private Bunifu.Framework.UI.BunifuFlatButton btnTaoBaoCaoHocKy;
        private Bunifu.Framework.UI.BunifuFlatButton btnXemBaoCaoMon;
        private Bunifu.Framework.UI.BunifuFlatButton btnThoat;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Microsoft.Reporting.WinForms.ReportViewer rpBaoCaoMon;
    }
}