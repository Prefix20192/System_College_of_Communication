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

        private readonly students.StudentsList _prevent;

        public StudentsUpdate(students.StudentsList prevent)
        {
            InitializeComponent();
            _prevent = prevent;
        }

        private void btnNewlable_and_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пока автор не реализовал Эдинг-Динамичный");
        }

        public void UpdateInfo(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                File.WriteAllLines(@"C:\TextFile.txt", array);
            }
            /*
            string sql = "UPDATE Student_info SET fio_stud = @StudentFio, g_stud = @StudentGroup WHERE id = @Studentid";
            SqlConnection con = Database.DbStudent.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
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
            */
        }

        public void Clear(string[] arr)
        {
            //MessageBox.Show("\n" + arr);
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
            
            string[] Students_info = {
                txtFio_stud.Text,
                txtgroup_stud.Text,
                txt_passport.Text,
                txtBirthday_stud.Text,
                txtphone_stud.Text,
                txtEducation_stud.Text,
                txt_address_in_stav.Text,
                txt_address_pasport.Text,
                txt_family_status.Text,
                txt_odn.Text,
                txtFIO_mam.Text,
                txt_FIO_Pap.Text,
                txt_address.Text,
                txt_phone_mam.Text,
                txt_phone_pap.Text,
                txt_address.Text,
                nationalnost.Text
            };


            UpdateInfo(Students_info);
            
        }

        private void импортToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Button
        /*
            if(btn.Text == "Обновить")
            {
                Student std = new Student(fio_stud.Text.Trim(), group_stud.Text.Trim());
                Database.DbStudent.UpdateStudent(std, id);
                Clear();
                btnAdd.Text = "Успешно";
            }
         
         */
    }
}
