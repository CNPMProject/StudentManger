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
    public class HocKyAccess : DatabaseAccess
    {

        public HocKyAccess() : base()
        { }

        public List<HocKy> GetAllHocKy()
        {
            OpenConnection();

            List<HocKy> listHocKy = new List<HocKy>();

            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from HOCKY";
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                string maHK = reader.GetString(0);
                string maNH = reader.GetString(1);

                HocKy hocky = new HocKy(maHK, maNH);
                listHocKy.Add(hocky);
            }

            reader.Close();
            CloseConnection();
            return listHocKy;
        }

        public bool XoaHocKy(string maHk)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from HOCKY where MaHocKy=@ma";
            com.Parameters.Add("@ma", SqlDbType.VarChar).Value = maHk;
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

        public bool ThemHocKy(string mahocky, string manamhoc)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "insert into HOCKY values(@mahocky,@manamhoc)";
                com.Connection = conn;

                com.Parameters.Add("@mahocky", SqlDbType.VarChar).Value = mahocky;
                com.Parameters.Add("@manamhoc", SqlDbType.NVarChar).Value = manamhoc;

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

        public bool SuaHocKy(string mahocky, string manamhoc)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "update  HOCKY set MaNamHoc=@manamhoc where  MaHocKy=@mahocky";
                com.Connection = conn;

                com.Parameters.Add("@mahocky", SqlDbType.VarChar).Value = mahocky;
                com.Parameters.Add("@manamhoc", SqlDbType.NVarChar).Value = manamhoc;

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
