using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Windows.Forms;

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

        public BaoCaoTongKetMon GetBaoCaoTongKetMon(string hocky, string namhoc, string monhoc)
        {
            OpenConnection();


            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from BaoCaoTongKetMon where mamonhoc=@monhoc and mahocky=@hocky and manamhoc=@namhoc";
            com.Parameters.Add("@monhoc", SqlDbType.VarChar).Value = monhoc;
            com.Parameters.Add("@namhoc", SqlDbType.VarChar).Value = namhoc;
            com.Parameters.Add("@hocky", SqlDbType.VarChar).Value = hocky;
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            BaoCaoTongKetMon baoCaoTongKetMon = null;
            if (reader.Read())
            {
                string MaBCTKM = reader.GetInt32(0) + "";
                string MaMonHoc = reader.GetString(1);
                string MaHocKy = reader.GetString(2);
                string MaNamHoc = reader.GetString(3);


                baoCaoTongKetMon = new BaoCaoTongKetMon(MaBCTKM, MaMonHoc, MaHocKy, MaNamHoc);
               
            }

            reader.Close();
            CloseConnection();
            return baoCaoTongKetMon;
        }

        public string getMaBaoCaoMax()
        {
            OpenConnection();


            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = " select top 1 MaBCTKM from BAOCAOTONGKETMON order by MaBCTKM DESC";
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            string maBaoCao = null;
            if (reader.Read())
            {
                maBaoCao = reader.GetInt32(0) + "";
            }

            reader.Close();
            CloseConnection();
            return maBaoCao;
        }

        public ErrorType TaoBaoCaoTongKetMon(string hocky, string namhoc, string monhoc)
        {
            try
            {
                OpenConnection();
            }
            catch { return ErrorType.KHONG_THE_KET_NOI; }

            BaoCaoTongKetMon baocao = GetBaoCaoTongKetMon(hocky, namhoc, monhoc);
            //neu chua ton tai thi tao bao cao tong key mon
            string maHienTai = null;
            if (baocao == null)
            {
                //lay ra bao cao moi nhat de tao ma bao cao
                maHienTai = getMaBaoCaoMax();
                maHienTai = (Int32.Parse(maHienTai) + 1).ToString();
                ThemBaoCaoTongKetMon(maHienTai, monhoc, hocky, namhoc);
            }
            else
                maHienTai = baocao.MaBCTKM;

            //tao chi tiet bao cao tong ket mon tat ca cac lop co ma bctk mon nay

            CTBaoCaoTongKetMonAccess CTbaocao = new CTBaoCaoTongKetMonAccess();
            LopAccess lopac = new LopAccess();
            List<Lop> listLop = lopac.GetAllLop();

            foreach(Lop lop in listLop)
            {
                CTbaocao.ThemCTBaoCaoTongKetMon(maHienTai, lop.MaLop, 0, 0);
            }
            
            return ErrorType.THANH_CONG;
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
            //try
            //{
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "insert into BaoCaoTongKetMon values(@MaBCTKM, @MaMonHoc, @MaHocKy,@manamhoc)";
                com.Connection = conn;

                com.Parameters.Add("@MaBCTKM", SqlDbType.Int).Value =Int32.Parse( MaBCTKM);
                com.Parameters.Add("@MaMonHoc", SqlDbType.VarChar).Value = MaMonHoc;
                com.Parameters.Add("@MaHocKy", SqlDbType.VarChar).Value = MaHocKy;
                com.Parameters.Add("@manamhoc", SqlDbType.VarChar).Value = MaNamHoc;
           // MessageBox.Show(MaNamHoc);

                int result = com.ExecuteNonQuery();

                CloseConnection();
                if (result > 0)
                    return true;
                return false;
            //}
            //catch
            //{
            //    return false;
            //}
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
