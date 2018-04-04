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

public partial class admin_newcat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void outbutton_Click(object sender, EventArgs e)
    {
        //sets session to null
        Session["admin"] = null;

        //redirects the page
        if (Session["admin"] == null)
        {
            Response.Redirect("../default.aspx");
        }
    }

    protected void uploadbutton_Click(object sender, EventArgs e){
        //connecting to the database
        string connect = WebConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        SqlConnection myConnection = new SqlConnection(connect);


        myConnection.Open();

        string itemnamedata = catname.Text;
        string descriptiondata = description.Text;

        //query string
        string query = "INSERT INTO typeofcategoryID(category, description) VALUES(@catname, @description)";

        SqlCommand myCommand = new SqlCommand(query, myConnection);
        //create a parameterised object
        //coverts string data to parameters
        //stops sql injections etc
        myCommand.Parameters.AddWithValue("@catname", itemnamedata);
        myCommand.Parameters.AddWithValue("@description", descriptiondata);

        myCommand.ExecuteNonQuery();

        Response.Redirect("admincategorys.aspx");

        //clear form of data
        catname.Text = "";
        description.Text = "";
        
}
}