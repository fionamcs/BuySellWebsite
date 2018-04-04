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

public partial class admin_adminedititems : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            string buyer = Request.QueryString["itemid"].ToString();
            //select info where id is the same as session
            string query = "SELECT * FROM [items] WHERE ID=@itemid";

            string connectionString = WebConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(connectionString);

            SqlCommand com = new SqlCommand(query, myConnection);
            com.Parameters.AddWithValue("@itemid", buyer);

            myConnection.Open();

            SqlDataReader read = com.ExecuteReader();

            if (read.HasRows)
            {
                while (read.Read())
                {
                    string itemnamedata = read["name"].ToString();
                    string descriptiondata = read["description"].ToString();
                    string pricedata = read["price"].ToString();
                    string catdata = read["typeofcategoryID"].ToString();
                    string conditiondata = read["typeofconditionID"].ToString();

                    itemname.Text = itemnamedata;
                    descriptiontext.Text = descriptiondata;
                    price.Text = pricedata;
                    typecategory.Text = catdata;
                    typecondition.Text = conditiondata;
                    
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

    protected void updatebutton_Click(object sender, EventArgs e)
    {
        string upPath = Server.MapPath("../../files");

        Random r = new Random();
        int rInt = r.Next(0, 1000);

        if (!Directory.Exists(upPath))
        {
            myinfo.Text = upPath + "folder does not exist";
        }
        else
        {
            int imgSize = myimage.PostedFile.ContentLength;
            string imgName = myimage.FileName;
            string imgPath = "../..//files/" + rInt + imgName;

            if (myimage.PostedFile.ContentLength > 1500000)
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('File is too big.')", true);
            }
            else
            {
                //then save it to the folder
                myimage.SaveAs(Server.MapPath(imgPath));

            }
            myinfo.Text = "file" + imgPath + " uploaded";
        }

        string connect = WebConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        SqlConnection myConnection = new SqlConnection(connect);

        //opens connection
        myConnection.Open();


        string img = rInt + myimage.FileName;
        string upname = itemname.Text;
        string updescription = descriptiontext.Text;
        string upprice = price.Text;
        string upcategory = typecategory.Text;
        string upcondition = typecondition.Text;
        string item = Request.QueryString["itemid"].ToString();

        //add where on to end of query
        string query = "UPDATE items SET name = @name, description = @description, price=@price, typeofcategoryID = @typeofcategoryID, typeofconditionID=@typeofconditionID, image=@pic WHERE ID=@itemid";

        SqlCommand command = new SqlCommand(query, myConnection);
        command.Parameters.AddWithValue("@name", upname);
        command.Parameters.AddWithValue("@description", updescription);
        command.Parameters.AddWithValue("@price", upprice);
        command.Parameters.AddWithValue("@typeofcategoryID", upcategory);
        command.Parameters.AddWithValue("@typeofconditionID", upcondition);
        command.Parameters.AddWithValue("@pic", img);
        command.Parameters.AddWithValue("@itemid", item);
        //parameter for id

        command.ExecuteNonQuery();

        myConnection.Close();

        Response.Redirect("adminitems.aspx"); 
    }
}