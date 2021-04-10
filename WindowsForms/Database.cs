using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;




namespace WindowsForms
{
    class Database
    {
        public Database()
        {
            string connectString = "SERVER=localhost;DATABASE=book_store;UID=root;PASSWORD=Halk123211;";

            MySqlConnection connection = new MySqlConnection(connectString);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM book; ", connection);
            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();
        }
    }  
}
