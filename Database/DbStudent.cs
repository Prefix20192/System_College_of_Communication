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
    class DbStudent
    {
        public static SqlConnection GetConnection()
        {
            /*
            var path = Path.GetFullPath(@"../../Database/Database.mdf");
            string sql_path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";
            */
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

        public static void AddStudent(students.Student std)
        {
            string sql = "INSERT INTO Students (fio_stud, g_stud) VALUES (@StudentFio, @StudentGroup)";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@StudentFio", std.FIO_stud);
            cmd.Parameters.AddWithValue("@StudentGroup", std.Group_stud);

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
        public static void UpdateStudent(students.Student std, string id)
        {
            string sql = "UPDATE Students SET fio_stud = @StudentFio, g_stud = @StudentGroup WHERE id = @Studentid";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@Studentid", id);
            cmd.Parameters.AddWithValue("@StudentFio", std.FIO_stud);
            cmd.Parameters.AddWithValue("@StudentGroup", std.Group_stud);


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Успешно обновил!\nСтудент: { std.FIO_stud} \nГруппы: { std.Group_stud}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error not update: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DeleteStudent(string id)
        {
            string sql = "DELETE FROM Students WHERE id = @Studentid";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@Studentid", id);

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
