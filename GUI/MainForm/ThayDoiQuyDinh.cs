
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

        void LoadThamSoLenListView()
        {
            lvDSthamso.Items.Clear();
            List<ThamSo> listThamSo = quydinh.GetListThamSo();
            int soThuTu = 1;

            foreach (ThamSo thamso in listThamSo)
            {
                ListViewItem lvi = new ListViewItem(soThuTu + "");
                lvi.SubItems.Add(thamso.TenThamSo);
                lvi.SubItems.Add(thamso.GiaTri.ToString());
                soThuTu++;

                lvDSthamso.Items.Add(lvi);
            }
        }

        // load cac tham so va gia tri
        void LoadThamSo_DanhSachThamSo()
        {
            LoadThamSoLenListView();          

            nricdiemdathk.Value =decimal.Parse( lvDSthamso.Items[0].SubItems[2].Text);
            nricdiemdatmon.Value = decimal.Parse(lvDSthamso.Items[1].SubItems[2].Text);
            nricdiemtoida.Value = decimal.Parse(lvDSthamso.Items[2].SubItems[2].Text);
            nricdiemtoithieu.Value = decimal.Parse(lvDSthamso.Items[3].SubItems[2].Text);
            nricsiso.Value = Int32.Parse(lvDSthamso.Items[4].SubItems[2].Text);
            nrictoitoida.Value = Int32.Parse(lvDSthamso.Items[5].SubItems[2].Text);
            nricTuoitoithieu.Value = Int32.Parse(lvDSthamso.Items[6].SubItems[2].Text);
        }

        

        private void btApDung_Click(object sender, System.EventArgs e)
        {
            //try
            //{
                ErrorType result=ErrorType.THANH_CONG;
                if (nricTuoitoithieu.Value != Int32.Parse(lvDSthamso.Items[0].SubItems[2].Text))
                    result=quydinh.SuaThamSo("TuoiToiThieu", nricTuoitoithieu.Value);
                else
                if (nrictoitoida.Value != Int32.Parse(lvDSthamso.Items[1].SubItems[2].Text))
                    result = quydinh.SuaThamSo("TuoiToiDa", nrictoitoida.Value);
                else
                if (nricsiso.Value != Int32.Parse(lvDSthamso.Items[2].SubItems[2].Text))
                    result = quydinh.SuaThamSo("SiSoToiDa", nricsiso.Value);
                else
                if (nricdiemtoithieu.Value != Int32.Parse(lvDSthamso.Items[3].SubItems[2].Text))
                    result = quydinh.SuaThamSo("DiemToiThieu", nricdiemtoithieu.Value);
                else
                if (nricdiemtoida.Value != Int32.Parse(lvDSthamso.Items[4].SubItems[2].Text))
                    result = quydinh.SuaThamSo("DiemToiDa", nricdiemtoida.Value);
                else
                if (nricdiemdatmon.Value != Int32.Parse(lvDSthamso.Items[5].SubItems[2].Text))
                    result = quydinh.SuaThamSo("DiemDatMon", nricdiemdatmon.Value);
                else
                if (nricdiemdathk.Value != Int32.Parse(lvDSthamso.Items[6].SubItems[2].Text))
                    result = quydinh.SuaThamSo("DiemDatHocKy", nricdiemdathk.Value);

                if (result == ErrorType.THANH_CONG)
                {
                    MessageBox.Show(" Thay đổi quy định thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThamSoLenListView();
                }
                else
                if(result==ErrorType.VI_PHAM_RANG_BUOC_TU_NHIEN)
                {
                    MessageBox.Show(" Thất bại, Xin kiểm tra ràng buộc tự nhiên (giá trị phải lớn hơn 0, giá trị tối thiểu không lớn hơn giá trị tối đa,...)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             //   else
                  //  MessageBox.Show(" Thất bại, Xin kiểm tra lại kết nối!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
            //catch
            //{
            //    MessageBox.Show(" Thất bại, Xin kiểm tra lại kết nối!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            
        }



        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            LoadThamSo_DanhSachThamSo();
        }
    }
}
