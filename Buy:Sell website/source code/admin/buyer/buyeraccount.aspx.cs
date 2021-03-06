﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class admin_buyer_buyeraccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //get id from session
            string sellerID = Session["user"].ToString();
            //select info where id is the same as session
            string query = "SELECT * FROM [elmtreebuyer] WHERE buyerID=@user";

            string connectionString = WebConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(connectionString);

            SqlCommand com = new SqlCommand(query, myConnection);
            com.Parameters.AddWithValue("@user", Session["user"].ToString());

            myConnection.Open();

            SqlDataReader read = com.ExecuteReader();

            if (read.HasRows)
            {
                while (read.Read())
                {
                    string firstnamedata = read["firstname"].ToString();
                    string lastnamedata = read["lastname"].ToString();
                    string usernamedata = read["username"].ToString();
                    string addressdata = read["address"].ToString();
                    string phonedata = read["phoneno"].ToString();
                    string emaildata = read["email"].ToString();
                    string passworddata = read["password"].ToString();
                    string learningdata = read["learningin"].ToString();
                    


                    firstname.Text = firstnamedata;
                    lastname.Text = lastnamedata;
                    username.Text = usernamedata;
                    address.Text = addressdata;
                    phone.Text = phonedata;
                    email.Text = emaildata;
                    password.Text = passworddata;
                    learning.Text = learningdata;

                }
            }
        }
    }
    protected void outbutton_Click(object sender, EventArgs e)
    {
        //sets session to null
        Session["user"] = null;

        //redirects the page
        if (Session["user"] == null)
        {
            Response.Redirect("../../default.aspx");
        }
    }
}