using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }//end of page load
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }//end of dropdown list


    protected void btnRegister_Click(object sender, EventArgs e)
    {

        Customer newCustomer = new Customer();
        Trace.Warn("New customer created with ID " + newCustomer.getUserID());
        newCustomer.setUserName(TBUser.Text);
        newCustomer.setFirstName(TBfname.Text);
        newCustomer.setLastName(TBSurname.Text);
        newCustomer.setPassword(TBPwd.Text);
        newCustomer.seteMail(TBEmail.Text);
        newCustomer.setAddress(TBAddress.Text);
        //newCustomer.setPhone(Convert.ToInt32(TBPhone.Text));
        newCustomer.setPhone(TBPhone.Text);

        newCustomer.createNewUser();

        //Trace.Warn("New customer created with ID " + newCustomer.getUserID());



        Response.Redirect("~/home.aspx");

    }//end of btnRegister


}//end of registration class