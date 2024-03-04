using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class manageCourse : Form
    {
        courseClass course = new courseClass();
        public manageCourse()
        {
            InitializeComponent();
        }

        private void manageCourse_Load(object sender, EventArgs e)
        {
            showData();
        }
        //show course list
        private void showData()
        {
            //show course on data grid
            DataGrid_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
        }


        private void button_update_Click(object sender, EventArgs e)
        { 
            if (textBox_courseName.Text == "" || textBox_hours.Text == "" || textBox_courseId.Text.Equals(""))
            {
               MessageBox.Show("Need Course data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(textBox_courseId.Text);
                string cName = textBox_courseName.Text;
                int hr = Convert.ToInt32(textBox_hours.Text);
                string de = textBox_details.Text;

                if (course.updateCourse(id, cName, hr, de))
                    {
                        showData();
                        button_clear.PerformClick();
                        MessageBox.Show("Course upadted", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error - Unable to update course", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_courseId.Clear();
            textBox_courseName.Clear();
            textBox_hours.Clear();
            textBox_details.Clear();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_courseId.Text.Equals(""))
            {
                MessageBox.Show("Course id is require", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox_courseId.Text);
                    if (course.deleteCourse(id))
                    {
                        showData();
                        button_clear.PerformClick();
                        MessageBox.Show("Course deleted", "Removed Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Removed Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DataGrid_course_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_courseId.Text = DataGrid_course.CurrentRow.Cells[0].Value.ToString();
            textBox_courseName.Text = DataGrid_course.CurrentRow.Cells[1].Value.ToString();
            textBox_hours.Text = DataGrid_course.CurrentRow.Cells[2].Value.ToString();
            textBox_details.Text = DataGrid_course.CurrentRow.Cells[3].Value.ToString();

        }
    }
}
