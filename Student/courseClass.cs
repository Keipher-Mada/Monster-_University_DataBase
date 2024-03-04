using MySql.Data.MySqlClient;
using Student_form;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Student
{
    internal class courseClass
    {
        DBconnect connect = new DBconnect();
        //function for inserting course
        public bool insertCourse(string cName, int hr, string de)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `course`(`Course_name`, `Course_Hours`, `Details`) VALUES (@cn,@hr,@de)", connect.getconnection);
            //@cn, @hr, @de
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@hr", MySqlDbType.Int32).Value = hr;
            command.Parameters.Add("@de", MySqlDbType.VarChar).Value = de;
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



        //function to retrived course
        public DataTable getCourse(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //functionality for course update
        public bool updateCourse(int id, string cName, int hr, string de)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `course` SET `Course_Id`=@id,`Course_name`=@cn,`Course_Hours`=@hr,`Details`=@de ", connect.getconnection);
            //@id, @cn, @hr, @de
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@hr", MySqlDbType.Int32).Value = hr;
            command.Parameters.Add("@de", MySqlDbType.VarChar).Value = de;
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
        //Functionality for delete course data
        public bool deleteCourse(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `course` WHERE `Course_Id`=@id", connect.getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
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

    }
}
