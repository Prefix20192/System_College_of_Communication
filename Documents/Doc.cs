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
            Database.DbStudent.DisplayAndSearch("SELECT id,filename,categories,date FROM Documents", dataGridView);
        }

        private void Doc_Shown(object sender, EventArgs e)
        {
            Display();
        }

        public void DeleteStudent(string id)
        {
            string sql = "DELETE FROM Documents WHERE id = @Docid";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            cmd.CommandType = CommandType.Text;

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
                MessageBox.Show("Скачать");
                return;
            }
            if (e.ColumnIndex == 1)
            {
                //Edit
                MessageBox.Show("Редактировать");
            }
            if (e.ColumnIndex == 2)
            {

                if (MessageBox.Show("Вы действительно хотите удалить?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DeleteStudent(dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
