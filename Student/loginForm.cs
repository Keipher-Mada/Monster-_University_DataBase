using Student_form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
   

namespace Student
{
    public partial class loginForm : Form
    {
        studentClass student = new studentClass();
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void label_x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_logIn_Click(object sender, EventArgs e)
        {
            if (textBox_userName.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Please enter your login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string uname = textBox_userName.Text;
                string pass = textBox_password.Text;
                DataTable table = student.getList(new MySqlCommand("SELECT * FROM `userinfo` WHERE `user_name`= '" + uname + "' AND `password`='" + pass + "'"));
                if (table.Rows.Count > 0)
                {
                    Form_menu main = new Form_menu();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Your account does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
