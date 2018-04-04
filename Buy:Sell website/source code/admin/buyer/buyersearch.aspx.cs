using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_buyer_buyersearch : System.Web.UI.Page
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
}