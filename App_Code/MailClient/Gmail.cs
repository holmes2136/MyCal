using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using MyCalendar;
using System.Text;
using System.Collections.Generic;

namespace MailClient { 
/// <summary>
/// Summary description for Gmail
/// </summary>
public class Gmail:IInvitation
{

	public Gmail(){}


    public string Add(MyCalEvent e)

    {
        StringBuilder output = new StringBuilder();

            output.AppendLine("BEGIN:VCALENDAR");
            output.AppendLine("PRODID:-//companyname-Email-Calander-Invite");
            output.AppendLine("VERSION:2.0");
            output.AppendLine("METHOD:" + e.method);
            output.AppendLine("BEGIN:VEVENT");
            output.AppendLine(string.Format("DTSTART:{0}", e.dtstart.ToString("yyyyMMddTHHmm00")));
            output.AppendLine(string.Format("DTSTAM:{0}", DateTime.Now.ToString("yyyyMMddTHHmm00")));
            output.AppendLine(string.Format("DTEND:{0}", e.dtend.ToString("yyyyMMddTHHmm00")));
            output.AppendLine(string.Format("LOCATION:{0}", e.location));
            output.AppendLine(string.Format("UID:{0}", Guid.NewGuid()));
            output.AppendLine(string.Format("DESCRIPTION:{0}", e.description));
            output.AppendLine(string.Format("X-ALT-DESC;FMTTYPE=text/html:{0}", ""));
            output.AppendLine(string.Format("SUMMARY:{0}", e.summary));
            output.AppendLine(string.Format("ORGANIZER:MAILTO:{0}", string.IsNullOrEmpty(e.organizer) ? e.organizer : e.organizer));
            output.AppendLine("BEGIN:VALARM");
            output.AppendLine(string.Format("TRIGGER:-PT{0}", e.alarm));
            output.AppendLine("ACTION:DISPLAY");
            output.AppendLine("DESCRIPTION:Reminder");
            output.AppendLine("END:VALARM");
            output.AppendLine("END:VEVENT");
            output.AppendLine("END:VCALENDAR");

            return output.ToString();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }



}


}