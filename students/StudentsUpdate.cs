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
            for(int i = 0; i < array.Length; i++)
            {
                
            }
        }

        public void Clear(string[] arr)
        {
            MessageBox.Show("\n" + arr);
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
            /*
           new Students = {
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
            };*/


            //UpdateInfo(Students);
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
