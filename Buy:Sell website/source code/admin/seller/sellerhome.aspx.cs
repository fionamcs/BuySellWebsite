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

public partial class admin_seller_sellerhome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
           // string connectionString = WebConfigurationManager.ConnectionStrings["connect"].ConnectionString;
           // SqlConnection myConnection = new SqlConnection(connectionString);
   
            //get id from session
             // string sellerid = Session["sellerID"].ToString();
                       //select info where id is the same as session
            // string getid = "SELECT * FROM [items] WHERE sellerID=@sellerID";

            //SqlCommand com = new SqlCommand(query, myConnection);
            //com.Parameters.AddWithValue("@sellerID", Session["sellerID"].ToString());

            //myConnection.Open();


        }


    }


    protected void outbutton_Click(object sender, EventArgs e)
    {
        //sets session to null
        Session["sellerID"] = null;

        //redirects the page
        if (Session["sellerID"] == null)
        {
            Response.Redirect("../../default.aspx");
        }
    }
}