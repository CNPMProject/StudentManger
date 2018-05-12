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

            List<string> listTenNH = new List<string>();
            foreach (NamHoc namhoc in listNamHoc)
            {
                listTenNH.Add(namhoc.MaNamHoc);
            }

            cbNH_DSKL.DataSource = listTenNH;
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

        void LoadDanhSachHocSinh(string maNamHoc)
        {

        }

        private void cbNH_DSHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachHocSinh(cbNH_DSHS.Text);
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
    }
}
