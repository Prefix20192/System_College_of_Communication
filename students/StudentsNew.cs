using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_College_of_Communication.students
{
    public partial class StudentsNew : Form
    {
        private readonly StudentsList _pravent;

        public StudentsNew(StudentsList pravent)
        {
            InitializeComponent();
            _pravent = pravent;
        }

        public void Clear()
        {
            fio_stud.Text = group_stud.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(fio_stud.Text.Trim().Length < 3)
            {
                MessageBox.Show("Student name is Empty (> 3).");
                return;
            }            
            if(group_stud.Text.Trim().Length < 3)
            {
                MessageBox.Show("Group name is Empty (> 3).");
                return;
            }
            if (btnAdd.Text == "Успешно")
            {
                btnAdd.Text = "Добавить";
            }
            
            if(btnAdd.Text == "Добавить")
            {
                Student std = new Student(fio_stud.Text.Trim(), group_stud.Text.Trim());
                Database.DbStudent.AddStudent(std);
                Clear();
                btnAdd.Text = "Успешно";
            }
            _pravent.Display();
        }
    }
}
