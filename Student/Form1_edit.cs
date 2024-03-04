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
    public partial class Form_menu : Form
    {
        public Form_menu()
        {
            InitializeComponent();
            customDesign();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void customDesign()
        {
            panel_registrationSubmenu.Visible = false;
            panel_courseSubmenu.Visible = false;
            panel_gradesSubmenu.Visible = false;
        }

        private void hideSubmenu()
        { 
        if (panel_courseSubmenu.Visible == true)
            panel_courseSubmenu.Visible = false;
        if (panel_registrationSubmenu.Visible == true)
            panel_registrationSubmenu.Visible = false;
        if (panel_gradesSubmenu.Visible == true)
            panel_gradesSubmenu.Visible = false;
        }
    

         private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        
        private void button_student_Click_1(object sender, EventArgs e)
        {
            {
                showSubmenu(panel_registrationSubmenu);
            }
        }
        #region student_section
        private void button_registration_Click(object sender, EventArgs e)
        {
            openChildForm(new Registration_Form());
            //...
            //..for later
            //...
            hideSubmenu();
        }

        private void button_manageStudent_Click_1(object sender, EventArgs e)
        {
            //...
            //..for later
            //...
            hideSubmenu();
        }

        private void button_status_Click_1(object sender, EventArgs e)
        {
            //...
            //..for later
            //...
            hideSubmenu();
        }

        private void button_attendance_Click_1(object sender, EventArgs e)
        {
            //...
            //..for later
            //...
            hideSubmenu();
        }
        #endregion student_section 
        private void button_course_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panel_courseSubmenu);
        }
        #region course_section

        private void button_newCourse_Click_1(object sender, EventArgs e)
        {
            //...
            //..for later
            //...
            hideSubmenu();
        }

        private void button_manageCourse_Click_1(object sender, EventArgs e)
        {
            //...
            //..for later
            //...
            hideSubmenu();
        }

        private void button_print_Click_1(object sender, EventArgs e)
        {
            //...
            //..for later
            //...
            hideSubmenu();
        }
        #endregion course_section

        #region labels
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        #endregion labels

        private void button1_Click(object sender, EventArgs e)
        {
            //...
            //..for later
            //...
            hideSubmenu();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_grades_Click(object sender, EventArgs e)
        {
           showSubmenu(panel_gradesSubmenu);
        }

        private void button_stuGrades_Click(object sender, EventArgs e)
        {
            //...
            //..for later
            //...
            hideSubmenu();
        }

        private void button_amendGrades_Click(object sender, EventArgs e)
        {
            //...
            //..for later
            //...
            hideSubmenu();
        }

        private void button_printGrades_Click(object sender, EventArgs e)
        {
            //...
            //..for later
            //...
            hideSubmenu();
        }

        private void panel_logIn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        //connect registion form with main menu
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
               activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
