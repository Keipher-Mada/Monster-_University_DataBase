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
using System.IO;

namespace Student
{
    public partial class Student_Manage : Form
    {
        studentClass student = new studentClass();
        public Student_Manage()
        {
            InitializeComponent();
        }

        private void Student_Manage_Load(object sender, EventArgs e)
        {
            showTable();
        }
        // show grid table
        public void showTable()
        {
            DataGrid_student.DataSource = student.getStudentlist();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGrid_student.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }


        //Load SQL data to text box
        private void DataGrid_student_Click(object sender, EventArgs e)
        {
            textBox_id.Text = DataGrid_student.CurrentRow.Cells[0].Value.ToString();
            textBox_firstName.Text = DataGrid_student.CurrentRow.Cells[1].Value.ToString();
            textBox_lastName.Text = DataGrid_student.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker.Value = (DateTime)DataGrid_student.CurrentRow.Cells[3].Value;
            comboBox_sex.Text = DataGrid_student.CurrentRow.Cells[4].Value.ToString();
            textBox_phone.Text = DataGrid_student.CurrentRow.Cells[5].Value.ToString();
            textBox_address.Text = DataGrid_student.CurrentRow.Cells[6].Value.ToString();
            byte[] img = (byte[])DataGrid_student.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox_img.Image = Image.FromStream(ms);
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_firstName.Clear();
            textBox_lastName.Clear();
            textBox_phone.Clear();
            textBox_address.Clear();
            comboBox_sex.DataSource = null;
            dateTimePicker.Value = DateTime.Now;
            pictureBox_img.Image = null;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            //update student record
            int id = Convert.ToInt32(textBox_id.Text);
            string firstName = textBox_firstName.Text;
            string lastName = textBox_lastName.Text;
            DateTime DOB = dateTimePicker.Value;
            string sex = comboBox_sex.Text;
            string phone = textBox_phone.Text;
            string address = textBox_address.Text;


            //covert year to age
            int year_born = dateTimePicker.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - year_born) < 10 || (this_year - year_born) > 100)
            {
                MessageBox.Show("The student should be between the age of 10 to 100", "Invalid Birthday", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (verify())
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox_img.Image.Save(ms, pictureBox_img.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    if (student.updateStudent(id, firstName, lastName, DOB, sex, phone, address, img))
                    {
                        showTable();
                        MessageBox.Show("Record updated", "Update student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)


                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            bool verify()
            {
                if ((textBox_firstName.Text == "") || ((textBox_lastName.Text == "") ||
                   (textBox_phone.Text == "") || (textBox_address.Text == "") ||
                   (pictureBox_img.Image == null)))
                {
                    return false;
                }
                else
                    return true;
            }
        }


        private void button_search_Click_1(object sender, EventArgs e)
        {
            DataGrid_student.DataSource = student.searchStudent(textBox_search.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGrid_student.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_img.Image = Image.FromFile(opf.FileName);
        }
    }
}
      

       