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
    public partial class ThemSuaKhoiLop : Form
    {
        public string maKhoiLop=null;
        public string tenKhoiLop=null;
        public string phongBan=null;
        public string maNamHoc=null;

        string TaoMaKhoiLopMoi()
        {
            KhoiLopBLL khoiLopBll = new KhoiLopBLL();
            string maKhoiLopMax = khoiLopBll.GetMaKhoiLopMax();
            string[] listTemp = maKhoiLopMax.Split('L');
            string maKhoiLop = listTemp[1];
            maKhoiLop= "KL" + (Int32.Parse(maKhoiLop) + 1).ToString();
            return maKhoiLop;
        }
        public ThemSuaKhoiLop()
        {
            InitializeComponent();
            lbTop.Text = "Thêm mới khối lớp";


            tbMaKhoiLop.Text = TaoMaKhoiLopMoi();
        }

        public ThemSuaKhoiLop(string ma,string ten,string phongban,string namhoc)
        {
            InitializeComponent();
            this.maKhoiLop = tbMaKhoiLop.Text = ma;
            this.tenKhoiLop = tbTenKhoiLop.Text = ten;
            this.phongBan = tBbPhongBan.Text = phongban;
            this.maNamHoc = cbMaNamHoc.Text = namhoc;
            lbTop.Text = "Sửa khối lớp";
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KhoiLopBLL khoiLopBll = new KhoiLopBLL();
            ErrorType result;
            //neu them moi
            string infor;
            if (this.maKhoiLop == null)
            {
                result = khoiLopBll.Themkhoilop(tbMaKhoiLop.Text, tbTenKhoiLop.Text, tBbPhongBan.Text, cbMaNamHoc.Text);
                infor = "Thêm thành công!";
            } 
            else
            {
                result = khoiLopBll.Suakhoilop(tbMaKhoiLop.Text, tbTenKhoiLop.Text, tBbPhongBan.Text, cbMaNamHoc.Text);
                infor = "Sửa thành công!";
            }
           
            if (result==ErrorType.THANH_CONG)
                {
                    MessageBox.Show(infor, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMaKhoiLop.Text = TaoMaKhoiLopMoi();
                tBbPhongBan.Text = "";
                tbTenKhoiLop.Text = "";
                }
            else
            if (result == ErrorType.KI_TU_RONG)
            {
                MessageBox.Show("Bạn nên điền đầy đủ thông tin để thực hiện", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
                {
                    MessageBox.Show("Thất bại, vui lòng xem lại chuỗi kết nối CSDL!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }

        private void ThemSuaKhoiLop_Load(object sender, EventArgs e)
        {
            btnHuyBo.IconVisible = btnLuu.IconVisible = true;
            NamHocBLL nhbll = new NamHocBLL();
            List<NamHoc> listNH = nhbll.GetListNamHoc();
            List<string> dsNH = new List<string>();
            foreach (NamHoc namhoc in listNH)
                dsNH.Add(namhoc.MaNamHoc);

            cbMaNamHoc.DataSource = dsNH;
        }
    }
}
