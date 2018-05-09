using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DatabaseBLL
    {
        DatabaseAccess dba;

        public void ConnectToDatabase()
        {
            if (dba == null)
                dba = new DatabaseAccess();
            dba.ConnectToDatabase();
        }

        public void ConnectToDatabase(string sever, string database)
        {
            if (dba == null)
                dba = new DatabaseAccess();
            dba.ConnectToDatabase(sever, database);
        }

        public void ConnectToDatabase(string sever, string database, string tenDangNhap, string matKhau)
        {
            if (dba == null)
                dba = new DatabaseAccess();
            dba.ConnectToDatabase(sever, database, tenDangNhap, matKhau);
        }

        public void OpenConnection()
        {
            dba.OpenConnection();
        }

        public void CloseConection()
        {
            dba.CloseConnection();
        }

        public void SaveChangeConection()
        {
            dba.SaveChangeConection();
        }
    }
}
