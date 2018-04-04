using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class signin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void setsession_Click(object sender, EventArgs e)
    {
        string usern = username.Text;
        string passd = password.Text;

        String connectionString = WebConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        SqlConnection myConnection = new SqlConnection(connectionString);

        myConnection.Open();

        string query = "SELECT * FROM elmtreebuyer WHERE username=@user AND password=@password";
        SqlCommand myCommand = new SqlCommand(query, myConnection);

        //create parameters
        myCommand.Parameters.AddWithValue("@user", usern);
        myCommand.Parameters.AddWithValue("@password", passd);

        SqlDataReader rdr = myCommand.ExecuteReader();

        if (rdr.HasRows)
        {
            while (rdr.Read())
            {
                string name = rdr["username"].ToString();
                string myid = rdr["buyerID"].ToString();
                int buyer = Convert.ToInt16(rdr["buyerID"]);
                //set session
                
                Session["user"] = myid;
                
                Response.Redirect("admin/buyer/buyerhome.aspx");
            }
        }
        myConnection.Close();
    }

    protected void setsess_Click(object sender, EventArgs e)
    {
        string usern = uname.Text;
        string passd = pword.Text;

        String connectionString = WebConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        SqlConnection myConnection = new SqlConnection(connectionString);

        myConnection.Open();

        string query = "SELECT * FROM elmtreeseller WHERE username=@user AND password=@password";
        SqlCommand myCommand = new SqlCommand(query, myConnection);

        //create parameters
        myCommand.Parameters.AddWithValue("@user", usern);
        myCommand.Parameters.AddWithValue("@password", passd);

        SqlDataReader rdr = myCommand.ExecuteReader();

        if (rdr.HasRows)
        {
            while (rdr.Read())
            {
                string name = rdr["username"].ToString();
                string myid = rdr["ID"].ToString();
                int seller = Convert.ToInt16(rdr["ID"]);

                //set session
                Session["sellerID"] = myid;
                Response.Redirect("admin/seller/sellerhome.aspx");
            }
        }
        myConnection.Close();
    }
    
    protected void in_Click(object sender, EventArgs e)
    {
        string uname = adminname.Text;
        string pword = adpassword.Text;

        String connectionString = WebConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        SqlConnection myConnection = new SqlConnection(connectionString);

        myConnection.Open();

        string query = "SELECT * FROM elmtreeadmin WHERE username=@user AND password=@password";
        SqlCommand myCommand = new SqlCommand(query, myConnection);

        //create parameters
        myCommand.Parameters.AddWithValue("@user", uname);
        myCommand.Parameters.AddWithValue("@password", pword);

        SqlDataReader rdr = myCommand.ExecuteReader();

        if (rdr.HasRows)
        {
            while (rdr.Read())
            {
                string name = rdr["username"].ToString();
                string myid = rdr["ID"].ToString();
                int seller = Convert.ToInt16(rdr["ID"]);

                //set session
                Session["admin"] = myid;
                Response.Redirect("admin/adminhome.aspx");
            }
        }
        myConnection.Close();
    }
}