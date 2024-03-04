using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Student_form
{
    class DBconnect
    {
        MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3307;username=root;password=;database=studentdatabase");

        //establish connection
        public MySqlConnection getconnection
        {

            get
            {
                return connect;
            }
        }

        //function to open connection
        public void openConnect()
        { 
             if (connect.State == System.Data.ConnectionState.Closed)
                 connect.Open();
        }

        //function to close connection
        public void closeConnect() 
        {
            if(connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }
    }
}
