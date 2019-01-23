using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Configuration;

namespace DataBicycle.Core
{
    class ConnectionEstablisher
    {
        SqlConnection connection;

        public SqlConnection Start()
        {
            string startupPath = Directory.GetCurrentDirectory();

            // LocalDB is used to connect to database(https://docs.microsoft.com/ru-ru/sql/database-engine/configure-windows/sql-server-2016-express-localdb)
            // SQL Server Express service is required to run this app.
            // Attach target database to your local SQLExpress server and provide connection string in the App.config

            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager
                .ConnectionStrings["connectionString"]
                .ConnectionString;

            if (!File.Exists(startupPath + @"\BicycleDB.mdf"))
            {
                throw new Exception("Файл базы данных не обнаружен в каталоге приложения");
            }

            connection.Open();
            return connection;
        }

        public void Finish()
        {
            connection.Close();
        }
    }
}
