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
    }
}
