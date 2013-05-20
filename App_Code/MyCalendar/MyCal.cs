using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;


          
namespace MyCalendar{
/// <summary>
/// MyCal 的摘要描述
/// </summary>
public class MyCal
{

    public List<MyCalEvent> evts {get;set;}

	public MyCal(){}


    public MyCal(List<MyCalEvent> evts){
     this.evts = evts;
    }
  

    public string  OutputICS(){
    
     	StringBuilder output = new StringBuilder();
     
     foreach (MyCalEvent e in this.evts){
     
        output.AppendLine("BEGIN:VCALENDAR");
        output.AppendLine("PRODID:-//companyname-Email-Calander-Invite");
        output.AppendLine("VERSION:2.0");
        output.AppendLine("METHOD:" + e.method);
        output.AppendLine("BEGIN:VEVENT");
        output.AppendLine(string.Format("DTSTART:{0}", e.dtstart.ToString("yyyyMMddTHHmm00")));
        output.AppendLine(string.Format("DTSTAM:{0}",DateTime.Now.ToString("yyyyMMddTHHmm00")));
        output.AppendLine(string.Format("DTEND:{0}", e.dtend.ToString("yyyyMMddTHHmm00")));
        output.AppendLine(string.Format("LOCATION:{0}", e.location));
        output.AppendLine(string.Format("UID:{0}", Guid.NewGuid()));
        output.AppendLine(string.Format("DESCRIPTION:{0}", e.description));
        output.AppendLine(string.Format("X-ALT-DESC;FMTTYPE=text/html:{0}", ""));
        output.AppendLine(string.Format("SUMMARY:{0}", e.summary));
        output.AppendLine(string.Format("ORGANIZER:MAILTO:{0}", string.IsNullOrEmpty(e.organizer)?e.organizer:e.organizer));
        output.AppendLine("BEGIN:VALARM");
        output.AppendLine(string.Format("TRIGGER:-PT{0}",e.alarm));
        output.AppendLine("ACTION:DISPLAY");
        output.AppendLine("DESCRIPTION:Reminder");
        output.AppendLine("END:VALARM");
        output.AppendLine("END:VEVENT");
        output.AppendLine("END:VCALENDAR");
     }

     return output.ToString();
  }

  


}

}
