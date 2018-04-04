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

public partial class admin_admineditcat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            string cat = Request.QueryString["typeofcatid"].ToString();
            //select info where id is the same as session
            string query = "SELECT * FROM [typeofcategoryID] WHERE ID=@typeofcatid";

            string connectionString = WebConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(connectionString);

            SqlCommand com = new SqlCommand(query, myConnection);
            com.Parameters.AddWithValue("@typeofcatid", cat);

            myConnection.Open();

            SqlDataReader read = com.ExecuteReader();

            if (read.HasRows)
            {
                while (read.Read())
                {
                    string catdata = read["category"].ToString();
                    string descriptiondata = read["description"].ToString();
                    


                    category.Text = catdata;
                    description.Text = descriptiondata;
                }
            }
        }
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

    protected void updatebutton_Click(Object sender, EventArgs e)
    {
      
        string connect = WebConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        SqlConnection myConnection = new SqlConnection(connect);

        //opens connection
        myConnection.Open();


        string upcategory = category.Text;
        string updescription = description.Text;
        string cat = Request.QueryString["typeofcatid"].ToString();

        //add where on to end of query
        string query = "UPDATE typeofcategoryID SET category = @category, description = @description WHERE ID=@typeofcatid";

        SqlCommand command = new SqlCommand(query, myConnection);
        command.Parameters.AddWithValue("@category", upcategory);
        command.Parameters.AddWithValue("@description", updescription);
        command.Parameters.AddWithValue("@typeofcatid", cat);
        //parameter for id

        command.ExecuteNonQuery();

        myConnection.Close();

        Response.Redirect("admincategorys.aspx");
    }

    
}