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

       // string id, fio_stud, g_stud;
        public StudentsUpdate(students.StudentsList prevent)
        {
            InitializeComponent();
            _prevent = prevent;
        }

        private void btnNewlable_and_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пока автор не реализовал Эдинг-Динамичный");
        }

        public void UpdateInfo()
        {
            //TODO...
        }

        private void StudentsUpdate_Load(object sender, EventArgs e)
        {
            var path = Path.GetFullPath(@"../../Database/Database.mdf");
            string sql_path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";
            sqlConnection = new SqlConnection(sql_path);
            sqlConnection.Open();
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
