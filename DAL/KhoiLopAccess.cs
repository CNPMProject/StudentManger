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
    public class KhoiLopAccess : DatabaseAccess
    {
        public KhoiLopAccess() : base() { }

        public List<KhoiLop> GetAllKhoilop()
        {
            OpenConnection();

            List<KhoiLop> listKhoiLop = new List<KhoiLop>();

            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from KHOILOP";
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                string maKL = reader.GetString(0);
                string tenKL = reader.GetString(1);
                string ban = reader.GetString(2);
                string manamhoc = reader.GetString(1);

                KhoiLop khoilop = new KhoiLop(maKL, tenKL, ban, manamhoc);
                listKhoiLop.Add(khoilop);
            }

            reader.Close();
            CloseConnection();
            return listKhoiLop;
        }
        public bool XoaKhoiLop(string maKL)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from KHOILOP where MaKhoiLop=@ma";
            com.Parameters.Add("@ma", SqlDbType.VarChar).Value = maKL;
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

        public bool ThemKhoiLop(string ma, string ten, string ban, string makhoilop)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "insert into KHOILOP values(@ma,@ten,@ban,@makhoilop)";
                com.Connection = conn;

                com.Parameters.Add("@ma", SqlDbType.VarChar).Value = ma;
                com.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
                com.Parameters.Add("@ban", SqlDbType.NVarChar).Value = ban;
                com.Parameters.Add("@makhoilop", SqlDbType.VarChar).Value = makhoilop;
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

        public bool SuaKhoiLop(string ma, string ten, string ban, string manamhoc)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "update  KHOILOP set TenKhoiLop=@ten and Ban=@ban and MaNamHoc=@manamhoc where  MaKhoiLop=@ma";
                com.Connection = conn;

                com.Parameters.Add("@ma", SqlDbType.VarChar).Value = ma;
                com.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
                com.Parameters.Add("@ban", SqlDbType.NVarChar).Value = ban;
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
    }
}
