using System;
using System.Windows.Forms;
using System.Collections.Generic;
using BLL;
using DTO;

namespace GUI.MainForm
{
    public partial class QuanLyLopHoc : Form
    {
        //khi them xoa sua thi moi thay doi list nay
        //neu khong thi lay cai cu do mat cong load xuong csdl
        NamHocBLL namhocbll = new NamHocBLL();
        List<NamHoc> listNamHoc = new List<NamHoc>();

        LopBLL lopBLL = new LopBLL();
        List<Lop> listLop = new List<Lop>();

        DShocsinhBLL hocSinhbll = new DShocsinhBLL();
        List<HocSinh> listDSHocSinh = new List<HocSinh>();

        KhoiLopBLL khoilopbll = new KhoiLopBLL();
        List<KhoiLop> listKhoiLop = new List<KhoiLop>();

        public QuanLyLopHoc()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load all namhoc to combobox danh sach hoc sinh
        /// </summary>
        void LoadNamHoc_DSHS()
        {
            if (listNamHoc.Count == 0)
                listNamHoc = namhocbll.GetListNamHoc();

            List<string> listTenNH = new List<string>();
            foreach(NamHoc namhoc in listNamHoc)
            {
                listTenNH.Add(namhoc.MaNamHoc);
            }

            cbNH_DSHS.DataSource = listTenNH;
        }

        void LoadDSHS_DSHS()
        {

        }

        /// <summary>
        /// Load all class to combobox
        /// </summary>
        void LoadMaLop_DSLH()
        {
            if (listLop.Count == 0)
                listLop = lopBLL.GetListLop();
            List<string> listMaLop = new List<string>();

            foreach(Lop lop in listLop)
            {
                listMaLop.Add(lop.MaLop);
            }

            cbMaLop_DSLH.DataSource = listMaLop;
        }

        /// <summary>
        /// Load all namhoc to combobox Danh sach khoi lop
        /// </summary>
        void LoadNH_DSKL()
        {
            if(listNamHoc.Count==0)
            listNamHoc = namhocbll.GetListNamHoc();

            List<string> listMaNH = new List<string>();
            foreach (NamHoc namhoc in listNamHoc)
            {
                listMaNH.Add(namhoc.MaNamHoc);
            }

            cbNH_DSKL.DataSource = listMaNH;
        }

        void LoadNH_CL()
        {
            if (listNamHoc.Count == 0)
                listNamHoc = namhocbll.GetListNamHoc();

            List<string> listMaNHCu = new List<string>();
            List<string> listMaNHMoi = new List<string>();
            foreach (NamHoc namhoc in listNamHoc)
            {
                listMaNHCu.Add(namhoc.MaNamHoc);
                listMaNHMoi.Add(namhoc.MaNamHoc);
            }

            cbNH_ChuyenLop_cu.DataSource = listMaNHCu;
            cbNH_ChuyenLopMoi.DataSource = listMaNHMoi;
        }

        void LoadHK_CL()
        {
            HocKyBLL hocKybll = new HocKyBLL();
            List<HocKy> listHocKy = hocKybll.GetListHocKy();
            List<string> listmaHKCu = new List<string>();
            List<string> listmaHKMoi = new List<string>();
            foreach (HocKy hocky in listHocKy)
            {
                listmaHKCu.Add(hocky.MaHocKy);
                listmaHKMoi.Add(hocky.MaHocKy);
            }

            cbHK_ChuyenLopCu.DataSource = listmaHKCu;
            cbHocKy_ChuyenLopMoi.DataSource = listmaHKMoi;
        }
        void LoadLop_CL()
        {
            if (listLop.Count == 0)
                listLop = lopBLL.GetListLop();

            List<string> listmaLopCu = new List<string>();
            List<string> listmaLopMoi = new List<string>();
            foreach (Lop lop in listLop)
            {
                listmaLopCu.Add(lop.MaLop);
                listmaLopMoi.Add(lop.MaLop);
            }

            cbLopChuyenLopCu.DataSource = listmaLopCu;
            cbLop_ChuyenLop_Moi.DataSource = listmaLopMoi;
        }

