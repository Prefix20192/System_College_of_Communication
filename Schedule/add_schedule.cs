using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_College_of_Communication.Schedule
{
    public partial class add_schedule : Form
    {

        private readonly Schedule _parent;
        public string id, g_name, predmet, auditori, time_work, prepod, day_week;

        public add_schedule(Schedule parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void Clear()
        {
            txtPredmet.Text = txtGroup.Text = txtFioPrepod.Text = txttimework.Text = txtauditori.Text = string.Empty;
        }

        public void Update_Schedule()
        {
            txtPredmet.Text = predmet;
            txtGroup.Text = g_name;
            txtFioPrepod.Text = prepod;
            txttimework.Text = time_work;
            txtauditori.Text = auditori;
            txtDay_week.Text = day_week;
            label6.Text = "Редактировать рассписание";
            btnSave.Text = "Обновить";
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if(btnSave.Text == "Добавить")
            {
                parametrs_schedule schedule = new parametrs_schedule(txtPredmet.Text.Trim(), txtGroup.Text.Trim(), txtFioPrepod.Text.Trim(), txttimework.Text.Trim(), txtauditori.Text.Trim(), txtDay_week.Text.Trim());
                Database.DbSchedule.AddSchedule(schedule);
                _parent.Display();
            }
            if(btnSave.Text == "Обновить")
            {
                parametrs_schedule schedule = new parametrs_schedule(txtPredmet.Text.Trim(), txtGroup.Text.Trim(), txtFioPrepod.Text.Trim(), txttimework.Text.Trim(), txtauditori.Text.Trim(), txtDay_week.Text.Trim());
                Database.DbSchedule.UpdateSchedule(schedule, id);
                _parent.Display();
            }
        }
    }
}
