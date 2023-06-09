﻿using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;

namespace System_College_of_Communication
{
    public partial class main_form : Form
    {
        private SqlConnection sqlConnection = null;

        public main_form()
        {
            InitializeComponent();
        }

        void FillChart()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["base_main"].ConnectionString);
            DataTable dt = new DataTable();
            sqlConnection.Open();
            SqlDataAdapter dp = new SqlDataAdapter("SELECT COUNT(*) as Total, g_stud FROM Students GROUP BY g_stud", sqlConnection);
            dp.Fill(dt);
            chart1.DataSource = dt;
            sqlConnection.Close();

            chart1.Series["Students"].Label = "#PERCENT{P}"; //Отображать значения Y в процентах
            chart1.Series["Students"].LegendText = "#VALX"; //В легенде отображать значения по X


            chart1.Series["Students"].XValueMember = "g_stud";
            chart1.Series["Students"].YValueMembers = "Total";
            chart1.Titles.Add("Количество студентов в группах");
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            FillChart();
        }

        private void open_student_table_Click(object sender, EventArgs e)
        {
          
            students.StudentsList studetns = new students.StudentsList();
            studetns.Show();
        }

        private void open_view_doc_Click(object sender, EventArgs e)
        {
            
            Documents.Doc doc = new Documents.Doc();
            doc.Show();
        }

        private void open_view_rasspisanie_Click(object sender, EventArgs e)
        {
          
            Schedule.Schedule rassp = new Schedule.Schedule();
            rassp.Show();
        }

        private void open_view_concurse_Click(object sender, EventArgs e)
        {
         
            Cool_Hour.Col_Hours col_h = new Cool_Hour.Col_Hours();
            col_h.Show();
        }
    }

    //Код для автозагрузки
     /*
        const string name = "System_College_of_Communication";
        using Microsoft.Win32;
        public bool SetAutorunValue(bool autorun)
        {
            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                if (autorun)
                    reg.SetValue(name, ExePath);
                else
                    reg.DeleteValue(name);
 
                reg.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
     */
}
