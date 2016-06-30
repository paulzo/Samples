using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Sports : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        //Use the dataset returned from the code to be the
        //data source of the grid view
        System.Data.DataSet ds = EventsList.getSport();
        dgvSport.DataSource = ds.Tables["dtSport"];

        dgvSport.AllowPaging = true;
        dgvSport.PageSize = 10;


        dgvSport.DataBind();

    }//end of page load

    protected void dgvEvents_SelectedIndexChanged(object sender, EventArgs e)
    {
        //brings back the productID of selected index(ie the 1st cell- which is ID) and its returned to session variable
        Session["SelectedEventID"] = dgvSport.Rows[dgvSport.SelectedIndex].Cells[0].Text;
        Response.Redirect("EventDetails.aspx");
    }//SelectedIndexChanged()



}//end of class