        private void tcQuanLyLop_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                if (e.TabPageIndex == 0)
                {
                    LoadNamHoc_DSHS();
                    LoadDSHS_DSHS();
                }
                else
                 if (e.TabPageIndex == 1)
                {
                    LoadMaLop_DSLH();
                }
                else
                 if (e.TabPageIndex == 2)
                {
                    LoadNH_DSKL();
                }
                else
                 if (e.TabPageIndex == 3)
                {
                    LoadNH_CL();
                    LoadHK_CL();
                    LoadLop_CL();
                }
            }
            catch
            {
                MessageBox.Show("Không thể kết nối tới CSDL,vui lòng cài đặt lại kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuanLyLopHoc_Load(object sender, EventArgs e)
        {
            LoadNamHoc_DSHS();
        }

        /// <summary>
        /// int listview =1 la lisstview lop cu. 2 la lop moi
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="maNamHoc"></param>
        /// <param name="maHocKy"></param>
        /// <param name="maLop"></param>
        void LoadDanhSachHocSinh(int listView, string maNamHoc,string maHocKy,string maLop)
        {
            List<HocSinh> listDSHocSinhCoDK;
            listDSHocSinhCoDK = hocSinhbll.GetDSHocSinh(maNamHoc, maHocKy, maLop);

            int STT = 1;
            if(listView==1)
            {
                lvDSHSCu_CL.Items.Clear();
                foreach (HocSinh hocsinh in listDSHocSinhCoDK)
                {
                    ListViewItem lvi = new ListViewItem(STT.ToString());
                    lvi.SubItems.Add(hocsinh.MaHocSinh);
                    lvi.SubItems.Add(hocsinh.HoVaTen);

                    lvDSHSCu_CL.Items.Add(lvi);
                    STT++;
                }
            }
            else
            {
                lvDSHSMoi_CL.Items.Clear();
                foreach (HocSinh hocsinh in listDSHocSinhCoDK)
                {
                    ListViewItem lvi = new ListViewItem(STT.ToString());
                    lvi.SubItems.Add(hocsinh.MaHocSinh);
                    lvi.SubItems.Add(hocsinh.HoVaTen);

                    lvDSHSMoi_CL.Items.Add(lvi);
                    STT++;
                }
            }

        }

        private void cbNH_DSHS_SelectedIndexChanged(object sender, EventArgs e)
        {
           // LoadDanhSachHocSinh(cbNH_DSHS.Text);
        }


        void LoadDSHSTheoLop(string maLop,string tenLop)
        {
            gbDSHSTheoLop.Text = "Danh sách học sinh của lớp " + tenLop;
            DShocsinhBLL dsHocSinh = new DShocsinhBLL();
            List<HocSinh> dsHS = dsHocSinh.GetDSHocSinhTheoLop(maLop);
            int dem = 1;
            lvDSHSTheoLop.Items.Clear();

            foreach(HocSinh hocsinh in dsHS)
            {
                
                ListViewItem lvi = new ListViewItem(dem+"");
                lvi.SubItems.Add(hocsinh.MaHocSinh);
                lvi.SubItems.Add(hocsinh.HoVaTen);
                lvi.SubItems.Add(hocsinh.GioiTinh);
                lvi.SubItems.Add(hocsinh.NamSinh);
                lvi.SubItems.Add(hocsinh.DiaChi);

                lvDSHSTheoLop.Items.Add(lvi);
                dem++;
            }
        }

        private void cbMaLop_DSLH_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Lop lop in listLop)
                if (lop.MaLop == cbMaLop_DSLH.Text)
                {
                    tbTenLop_DSLH.Text = lop.TenLop;
                    tbSiSo_DSLH.Text = lop.SiSo.ToString();
                    break;
                }
                   
            LoadDSHSTheoLop(cbMaLop_DSLH.Text,tbTenLop_DSLH.Text);
        }

