using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ChuongTrinhDaoTaoAccess : DatabaseAccess
    {
        public ChuongTrinhDaoTaoAccess() : base()
        { }

        public List<ChuongTrinhDaoTao> GetAllCTDT()
        {
            OpenConnection();
            List<ChuongTrinhDaoTao> listCTDT = new List<ChuongTrinhDaoTao>();

            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from ChuongTrinhDaoTao";
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                string maLop = reader.GetString(0);
                string maMon = reader.GetString(1);
                int heSo = reader.GetInt32(2);

                ChuongTrinhDaoTao ctdt = new ChuongTrinhDaoTao(maLop, maMon, heSo);
                listCTDT.Add(ctdt);
            }

            reader.Close();
            CloseConnection();
            return listCTDT;
        }

        public bool XoaCTDT(string maKhoi, string maMon)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from ChuongTrinhDaoTao where MaKhoiLop=@makhoi and MaMonHoc=@mamon";
            com.Parameters.Add("@makhoi", SqlDbType.VarChar).Value = maKhoi;
            com.Parameters.Add("@mamon", SqlDbType.VarChar).Value = maMon;
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

        public bool ThemCTDT(string maKhoi, string maMon, int heSo)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "insert into ChuongTrinhDaoTao values(@makhoi,@mamon,@heso)";
                com.Connection = conn;

                com.Parameters.Add("@makhoi", SqlDbType.VarChar).Value = maKhoi;
                com.Parameters.Add("@mamon", SqlDbType.NVarChar).Value = maMon;
                com.Parameters.Add("@heso", SqlDbType.Int).Value = heSo;

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

        public bool SuaCTDT(string maKhoi, string maMon, int heSo)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "update  ChuongTrinhDaoTao set HeSoMon=@heso where  MaMonHoc=@mamon and MakhoiLop=@makhoi";
                com.Connection = conn;

                com.Parameters.Add("@mamon", SqlDbType.VarChar).Value = maMon;
                com.Parameters.Add("@makhoi", SqlDbType.NVarChar).Value = maKhoi;
                com.Parameters.Add("@heso", SqlDbType.Int).Value = heSo;

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
