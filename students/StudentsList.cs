using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Configuration;


namespace System_College_of_Communication.students
{
    public partial class StudentsList : Form
    {
        //
        //  students.StudentsUpdate std_upd;
        //
        private SqlConnection sqlConnection = null;

        public StudentsList()
        {
            InitializeComponent();
        }


        public void Display()
        {
            Database.DbStudent.DisplayAndSearch("SELECT id, fio_stud, g_stud FROM Students", dataGridView);
        }

        private void StudentsList_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["base_main"].ConnectionString);
            sqlConnection.Open();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            students.StudentsNew stdNew = new students.StudentsNew(this);
            stdNew.Show();
        }

        private void StudentsList_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            Database.DbStudent.DisplayAndSearch("SELECT id, fio_stud, g_stud FROM Students WHERE fio_stud LIKE'%" + textSearch.Text + "%'", dataGridView);
        }

        
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.ColumnIndex == 0)
            {
                //View
                return;
            }
            if(e.ColumnIndex == 1)
            {
                //Edit
                students.StudentsUpdate stdUpdate = new students.StudentsUpdate(dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
                stdUpdate.Show();
            }
            if(e.ColumnIndex == 2)
            {
                //Delete
                
                if (MessageBox.Show("Are you want to delete record student?", "information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Database.DbStudent.DeleteStudent(dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
                    Display();
                }
                return;
            }
            
        }

        private void import_excel_Click(object sender, EventArgs e)
        {
            students.ImportStudentsFromExcel stdimportxls = new students.ImportStudentsFromExcel();
            stdimportxls.Show();
        
        }

        private void export_excel_Click(object sender, EventArgs e)
        {
  

            
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            string rep;
            for (i = 0; i <= dataGridView.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridView.ColumnCount - 1; j++)
                {
                    wsh.Cells[1, j + 1] = dataGridView.Columns[j].HeaderText.ToString();
                    rep = dataGridView[j, i].Value.ToString().Replace("|", "\\");
                    wsh.Cells[i + 2, j + 1] = rep;
                }
            }
            exApp.Visible = true;
        }
    }
}
