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
using System.Configuration;
using System.IO;
using System.Diagnostics;

namespace System_College_of_Communication.Documents
{
    public partial class Doc : Form
    {
        private SqlConnection sqlConnection = null;
        public Doc()
        {
            InitializeComponent();
        }

        private void Doc_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["base_main"].ConnectionString);
            sqlConnection.Open();
        }

        public void Display()
        {
            Database.DbStudent.DisplayAndSearch("SELECT id,filename,categories,date,path FROM Documents", dataGridView);
        }

        private void Doc_Shown(object sender, EventArgs e)
        {
            Display();
        }

        public void DeleteDoc(string id)
        {
            string sql = "DELETE FROM Documents WHERE id = @Docid";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            cmd.Parameters.AddWithValue("@Docid", id);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Успешно удалил!\n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error not delete: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlConnection.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //download
                // MessageBox.Show("Скачать");
                DownloadFileFromDatabase(dataGridView);
                return;
            }
            if (e.ColumnIndex == 1)
            {

                if (MessageBox.Show("Вы действительно хотите удалить?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DeleteDoc(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void UploadFileToDatabase(string filePath)
        {
            byte[] fileContent = File.ReadAllBytes(filePath);
            string fileName = Path.GetFileNameWithoutExtension(filePath);
            string fileType = Path.GetExtension(filePath);

            // Сохранить файл в папке с проектом
            string projectDirectory = Path.GetDirectoryName(Application.ExecutablePath) + @"\Personal_documents";
            string saveFilePath = Path.Combine(projectDirectory, fileName + fileType);
            File.WriteAllBytes(saveFilePath, fileContent);

            SqlCommand databaseCommand = new SqlCommand("INSERT INTO Documents (filename, filetype, filecontent, path, date) VALUES (@filename, @filetype, @filecontent, @path, @date)", sqlConnection);
            databaseCommand.Parameters.AddWithValue("@filename", fileName);
            databaseCommand.Parameters.AddWithValue("@filetype", fileType);
            databaseCommand.Parameters.AddWithValue("@filecontent", fileContent);
            databaseCommand.Parameters.AddWithValue("@path", saveFilePath);
            databaseCommand.Parameters.AddWithValue("@date", DateTime.Now);
            
            databaseCommand.ExecuteNonQuery();
            Display();
        }

        private void DownloadFileFromDatabase(DataGridView dataGridView)
        {
            // Получить значение ячейки с путем к файлу
            int rowIndex = dataGridView.CurrentCell.RowIndex;
            string filePath = dataGridView.Rows[rowIndex].Cells["path"].Value.ToString();

            // Считать содержимое файла из указанного пути
            byte[] fileContent = File.ReadAllBytes(filePath);

            // Показать диалог сохранения для сохранения файла на диск
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = Path.GetFileName(filePath);
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, fileContent);
                    MessageBox.Show("Файл успешно сохранен.");
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Path.GetDirectoryName(Application.ExecutablePath) + @"\Personal_documents");
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Все файлы (*.*)|*.*" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    UploadFileToDatabase(openFileDialog.FileName);
                }
            }
        }
    }
}
