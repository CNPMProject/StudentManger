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
    public class BaoCaoTongKetMonAccess : DatabaseAccess
    {
        public BaoCaoTongKetMonAccess() : base()
        { }

        public List<BaoCaoTongKetMon> GetAllBaoCaoTongKetMon()
        {
            OpenConnection();

            List<BaoCaoTongKetMon> listBaoCaoTongKetMon = new List<BaoCaoTongKetMon>();

            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from BaoCaoTongKetMon";
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                string MaBCTKM = reader.GetInt32(0)+"";
                string MaMonHoc = reader.GetString(1);
                string MaHocKy = reader.GetString(2);
                string MaNamHoc = reader.GetString(3);


                BaoCaoTongKetMon baoCaoTongKetMon = new BaoCaoTongKetMon(MaBCTKM, MaMonHoc, MaHocKy,MaNamHoc);
                listBaoCaoTongKetMon.Add(baoCaoTongKetMon);
            }

            reader.Close();
            CloseConnection();
            return listBaoCaoTongKetMon;
        }

        public bool XoaBaoCaoTongKetMon(string MaBCTKM)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from BaoCaoTongKetMon where MaBaoCaoTongKetMon=@MaBCTKM";
            com.Parameters.Add("@MaBCTKM", SqlDbType.Int).Value =Int32.Parse( MaBCTKM);
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

        public bool ThemBaoCaoTongKetMon(string MaBCTKM, string MaMonHoc, string MaHocKy,string MaNamHoc)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "insert into BaoCaoTongKetMon values(@MaBCTKM, @MaMonHoc, @MaHocKy,@manamhoc)";
                com.Connection = conn;

                com.Parameters.Add("@MaBCTKM", SqlDbType.Int).Value =Int32.Parse( MaBCTKM);
                com.Parameters.Add("@MaMonHoc", SqlDbType.VarChar).Value = MaMonHoc;
                com.Parameters.Add("@MaHocKy", SqlDbType.VarChar).Value = MaHocKy;
                com.Parameters.Add("@manamhoc", SqlDbType.VarChar).Value = MaNamHoc;

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

        public bool SuaBaoCaoTongKetMon(string MaBCTKM, string MaMonHoc, string MaHocKy,string MaNamHoc)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "update  BaoCaoTongKetMon set MaMonHoc=@MaMonHoc , MaHocKy=@MaHocKy ,MaNamHoc=@manamhoc where  MaBaoCaoTongKetMon=@MaBCTKM";

                com.Connection = conn;

                com.Parameters.Add("@MaBCTKM", SqlDbType.Int).Value =Int32.Parse( MaBCTKM);
                com.Parameters.Add("@MaMonHoc", SqlDbType.VarChar).Value = MaMonHoc;
                com.Parameters.Add("@MaHocKy", SqlDbType.VarChar).Value = MaHocKy;
                com.Parameters.Add("@manamhoc", SqlDbType.VarChar).Value = MaNamHoc;
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
