using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //original page Code start here

        //if (!IsPostBack)
        //{
        //    if (HttpContext.Current.User.Identity.IsAuthenticated)
        //    {
        //        loginPanel.Visible = false;
        //        loginButton.Visible = false;
        //        loggedIn.Visible = true;
        //    }
        //    else
        //    {

        //        loginPanel.Visible = true;
        //        loginButton.Visible = true;
        //        loggedIn.Visible = false;
        //    }
        //}
        //else { }

        //original pageload code end here



        //FROM HERE PAUL ******************
        if (!IsPostBack)
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                loginPanel.Visible = false;
                loginButton.Visible = false;
                loggedIn.Visible = true;
                lblAuthUser.Text = HttpContext.Current.User.Identity.Name.ToString();
            }
            else
            {

                loginPanel.Visible = true;
                loginButton.Visible = true;
                loggedIn.Visible = false;
            }
        }
        else { }

        //TO HERE******************************************






    }//end of page load
    protected void btnEvents_Click(object sender, EventArgs e)
    {
        Response.Redirect("Events.aspx");
    }
    protected void btnOffers_Click(object sender, EventArgs e)
    {
        Response.Redirect("Offers.aspx");
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Response.Redirect("Search.aspx");
    }
    protected void btnContact_Click(object sender, EventArgs e)
    {
        Response.Redirect("Contact.aspx");
    }

    private int checkLogin(String username, String password)
    {
        return DataAccess.validateLogin(username, password);
    }
    protected void btnShoppingCart_Click(object sender, EventArgs e)
    {
        Response.Redirect("shoppingCart.aspx");
    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        //FormsAuthentication.SignOut();

        //FROM HERE PAUL*************************
        FormsAuthentication.SignOut();
        Response.Redirect("home.aspx");
        //TO HERE ****************************************


    }
    protected void btnRegister_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Registration.aspx");
    }
    protected void btnLogon_Click(object sender, EventArgs e)
    {
        // check if valid Username and password
        int StaffID = checkLogin(txtUserName.Text, txtPassword.Text);

        if (StaffID != -1) //If Valid
        {

            System.Web.Security.FormsAuthentication.RedirectFromLoginPage(StaffID.ToString(), chkPersist.Checked);
        }
        else
        {
            lblInvalid.Text = "Invalid credentials. Please try again.";
        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        // check if valid Username and password
        int StaffID = checkLogin(txtUserName.Text, txtPassword.Text);

        if (StaffID != -1) //If Valid
        {

            System.Web.Security.FormsAuthentication.RedirectFromLoginPage(StaffID.ToString(), chkPersist.Checked);
        }
        else
        {
            lblInvalid.Text = "Invalid credentials. Please try again.";
        }
    }

}
