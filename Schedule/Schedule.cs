using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace System_College_of_Communication.Schedule
{
    public partial class Schedule : Form
    {
        private SqlConnection sqlConnection = null;
        add_schedule add_sch;
        public Schedule()
        {
            InitializeComponent();
            add_sch = new add_schedule(this);
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["base_main"].ConnectionString);
            sqlConnection.Open();
        }

        public void Display()
        {
            Database.DbSchedule.DisplayAndSearch("SELECT id, predmet, g_name, auditori, prepod, time_work FROM schedule", dataGridView);
        }

        private void Schedule_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Database.DbSchedule.DisplayAndSearch("SELECT id, predmet, g_name, auditori, prepod, time_work FROM schedule WHERE predmet LIKE'%"+ txtSearch.Text+ "%'", dataGridView);
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                txtSearch.Text = "Введите название предмета";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Введите название предмета")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                add_sch.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                add_sch.g_name = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                add_sch.predmet = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                add_sch.auditori = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                add_sch.time_work = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                add_sch.prepod = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();

                add_sch.Update_Schedule();
                add_sch.ShowDialog();
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you want to delete schedule?", "information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Database.DbStudent.DeleteStudent(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add_sch.ShowDialog();
        }
    }
}
