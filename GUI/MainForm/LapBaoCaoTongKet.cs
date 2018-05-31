using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using BLL;
using DTO;

namespace GUI.MainForm
{
    public partial class LapBaoCaoTongKet : Form
    {
        public LapBaoCaoTongKet()
        {
            InitializeComponent();
        }

        #region Tao Bao Cao Tong Ket hoc ky Xuong CSDL
        void TaoBaoCaoTongKetHocKy()
        {
            BaoCaoTongKetHocKyBLL baoCaoTongKetHocKy = new BaoCaoTongKetHocKyBLL();
            ErrorType result = baoCaoTongKetHocKy.TaoBaoCaoTongKetHocKy(cbHocKy_BCHK.Text, cbNamHoc_BCHK.Text);
         //   MessageBox.Show(cbNamHoc_BCHK.Text);
            if (result == ErrorType.KHONG_THE_KET_NOI)
                MessageBox.Show("Không thể tạo báo cáo, lỗi kết nối CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Trich xuat ra bao cao tong ket hoc ky
        void TrichXuatBaoCaoHocKy()
        {
            DatabaseBLL databasebll = new DatabaseBLL();
            string con = null;
            con = databasebll.GetconnectionString();

            string strConnect = "select bc.MaLop,l.SiSo, bc.SoLuongDat,bc.Tile"
                                    + " from BAOCAOTONGKETHOCKY bc, LOP l"
                                    + " where bc.MaLop = l.MaLop and MaHocKy= '"
                                    + cbHocKy_BCHK.Text + "' and MaNamHoc= '" + cbNamHoc_BCHK.Text + "'";
           // MessageBox.Show(strConnect);
            SqlDataAdapter adapter = new SqlDataAdapter(strConnect, con);
            DataSet datasetHocky = new DataSet();
            adapter.Fill(datasetHocky, "HocKy");

            this.rpBaoCaoHocKy.LocalReport.ReportEmbeddedResource = "GUI.BaoCaoTongKet.ReportHocKy.rdlc";
            ReportDataSource rpdsHocKy = new ReportDataSource();
            rpdsHocKy.Name = "BaoCaoHocKy";
            rpdsHocKy.Value = datasetHocky.Tables[0];
            rpBaoCaoHocKy.LocalReport.DataSources.Add(rpdsHocKy);
            this.rpBaoCaoHocKy.RefreshReport();
        }

        #endregion

        #region Tao Bao Cao Tong Ket mon Xuong CSDL
        void TaoBaoCaoTongKetMonHoc()
        {
            BaoCaoTongKetMonBLL baoCaoTongKetMon = new BaoCaoTongKetMonBLL();
           // MessageBox.Show(cbNamHoc_BCMH.Text);
            ErrorType result = baoCaoTongKetMon.TaoBaoCaoTongKetMon(cbHocKy_BCMH.Text, cbNamHoc_BCMH.Text,cbMonHoc_BCMH.Text);
            //   MessageBox.Show(cbNamHoc_BCHK.Text);


            if (result == ErrorType.KHONG_THE_KET_NOI)
                MessageBox.Show("Không thể tạo báo cáo, lỗi kết nối CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        #endregion

        #region Trich xuat ra bao cao tong ket mon
        void TrichXuatBaoCaoMonHoc()
        {
            DatabaseBLL databasebll = new DatabaseBLL();
            string con = null;
            con = databasebll.GetconnectionString();

            string strConnect = "select l.MaLop,l.SiSo,ct.SoLuongDatMon ,ct.TiLeDatMon "
                                + " from BAOCAOTONGKETMON bc, LOP l, CT_BCAOTONGKETMON ct "
                                + " where bc.MaBCTKM = ct.MaBCTKM and ct.MaLop = l.MaLop "
                                +" and MaHocKy = '"+cbHocKy_BCMH.Text+"' and MaNamHoc = '"+cbNamHoc_BCMH.Text+"' and bc.MaMonHoc = '"+cbMonHoc_BCMH.Text+"'";
           
            // MessageBox.Show(strConnect);
            SqlDataAdapter adapter = new SqlDataAdapter(strConnect, con);
            DataSet datasetMonHoc = new DataSet();
            adapter.Fill(datasetMonHoc, "MonHoc");

            this.rpBaoCaoMon.LocalReport.ReportEmbeddedResource = "GUI.BaoCaoTongKet.ReportMonHoc.rdlc";
            ReportDataSource rpdsMonHoc = new ReportDataSource();
            rpdsMonHoc.Name = "BaoCaoMonHoc";
            rpdsMonHoc.Value = datasetMonHoc.Tables[0];
            rpBaoCaoMon.LocalReport.DataSources.Add(rpdsMonHoc);

            this.rpBaoCaoMon.RefreshReport();
        }

        #endregion

        private void LapBaoCaoTongKet_Load(object sender, EventArgs e)
        {
            #region Load tabpage dau tien
            LoadDanhSachHocKy(0);
            LoadDanhSachNamHoc(0);
            LoadDanhSachMonHoc();
            #endregion

        }

        /// <summary>
        /// Load danh sach nam hoc len combobox theo tabpage
        /// </summary>
        void LoadDanhSachNamHoc(int index)
        {
            NamHocBLL namhocbll = new NamHocBLL();
            List<NamHoc> DanhSachNamHoc = namhocbll.GetListNamHoc();
            List<string> listMaNamHoc = new List<string>();

            foreach(NamHoc namhoc in DanhSachNamHoc)
            {
                listMaNamHoc.Add(namhoc.MaNamHoc);
            }

            if(index==1)
            cbNamHoc_BCHK.DataSource = listMaNamHoc;
            else
            {
                cbNamHoc_BCMH.DataSource = listMaNamHoc;
            }
        }

        /// <summary>
        /// Load danh sach hoc ky len combobox theo tabpage
        /// </summary>
        void LoadDanhSachHocKy(int index)
        {
            HocKyBLL hockybll = new HocKyBLL();
            List<HocKy> DanhSachHocKy = hockybll.GetListHocKy();

            List<string> DanhSachMaHocKy = new List<string>();

            foreach(HocKy hocky in DanhSachHocKy)
            {
                DanhSachMaHocKy.Add(hocky.MaHocKy);
            }

            if (index == 1)
                cbHocKy_BCHK.DataSource = DanhSachMaHocKy;
            else
                cbHocKy_BCMH.DataSource = DanhSachMaHocKy;
        }

        /// <summary>
        /// Load danh sach mon hoc lem combobox bao cao mon hoc
        /// </summary>
        void LoadDanhSachMonHoc()
        {
            MonHocBLL monhocbll = new MonHocBLL();
            List<MonHoc> DanhSachMonHoc = monhocbll.GetListMonHoc();
            List<string> DanhSachMaMonHoc = new List<string>();

            foreach(MonHoc monhoc in DanhSachMonHoc)
            {
                DanhSachMaMonHoc.Add(monhoc.MaMonHoc);
            }

            cbMonHoc_BCMH.DataSource = DanhSachMaMonHoc;
        }

        private void tbbaocaomon_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1)
            {
                LoadDanhSachHocKy(1);
                LoadDanhSachNamHoc(1);
            }
            else
            {
                LoadDanhSachHocKy(0);
                LoadDanhSachNamHoc(0);
                LoadDanhSachMonHoc();
            }
        }

        private void btnTaoBaoCaoHocKy_Click(object sender, EventArgs e)
        {
            TaoBaoCaoTongKetHocKy();
            TrichXuatBaoCaoHocKy();
        }

        private void btnXemBaoCaoMon_Click(object sender, EventArgs e)
        {
            TaoBaoCaoTongKetMonHoc();
            TrichXuatBaoCaoMonHoc();
        }
    }
}
