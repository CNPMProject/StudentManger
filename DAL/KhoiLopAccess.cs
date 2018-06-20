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
                string manamhoc = reader.GetString(3);

                KhoiLop khoilop = new KhoiLop(maKL, tenKL, ban, manamhoc);
                listKhoiLop.Add(khoilop);
            }

            reader.Close();
            CloseConnection();
            return listKhoiLop;
        }

        public List<KhoiLop> GetAllKhoilop(string namHoc)
        {
            OpenConnection();

            List<KhoiLop> listKhoiLop = new List<KhoiLop>();

            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from KHOILOP where MaNamHoc=@namhoc";
            com.Parameters.Add("@namhoc", SqlDbType.VarChar).Value = namHoc;
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                string maKL = reader.GetString(0);
                string tenKL = reader.GetString(1);
                string ban = reader.GetString(2);
                string manamhoc = reader.GetString(3);

                KhoiLop khoilop = new KhoiLop(maKL, tenKL, ban, manamhoc);
                listKhoiLop.Add(khoilop);
            }

            reader.Close();
            CloseConnection();
            return listKhoiLop;
        }

        public KhoiLop GetKhoiLop(string maKhoiLop)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from KhoiLOP where MAkhoilop=@ma";
            com.Parameters.Add("@ma", SqlDbType.VarChar).Value = maKhoiLop;
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            KhoiLop lop = null;
            while (reader.Read())
            {
                string ma = reader.GetString(0);
                String ten = reader.GetString(1);
                string ban = reader.GetString(2);
                string manamhoc = reader.GetString(3);

                lop = new KhoiLop(ma, ten, ban, manamhoc);
            }

            reader.Close();
            CloseConnection();
            return lop;
        }

        public string GetMaKhoiLop(string tenkl)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            string value = ("N'" + tenkl + "'");
            com.CommandText = "Select MaKhoiLop from KhoiLOP where tenkhoilop="+value;
            
           // com.Parameters.Add("@tenkl", SqlDbType.VarChar).Value =value ;
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            string  malop = null;
            while (reader.Read())
            {
                malop = reader.GetString(0);
            }

            reader.Close();
            CloseConnection();
            return malop;
        }

        public KhoiLop GetKhoiLopTheoNH(string namhoc)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from KhoiLOP where MaNamHoc=@ma";
            com.Parameters.Add("@ma", SqlDbType.VarChar).Value = namhoc;
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            KhoiLop lop = null;
            while (reader.Read())
            {
                string ma = reader.GetString(0);
                String ten = reader.GetString(1);
                string ban = reader.GetString(2);
                string manamhoc = reader.GetString(3);

                lop = new KhoiLop(ma, ten, ban, manamhoc);
            }

            reader.Close();
            CloseConnection();
            return lop;
        }

        public string GetMaKhoiLopMax()
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = " select top 1 MaKhoiLop "
                                +"from KHOILOP group by MaKhoiLop"
                                +" order by MaKhoiLop DESC";
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                return reader.GetString(0);
            }

            reader.Close();
            CloseConnection();
            return null;
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
                com.CommandText = "update  KHOILOP set TenKhoiLop=@ten , Ban=@ban , MaNamHoc=@manamhoc where  MaKhoiLop=@ma";
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
