using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Windows.Forms;

namespace BLL
{
    public class DShocsinhBLL : DatabaseBLL
    {
        DShocsinhAccess danhsachhocsinh = new DShocsinhAccess();
        public DShocsinhBLL() : base() { }
        public List<HocSinh> GetAllHocSinh()
        {
            
            return danhsachhocsinh.GetAllDShocsinh();
        }

        public HocSinh GetHocSinh(string maHocSinh)
        {
            return danhsachhocsinh.GetHocSinh(maHocSinh);
        }

        public string GetMaHSMax()
        {
            return danhsachhocsinh.GetMaHocSinhMax();
        }

        public List<ThongTinChungHS_DiemTB> GetDanhSachHocSinh_ThongTinChung_Diem(string maNamHoc)
        {
            return danhsachhocsinh.GetDanhSachHocSinh_ThongTinChung_Diem(maNamHoc);
        }

        public List<ThongTinChungHS_DiemTB> GetDanhSachHocSinh_ThongTinChung_TimKiemTheoTen(string tenHocSinh)
        {
            return danhsachhocsinh.GetDanhSachHocSinh_ThongTinChung_TimKiemTheoTen(tenHocSinh);
        }

        public List<ThongTinChungHS_DiemTB> GetDanhSachHocSinh_ThongTinChung_TimKiemTheoLop(string lop)
        {
            return danhsachhocsinh.GetDanhSachHocSinh_ThongTinChung_TimKiemTheoLop(lop);
        }

        public List<HocSinh> GetDSHocSinhTheoLop(string malop)
        {
            return danhsachhocsinh.GetDSHocSinhTheoLop(malop);
        }

        public List<HocSinh> GetDSHocSinhChuaXepLop()
        {
            return danhsachhocsinh.GetDSHocSinhChuaXepLop();
        }

        public List<HocSinh> GetDSHocSinh(string namHoc, string hocKy, string maLop)
        {
            return danhsachhocsinh.GetDSHocSinh(namHoc, hocKy, maLop);
        }

        public ErrorType ThemHS
            (string ma, string ten, string gioitinh, string diachi, string email,DateTime namsinh)
        {
            #region Kiem tra rong
            if (string.IsNullOrEmpty(ma) 
                || string.IsNullOrEmpty(ten) 
                || string.IsNullOrEmpty(gioitinh)
                || string.IsNullOrEmpty(diachi) 
                || string.IsNullOrEmpty(email) 
                || string.IsNullOrEmpty(namsinh.ToShortDateString())) 
                return ErrorType.KI_TU_RONG;
            #endregion

            #region Kiem tra quy dinh
            ThayDoiQuyDinhBLL quydinhbll = new ThayDoiQuyDinhBLL();
            List<ThamSo> listThamSo = quydinhbll.GetListThamSo();

            decimal tuoiToiDa = 0;
            decimal tuoiToiThieu = 0;
            foreach (ThamSo ts in listThamSo)
            {
                //tuoi toi thieu
                if (ts.MaThamSo == "TuoiToiDa")
                    tuoiToiDa =(decimal) ts.GiaTri;
                if (ts.MaThamSo == "TuoiToiThieu")
                    tuoiToiThieu =(decimal) ts.GiaTri;
            }
            TimeSpan tuoiHienTai = DateTime.Now - namsinh;
            decimal tuoi = tuoiHienTai.Days / 365;
          //  MessageBox.Show(tuoi + "");
            if (tuoi > tuoiToiDa || tuoi < tuoiToiThieu)
                return ErrorType.VUOT_MIEN_GIA_TRI;
            #endregion


            DShocsinhAccess ac = new DShocsinhAccess();
            return ac.ThemHs(ma, ten, gioitinh, diachi, email,namsinh.ToShortDateString());
        }

        public ErrorType SuaHS(
            string ma, string ten, string gioitinh, string diachi, string email,DateTime namsinh)
        {
            if (string.IsNullOrEmpty(ma) 
                || string.IsNullOrEmpty(ten) 
                || string.IsNullOrEmpty(gioitinh) 
                || string.IsNullOrEmpty(diachi)
                || string.IsNullOrEmpty(email) 
                || string.IsNullOrEmpty(namsinh.ToShortDateString()))
                return ErrorType.KI_TU_RONG;

            ThayDoiQuyDinhBLL quydinhbll = new ThayDoiQuyDinhBLL();
            List<ThamSo> listThamSo = quydinhbll.GetListThamSo();

            decimal tuoiToiDa = 0;
            decimal tuoiToiThieu = 0;
            foreach (ThamSo ts in listThamSo)
            {
                //tuoi toi thieu
                if (ts.MaThamSo == "TuoiToiDa")
                    tuoiToiDa =(decimal) ts.GiaTri;
                if (ts.MaThamSo == "TuoiToiThieu")
                    tuoiToiThieu =(decimal)ts.GiaTri;
            }
            TimeSpan tuoiHienTai = DateTime.Now - namsinh;
            int tuoi = tuoiHienTai.Days / 365;
            if (tuoi> tuoiToiDa || tuoi < tuoiToiThieu)
                return ErrorType.VUOT_MIEN_GIA_TRI;

            DShocsinhAccess ac = new DShocsinhAccess();
            return ac.SuaHs(ma, ten, gioitinh, diachi, email,namsinh.ToShortDateString());
        }

        public bool XoaHs(string ma)
        {
            DShocsinhAccess ac = new DShocsinhAccess();
            return ac.XoaHS(ma);
        }
    }
}
