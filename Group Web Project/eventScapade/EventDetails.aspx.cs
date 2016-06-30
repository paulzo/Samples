using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EventDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            if (Session["SelectedEventID"] == null)
            {
                Response.Redirect("Events.aspx");
            }
            else
            {
                lblEventID.Text = Session["SelectedEventID"].ToString();
            }//end of inner if else
        }//end of if

        if (!IsPostBack)
        {
            if (Session["SelectedEventID"] == null)
            {
                Response.Redirect("Events.aspx");
            }
            else
            {
                lblEventID.Text = Session["SelectedEventID"].ToString();

                //create a tmpProduct object using the loadProduct method 
                Event tmpEvent = new Event();
                tmpEvent.loadEventDetails(Session["SelectedEventID"].ToString());

                // display the data within the tmpProduct object 
                lblEventTitle.Text = tmpEvent.getStrEventTitle();
                lblEventVenue.Text = tmpEvent.getStrEventVenue();
                imgEventImage.ImageUrl = tmpEvent.getStrEventImage();
                lblEventDate.Text = tmpEvent.getStrEventDate().ToString();
                lblEventPrice.Text = tmpEvent.getEventPrice().ToString("##.00");

                //"##.00"

                //ddlStock.Items.Clear(); //ensure drop down list is empty

                //using the inStock value to populate the drop down list
                //for (int index = 1; index <= tmpProduct.getIntStock(); index++)
                //{
                //    ddlStock.Items.Add(index.ToString());
                //}//for

            }//if
        }


    }//end of page load



    protected void btnBack_Click(object sender, EventArgs e)
    {

        //Event tmpEvent = new Event();
        //tmpEvent.loadEventDetails(Session["SelectedEventID"].ToString());

        //lblEventTitle.Text = null;
        //lblEventVenue.Text = null;
        //imgEventImage.ImageUrl = null;
        //lblEventDate.Text = null;
        //lblEventPrice.Text = null;

        //Response.Redirect("Events.aspx");

        
            //Session["SelectedEventID"] == null)
           
            Response.Redirect("Events.aspx");
            

        
    }//end of back btn
}//end of class