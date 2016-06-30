using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataAccess
/// </summary>
public class DataAccess
{
	public DataAccess()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    //private static OleDbConnection openConnection()
    //{
    //    string root = "~"; // Sets Root Directory
    //    System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(root); //Access web.config
    //    string conStr = null; // Declare new connection String


    //    if (rootWebConfig.ConnectionStrings.ConnectionStrings.Count > 0) // If there is any connection strings within the web.config
    //    {
    //        try
    //        {
    //            conStr = rootWebConfig.ConnectionStrings.ConnectionStrings["conStrEventScapade"].ToString(); // Get Connection String
    //        }
    //        catch (Exception ex)
    //        {
    //            conStr = null; //Catch Exception, reset connection string to null.
    //        }


    //        if (conStr != null) // If connection string is not empty
    //        {
    //            OleDbConnection newConn = new OleDbConnection(conStr); //New connection object
    //            newConn.Open(); // Open new Database Connection
    //            HttpContext.Current.Trace.Warn("connection opened"); // Trace Warning
    //            return newConn; // 
    //        }
    //        else
    //        {
    //            HttpContext.Current.Trace.Warn("connection not available");
    //            return null;
    //        }
    //    }

    //    return null;

    //}//openConnection

    private static void closeConection(OleDbConnection cn)
    {
        cn.Close(); //Close Connection
        HttpContext.Current.Trace.Warn("connection closed"); // Trace Warning
    }//close connection

    //public static int validateLogin(String username, String password)
    //{

    //    int staffID = -1;

    //    OleDbConnection con = openConnection(); //Open Database Connection

    //    //Use a variable to hold the SQL statement
    //    String strSql = "SELECT UserName FROM tblStaff";
    //    strSql += " WHERE (((Staff.UserName)='" + username + "')";
    //    strSql += " AND ((Staff.Password)=" + "'" + password + "'))";

    //    try
    //    {

    //        OleDbCommand cmd = new OleDbCommand(strSql, con); //Create new OleDbCommand object, with SQL statement and Connection String as Parameters.

         
    //        OleDbDataReader dr = cmd.ExecuteReader(); //Creates Data Reader & fetches the corresponding SQL record.
            
    //        while (dr.Read()) // While Parsing through records.
    //        {
    //            staffID = Int32.Parse(dr["StaffID"].ToString()); //Parse StaffID to String
    //        }


    //        dr.Close(); //Close data reader
    //        closeConection(con); // Close Connection

    //        return staffID;

    //    }
    //    catch (Exception ex)
    //    {
           
    //        return staffID; //Return -1 if login has not been successful.
    //    }

    //}//validateLogin


    // FROM HERE PAUL**************************************************************************
    public static int validateLogin(String username, String password)
    {

        int UserID = -1;

        OleDbConnection con = openConnection(); //Open Database Connection

        //Use a variable to hold the SQL statement
        String strSql = "SELECT UserID FROM tblCustomer WHERE UserName='" + username + "' AND Pwd='" + password + "';";

        try
        {

            OleDbCommand cmd = new OleDbCommand(strSql, con); //Create new OleDbCommand object, with SQL statement and Connection String as Parameters.


            OleDbDataReader dr = cmd.ExecuteReader(); //Creates Data Reader & fetches the corresponding SQL record.

            while (dr.Read()) // While Parsing through records.
            {
                UserID = Int32.Parse(dr["UserID"].ToString()); //Parse UserID to String


            }


            dr.Close(); //Close data reader
            closeConection(con); // Close Connection
            return UserID;


        }
        catch (Exception ex)
        {

            return UserID; //Return -1 if login has not been successful.
        }

        // To Here******************************
    }//validateLogin



    private static OleDbConnection openConnection()
    {
        // path to the root of the web site where the web.config file exists
        string configPath = "~";
        // access to web.config file
        System.Configuration.Configuration rootWebConfig =
         System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(configPath);
        // declaring the connection string
        string conStr = null;

        // get the value(s) in the connection string
        if (rootWebConfig.ConnectionStrings.ConnectionStrings.Count > 0)
        {
            try
            {
                conStr = rootWebConfig.ConnectionStrings.ConnectionStrings["conStrBMC"].ToString();
            }
            catch (Exception ex)
            {
                conStr = null;
            }

            if (conStr != null)
            {
                HttpContext.Current.Trace.Warn("BMC connection string = \"{0}\"", conStr);

                //Create an OleDbConnection object using the Connection String
                OleDbConnection cn = new OleDbConnection(conStr);
                //Open the connection.
                cn.Open();
                return cn;
            }
            else
            {
                HttpContext.Current.Trace.Warn("No BMC connection string");
                return null;
            }
        }

        return null;
    }// openConnection

