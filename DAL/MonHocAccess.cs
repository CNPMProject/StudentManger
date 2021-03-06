﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class MonHocAccess : DatabaseAccess
    {
        public MonHocAccess() : base()
        { }

        public List<MonHoc> GetAllMonHoc()
        {
            OpenConnection();

            List<MonHoc> listMonHoc = new List<MonHoc>();

            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from MonHoc";
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                string maMH = reader.GetString(0);
                string tenMH = reader.GetString(1);

                MonHoc monHoc = new MonHoc(maMH, tenMH);
                listMonHoc.Add(monHoc);
            }

            reader.Close();
            CloseConnection();
            return listMonHoc;
        }

        public MonHoc GetMonHoc(string maMonHoc)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from MonHoc where MaMonHoc=@ma";
            com.Parameters.Add("@ma", SqlDbType.VarChar).Value = maMonHoc;
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            MonHoc monhoc = null;
            while (reader.Read())
            {
                string ma = reader.GetString(0);
                String ten = reader.GetString(1);

                monhoc = new MonHoc(ma, ten);
            }

            reader.Close();
            CloseConnection();
            return monhoc;
        }

        public bool XoaMonHoc(string maMH)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from MonHoc where MaMonHoc=@ma";
            com.Parameters.Add("@ma", SqlDbType.VarChar).Value = maMH;
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

        public ErrorType ThemMonHoc(string ma, string ten)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "insert into MonHoc values(@ma,@ten)";
                com.Connection = conn;

                com.Parameters.Add("@ma", SqlDbType.VarChar).Value = ma;
                com.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;

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

        public ErrorType SuaMonHoc(string ma, string ten)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "update  MonHoc set TenMonHoc=@Ten where  MaMonHoc=@ma";
                com.Connection = conn;

                com.Parameters.Add("@ma", SqlDbType.VarChar).Value = ma;
                com.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;

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

      
}
}
