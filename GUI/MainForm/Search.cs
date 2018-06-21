using BLL;
using DTO;
using GUI.FormNhapLieu;
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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            List<string> DanhSachTuyChonTimKiem = new List<string>()
            {
                "Tìm theo tên",
                "Tìm theo lớp",
                "Tìm theo điểm TB"
            };

            cbTieuChiTimKiem.DataSource = DanhSachTuyChonTimKiem;
            LoadColumnHocKyLenListView();

            btnSuaHS.IconVisible = true;
        }

        /// <summary>
        /// Load header cac column len listview, vi day la danh sach hoc ki dong
        /// </summary>
        void LoadColumnHocKyLenListView()
        {
            HocKyBLL hockybll = new HocKyBLL();
            List<HocKy> listHocKy = hockybll.GetListHocKy();

            foreach (HocKy hocky in listHocKy)
            {
                ColumnHeader header = new ColumnHeader()
                {
                    Name = hocky.MaHocKy,
                    Text = "Điểm TB " + hocky.MaHocKy,
                    Width = 110
                };
                lvdshs.Columns.Add(header);
            }


            ColumnHeader colltemp1 = new ColumnHeader() { Name = "temp1", Text = "", Width = 0,TextAlign=HorizontalAlignment.Center };
            lvdshs.Columns.Add(colltemp1);
            ColumnHeader colltemp2 = new ColumnHeader() { Name = "temp2", Text = "", Width = 0 ,TextAlign = HorizontalAlignment.Center };
            lvdshs.Columns.Add(colltemp2);
            ColumnHeader colltemp3 = new ColumnHeader() { Name = "temp3", Text = "", Width = 0 , TextAlign = HorizontalAlignment.Center };
            lvdshs.Columns.Add(colltemp3);
            ColumnHeader colltemp4 = new ColumnHeader() { Name = "temp4", Text = "", Width = 0 , TextAlign = HorizontalAlignment.Center };
            lvdshs.Columns.Add(colltemp4);
        }

        /// <summary>
        /// Load thong tin chung cua hoc sinh bao gom ca diem len listview DSHS
        /// </summary>
        void LoadDSHS_DSHS()
        {
            DShocsinhBLL hocSinhbll = new DShocsinhBLL();
            List<ThongTinChungHS_DiemTB> listThongTinChungHocSinh;
            if (cbTieuChiTimKiem.SelectedIndex == 0)
            {
                listThongTinChungHocSinh = hocSinhbll.GetDanhSachHocSinh_ThongTinChung_TimKiemTheoTen(tbTuKhoaTimKiem.Text);
            }
            else
             if (cbTieuChiTimKiem.SelectedIndex == 2)
            {
                try
                {
                    string[] listdiem = tbTuKhoaTimKiem.Text.Split(' ');
                    float canTren = float.Parse(listdiem[1]);
                    float canDuoi = float.Parse(listdiem[0]);
                    listThongTinChungHocSinh = hocSinhbll.GetDanhSachHocSinh_ThongTinChung_TimKiemTheoDiemTB(canDuoi, canTren);
                }
                catch
                {
                    MessageBox.Show("Không đúng định dạng tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
               
            }
            else
           //  if (cbTieuChiTimKiem.SelectedIndex == 1)
            {
                listThongTinChungHocSinh = hocSinhbll.GetDanhSachHocSinh_ThongTinChung_TimKiemTheoLop(tbTuKhoaTimKiem.Text);
            }

            lvdshs.Items.Clear();
            int soThuTu = 1;
            HocKyBLL hockybll = new HocKyBLL();
            List<HocKy> listhocky = hockybll.GetListHocKy();
            
            foreach (ThongTinChungHS_DiemTB hocsinh in listThongTinChungHocSinh)
            {

                int indexHocKy = 0;
                for (int i = 0; i < listhocky.Count; i++)
                {
                    if (listhocky[i].MaHocKy == hocsinh.maHocKy)
                        indexHocKy = i + 4;
                }

                bool kiemTraTonTai = false;
                if (lvdshs.Items.Count > 0)
                {
                    foreach (ListViewItem lvitem in lvdshs.Items)
                    {
                        if (lvitem.SubItems[1].Text == hocsinh.maHocSinh)
                        {
                            kiemTraTonTai = true;
                            lvitem.SubItems[indexHocKy].Text = hocsinh.diemTB;
                            break;
                        }
                    }
                }

                if (!kiemTraTonTai)
                {
                    ListViewItem lvi = new ListViewItem(soThuTu + "");
                    lvi.SubItems.Add(hocsinh.maHocSinh);
                    lvi.SubItems.Add(hocsinh.TenHocSinh);
                    lvi.SubItems.Add(hocsinh.Lop);
                    lvi.SubItems.Add("-"); // diem tb hoc ki 1
                    lvi.SubItems.Add("-"); // dim trung binh hk 2
                    lvi.SubItems.Add("-"); // dim trung binh hk 3
                    lvi.SubItems.Add("-"); // dim trung binh hk 4


                    lvi.SubItems[indexHocKy].Text = hocsinh.diemTB;

                    lvdshs.Items.Add(lvi);
                    soThuTu++;
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {        
            LoadDSHS_DSHS();
        }

        private void lvdshs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvdshs.SelectedItems.Count > 0)
            {
                DShocsinhBLL hocsinhbll = new DShocsinhBLL();
                string maHocSinh = lvdshs.SelectedItems[0].SubItems[1].Text;
                HocSinh hocsinh = hocsinhbll.GetHocSinh(maHocSinh);

                tbMaHocSinh.Text = hocsinh.MaHocSinh;
                tbHoVaTen.Text = hocsinh.HoVaTen;
                tbGioiTinh.Text = hocsinh.GioiTinh;
                tbDiaChi.Text = hocsinh.DiaChi;
                tbEmail.Text = hocsinh.Email;
                tbNgaySinh.Text = hocsinh.NamSinh;

                QuaTrinhHocTapBLL quaTrinhHocbll = new QuaTrinhHocTapBLL();
                List<QuaTrinhHocTap> listQuaTrinhHoc = quaTrinhHocbll.GetQuaTrinhHocTapCoMaHS(hocsinh.MaHocSinh);
                tbLop.Text = listQuaTrinhHoc[0].MaLop;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Visible=false;
        }

        private void btnSuaHS_Click(object sender, EventArgs e)
        {
            if (lvdshs.SelectedItems.Count > 0)
            {
                ThemSuaHocSinh fThemSua = new ThemSuaHocSinh
                (tbMaHocSinh.Text, tbHoVaTen.Text,
                tbNgaySinh.Text,tbGioiTinh.Text,
                tbEmail.Text, tbDiaChi.Text);
                fThemSua.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 học sinh để sửa !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbTieuChiTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTieuChiTimKiem.SelectedIndex==2)
            lbHuongDan.Visible = true;
            else
                lbHuongDan.Visible = false;
        }
    }
}
