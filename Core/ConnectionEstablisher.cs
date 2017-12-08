using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace DataBicycle.Core
{
    class ConnectionEstablisher
    {
        SqlConnection connection;

        
        // Создаем ConnectionStringBuilder для создания строки подключения
        //SqlConnectionStringBuilder strBuilder = new SqlConnectionStringBuilder();
        
        public SqlConnection Start()
        {
            // Создаем ConnectionStringBuilder для создания строки подключения
            SqlConnectionStringBuilder strBuilder = new SqlConnectionStringBuilder();

            string startupPath = Directory.GetCurrentDirectory();

            // Для подключения к базе данных используется LocalDB (см. https://docs.microsoft.com/ru-ru/sql/database-engine/configure-windows/sql-server-2016-express-localdb)
            // Приложение может не запускаться из-за того, что не установлен какой-то компонент SQL Server Express
            strBuilder.DataSource = @"(LocalDB)\MSSQLLocalDB"; 
            strBuilder.AttachDBFilename = startupPath +  @"\BicycleDB.mdf";
            strBuilder.IntegratedSecurity = true;
            strBuilder.ConnectTimeout = 30;


            connection = new SqlConnection();
            connection.ConnectionString = strBuilder.ConnectionString;


            /* Метод выполняет две функции - устанавливает соединение
             * и возвращает экземпляр SqlConnection, что нарушает
             * правило одной операции. Экземпляр SqlConnection 
             * инициализируется как поле, поэтому приходится размещать
             * блок обработки исключений внутри класса (это-костыль)
             * 
             * TODO: рефакторинг
             */

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
