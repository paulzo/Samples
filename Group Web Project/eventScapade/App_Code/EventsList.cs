using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EventsList
/// </summary>
public class EventsList
{
	public EventsList()
	{
	
	}//end of constructor


    public static DataSet getEvents()
    {
        return DataAccess.getEvents();
    }//getEvents

    public static DataSet getMusic()
    {

        return DataAccess.getMusic();

    }//end of get music

    public static DataSet getSport()
    {

        return DataAccess.getSport();

    }//end of get Sport

    public static DataSet getTheatre()
    {

        return DataAccess.getTheatre();

    }//end of getTheatre









}//end of class