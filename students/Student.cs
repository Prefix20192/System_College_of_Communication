using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_College_of_Communication.students
{
    class Student
    {
        public string FIO_stud { get; set; }
        public string Group_stud { get; set; }

        public Student(string fIO_stud, string group_stud)
        {
            FIO_stud = fIO_stud;
            Group_stud = group_stud;
        }
    }
}
