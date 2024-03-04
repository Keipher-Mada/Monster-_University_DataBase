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
        //query counter
        public string exeCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connect.getconnection);
            connect.openConnect() ;
            string count = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return count;
        }
        //retrived total student count from sql server
        public string totalStudent ()
        {
            return exeCount("SELECT COUNT(*) FROM student; ");
        }
        //Male student count
        public string maleCount()
        {
            return exeCount("SELECT COUNT(*) FROM student WHERE `Sex`='Male';");
        }
        //Female student count
        public string femaleCount()
        {
            return exeCount("SELECT COUNT(*) FROM student WHERE `Sex`='Female';");
        }
        //search functionality
        public DataTable searchStudent(String searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student` WHERE CONCAT(`First name`,`Last name`,`Address`) LIKE '%"+ searchdata + "%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //edit functionality
        public bool updateStudent(int id,string firstName, string lastName, DateTime DOB, string sex, string phone, string address, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `student` SET `Id`= @id,`First name`= @fn,`Last name`= @ln,`D.O.B`= @dob,`Sex`= @sex,`Phone`= @ph,`Address`= @adr,`Photo`= @img) VALUES(@id,@fn, @ln, @dob, @sex, @ph, @adr, @img)", connect.getconnection);

            //@fn, @ln, @dob, @sex, @ph, @adr, @img
            command.Parameters.Add("fn", MySqlDbType.VarChar).Value = firstName;
            command.Parameters.Add("ln", MySqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("dob", MySqlDbType.Date).Value = DOB;
            command.Parameters.Add("sex", MySqlDbType.VarChar).Value = sex;
            command.Parameters.Add("ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("img", MySqlDbType.Blob).Value = img;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
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
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
