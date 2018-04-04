using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_adminsellers : System.Web.UI.Page
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

    protected void updatebutton_Click(object sender, EventArgs e)
    {

    }
}
