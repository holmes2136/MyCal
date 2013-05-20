using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using MyCalendar;
public partial class Sample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        MyCal cal = new MyCal();
        MyCalEvent evt = new MyCalEvent(DateTime.Now, DateTime.Now.AddDays(2), "post");
        cal.evts.Add(evt);
        string result = cal.OutputICS();


        MailMessage mail = new MailMessage();
        mail.To.Add("type the email address that you want to recieve");
        mail.From = new MailAddress("type the email from address");
        mail.Subject = "test icalendar mail";
        mail.Body = "test icalendar mail";
        System.Net.Mime.ContentType ct = new System.Net.Mime.ContentType("text/calendar");
        ct.Parameters.Add("method", "REQUEST");
        AlternateView avCal = AlternateView.CreateAlternateViewFromString(result, ct);
        mail.AlternateViews.Add(avCal);
        SmtpClient smtp = new SmtpClient("your host", 25);
        smtp.Send(mail);


    }
}