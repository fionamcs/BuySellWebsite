using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_buyer_seller : System.Web.UI.Page
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
    protected void ratebutton_Click(object sender, EventArgs e)
    {

    }
}