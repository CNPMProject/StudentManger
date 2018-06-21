namespace GUI.FormNhapLieu
{
    partial class ThemSuaMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemSuaMonHoc));
            this.tbTenMH_DSMH = new System.Windows.Forms.TextBox();
            this.tbMaMH_DSMH = new System.Windows.Forms.TextBox();
            this.lbMaMH = new System.Windows.Forms.Label();
            this.lbTenMH = new System.Windows.Forms.Label();
            this.btnLuu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHuyBo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTenMH_DSMH
            // 
            this.tbTenMH_DSMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTenMH_DSMH.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbTenMH_DSMH.Location = new System.Drawing.Point(206, 99);
            this.tbTenMH_DSMH.Multiline = true;
            this.tbTenMH_DSMH.Name = "tbTenMH_DSMH";
            this.tbTenMH_DSMH.Size = new System.Drawing.Size(222, 22);
            this.tbTenMH_DSMH.TabIndex = 16;
            // 
            // tbMaMH_DSMH
            // 
            this.tbMaMH_DSMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMaMH_DSMH.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbMaMH_DSMH.Location = new System.Drawing.Point(206, 52);
            this.tbMaMH_DSMH.Multiline = true;
            this.tbMaMH_DSMH.Name = "tbMaMH_DSMH";
            this.tbMaMH_DSMH.Size = new System.Drawing.Size(222, 22);
            this.tbMaMH_DSMH.TabIndex = 15;
            // 
            // lbMaMH
            // 
            this.lbMaMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMaMH.AutoSize = true;
            this.lbMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaMH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMaMH.Location = new System.Drawing.Point(77, 52);
            this.lbMaMH.Name = "lbMaMH";
            this.lbMaMH.Size = new System.Drawing.Size(107, 22);
            this.lbMaMH.TabIndex = 13;
            this.lbMaMH.Text = "Mã môn học";
            // 
            // lbTenMH
            // 
            this.lbTenMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTenMH.AutoSize = true;
            this.lbTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTenMH.Location = new System.Drawing.Point(77, 100);
            this.lbTenMH.Name = "lbTenMH";
            this.lbTenMH.Size = new System.Drawing.Size(115, 22);
            this.lbTenMH.TabIndex = 14;
            this.lbTenMH.Text = "Tên môn học";
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
            this.btnLuu.Location = new System.Drawing.Point(130, 156);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(66)))), ((int)(((byte)(244)))));
            this.btnLuu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(26)))), ((int)(((byte)(95)))));
            this.btnLuu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLuu.selected = false;
            this.btnLuu.Size = new System.Drawing.Size(107, 36);
            this.btnLuu.TabIndex = 21;
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
            this.btnHuyBo.Location = new System.Drawing.Point(279, 156);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(66)))), ((int)(((byte)(244)))));
            this.btnHuyBo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(26)))), ((int)(((byte)(95)))));
            this.btnHuyBo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHuyBo.selected = false;
            this.btnHuyBo.Size = new System.Drawing.Size(107, 36);
            this.btnHuyBo.TabIndex = 22;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBo.Textcolor = System.Drawing.Color.White;
            this.btnHuyBo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(203, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "*Vd: CTRR, CNPM";
            // 
            // ThemSuaMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(213)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(498, 252);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.tbTenMH_DSMH);
            this.Controls.Add(this.tbMaMH_DSMH);
            this.Controls.Add(this.lbMaMH);
            this.Controls.Add(this.lbTenMH);
            this.Name = "ThemSuaMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonHoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTenMH_DSMH;
        private System.Windows.Forms.TextBox tbMaMH_DSMH;
        private System.Windows.Forms.Label lbMaMH;
        private System.Windows.Forms.Label lbTenMH;
        private Bunifu.Framework.UI.BunifuFlatButton btnLuu;
        private Bunifu.Framework.UI.BunifuFlatButton btnHuyBo;
        private System.Windows.Forms.Label label1;
    }
}