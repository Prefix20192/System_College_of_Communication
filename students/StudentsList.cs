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
using DataTable = System.Data.DataTable;

namespace System_College_of_Communication.students
{
    public partial class StudentsList : Form
    {
        StudentsUpdate std_upd;
        StudentInfo std_info;
        Import_students_word std_import;
    
        private SqlConnection sqlConnection = null;

        public StudentsList()
        {
            InitializeComponent();
            std_upd = new StudentsUpdate(this);
            std_info = new StudentInfo(this);
            std_import = new Import_students_word(this);
        }


        public void Display()
        {
            Database.DbStudent.DisplayAndSearch("SELECT id, fio_stud, g_stud FROM Students", dataGridView);
        }

        private void StudentsList_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["base_main"].ConnectionString);
            sqlConnection.Open();
           // FillComboBox();
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
                std_info.id = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                std_info.ShowDialog();
            }
            if(e.ColumnIndex == 1)
            {
                //Edit
                std_upd.id = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                std_upd.UpdateInfo();
                std_upd.ShowDialog();
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

        private void btneksport_word_Click(object sender, EventArgs e)
        {
            // Получить данные из базы данных
            var query = "SELECT Student_info.stud_id as 'Ид студента', Students.fio_stud as 'ФИО студента', Students.g_stud as 'Группа студента', Student_info.birthday as 'Дата рождения', Student_info.phone as 'Телефон', Student_info.pasport as 'Паспортные данные', Student_info.education as 'Образование', Student_info.address_in_stav as 'Фактический адресс', Student_info.propiska as 'Место проживание (как в паспорте)', Student_info.family_status as 'Семейный статус', Student_info.Accounting_of_ODN as 'Состояние на учете в ОДН', Student_info.Fio_mam as 'ФИО мамы', Student_info.fio_pap as 'Фио папы', Student_info.phone_mam as 'Телефон мамы', Student_info.phone_pap as 'Телефон папы', Student_info.address_family as 'Семейный статус', Student_info.nationalnost as 'Национальность' FROM Students LEFT JOIN Student_info ON Students.id = Student_info.stud_id";

            var datatable = new DataTable();

            queryReturnData(query, datatable);
            ExportToWord(datatable);
        }
        public DataTable queryReturnData(string query, DataTable dataTable)
        {
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            SDA.SelectCommand.ExecuteNonQuery();

            SDA.Fill(dataTable);
            return dataTable;
        }
        private void ExportToWord(DataTable dataTable)
        {
            if (dataTable.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                word.Application.Documents.Add(Type.Missing);

                Microsoft.Office.Interop.Word.Table table = word.Application.ActiveDocument.Tables.Add(word.Selection.Range, dataTable.Rows.Count + 1, dataTable.Columns.Count, Type.Missing, Type.Missing);
                table.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
                table.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;

                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    table.Cell(1, i + 1).Range.Text = dataTable.Columns[i].ColumnName;
                }

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        table.Cell(i + 2, j + 1).Range.Text = dataTable.Rows[i][j].ToString();
                    }
                }

                word.Visible = true;
            }
            else
            {
                MessageBox.Show("Базаа данных пустая!");
            }
        }

        private void btnImport_word_Click(object sender, EventArgs e)
        {
            Import_students_word s_word = new Import_students_word(this);
            s_word.Show();
        }
        /*
        private void FillComboBox()
        {
            // Выполнить запрос для получения данных
            SqlCommand databaseCommand = new SqlCommand("SELECT g_stud FROM Students", sqlConnection);
            SqlDataReader dataReader = databaseCommand.ExecuteReader();

            // Очистить список ComboBox
            comboBox1.Items.Clear();

            // Добавить элементы в ComboBox
            while (dataReader.Read())
            {
                comboBox1.Items.Add(dataReader["g_stud"].ToString());
            }
        }
        */
    }
}
