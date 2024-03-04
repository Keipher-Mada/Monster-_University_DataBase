using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.Data;
using System.Web.UI.WebControls;

namespace Student_form
{
    class studentClass
    {
        DBconnect connect = new DBconnect();

        public bool insertStudent(string firstName, string lastName, DateTime DOB, string sex, string phone, string address, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student`(`First name`, `Last name`, `D.O.B`, `Sex`, `Phone`, `Address`, `Photo`) VALUES(@fn, @ln, @dob, @sex, @ph, @adr, @img)", connect.getconnection);

            //@fn, @ln, @dob, @sex, @ph, @adr, @img
            command.Parameters.Add("fn", MySqlDbType.VarChar).Value = firstName;
            command.Parameters.Add("ln", MySqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("dob", MySqlDbType.Date).Value = DOB;
            command.Parameters.Add("sex", MySqlDbType.VarChar).Value = sex;
            command.Parameters.Add("ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("img", MySqlDbType.Blob).Value = img;

            connect.openConnect();
            if(command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else 
            {
                connect.closeConnect();
                return false;
            }
        }

        //retrived student table
        public DataTable getStudentlist()
        { 
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student`", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
