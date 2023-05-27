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
using System.IO;
using System.Drawing.Imaging;

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
            string sql_select = $"SELECT Students.id as id, Students.fio_stud as fio_stud, Students.g_stud as stud_g, Students.avatar as avatar, Student_info.birthday as birthday, Student_info.phone as phone, Student_info.pasport as pasport, Student_info.education as education, Student_info.address_in_stav as address_in_stav, Student_info.propiska as propiska, Student_info.family_status as family_status, Student_info.Accounting_of_ODN as odn, Student_info.Fio_mam as fio_mam, Student_info.fio_pap as fio_pap, Student_info.phone_mam as phone_mam, Student_info.phone_pap as phone_pap, Student_info.address_family as address_family, Student_info.nationalnost as nationalnost FROM Students LEFT JOIN Student_info ON Students.id = Student_info.stud_id WHERE Students.id = {id}";
            SqlCommand command = new SqlCommand(sql_select, sqlConnection);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if(reader["avatar"] == DBNull.Value)
                {
                    pictureBoxStudent.Image = Properties.Resources.no_avatar;
                }
                else
                {
                    //Выводи аватарку
                    byte[] img_arr1 = (byte[])reader["avatar"];
                    MemoryStream ms1 = new MemoryStream(img_arr1);
                    ms1.Seek(0, SeekOrigin.Begin);
                    pictureBoxStudent.Image = Image.FromStream(ms1);
                }
                //Заполняем инфу
                stud_name.Text = reader["fio_stud"].ToString();
                txtFIO_stud.Text = reader["fio_stud"].ToString();
                txtGroup_stud.Text = reader["stud_g"].ToString();
                txtBirthday.Text = reader["birthday"].ToString();
                txtPassport.Text = reader["pasport"].ToString();
                txtEducation.Text = reader["education"].ToString();
                txtAdress_in_stav.Text = reader["address_in_stav"].ToString();
                txtPropiska.Text = reader["propiska"].ToString();
                txtFamily_status.Text = reader["family_status"].ToString();
                txtODN.Text = reader["odn"].ToString();
                txtFio_mam.Text = reader["fio_mam"].ToString();
                txtFio_pap.Text = reader["fio_pap"].ToString();
                txtPhone_mam.Text = reader["phone_mam"].ToString();
                txtPhone_pap.Text = reader["phone_pap"].ToString();
                txt_address_family.Text = reader["address_family"].ToString();
                txt_nationalnost.Text = reader["nationalnost"].ToString();
            }
            reader.Close();
            sqlConnection.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Stream myStream = null;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.bmp)|*.jpg; *.jpeg; *.bmp";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        string FileName = openFileDialog.FileName;
                        txtStudentImage.Text = FileName;
                        if (myStream.Length > 512000)
                        {
                            MessageBox.Show("File size limit exceed");
                        }
                        else
                        {
                            pictureBoxStudent.Load(FileName);
                            pictureBoxStudent.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. error: " + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            pictureBoxStudent.Image.Save(stream, ImageFormat.Jpeg);

            byte[] pic = stream.ToArray();
            try
            {
                sqlConnection.Open();
                string sql_select = "UPDATE Students SET avatar = @Image WHERE id = @StudentId";
                SqlCommand cmd = new SqlCommand(sql_select, sqlConnection);

                cmd.Parameters.AddWithValue("@StudentId", id);
                cmd.Parameters.AddWithValue("@Image", pic);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Обновил данные!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
