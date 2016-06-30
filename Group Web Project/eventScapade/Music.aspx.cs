using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Music : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Use the dataset returned from the code to be the
        //data source of the grid view
        System.Data.DataSet ds = EventsList.getMusic();
        dgvMusic.DataSource = ds.Tables["dtMusic"];

        dgvMusic.AllowPaging = true;
        dgvMusic.PageSize = 10;


        dgvMusic.DataBind();
    }//end of page load

    protected void dgvEvents_SelectedIndexChanged(object sender, EventArgs e)
    {
        //brings back the productID of selected index(ie the 1st cell- which is ID) and its returned to session variable
        Session["SelectedEventID"] = dgvMusic.Rows[dgvMusic.SelectedIndex].Cells[0].Text;
        Response.Redirect("EventDetails.aspx");
    }//en


}//end of class