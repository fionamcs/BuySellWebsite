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

public partial class admin_admineditseller : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            string seller = Request.QueryString["sellerid"].ToString();
            //select info where id is the same as session
            string query = "SELECT * FROM [elmtreeseller] WHERE ID=@sellerid";

            string connectionString = WebConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(connectionString);

            SqlCommand com = new SqlCommand(query, myConnection);
            com.Parameters.AddWithValue("@sellerid", seller);

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



                    firstname.Text = firstnamedata;
                    lastname.Text = lastnamedata;
                    username.Text = usernamedata;
                    address.Text = addressdata;
                    phone.Text = phonedata;
                    email.Text = emaildata;
                    password.Text = passworddata;
                    learning.Text = learningdata;
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
        string upname = firstname.Text;
        string uplastname = lastname.Text;
        string upusername = username.Text;
        string upaddress = address.Text;
        string upphone = phone.Text;
        string upemail = email.Text;
        string uppassword = password.Text;
        string uplearning = learning.Text;
        string seller = Request.QueryString["sellerid"].ToString();

        //add where on to end of query
        string query = "UPDATE elmtreeseller SET firstname = @firstname, lastname = @lastname, username=@username, address = @address, phoneno=@phone, learningin=@learning, password=@password, email=@email, pic=@pic WHERE ID=@sellerid";

        SqlCommand command = new SqlCommand(query, myConnection);
        command.Parameters.AddWithValue("@firstname", upname);
        command.Parameters.AddWithValue("@lastname", uplastname);
        command.Parameters.AddWithValue("@username", upusername);
        command.Parameters.AddWithValue("@address", upaddress);
        command.Parameters.AddWithValue("@phone", upphone);
        command.Parameters.AddWithValue("@pic", img);
        command.Parameters.AddWithValue("@email", upemail);
        command.Parameters.AddWithValue("@learning", uplearning);
        command.Parameters.AddWithValue("@password", uppassword);
        command.Parameters.AddWithValue("@sellerid", seller);
        //parameter for id

        command.ExecuteNonQuery();

        myConnection.Close();

        Response.Redirect("adminsellers.aspx"); 
    }
    }
