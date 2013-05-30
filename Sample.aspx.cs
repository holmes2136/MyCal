using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using MyCalendar;
using MailClient;

public partial class Sample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        IInvitation cal = new Gmail();
        MyCalEvent evt = new MyCalEvent(DateTime.Now, DateTime.Now.AddDays(2), "post");
        
        string result = cal.Add(evt);


        MailMessage mail = new MailMessage();
        mail.To.Add("type the email address that you want to recieve");
        mail.From = new MailAddress("type your email addresss");
        mail.Subject = "test icalendar mail";
        mail.Body = "test icalendar mail";
        System.Net.Mime.ContentType ct = new System.Net.Mime.ContentType("text/calendar");
        ct.Parameters.Add("method", "REQUEST");
        AlternateView avCal = AlternateView.CreateAlternateViewFromString(result, ct);
        mail.AlternateViews.Add(avCal);
        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        smtp.EnableSsl = true;
        smtp.Send(mail);


    }
}