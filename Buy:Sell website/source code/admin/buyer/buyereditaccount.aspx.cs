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

public partial class admin_buyer_buyereditaccount : System.Web.UI.Page
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



                    firstnameupdate.Text = firstnamedata;
                    lastnameupdate.Text = lastnamedata;
                    usernameupdate.Text = usernamedata;
                    addressupdate.Text = addressdata;
                    phonenupdate.Text = phonedata;
                    emailupdate.Text = emaildata;
                    passwordupdate.Text = passworddata;
                    learningupdate.Text = learningdata;

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

    protected void upbutton_Click(object sender, EventArgs e)
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
            int imgSize = upimage.PostedFile.ContentLength;
            string imgName = upimage.FileName;
            string imgPath = "../../../files/" + rInt + imgName;

            if (upimage.PostedFile.ContentLength > 1500000)
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('File is too big.')", true);
            }
            else
            {
                //then save it to the folder
                upimage.SaveAs(Server.MapPath(imgPath));

            }
            myinfo.Text = "file" + imgPath + " uploaded";
        }

        string connect = WebConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        SqlConnection myConnection = new SqlConnection(connect);

        //opens connection
        myConnection.Open();

        string img = rInt + upimage.FileName;
        string upfirstname = firstnameupdate.Text;
        string uplastname = lastnameupdate.Text;
        string upusername = usernameupdate.Text;
        string upaddress = addressupdate.Text;
        string uppassword = passwordupdate.Text;
        string upphone = phonenupdate.Text;
        string upemail = emailupdate.Text;
        string uplearningin = learningupdate.Text;
        int buyer = Convert.ToInt16(Session["user"]);

        string query = "UPDATE elmtreebuyer SET firstname = @firstname, lastname = @lastname, address=@address, username = @username, phoneno=@phoneno, email=@email, password=@password, learningin=@learningin, pic=@pic WHERE buyerID= @buyerid";

        SqlCommand command = new SqlCommand(query, myConnection);
        command.Parameters.AddWithValue("@firstname", upfirstname);
        command.Parameters.AddWithValue("@lastname", uplastname);
        command.Parameters.AddWithValue("@username", upusername);
        command.Parameters.AddWithValue("@password", uppassword);
        command.Parameters.AddWithValue("@address", upaddress);
        command.Parameters.AddWithValue("@phoneno", upphone);
        command.Parameters.AddWithValue("@email", upemail);
        command.Parameters.AddWithValue("@learningin", uplearningin);
        command.Parameters.AddWithValue("@pic", img);
        command.Parameters.AddWithValue("@buyerid", buyer);


        command.ExecuteNonQuery();

        myConnection.Close();

        Response.Redirect("buyerhome.aspx");
    }

    protected void updatebutton_Click(object sender, EventArgs e)
    {
        string connect = WebConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        SqlConnection myConnection = new SqlConnection(connect);

        //opens connection
        myConnection.Open();


        string upfirstname = firstnameupdate.Text;
        string uplastname = lastnameupdate.Text;
        string upusername = usernameupdate.Text;
        string upaddress = addressupdate.Text;
        string uppassword = passwordupdate.Text;
        string upphone = phonenupdate.Text;
        string upemail = emailupdate.Text;
        string uplearningin = learningupdate.Text;

        int user = Convert.ToInt16(Session["user"]);

        string query = "UPDATE elmtreebuyer SET firstname = @firstname, lastname = @lastname, address=@address, username = @username, phoneno=@phoneno, email=@email, password=@password, learningin=@learningin WHERE buyerID= @user";

        SqlCommand command = new SqlCommand(query, myConnection);
        command.Parameters.AddWithValue("@firstname", upfirstname);
        command.Parameters.AddWithValue("@lastname", uplastname);
        command.Parameters.AddWithValue("@username", upusername);
        command.Parameters.AddWithValue("@password", uppassword);
        command.Parameters.AddWithValue("@address", upaddress);
        command.Parameters.AddWithValue("@phoneno", upphone);
        command.Parameters.AddWithValue("@email", upemail);
        command.Parameters.AddWithValue("@learningin", uplearningin);
        command.Parameters.AddWithValue("@user", user);



        command.ExecuteNonQuery();

        myConnection.Close();

        Response.Redirect("buyerhome.aspx");
    }
}