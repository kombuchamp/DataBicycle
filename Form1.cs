using System;
using System.Windows.Forms;

using DataBicycle.Core;
using System.Data.SqlClient;


namespace DataBicycle
{
    public partial class Form1 : Form
    {
        static ConnectionEstablisher Establisher = new ConnectionEstablisher();

        SqlConnection connection = Establisher.Start();

        public Form1()
        {
            InitializeComponent();
        }

        private async void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;

            bool listIsEmpty = listBox1.Items.Count < 0;
            bool listIndexIsNegative = selectedIndex < 0;

            if (listIsEmpty || listIndexIsNegative)
                return;

            Form2 f2 = new Form2();
            f2.Show();

            int currID = DataObtainer.IndexToID(selectedIndex);

            if (!IsConnected(connection))
            {
                f2.Close();
                return;
            }


            /* 
             * Reading from database with SqlDataReader
             */

            // Get records by one-to-many relation
            SqlCommand cmdGetOneToManyCommand = new SqlCommand();
            cmdGetOneToManyCommand.Connection = connection;
            cmdGetOneToManyCommand.CommandText = "SELECT t1.WName, t2.Name, t1.Picture " +
                                                 "FROM [Table] t1 " +
                                                 "JOIN Country t2 " +
                                                 "ON t1.CountryID = t2.CountryID " +
                                                 "WHERE t1.ID = @ID";
            cmdGetOneToManyCommand.Parameters.AddWithValue("ID", currID);

            // Get records by many-to-many relation
            SqlCommand cmdGetManyToManyCommand = new SqlCommand();
            cmdGetManyToManyCommand.Connection = connection;
            cmdGetManyToManyCommand.CommandText = "SELECT t2.Name " +
                                                  "FROM W_E t1 " +
                                                  "JOIN Effect t2 " +
                                                  "ON t1.EffectID = t2.EffectID " +
                                                  "WHERE t1.ID = @ID";
            cmdGetManyToManyCommand.Parameters.AddWithValue("ID", currID);

            // Get data from database with SqlDataReader and fill the form
            SqlDataReader reader = await cmdGetOneToManyCommand.ExecuteReaderAsync();

            using (reader)
            {
                while (reader.Read())
                {
                    f2.PropTextBox1 = reader[0].ToString();
                    f2.PropTitle = reader[0].ToString();

                    f2.PropTextBox2 = reader[1].ToString();
                    byte[] image = reader[2] as byte[];
                    f2.PropPictureBox1Image = ImageReader.GetImage(image);
                }
            }

            reader = await cmdGetManyToManyCommand.ExecuteReaderAsync();

            using (reader)
            {
                string listOfEffects = "";
                while (reader.Read())
                {
                    string currentEntry = reader.GetString(0);
                    currentEntry = currentEntry.Replace(" ", string.Empty); // MSSQL Management Studio doesn't truncate trailing spaces

                    if (listOfEffects.Length > 0)
                        listOfEffects += (", " + currentEntry.ToLower());
                    else
                        listOfEffects += currentEntry;
                }
                f2.PropTextBox3 = listOfEffects;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            textSearchPrompt.AddPlaceholder("Введите поисковой запрос");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Establisher.Finish();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string query = textSearchPrompt.Text;

            if (query == null || query.Length <= 0)
                return;

            // Проверяем, установлено ли соединение
            if (!IsConnected(connection))
                return;

            DataObtainer obtainer = new DataObtainer(connection);
            obtainer.SearchAndFillList(query, listBox1);
        }


        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (!IsConnected(connection))
                return;

            DataObtainer obtainer = new DataObtainer(connection);
            obtainer.FillList(listBox1);
        }


        private bool IsConnected(SqlConnection connection)
        {
            if (connection == null)
            {
                this.connection = Establisher.Start();
                return (connection == null) ? false : true;
            }
            return true;
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutWindow about = AboutWindow.ReturnInstance();
            about.Show();
        }
    }
}


