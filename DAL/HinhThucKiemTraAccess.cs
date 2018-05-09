using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class HinhThucKiemTraAccess : DatabaseAccess
    {
        public HinhThucKiemTraAccess() : base()
        { }

        public List<HinhThucKiemTra> GetAllHinhThucKiemTra()
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from HinhThucKiemTra";
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            List<HinhThucKiemTra> listHinhThucKiemTra = new List<HinhThucKiemTra>();

            while (reader.Read())
            {
                string ma = reader.GetString(0);
                String ten = reader.GetString(1);
                int heSo = reader.GetInt32(2);

                HinhThucKiemTra hinhThuc = new HinhThucKiemTra(ma, ten, heSo);
                listHinhThucKiemTra.Add(hinhThuc);
            }

            reader.Close();
            CloseConnection();
            return listHinhThucKiemTra;

        }

        public bool ThemHTKT(string ma, string ten, int heso)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "insert into  HinhThucKiemTra values(@ma,@ten,@heso)";
                com.Connection = conn;

                com.Parameters.Add("@ma", SqlDbType.VarChar).Value = ma;
                com.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
                com.Parameters.Add("@heso", SqlDbType.Int).Value = heso;

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

        public bool SuaHTKT(string ma, string ten, int heso)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "update  HinhThucKiemTra set TenHTKT=@ten,HeSo=@heso  where MaHTKT=@ma";
                com.Connection = conn;

                com.Parameters.Add("@ma", SqlDbType.VarChar).Value = ma;
                com.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
                com.Parameters.Add("@heso", SqlDbType.NVarChar).Value = heso;

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

        public bool XoaHTKT(string ma)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "delete from  HinhThucKiemTra where MaHTKT=@ma";
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
