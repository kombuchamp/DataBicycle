using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataBicycle.Core
{
    class DataObtainer
    {
        SqlConnection connection;

        public DataObtainer(SqlConnection connection)
        {
            this.connection = connection;
        }

        static Dictionary<int, int> IndexIDdict = new Dictionary<int, int>();

        public void SearchAndFillList(string query, ListBox listbox)
        {
            // Trying to avoid an sql-injection
            query = query.Replace(';', ' ');
            query = query.Replace('"', ' ');
            query = query.Replace('\'', ' ');
            query = query.Replace('/', ' ');

            SqlCommand cmdSelectByQuery = new SqlCommand();
            cmdSelectByQuery.Connection = connection;
            cmdSelectByQuery.CommandText = "SELECT ID, WName " +
                                           "FROM [Table] " +
                                           "WHERE WName LIKE '%" + query + "%'";// @WName 
            //cmdSelectByQuery.Parameters.AddWithValue("WName", query); // won't work. Using concatination here.
            FillList(listbox, cmdSelectByQuery);
        }

        public void FillList(ListBox listbox, SqlCommand command = null)
        {
            if (command == null)
            {
                command = new SqlCommand();
                
                command.Connection = connection;
                command.CommandText = "SELECT [ID], [WName] FROM [dbo].[Table]"; 
            }

            SqlDataReader reader = command.ExecuteReader();

            listbox.Items.Clear();
            IndexIDdict.Clear();
            
            while (reader.Read())
            {
                int id = (int)reader[0];
                IndexIDdict.Add(listbox.Items.Count, id);

                string name = reader.GetString(1);
                
                listbox.Items.Add(name);
            }
            reader.Close();
               
        }

        public static int IndexToID(int index)
        {
            return IndexIDdict[index];
        }
    }
}
