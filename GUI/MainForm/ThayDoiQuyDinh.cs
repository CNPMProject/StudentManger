
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;



namespace QLHS.FormChinh
{
    public partial class ThayDoiQuyDinh : Form
    {
        ThayDoiQuyDinhBLL quydinh;
        public ThayDoiQuyDinh()
        {
            InitializeComponent();
            quydinh = new ThayDoiQuyDinhBLL();
        }

        // load cac tham so va gia tri
        void LoadThamSo_DanhSachThamSo()
        {

            lvDSthamso.Items.Clear();
            List<ThamSo> listThamSo = quydinh.GetListThamSo();

            int soThuTu = 1;

            foreach (ThamSo thamso in listThamSo)
            {
                ListViewItem lvi = new ListViewItem(soThuTu + "");
                lvi.SubItems.Add(thamso.TenThamSo);
                //thamso.GiaTri = decimal.Parse(lvi.SubItems[soThuTu++].Text);
                soThuTu++;

                lvDSthamso.Items.Add(lvi);
            }
        }

        private void QuiDinh_Load(object sender, System.EventArgs e)
        {

            LoadThamSo_DanhSachThamSo();
        }


        private void btApDung_Click(object sender, System.EventArgs e)
        {
            if (nricTuoitoithieu.Value != 0)
                quydinh.SuaThamSo("thamso1", nricTuoitoithieu.Value);
            if (nrictoitoida.Value != 0)
                quydinh.SuaThamSo("thamso2", nrictoitoida.Value);
            if (nricsiso.Value != 0)
                quydinh.SuaThamSo("thamso3", nricsiso.Value);
            if (nricdiemtoithieu.Value != 0)
                quydinh.SuaThamSo("thamso4", nricdiemtoithieu.Value);
            if (nricdiemtoida.Value != 0)
                quydinh.SuaThamSo("thamso5", nricdiemtoida.Value);
            if (nricdiemdatmon.Value != 0)
                quydinh.SuaThamSo("thamso6", nricdiemdatmon.Value);
            if (nricdiemdathk.Value != 0)
                quydinh.SuaThamSo("thamso7", nricdiemdathk.Value);
            MessageBox.Show(" Thay đổi quy định thành công");
        }



        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
