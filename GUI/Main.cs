using GUI.FormNhapLieu;
using GUI.MainForm;
using QLHS.FormChinh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Main : Form
    {
        private Bunifu.Framework.UI.BunifuTileButton btBaoCao;
        private Bunifu.Framework.UI.BunifuTileButton btNhapBangDiem;
        private Bunifu.Framework.UI.BunifuTileButton btTraCuu;
        private Bunifu.Framework.UI.BunifuTileButton btLapDS;
        private Bunifu.Framework.UI.BunifuTileButton btThemHocSinh;
        private Bunifu.Framework.UI.BunifuTileButton btQuyDinh;

        int Width_pandUser = 200;
        bool Hident = true;

        public Main()
        {
            InitializeComponent();
        }

        private void btnQuanlyMonHoc_Click(object sender, EventArgs e)
        {
            QuanLyMonHoc quanLyMobHoc = new QuanLyMonHoc() { TopLevel=false};
            pnBoard.Controls.Clear();
            pnBoard.Controls.Add(quanLyMobHoc);
            quanLyMobHoc.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Home home = new Home() { TopLevel=false};      
            //this.pnBoard.Controls.Clear();
            //this.pnBoard.Controls.Add(home);
            //home.Show();
            CreateMainIcon();

            //// btQuyDinh.Click += BtQuyDinh_Click;
            //// btBaoCao.Click += BtBaoCao_Click1;
            ////btThemHocSinh.Click += BtThemHocSinh_Click;
            //// btTraCuu.Click += BtTraCuu_Click;
            //btLapDS.Click += BtLapDS_Click;
            //btNhapBangDiem.Click += BtNhapBangDiem_Click;
        }

        private void btNhapBangDiem_Click(object sender, EventArgs e)
        {
            ThemSuaDiem themSuaDiem = new ThemSuaDiem() ;
           // pnBoard.Controls.Clear();
           // pnBoard.Controls.Add(themSuaDiem);
            themSuaDiem.ShowDialog();
        }

        private void btLapDS_Click(object sender, EventArgs e)
        {
            QuanLyLopHoc fLopHoc = new QuanLyLopHoc() { IsMdiContainer = false, TopLevel = false };
            pnBoard.Controls.Clear();
            pnBoard.Controls.Add(fLopHoc);
            fLopHoc.Show();
        }

        private void btTraCuu_Click(object sender, EventArgs e)
        {
            Search fSearch = new Search() { TopLevel = false };
            pnBoard.Controls.Clear();
            pnBoard.Controls.Add(fSearch);
            fSearch.Show();
        }

        private void btThemHocSinh_Click(object sender, EventArgs e)
        {
            ThemSuaHocSinh fThemSuaHocSinh = new ThemSuaHocSinh();
           // pnBoard.Controls.Clear();
           // pnBoard.Controls.Add(fThemSuaHocSinh);
            fThemSuaHocSinh.ShowDialog();
        }

        private void btBaoCao_Click(object sender, EventArgs e)
        {
            LapBaoCaoTongKet fBaoCao = new LapBaoCaoTongKet() { TopLevel = false };
            pnBoard.Controls.Clear();
            pnBoard.Controls.Add(fBaoCao);
            fBaoCao.Show();
        }

        private void btQuyDinh_Click(object sender, EventArgs e)
        {
            ThayDoiQuyDinh fQuyDinh = new ThayDoiQuyDinh() { TopLevel = false };
            pnBoard.Controls.Clear();
            pnBoard.Controls.Add(fQuyDinh);
            fQuyDinh.Show();
        }

        private void CreateMainIcon()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btBaoCao = new Bunifu.Framework.UI.BunifuTileButton();
            this.btNhapBangDiem = new Bunifu.Framework.UI.BunifuTileButton();
            this.btTraCuu = new Bunifu.Framework.UI.BunifuTileButton();
            this.btLapDS = new Bunifu.Framework.UI.BunifuTileButton();
            this.btThemHocSinh = new Bunifu.Framework.UI.BunifuTileButton();
            this.btQuyDinh = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();

            // btBaoCao
            // 
            this.btBaoCao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btBaoCao.color = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btBaoCao.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBaoCao.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaoCao.ForeColor = System.Drawing.Color.White;
            this.btBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("btBaoCao.Image")));
            this.btBaoCao.ImagePosition = 10;
            this.btBaoCao.ImageZoom = 30;
            this.btBaoCao.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.btBaoCao.LabelPosition = 39;
            this.btBaoCao.LabelText = "Lập báo cáo tổng kết";
            this.btBaoCao.Location = new System.Drawing.Point(719, 287);
            this.btBaoCao.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btBaoCao.Name = "btBaoCao";
            this.btBaoCao.Size = new System.Drawing.Size(210, 117);
            this.btBaoCao.TabIndex = 22;
            this.btBaoCao.Click += new System.EventHandler(this.btBaoCao_Click);


            // btNhapBangDiem
            // 
            this.btNhapBangDiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btNhapBangDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btNhapBangDiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btNhapBangDiem.color = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btNhapBangDiem.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btNhapBangDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNhapBangDiem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhapBangDiem.ForeColor = System.Drawing.Color.White;
            this.btNhapBangDiem.Image = ((System.Drawing.Image)(resources.GetObject("btNhapBangDiem.Image")));
            this.btNhapBangDiem.ImagePosition = 10;
            this.btNhapBangDiem.ImageZoom = 30;
            this.btNhapBangDiem.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.btNhapBangDiem.LabelPosition = 39;
            this.btNhapBangDiem.LabelText = "Nhận bảng điểm môn";
            this.btNhapBangDiem.Location = new System.Drawing.Point(472, 287);
            this.btNhapBangDiem.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btNhapBangDiem.Name = "btNhapBangDiem";
            this.btNhapBangDiem.Size = new System.Drawing.Size(211, 117);
            this.btNhapBangDiem.TabIndex = 21;
            this.btNhapBangDiem.Click += new System.EventHandler(this.btNhapBangDiem_Click);

            // btTraCuu
            // 
            this.btTraCuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btTraCuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btTraCuu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btTraCuu.color = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btTraCuu.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btTraCuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTraCuu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTraCuu.ForeColor = System.Drawing.Color.White;
            this.btTraCuu.Image = ((System.Drawing.Image)(resources.GetObject("btTraCuu.Image")));
            this.btTraCuu.ImagePosition = 10;
            this.btTraCuu.ImageZoom = 30;
            this.btTraCuu.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.btTraCuu.LabelPosition = 39;
            this.btTraCuu.LabelText = "Tra cứu học sinh";
            this.btTraCuu.Location = new System.Drawing.Point(719, 122);
            this.btTraCuu.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btTraCuu.Name = "btTraCuu";
            this.btTraCuu.Size = new System.Drawing.Size(210, 119);
            this.btTraCuu.TabIndex = 20;
            this.btTraCuu.Click += new System.EventHandler(this.btTraCuu_Click);

            // btLapDS
            // 
            this.btLapDS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btLapDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btLapDS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btLapDS.color = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btLapDS.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btLapDS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLapDS.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLapDS.ForeColor = System.Drawing.Color.White;
            this.btLapDS.Image = ((System.Drawing.Image)(resources.GetObject("btLapDS.Image")));
            this.btLapDS.ImagePosition = 10;
            this.btLapDS.ImageZoom = 27;
            this.btLapDS.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.btLapDS.LabelPosition = 39;
            this.btLapDS.LabelText = "Lập Danh Sách Lớp";
            this.btLapDS.Location = new System.Drawing.Point(215, 287);
            this.btLapDS.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btLapDS.Name = "btLapDS";
            this.btLapDS.Size = new System.Drawing.Size(220, 117);
            this.btLapDS.TabIndex = 19;
            this.btLapDS.Click += new System.EventHandler(this.btLapDS_Click);

            // btThemHocSinh
            // 
            this.btThemHocSinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btThemHocSinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btThemHocSinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btThemHocSinh.color = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btThemHocSinh.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btThemHocSinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThemHocSinh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemHocSinh.ForeColor = System.Drawing.Color.White;
            this.btThemHocSinh.Image = ((System.Drawing.Image)(resources.GetObject("btThemHocSinh.Image")));
            this.btThemHocSinh.ImagePosition = 10;
            this.btThemHocSinh.ImageZoom = 30;
            this.btThemHocSinh.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.btThemHocSinh.LabelPosition = 39;
            this.btThemHocSinh.LabelText = "Tiếp Nhận Học Sinh";
            this.btThemHocSinh.Location = new System.Drawing.Point(472, 122);
            this.btThemHocSinh.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btThemHocSinh.Name = "btThemHocSinh";
            this.btThemHocSinh.Size = new System.Drawing.Size(211, 119);
            this.btThemHocSinh.TabIndex = 18;
            this.btThemHocSinh.Click += new System.EventHandler(this.btThemHocSinh_Click);


            // btQuyDinh
            // 
            this.btQuyDinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btQuyDinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btQuyDinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btQuyDinh.color = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btQuyDinh.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btQuyDinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btQuyDinh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuyDinh.ForeColor = System.Drawing.Color.White;
            this.btQuyDinh.Image = ((System.Drawing.Image)(resources.GetObject("btQuyDinh.Image")));
            this.btQuyDinh.ImagePosition = 10;
            this.btQuyDinh.ImageZoom = 30;
            this.btQuyDinh.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.btQuyDinh.LabelPosition = 39;
            this.btQuyDinh.LabelText = "Quy Định Chung";
            this.btQuyDinh.Location = new System.Drawing.Point(215, 122);
            this.btQuyDinh.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btQuyDinh.Name = "btQuyDinh";
            this.btQuyDinh.Size = new System.Drawing.Size(220, 119);
            this.btQuyDinh.TabIndex = 16;
            this.btQuyDinh.Click += new System.EventHandler(this.btQuyDinh_Click);


            pnBoard.Controls.Add(this.btBaoCao);
            pnBoard.Controls.Add(this.btNhapBangDiem);
            pnBoard.Controls.Add(this.btTraCuu);
            pnBoard.Controls.Add(this.btLapDS);
            pnBoard.Controls.Add(this.btThemHocSinh);
            pnBoard.Controls.Add(this.btQuyDinh);

        }

        private void BtBaoCao_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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

        private void btnUser_Click(object sender, EventArgs e)
        {
            timerUser.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnBoard.Controls.Clear();
            CreateMainIcon();
        }

        private void btnQuanLyLop_Click(object sender, EventArgs e)
        {
            QuanLyLopHoc quanLyLopHoc = new QuanLyLopHoc() { IsMdiContainer = false, TopLevel = false };
            pnBoard.Controls.Clear();
            pnBoard.Controls.Add(quanLyLopHoc);
            quanLyLopHoc.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Search timkiem = new Search() { IsMdiContainer = false,TopLevel = false };
            pnBoard.Controls.Clear();
            pnBoard.Controls.Add(timkiem);
            timkiem.Show();
           
        }

        private void btnCoSoDuLieu_Click(object sender, EventArgs e)
        {
            CSDL csdl = new CSDL();// { TopLevel = false };
           // pnBoard.Controls.Clear();
            //pnBoard.Controls.Add(csdl);
            csdl.ShowDialog();
         
        }

        private void pbClose_Click(object sender, EventArgs e)
        {

        }

        private void btnQuyDinh_Click(object sender, EventArgs e)
        {
            ThayDoiQuyDinh thaydoi = new ThayDoiQuyDinh() { TopLevel=false};
            pnBoard.Controls.Clear();
            pnBoard.Controls.Add(thaydoi);
            thaydoi.Show();
        }

        private void pbClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            LapBaoCaoTongKet fBaoCaoTongKet = new LapBaoCaoTongKet() { TopLevel = false };
            pnBoard.Controls.Clear();
            pnBoard.Controls.Add(fBaoCaoTongKet);
            fBaoCaoTongKet.Show();
        }

        private void btnThemHocSinh_Click(object sender, EventArgs e)
        {
            ThemSuaHocSinh fThemSuaHocSinh = new ThemSuaHocSinh();
            fThemSuaHocSinh.ShowDialog();
        }

        private void btnInfor_Click(object sender, EventArgs e)
        {
            ThongTinNhom thongtin = new ThongTinNhom() { TopLevel=false};
            pnBoard.Controls.Clear();
            pnBoard.Controls.Add(thongtin);
            thongtin.Show();
        }
    }
}
