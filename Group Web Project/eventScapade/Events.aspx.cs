using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Events : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void imgbTheatre_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Theatre.aspx");

    }
    protected void imgbSport_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Sports.aspx");
    }
    protected void imgbMusic_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Music.aspx");
    }
}