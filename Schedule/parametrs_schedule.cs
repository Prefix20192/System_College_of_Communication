using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_College_of_Communication.Schedule
{
    class parametrs_schedule
    {
        public string g_name { get; set; }
        public string predmet { get; set; }
        public string auditori { get; set; }
        public string time_work { get; set; }
        public string prepod { get; set; }
        public string Day_week { get; set; }

        public parametrs_schedule(string g_name, string predmet, string auditori, string time_work, string prepod, string Day_week)
        {
            this.g_name = g_name;
            this.predmet = predmet;
            this.auditori = auditori;
            this.time_work = time_work;
            this.prepod = prepod;
            this.Day_week = Day_week;
        }
    }
}
