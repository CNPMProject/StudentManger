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
    public partial class ThemSuaHTKT : Form
    {
        string ten=null;
        string ma=null;
        string heso=null;

        public ThemSuaHTKT()
        {
            InitializeComponent();
        }

        public ThemSuaHTKT(string ma,string ten, string heso)
        {
            InitializeComponent();
            this.ten =tbTenHTKT.Text= ten;
            this.heso =tbHeSo.Text= heso;
            this.ma=tbMa.Text= ma;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            #region KiemTraRangBuoc
            try
            {
                int heso = Int32.Parse(tbHeSo.Text);
                if (heso < 1)
                {
                    MessageBox.Show("Hệ số phải là số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    
            }
            catch
            {
                MessageBox.Show("Hệ số phải là số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion
            HinhThucKiemTraBLL htktbll = new HinhThucKiemTraBLL();
            ErrorType result;
            //them
            if (this.ten == null)
                result = htktbll.ThemHinhThucKiemTra(tbMa.Text, tbTenHTKT.Text, tbHeSo.Text);
            else //sua
                result = htktbll.SuaHinhThucKiemTra(tbMa.Text, tbTenHTKT.Text, tbHeSo.Text);

            switch ((int)result)
            {
                case (int)ErrorType.KI_TU_RONG:
                    MessageBox.Show("Thất bại, bạn phải điền đầy đủ thông tin để thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case (int)ErrorType.DA_TON_TAI:
                    MessageBox.Show("Không thể thêm, hình thức kiểm tra này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case (int)ErrorType.THAT_BAI:
                    MessageBox.Show("Thất bại, Xin kiểm tra lại kết nối CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                default:
                    string infor;
                    if (this.ten == null)
                        infor = "Thêm thành công!";
                    else
                        infor = "Sửa thành công !";
                    MessageBox.Show(infor, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbHeSo.Text = "";
                    tbMa.Text = "";
                    tbTenHTKT.Text = "";
                    break;
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
