using System;
using System.Windows.Forms;

namespace System_College_of_Communication.students
{
    public partial class StudentsUpdate : Form
    {
        private readonly StudentsList _parent;
        public string id, fio_stud, group_stud, passport_stud,
            Birthday_stud, phone_stud, Education_stud,
            address_in_stav, address_pasport, family_status,
            odn, FIO_mam, FIO_Pap, address, phone_mam, phone_pap;

        public StudentsUpdate(StudentsList parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void btnNewlable_and_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пока автор не реализовал Эдинг-Динамичный");
        }

        public void Clear() 
        {
            txtFio_stud.Text = txtgroup_stud.Text = txt_passport.Text = txtBirthday_stud.Text =
            txtphone_stud.Text = txtEducation_stud.Text = txt_address_in_stav.Text = txt_address_pasport.Text =
            txt_family_status.Text = txt_odn.Text = txtFIO_mam.Text = txt_FIO_Pap.Text = txt_address.Text =
            txt_phone_mam.Text = txt_phone_pap.Text = string.Empty;
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
