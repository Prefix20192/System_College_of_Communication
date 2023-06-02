
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.open_student_table = new System.Windows.Forms.Button();
            this.open_view_concurse = new System.Windows.Forms.Button();
            this.open_view_doc = new System.Windows.Forms.Button();
            this.open_view_rasspisanie = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // open_student_table
            // 
            this.open_student_table.Location = new System.Drawing.Point(149, 25);
            this.open_student_table.Name = "open_student_table";
            this.open_student_table.Size = new System.Drawing.Size(119, 35);
            this.open_student_table.TabIndex = 0;
            this.open_student_table.Text = "Список студентов";
            this.open_student_table.UseVisualStyleBackColor = true;
            this.open_student_table.Click += new System.EventHandler(this.open_student_table_Click);
            // 
            // open_view_concurse
            // 
            this.open_view_concurse.Location = new System.Drawing.Point(524, 25);
            this.open_view_concurse.Name = "open_view_concurse";
            this.open_view_concurse.Size = new System.Drawing.Size(119, 35);
            this.open_view_concurse.TabIndex = 1;
            this.open_view_concurse.Text = "Классные часы";
            this.open_view_concurse.UseVisualStyleBackColor = true;
            this.open_view_concurse.Click += new System.EventHandler(this.open_view_concurse_Click);
            // 
            // open_view_doc
            // 
            this.open_view_doc.Location = new System.Drawing.Point(274, 25);
            this.open_view_doc.Name = "open_view_doc";
            this.open_view_doc.Size = new System.Drawing.Size(119, 35);
            this.open_view_doc.TabIndex = 2;
            this.open_view_doc.Text = "Личный документы";
            this.open_view_doc.UseVisualStyleBackColor = true;
            this.open_view_doc.Click += new System.EventHandler(this.open_view_doc_Click);
            // 
            // open_view_rasspisanie
            // 
            this.open_view_rasspisanie.Location = new System.Drawing.Point(399, 25);
            this.open_view_rasspisanie.Name = "open_view_rasspisanie";
            this.open_view_rasspisanie.Size = new System.Drawing.Size(119, 35);
            this.open_view_rasspisanie.TabIndex = 3;
            this.open_view_rasspisanie.Text = "Рассписание всех групп";
            this.open_view_rasspisanie.UseVisualStyleBackColor = true;
            this.open_view_rasspisanie.Click += new System.EventHandler(this.open_view_rasspisanie_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.open_view_rasspisanie);
            this.panel1.Controls.Add(this.open_student_table);
            this.panel1.Controls.Add(this.open_view_concurse);
            this.panel1.Controls.Add(this.open_view_doc);
            this.panel1.Location = new System.Drawing.Point(3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 401);
            this.panel1.TabIndex = 5;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.White;
            legend1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DashedHorizontal;
            legend1.BackImageTransparentColor = System.Drawing.Color.White;
            legend1.BackSecondaryColor = System.Drawing.Color.White;
            legend1.BorderColor = System.Drawing.Color.White;
            legend1.InterlacedRowsColor = System.Drawing.Color.Red;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.Red;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(162, 71);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Students";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(469, 300);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(826, 397);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main_form";
            this.Text = "Руководство для классных руководителей";
            this.Load += new System.EventHandler(this.main_form_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button open_student_table;
        private System.Windows.Forms.Button open_view_concurse;
        private System.Windows.Forms.Button open_view_doc;
        private System.Windows.Forms.Button open_view_rasspisanie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

