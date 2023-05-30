using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;

namespace System_College_of_Communication.students
{
    public partial class Import_students_word : Form
    {
        private SqlConnection sqlConnection = null;
        private readonly StudentsList _parent;
        public Import_students_word(StudentsList parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void Import_students_word_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["base_main"].ConnectionString);
            sqlConnection.Open();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Documents (*.doc, *.docx) | *.doc; *.docx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtPathFilename.Text = openFileDialog.FileName;
                }
            }
        }
        private void ImportWordDataToDatabase(string filePath)
        {
            // Создать документ Word
            Application wordApplication = new Application();
            Document document = wordApplication.Documents.Open(filePath, ReadOnly: true);

            // Получить первую таблицу в документе
            Table table = document.Tables[1];

            // Прочитать данные из таблицы
            for (int row = 2; row <= table.Rows.Count; row++)
            {
                string column1 = table.Cell(row, 1).Range.Text.TrimEnd('\r', '\a').Trim();
                string column2 = table.Cell(row, 2).Range.Text.TrimEnd('\r', '\a').Trim();

                // Вставить данные в базу данных
                SqlCommand databaseCommand = new SqlCommand("INSERT INTO Students (fio_stud, g_stud) VALUES (@fio, @group)", sqlConnection);
                databaseCommand.Parameters.AddWithValue("@fio", column1);
                databaseCommand.Parameters.AddWithValue("@group", column2);
                try
                {
                    databaseCommand.ExecuteNonQuery();
                    MessageBox.Show("Успешно добавил!\n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error not insert: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            
            document.Close();
            wordApplication.Quit();
            
        }

        private void btnSaveDB_Click(object sender, EventArgs e)
        {
            ImportWordDataToDatabase(txtPathFilename.Text);
            _parent.Display();
        }
    }
}
