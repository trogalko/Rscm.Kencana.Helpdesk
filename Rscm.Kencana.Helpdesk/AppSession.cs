using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rscm.Kencana.Helpdesk.BusinessObjects;

namespace Rscm.Kencana.Helpdesk
{
    public class AppSession
    {
        public static ADefHelpDeskUsers UserLogin
        {
            get
            {
                object obj = HttpContext.Current.Session["_UserLogin"];
                if (obj == null)
                {
                    ADefHelpDeskUsers user = new ADefHelpDeskUsers();
                    user.UserID = 0;
                    user.Username = string.Empty;
                    HttpContext.Current.Session["_UserLogin"] = user;
                    return user;
                }

                return (ADefHelpDeskUsers)obj;
            }
            set
            { HttpContext.Current.Session["_UserLogin"] = value; }
        }
    }
}