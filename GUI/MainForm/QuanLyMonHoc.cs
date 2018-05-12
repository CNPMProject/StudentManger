using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.MainForm
{
    public partial class QuanLyMonHoc : Form
    {
        MonHocBLL monhoc;

        public QuanLyMonHoc()
        {
            InitializeComponent();
            monhoc = new MonHocBLL();
        }

        /// <summary>
        /// load source cac mon hoc len combobox tab-page bang diem mon hic
        /// </summary>
        void LoadMonHoc_BangDiemMonHoc()
        {

            List<MonHoc> listMonHoc = monhoc.GetListMonHoc();

            //load source cac mon hoc len combobox tab-page bang diem mon hic
            List<string> listTenMH = new List<string>();
            listTenMH.Add("Chọn tất cả.");
            foreach (MonHoc mon in listMonHoc)
            {
                listTenMH.Add(mon.TenMonHoc);
            }
            cbDanhSachMonHoc.DataSource = listTenMH;
        }

        void LoadLopHoc_BangDiemMonHoc()
        {
            LopBLL lopbll = new LopBLL();
            List<Lop> listLop = lopbll.GetListLop();
            List<string> nameClass = new List<string>();
            nameClass.Add("Chọn tất cả.");

            
            foreach (Lop lop in listLop)
            {
                nameClass.Add(lop.TenLop);
            }

            cbDSLop.DataSource = nameClass;
        }

        void LoadHocKy_BangDiemMonHoc()
        {
            HocKyBLL lopbll = new HocKyBLL();
            List<HocKy> listLop = lopbll.GetListHocKy();
            List<string> nameHocKy = new List<string>();
            nameHocKy.Add("Chọn tất cả.");


            foreach (HocKy hocKy in listLop)
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

        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMonHoc_DanhSachMonHoc();
                LoadLopHoc_BangDiemMonHoc();
                LoadHocKy_BangDiemMonHoc();
            }
            catch
            {
                MessageBox.Show("Không thể kết nối tới CSDL,vui lòng cài đặt lại kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tcQuanLyMonHoc_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                if (e.TabPageIndex == 1)
                {
                    LoadMonHoc_BangDiemMonHoc();
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
    }
}
