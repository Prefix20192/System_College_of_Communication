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
    public partial class Col_Hours : Form
    {
        private SqlConnection sqlConnection = null;
        txt_topic txt;
        public Col_Hours()
        {
            InitializeComponent();
            txt = new txt_topic(this);
        }

        private void Col_Hours_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["base_main"].ConnectionString);
            sqlConnection.Open();
        }

        public void Display()
        {
            Display_Query("SELECT id, date, topic, path FROM CoolHours", dataGridView);
        }

        private void Col_Hours_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void Display_Query(string query, DataGridView dvg)
        {
            string sql = query;
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adp.Fill(tbl);
            dvg.DataSource = tbl;
            sqlConnection.Close();
        }

        private void btnBrouseAndSave_Click(object sender, EventArgs e)
        {
            txt.ShowDialog();
        }

        public void Delete(string id)
        {
            string sql = "DELETE FROM CoolHours WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            cmd.Parameters.AddWithValue("@id", id);

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
                    Delete(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