        private void lvDSHSTheoLop_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvDSHSTheoLop.SelectedItems.Count > 0)
            {
                string maHS = lvDSHSTheoLop.SelectedItems[0].SubItems[1].Text;
               // MessageBox.Show(maHS);
                HocSinh hs = hocSinhbll.GetHocSinh(maHS);

                if (hs!=null){
                    tbMaHS_DSLH.Text = hs.MaHocSinh;
                    tbHoTen_DSHS.Text = hs.HoVaTen;
                    tbNamSinh_DSLH.Text = hs.NamSinh;
                    tbGioiTinh_DSLH.Text = hs.GioiTinh;
                    tbmail_DSLH.Text = hs.Email;
                    tbDiaChi_DSLH.Text = hs.DiaChi;
                }
               
            }
        }

        void LoadDSKL_TheoNH()
        {
            KhoiLopBLL klbll = new KhoiLopBLL();
            List<KhoiLop> listKhoiLop = klbll.GetListKhoiLop(cbNH_DSKL.Text);

            lvDSKL_NH.Items.Clear();
            int stt = 1;
            foreach (KhoiLop khoiLop in listKhoiLop)
            {
                ListViewItem lvi = new ListViewItem(stt.ToString());
                lvi.SubItems.Add(khoiLop.MaKhoiLop);
                lvi.SubItems.Add(khoiLop.TenKhoiLop);
                stt++;

                lvDSKL_NH.Items.Add(lvi);
            }
        }

        private void cbNH_DSKL_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDSKL_TheoNH();
        }

        private void cbNH_ChuyenLop_cu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachHocSinh(1, cbNH_ChuyenLop_cu.Text, cbHK_ChuyenLopCu.Text, cbLopChuyenLopCu.Text);
        }

        private void cbHK_ChuyenLopCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachHocSinh(1, cbNH_ChuyenLop_cu.Text, cbHK_ChuyenLopCu.Text, cbLopChuyenLopCu.Text);
        }

        private void cbLopChuyenLopCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachHocSinh(1, cbNH_ChuyenLop_cu.Text, cbHK_ChuyenLopCu.Text, cbLopChuyenLopCu.Text);
        }

        private void cbNH_ChuyenLopMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachHocSinh(2, cbNH_ChuyenLopMoi.Text, cbHocKy_ChuyenLopMoi.Text, cbLop_ChuyenLop_Moi.Text);
        }

        private void cbHocKy_ChuyenLopMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachHocSinh(2, cbNH_ChuyenLopMoi.Text, cbHocKy_ChuyenLopMoi.Text, cbLop_ChuyenLop_Moi.Text);
        }

        private void cbLop_ChuyenLop_Moi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachHocSinh(2, cbNH_ChuyenLopMoi.Text, cbHocKy_ChuyenLopMoi.Text, cbLop_ChuyenLop_Moi.Text);
        }

        private void lvDSKL_NH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSKL_NH.SelectedItems.Count != 0)
            {
                string maKhoiLop = lvDSKL_NH.SelectedItems[0].SubItems[1].Text;
                KhoiLop khoiLop = khoilopbll.GetKhoiLop(maKhoiLop);

                tbTenKL_DSKL.Text = khoiLop.TenKhoiLop;
                tbMaKL_DSKL.Text = khoiLop.MaKhoiLop;
                tbBan_DSKL.Text = khoiLop.Ban;
                tbNH_DSKL.Text = khoiLop.MaNamHoc;

                int countKhoiLop = lopBLL.CountSoLuongLopTheoKhoi(khoiLop.MaKhoiLop);
                tbSoLuongLop_DSKL.Text = countKhoiLop.ToString();
            }
           
        }

        private void pbChuyenSangLopMoi_Click(object sender, EventArgs e)
        {
            if (lvDSHSCu_CL.SelectedItems.Count > 0)
            {
                string maHocSinh = lvDSHSCu_CL.SelectedItems[0].SubItems[1].Text;
                string maHocKy = cbHK_ChuyenLopCu.Text;
                string maNamHoc = cbNH_ChuyenLop_cu.Text;

                QuaTrinhHocTapBLL qthocBll = new QuaTrinhHocTapBLL();
                QuaTrinhHocTap quaTrinhHocTap = qthocBll.GetQuaTrinhHocTapCo(maHocSinh,maHocKy,maNamHoc);

                ErrorType result=  qthocBll.SuaQuatrinhhoctap(quaTrinhHocTap.MaQTH, cbLop_ChuyenLop_Moi.Text, cbHocKy_ChuyenLopMoi.Text, cbNH_ChuyenLopMoi.Text, quaTrinhHocTap.MaHocSinh, quaTrinhHocTap.DiemTBHk);
                switch ((int)result)
                {
                    case (int)ErrorType.DA_TON_TAI:
                        MessageBox.Show(" Không thể chuyển,Đã tồn tại học sinh này trong lớp mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case (int)ErrorType.THAT_BAI:
                        MessageBox.Show(" Không thể chuyển,Vui lòng kiểm tra lại kết nối CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    default:
                        MessageBox.Show(" Chuyển thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                }

                LoadDanhSachHocSinh(1, cbNH_ChuyenLop_cu.Text, cbHK_ChuyenLopCu.Text, cbLopChuyenLopCu.Text);
                LoadDanhSachHocSinh(2, cbNH_ChuyenLopMoi.Text, cbHocKy_ChuyenLopMoi.Text, cbLop_ChuyenLop_Moi.Text);
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 học sinh để chuyển lớp", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
