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
            List<string> listMaMH = new List<string>();
            //listTenMH.Add("Chọn tất cả.");
            foreach (MonHoc mon in listMonHoc)
            {
                listMaMH.Add(mon.MaMonHoc);
            }
            cbDanhSachMonHoc.DataSource = listMaMH;
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
            lvDSHS.Items.Clear();

            foreach(HocSinh hs in listHS)
            {
                ListViewItem lvi = new ListViewItem(STT + "");
                lvi.SubItems.Add(hs.MaHocSinh);
                lvi.SubItems.Add(hs.HoVaTen);
                lvi.SubItems.Add(hs.GioiTinh);
                STT++;

                lvDSHS.Items.Add(lvi);
            }
        }

        void LoadDSHTKT()
        {
            HinhThucKiemTraBLL htktbll = new HinhThucKiemTraBLL();
            List<HinhThucKiemTra> listhtkt = htktbll.GetAllHinhThucKiemTra();
            List<string> listMahtkt = new List<string>();

            foreach(HinhThucKiemTra ht in listhtkt)
            {
                listMahtkt.Add(ht.MaHTKT);
            }

            cbDSHTKT.DataSource = listMahtkt;
        }
        private void ThemSuaDiem_Load(object sender, EventArgs e)
        {
            LoadDSMonHoc();
            LoadDSLopHoc();
            LoadDSHocKy();
            LoadNamHoc();
            LoadDSHTKT();
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
                #region KiemTraRangBuocTuNhien

                if (string.IsNullOrEmpty( tbDiem.Text))
                {
                    MessageBox.Show("Bạn phải điền điểm vào ô điểm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    float diem= float.Parse(tbDiem.Text);
                    ThayDoiQuyDinhBLL quydinhbll = new ThayDoiQuyDinhBLL();
                    List<ThamSo> dsThamSo = quydinhbll.GetListThamSo();

                    float diemToiThieu=0, diemToiDa=10;
                    foreach (ThamSo ts in dsThamSo)
                    {
                       
                        if(ts.MaThamSo== "DiemToiThieu")
                        {
                            diemToiThieu = ts.GiaTri;
                        }
                        if (ts.MaThamSo == "DiemToiDa")
                        {
                            diemToiDa = ts.GiaTri;
                        }
                    }

                    if(diem<diemToiThieu||diem>diemToiDa)
                    {
                        MessageBox.Show("Điểm phải lớn hơn "+diemToiThieu+" và nhỏ hơn "+diemToiDa, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                       
                }
                catch
                {
                    MessageBox.Show("Điểm phải là dạng số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                #endregion

                QuaTrinhHocTapBLL qthocbll = new QuaTrinhHocTapBLL();
                QuaTrinhHocTap qthoctap = qthocbll.GetQuaTrinhHocTapCo(tbMaHS.Text, cbDSHocKy.Text, cbDSNH.Text);

                BangDiemMonBLL bdbll = new BangDiemMonBLL();
                BangDiemMon bdm = bdbll.GetBangDiemMon(qthoctap.MaQTH, cbDanhSachMonHoc.Text);

                if (bdm == null)
                {
                    //neu chua ton tai bd thi them bd vao 

                    string mabdm = bdbll.GetMaBDMMax();
                    mabdm =(Int32.Parse(mabdm)+1).ToString();
                   // MessageBox.Show(mabdm + "");
                    bdbll.ThemBDM(mabdm, qthoctap.MaQTH, cbDanhSachMonHoc.Text);
                    bdm = bdbll.GetBangDiemMon(qthoctap.MaQTH, cbDanhSachMonHoc.Text);
                }

                //lay ra ma ma bang diem dang can nhap
                string mabd = bdm.MaBangDiemMon;
                //lay ra chi tiet bang diem mon, neu chua co thi insert| nhieu khi da them diem truoc do nen da co
                CTBangDiemMonBLL ctbdbll = new CTBangDiemMonBLL();
                  ChiTietBangDiemMon ctbdm = ctbdbll.GetCTBangDiemMon(mabd, cbDSHTKT.Text);

                ErrorType result;
                if (ctbdm == null)
                {
                    #region Nếu chưa tồn tại bảng điểm chi tiết tức là đang insert
                    //tao ma chi tiet bang diem mon moi de insert
                    string mactbd = ctbdbll.GetMaCTBDMMax();
                    mactbd = (Int32.Parse( mactbd)+1).ToString();
                   // MessageBox.Show(mactbd);
                    result = ctbdbll.ThemCTBDM(mactbd, mabd, cbDSHTKT.Text, tbDiem.Text);
                   
                    #endregion
                }
                else
                {
                    #region Đã tồn tại tức là mình đang update.
                    result = ctbdbll.SuaCTBDM(ctbdm.MaCTBangDiemMon, mabd, cbDSHTKT.Text, tbDiem.Text);
                  //  MessageBox.Show("sua bang diem");
                    #endregion
                }

                if (result == ErrorType.THANH_CONG)
                {
                    MessageBox.Show("Thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbDiem.Text = "";
                }
                else
                {
                    MessageBox.Show("Không thể thêm", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 học sinh để vào điểm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvDSHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSHS.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvDSHS.SelectedItems[0];
                tbMaHS.Text = lvi.SubItems[1].Text;
                tbTenhS.Text = lvi.SubItems[2].Text;
            }

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
