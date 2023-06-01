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

namespace System_College_of_Communication.Cool_Hour
{
    public partial class txt_topic : Form
    {
        private string FilePath = null;
        private SqlConnection sqlConnection = null;
        private readonly Col_Hours _parent;
        public txt_topic(Col_Hours parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void txt_topic_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["base_main"].ConnectionString);
            sqlConnection.Open();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Все файлы (*.*)|*.*" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = openFileDialog.FileName;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] fileContent = File.ReadAllBytes(FilePath);
            string fileName = Path.GetFileNameWithoutExtension(FilePath);
            string fileType = Path.GetExtension(FilePath);

            // Сохранить файл в папке с проектом
            string projectDirectory = Path.GetDirectoryName(Application.ExecutablePath) + @"\cool_hours_files";
            string saveFilePath = Path.Combine(projectDirectory, fileName + fileType);
            File.WriteAllBytes(saveFilePath, fileContent);

            SqlCommand databaseCommand = new SqlCommand("INSERT INTO CoolHours (filename, filetype, filecontent, topic, date, path) VALUES (@filename, @filetype, @filecontent, @topic, @date, @path)", sqlConnection);
            databaseCommand.Parameters.AddWithValue("@filename", fileName);
            databaseCommand.Parameters.AddWithValue("@filetype", fileType);
            databaseCommand.Parameters.AddWithValue("@filecontent", fileContent);
            databaseCommand.Parameters.AddWithValue("@path", saveFilePath);
            databaseCommand.Parameters.AddWithValue("@topic", txtTopic.Text);
            databaseCommand.Parameters.AddWithValue("@date", DateTime.Now);

            try
            {
                databaseCommand.ExecuteNonQuery();
                MessageBox.Show("Успешно");
                this.Hide();
                _parent.Display();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
