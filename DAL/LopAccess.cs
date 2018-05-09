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
    public class LopAccess : DatabaseAccess
    {

        public LopAccess() : base() { }
        public List<Lop> GetAllLop()
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from LOP";
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            List<Lop> ListLop = new List<Lop>();

            while (reader.Read())
            {
                string ma = reader.GetString(0);
                String ten = reader.GetString(1);
                string makhoi = reader.GetString(2);
                int siso = reader.GetInt32(2);

                Lop dsLop = new Lop(ma, ten, makhoi, siso);
                ListLop.Add(dsLop);
            }

            reader.Close();
            CloseConnection();
            return ListLop;

        }
        public bool ThemLop(string malop, string tenlop, string makhoi, int siso)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "insert into  LOP values (@malop,@tenlop,@makhoi,@siso)";
                com.Connection = conn;

                com.Parameters.Add("@malop", SqlDbType.VarChar).Value = malop;
                com.Parameters.Add("@tenlop", SqlDbType.NVarChar).Value = tenlop;
                com.Parameters.Add("@makhoi", SqlDbType.VarChar).Value = makhoi;
                com.Parameters.Add("@siso", SqlDbType.Int).Value = siso;

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


        public bool SuaLop(string ma, string ten, string makhoi, int siso)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "update  LOP set TenLop=@ten and MaKhoiLop=@makhoi and SiSo=@siso  where MaLop=@ma";
                com.Connection = conn;

                com.Parameters.Add("@ma", SqlDbType.VarChar).Value = ma;
                com.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
                com.Parameters.Add("@makhoi", SqlDbType.NVarChar).Value = makhoi;
                com.Parameters.Add("@siso", SqlDbType.Int).Value = siso;

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

        public bool XoaLop(string ma)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "delete from  LOP where MaLop=@ma";
                com.Connection = conn;

                com.Parameters.Add("@ma", SqlDbType.VarChar).Value = ma;

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

