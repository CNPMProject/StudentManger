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
    public class ThayDoiQuyDinhAccess : DatabaseAccess
    {
        public ThayDoiQuyDinhAccess() : base()
        { }

        public List<ThamSo> GetAllThamSo()
        {
            OpenConnection();

            List<ThamSo> listThamSo = new List<ThamSo>();

            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from THAMSO";
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                string mathamso = reader.GetString(0);
                string tenthamso = reader.GetString(1);
                decimal giatri = reader.GetDecimal(2);
                ThamSo thamso = new ThamSo(mathamso, tenthamso, giatri);
                listThamSo.Add(thamso);


            }

            reader.Close();
            CloseConnection();
            return listThamSo;
        }

        public bool XoaThamSo(string mathamso)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from THAMSO where MaThamSo=@mathamso";
            com.Parameters.Add("@mathamso", SqlDbType.VarChar).Value = mathamso;
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

        public bool ThemThamSo(string mathamso, string ten, float giatri)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "insert into THAMSO values(@mathamso,@ten,@giatri)";
                com.Connection = conn;
                com.Parameters.Add("@mathamso", SqlDbType.VarChar).Value = mathamso;
                com.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
                com.Parameters.Add("@giatri", SqlDbType.Float).Value = giatri;


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

        public bool SuaThamSo(string mathamso, Decimal giatri)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "update THAMSO set GiaTri=@giatri where  MaThamSo=@mathamso ";
                com.Connection = conn;

                com.Parameters.Add("@mathamso", SqlDbType.VarChar).Value = mathamso;
                com.Parameters.Add("@giatri", SqlDbType.Decimal).Value = giatri;


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
