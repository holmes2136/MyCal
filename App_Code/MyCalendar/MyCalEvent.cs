using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MyCalendar{

/// <summary>
/// MyCalEvent 的摘要描述
/// </summary>
public class MyCalEvent
{

    public DateTime dtstart { get; set; }
    public DateTime dtstamp { get; set; }
    public DateTime dtend { get; set; }
    public string method { get; set; }
    public string title { get; set; }
    public string location { get; set; }
    public string UID { get; set; }
    public string description { get; set; }
    public string summary { get; set; }
    public string organizer { get; set; }
    public Valarm alarm { get; set; }

    private MyCalEvent(){}

  //build a easy sample event
    public MyCalEvent(DateTime dtstart, DateTime dtsend, string method) {
    		
         new MyCalEvent(dtstart,DateTime.Now,dtsend,method,"Test ICalendar Format",
               "test",Guid.NewGuid().ToString(), "Test", "Test", "Test", "15M"); 
    }
  
    public MyCalEvent(DateTime dtstart,DateTime dtstamp,DateTime dtsend,string method,string title,
                    string location,String UID,string description,string summary,string organizer,Valarm alarm ){
     
      this.dtstart = dtstart;
      this.dtstamp = dtstamp;
      this.dtend = dtend;
      this.method = method;
      this.title = title;
      this.location = location;
      this.UID = UID;
      this.description = description;
      this.summary = summary;
      this.organizer = organizer;
      this.alarm = alarm;                     
  }

    public MyCalEvent(DateTime dtstart,DateTime dtsend,string method,string title,
                    string location,string description,string summary,string organizer,Valarm alarm ){
      
        
      new MyCalEvent(dtstart,DateTime.Now,dtsend,method,title,
                     location,Guid.NewGuid().ToString(), description, summary, organizer, alarm);
     
              
    }

    
}

}
