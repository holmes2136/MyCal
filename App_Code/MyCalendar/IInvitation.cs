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
using System.Collections.Generic;


namespace MyCalendar { 
/// <summary>
/// Summary description for IInvitation
/// </summary>
public interface IInvitation
{
     string Add(MyCalEvent evts);
     void Delete();
     void Update();

}


}