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
    public partial class ThemSuaCTDT : Form
    {
        string makhoilop = null;
        string mamonhoc = null;
        string heso=null;

        public ThemSuaCTDT()
        {
            InitializeComponent();
        }

        public ThemSuaCTDT(string makhoilop,string mamonhoc,string heso)
        {
            InitializeComponent();
            this.makhoilop = makhoilop;
            this.mamonhoc = mamonhoc;
            this.heso = heso;

            cbMaKL.Text = this.makhoilop;
            cbMaMH.Text = this.mamonhoc;
            tbHeso.Text = this.heso;
            cbMaKL.Enabled = cbMaMH.Enabled = false;
        }

        private void ThemSuaCTDT_Load(object sender, EventArgs e)
        {
            KhoiLopBLL KLbll = new KhoiLopBLL();
            List<KhoiLop> listKL = new List<KhoiLop>();
            listKL = KLbll.GetListKhoiLop();
            List<string> listStrKL = new List<string>();
            foreach(KhoiLop kl in listKL)
            {
                listStrKL.Add(kl.MaKhoiLop);
            }
            cbMaKL.DataSource = listStrKL;


            MonHocBLL MHbll = new MonHocBLL();
            List<MonHoc> listMH = new List<MonHoc>();
            listMH = MHbll.GetListMonHoc();
            List<string> listStrMH = new List<string>();
            foreach (MonHoc mh in listMH)
            {
                listStrMH.Add(mh.MaMonHoc);
            }

            cbMaMH.DataSource = listStrMH;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            try
            {
                int hs=Int32.Parse(tbHeso.Text);
                if(hs<1)
                MessageBox.Show("Hệ số phải là số nguyên dương", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Hệ số phải là số nguyên dương", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChuongTrinhDaoTaoBLL ctdtbll = new ChuongTrinhDaoTaoBLL();
            ErrorType result;
            //them
            if (this.makhoilop == null)
                result = ctdtbll.ThemCTDT(cbMaKL.Text, cbMaMH.Text,tbHeso.Text);
            else //sua
                result = ctdtbll.SuaCTDT(cbMaKL.Text, cbMaMH.Text, tbHeso.Text);

            switch ((int)result)
            {
                case (int)ErrorType.KI_TU_RONG:
                    MessageBox.Show("Thất bại, bạn phải điền đầy đủ thông tin để thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case (int)ErrorType.DA_TON_TAI:
                    MessageBox.Show("Không thể thêm, chương trình đào tạo này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case (int)ErrorType.THAT_BAI:
                    MessageBox.Show("Thất bại, Xin kiểm tra lại kết nối CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                default:
                    string infor;
                    if (this.makhoilop == null)
                        infor = "Thêm thành công!";
                    else
                        infor = "Sửa thành công !";
                    MessageBox.Show(infor, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbHeso.Text = "";                   
                    break;
            }

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
