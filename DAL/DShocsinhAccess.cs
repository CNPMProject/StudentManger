using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAL
{
    public class DShocsinhAccess : DatabaseAccess
    {

        public DShocsinhAccess() : base()
        { }

        public List<HocSinh> GetAllDShocsinh()
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from HOCSINH";
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            List<HocSinh> listdshocsinh = new List<HocSinh>();

            while (reader.Read())
            {
                string ma = reader.GetInt32(0)+"";
                String ten = reader.GetString(1);
                string gioitinh = reader.GetString(2);
                string namsinh = reader.GetDateTime(3).ToString();
                string diachi = reader.GetString(4);
                string email = reader.GetString(5);
                string trangThai = reader.GetString(6);


                HocSinh dshocsinh = new HocSinh(ma, ten, gioitinh, diachi, email,namsinh,trangThai);
                listdshocsinh.Add(dshocsinh);
            }

            reader.Close();
            CloseConnection();
            return listdshocsinh;
        }

        public List<ThongTinChungHS_DiemTB> GetDanhSachHocSinh_ThongTinChung_Diem(string maNamHoc)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select hs.MaHocSinh,hs.HoVaTen,qth.MaLop,qth.MaHocKy,qth.DiemTBHk "
                            +"from HOCSINH hs,QUATRINHHOCTAP qth "
                            +"where hs.MaHocSinh = qth.MaHocSinh and maNamHoc=@maNamHoc and hs.TrangThai='HD'";
            
            com.Parameters.Add("@maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            List<ThongTinChungHS_DiemTB> listdshocsinh = new List<ThongTinChungHS_DiemTB>();

            while (reader.Read())
            {
                string maHocSinh = reader.GetInt32(0)+"";
                String tenHocSinh = reader.GetString(1);
                string maLop = reader.GetString(2);
                string maHocKy = reader.GetString(3);
                string diemTrungBinh = null;
                try
                {
                    diemTrungBinh = reader.GetDouble(4).ToString();
                }
                catch { }


                ThongTinChungHS_DiemTB dshocsinh = new ThongTinChungHS_DiemTB(
                    maHocSinh, tenHocSinh, maLop, maHocKy, diemTrungBinh);
                listdshocsinh.Add(dshocsinh);
            }

            reader.Close();
            CloseConnection();
            return listdshocsinh;

        }

        public List<ThongTinChungHS_DiemTB> GetDanhSachHocSinh_ThongTinChung_TimKiemTheoTen(string tenHS)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select hs.MaHocSinh,hs.HoVaTen,qth.MaLop,qth.MaHocKy,qth.DiemTBHk "
                            + "from HOCSINH hs,QUATRINHHOCTAP qth "
                            + "where hs.MaHocSinh = qth.MaHocSinh and  hs.hovaten like N'%"+ tenHS + "%'";

           // com.Parameters.Add("@ten", SqlDbType.VarChar).Value = tenHocSinh;
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            List<ThongTinChungHS_DiemTB> listdshocsinh = new List<ThongTinChungHS_DiemTB>();

            while (reader.Read())
            {
                string maHocSinh = reader.GetInt32(0)+"";
                String tenHocSinh = reader.GetString(1);
                string maLop = reader.GetString(2);
                string maHocKy = reader.GetString(3);
                string diemTrungBinh = null;
                try
                {
                    diemTrungBinh = reader.GetDouble(4).ToString();
                }
                catch { }


                ThongTinChungHS_DiemTB dshocsinh = new ThongTinChungHS_DiemTB(
                    maHocSinh, tenHocSinh, maLop, maHocKy, diemTrungBinh);
                listdshocsinh.Add(dshocsinh);
            }

            reader.Close();
            CloseConnection();
            return listdshocsinh;

        }

        public List<ThongTinChungHS_DiemTB> GetDanhSachHocSinh_ThongTinChung_TimKiemTheoLop(string lop)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select hs.MaHocSinh,hs.HoVaTen,qth.MaLop,qth.MaHocKy,qth.DiemTBHk "
                               +" from HOCSINH hs,QUATRINHHOCTAP qth, LOP l "
                               +"where hs.MaHocSinh = qth.MaHocSinh  and qth.MaLop = l.MaLop and l.TenLop like N'%"+lop+"%'";

            // com.Parameters.Add("@ten", SqlDbType.VarChar).Value = tenHocSinh;
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            List<ThongTinChungHS_DiemTB> listdshocsinh = new List<ThongTinChungHS_DiemTB>();

            while (reader.Read())
            {
                string maHocSinh = reader.GetInt32(0).ToString();
                String tenHocSinh = reader.GetString(1);
                string maLop = reader.GetString(2);
                string maHocKy = reader.GetString(3);
                string diemTrungBinh = null;
                try
                {
                    diemTrungBinh = reader.GetDouble(4).ToString();
                }
                catch { }


                ThongTinChungHS_DiemTB dshocsinh = new ThongTinChungHS_DiemTB(
                    maHocSinh, tenHocSinh, maLop, maHocKy, diemTrungBinh);
                listdshocsinh.Add(dshocsinh);
            }

            reader.Close();
            CloseConnection();
            return listdshocsinh;

        }

        public HocSinh GetHocSinh(string mahocsinh)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from HOCSINH where mahocsinh=@ma";
            com.Parameters.Add("@ma", SqlDbType.Int).Value = Int32.Parse( mahocsinh);
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            List<HocSinh> listdshocsinh = new List<HocSinh>();
            HocSinh dshocsinh = null;

            if (reader.Read())
            {
                string ma = reader.GetInt32(0)+"";
                String ten = reader.GetString(1);
                string gioitinh = reader.GetString(2);
                string namsinh = reader.GetDateTime(3).ToString();
                string diachi = reader.GetString(4);
                string email = reader.GetString(5);
                string trangThai = reader.GetString(6);


                dshocsinh = new HocSinh(ma, ten, gioitinh, diachi, email, namsinh,trangThai);
                listdshocsinh.Add(dshocsinh);
            }

            reader.Close();
            CloseConnection();

            return dshocsinh;
        }

        public string GetMaHocSinhMax()
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select top 1 MaHocSinh from HOCSINH order by MaHocSinh DESC";     
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();

            string maHS = null;

            if (reader.Read())
            {
                 maHS = reader.GetInt32(0).ToString();               
            }

            reader.Close();
            CloseConnection();

            return maHS;
        }

        public List<HocSinh> GetDSHocSinhChuaXepLop()
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = " select * from HOCSINH "
                               +"where MaHocSinh not in (select MaHocSinh from QUATRINHHOCTAP)";
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            List<HocSinh> listdshocsinh = new List<HocSinh>();
            string namsinh = null;

            while (reader.Read())
            {
                string ma = reader.GetInt32(0).ToString();
                String ten = reader.GetString(1);
                string gioitinh = reader.GetString(2);
                namsinh = reader.GetDateTime(3).ToString();
                string diachi = reader.GetString(4);
                string email = reader.GetString(5);
                string trangThai = reader.GetString(6);


                HocSinh dshocsinh = new HocSinh(ma, ten, gioitinh, diachi, email, namsinh, trangThai);
                listdshocsinh.Add(dshocsinh);
            }

            reader.Close();
            CloseConnection();
            return listdshocsinh;
        }

        public List<HocSinh> GetDSHocSinhTheoLop(string maLop)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from hocsinh,QUATRINHHOCTAP where HOCSINH.MaHocSinh=QUATRINHHOCTAP.MaHocSinh and malop=@ma";
            com.Parameters.Add("@ma", SqlDbType.VarChar).Value = maLop;
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            List<HocSinh> listdshocsinh = new List<HocSinh>();
            string namsinh = null;

            while (reader.Read())
            {
                string ma = reader.GetInt32(0).ToString();
                String ten = reader.GetString(1);
                string gioitinh = reader.GetString(2);
                namsinh = reader.GetDateTime(3).ToString();
                string diachi = reader.GetString(4);
                string email = reader.GetString(5);
                string trangThai = reader.GetString(6);


                HocSinh dshocsinh = new HocSinh(ma, ten, gioitinh, diachi, email,namsinh,trangThai);
                listdshocsinh.Add(dshocsinh);
            }

            reader.Close();
            CloseConnection();
            return listdshocsinh;
        }

        public List<HocSinh> GetDSHocSinh(string namHoc,string hocKy,string maLop)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            string textQuery = "select * from HOCSINH, QUATRINHHOCTAP "
                                +"where HOCSINH.MaHocSinh = QUATRINHHOCTAP.MaHocSinh"
                                + " and QUATRINHHOCTAP.MaNamHoc = @maNH and QUATRINHHOCTAP.MaHocKy = @maHK"
                                + " and QUATRINHHOCTAP.MaLop = @maLop";
            com.CommandText = textQuery;

            com.Parameters.Add("@maNH", SqlDbType.VarChar).Value = namHoc;
            com.Parameters.Add("@maHK", SqlDbType.VarChar).Value = hocKy;
            com.Parameters.Add("@maLop", SqlDbType.VarChar).Value = maLop;
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            List<HocSinh> listdshocsinh = new List<HocSinh>();
            string namsinh = null;

            while (reader.Read())
            {
                string ma = reader.GetInt32(0).ToString();
                String ten = reader.GetString(1);
                string gioitinh = reader.GetString(2);
                namsinh = reader.GetDateTime(3).ToString();
                string diachi = reader.GetString(4);
                string email = reader.GetString(5);
                string trangThai = reader.GetString(6);


                HocSinh dshocsinh = new HocSinh(ma, ten, gioitinh, diachi, email, namsinh, trangThai);
                listdshocsinh.Add(dshocsinh);
            }

            reader.Close();
            CloseConnection();
            return listdshocsinh;
        }

        public bool XoaHS(string mahocsinh)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "update  HOCSINH set TrangThai='KHD'  where MaHocSinh=@mahocsinh";
            com.Parameters.Add("@mahocsinh", SqlDbType.Int).Value =Int32.Parse( mahocsinh);
            com.Connection = conn;

            try
            {
                int check = com.ExecuteNonQuery();
                if (check > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }

        }
        public ErrorType ThemHs(
            string mahocsinh, string hoten, string gioitinh, string diachi, string email,string namsinh)
        {
            try
            {

                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "insert into HOCSINH values(@mahocsinh,@hoten,@gioitinh,@namsinh,@diachi,@email,'HD')";
                com.Connection = conn;

                com.Parameters.Add("@mahocsinh", SqlDbType.Int).Value = Int32.Parse( mahocsinh);
                com.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = hoten;
                com.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = gioitinh;
                com.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
                com.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                com.Parameters.Add("@namsinh", SqlDbType.SmallDateTime).Value = namsinh;
                int result = com.ExecuteNonQuery();

                CloseConnection();
                if (result > 0)
                    return ErrorType.THANH_CONG;
                return ErrorType.THAT_BAI;
        }
            catch
            {
                return ErrorType.THAT_BAI;
            }
}

        public ErrorType SuaHs(
            string mahocsinh, string hoten, string gioitinh,
            string diachi, string email,string namsinh)
        {

            //try
            //{
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "update  HOCSINH set HoVaTen=@hoten , GioiTinh=@gioitinh ,  DiaChi=@diachi , Email=@email , ngaysinh=@namsinh where  MaHocSinh=@mahocsinh";
                com.Connection = conn;

                com.Parameters.Add("@mahocsinh", SqlDbType.Int).Value = Int32.Parse( mahocsinh);
                com.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = hoten;
                com.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = gioitinh;
                com.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
                com.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                com.Parameters.Add("@namsinh", SqlDbType.SmallDateTime).Value = namsinh;
                int result = com.ExecuteNonQuery();

                CloseConnection();
                if (result > 0)
                    return ErrorType.THANH_CONG;
                return ErrorType.THAT_BAI;

            //}
            //catch
            //{
            //    return ErrorType.THAT_BAI;
            //}
        }
    }
}

