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

namespace GUI.FormNhapLieu
{
    public partial class ThemSuaDiem : Form
    {
        MonHocBLL monhocbll = new MonHocBLL();
        LopBLL lopbll = new LopBLL();
        HocKyBLL hockybll = new HocKyBLL();
        DShocsinhBLL hocsinhbll = new DShocsinhBLL();

        public ThemSuaDiem()
        {
            InitializeComponent();
        }

        void LoadDSMonHoc()
        {

            List<MonHoc> listMonHoc = monhocbll.GetListMonHoc();

            //load source cac mon hoc len combobox tab-page bang diem mon hic
            List<string> listTenMH = new List<string>();
            //listTenMH.Add("Chọn tất cả.");
            foreach (MonHoc mon in listMonHoc)
            {
                listTenMH.Add(mon.TenMonHoc);
            }
            cbDanhSachMonHoc.DataSource = listTenMH;
        }

        void LoadDSLopHoc()
        {

            List<Lop> listLop = lopbll.GetListLop();
            List<string> nameClass = new List<string>();
            //nameClass.Add("Chọn tất cả.");


            foreach (Lop lop in listLop)
            {
                nameClass.Add(lop.MaLop+"("+ lop.TenLop +")");
            }

            cbMaLop.DataSource = nameClass;
        }

        void LoadDSHocKy()
        {

            List<HocKy> listHocKy = hockybll.GetListHocKy();
            List<string> nameHocKy = new List<string>();
           // nameHocKy.Add("Chọn tất cả.");


            foreach (HocKy hocKy in listHocKy)
            {
                nameHocKy.Add(hocKy.MaHocKy);
            }

            cbDSHocKy.DataSource = nameHocKy;
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

        void LoadDSHSLenListview()
        {
            List<HocSinh> listHS = new List<HocSinh>();
            string malop = cbMaLop.Text;
            string []listma = malop.Split('(');
            malop = listma[0];
            listHS = hocsinhbll.GetDSHocSinh(cbDSNH.Text, cbDSHocKy.Text, malop);
            //MessageBox.Show(malop);

            int STT = 1;
            lvDSHS.Clear();

            foreach(HocSinh hs in listHS)
            {
                ListViewItem lvi = new ListViewItem(STT + "");
                lvi.SubItems.Add(hs.MaHocSinh);
                lvi.SubItems.Add(hs.HoVaTen);
                STT++;

                lvDSHS.Items.Add(lvi);
            }
        }
        private void ThemSuaDiem_Load(object sender, EventArgs e)
        {
            LoadDSMonHoc();
            LoadDSLopHoc();
            LoadDSHocKy();
            LoadNamHoc();
            LoadDSHSLenListview();
        }

        private void cbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDSHSLenListview();
        }

        private void cbDSHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDSHSLenListview();
        }

        private void cbDSNH_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDSHSLenListview();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(lvDSHS.SelectedItems.Count>0)
            {
                QuaTrinhHocTapBLL qthocbll = new QuaTrinhHocTapBLL();
                QuaTrinhHocTap qthoctap = qthocbll.GetQuaTrinhHocTapCo(tbMaHS.Text, cbDSHocKy.Text, cbDSNH.Text);

                BangDiemMonBLL bdbll = new BangDiemMonBLL();
                BangDiemMon bdm = bdbll.GetBangDiemMon(qthoctap.MaQTH, cbDanhSachMonHoc.Text);
                if (bdm == null)
                {
                    ////neu chua ton tai bd thi them bd vao
                    //string mabdm = bdbll.GetMaBDMMax();
                    //string[] list = mabdm.Split('D');
                    //mabdm = "BD"+(Int32.Parse( list[1])+1).ToString();
                    //bdbll.ThemBDM(mabdm,)
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 học sinh để vào điểm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
