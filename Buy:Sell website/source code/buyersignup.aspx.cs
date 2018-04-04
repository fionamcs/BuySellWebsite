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

public partial class buyersignup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void uploadbutton_Click(object sender, EventArgs e)
    {
        string upPath = Server.MapPath("~/files");

        Random r = new Random();
        int rInt = r.Next(0, 1000);

        if (!Directory.Exists(upPath))
        {
            Directory.CreateDirectory(upPath);
            myinfo.Text = upPath + "folder does not exist";
        }
        else
        {
            int imgSize = myimage.PostedFile.ContentLength;
            string imgName = myimage.FileName;
            string imgPath = "~/files/" + rInt + imgName;

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
        string firstnamedata = firstname.Text;
        string surnamedata = lastname.Text;
        string usernamedata = username.Text;
        string addressdata = address.Text;
        string numberdata = phonen.Text;
        string emaildata = email.Text;
        string passworddata = pword.Text;
        string learningindata = learning.Text;

        //query string
        string query = "INSERT INTO elmtreebuyer(firstname, lastname, username, address, phoneno, email, password, learningin, pic) VALUES(@firstname, @lastname, @username, @address, @phoneno, @email, @password, @learningin, @pic )";

        SqlCommand myCommand = new SqlCommand(query, myConnection);
        //create a parameterised object
        //coverts string data to parameters
        //stops sql injections etc
        myCommand.Parameters.AddWithValue("@firstname", firstnamedata);
        myCommand.Parameters.AddWithValue("@lastname", surnamedata);
        myCommand.Parameters.AddWithValue("@username", usernamedata);
        myCommand.Parameters.AddWithValue("@address", addressdata);
        myCommand.Parameters.AddWithValue("@phoneno", numberdata);
        myCommand.Parameters.AddWithValue("@email", emaildata);
        myCommand.Parameters.AddWithValue("@password", passworddata);
        myCommand.Parameters.AddWithValue("@learningin", learningindata);
        myCommand.Parameters.AddWithValue("@pic", img);

        myCommand.ExecuteNonQuery();

        myinfo.Text = "upload successful..";
        Response.Redirect("signin.aspx");

        //clear form of data
        firstname.Text = "";
        lastname.Text = "";
        username.Text = "";
        address.Text = "";
        phonen.Text = "";
        email.Text = "";
        pword.Text = "";
        learning.Text = "";

        myConnection.Close();
    }
}