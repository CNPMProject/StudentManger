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
    public class BaoCaoTongKetHocKyAccess : DatabaseAccess
    {
        public BaoCaoTongKetHocKyAccess() : base()
        { }

        public List<BaoCaoTongKetHocKy> GetAllBaoCaoTongKetHocKy()
        {
            OpenConnection();

            List<BaoCaoTongKetHocKy> listBaoCaoTongKetHocKy = new List<BaoCaoTongKetHocKy>();

            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from BaoCaoTongKetHocKy";
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                string MaHocKy = reader.GetString(0);
                string MaNamHoc = reader.GetString(1);
                string MaLop = reader.GetString(2);
                int SoLuongDat = reader.GetInt32(3);
                float Tile = reader.GetFloat(4);

                BaoCaoTongKetHocKy baoCaoTongKetHocKy = new BaoCaoTongKetHocKy(MaHocKy,MaNamHoc, MaLop, SoLuongDat, Tile);
                listBaoCaoTongKetHocKy.Add(baoCaoTongKetHocKy);
            }

            reader.Close();
            CloseConnection();
            return listBaoCaoTongKetHocKy;
        }

        public ErrorType TaoBaoCaoTongKetHocKy(string maHocKy,string maNamHoc, List<Lop> listLop)
        {
            try
            {
                OpenConnection();
            }
            catch { return ErrorType.KHONG_THE_KET_NOI; }
          
            foreach(Lop lop in listLop)
            {
                    ThemBaoCaoTongKetHocKy(maHocKy, maNamHoc, lop.MaLop, 0, 0);             
            }


            return ErrorType.THANH_CONG;
        }

        public bool XoaBaoCaoTongKetHocKy(string MaHocKy, string MaNamHoc,string MaLop)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from BaoCaoTongKetHocKy where MaHocKy=@MaHocKy and MaLop=@MaLop and MaNamHoc=@manamhoc";
            com.Parameters.Add("@MaHocKy", SqlDbType.VarChar).Value = MaHocKy;
            com.Parameters.Add("@manamhoc", SqlDbType.VarChar).Value = MaNamHoc;
            com.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = MaLop;
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

        public bool ThemBaoCaoTongKetHocKy(string MaHocKy,string MaNamHoc, string MaLop, int SoLuongDat,float Tile)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "insert into BAOCAOTONGKETHOCKY values(@MaHocKy,@MaNamHoc,@MaLop, @SoLuongDat, @Tile)";
                com.Connection = conn;

                com.Parameters.Add("@MaHocKy", SqlDbType.VarChar).Value = MaHocKy;
                com.Parameters.Add("@MaNamHoc", SqlDbType.VarChar).Value = MaNamHoc;
                com.Parameters.Add("@MaLop", SqlDbType.NVarChar).Value = MaLop;
                com.Parameters.Add("@SoLuongDat", SqlDbType.Int).Value = SoLuongDat;
                com.Parameters.Add("@Tile", SqlDbType.Float).Value = Tile;

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

        public bool SuaBaoCaoTongKetHocKy(string MaHocKy, string MaNamHoc,string MaLop, int SoLuongDat,float Tile)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "update  BaoCaoTongKetHocKy set SoLuongDat = @SoLuongDat ,Tile = @Tile where MaNamHoc=@MaNamHoc and MaHocKy=@MaHocKy and MaLop=@MaLop";
                com.Connection = conn;

                com.Parameters.Add("@MaHocKy", SqlDbType.VarChar).Value = MaHocKy;
                com.Parameters.Add("@MaNamHoc", SqlDbType.VarChar).Value = MaNamHoc;
                com.Parameters.Add("@MaLop", SqlDbType.NVarChar).Value = MaLop;
                com.Parameters.Add("@SoLuongDat", SqlDbType.Int).Value = SoLuongDat;
                com.Parameters.Add("@Tile", SqlDbType.Float).Value = Tile;


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