using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace System_College_of_Communication.students
{
    public partial class StudentsUpdate : Form
    {
        private readonly StudentsList _parent;
        public string id, fio_stud, group_stud, passport_stud,
            Birthday_stud, phone_stud, Education_stud,
            address_in_stav, address_pasport, family_status,
            odn, FIO_mam, FIO_Pap, address, phone_mam, phone_pap;

        public static string connectString = ConfigurationManager.ConnectionStrings["base_main"].ConnectionString;

        private SqlConnection myConnection;

        public StudentsUpdate(StudentsList parent)
        {
            InitializeComponent();
            _parent = parent;
        }


        private void btnNewlable_and_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пока автор не реализовал Эдинг-Динамичный");
        }


        public void UpdateInfo()
        {
            //Основное
            txtFio_stud.Text = fio_stud;
            txtgroup_stud.Text = group_stud;
            txt_passport.Text = passport_stud;
            txtBirthday_stud.Text = Birthday_stud;
            txtphone_stud.Text = phone_stud;
            txtEducation_stud.Text = Education_stud;
            txt_address_in_stav.Text = address_in_stav;
            txt_address_pasport.Text = address_pasport;

            //Дополнительная информация
            txt_family_status.Text = family_status;
            txt_odn.Text = odn;

            //Сведения о родителях
            txtFIO_mam.Text = FIO_mam;
            txt_FIO_Pap.Text = FIO_Pap;
            txt_address.Text = address;
            txt_phone_mam.Text = phone_mam;
            txt_phone_pap.Text = phone_pap;

        }

        private void StudentsUpdate_Load(object sender, EventArgs e)
        {
            myConnection = new SqlConnection(connectString);

            myConnection.Open();
            string sql_select = "SELECT Student_info.stud_id as id, Students.fio_stud as fio, Students.g_stud as g_stud, Student_info.birthday as birthday, Student_info.phone as phone, Student_info.pasport as pasport, Student_info.education as education, Student_info.address_in_stav as address_in_stav, Student_info.propiska as propiska, Student_info.family_status as family_status, Student_info.Accounting_of_ODN as ODN, Student_info.Fio_mam as Fio_mam, Student_info.fio_pap as fio_pap, Student_info.phone_mam as phone_mam, Student_info.phone_pap as phone_pap, Student_info.address_family as address_family, Student_info.nationalnost as nationalnost FROM Students LEFT JOIN Student_info ON Students.id = Student_info.stud_id WHERE Student_info.stud_id = "+id+"";
            SqlCommand command = new SqlCommand(sql_select, myConnection);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtFio_stud.Text = reader["fio"].ToString();
                txtgroup_stud.Text = (string)reader["g_stud"];
                txt_passport.Text = reader["pasport"].ToString();
                txtBirthday_stud.Text = reader["birthday"].ToString();
                txtphone_stud.Text = (string)reader["phone"];
                txtEducation_stud.Text = (string)reader["education"];
                txt_address_in_stav.Text = (string)reader["address_in_stav"];
                txt_address_pasport.Text = (string)reader["propiska"];

                //Дополнительная информация
                txt_family_status.Text = (string)reader["family_status"];
                txt_odn.Text = (string)reader["ODN"];

                //Сведения о родителях
                txtFIO_mam.Text = (string)reader["Fio_mam"];
                txt_FIO_Pap.Text = (string)reader["fio_pap"];
                txt_address.Text = (string)reader["address_family"];
                txt_phone_mam.Text = (string)reader["phone_mam"];
                txt_phone_pap.Text = (string)reader["phone_pap"];
            }
            else
            {
                myConnection.Close();
                MessageBox.Show("ERROR: Я вас не нашел в базе данных :(\nПроверьте правильность ввода данных! + ");
                reader.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student_info std_info = new Student_info(txtFio_stud.Text.Trim(), txtgroup_stud.Text.Trim(), 
                                                        txt_passport.Text.Trim(), txtBirthday_stud.Text.Trim(), txtphone_stud.Text.Trim(),
                                                        txtEducation_stud.Text.Trim(), txt_address_in_stav.Text.Trim(), txt_address_pasport.Text.Trim(),
                                                        txt_family_status.Text.Trim(), txt_odn.Text.Trim(), txtFIO_mam.Text.Trim(), txt_FIO_Pap.Text.Trim(),
                                                        txt_address.Text.Trim(), txt_phone_mam.Text.Trim(), txt_phone_pap.Text.Trim(), "Русский");
            Database.DbStudent.UpdateStudent(std_info, id);
            _parent.Display();
        }
    }
}
