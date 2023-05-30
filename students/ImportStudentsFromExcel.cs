using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;
using System.Configuration;

namespace System_College_of_Communication.students
{
    public partial class ImportStudentsFromExcel : Form
    {

        private SqlConnection sqlConnection = null;
        public ImportStudentsFromExcel()
        {
            InitializeComponent();
        }

        private void ImportStudentsFromExcel_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["base_main"].ConnectionString);
            sqlConnection.Open();
        }

        private void choSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[choSheet.SelectedItem.ToString()];
            //dataGridView1.DataSource = dt;
            if(dt != null)
            {
                List<import_student_info_excel> students = new List<import_student_info_excel>();
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    import_student_info_excel studentInfo = new import_student_info_excel();
                    studentInfo.passport_stud = dt.Rows[i]["Паспорт студента"].ToString();
                    studentInfo.Birthday_stud = dt.Rows[i]["День рождения"].ToString();
                    studentInfo.phone_stud = dt.Rows[i]["Телефон студента"].ToString();
                    studentInfo.Education_stud = dt.Rows[i]["Образование"].ToString();
                    studentInfo.address_in_stav = dt.Rows[i]["Адресс проживание в Ставрополе"].ToString();
                    studentInfo.address_pasport = dt.Rows[i]["Адресс проживание в паспорте"].ToString();
                    studentInfo.family_status = dt.Rows[i]["Семейный статус"].ToString();
                    studentInfo.odn = dt.Rows[i]["Состояние в ОДН"].ToString();
                    studentInfo.FIO_mam = dt.Rows[i]["ФИО Мамы"].ToString();
                    studentInfo.FIO_Pap = dt.Rows[i]["ФИО Папы"].ToString();
                    studentInfo.address = dt.Rows[i]["Адресс проживание родителей"].ToString();
                    studentInfo.phone_mam = dt.Rows[i]["Телефон мамы"].ToString();
                    studentInfo.phone_pap = dt.Rows[i]["Телефон папы"].ToString();
                    studentInfo.nationalnost = dt.Rows[i]["Национальность"].ToString();
                    studentInfo.stud_id = dt.Rows[i]["Номер студента"].ToString();
                    students.Add(studentInfo);
                }
                dataGridView1.DataSource = students;
            }
        }

        DataTableCollection tableCollection;

        private void btnBrows_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog() { Filter="Excel 97-2007 Workbook|*.xls|Excel Workbook|*.xlsx"})
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = openFileDialog.FileName;
                    using(var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using(IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true}
                            });
                            tableCollection = result.Tables;
                            choSheet.Items.Clear();
                            foreach(DataTable table in tableCollection)
                            {
                                choSheet.Items.Add(table.TableName);
                            }
                        }
                    }
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                DapperPlusManager.Entity<import_student_info_excel>().Table("Student_info");
                List<import_student_info_excel> students = dataGridView1.DataSource as List<import_student_info_excel>;
                if(students != null)
                {
                    sqlConnection.BulkInsert(students);
                }
                MessageBox.Show("Успешно импортировал в базу данных");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
