using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI.FormNhapLieu
{
    public partial class ThemSuaHocSinh : Form
    {
        string tenHocSinh = null;
        string maHocSinh = null;
        string email = null;
        string diaChi = null;
        string ngaySinh = null;
        string gioiTinh = null;

        public ThemSuaHocSinh()
        {
            InitializeComponent();
        }


        public ThemSuaHocSinh(string maHocSinh, string tenHocSinh, string ngaySinh, string gioiTinh, string email, string diaChi)
        {
            InitializeComponent();

            this.tenHocSinh = tenHocSinh;
            this.maHocSinh = maHocSinh;
            this.email = email;
            this.diaChi = diaChi;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;

            tbHoTen.Text = this.tenHocSinh;
            tbMaHS.Text = this.maHocSinh;
            tbNgaySinh.Text = this.ngaySinh;
            tbEmail.Text = this.tenHocSinh;
            tbDiaChi.Text = this.diaChi;
            cbGioiTinh.Text = this.gioiTinh;
        }

        string CreateMaHocSinhMoi()
        {
            DShocsinhBLL dshsbll = new DShocsinhBLL();
            string maHSMax = dshsbll.GetMaHSMax();
            string[] listSplit = maHSMax.Split('S');
            return listSplit[1];
        }
        private void ThemSuaHocSinh_Load(object sender, EventArgs e)
        {
            List<string> listGioiTinh = new List<string>()
            {
                "Nam",
                "Nữ"
            };
            cbGioiTinh.DataSource = listGioiTinh;

            //neu day la tem moi hoc sinh thi minh se load san tbMaHocSinh bang gia tri moi
            if (this.tenHocSinh == null)
            {
                DShocsinhBLL dshsbll = new DShocsinhBLL();
                string maHocSinhMax= dshsbll.GetMaHSMax();
                string [] listSplit = maHocSinhMax.Split('S');
                tbMaHS.Text = "HS"+(Int32.Parse(listSplit[1])+1);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            //ten hoc sinh null tuc la tao moi, nguoc lai la sua
            ErrorType result;
            DShocsinhBLL dshsbll = new DShocsinhBLL();
            if (this.tenHocSinh == null)
            {
                result = dshsbll.ThemHS(tbMaHS.Text, tbHoTen.Text, cbGioiTinh.Text, tbDiaChi.Text, tbEmail.Text, tbNgaySinh.Text);
            }
            else
            {
                result = dshsbll.SuaHS(tbMaHS.Text, tbHoTen.Text, cbGioiTinh.Text, tbDiaChi.Text, tbEmail.Text, tbNgaySinh.Text);
            }


            switch ((int)result)
            {
                case (int)ErrorType.KI_TU_RONG:
                    MessageBox.Show("Thất bại, bạn phải điền đầy đủ thông tin để thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case (int)ErrorType.THAT_BAI:
                    MessageBox.Show("Thất bại, Xin kiểm tra lại kết nối CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                default:
                    if (this.tenHocSinh == null)
                    {

                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbNgaySinh.Text = "";
                        tbHoTen.Text = "";
                        tbEmail.Text = "";
                        tbDiaChi.Text = "";

                        tbMaHS.Text ="HS"+ CreateMaHocSinhMoi();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }

        }
    }
}
