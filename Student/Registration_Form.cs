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
using System.Linq.Expressions;
using Student_form;

namespace Student
{
    public partial class Registration_Form : Form
    {
        studentClass student = new studentClass();
        public Registration_Form()
        {
            InitializeComponent();
        }

        public void showTable()
        {
            DataGrid_student.DataSource = student.getStudentlist();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGrid_student.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void Registration_Form_Load(object sender, EventArgs e)
        {
                showTable();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_upload_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_img.Image=Image.FromFile(opf.FileName);
        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
                //add data to SQL server
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
                        if (student.insertStudent(firstName, lastName, DOB, sex, phone, address, img))
                        {
                            showTable();
                            MessageBox.Show("New student added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)


                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

          //verify function
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

       private void button_clear_Click_2(object sender, EventArgs e)
          {
            textBox_firstName.Clear();
            textBox_lastName.Clear();
            textBox_phone.Clear();
            textBox_address.Clear();
            pictureBox_img.Image = null;
          }

        private void Regiserform_Load(object sender, EventArgs e)
        {
            showTable();
        }

        public void showtable()
        {
            DataGrid_student.DataSource = student.getStudentlist();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGrid_student.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
    }

}



