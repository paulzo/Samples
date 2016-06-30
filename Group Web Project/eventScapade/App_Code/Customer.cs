using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Customer
/// </summary>
public class Customer
{

    private int userID;
    private string pwd;
    private string eMail;
    private string userName;
    private string firstName;
    private string lastName;
    private string address;
    private string phone;




	public Customer()
	{
		



	}//end of constructor

    //public int userID { get; set; }
    //public string pwd { get; set; }
    //public string eMail { get; set; }
    //public string userName { get; set; }
    //public string firstName { get; set; }
    //public string lastName { get; set; }
    //public string address { get; set; }
    //public int phone { get; set; }

    public void setUserID(int parUserID)
    {
        this.userID = parUserID;
    } // end of setID modifier

    public int getUserID()
    {
        return this.userID;
    } // end of getID accessor

    public string getPassword()
    {
        return this.pwd;
    } // end of getPassword modifier

    public void setPassword(string parPassword)
    {
        this.pwd = parPassword;
    } // end of setPassword modifier

    public string geteMail()
    {
        return this.eMail;
    } // end of geteMail accessor

    public void seteMail(string pareMail)
    {
        this.eMail = pareMail;
    } // end of seteMail modifier

    public string getUserName()
    {
        return this.userName;
    } // end of getCustName accessor

    public void setUserName(string parUsername)
    {
        this.userName = parUsername;
    } // end of setCustName modifier

    public void setFirstName(string parFirstname)
    {
        this.firstName = parFirstname;
    } // end of setCustName modifier 


    public void setLastName(string parLastName)
    {
        this.lastName = parLastName;
    } // end of setCustName modifier

    public void setAddress(string parAddress)
    {
        this.address = parAddress;
    } // end of setCustName modifier


    public void setPhone(String parPhone)
    {
        this.phone = parPhone;
    } // end of setCustName modifier

    public void createNewUser()
    {
        this.userID = DataAccess.createNewUser(userName, pwd,  firstName, lastName, address, eMail, phone);
    }



    





}//end of class