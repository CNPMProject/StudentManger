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
    public class NamHocAccess : DatabaseAccess
    {
        public NamHocAccess() : base()
        { }

        public List<NamHoc> GetAllNamHoc()
        {
            OpenConnection();

            List<NamHoc> listNamHoc = new List<NamHoc>();

            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from NAMHOC";
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                string manh = reader.GetString(0);
                int nam1 = reader.GetInt32(1);
                int nam2 = reader.GetInt32(2);

                NamHoc namhoc = new NamHoc(manh, nam1, nam2);
                listNamHoc.Add(namhoc);
            }

            reader.Close();
            CloseConnection();
            return listNamHoc;
        }

        public bool XoaNamHoc(string maNH)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from NAMHOC where MaNamHoc=@ma";
            com.Parameters.Add("@ma", SqlDbType.VarChar).Value = maNH;
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

        public bool ThemNamHoc(string ma, int nam1, int nam2)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "insert into NAMHOC values(@ma,@nam1,@nam2)";
                com.Connection = conn;

                com.Parameters.Add("@ma", SqlDbType.VarChar).Value = ma;
                com.Parameters.Add("@nam1", SqlDbType.Int).Value = nam1;
                com.Parameters.Add("@nam2", SqlDbType.Int).Value = nam2;

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

        public bool SuaNamHoc(string ma, int nam1, int nam2)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "update  NAMHOC set Nam1=@nam1 and Nam2=@nam2 where  MaNamHoc=@ma";
                com.Connection = conn;

                com.Parameters.Add("@ma", SqlDbType.VarChar).Value = ma;
                com.Parameters.Add("@nam1", SqlDbType.Int).Value = nam1;
                com.Parameters.Add("@nam2", SqlDbType.Int).Value = nam2;

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
