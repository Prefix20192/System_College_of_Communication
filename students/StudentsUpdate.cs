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
using System.Collections.ObjectModel;

namespace System_College_of_Communication.students
{
    public partial class StudentsUpdate : Form
    {
        private SqlConnection sqlConnection = null;

        private string id;

        public StudentsUpdate(string std_id)
        {
            InitializeComponent();
            id = std_id;
        }

        private void btnNewlable_and_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пока автор не реализовал Эдинг-Динамичный");
        }

        private void StudentsUpdate_Load(object sender, EventArgs e)
        {
            var path = Path.GetFullPath(@"../../Database/Database.mdf");
            string sql_path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";
            sqlConnection = new SqlConnection(sql_path);
            sqlConnection.Open();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
   
            string sql = "UPDATE Students SET fio_stud = @StudentFio, g_stud = @StudentGroup WHERE id = @Studentid;" +
                "INSERT INTO Student_info (stud_id, family_id, birthday, phone, pasport, education, address_in_stav, propiska, family_status, Accounting_of_ODN) VALUES(@Studentid, @f_id, @StudentBirhtday, @StudPhone, @StudPassport, @StudEducation, @StudAddress_in_stav, @StudPropiska, @StudFamily_status, @StudODN);" +
                "INSERT INTO family (fio_mam, fio_pap, phone_mam, phone_pap, address, national) VALUES(@fio_mam, @fio_pap, @phone_mam, @phone_pap, @adress, @nation)";
            SqlConnection con = Database.DbStudent.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@Studentid", id);
            cmd.Parameters.AddWithValue("@StudentFio", txtFio_stud.Text);
            cmd.Parameters.AddWithValue("@StudentGroup", txtgroup_stud.Text);

            cmd.Parameters.AddWithValue("@StudentBirhtday", txtBirthday_stud.Text);
            cmd.Parameters.AddWithValue("@StudPhone", txtphone_stud.Text);
            cmd.Parameters.AddWithValue("@StudPassport", txt_passport.Text);
            cmd.Parameters.AddWithValue("@StudEducation", txtEducation_stud.Text);
            cmd.Parameters.AddWithValue("@StudAddress_in_stav", txt_address_in_stav.Text);
            cmd.Parameters.AddWithValue("@StudPropiska", txt_address_pasport.Text);
            cmd.Parameters.AddWithValue("@StudFamily_status", txt_family_status.Text);
            cmd.Parameters.AddWithValue("@StudODN", txt_odn.Text);

            cmd.Parameters.AddWithValue("@fio_mam", txtFIO_mam.Text);
            cmd.Parameters.AddWithValue("@fio_pap", txt_FIO_Pap.Text);
            cmd.Parameters.AddWithValue("@phone_mam", txt_phone_mam.Text);
            cmd.Parameters.AddWithValue("@phone_pap", txt_phone_pap.Text);
            cmd.Parameters.AddWithValue("@adress", txt_address.Text);
            cmd.Parameters.AddWithValue("@nation", nationalnost.Text);

            

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Успешно обновил!\nСтудент: { txtFio_stud.Text} \nГруппы: { txtgroup_stud.Text}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error not update: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }

        private void импортToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
