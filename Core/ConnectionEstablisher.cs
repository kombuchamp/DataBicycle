using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace DataBicycle.Core
{
    class ConnectionEstablisher
    {
        SqlConnection connection;

        public SqlConnection Start()
        {
            SqlConnectionStringBuilder strBuilder = new SqlConnectionStringBuilder();

            string startupPath = Directory.GetCurrentDirectory();

            // LocalDB is used to connect to database(https://docs.microsoft.com/ru-ru/sql/database-engine/configure-windows/sql-server-2016-express-localdb)
            // SQL Server Express service is required to run this app
            strBuilder.DataSource = @"(LocalDB)\MSSQLLocalDB"; 
            strBuilder.AttachDBFilename = startupPath +  @"\BicycleDB.mdf";
            strBuilder.IntegratedSecurity = true;
            strBuilder.ConnectTimeout = 30;

            connection = new SqlConnection();
            connection.ConnectionString = strBuilder.ConnectionString;
            
            try
            {
                if (!File.Exists(startupPath + @"\BicycleDB.mdf"))
                {
                    throw new Exception("Файл базы данных не обнаружен в каталоге приложения");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK);
                return null;
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
