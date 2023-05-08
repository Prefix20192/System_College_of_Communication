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

namespace System_College_of_Communication.students
{
    public partial class StudentsList : Form
    {

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
            var path = Path.GetFullPath(@"../../Database/Database.mdf");
            string sql_path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+path+";Integrated Security=True";
            sqlConnection = new SqlConnection(sql_path);
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
        
    }
}
