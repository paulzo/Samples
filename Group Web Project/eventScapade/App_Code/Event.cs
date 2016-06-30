using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Event
/// </summary>
public class Event
{
    //variables

    private string strEventID;
    private string strEventTitle;
    private string strEventDate;
    private string strEventVenue;
    private string strEventImage;
    private double dblEventPrice;


    public Event()
    {
    }


    public Event(string id, string title, string eventDate, string eventVenue, string eventImage, double eventPrice)
    {
        this.strEventID = id;
        this.strEventTitle = title;
        this.strEventDate = eventDate;
        this.strEventVenue = eventVenue;
        this.strEventImage = eventImage;
        this.dblEventPrice = eventPrice;

    }//end of constructor

    public string getStrEventDate()
    {
        return strEventDate;
    }

    public void setStrEventDate(string pEventDate)
    {
        strEventDate = pEventDate;
    }

    public string getStrEventID()
    {
        return strEventID;
    }

    public void setStrEventID(string pEventID)
    {
        strEventID = pEventID;
    }

    public string getStrEventTitle()
    {
        return strEventTitle;
    }

    public void setStrEventTitle(string pEventTitle)
    {
        strEventTitle = pEventTitle;
    }

    public string getStrEventVenue()
    {
        return strEventVenue;
    }

    public void setStrEventVenue(string pEventVenue)
    {
        strEventVenue = pEventVenue;
    }

    public string getStrEventImage()
    {
        return strEventImage;
    }

    public void setStrEventImage(string pEventImage)
    {
        strEventImage = pEventImage;
    }

    public double getEventPrice()
    {
        return dblEventPrice;
    }

    public void setDblEventPrice(double pEventPrice)
    {
        dblEventPrice = pEventPrice;
    }

    public Event loadEventDetails(string pEventID)
    {
        Event tmpEvent = DataAccess.getEvent(pEventID);

        strEventID = tmpEvent.getStrEventID();
        strEventTitle = tmpEvent.getStrEventTitle();
        strEventVenue = tmpEvent.getStrEventVenue();
        strEventImage = tmpEvent.getStrEventImage();
        dblEventPrice = tmpEvent.getEventPrice();
        strEventDate = tmpEvent.getStrEventDate();

        return tmpEvent;

    }//loadProduct

}//end of event class