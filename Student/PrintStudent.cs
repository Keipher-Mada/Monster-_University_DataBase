using MySql.Data.MySqlClient;
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
using DGVPrinterHelper;

namespace Student
{
    public partial class PrintStudent : Form
    {
        studentClass student = new studentClass();
        DGVPrinter printer = new DGVPrinter();
        public PrintStudent()
        {
            InitializeComponent();
        }

        private void PrintStudent_Load(object sender, EventArgs e)
        {
            showData(new MySqlCommand("SELECT * FROM `student`"));
        }

        //function for showing data
        public void showData(MySqlCommand command)
        {
            DataGrid_student.ReadOnly = true;
            DataGridViewImageColumn ImageColumn = new DataGridViewImageColumn();
            DataGrid_student.DataSource = student.getList(command);
            //load index 7 for image
            ImageColumn = (DataGridViewImageColumn)DataGrid_student.Columns[7];
            ImageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGrid_student.DataSource = student.searchStudent(textBox_search.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGrid_student.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            //link to DgvPrinter for pdf printing
            printer.Title = "Monster University student list";
            printer.SubTitle = string.Format("Data: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.Footer = "foxlearn";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGrid_student);
        }
    }
}
