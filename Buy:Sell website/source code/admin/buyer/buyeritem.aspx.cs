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

public partial class admin_buyer_buyeritem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
    protected void ratebutton_Click(object sender, EventArgs e)
    {
        
        //connecting to the database
        string connect = WebConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        SqlConnection myConnection = new SqlConnection(connect);


        myConnection.Open();

        string sellerd = seller.Text;
        string ratingd = rating.Text;
        string commentd = comment.Text;


        //query string
        string query = "INSERT INTO elmtreesellerrating(ratingID, comment, sellerID) VALUES(@rating, @comment, @sellerID )";

        SqlCommand myCommand = new SqlCommand(query, myConnection);
        //create a parameterised object
        //coverts string data to parameters
        //stops sql injections etc
        myCommand.Parameters.AddWithValue("@rating", ratingd);
        myCommand.Parameters.AddWithValue("@comment", commentd);
        myCommand.Parameters.AddWithValue("@sellerID", sellerd);

        myCommand.ExecuteNonQuery();

        
        //clear form of data
        //seller.Text = "";
        //rating.Text = "";
        comment.Text = "";
     
        myConnection.Close();
    }
   
}