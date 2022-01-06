using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Point_of_Sale.Data
{
    class DbContext
    {
        public static SqlConnection cnn;

        public static void ConnectToDb()
        {
            string connectionString =
                @"Data Source=DESKTOP-OS1JH1I,41972;Initial Catalog=AkaliDB;User ID=akali;Password=volvo;";

            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to db - " + ex.ToString());
            }
        } 

        public static void CloseDb()
        {
            cnn.Close();
        }
    }
}
