using System;
using System.Windows.Forms;
using System.Collections.Generic;
using BLL;
using DTO;
using GUI.FormNhapLieu;

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
            btnThemHS.IconVisible = btnSuaHS.IconVisible = btnXoaHocSinh.IconVisible = true;
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

        
        void LoadNamHoc_DSLop()
        {
            listNamHoc = namhocbll.GetListNamHoc();

            List<string> listTenNH = new List<string>();
            foreach (NamHoc namhoc in listNamHoc)
            {
                listTenNH.Add(namhoc.MaNamHoc);
            }

            cbNH_HSLH.DataSource = listTenNH;
        }

        /// <summary>
        /// Load all class to combobox
        /// </summary>
        void LoadMaLop_DSLH()
        {
           // if (listLop.Count == 0)
                listLop = lopBLL.GetLopTheoNamHoc(cbNH_HSLH.Text);
            List<string> listTenLop = new List<string>();

            foreach(Lop lop in listLop)
            {
                listTenLop.Add(lop.TenLop);
            }

            cbLop_DSLH.DataSource = listTenLop;
        }

        /// <summary>
        /// Load all namhoc to combobox manh hinh Danh sach khoi lop
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

        /// <summary>
        /// Load nam hoc lem combobox man hinh chuyen lop
        /// </summary>
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

        /// <summary>
        /// Load hoc ky len combobox man hinh chuyen lop
        /// </summary>
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

        /// <summary>
        /// Load danh sach lop len combobox man hinh chuyen lop
        /// </summary>
        void LoadLop_CL()
        {
            if (listLop.Count == 0)
                listLop = lopBLL.GetListLop();

            List<string> listmaLopCu = new List<string>();
            List<string> listmaLopMoi = new List<string>();
            foreach (Lop lop in listLop)
            {
                listmaLopCu.Add(lop.TenLop+" ("+ lop.MaLop+")");
                listmaLopMoi.Add(lop.TenLop + " (" + lop.MaLop + ")");
            }

            cbLopChuyenLopCu.DataSource = listmaLopCu;
            cbLop_ChuyenLop_Moi.DataSource = listmaLopMoi;
        }

        /// <summary>
        /// Load danh sach lop len combobox man hinh xep lop
        /// </summary>
        void LoadLop_XL()
        {
            List<Lop> listLop = lopBLL.GetListLop();

            List<string> listtenlop = new List<string>();
            foreach (Lop lop in listLop)
            {
                listtenlop.Add(lop.MaLop+" ("+lop.TenLop+" )");
            }

            cbLop_XL.DataSource = listtenlop;
        }

        /// <summary>
        /// load danh sach nam hoc len combobox man hinh xep lop
        /// </summary>
        void LoadNH_XL()
        {
            List<NamHoc> listNamHoc = namhocbll.GetListNamHoc();
            List<string> listMaNH = new List<string>();
            foreach (NamHoc namhoc in listNamHoc)
            {
                listMaNH.Add(namhoc.MaNamHoc);
            }

            cbNamHoc_XL.DataSource = listMaNH;
        }

        /// <summary>
        /// Load hoc ky len combobox man hinh xep lop
        /// </summary>
        void LoadHocKy_XL()
        {
            HocKyBLL hocKybll = new HocKyBLL();
            List<HocKy> listHocKy = hocKybll.GetListHocKy();

            List<string> listmaHocKy = new List<string>();
            foreach (HocKy hocky in listHocKy)
            {
                listmaHocKy.Add(hocky.MaHocKy);
            }

            cbHocKy_XL.DataSource = listmaHocKy;
        }

        /// <summary>
        /// load danh sach hoc sinh chua duoc xep lop len listView
        /// </summary>
        void LoadDanhSachHocSinhChuaXepLop()
        {
            List<HocSinh> listHocSinh = hocSinhbll.GetDSHocSinhChuaXepLop();
            lvDSHSChuaCoLop_XepLop.Items.Clear();
            int soThuTu = 1;

            foreach(HocSinh hocsinh in listHocSinh)
            {
                ListViewItem lvi = new ListViewItem(soThuTu + "");
                lvi.SubItems.Add(hocsinh.MaHocSinh);
                lvi.SubItems.Add(hocsinh.HoVaTen);
                lvi.SubItems.Add(hocsinh.GioiTinh);

                lvDSHSChuaCoLop_XepLop.Items.Add(lvi);
            }
        }

        /// <summary>
        /// load ds hoc sinh cua lop duoc chon chuyen vao
        /// </summary>
        void LoadDanhSachHocSinhLopDuocXep_MHXL()
        {
            gbDSHSLopChuyenDen_XL.Text = "Danh sách học sinh lớp " + cbLop_XL.Text;
            string malop = cbLop_XL.Text;
            string[] listma = malop.Split('(');
            malop = listma[0];

            LoadDanhSachHocSinh(3, cbNamHoc_XL.Text, cbHocKy_XL.Text, malop);
        }

        private void tcQuanLyLop_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                if (e.TabPageIndex == 0)
                {
                    //LoadNamHoc_DSHS();
                    //LoadDSHS_DSHS();
                    btnThemHS.IconVisible = btnSuaHS.IconVisible = btnXoaHocSinh.IconVisible = true;
                }
                else
                 if (e.TabPageIndex == 1)
                {
                    LoadNamHoc_DSLop();
                    LoadMaLop_DSLH();
                    btnThemLopHoc.IconVisible = btnSuaLopHoc.IconVisible = btnXoaLopHoc.IconVisible = true;
                }
                else
                 if (e.TabPageIndex == 2)
                {
                    LoadNH_DSKL();
                    btnThemKhoiLop.IconVisible = btnSua.IconVisible = btnXoaKhoiLop.IconVisible = true;
                }
                else
                 if (e.TabPageIndex == 3)
                {
                    LoadNH_CL();
                    LoadHK_CL();
                    LoadLop_CL();
                }
                else
                 if (e.TabPageIndex == 4)
                {
                    LoadLop_XL();
                    LoadNH_XL();
                    LoadHocKy_XL();
                    LoadDanhSachHocSinhChuaXepLop();
                    LoadDanhSachHocSinhLopDuocXep_MHXL();
                }
        }
            catch
            {
                MessageBox.Show("Không thể kết nối tới CSDL,vui lòng cài đặt lại kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        /// <summary>
        /// Load thong tin chung cua hoc sinh bao gom ca diem len listview DSHS
        /// </summary>
        void LoadDSHS_DSHS()
        {
            List<ThongTinChungHS_DiemTB> listThongTinChungHocSinh = hocSinhbll.GetDanhSachHocSinh_ThongTinChung_Diem(cbNH_DSHS.Text);
            lvdshs.Items.Clear();
            int soThuTu = 1;
            HocKyBLL hockybll = new HocKyBLL();
            List<HocKy> listhocky = hockybll.GetListHocKy();

            foreach(ThongTinChungHS_DiemTB hocsinh in listThongTinChungHocSinh)
            {

                int indexHocKy=0;
                for (int i = 0; i < listhocky.Count; i++)
                {
                    if (listhocky[i].MaHocKy == hocsinh.maHocKy)
                        indexHocKy = i + 4;
                }

                bool kiemTraTonTai = false;
                if (lvdshs.Items.Count > 0)
                {
                    foreach(ListViewItem lvitem in lvdshs.Items)
                    {
                        if (lvitem.SubItems[1].Text == hocsinh.maHocSinh)
                        {
                            kiemTraTonTai = true;
                                lvitem.SubItems[indexHocKy].Text = hocsinh.diemTB;
                            break;
                        }
                    }
                }

                if (!kiemTraTonTai)
                {
                    ListViewItem lvi = new ListViewItem(soThuTu + "");
                    lvi.SubItems.Add(hocsinh.maHocSinh);
                    lvi.SubItems.Add(hocsinh.TenHocSinh);
                    lvi.SubItems.Add(hocsinh.Lop);
                    lvi.SubItems.Add("-"); // diem tb hoc ki 1
                    lvi.SubItems.Add("-"); // dim trung binh hk 2
                    lvi.SubItems.Add("-"); // dim trung binh hk 3
                    lvi.SubItems.Add("-"); // dim trung binh hk 4


                    lvi.SubItems[indexHocKy].Text = hocsinh.diemTB;

                    lvdshs.Items.Add(lvi);
                    soThuTu++;
                }
            }
        }

        void LoadColumnHocKyLenListView()
        {
            HocKyBLL hockybll = new HocKyBLL();
            List<HocKy> listHocKy = hockybll.GetListHocKy();

            foreach(HocKy hocky in listHocKy)
            {
                ColumnHeader header = new ColumnHeader()
                {
                    Name = hocky.MaHocKy,
                    Text = "Điểm TB " + hocky.MaHocKy,
                    Width = 110
                };
                lvdshs.Columns.Add(header);
            }


            ColumnHeader colltemp1 = new ColumnHeader() { Name = "temp1", Text = "", Width = 0 };
            lvdshs.Columns.Add(colltemp1);
            ColumnHeader colltemp2 = new ColumnHeader() { Name = "temp2", Text = "", Width = 0 };
            lvdshs.Columns.Add(colltemp2);
            ColumnHeader colltemp3 = new ColumnHeader() { Name = "temp3", Text = "", Width = 0 };
            lvdshs.Columns.Add(colltemp3);
            ColumnHeader colltemp4 = new ColumnHeader() { Name = "temp4", Text = "", Width = 0 };
            lvdshs.Columns.Add(colltemp4);
        }
        private void QuanLyLopHoc_Load(object sender, EventArgs e)
        {
            LoadNamHoc_DSHS();
            LoadDSHS_DSHS();
            LoadColumnHocKyLenListView();
        }

        /// <summary>
        /// int listview =1 la lisstview lop cu. 2 la lop moi 3 la listView xepLop-dshoc sinh trong lop duoc chuyen den
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="maNamHoc"></param>
        /// <param name="maHocKy"></param>
        /// <param name="maLop"></param>
        void LoadDanhSachHocSinh(int listView, string maNamHoc,string maHocKy,string maLop)
        {
            List<HocSinh> listDSHocSinhCoDK;
            if (listView != 3)
            {
                string[] splitMaLop = maLop.Split('(');
                maLop = splitMaLop[1];
                splitMaLop = maLop.Split(')');
                maLop = splitMaLop[0];
            }


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
            if (listView == 2)
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
            else
            {

                lvDSHS_MHXL.Items.Clear();
                foreach (HocSinh hocsinh in listDSHocSinhCoDK)
                {
                    ListViewItem lvi = new ListViewItem(STT.ToString());
                    lvi.SubItems.Add(hocsinh.MaHocSinh);
                    lvi.SubItems.Add(hocsinh.HoVaTen);

                    lvDSHS_MHXL.Items.Add(lvi);
                    STT++;
                }
            }

        }

        private void cbNH_DSHS_SelectedIndexChanged(object sender, EventArgs e)
        {
           LoadDSHS_DSHS();
            lvdshs.Sorting= new SortOrder();
            lvdshs.Sorting = 0;
            lvdshs.Sort();
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
            //foreach (Lop lop in listLop)
            //    if (lop.MaLop == cbMaLop_DSLH.Text)
            //    {
            //        tbTenLop_DSLH.Text = lop.TenLop;
            //        tbSiSo_DSLH.Text = lop.SiSo.ToString();
            //        break;
            //    }

            Lop  lop = lopBLL.GetLop(cbLop_DSLH.Text,cbNH_HSLH.Text);
            tbMaLop_DSLH.Text = lop.MaLop;
            tbSiSo_DSLH.Text = lop.SiSo.ToString();

            LoadDSHSTheoLop(tbMaLop_DSLH.Text, cbLop_DSLH.Text);
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
                    tbHoTen_DSLH.Text = hs.HoVaTen;
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

                // kiem tra lop chuyen den da dat si so toi da chua
                ThayDoiQuyDinhBLL quydinhbll = new ThayDoiQuyDinhBLL();
                List<ThamSo> DanhSachThamSo = quydinhbll.GetListThamSo();
                int siSoToiDa = 100;
                foreach (ThamSo thamso in DanhSachThamSo)
                {
                    if (thamso.MaThamSo == "SiSoToiDa")
                        siSoToiDa = (int)thamso.GiaTri;
                }

                Lop lop = lopBLL.GetLop(cbLop_ChuyenLop_Moi.Text);
                if (lop.SiSo == siSoToiDa)
                {
                    MessageBox.Show("Lớp này đã đầy, bạn vui lòng xếp vào lớp khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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

        private void pbChuyenSangLopCu_Click(object sender, EventArgs e)
        {
            if (lvDSHSMoi_CL.SelectedItems.Count > 0)
            {

                // kiem tra lop chuyen den da dat si so toi da chua
                ThayDoiQuyDinhBLL quydinhbll = new ThayDoiQuyDinhBLL();
                List<ThamSo> DanhSachThamSo = quydinhbll.GetListThamSo();
                int siSoToiDa = 100;
                foreach (ThamSo thamso in DanhSachThamSo)
                {
                    if (thamso.MaThamSo == "SiSoToiDa")
                        siSoToiDa = (int)thamso.GiaTri;
                }

                Lop lop = lopBLL.GetLop(cbLopChuyenLopCu.Text);
                if (lop.SiSo == siSoToiDa)
                {
                    MessageBox.Show("Lớp này đã đầy, bạn vui lòng xếp vào lớp khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string maHocSinh = lvDSHSMoi_CL.SelectedItems[0].SubItems[1].Text;
                string maHocKy = cbHocKy_ChuyenLopMoi.Text;
                string maNamHoc = cbNH_ChuyenLopMoi.Text;

                QuaTrinhHocTapBLL qthocBll = new QuaTrinhHocTapBLL();
                QuaTrinhHocTap quaTrinhHocTap = qthocBll.GetQuaTrinhHocTapCo(maHocSinh, maHocKy, maNamHoc);

                ErrorType result = qthocBll.SuaQuatrinhhoctap(quaTrinhHocTap.MaQTH, cbLopChuyenLopCu.Text, cbHK_ChuyenLopCu.Text, cbNH_ChuyenLop_cu.Text, quaTrinhHocTap.MaHocSinh, quaTrinhHocTap.DiemTBHk);
                switch ((int)result)
                {
                    case (int)ErrorType.DA_TON_TAI:
                        MessageBox.Show(" Không thể chuyển,Đã tồn tại học sinh này trong lớp  của học kỳ và năm hoc chuyển tới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnThemHS_Click(object sender, EventArgs e)
        {
            ThemSuaHocSinh fThemSua = new ThemSuaHocSinh();
            fThemSua.ShowDialog();
        }

        private void btnSuaHS_Click(object sender, EventArgs e)
        {
            if (lvdshs.SelectedItems.Count > 0)
            {
                ThemSuaHocSinh fThemSua = new ThemSuaHocSinh
                (tbMaHocSinh_DSHS.Text,tbHoTen_DSHS.Text,tbNgaySinh_DSHS.Text,tbGioiTinh_DSHS.Text,tbEmail_DSHS.Text,tbDiaChi_DSHS.Text);
                fThemSua.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 học sinh để sửa !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaHocSinh_Click(object sender, EventArgs e)
        {
            if (lvdshs.SelectedItems.Count > 0)
            {
                DShocsinhBLL dshsbll = new DShocsinhBLL();
                bool result = dshsbll.XoaHs(lvdshs.SelectedItems[0].SubItems[1].Text);
                if(!result)
                        MessageBox.Show(" Không thể xóa,Vui lòng kiểm tra lại kết nối CSDL!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                        MessageBox.Show(" Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 học sinh để xóa !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvdshs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvdshs.SelectedItems.Count > 0)
            {
                string maHocSinh = lvdshs.SelectedItems[0].SubItems[1].Text;
                HocSinh hocsinh = hocSinhbll.GetHocSinh(maHocSinh);

                tbMaHocSinh_DSHS.Text = hocsinh.MaHocSinh;
                tbHoTen_DSHS.Text = hocsinh.HoVaTen;
                tbGioiTinh_DSHS.Text = hocsinh.GioiTinh;
                tbDiaChi_DSHS.Text = hocsinh.DiaChi;
                tbEmail_DSHS.Text = hocsinh.Email;
                tbNgaySinh_DSHS.Text = hocsinh.NamSinh;

                QuaTrinhHocTapBLL quaTrinhHocbll = new QuaTrinhHocTapBLL();
                List<QuaTrinhHocTap> listQuaTrinhHoc = quaTrinhHocbll.GetQuaTrinhHocTapCoMaHS(hocsinh.MaHocSinh);
                tbLop_DSHS.Text = listQuaTrinhHoc[0].MaLop;
            }
            
        }

        private void btnThemKhoiLop_Click(object sender, EventArgs e)
        {
            ThemSuaKhoiLop fThemSuaKhoiLop = new ThemSuaKhoiLop();
            fThemSuaKhoiLop.ShowDialog();
            LoadDSKL_TheoNH();
        }

        private void tcQuanLyLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbLop_XL_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachHocSinhLopDuocXep_MHXL();
        }

        private void cbNamHoc_XL_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachHocSinhLopDuocXep_MHXL();
        }

        private void cbHocKy_XL_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachHocSinhLopDuocXep_MHXL();
        }

        private void btnXepLop_Click(object sender, EventArgs e)
        {

            if (lvDSHSChuaCoLop_XepLop.SelectedItems.Count > 0)
            {
                // kiem tra lop chuyen den da dat si so toi da chua
                ThayDoiQuyDinhBLL quydinhbll = new ThayDoiQuyDinhBLL();
                List<ThamSo> DanhSachThamSo = quydinhbll.GetListThamSo();
                int siSoToiDa = 100;
                foreach (ThamSo thamso in DanhSachThamSo)
                {
                    if (thamso.MaThamSo == "SiSoToiDa")
                        siSoToiDa = (int)thamso.GiaTri;
                }

                string[] Listtemp = cbLop_XL.Text.Split(' ');
                Lop lop = lopBLL.GetLop(Listtemp[0]);
                if (lop.SiSo == siSoToiDa)
                {
                    MessageBox.Show("Lớp này đã đầy, bạn vui lòng xếp vào lớp khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                   

                bool Error = true;
                QuaTrinhHocTapBLL qthbll = new QuaTrinhHocTapBLL();
                foreach(ListViewItem lvi in lvDSHSChuaCoLop_XepLop.SelectedItems)
                {
                    string maQTHMax = qthbll.GetMaQTHMax();
                    string maQTH =""+ (Int32.Parse( maQTHMax)+1);
                    string maHocSinh = lvi.SubItems[1].Text;
                    string[] listTemp;
                    listTemp = cbLop_XL.Text.Split(' ');
                    string maLop = listTemp[0];

                    // MessageBox.Show(maQTH + "  " + maLop);
                    bool er = qthbll.ThemQuatrinhhoctap(maQTH, maLop, cbHocKy_XL.Text, cbNamHoc_XL.Text, maHocSinh, 0);
                    if (!er)
                    {
                        Error = true;
                        break;
                    }
                }

                if (Error)
                {
                    int soLuongHocSinhVuaXep = lvDSHSChuaCoLop_XepLop.SelectedItems.Count;
                    MessageBox.Show("Bạn vừa xếp thành công " + soLuongHocSinhVuaXep + " học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachHocSinhChuaXepLop();
                    LoadDanhSachHocSinhLopDuocXep_MHXL();
                }
                else
                {
                    MessageBox.Show("Lỗi, vui lòng xem lại chuỗi kết nối CSDL !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Bạn cần chọn ít nhất 1 học sinh để xếp lớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoaKhoiLop_Click(object sender, EventArgs e)
        {
                if (khoilopbll.XoaKhoilop(tbMaKL_DSKL.Text))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Không thể xóa , khối lớp đang giảng dạy!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXoaHocSinh_Click_1(object sender, EventArgs e)
        {
            if (lvdshs.SelectedItems.Count > 0)
            {
                string maHocSinh = lvdshs.SelectedItems[0].SubItems[1].Text;
                DShocsinhBLL hocsinhbll = new DShocsinhBLL();
                if (hocsinhbll.XoaHs(maHocSinh))
                {
                    MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSHS_DSHS();
                }                    
                else
                    MessageBox.Show("Xóa thất bại, thử kiểm tra lại kết nối CSDL!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Bạn phải chọn ít nhất 1 dòng để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKhoiLop = tbMaKL_DSKL.Text;
            string tenKhoiLop = tbTenKL_DSKL.Text;
            string phongBan = tbBan_DSKL.Text;
            string namHoc = cbNH_DSKL.Text;

            ThemSuaKhoiLop fThemSuaKhoiLop = new ThemSuaKhoiLop(maKhoiLop, tenKhoiLop, phongBan, namHoc);
            fThemSuaKhoiLop.ShowDialog();
            LoadDSKL_TheoNH();
        }



        private void btnXoaLopHoc_Click(object sender, EventArgs e)
        {
            if (lopBLL.Xoalop(cbLop_DSLH.Text))
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Không thể xóa , lớp đang nằm trong chương trình đào tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnThemLopHoc_Click(object sender, EventArgs e)
        {
            ThemSuaLop fThemSuaLop = new ThemSuaLop();
            fThemSuaLop.ShowDialog();
            LoadMaLop_DSLH();
        }

        private void btnSuaLopHoc_Click(object sender, EventArgs e)
        {
            ThemSuaLop fThemSuaLop = new ThemSuaLop(cbLop_DSLH.Text);
            fThemSuaLop.ShowDialog();
            LoadMaLop_DSLH();
        }

        private void cbNH_HSLH_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMaLop_DSLH();
        }
    }
}
