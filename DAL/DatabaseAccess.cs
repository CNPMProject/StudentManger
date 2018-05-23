using DAL.Properties;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class DatabaseAccess
    {
        public string ConnectionString { get; set; }
        public string SeverName { get; set; }
        public string DatabaseName { get; set; }
        public SqlConnection conn = null;

        public DatabaseAccess()
        {
            ConnectionString = Settings.Default.connectionString;
            SeverName = Settings.Default.SeverName;
            DatabaseName = Settings.Default.DatabaseName;
        }

        /// <summary>
        /// Kết nối bằng sever mặc định
        /// </summary>
        public void ConnectToDatabase()
        {
            ConnectionString = string.Format("Data Source = {0}; Initial Catalog = {1}; ", SeverName, DatabaseName);
            ConnectionString += "Integrated Security = True; ";
        }

        /// <summary>
        /// Kết nối với database khong can dang nhap.
        /// </summary>
        public void ConnectToDatabase(string sever, string database)
        {
            SeverName = sever;
            DatabaseName = database;

            ConnectionString = string.Format("Data Source = {0}; Initial Catalog = {1}; ", SeverName, DatabaseName);
            ConnectionString += "Integrated Security = True; ";
        }

        /// <summary>
        /// Kết nối database cần đăng nhập
        /// </summary>
        public void ConnectToDatabase(string sever, string database, string tenDangNhap, string matKhau)
        {
            SeverName = sever;
            DatabaseName = database;

            ConnectionString = "Server =" + @SeverName + ";database=" + DatabaseName + "; ";
            ConnectionString += string.Format("User id ={0};pwd={1}", tenDangNhap, matKhau);


        }

        public void OpenConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(ConnectionString);
            }
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }

        /// <summary>
        /// Lưu chuỗi đăng nhập hiện tại vào chuỗi mặc định
        /// </summary>
        public void SaveChangeConection()
        {
            Settings.Default.SeverName = SeverName;
            Settings.Default.DatabaseName = DatabaseName;
            Settings.Default.connectionString = ConnectionString;
            Settings.Default.Save();
        }

        public string GetStringConnection()
        {

            return ConnectionString;
        }
    }
}
