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
                string ma = reader.GetString(0);
                String ten = reader.GetString(1);
                string gioitinh = reader.GetString(2);
                string diachi = reader.GetString(3);
                string email = reader.GetString(4);
                string namsinh = reader.GetDateTime(5).ToString();

                HocSinh dshocsinh = new HocSinh(ma, ten, gioitinh, diachi, email,namsinh);
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
            com.Parameters.Add("@ma", SqlDbType.VarChar).Value = mahocsinh;
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            List<HocSinh> listdshocsinh = new List<HocSinh>();
            HocSinh dshocsinh = null;

            if (reader.Read())
            {
                string ma = reader.GetString(0);
                String ten = reader.GetString(1);
                string gioitinh = reader.GetString(2);
                string namsinh = reader.GetDateTime(3).ToString();
                string diachi = reader.GetString(4);
                string email = reader.GetString(5);

               

                dshocsinh = new HocSinh(ma, ten, gioitinh, diachi, email, namsinh);
                listdshocsinh.Add(dshocsinh);
            }

            reader.Close();
            CloseConnection();

            return dshocsinh;
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
                string ma = reader.GetString(0);
                String ten = reader.GetString(1);
                string gioitinh = reader.GetString(2);
                namsinh = reader.GetDateTime(3).ToString();
                string diachi = reader.GetString(5);
                string email = reader.GetString(5);
               

                HocSinh dshocsinh = new HocSinh(ma, ten, gioitinh, diachi, email,namsinh);
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
                string ma = reader.GetString(0);
                String ten = reader.GetString(1);
                string gioitinh = reader.GetString(2);
                namsinh = reader.GetDateTime(3).ToString();
                string diachi = reader.GetString(4);
                string email = reader.GetString(5);

                HocSinh dshocsinh = new HocSinh(ma, ten, gioitinh, diachi, email, namsinh);
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
            com.CommandText = "delete from HOCSINH where MaHocSinh=@mahocsinh";
            com.Parameters.Add("@mahocsinh", SqlDbType.VarChar).Value = mahocsinh;
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
        public bool ThemHs(string mahocsinh, string hoten, string gioitinh, string diachi, string email,string namsinh)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "insert into HOCSINH values(@mahocsinh,@hoten,@gioitinh,@diachi,@email,@namsinh)";
                com.Connection = conn;

                com.Parameters.Add("@mahocsinh", SqlDbType.VarChar).Value = mahocsinh;
                com.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = hoten;
                com.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = gioitinh;
                com.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
                com.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                com.Parameters.Add("@namsinh", SqlDbType.SmallDateTime).Value = namsinh;
                int result = com.ExecuteNonQuery();

                CloseConnection();
                if (result > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaHs(string mahocsinh, string hoten, string gioitinh, string diachi, string email,string namsinh)
        {

            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "update  HOCSINH set HoVaTen=@hoten and GioiTinh=@gioitinh and  DiaChi=@diachi and Email=@email and namsinh=@namsinh where  MaHocSinh=@mahocsinh";
                com.Connection = conn;

                com.Parameters.Add("@mahocsinh", SqlDbType.VarChar).Value = mahocsinh;
                com.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = hoten;
                com.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = gioitinh;
                com.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
                com.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                com.Parameters.Add("@namsinh", SqlDbType.SmallDateTime).Value = namsinh;
                int result = com.ExecuteNonQuery();

                CloseConnection();
                if (result > 0)
                    return true;
                return false;

            }
            catch
            {
                return false;
            }
        }
    }
}

