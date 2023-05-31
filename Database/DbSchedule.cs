using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Configuration;

namespace System_College_of_Communication.Database
{
    class DbSchedule
    {
        public static SqlConnection GetConnection()
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["base_main"].ConnectionString);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connection SQL: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void AddSchedule(Schedule.parametrs_schedule sch)
        {
            string sql = "INSERT INTO schedule (g_name, predmet, auditori, time_work, prepod) VALUES (@g_name, @predmet, @auditori, @time_work, @prepod)";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@g_name", sch.g_name);
            cmd.Parameters.AddWithValue("@predmet", sch.predmet);
            cmd.Parameters.AddWithValue("@auditori", sch.auditori);
            cmd.Parameters.AddWithValue("@time_work", sch.time_work);
            cmd.Parameters.AddWithValue("@prepod", sch.prepod);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно добавил!\n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error not insert: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void UpdateSchedule(Schedule.parametrs_schedule sch, string id)
        {
            string sql = "UPDATE schedule SET g_name = @g_name, predmet = @predmet, auditori = @auditor, time_work = @time, prepod = @prepod WHERE id = @ScheduleID";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@ScheduleID", id);
            cmd.Parameters.AddWithValue("@g_name", sch.g_name);
            cmd.Parameters.AddWithValue("@predmet", sch.predmet);
            cmd.Parameters.AddWithValue("@auditor", sch.auditori);
            cmd.Parameters.AddWithValue("@time", sch.time_work);
            cmd.Parameters.AddWithValue("@prepod", sch.prepod);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Успешно обновил!\n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error not update: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DeleteSchedule(string id)
        {
            string sql = "DELETE FROM schedule WHERE id = @ScheduleID";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@ScheduleID", id);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Успешно удалил!\n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error not delete: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        //Это функция делает поиск
        public static void DisplayAndSearch(string query, DataGridView dvg)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adp.Fill(tbl);
            dvg.DataSource = tbl;
            con.Close();
        }
    }
}
