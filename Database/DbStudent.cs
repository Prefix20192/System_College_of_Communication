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
        public static void UpdateStudent(students.Student_info std, string id)
        {
            string sql_select = $"SELECT * FROM Student_info WHERE stud_id = {id}";
            SqlConnection con = GetConnection();
            SqlCommand command = new SqlCommand(sql_select, con);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                string sql = "UPDATE Students SET fio_stud = @StudentFio, g_stud = @StudentGroup WHERE id = @Studentid;" +
                        "UPDATE Student_info SET birthday = @StudBirthday, phone = @StudPhone, passport = @passport, education = @StudEducation, address_in_stav = @StudAddress_In_Stav, propiska = @StudPropiska, family_status = @StudFamilyStatus, Accounting_of_ODN = @StudODN, Fio_mam = @Fio_mam, fio_pap = @fio_pap, phone_mam = @PhoneMam, phone_pap = @Phone_pap, address_family = @AddresFamily, nationalnost = @Notional WHERE stud_id = @Studentid";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Studentid", id);
                cmd.Parameters.AddWithValue("@StudentFio", std.fio_stud);
                cmd.Parameters.AddWithValue("@StudentGroup", std.group_stud);

                cmd.Parameters.AddWithValue("@StudBirthday", std.Birthday_stud);
                cmd.Parameters.AddWithValue("@StudPhone", std.passport_stud);
                cmd.Parameters.AddWithValue("@passport", std.passport_stud);
                cmd.Parameters.AddWithValue("@StudEducation", std.Education_stud);
                cmd.Parameters.AddWithValue("@StudAddress_In_Stav", std.address_in_stav);
                cmd.Parameters.AddWithValue("@StudPropiska", std.address_pasport);
                cmd.Parameters.AddWithValue("@StudFamilyStatus", std.family_status);
                cmd.Parameters.AddWithValue("@StudODN", std.odn);
                cmd.Parameters.AddWithValue("@Fio_mam", std.FIO_mam);
                cmd.Parameters.AddWithValue("@fio_pap", std.FIO_Pap);
                cmd.Parameters.AddWithValue("@PhoneMam", std.phone_mam);
                cmd.Parameters.AddWithValue("@Phone_pap", std.phone_pap);
                cmd.Parameters.AddWithValue("@AddresFamily", std.address);
                cmd.Parameters.AddWithValue("@Notional", std.nationalnost);

                reader.Close();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Успешно обновил!\nСтудент: { std.fio_stud} \nГруппы: { std.group_stud}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error not update: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            else
            {
                string sql = "INSERT INTO Student_info (stud_id, birthday, phone, pasport, education, address_in_stav, propiska, family_status, Accounting_of_ODN, Fio_mam, fio_pap, phone_mam, phone_pap, address_family, nationalnost) VALUES (@Studentid,@StudBirthday,@StudPhone,@passport,@StudEducation,@StudAddress_In_Stav,@StudPropiska,@StudFamilyStatus,@StudODN,@Fio_mam,@fio_pap,@PhoneMam,@Phone_pap,@AddresFamily,@Notional);" +
                    "UPDATE Students SET fio_stud = @StudentFio, g_stud = @StudentGroup WHERE id = @Studentid;";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Studentid", id);
                cmd.Parameters.AddWithValue("@StudentFio", std.fio_stud);
                cmd.Parameters.AddWithValue("@StudentGroup", std.group_stud);

                cmd.Parameters.AddWithValue("@StudBirthday", std.Birthday_stud);
                cmd.Parameters.AddWithValue("@StudPhone", std.passport_stud);
                cmd.Parameters.AddWithValue("@passport", std.passport_stud);
                cmd.Parameters.AddWithValue("@StudEducation", std.Education_stud);
                cmd.Parameters.AddWithValue("@StudAddress_In_Stav", std.address_in_stav);
                cmd.Parameters.AddWithValue("@StudPropiska", std.address_pasport);
                cmd.Parameters.AddWithValue("@StudFamilyStatus", std.family_status);
                cmd.Parameters.AddWithValue("@StudODN", std.odn);
                cmd.Parameters.AddWithValue("@Fio_mam", std.FIO_mam);
                cmd.Parameters.AddWithValue("@fio_pap", std.FIO_Pap);
                cmd.Parameters.AddWithValue("@PhoneMam", std.phone_mam);
                cmd.Parameters.AddWithValue("@Phone_pap", std.phone_pap);
                cmd.Parameters.AddWithValue("@AddresFamily", std.address);
                cmd.Parameters.AddWithValue("@Notional", std.nationalnost);

                reader.Close();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Успешно добавил данные!\nСтудента: { std.fio_stud} \nГруппы: { std.group_stud}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error not update: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
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
