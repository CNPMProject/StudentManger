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
    public partial class ThemSuaLop : Form
    {
        string maLop = null;
        //string tenLop = null;
        //string maKhoiLop = null;
        //string siSo = null;

        public ThemSuaLop()
        {
            InitializeComponent();
            lbTop.Text = "Thêm lớp mới";

            LopBLL lopBll = new LopBLL();
            string maLopMax = lopBll.GetMaLopMax();
            string[] listtemp = maLopMax.Split('L');
            string maLop = listtemp[0];

            tbMaLop.Text = maLop;
        }

        public ThemSuaLop(string maLop/*,string tenLop,string maKhoiLop,string siSo*/)
        {
            InitializeComponent();
            lbTop.Text = "Sửa lớp";
           this.maLop = tbMaLop.Text = maLop;
            //this.tenLop = tbTenLop.Text = tenLop;
            //this.maKhoiLop = cbMaKhoiLop.Text = maKhoiLop;
            //this.siSo = tbSiSo.Text = siSo;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {


            LopBLL LopBll = new LopBLL();
            KhoiLopBLL klbll = new KhoiLopBLL();
            ErrorType result;
            //neu them moi
            string infor;
            string maKhoiLop = klbll.GetMaKhoiLop(cbTenKhoiLop.Text);
            if (this.maLop == null)
            {
                result = LopBll.Themlop(tbMaLop.Text, tbTenLop.Text, maKhoiLop, tbSiSo.Text);
                infor = "Thêm thành công!";
            }
            else
            {
                result = LopBll.SuaLop(tbMaLop.Text, tbTenLop.Text, maKhoiLop, tbSiSo.Text);
                infor = "Xóa thành công!";
            }

            if (result==ErrorType.THANH_CONG)
            {
                MessageBox.Show(infor, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMaLop.Text = TaoMaLopMoi();
                tbTenLop.Text = "";
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

        string TaoMaLopMoi()
        {
            LopBLL lopbll = new LopBLL();
            string malop = lopbll.GetMaLopMax();
            string[] list = malop.Split('L');
            malop = "L" + (Int32.Parse(list[1]) + 1);
            return malop;
        }

        private void ThemSuaLop_Load(object sender, EventArgs e)
        {
            KhoiLopBLL khoilopBll = new KhoiLopBLL();
            List<KhoiLop> listKhoiLop = khoilopBll.GetListKhoiLop();
            List<string> ListTenKl = new List<string>();
            foreach (KhoiLop kl in listKhoiLop)
                ListTenKl.Add(kl.TenKhoiLop);

            cbTenKhoiLop.DataSource = ListTenKl;

            tbMaLop.Text= TaoMaLopMoi();
        }
    }
}
