using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.MainForm
{
    public partial class CSDL : Form
    {
        DatabaseBLL db;

        public CSDL()
        {
            InitializeComponent();
            db = new DatabaseBLL();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenServer.Text))
                    throw new ArgumentException("Tên sever không được trống");

                if (cboKieuXacThuc.SelectedIndex == 0)
                    db.ConnectToDatabase(txtTenServer.Text, tbdatabeseName.Text);
                else
                    db.ConnectToDatabase(txtTenServer.Text, tbdatabeseName.Text, txtTenDangNhap.Text, txtMatKhau.Text);

                db.OpenConnection();
                MessageBox.Show("Kết nối thành công!" + Environment.NewLine + "Vui lòng nhấn lưu để sử dụng cho lần sau.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnLuuThongTin.Enabled = true;
                db.CloseConection();
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại!" + Environment.NewLine + "Vui lòng thử lại một lần nữa.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            db.SaveChangeConection();
            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cboKieuXacThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenDangNhap.Enabled = txtMatKhau.Enabled = cboKieuXacThuc.SelectedIndex == 1;
        }

        private void CSDL_Load(object sender, EventArgs e)
        {
            cboKieuXacThuc.Items.AddRange(new string[]
            {
                "Xác thực của Windows",
                "Xác thực của SQL Server"
            });

            cboKieuXacThuc.SelectedIndex = 0;
        }
    }
}
