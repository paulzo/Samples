using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Theatre : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //Use the dataset returned from the code to be the
        //data source of the grid view
        System.Data.DataSet ds = EventsList.getTheatre();
        dgvTheatre.DataSource = ds.Tables["dtTheatre"];

        dgvTheatre.AllowPaging = true;
        dgvTheatre.PageSize = 10;


        dgvTheatre.DataBind();

    }//end of page load

    protected void dgvEvents_SelectedIndexChanged(object sender, EventArgs e)
    {
        //brings back the productID of selected index(ie the 1st cell- which is ID) and its returned to session variable
        Session["SelectedEventID"] = dgvTheatre.Rows[dgvTheatre.SelectedIndex].Cells[0].Text;
        Response.Redirect("EventDetails.aspx");
    }


}//end of class