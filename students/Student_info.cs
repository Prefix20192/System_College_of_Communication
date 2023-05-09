using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_College_of_Communication.students
{
    class Student_info
    {
        public string fio_stud { get; set; }
        public string group_stud { get; set; }
        public string passport_stud { get; set; }
        public string Birthday_stud { get; set; }
        public string phone_stud { get; set; }
        public string Education_stud { get; set; }
        public string address_in_stav { get; set; }
        public string address_pasport { get; set; }
        public string family_status { get; set; }
        public string odn { get; set; }
        public string FIO_mam { get; set; }
        public string FIO_Pap { get; set; }
        public string address { get; set; }
        public string phone_mam { get; set; }   
        public string phone_pap { get; set; }
        public string nationalnost { get; set; }

        public Student_info(string fio_stud, string group_stud, string passport_stud, string birthday_stud, string phone_stud, string education_stud, string address_in_stav, string address_pasport, string family_status, string odn, string fIO_mam, string fIO_Pap, string address, string phone_mam, string phone_pap, string nationalnost)
        {
            this.fio_stud = fio_stud;
            this.group_stud = group_stud;
            this.passport_stud = passport_stud;
            Birthday_stud = birthday_stud;
            this.phone_stud = phone_stud;
            Education_stud = education_stud;
            this.address_in_stav = address_in_stav;
            this.address_pasport = address_pasport;
            this.family_status = family_status;
            this.odn = odn;
            FIO_mam = fIO_mam;
            FIO_Pap = fIO_Pap;
            this.address = address;
            this.phone_mam = phone_mam;
            this.phone_pap = phone_pap;
            this.nationalnost = nationalnost;
        }
    }
}
