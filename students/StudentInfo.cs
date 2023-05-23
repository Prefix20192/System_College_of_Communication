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

namespace System_College_of_Communication.students
{
    public partial class StudentInfo : Form
    {
        private readonly StudentsList _parent;

        public string id;

        private SqlConnection sqlConnection = null;

        public StudentInfo(StudentsList parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["base_main"].ConnectionString);
            sqlConnection.Open();
            //Выводим логин пользователя в lable
            string sql_select = $"SELECT * FROM Students WHERE id = {id}";
            SqlCommand command = new SqlCommand(sql_select, sqlConnection);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                stud_name.Text = reader["fio_stud"].ToString();
            }
            reader.Close();
        }
    }
}
