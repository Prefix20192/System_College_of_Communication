
namespace System_College_of_Communication.students
{
    partial class StudentInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stud_name = new System.Windows.Forms.Label();
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtStudentImage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFIO_stud = new System.Windows.Forms.TextBox();
            this.txtGroup_stud = new System.Windows.Forms.TextBox();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFamily_status = new System.Windows.Forms.TextBox();
            this.txtPropiska = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdress_in_stav = new System.Windows.Forms.TextBox();
            this.txtEducation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nationalnost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_address_family = new System.Windows.Forms.TextBox();
            this.txtPhone_pap = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPhone_mam = new System.Windows.Forms.TextBox();
            this.txtFio_pap = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFio_mam = new System.Windows.Forms.TextBox();
            this.txtODN = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(400, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Информация о студенте:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.stud_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 73);
            this.panel1.TabIndex = 1;
            // 
            // stud_name
            // 
            this.stud_name.AutoSize = true;
            this.stud_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stud_name.Location = new System.Drawing.Point(439, 29);
            this.stud_name.Name = "stud_name";
            this.stud_name.Size = new System.Drawing.Size(74, 29);
            this.stud_name.TabIndex = 1;
            this.stud_name.Text = "Prefix";
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.Image = global::System_College_of_Communication.Properties.Resources.no_avatar;
            this.pictureBoxStudent.Location = new System.Drawing.Point(477, 89);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(125, 128);
            this.pictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStudent.TabIndex = 2;
            this.pictureBoxStudent.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(464, 250);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Загрузить";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(545, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtStudentImage
            // 
            this.txtStudentImage.Location = new System.Drawing.Point(477, 224);
            this.txtStudentImage.Name = "txtStudentImage";
            this.txtStudentImage.ReadOnly = true;
            this.txtStudentImage.Size = new System.Drawing.Size(125, 20);
            this.txtStudentImage.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Группа";
            // 
            // txtFIO_stud
            // 
            this.txtFIO_stud.Location = new System.Drawing.Point(205, 301);
            this.txtFIO_stud.Name = "txtFIO_stud";
            this.txtFIO_stud.ReadOnly = true;
            this.txtFIO_stud.Size = new System.Drawing.Size(288, 20);
            this.txtFIO_stud.TabIndex = 8;
            // 
            // txtGroup_stud
            // 
            this.txtGroup_stud.Location = new System.Drawing.Point(205, 327);
            this.txtGroup_stud.Name = "txtGroup_stud";
            this.txtGroup_stud.ReadOnly = true;
            this.txtGroup_stud.Size = new System.Drawing.Size(288, 20);
            this.txtGroup_stud.TabIndex = 9;
            // 
            // txtPassport
            // 
            this.txtPassport.Location = new System.Drawing.Point(205, 379);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.ReadOnly = true;
            this.txtPassport.Size = new System.Drawing.Size(288, 20);
            this.txtPassport.TabIndex = 13;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(205, 353);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.ReadOnly = true;
            this.txtBirthday.Size = new System.Drawing.Size(288, 20);
            this.txtBirthday.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Паспорт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Год рождения";
            // 
            // txtFamily_status
            // 
            this.txtFamily_status.Location = new System.Drawing.Point(702, 304);
            this.txtFamily_status.Name = "txtFamily_status";
            this.txtFamily_status.ReadOnly = true;
            this.txtFamily_status.Size = new System.Drawing.Size(315, 20);
            this.txtFamily_status.TabIndex = 21;
            // 
            // txtPropiska
            // 
            this.txtPropiska.Location = new System.Drawing.Point(205, 457);
            this.txtPropiska.Name = "txtPropiska";
            this.txtPropiska.ReadOnly = true;
            this.txtPropiska.Size = new System.Drawing.Size(288, 20);
            this.txtPropiska.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(600, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Семейный статус";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Место проживание (как в паспорте)";
            // 
            // txtAdress_in_stav
            // 
            this.txtAdress_in_stav.Location = new System.Drawing.Point(205, 431);
            this.txtAdress_in_stav.Name = "txtAdress_in_stav";
            this.txtAdress_in_stav.ReadOnly = true;
            this.txtAdress_in_stav.Size = new System.Drawing.Size(288, 20);
            this.txtAdress_in_stav.TabIndex = 17;
            // 
            // txtEducation
            // 
            this.txtEducation.Location = new System.Drawing.Point(205, 405);
            this.txtEducation.Name = "txtEducation";
            this.txtEducation.ReadOnly = true;
            this.txtEducation.Size = new System.Drawing.Size(288, 20);
            this.txtEducation.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Адрес проживание в Ставрополе";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Образование";
            // 
            // txt_nationalnost
            // 
            this.txt_nationalnost.Location = new System.Drawing.Point(702, 460);
            this.txt_nationalnost.Name = "txt_nationalnost";
            this.txt_nationalnost.ReadOnly = true;
            this.txt_nationalnost.Size = new System.Drawing.Size(315, 20);
            this.txt_nationalnost.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(604, 467);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Национальность";
            // 
            // txt_address_family
            // 
            this.txt_address_family.Location = new System.Drawing.Point(702, 434);
            this.txt_address_family.Name = "txt_address_family";
            this.txt_address_family.ReadOnly = true;
            this.txt_address_family.Size = new System.Drawing.Size(315, 20);
            this.txt_address_family.TabIndex = 33;
            // 
            // txtPhone_pap
            // 
            this.txtPhone_pap.Location = new System.Drawing.Point(702, 408);
            this.txtPhone_pap.Name = "txtPhone_pap";
            this.txtPhone_pap.ReadOnly = true;
            this.txtPhone_pap.Size = new System.Drawing.Size(315, 20);
            this.txtPhone_pap.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(549, 437);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Адресс где живут родители";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(613, 411);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Телефон Папы";
            // 
            // txtPhone_mam
            // 
            this.txtPhone_mam.Location = new System.Drawing.Point(702, 382);
            this.txtPhone_mam.Name = "txtPhone_mam";
            this.txtPhone_mam.ReadOnly = true;
            this.txtPhone_mam.Size = new System.Drawing.Size(315, 20);
            this.txtPhone_mam.TabIndex = 29;
            // 
            // txtFio_pap
            // 
            this.txtFio_pap.Location = new System.Drawing.Point(702, 356);
            this.txtFio_pap.Name = "txtFio_pap";
            this.txtFio_pap.ReadOnly = true;
            this.txtFio_pap.Size = new System.Drawing.Size(315, 20);
            this.txtFio_pap.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(617, 385);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Телефон Мамы";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(638, 359);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Фио Отца";
            // 
            // txtFio_mam
            // 
            this.txtFio_mam.Location = new System.Drawing.Point(702, 330);
            this.txtFio_mam.Name = "txtFio_mam";
            this.txtFio_mam.ReadOnly = true;
            this.txtFio_mam.Size = new System.Drawing.Size(315, 20);
            this.txtFio_mam.TabIndex = 25;
            // 
            // txtODN
            // 
            this.txtODN.Location = new System.Drawing.Point(205, 483);
            this.txtODN.Name = "txtODN";
            this.txtODN.ReadOnly = true;
            this.txtODN.Size = new System.Drawing.Size(288, 20);
            this.txtODN.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(628, 333);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "ФИО Матери";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(121, 486);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Состоит в ОДН";
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1029, 553);
            this.Controls.Add(this.txt_nationalnost);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_address_family);
            this.Controls.Add(this.txtPhone_pap);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPhone_mam);
            this.Controls.Add(this.txtFio_pap);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtFio_mam);
            this.Controls.Add(this.txtODN);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtFamily_status);
            this.Controls.Add(this.txtPropiska);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAdress_in_stav);
            this.Controls.Add(this.txtEducation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPassport);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGroup_stud);
            this.Controls.Add(this.txtFIO_stud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStudentImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pictureBoxStudent);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "StudentInfo";
            this.Text = "Информация о студенте";
            this.Load += new System.EventHandler(this.StudentInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label stud_name;
        private System.Windows.Forms.PictureBox pictureBoxStudent;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtStudentImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFIO_stud;
        private System.Windows.Forms.TextBox txtGroup_stud;
        private System.Windows.Forms.TextBox txtPassport;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFamily_status;
        private System.Windows.Forms.TextBox txtPropiska;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdress_in_stav;
        private System.Windows.Forms.TextBox txtEducation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nationalnost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_address_family;
        private System.Windows.Forms.TextBox txtPhone_pap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPhone_mam;
        private System.Windows.Forms.TextBox txtFio_pap;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFio_mam;
        private System.Windows.Forms.TextBox txtODN;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}