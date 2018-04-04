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

public partial class admin_seller_sellitems : System.Web.UI.Page
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

    protected void uploadbutton_Click(object sender, EventArgs e)
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

        //connecting to the database
        string connect = WebConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        SqlConnection myConnection = new SqlConnection(connect);


        myConnection.Open();

        string img = rInt + myimage.FileName;
        string itemnamedata = itemname.Text;
        string descriptiondata = descriptiontext.Text;
        string pricedata = price.Text;
        string categorydata = typecategory.Text;
        string conditiondata = typecondition.Text;
        string seller = Session["sellerID"].ToString();

        //query string
        string query = "INSERT INTO items(name, description, price, typeofcategoryID, typeofconditionID, image, sellerID) VALUES(@name, @description, @price, @typeofcategoryID, @typeofconditionId, @pic, @sellerID)";

        SqlCommand myCommand = new SqlCommand(query, myConnection);
        //create a parameterised object
        //coverts string data to parameters
        //stops sql injections etc
        myCommand.Parameters.AddWithValue("@name", itemnamedata);
        myCommand.Parameters.AddWithValue("@description", descriptiondata);
        myCommand.Parameters.AddWithValue("@price", pricedata);
        myCommand.Parameters.AddWithValue("@typeofcategoryID", categorydata);
        myCommand.Parameters.AddWithValue("@typeofconditionID", conditiondata);
        myCommand.Parameters.AddWithValue("@pic", img);
        myCommand.Parameters.AddWithValue("@sellerID", seller);
     
        myCommand.ExecuteNonQuery();

        myinfo.Text = "upload successful..";
        Response.Redirect("sellerhome.aspx");

        //clear form of data
        itemname.Text = "";
        descriptiontext.Text = "";
        price.Text = "";
 
       
        

        myConnection.Close();
        
    }
}