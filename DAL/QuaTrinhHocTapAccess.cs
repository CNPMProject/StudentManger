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
    public class QuaTrinhHocTapAccess : DatabaseAccess
    {

        public QuaTrinhHocTapAccess() : base()
        { }

        public List<QuaTrinhHocTap> GetAllQuaTrinhHocTap()
        {
            OpenConnection();

            List<QuaTrinhHocTap> listQuaTrinhHocTap = new List<QuaTrinhHocTap>();

            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from QUATRINHHOCTAP";
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                string MaQTH = reader.GetString(0);
                string MaLop = reader.GetString(1);
                string MaHocKy = reader.GetString(2);
                string MaHocSinh = reader.GetString(3);
                float DiemTBHk = 0;
                try { DiemTBHk = reader.GetFloat(4); }
                catch { }
                QuaTrinhHocTap quatrinhoctap = new QuaTrinhHocTap(MaQTH, MaLop, MaHocKy, MaHocSinh, DiemTBHk);
                listQuaTrinhHocTap.Add(quatrinhoctap);

            }

            reader.Close();
            CloseConnection();
            return listQuaTrinhHocTap;
        }

        public List<QuaTrinhHocTap> GetQuaTrinhHocTapCoMaHS(string maHS) 
        {
            OpenConnection();

            List<QuaTrinhHocTap> listQuaTrinhHocTap = new List<QuaTrinhHocTap>();

            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from QUATRINHHOCTAP where MaHocSinh=@ma";
            com.Parameters.Add("@ma", SqlDbType.VarChar).Value = maHS;
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                string MaQTH = reader.GetString(0); 
                string MaLop = reader.GetString(1);
                string MaHocKy = reader.GetString(2);
                string MaHocSinh = reader.GetString(3);
                float DiemTBHk = 0;
                try { DiemTBHk = reader.GetFloat(4); }
                catch { }
                QuaTrinhHocTap quatrinhoctap = new QuaTrinhHocTap(MaQTH, MaLop, MaHocKy, MaHocSinh, DiemTBHk);
                listQuaTrinhHocTap.Add(quatrinhoctap);

            }

            reader.Close();
            CloseConnection();
            return listQuaTrinhHocTap;
        }

        public bool XoaQuaTrinhHocTap(string maQTH)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from QUATRINHHOCTAP where MaQTH=@maQTH";
            com.Parameters.Add("@maQTH", SqlDbType.VarChar).Value = maQTH;
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

        public bool ThemQuaTrinhHocTap(string maqth, string malop, string mahocky, string mahsinh, float diemtbhk)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "insert into QUATRINHHOCTAP values (@maqth,@malop,@mahocky,@mahsinh,@diemtbhk)";
                com.Connection = conn;

                com.Parameters.Add("@maqth", SqlDbType.VarChar).Value = maqth;
                com.Parameters.Add("@malop", SqlDbType.VarChar).Value = malop;
                com.Parameters.Add("@mahocky", SqlDbType.VarChar).Value = mahocky;
                com.Parameters.Add("@mahsinh", SqlDbType.VarChar).Value = mahsinh;
                com.Parameters.Add("@diemtbhk", SqlDbType.Float).Value = diemtbhk;


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

        public bool SuaQuaTrinhHocTap(string maqth, string malop, string mahky, string mahsinh, float diemtbhk)
        {
          //  try
            //{
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "update  QUATRINHHOCTAP set MaLop=@malop , MaHocKy=@mahky , MaHocSinh=@mahsinh , DiemTBHk=@diemtbhk where  MaQTH=@maqth";
                com.Connection = conn;

                com.Parameters.Add("@maqth", SqlDbType.VarChar).Value = maqth;
                com.Parameters.Add("@malop", SqlDbType.VarChar).Value = malop;
                com.Parameters.Add("@mahky", SqlDbType.VarChar).Value = mahky;
                com.Parameters.Add("@mahsinh", SqlDbType.VarChar).Value = mahsinh;
                com.Parameters.Add("@diemtbhk", SqlDbType.Float).Value = diemtbhk;

                int result = com.ExecuteNonQuery();

                CloseConnection();
                if (result > 0)
                    return true;
                return false;

         //   }
           // catch
            //{
              //  return false;
           // }
        }
    }
}
