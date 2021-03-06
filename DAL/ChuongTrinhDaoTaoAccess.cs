﻿using System;
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

        public ChuongTrinhDaoTao GetChuongTrinhDaoTao(string maMonHoc)
        {
            OpenConnection();

            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from ChuongTrinhDaoTao where mamonhoc=@ma";
            com.Parameters.Add("@ma", SqlDbType.VarChar).Value = maMonHoc;
            com.Connection = conn;
           
            SqlDataReader reader = com.ExecuteReader();

            ChuongTrinhDaoTao ctdt = null;
            if (reader.Read())
            {
                string maKhoi = reader.GetString(0);
                string maMon = reader.GetString(1);
                int heSo = reader.GetInt32(2);

                ctdt = new ChuongTrinhDaoTao(maKhoi, maMon, heSo);
            }

            return ctdt;
        }

        public ChuongTrinhDaoTao GetChuongTrinhDaoTao(string maMonHoc,string maKhoiLop)
        {
            OpenConnection();

            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from ChuongTrinhDaoTao where mamonhoc=@ma and makhoilop=@makl";
            com.Parameters.Add("@ma", SqlDbType.VarChar).Value = maMonHoc;
            com.Parameters.Add("@makl", SqlDbType.VarChar).Value = maKhoiLop;
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();

            ChuongTrinhDaoTao ctdt = null;
            if (reader.Read())
            {
                string maKhoi = reader.GetString(0);
                string maMon = reader.GetString(1);
                int heSo = reader.GetInt32(2);

                ctdt = new ChuongTrinhDaoTao(maKhoi, maMon, heSo);
            }
            reader.Close();
            return ctdt;
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

        public ErrorType ThemCTDT(string maKhoi, string maMon, int heSo)
        {
            //try
            //{
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
                    return ErrorType.THANH_CONG;
                return ErrorType.THAT_BAI;
        }
        //    catch
        //    {
        //        return ErrorType.THAT_BAI;
        //    }
        //}

        public ErrorType SuaCTDT(string maKhoi, string maMon, int heSo)
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
