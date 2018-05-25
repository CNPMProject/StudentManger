using BLL;
using DTO;
using GUI.FormNhapLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace GUI.MainForm
{
    public partial class QuanLyMonHoc : Form
    {
        MonHocBLL monhoc;
        //list nay de up len listview
        List<HinhThucKiemTra> listhtkt = new List<HinhThucKiemTra>();

        public QuanLyMonHoc()
        {
            InitializeComponent();
            monhoc = new MonHocBLL();

            btnThemCTDT.IconVisible = btnThemHTKT.IconVisible = btnSuaMH.IconVisible = true;
            btnThemMH.IconVisible = btnSuaHTKT.IconVisible = btnSuaCTDT.IconVisible = true;
            btnNhapDiem.IconVisible = btnSuaDiem.IconVisible = btnXoaCTDT.IconVisible = true;
            btnXoaMH.IconVisible = btnXoaHTKT.IconVisible = true;
        }

        /// <summary>
        /// load source cac mon hoc len combobox tab-page bang diem mon hic
        /// </summary>
        void LoadMonHoc_BangDiemMonHoc()
        {

            List<MonHoc> listMonHoc = monhoc.GetListMonHoc();

            //load source cac mon hoc len combobox tab-page bang diem mon hic
            List<string> listMaMH = new List<string>();
           // listMaMH.Add("Chọn tất cả.");
            foreach (MonHoc mon in listMonHoc)
            {
                listMaMH.Add(mon.MaMonHoc);
            }
            cbDanhSachMonHoc.DataSource = listMaMH;
        }

        void LoadLopHoc_BangDiemMonHoc()
        {
            LopBLL lopbll = new LopBLL();
            List<Lop> listLop = lopbll.GetListLop();
            List<string> nameClass = new List<string>();
           // nameClass.Add("Chọn tất cả.");


            foreach (Lop lop in listLop)
            {
                nameClass.Add(lop.MaLop + "(" + lop.TenLop + ")");
            }

            cbDSLop.DataSource = nameClass;
        }

        void LoadHocKy_BangDiemMonHoc()
        {
            HocKyBLL hockybll = new HocKyBLL();
            List<HocKy> listHK = hockybll.GetListHocKy();
            List<string> nameHocKy = new List<string>();
            //nameHocKy.Add("Chọn tất cả.");


            foreach (HocKy hocKy in listHK)
            {
                nameHocKy.Add(hocKy.MaHocKy);
            }

            cbDSHocKy.DataSource = nameHocKy;
        }

        /// <summary>
        /// Load danh sach mon hoc len tab-page danh sach mon hoc
        /// </summary>
        void LoadMonHoc_DanhSachMonHoc()
        {
            lvDanhSachMonHoc.Items.Clear();
            List<MonHoc> listMonHoc = monhoc.GetListMonHoc();

            int soThuTu = 1;
            foreach (MonHoc mon in listMonHoc)
            {
                ListViewItem lvi = new ListViewItem(soThuTu + "");
                lvi.SubItems.Add(mon.MaMonHoc);
                lvi.SubItems.Add(mon.TenMonHoc);
                soThuTu++;

                lvDanhSachMonHoc.Items.Add(lvi);
            }
        }

        /// <summary>
        /// Load toan bo hinh thuc kiem tra len tab-page hinh thuc kt
        /// </summary>
        void LoadHinhThucKiemtra()
        {
            lvHinhThucKT.Items.Clear();
            HinhThucKiemTraBLL htkt = new HinhThucKiemTraBLL();

            List<HinhThucKiemTra> listHinhThucKiemTra = new List<HinhThucKiemTra>();
            listHinhThucKiemTra = htkt.GetAllHinhThucKiemTra();

            int soTT = 1;
            foreach (HinhThucKiemTra hinhThuc in listHinhThucKiemTra)
            {
                ListViewItem lvi = new ListViewItem(soTT + "");
                lvi.SubItems.Add(hinhThuc.MaHTKT);
                lvi.SubItems.Add(hinhThuc.TenHTKT);
                lvi.SubItems.Add(hinhThuc.HeSo + "");

                lvHinhThucKT.Items.Add(lvi);
                soTT++;
            }
        }

        /// <summary>
        /// Load danh sach chuong trinh dao tao len tab-page CTDD
        /// </summary>
        void LoadChuongTrinhDaoTao()
        {
            lvCTDT.Items.Clear();
            ChuongTrinhDaoTaoBLL ctdt = new ChuongTrinhDaoTaoBLL();
            List<ChuongTrinhDaoTao> listCTDT = new List<ChuongTrinhDaoTao>();
            listCTDT = ctdt.GetAllCTDT();

            int STT = 1;
            foreach (ChuongTrinhDaoTao ct in listCTDT)
            {
                ListViewItem lvi = new ListViewItem(STT + "");
                lvi.SubItems.Add(ct.MaKhoiLop);
                lvi.SubItems.Add(ct.MaMonHoc);
                lvi.SubItems.Add(ct.HeSoMon + "");

                lvCTDT.Items.Add(lvi);
                STT++;
            }
        }

        void LoadNamHoc()
        {
            NamHocBLL namhocbll = new NamHocBLL();
            List<NamHoc> listNamHoc = new List<NamHoc>();
            listNamHoc = namhocbll.GetListNamHoc();

            List<string> listTenNH = new List<string>();
            foreach (NamHoc namhoc in listNamHoc)
            {
                listTenNH.Add(namhoc.MaNamHoc);
            }

            cbDSNH.DataSource = listTenNH;
        }

        void LoadBangDiemLenListView()
        {
            lvBDMH.Items.Clear();

            //lay ra toan bo bang diem chi tiet de up len listview
            BangDiemMonBLL bdbll = new BangDiemMonBLL();
            string malop = cbDSLop.Text;
            string[] listma = malop.Split('(');
            malop = listma[0];
            List<BangDiemDayDu> Listbdm = bdbll.GetListBangDiemMonDayDu(malop, cbDSHocKy.Text, cbDSNH.Text, cbDanhSachMonHoc.Text);


            int STT = 1;
            int indexDiemTB = listhtkt.Count+3;
            foreach (BangDiemDayDu bdm in Listbdm)
            {
                

                int indexHTKT = 2;
                for (int i = 0; i < listhtkt.Count; i++)
                {
                    if (listhtkt[i].MaHTKT == bdm.HinhThucKT)
                        indexHTKT = i + 3;
                }

                bool kiemTraTonTai = false;
                // ListViewItemCollection listlvi = lvBDMH.Items;
                if(lvBDMH.Items.Count>0)
                {

                    foreach (ListViewItem lvis in lvBDMH.Items)
                    {
                          //MessageBox.Show(lvis.SubItems[0].Text.ToString());
                       // neu ma hs giong nhau tuc la day la diem cua thang do
                            if (lvis.SubItems[1].Text == bdm.maHS)
                            {
                                kiemTraTonTai = true;
                               // MessageBox.Show(bdm.maHS + "da ton tai");
                                // lvi.SubItems.Add ( new ListViewItem.ListViewSubItem(lvi, bdm.DiemHTKT+""));
                                lvis.SubItems[indexHTKT].Text = bdm.DiemHTKT + "";
                                break;
                            }
                    }
                }
             

                //neu khong co ma nao da nam trong ds
                //thi day la lan dau tien co ten hs nay
                if (!kiemTraTonTai)
                {
                    //  MessageBox.Show(bdm.maHS + "chua ton tai");
                    ListViewItem lvi = new ListViewItem(STT + "");
                    lvi.SubItems.Add(bdm.maHS);
                    lvi.SubItems.Add(bdm.tenHS);


                    lvi.SubItems.Add("NULL");
                    lvi.SubItems.Add("NULL");
                    lvi.SubItems.Add("NULL");
                    lvi.SubItems.Add("NULL");
                    lvi.SubItems.Add("NULL");

                    lvi.SubItems[indexHTKT].Text = bdm.DiemHTKT + "";

                    //no luon co diem trung binh nen cu them vao
                    lvi.SubItems[indexDiemTB].Text = bdm.DiemTB + "";
                    lvBDMH.Items.Add(lvi);
                    STT++;
                //    MessageBox.Show(lvi.SubItems[1].ToString());
                }   




            }
        }
        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMonHoc_DanhSachMonHoc();
                
            }
            catch
            {
                MessageBox.Show("Không thể kết nối tới CSDL,vui lòng cài đặt lại kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void TaoColumnDiemListView()
        {
            HinhThucKiemTraBLL htktbll = new HinhThucKiemTraBLL();
            listhtkt= htktbll.GetAllHinhThucKiemTra();

            lvBDMH.Columns.Clear();
            ColumnHeader colSTT = new ColumnHeader() { Name = "STT_", Text = "STT", Width = 50 };
            lvBDMH.Columns.Add(colSTT);
            ColumnHeader colMA = new ColumnHeader() { Name = "Ma_", Text = "Mã HS", Width = 0 };
            lvBDMH.Columns.Add(colMA);
            ColumnHeader colTen = new ColumnHeader() { Name = "Ten_" ,Text= "Họ và tên", Width = 250 };
            lvBDMH.Columns.Add(colTen);

            foreach (HinhThucKiemTra htkt in listhtkt)
            {
                ColumnHeader col = new ColumnHeader() { Name=htkt.MaHTKT,Text=htkt.TenHTKT,Width=110};
                lvBDMH.Columns.Add(col);
            }

            ColumnHeader coll = new ColumnHeader() { Name = "DiemTB", Text ="Điểm TB" , Width = 110 };
            lvBDMH.Columns.Add(coll);
            ColumnHeader colltemp1 = new ColumnHeader() { Name = "temp1", Text = "", Width = 0 };
            lvBDMH.Columns.Add(colltemp1);
            ColumnHeader colltemp2 = new ColumnHeader() { Name = "temp2", Text = "", Width = 0 };
            lvBDMH.Columns.Add(colltemp2);
            ColumnHeader colltemp3 = new ColumnHeader() { Name = "temp3", Text = "", Width = 0 };
            lvBDMH.Columns.Add(colltemp3);
            ColumnHeader colltemp4 = new ColumnHeader() { Name = "temp4", Text = "", Width = 0 };
            lvBDMH.Columns.Add(colltemp4);
        }

        private void tcQuanLyMonHoc_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                if (e.TabPageIndex == 1)
                {
                    TaoColumnDiemListView();
                    LoadMonHoc_BangDiemMonHoc();
                    LoadLopHoc_BangDiemMonHoc();
                    LoadHocKy_BangDiemMonHoc();
                    LoadNamHoc();
                    LoadBangDiemLenListView();
                }
                else
                 if (e.TabPageIndex == 2)
                {
                    LoadHinhThucKiemtra();
                }
                else
                    LoadChuongTrinhDaoTao();
            }
            catch
            {
                MessageBox.Show("Không thể kết nối tới CSDL,vui lòng cài đặt lại kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvDanhSachMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSachMonHoc.SelectedItems.Count > 0)
            {
                ListViewItem lv = lvDanhSachMonHoc.SelectedItems[0];
                string ma = lv.SubItems[1].Text;
                string ten = lv.SubItems[2].Text;

                tbMaMH_DSMH.Text = ma;
                tbTenMH_DSMH.Text = ten;

                try
                {
                    ChuongTrinhDaoTaoBLL ctdt = new ChuongTrinhDaoTaoBLL();
                    ChuongTrinhDaoTao ct = ctdt.GetChuongTrinhDaoTao(ma);
                    tbHeSoMH_DSMH.Text = ct.HeSoMon.ToString();
                }
                catch { tbHeSoMH_DSMH.Text = ""; }

            }
        }

        private void lvHinhThucKT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHinhThucKT.SelectedItems.Count > 0)
            {
                ListViewItem lv = lvHinhThucKT.SelectedItems[0];
                string ma = lv.SubItems[1].Text;
                string ten = lv.SubItems[2].Text;
                string heso = lv.SubItems[3].Text;

                tbMaHTKT.Text = ma;
                tbTenHTKT.Text = ten;
                tbHesoHTKT.Text = heso;
            }
        }

        private void lvCTDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCTDT.SelectedItems.Count > 0)
            {
                ListViewItem lv = lvCTDT.SelectedItems[0];
                string maKhoi = lv.SubItems[1].Text;
                string MaMon = lv.SubItems[2].Text;
                string heSo = lv.SubItems[3].Text;

                tbMaKL_CTDT.Text = maKhoi;
                tbMaMH_CTDT.Text = MaMon;
                tbHeSoCTDT.Text = heSo;
            }

            KhoiLopBLL lopBll = new KhoiLopBLL();
            KhoiLop lop = lopBll.GetKhoiLop(tbMaKL_CTDT.Text);
            tbTenKhoi_CTDT.Text = lop.TenKhoiLop;


            MonHocBLL mh = new MonHocBLL();
            MonHoc mon = mh.GetMonHoc(tbMaMH_CTDT.Text);
            tbTenMH_CTDT.Text = mon.TenMonHoc;
        }

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            ThemSuaMonHoc formThemMH= new ThemSuaMonHoc();
            formThemMH.ShowDialog();
            LoadMonHoc_DanhSachMonHoc();
        }

        private void btnSuaMH_Click(object sender, EventArgs e)
        {

            if (lvDanhSachMonHoc.SelectedItems.Count > 0)
            {
                ThemSuaMonHoc formThemMH = new ThemSuaMonHoc(tbMaMH_DSMH.Text, tbTenMH_DSMH.Text);
                formThemMH.ShowDialog();
                LoadMonHoc_DanhSachMonHoc();
            }
            else
                MessageBox.Show("Bạn cần chọn 1 dòng để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            if (lvDanhSachMonHoc.SelectedItems.Count > 0)
            {
                string maMH = lvDanhSachMonHoc.SelectedItems[0].SubItems[1].Text;
                MonHocBLL monhocbll = new MonHocBLL();
                if (monhocbll.XoaMonHoc(maMH))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMonHoc_DanhSachMonHoc();
                }
                else
                    MessageBox.Show("Thất bại, môn học đang được sử giảng dạy!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
             MessageBox.Show("Bạn cần chọn 1 dòng để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnThemHTKT_Click(object sender, EventArgs e)
        {
            ThemSuaHTKT fHTKT = new ThemSuaHTKT();
            fHTKT.ShowDialog();
            LoadHinhThucKiemtra();
        }

        private void btnSuaHTKT_Click(object sender, EventArgs e)
        {

            if (lvHinhThucKT.SelectedItems.Count > 0)
            {
                ThemSuaHTKT fHTKT = new ThemSuaHTKT(tbMaHTKT.Text, tbTenHTKT.Text, tbHesoHTKT.Text);
                fHTKT.ShowDialog();
                LoadHinhThucKiemtra();
            }
            else
                MessageBox.Show("Bạn cần chọn 1 dòng để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXoaHTKT_Click(object sender, EventArgs e)
        {
            if (lvHinhThucKT.SelectedItems.Count > 0)
            {
                string maHTKT = lvHinhThucKT.SelectedItems[0].SubItems[1].Text;
                HinhThucKiemTraBLL htktbll = new HinhThucKiemTraBLL();
                if (htktbll.XoaHinhThucKiemTra(maHTKT))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHinhThucKiemtra();
                }
                else
                    MessageBox.Show("Thất bại, Hình thức kiểm tra đang sử dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Bạn cần chọn 1 dòng để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnThemCTDT_Click(object sender, EventArgs e)
        {
            ThemSuaCTDT fctdt = new ThemSuaCTDT();
            fctdt.ShowDialog();
            LoadChuongTrinhDaoTao();
        }

        private void btnSuaCTDT_Click(object sender, EventArgs e)
        {
            if (lvCTDT.SelectedItems.Count > 0)
            {
                ThemSuaCTDT fctdt = new ThemSuaCTDT(tbMaKL_CTDT.Text, tbMaMH_CTDT.Text, tbHeSoCTDT.Text);
                fctdt.ShowDialog();
                LoadChuongTrinhDaoTao();
            }
            else
                MessageBox.Show("Bạn cần chọn 1 dòng để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXoaCTDT_Click(object sender, EventArgs e)
        {
            if (lvCTDT.SelectedItems.Count > 0)
            {
                string makhoi = lvCTDT.SelectedItems[0].SubItems[1].Text;
                string mamon = lvCTDT.SelectedItems[0].SubItems[2].Text;
                ChuongTrinhDaoTaoBLL ctdt = new ChuongTrinhDaoTaoBLL();
                if (ctdt.XoaCTDT(makhoi,mamon))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMonHoc_DanhSachMonHoc();
                }
                else
                    MessageBox.Show("Thất bại, Hình thức kiểm tra đang sử dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Bạn cần chọn 1 dòng để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbDanhSachMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBangDiemLenListView();
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            ThemSuaDiem fdiem = new ThemSuaDiem();
            fdiem.ShowDialog();
            LoadBangDiemLenListView();
        }

        private void cbDSNH_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBangDiemLenListView();
        }

        private void cbDSHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBangDiemLenListView();
        }

        private void cbDSLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBangDiemLenListView();
        }

        private void btnSuaDiem_Click(object sender, EventArgs e)
        {
            ThemSuaDiem fThemSuaDiem = new ThemSuaDiem();
            fThemSuaDiem.ShowDialog();
        }

        private void tcQuanLyMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
