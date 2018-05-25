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
            ErrorType result;
            //neu them moi
            string infor;
            if (this.maLop == null)
            {
                result = LopBll.Themlop(tbMaLop.Text, tbTenLop.Text, cbMaKhoiLop.Text,tbSiSo.Text);
                infor = "Thêm thành công!";
            }
            else
            {
                result = LopBll.SuaLop(tbMaLop.Text, tbTenLop.Text, cbMaKhoiLop.Text, tbSiSo.Text);
                infor = "Xóa thành công!";
            }

            if (result==ErrorType.THANH_CONG)
            {
                MessageBox.Show(infor, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
