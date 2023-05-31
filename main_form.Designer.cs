
namespace System_College_of_Communication
{
    partial class main_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.open_student_table = new System.Windows.Forms.Button();
            this.open_view_concurse = new System.Windows.Forms.Button();
            this.open_view_doc = new System.Windows.Forms.Button();
            this.open_view_rasspisanie = new System.Windows.Forms.Button();
            this.view_other = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // open_student_table
            // 
            this.open_student_table.Location = new System.Drawing.Point(71, 29);
            this.open_student_table.Name = "open_student_table";
            this.open_student_table.Size = new System.Drawing.Size(119, 35);
            this.open_student_table.TabIndex = 0;
            this.open_student_table.Text = "Список студентов";
            this.open_student_table.UseVisualStyleBackColor = true;
            this.open_student_table.Click += new System.EventHandler(this.open_student_table_Click);
            // 
            // open_view_concurse
            // 
            this.open_view_concurse.Location = new System.Drawing.Point(446, 29);
            this.open_view_concurse.Name = "open_view_concurse";
            this.open_view_concurse.Size = new System.Drawing.Size(119, 35);
            this.open_view_concurse.TabIndex = 1;
            this.open_view_concurse.Text = "Классные часы";
            this.open_view_concurse.UseVisualStyleBackColor = true;
            this.open_view_concurse.Click += new System.EventHandler(this.open_view_concurse_Click);
            // 
            // open_view_doc
            // 
            this.open_view_doc.Location = new System.Drawing.Point(196, 29);
            this.open_view_doc.Name = "open_view_doc";
            this.open_view_doc.Size = new System.Drawing.Size(119, 35);
            this.open_view_doc.TabIndex = 2;
            this.open_view_doc.Text = "Личный документы";
            this.open_view_doc.UseVisualStyleBackColor = true;
            this.open_view_doc.Click += new System.EventHandler(this.open_view_doc_Click);
            // 
            // open_view_rasspisanie
            // 
            this.open_view_rasspisanie.Location = new System.Drawing.Point(321, 29);
            this.open_view_rasspisanie.Name = "open_view_rasspisanie";
            this.open_view_rasspisanie.Size = new System.Drawing.Size(119, 35);
            this.open_view_rasspisanie.TabIndex = 3;
            this.open_view_rasspisanie.Text = "Рассписание всех групп";
            this.open_view_rasspisanie.UseVisualStyleBackColor = true;
            this.open_view_rasspisanie.Click += new System.EventHandler(this.open_view_rasspisanie_Click);
            // 
            // view_other
            // 
            this.view_other.Location = new System.Drawing.Point(571, 29);
            this.view_other.Name = "view_other";
            this.view_other.Size = new System.Drawing.Size(119, 35);
            this.view_other.TabIndex = 4;
            this.view_other.Text = "Остальное";
            this.view_other.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.open_view_rasspisanie);
            this.panel1.Controls.Add(this.view_other);
            this.panel1.Controls.Add(this.open_student_table);
            this.panel1.Controls.Add(this.open_view_concurse);
            this.panel1.Controls.Add(this.open_view_doc);
            this.panel1.Location = new System.Drawing.Point(3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 389);
            this.panel1.TabIndex = 5;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(826, 382);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main_form";
            this.Text = "Руководство для классных руководителей";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button open_student_table;
        private System.Windows.Forms.Button open_view_concurse;
        private System.Windows.Forms.Button open_view_doc;
        private System.Windows.Forms.Button open_view_rasspisanie;
        private System.Windows.Forms.Button view_other;
        private System.Windows.Forms.Panel panel1;
    }
}

