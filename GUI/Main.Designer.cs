namespace GUI
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnTop = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.lbNameSoftWare = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnLapBaoCao = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnCoSoDuLieu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGiaoVien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanlyMonHoc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyLop = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuyDinh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timerUser = new System.Windows.Forms.Timer(this.components);
            this.pnBoard = new System.Windows.Forms.Panel();
            this.pnUser = new System.Windows.Forms.Panel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.pnLeft.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.pnBoard.SuspendLayout();
            this.pnUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(161)))), ((int)(((byte)(220)))));
            this.pnTop.Controls.Add(this.pbClose);
            this.pnTop.Controls.Add(this.lbNameSoftWare);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1194, 32);
            this.pnTop.TabIndex = 14;
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Red;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(1164, 3);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(26, 26);
            this.pbClose.TabIndex = 8;
            this.pbClose.TabStop = false;
            // 
            // lbNameSoftWare
            // 
            this.lbNameSoftWare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNameSoftWare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameSoftWare.ForeColor = System.Drawing.Color.White;
            this.lbNameSoftWare.Location = new System.Drawing.Point(0, 0);
            this.lbNameSoftWare.Name = "lbNameSoftWare";
            this.lbNameSoftWare.Size = new System.Drawing.Size(1194, 32);
            this.lbNameSoftWare.TabIndex = 7;
            this.lbNameSoftWare.Text = "Phần mềm quản lí học sinh";
            this.lbNameSoftWare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Location = new System.Drawing.Point(-1, -1);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(51, 52);
            this.btnHome.TabIndex = 9;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnLeft.Controls.Add(this.btnAdd);
            this.pnLeft.Controls.Add(this.btnDelete);
            this.pnLeft.Controls.Add(this.btnEdit);
            this.pnLeft.Controls.Add(this.btnUser);
            this.pnLeft.Controls.Add(this.btnHome);
            this.pnLeft.Location = new System.Drawing.Point(0, 33);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(50, 596);
            this.pnLeft.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(-1, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 51);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(-1, 447);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 51);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(0, 343);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(51, 51);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUser.BackgroundImage")));
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUser.Location = new System.Drawing.Point(-1, 135);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(51, 51);
            this.btnUser.TabIndex = 10;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnLapBaoCao
            // 
            this.btnLapBaoCao.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(128)))));
            this.btnLapBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLapBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.btnLapBaoCao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLapBaoCao.BorderRadius = 0;
            this.btnLapBaoCao.ButtonText = "Lập báo cáo tổng kết";
            this.btnLapBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapBaoCao.DisabledColor = System.Drawing.Color.Gray;
            this.btnLapBaoCao.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLapBaoCao.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLapBaoCao.Iconimage")));
            this.btnLapBaoCao.Iconimage_right = null;
            this.btnLapBaoCao.Iconimage_right_Selected = null;
            this.btnLapBaoCao.Iconimage_Selected = null;
            this.btnLapBaoCao.IconMarginLeft = 0;
            this.btnLapBaoCao.IconMarginRight = 0;
            this.btnLapBaoCao.IconRightVisible = true;
            this.btnLapBaoCao.IconRightZoom = 0D;
            this.btnLapBaoCao.IconVisible = true;
            this.btnLapBaoCao.IconZoom = 90D;
            this.btnLapBaoCao.IsTab = false;
            this.btnLapBaoCao.Location = new System.Drawing.Point(654, 1);
            this.btnLapBaoCao.Name = "btnLapBaoCao";
            this.btnLapBaoCao.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.btnLapBaoCao.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLapBaoCao.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLapBaoCao.selected = false;
            this.btnLapBaoCao.Size = new System.Drawing.Size(160, 51);
            this.btnLapBaoCao.TabIndex = 1;
            this.btnLapBaoCao.Text = "Lập báo cáo tổng kết";
            this.btnLapBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLapBaoCao.Textcolor = System.Drawing.Color.Black;
            this.btnLapBaoCao.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnMenu
            // 
            this.pnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.pnMenu.Controls.Add(this.btnCoSoDuLieu);
            this.pnMenu.Controls.Add(this.btnGiaoVien);
            this.pnMenu.Controls.Add(this.btnQuanlyMonHoc);
            this.pnMenu.Controls.Add(this.btnQuanLyLop);
            this.pnMenu.Controls.Add(this.btnTimKiem);
            this.pnMenu.Controls.Add(this.btnLapBaoCao);
            this.pnMenu.Controls.Add(this.btnQuyDinh);
            this.pnMenu.Location = new System.Drawing.Point(50, 33);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(1144, 52);
            this.pnMenu.TabIndex = 18;
            // 
            // btnCoSoDuLieu
            // 
            this.btnCoSoDuLieu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(128)))));
            this.btnCoSoDuLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.btnCoSoDuLieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCoSoDuLieu.BorderRadius = 0;
            this.btnCoSoDuLieu.ButtonText = "Kết nối dữ liệu";
            this.btnCoSoDuLieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoSoDuLieu.DisabledColor = System.Drawing.Color.Gray;
            this.btnCoSoDuLieu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCoSoDuLieu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCoSoDuLieu.Iconimage")));
            this.btnCoSoDuLieu.Iconimage_right = null;
            this.btnCoSoDuLieu.Iconimage_right_Selected = null;
            this.btnCoSoDuLieu.Iconimage_Selected = null;
            this.btnCoSoDuLieu.IconMarginLeft = 0;
            this.btnCoSoDuLieu.IconMarginRight = 0;
            this.btnCoSoDuLieu.IconRightVisible = true;
            this.btnCoSoDuLieu.IconRightZoom = 0D;
            this.btnCoSoDuLieu.IconVisible = true;
            this.btnCoSoDuLieu.IconZoom = 90D;
            this.btnCoSoDuLieu.IsTab = false;
            this.btnCoSoDuLieu.Location = new System.Drawing.Point(0, 1);
            this.btnCoSoDuLieu.Name = "btnCoSoDuLieu";
            this.btnCoSoDuLieu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.btnCoSoDuLieu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCoSoDuLieu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCoSoDuLieu.selected = false;
            this.btnCoSoDuLieu.Size = new System.Drawing.Size(160, 51);
            this.btnCoSoDuLieu.TabIndex = 6;
            this.btnCoSoDuLieu.Text = "Kết nối dữ liệu";
            this.btnCoSoDuLieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCoSoDuLieu.Textcolor = System.Drawing.Color.Black;
            this.btnCoSoDuLieu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoSoDuLieu.Click += new System.EventHandler(this.btnCoSoDuLieu_Click);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(128)))));
            this.btnGiaoVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.btnGiaoVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiaoVien.BorderRadius = 0;
            this.btnGiaoVien.ButtonText = "Phân công giảng dạy";
            this.btnGiaoVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiaoVien.DisabledColor = System.Drawing.Color.Gray;
            this.btnGiaoVien.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGiaoVien.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGiaoVien.Iconimage")));
            this.btnGiaoVien.Iconimage_right = null;
            this.btnGiaoVien.Iconimage_right_Selected = null;
            this.btnGiaoVien.Iconimage_Selected = null;
            this.btnGiaoVien.IconMarginLeft = 0;
            this.btnGiaoVien.IconMarginRight = 0;
            this.btnGiaoVien.IconRightVisible = true;
            this.btnGiaoVien.IconRightZoom = 0D;
            this.btnGiaoVien.IconVisible = true;
            this.btnGiaoVien.IconZoom = 90D;
            this.btnGiaoVien.IsTab = false;
            this.btnGiaoVien.Location = new System.Drawing.Point(164, 1);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.btnGiaoVien.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGiaoVien.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGiaoVien.selected = false;
            this.btnGiaoVien.Size = new System.Drawing.Size(160, 51);
            this.btnGiaoVien.TabIndex = 5;
            this.btnGiaoVien.Text = "Phân công giảng dạy";
            this.btnGiaoVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGiaoVien.Textcolor = System.Drawing.Color.Black;
            this.btnGiaoVien.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnQuanlyMonHoc
            // 
            this.btnQuanlyMonHoc.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(128)))));
            this.btnQuanlyMonHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.btnQuanlyMonHoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanlyMonHoc.BorderRadius = 0;
            this.btnQuanlyMonHoc.ButtonText = "Quản lý môn học";
            this.btnQuanlyMonHoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanlyMonHoc.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanlyMonHoc.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanlyMonHoc.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanlyMonHoc.Iconimage")));
            this.btnQuanlyMonHoc.Iconimage_right = null;
            this.btnQuanlyMonHoc.Iconimage_right_Selected = null;
            this.btnQuanlyMonHoc.Iconimage_Selected = null;
            this.btnQuanlyMonHoc.IconMarginLeft = 0;
            this.btnQuanlyMonHoc.IconMarginRight = 0;
            this.btnQuanlyMonHoc.IconRightVisible = true;
            this.btnQuanlyMonHoc.IconRightZoom = 0D;
            this.btnQuanlyMonHoc.IconVisible = true;
            this.btnQuanlyMonHoc.IconZoom = 90D;
            this.btnQuanlyMonHoc.IsTab = false;
            this.btnQuanlyMonHoc.Location = new System.Drawing.Point(490, 1);
            this.btnQuanlyMonHoc.Name = "btnQuanlyMonHoc";
            this.btnQuanlyMonHoc.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.btnQuanlyMonHoc.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnQuanlyMonHoc.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanlyMonHoc.selected = false;
            this.btnQuanlyMonHoc.Size = new System.Drawing.Size(160, 51);
            this.btnQuanlyMonHoc.TabIndex = 4;
            this.btnQuanlyMonHoc.Text = "Quản lý môn học";
            this.btnQuanlyMonHoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuanlyMonHoc.Textcolor = System.Drawing.Color.Black;
            this.btnQuanlyMonHoc.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanlyMonHoc.Click += new System.EventHandler(this.btnQuanlyMonHoc_Click);
            // 
            // btnQuanLyLop
            // 
            this.btnQuanLyLop.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(128)))));
            this.btnQuanLyLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuanLyLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.btnQuanLyLop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyLop.BorderRadius = 0;
            this.btnQuanLyLop.ButtonText = "Quản lý lớp học";
            this.btnQuanLyLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyLop.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyLop.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyLop.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyLop.Iconimage")));
            this.btnQuanLyLop.Iconimage_right = null;
            this.btnQuanLyLop.Iconimage_right_Selected = null;
            this.btnQuanLyLop.Iconimage_Selected = null;
            this.btnQuanLyLop.IconMarginLeft = 0;
            this.btnQuanLyLop.IconMarginRight = 0;
            this.btnQuanLyLop.IconRightVisible = true;
            this.btnQuanLyLop.IconRightZoom = 0D;
            this.btnQuanLyLop.IconVisible = true;
            this.btnQuanLyLop.IconZoom = 90D;
            this.btnQuanLyLop.IsTab = false;
            this.btnQuanLyLop.Location = new System.Drawing.Point(327, 1);
            this.btnQuanLyLop.Name = "btnQuanLyLop";
            this.btnQuanLyLop.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.btnQuanLyLop.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnQuanLyLop.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyLop.selected = false;
            this.btnQuanLyLop.Size = new System.Drawing.Size(160, 51);
            this.btnQuanLyLop.TabIndex = 3;
            this.btnQuanLyLop.Text = "Quản lý lớp học";
            this.btnQuanLyLop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuanLyLop.Textcolor = System.Drawing.Color.Black;
            this.btnQuanLyLop.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyLop.Click += new System.EventHandler(this.btnQuanLyLop_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(128)))));
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.BorderRadius = 0;
            this.btnTimKiem.ButtonText = "Tìm kiếm";
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.DisabledColor = System.Drawing.Color.Gray;
            this.btnTimKiem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Iconimage")));
            this.btnTimKiem.Iconimage_right = null;
            this.btnTimKiem.Iconimage_right_Selected = null;
            this.btnTimKiem.Iconimage_Selected = null;
            this.btnTimKiem.IconMarginLeft = 0;
            this.btnTimKiem.IconMarginRight = 0;
            this.btnTimKiem.IconRightVisible = true;
            this.btnTimKiem.IconRightZoom = 0D;
            this.btnTimKiem.IconVisible = true;
            this.btnTimKiem.IconZoom = 90D;
            this.btnTimKiem.IsTab = false;
            this.btnTimKiem.Location = new System.Drawing.Point(817, 1);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.btnTimKiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTimKiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimKiem.selected = false;
            this.btnTimKiem.Size = new System.Drawing.Size(160, 51);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimKiem.Textcolor = System.Drawing.Color.Black;
            this.btnTimKiem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnQuyDinh
            // 
            this.btnQuyDinh.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(49)))), ((int)(((byte)(128)))));
            this.btnQuyDinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuyDinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.btnQuyDinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuyDinh.BorderRadius = 0;
            this.btnQuyDinh.ButtonText = "Thay đổi quy định";
            this.btnQuyDinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuyDinh.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuyDinh.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuyDinh.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuyDinh.Iconimage")));
            this.btnQuyDinh.Iconimage_right = null;
            this.btnQuyDinh.Iconimage_right_Selected = null;
            this.btnQuyDinh.Iconimage_Selected = null;
            this.btnQuyDinh.IconMarginLeft = 0;
            this.btnQuyDinh.IconMarginRight = 0;
            this.btnQuyDinh.IconRightVisible = true;
            this.btnQuyDinh.IconRightZoom = 0D;
            this.btnQuyDinh.IconVisible = true;
            this.btnQuyDinh.IconZoom = 90D;
            this.btnQuyDinh.IsTab = false;
            this.btnQuyDinh.Location = new System.Drawing.Point(981, 1);
            this.btnQuyDinh.Name = "btnQuyDinh";
            this.btnQuyDinh.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.btnQuyDinh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnQuyDinh.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuyDinh.selected = false;
            this.btnQuyDinh.Size = new System.Drawing.Size(160, 51);
            this.btnQuyDinh.TabIndex = 0;
            this.btnQuyDinh.Text = "Thay đổi quy định";
            this.btnQuyDinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuyDinh.Textcolor = System.Drawing.Color.Black;
            this.btnQuyDinh.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuyDinh.Click += new System.EventHandler(this.btnQuyDinh_Click);
            // 
            // timerUser
            // 
            this.timerUser.Interval = 10;
            this.timerUser.Tick += new System.EventHandler(this.timerUser_Tick);
            // 
            // pnBoard
            // 
            this.pnBoard.Controls.Add(this.pnUser);
            this.pnBoard.Location = new System.Drawing.Point(50, 85);
            this.pnBoard.Name = "pnBoard";
            this.pnBoard.Size = new System.Drawing.Size(1144, 541);
            this.pnBoard.TabIndex = 19;
            // 
            // pnUser
            // 
            this.pnUser.Controls.Add(this.bunifuFlatButton3);
            this.pnUser.Controls.Add(this.bunifuFlatButton2);
            this.pnUser.Controls.Add(this.bunifuFlatButton1);
            this.pnUser.Controls.Add(this.bunifuTileButton1);
            this.pnUser.Location = new System.Drawing.Point(1, 1);
            this.pnUser.Name = "pnUser";
            this.pnUser.Size = new System.Drawing.Size(0, 540);
            this.pnUser.TabIndex = 0;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuFlatButton3.ButtonText = "Đăng xuất";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 80D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(3, 318);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(198, 48);
            this.bunifuFlatButton3.TabIndex = 9;
            this.bunifuFlatButton3.Text = "Đăng xuất";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuFlatButton2.ButtonText = "Đổi mật khẩu";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 80D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(2, 268);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(198, 48);
            this.bunifuFlatButton2.TabIndex = 8;
            this.bunifuFlatButton2.Text = "Đổi mật khẩu";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuFlatButton1.ButtonText = "Thông tin cá nhân";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 80D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(2, 218);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(198, 48);
            this.bunifuFlatButton1.TabIndex = 7;
            this.bunifuFlatButton1.Text = "Thông tin cá nhân";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuTileButton1.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "NameUser";
            this.bunifuTileButton1.Location = new System.Drawing.Point(2, 0);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(198, 164);
            this.bunifuTileButton1.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(213)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1194, 626);
            this.Controls.Add(this.pnBoard);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý học sinh";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.pnLeft.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.pnBoard.ResumeLayout(false);
            this.pnUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbNameSoftWare;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUser;
        private Bunifu.Framework.UI.BunifuFlatButton btnLapBaoCao;
        private System.Windows.Forms.Panel pnMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnCoSoDuLieu;
        private Bunifu.Framework.UI.BunifuFlatButton btnGiaoVien;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanlyMonHoc;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyLop;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimKiem;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuyDinh;
        private System.Windows.Forms.Timer timerUser;
        private System.Windows.Forms.Panel pnBoard;
        private System.Windows.Forms.Panel pnUser;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private System.Windows.Forms.PictureBox pbClose;
    }
}