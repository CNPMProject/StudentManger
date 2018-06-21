namespace GUI.FormNhapLieu
{
    partial class ThemSuaDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemSuaDiem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.cbDanhSachMonHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDSHocKy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMaHS = new System.Windows.Forms.TextBox();
            this.tbTenhS = new System.Windows.Forms.TextBox();
            this.tbDiem = new System.Windows.Forms.TextBox();
            this.btnLuu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHuyBo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDSHTKT = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDSNH = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbListHS = new System.Windows.Forms.GroupBox();
            this.lvDSHS = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbTop = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbListHS.SuspendLayout();
            this.gbTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(984, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý điểm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMaLop
            // 
            this.cbMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaLop.FormattingEnabled = true;
            this.cbMaLop.Location = new System.Drawing.Point(65, 39);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(133, 24);
            this.cbMaLop.TabIndex = 0;
            this.cbMaLop.SelectedIndexChanged += new System.EventHandler(this.cbMaLop_SelectedIndexChanged);
            // 
            // cbDanhSachMonHoc
            // 
            this.cbDanhSachMonHoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDanhSachMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDanhSachMonHoc.FormattingEnabled = true;
            this.cbDanhSachMonHoc.Location = new System.Drawing.Point(821, 38);
            this.cbDanhSachMonHoc.Name = "cbDanhSachMonHoc";
            this.cbDanhSachMonHoc.Size = new System.Drawing.Size(133, 24);
            this.cbDanhSachMonHoc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(715, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Môn học :";
            // 
            // cbDSHocKy
            // 
            this.cbDSHocKy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDSHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDSHocKy.FormattingEnabled = true;
            this.cbDSHocKy.Location = new System.Drawing.Point(304, 39);
            this.cbDSHocKy.Name = "cbDSHocKy";
            this.cbDSHocKy.Size = new System.Drawing.Size(133, 24);
            this.cbDSHocKy.TabIndex = 1;
            this.cbDSHocKy.SelectedIndexChanged += new System.EventHandler(this.cbDSHocKy_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(227, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Học kỳ :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMaHS);
            this.groupBox1.Controls.Add(this.tbTenhS);
            this.groupBox1.Controls.Add(this.tbDiem);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnHuyBo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbDSHTKT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(536, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 314);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điểm học viên";
            // 
            // tbMaHS
            // 
            this.tbMaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaHS.Location = new System.Drawing.Point(216, 39);
            this.tbMaHS.Name = "tbMaHS";
            this.tbMaHS.ReadOnly = true;
            this.tbMaHS.Size = new System.Drawing.Size(177, 23);
            this.tbMaHS.TabIndex = 24;
            // 
            // tbTenhS
            // 
            this.tbTenhS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenhS.Location = new System.Drawing.Point(216, 75);
            this.tbTenhS.Name = "tbTenhS";
            this.tbTenhS.ReadOnly = true;
            this.tbTenhS.Size = new System.Drawing.Size(177, 23);
            this.tbTenhS.TabIndex = 24;
            // 
            // tbDiem
            // 
            this.tbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiem.Location = new System.Drawing.Point(216, 161);
            this.tbDiem.Name = "tbDiem";
            this.tbDiem.Size = new System.Drawing.Size(177, 23);
            this.tbDiem.TabIndex = 24;
            // 
            // btnLuu
            // 
            this.btnLuu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(66)))), ((int)(((byte)(244)))));
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.BorderRadius = 0;
            this.btnLuu.ButtonText = "Lưu";
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.DisabledColor = System.Drawing.Color.Gray;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLuu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLuu.Iconimage")));
            this.btnLuu.Iconimage_right = null;
            this.btnLuu.Iconimage_right_Selected = null;
            this.btnLuu.Iconimage_Selected = null;
            this.btnLuu.IconMarginLeft = 0;
            this.btnLuu.IconMarginRight = 0;
            this.btnLuu.IconRightVisible = false;
            this.btnLuu.IconRightZoom = 0D;
            this.btnLuu.IconVisible = true;
            this.btnLuu.IconZoom = 70D;
            this.btnLuu.IsTab = true;
            this.btnLuu.Location = new System.Drawing.Point(79, 220);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(66)))), ((int)(((byte)(244)))));
            this.btnLuu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(26)))), ((int)(((byte)(95)))));
            this.btnLuu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLuu.selected = false;
            this.btnLuu.Size = new System.Drawing.Size(129, 36);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu.Textcolor = System.Drawing.Color.White;
            this.btnLuu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHuyBo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuyBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(66)))), ((int)(((byte)(244)))));
            this.btnHuyBo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHuyBo.BorderRadius = 0;
            this.btnHuyBo.ButtonText = "Hủy bỏ";
            this.btnHuyBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyBo.DisabledColor = System.Drawing.Color.Gray;
            this.btnHuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHuyBo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHuyBo.Iconimage")));
            this.btnHuyBo.Iconimage_right = null;
            this.btnHuyBo.Iconimage_right_Selected = null;
            this.btnHuyBo.Iconimage_Selected = null;
            this.btnHuyBo.IconMarginLeft = 0;
            this.btnHuyBo.IconMarginRight = 0;
            this.btnHuyBo.IconRightVisible = false;
            this.btnHuyBo.IconRightZoom = 0D;
            this.btnHuyBo.IconVisible = true;
            this.btnHuyBo.IconZoom = 70D;
            this.btnHuyBo.IsTab = true;
            this.btnHuyBo.Location = new System.Drawing.Point(241, 220);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(66)))), ((int)(((byte)(244)))));
            this.btnHuyBo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(26)))), ((int)(((byte)(95)))));
            this.btnHuyBo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHuyBo.selected = false;
            this.btnHuyBo.Size = new System.Drawing.Size(129, 36);
            this.btnHuyBo.TabIndex = 1;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHuyBo.Textcolor = System.Drawing.Color.White;
            this.btnHuyBo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(27, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Điểm :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(27, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hình thức kiểm tra :";
            // 
            // cbDSHTKT
            // 
            this.cbDSHTKT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDSHTKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDSHTKT.FormattingEnabled = true;
            this.cbDSHTKT.Location = new System.Drawing.Point(216, 115);
            this.cbDSHTKT.Name = "cbDSHTKT";
            this.cbDSHTKT.Size = new System.Drawing.Size(177, 24);
            this.cbDSHTKT.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(27, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mã học sinh :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(27, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tên học sinh :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lớp :";
            // 
            // cbDSNH
            // 
            this.cbDSNH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDSNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDSNH.FormattingEnabled = true;
            this.cbDSNH.Location = new System.Drawing.Point(557, 39);
            this.cbDSNH.Name = "cbDSNH";
            this.cbDSNH.Size = new System.Drawing.Size(133, 24);
            this.cbDSNH.TabIndex = 2;
            this.cbDSNH.SelectedIndexChanged += new System.EventHandler(this.cbDSNH_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(467, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Năm học :";
            // 
            // gbListHS
            // 
            this.gbListHS.Controls.Add(this.lvDSHS);
            this.gbListHS.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListHS.Location = new System.Drawing.Point(12, 145);
            this.gbListHS.Name = "gbListHS";
            this.gbListHS.Size = new System.Drawing.Size(495, 314);
            this.gbListHS.TabIndex = 12;
            this.gbListHS.TabStop = false;
            this.gbListHS.Text = "Danh sách học sinh";
            // 
            // lvDSHS
            // 
            this.lvDSHS.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvDSHS.BackColor = System.Drawing.SystemColors.Window;
            this.lvDSHS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvDSHS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvDSHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDSHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDSHS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvDSHS.FullRowSelect = true;
            this.lvDSHS.GridLines = true;
            this.lvDSHS.Location = new System.Drawing.Point(3, 25);
            this.lvDSHS.Name = "lvDSHS";
            this.lvDSHS.Size = new System.Drawing.Size(489, 286);
            this.lvDSHS.TabIndex = 0;
            this.lvDSHS.UseCompatibleStateImageBehavior = false;
            this.lvDSHS.View = System.Windows.Forms.View.Details;
            this.lvDSHS.SelectedIndexChanged += new System.EventHandler(this.lvDSHS_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã học sinh";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên học sinh";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giới tính";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 130;
            // 
            // gbTop
            // 
            this.gbTop.Controls.Add(this.cbDSHocKy);
            this.gbTop.Controls.Add(this.cbMaLop);
            this.gbTop.Controls.Add(this.cbDSNH);
            this.gbTop.Controls.Add(this.label4);
            this.gbTop.Controls.Add(this.cbDanhSachMonHoc);
            this.gbTop.Controls.Add(this.label3);
            this.gbTop.Controls.Add(this.label9);
            this.gbTop.Controls.Add(this.label2);
            this.gbTop.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTop.Location = new System.Drawing.Point(15, 49);
            this.gbTop.Name = "gbTop";
            this.gbTop.Size = new System.Drawing.Size(960, 90);
            this.gbTop.TabIndex = 13;
            this.gbTop.TabStop = false;
            this.gbTop.Text = "Bộ lọc";
            // 
            // ThemSuaDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(213)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(984, 485);
            this.Controls.Add(this.gbTop);
            this.Controls.Add(this.gbListHS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "ThemSuaDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý điểm";
            this.Load += new System.EventHandler(this.ThemSuaDiem_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbListHS.ResumeLayout(false);
            this.gbTop.ResumeLayout(false);
            this.gbTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaLop;
        private System.Windows.Forms.ComboBox cbDanhSachMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDSHocKy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDSHTKT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMaHS;
        private System.Windows.Forms.TextBox tbTenhS;
        private System.Windows.Forms.TextBox tbDiem;
        private Bunifu.Framework.UI.BunifuFlatButton btnLuu;
        private Bunifu.Framework.UI.BunifuFlatButton btnHuyBo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDSNH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbListHS;
        private System.Windows.Forms.ListView lvDSHS;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox gbTop;
    }
}