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
    public partial class ThemSuaMonHoc : Form
    {
        string tenMH=null;
        string maMH=null;

        //cai nay danh cho them du lieu
        public ThemSuaMonHoc()
        {
            InitializeComponent();
        }

        //cai nay danh de sua MH
        public ThemSuaMonHoc(string maMH,string tenMH)
        {
            InitializeComponent();
            this.maMH = maMH;
            this.tenMH = tenMH;

            tbMaMH_DSMH.Text = this.maMH;
            tbTenMH_DSMH.Text = this.tenMH;
            tbMaMH_DSMH.Enabled = false;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MonHocBLL monhocbll = new MonHocBLL();
            ErrorType result;
            //them
            if (this.tenMH == null)
              result=   monhocbll.ThemMonHoc(tbMaMH_DSMH.Text, tbTenMH_DSMH.Text);
            else //sua
              result = monhocbll.SuaMonHoc(tbMaMH_DSMH.Text, tbTenMH_DSMH.Text);

            switch ((int)result)
            {
                case (int)ErrorType.KI_TU_RONG:
                    MessageBox.Show("Thất bại, bạn phải điền đầy đủ thông tin để thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case (int)ErrorType.DA_TON_TAI:
                    MessageBox.Show("Không thể thêm, Môn học này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case (int)ErrorType.THAT_BAI:
                    MessageBox.Show("Thất bại, Xin kiểm tra lại kết nối CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                default:
                    string infor;
                    if (this.tenMH == null)
                        infor = "Thêm thành công!";
                    else
                        infor = "Sửa thành công !";
                    MessageBox.Show(infor, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbMaMH_DSMH.Text = "";
                    tbTenMH_DSMH.Text = "";
                    break;
            }
        }
    }
}
