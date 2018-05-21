using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class CTBangDiemMonAccess : DatabaseAccess
    {

        public CTBangDiemMonAccess() : base() { }

        public List<ChiTietBangDiemMon> GetAllBangDiemMon()
        {
            OpenConnection();

            List<ChiTietBangDiemMon> listCTBD = new List<ChiTietBangDiemMon>();

            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from CT_BangDiemMon";
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                string maCTBD = reader.GetString(0);
                string maBD = reader.GetString(1);
                string maHTKT = reader.GetString(2);
                float diemTB = float.Parse(reader.GetDouble(3).ToString());

                ChiTietBangDiemMon bd = new ChiTietBangDiemMon(maCTBD, maBD, maHTKT, diemTB);
                listCTBD.Add(bd);
            }

            reader.Close();
            CloseConnection();
            return listCTBD;
        }

        public ChiTietBangDiemMon GetCTBangDiemMon(string maBD, string maHTKT)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from CT_BangDiemMon where MaBangDiemMon=@maBD and maHTKT=@maHTKT";
            com.Parameters.Add("@maBD", SqlDbType.VarChar).Value = maBD;
            com.Parameters.Add("@maHTKT", SqlDbType.VarChar).Value = maHTKT;
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            ChiTietBangDiemMon bd = null;
            while (reader.Read())
            {
                string maCTBD = reader.GetString(0);
                string maBDM = reader.GetString(1);
                string mahtkt = reader.GetString(2);
                float diemTB = float.Parse( reader.GetDouble(3).ToString());

                bd = new ChiTietBangDiemMon(maCTBD, maBDM, mahtkt, diemTB);
            }

            reader.Close();
            CloseConnection();
            return bd;
        }

        public bool XoaBD(string maCTBD)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from CT_BangDiemMon where MaCTBangDiemMon=@ma";
            com.Parameters.Add("@ma", SqlDbType.VarChar).Value = maCTBD;
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

        public ErrorType ThemCTBD(string maCTBD, string maBD, string maHTKT,float diem)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "insert into CT_BangDiemMon values(@maCTBD,@maBD,@maHTKT,@diem)";
                com.Connection = conn;

                com.Parameters.Add("@maCTBD", SqlDbType.VarChar).Value = maCTBD;
                com.Parameters.Add("@maBD", SqlDbType.NVarChar).Value = maBD;
                com.Parameters.Add("@maHTKT", SqlDbType.NVarChar).Value = maHTKT;
                com.Parameters.Add("@diem", SqlDbType.Float).Value = diem;

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

        public ErrorType SuaBD(string maCTBD, string maBD, string maHTKT, float diem)
        {
            //try
            //{
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "update  CT_BangDiemMon set Mabangdiemmon=@maBD,mahtkt=@maHTKT,diem=@diem where maCTbangDiemMon=@maCTBD";
                com.Connection = conn;

                com.Parameters.Add("@maCTBD", SqlDbType.VarChar).Value = maCTBD;
                com.Parameters.Add("@maBD", SqlDbType.NVarChar).Value = maBD;
                com.Parameters.Add("@maHTKT", SqlDbType.NVarChar).Value = maHTKT;
                com.Parameters.Add("@diem", SqlDbType.Float).Value = diem;

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

        public string GetCTMaBDMMax()
        {
            OpenConnection();


            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = " select top 1 MaCTBangDiemMon from CT_BANGDIEMMON order by MaCTBangDiemMon DESC";
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            string maBD = null;

            if (reader.Read())
            {
                maBD = reader.GetString(0);
            }

            reader.Close();
            CloseConnection();
            return maBD;
        }
    }
}
