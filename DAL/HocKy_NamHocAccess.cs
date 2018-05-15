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
   public  class HocKy_NamHocAccess:DatabaseAccess
    {
        public HocKy_NamHocAccess() : base()
        { }
        public List<HocKy_NamHoc> GetAllHocKy_NamHoc()
        {
            OpenConnection();

            List<HocKy_NamHoc> listHocKy_NamHoc = new List<HocKy_NamHoc>();

            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from HOCKY_NAMHOC";
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                string maHK = reader.GetString(0);
                string maNH = reader.GetString(1);

                HocKy_NamHoc Hocky_namhoc = new HocKy_NamHoc(maHK, maNH);
                listHocKy_NamHoc.Add(Hocky_namhoc);
                
               
            }

            reader.Close();
            CloseConnection();
            return listHocKy_NamHoc;
        }

        public bool XoaHocKy_NamHoc(string maHk,string maNamHoc)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from HOCKY_NAMHOC where MaHocKy=@ma and MaNamHoc=@manam";
            com.Parameters.Add("@ma", SqlDbType.VarChar).Value = maHk;
            com.Parameters.Add("@manam", SqlDbType.VarChar).Value = maNamHoc;

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

        public bool ThemHocKy_NamHoc(string mahocky, string manamhoc)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "insert into HOCKY_NAMHOC values(@mahocky,@manamhoc)";
                com.Connection = conn;

                com.Parameters.Add("@mahocky", SqlDbType.VarChar).Value = mahocky;
                com.Parameters.Add("@manamhoc", SqlDbType.VarChar).Value = manamhoc;

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

        public bool SuaHocKy_Namhoc(string mahocky, string manamhoc)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "update  HOCKY_NAMHOC set MaHocKy=@mahocky,MaNamHoc=@manamhoc  where  MaHocKy=@mahocky and MaNamHoc=@manamhoc";
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
