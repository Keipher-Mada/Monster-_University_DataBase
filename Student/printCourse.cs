using DGVPrinterHelper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class printCourse : Form
    {
        courseClass course = new courseClass();
        DGVPrinter printer = new DGVPrinter();
        public printCourse()
        {
            InitializeComponent();
        }

        private void printCourse_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void showData()
        {
            //show course on data grid
            DataGrid_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            //search function
            DataGrid_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course` WHERE CONCAT(`Course_name`)LIKE '%" +textBox_search.Text+"%'"));
            textBox_search.Clear();
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            //link to DgvPrinter for pdf printing
            printer.Title = "Monster University course list";
            printer.SubTitle = string.Format("Data: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "foxlearn";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGrid_course);
        }
    }
}
