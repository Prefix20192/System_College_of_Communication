using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_College_of_Communication
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void open_student_table_Click(object sender, EventArgs e)
        {
            this.Hide();
            students.StudentsList studetns = new students.StudentsList();
            studetns.Show();
        }

        private void open_view_doc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Documents.Doc doc = new Documents.Doc();
            doc.Show();
        }

        private void open_view_rasspisanie_Click(object sender, EventArgs e)
        {
            this.Hide();
            Schedule.Schedule rassp = new Schedule.Schedule();
            rassp.Show();
        }

        private void open_view_concurse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cool_Hour.Col_Hours col_h = new Cool_Hour.Col_Hours();
            col_h.Show();
        }
    }

    //Код для автозагрузки
     /*
        const string name = "MyTestApplication";
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
