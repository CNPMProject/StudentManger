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
            this.gbListSVTheoLop = new System.Windows.Forms.GroupBox();
            this.lvListSV = new System.Windows.Forms.ListView();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.clSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clMa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenHS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clGT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbDanhSachMonHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDSHocKy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDSHTKT = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThemMH = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSuaMH = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbDiem = new System.Windows.Forms.TextBox();
            this.tnTenhS = new System.Windows.Forms.TextBox();
            this.tbMaHS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDSNH = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbListSVTheoLop.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // gbListSVTheoLop
            // 
            this.gbListSVTheoLop.Controls.Add(this.lvListSV);
            this.gbListSVTheoLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListSVTheoLop.Location = new System.Drawing.Point(31, 108);
            this.gbListSVTheoLop.Name = "gbListSVTheoLop";
            this.gbListSVTheoLop.Size = new System.Drawing.Size(472, 354);
            this.gbListSVTheoLop.TabIndex = 1;
            this.gbListSVTheoLop.TabStop = false;
            this.gbListSVTheoLop.Text = "Danh sách sinh viên  lớp:";
            // 
            // lvListSV
            // 
            this.lvListSV.BackColor = System.Drawing.SystemColors.Window;
            this.lvListSV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvListSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clSTT,
            this.clMa,
            this.clTenHS,
            this.clGT});
            this.lvListSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvListSV.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvListSV.FullRowSelect = true;
            this.lvListSV.GridLines = true;
            this.lvListSV.HideSelection = false;
            this.lvListSV.Location = new System.Drawing.Point(3, 23);
            this.lvListSV.Name = "lvListSV";
            this.lvListSV.Size = new System.Drawing.Size(466, 328);
            this.lvListSV.TabIndex = 0;
            this.lvListSV.UseCompatibleStateImageBehavior = false;
            this.lvListSV.View = System.Windows.Forms.View.Details;
            // 
            // cbMaLop
            // 
            this.cbMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaLop.FormattingEnabled = true;
            this.cbMaLop.Location = new System.Drawing.Point(221, 65);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(133, 24);
            this.cbMaLop.TabIndex = 3;
            this.cbMaLop.SelectedIndexChanged += new System.EventHandler(this.cbMaLop_SelectedIndexChanged);
            // 
            // clSTT
            // 
            this.clSTT.Text = "STT";
            // 
            // clMa
            // 
            this.clMa.Text = "Mã học sinh";
            this.clMa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clMa.Width = 110;
            // 
            // clTenHS
            // 
            this.clTenHS.Text = "Tên học sinh";
            this.clTenHS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clTenHS.Width = 200;
            // 
            // clGT
            // 
            this.clGT.Text = "Giới tính";
            this.clGT.Width = 90;
            // 
            // cbDanhSachMonHoc
            // 
            this.cbDanhSachMonHoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDanhSachMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDanhSachMonHoc.FormattingEnabled = true;
            this.cbDanhSachMonHoc.Location = new System.Drawing.Point(215, 107);
            this.cbDanhSachMonHoc.Name = "cbDanhSachMonHoc";
            this.cbDanhSachMonHoc.Size = new System.Drawing.Size(177, 24);
            this.cbDanhSachMonHoc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(26, 110);
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
            this.cbDSHocKy.Location = new System.Drawing.Point(458, 65);
            this.cbDSHocKy.Name = "cbDSHocKy";
            this.cbDSHocKy.Size = new System.Drawing.Size(133, 24);
            this.cbDSHocKy.TabIndex = 6;
            this.cbDSHocKy.SelectedIndexChanged += new System.EventHandler(this.cbDSHocKy_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(378, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Học kỳ :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMaHS);
            this.groupBox1.Controls.Add(this.tnTenhS);
            this.groupBox1.Controls.Add(this.tbDiem);
            this.groupBox1.Controls.Add(this.btnThemMH);
            this.groupBox1.Controls.Add(this.btnSuaMH);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbDSHTKT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbDanhSachMonHoc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(536, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 351);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điểm học viên";
            // 
            // cbDSHTKT
            // 
            this.cbDSHTKT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDSHTKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDSHTKT.FormattingEnabled = true;
            this.cbDSHTKT.Location = new System.Drawing.Point(215, 147);
            this.cbDSHTKT.Name = "cbDSHTKT";
            this.cbDSHTKT.Size = new System.Drawing.Size(177, 24);
            this.cbDSHTKT.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(26, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hình thức kiểm tra :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(26, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tên học sinh :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(26, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mã học sinh :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(26, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Điểm :";
            // 
            // btnThemMH
            // 
            this.btnThemMH.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThemMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(66)))), ((int)(((byte)(244)))));
            this.btnThemMH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemMH.BorderRadius = 0;
            this.btnThemMH.ButtonText = "Lưu";
            this.btnThemMH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMH.DisabledColor = System.Drawing.Color.Gray;
            this.btnThemMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMH.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThemMH.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnThemMH.Iconimage")));
            this.btnThemMH.Iconimage_right = null;
            this.btnThemMH.Iconimage_right_Selected = null;
            this.btnThemMH.Iconimage_Selected = null;
            this.btnThemMH.IconMarginLeft = 0;
            this.btnThemMH.IconMarginRight = 0;
            this.btnThemMH.IconRightVisible = false;
            this.btnThemMH.IconRightZoom = 0D;
            this.btnThemMH.IconVisible = false;
            this.btnThemMH.IconZoom = 70D;
            this.btnThemMH.IsTab = true;
            this.btnThemMH.Location = new System.Drawing.Point(80, 260);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(66)))), ((int)(((byte)(244)))));
            this.btnThemMH.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(26)))), ((int)(((byte)(95)))));
            this.btnThemMH.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThemMH.selected = false;
            this.btnThemMH.Size = new System.Drawing.Size(129, 36);
            this.btnThemMH.TabIndex = 22;
            this.btnThemMH.Text = "Lưu";
            this.btnThemMH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemMH.Textcolor = System.Drawing.Color.White;
            this.btnThemMH.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSuaMH
            // 
            this.btnSuaMH.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSuaMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSuaMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(66)))), ((int)(((byte)(244)))));
            this.btnSuaMH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaMH.BorderRadius = 0;
            this.btnSuaMH.ButtonText = "Hủy bỏ";
            this.btnSuaMH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaMH.DisabledColor = System.Drawing.Color.Gray;
            this.btnSuaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaMH.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSuaMH.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSuaMH.Iconimage")));
            this.btnSuaMH.Iconimage_right = null;
            this.btnSuaMH.Iconimage_right_Selected = null;
            this.btnSuaMH.Iconimage_Selected = null;
            this.btnSuaMH.IconMarginLeft = 0;
            this.btnSuaMH.IconMarginRight = 0;
            this.btnSuaMH.IconRightVisible = false;
            this.btnSuaMH.IconRightZoom = 0D;
            this.btnSuaMH.IconVisible = false;
            this.btnSuaMH.IconZoom = 70D;
            this.btnSuaMH.IsTab = true;
            this.btnSuaMH.Location = new System.Drawing.Point(242, 260);
            this.btnSuaMH.Name = "btnSuaMH";
            this.btnSuaMH.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(66)))), ((int)(((byte)(244)))));
            this.btnSuaMH.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(26)))), ((int)(((byte)(95)))));
            this.btnSuaMH.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSuaMH.selected = false;
            this.btnSuaMH.Size = new System.Drawing.Size(129, 36);
            this.btnSuaMH.TabIndex = 23;
            this.btnSuaMH.Text = "Hủy bỏ";
            this.btnSuaMH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSuaMH.Textcolor = System.Drawing.Color.White;
            this.btnSuaMH.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tbDiem
            // 
            this.tbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiem.Location = new System.Drawing.Point(215, 193);
            this.tbDiem.Name = "tbDiem";
            this.tbDiem.Size = new System.Drawing.Size(177, 23);
            this.tbDiem.TabIndex = 24;
            // 
            // tnTenhS
            // 
            this.tnTenhS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnTenhS.Location = new System.Drawing.Point(215, 70);
            this.tnTenhS.Name = "tnTenhS";
            this.tnTenhS.Size = new System.Drawing.Size(177, 23);
            this.tnTenhS.TabIndex = 24;
            // 
            // tbMaHS
            // 
            this.tbMaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaHS.Location = new System.Drawing.Point(215, 34);
            this.tbMaHS.Name = "tbMaHS";
            this.tbMaHS.Size = new System.Drawing.Size(177, 23);
            this.tbMaHS.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(148, 65);
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
            this.cbDSNH.Location = new System.Drawing.Point(713, 65);
            this.cbDSNH.Name = "cbDSNH";
            this.cbDSNH.Size = new System.Drawing.Size(133, 24);
            this.cbDSNH.TabIndex = 10;
            this.cbDSNH.SelectedIndexChanged += new System.EventHandler(this.cbDSNH_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(612, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Năm học :";
            // 
            // ThemSuaDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(213)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(984, 485);
            this.Controls.Add(this.cbDSNH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbDSHocKy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMaLop);
            this.Controls.Add(this.gbListSVTheoLop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ThemSuaDiem";
            this.Text = "Quản lý điểm";
            this.Load += new System.EventHandler(this.ThemSuaDiem_Load);
            this.panel1.ResumeLayout(false);
            this.gbListSVTheoLop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbListSVTheoLop;
        private System.Windows.Forms.ColumnHeader clSTT;
        private System.Windows.Forms.ColumnHeader clMa;
        private System.Windows.Forms.ColumnHeader clTenHS;
        private System.Windows.Forms.ColumnHeader clGT;
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
        private System.Windows.Forms.TextBox tnTenhS;
        private System.Windows.Forms.TextBox tbDiem;
        private Bunifu.Framework.UI.BunifuFlatButton btnThemMH;
        private Bunifu.Framework.UI.BunifuFlatButton btnSuaMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDSNH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvListSV;
    }
}