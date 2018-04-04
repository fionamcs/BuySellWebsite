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

public partial class admin_seller_edititem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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

    protected void updatebutton_Click(object sender, EventArgs e)
    {
        string upPath = Server.MapPath("../../../files");

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
            string imgPath = "../../../files/" + rInt + imgName;

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
        //parameter for id
        command.Parameters.AddWithValue("@itemid", item);

        command.ExecuteNonQuery();

        myConnection.Close();

        Response.Redirect("sellerhome.aspx");
    }
}