    private static void closeConnection(OleDbConnection cn)
    {
        cn.Close();
    } //closeConnection


    //calls all events together

    public static DataSet getEvents()
    {
        OleDbConnection conn = openConnection();
        //create dataset (virtual database)
        DataSet dsBMC = new DataSet();

        string strSQL = "SELECT * FROM tblEvent";

        //data adapter is bridge between database and dataset
        OleDbDataAdapter daProducts = new OleDbDataAdapter(strSQL, conn);

        //populate the data table in the dataset 
        //with records from the database table
        daProducts.Fill(dsBMC, "dtProducts");

        conn.Close();

        return dsBMC;
    }//getEvents

    //Displays only music events from the data base
    public static DataSet getMusic()
    {
        OleDbConnection conn = openConnection();
        //create dataset (virtual database)
        DataSet dsBMC = new DataSet();

        //only music events
        string strSQL = "SELECT * FROM tblEvent WHERE EventType LIKE 'Music'";

        //data adapter is bridge between database and dataset
        OleDbDataAdapter daMusic = new OleDbDataAdapter(strSQL, conn);

        //populate the data table in the dataset 
        //with records from the database table
        //yo
        daMusic.Fill(dsBMC, "dtMusic");

        conn.Close();

        return dsBMC;
    }//getMusic


    public static DataSet getSport()
    {
        OleDbConnection conn = openConnection();
        //create dataset (virtual database)
        DataSet dsBMC = new DataSet();

        //only music events
        string strSQL = "SELECT * FROM tblEvent WHERE EventType LIKE 'Sport'";

        //data adapter is bridge between database and dataset
        OleDbDataAdapter daMusic = new OleDbDataAdapter(strSQL, conn);

        //populate the data table in the dataset 
        //with records from the database table
        //yo
        daMusic.Fill(dsBMC, "dtSport");

        conn.Close();

        return dsBMC;
    }//getSport

    public static DataSet getTheatre()
    {
        OleDbConnection conn = openConnection();
        //create dataset (virtual database)
        DataSet dsBMC = new DataSet();

        //only music events
        string strSQL = "SELECT * FROM tblEvent WHERE EventType LIKE 'Theatre'";

        //data adapter is bridge between database and dataset
        OleDbDataAdapter daTheatre = new OleDbDataAdapter(strSQL, conn);

        //populate the data table in the dataset 
        //with records from the database table
        //yo
        daTheatre.Fill(dsBMC, "dtTheatre");

        conn.Close();

        return dsBMC;
    }//getSport


    public static Event getEvent(string pEventID)
    {
        Event EventObj = new Event();

        OleDbConnection conn = openConnection();

        //Something Wrong this SQL Statement
        //int id = Int32.Parse(pEventID);

        string strSQL = "SELECT * FROM tblEvent WHERE EventID =" + pEventID + "";

        OleDbCommand cmd = new OleDbCommand(strSQL, conn);

        OleDbDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {

            EventObj.setStrEventID(reader["EventID"].ToString());
            EventObj.setStrEventTitle(reader["EventTitle"].ToString());
            EventObj.setStrEventVenue(reader["EventVenue"].ToString());
            EventObj.setStrEventImage(reader["EventImage"].ToString());
            EventObj.setStrEventDate(reader["EventDate"].ToString());
            EventObj.setDblEventPrice(Convert.ToDouble(reader["EventPrice"]));
        }//while

        reader.Close();
        closeConnection(conn);

        return EventObj;
    }//getEvent



    public static int createNewUser(string userName, string pwd, string firstName,string lastName,string address,string email,string phone)
    {
        OleDbConnection cn = openConnection();

        // SQL insert string
        string insertSQL = "INSERT into tblCustomer(UserName,Pwd,FirstName,LastName,Address,Email,Phone) " +
        "Values ('" + userName + "', '" + pwd + "','" + firstName + "','" + lastName + "','" + address + "','" + email + "','" + phone + "')";

        // Perform a SQL insertion
        OleDbCommand cmd = new OleDbCommand(insertSQL, cn);

        cmd.ExecuteNonQuery();

        ////return the Primary Key from the new record added
        cmd.CommandText = "SELECT @@IDENTITY";
        int newCustID = Convert.ToInt32(cmd.ExecuteScalar());

        cn.Close();

        return newCustID;
    } //createNewCustomer









}//end of class