﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void reg_Click(object sender, EventArgs e)
        {
            string ins = "Insert into [Table](Name, Email_id, Password) values ('" + Username.Text + "','" + email.Text + "','" + password.Text + "')";
            SqlCommand com = new SqlCommand(ins,con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }
    }
}