﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace System_College_of_Communication.Documents
{
    public partial class Doc : Form
    {

        private SqlConnection sqlConnection = null;
        public Doc()
        {
            InitializeComponent();
        }

        private void Doc_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["base_main"].ConnectionString);
            sqlConnection.Open();


        }


    }
}
