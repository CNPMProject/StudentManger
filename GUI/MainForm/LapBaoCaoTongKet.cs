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

        private void LapBaoCaoTongKet_Load(object sender, EventArgs e)
        {
            DatabaseBLL databasebll = new DatabaseBLL();
            string con = null;
            con = databasebll.GetconnectionString();


            SqlDataAdapter adapter = new SqlDataAdapter("select bc.MaLop,l.SiSo, bc.SoLuongDat,bc.Tile"
                                    +" from BAOCAOTONGKETHOCKY bc, LOP l"
                                    +" where bc.MaLop = l.MaLop", con);
            DataSet datasetHocky = new DataSet();
            adapter.Fill(datasetHocky, "HocKy");

            this.rpBaoCaoHocKy.LocalReport.ReportEmbeddedResource = "GUI.BaoCaoTongKet.ReportHocKy.rdlc";
            ReportDataSource rpdsHocKy = new ReportDataSource();
            rpdsHocKy.Name = "BaoCaoHocKy";
            rpdsHocKy.Value = datasetHocky.Tables[0];
            rpBaoCaoHocKy.LocalReport.DataSources.Add(rpdsHocKy);
            this.rpBaoCaoMon.RefreshReport(); 
            this.rpBaoCaoHocKy.RefreshReport();
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

            }
        }
    }
}
