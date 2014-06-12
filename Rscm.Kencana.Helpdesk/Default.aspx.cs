using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Rscm.Kencana.Helpdesk.BusinessObjects;

using Ext.Net;
using System.Data;

namespace Rscm.Kencana.Helpdesk
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                if (Session["ServiceUnitID"] == null)
                    return;
            AppUserCollection userColl = new AppUserCollection();
            userColl.es.Connection.Name = "KENCANA";
            AppUserQuery userQ = new AppUserQuery("a");
            userQ.es2.Connection.Name = "KENCANA";
            userQ.SelectAll();
            userColl.Load(userQ);
            if (userColl.Count >= 1)
            {
                foreach (AppUser au in userColl)
                {
                    ADefHelpDeskUsersQuery hlpUserQ = new ADefHelpDeskUsersQuery("uQ");
                    hlpUserQ.es2.Connection.Name = "HELPDESK";
                    hlpUserQ.SelectAll().Where(hlpUserQ.Username == au.UserID);
                    DataTable dtU = hlpUserQ.LoadDataTable();
                    if (dtU.Rows.Count == 0)
                    {
                        ADefHelpDeskUsers hlpUser = new ADefHelpDeskUsers();
                        hlpUser.es.Connection.Name = "HELPDESK";
                        hlpUser.Username = au.UserID;
                        hlpUser.FirstName = au.UserName;
                        hlpUser.LastName = ".";
                        hlpUser.IsSuperUser = false;
                        hlpUser.Email = au.UserID + "@rscmkencana.com";
                        hlpUser.Password = au.Password;
                        hlpUser.Save();
                    }
                }
            }
        }
    }
}
