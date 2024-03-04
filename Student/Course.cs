using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_form;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MySql.Data.MySqlClient;

namespace Student
{
    
    public partial class Course : Form
    {
        courseClass course = new courseClass();
        public Course()
        {
            InitializeComponent();
        }

        private void Course_Load(object sender, EventArgs e)
        {
            showData();
        }  

        private void showData()
        {
            //show course on data grid
            DataGrid_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_courseName.Clear();
            textBox_hours.Clear();
            textBox_details.Clear();

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_courseName.Text == "" || textBox_hours.Text == "")
            {
                MessageBox.Show("Need Course data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string cName = textBox_courseName.Text;
                int hr = Convert.ToInt32(textBox_hours.Text);
                string de = textBox_details.Text;

                if (course.insertCourse(cName, hr, de))
                {
                    showData();
                    button_clear.PerformClick();
                    MessageBox.Show("New course inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unable to insert course", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
 }

