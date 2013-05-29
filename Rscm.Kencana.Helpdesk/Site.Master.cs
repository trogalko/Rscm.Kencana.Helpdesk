using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Rscm.Kencana.Helpdesk.BusinessObjects;
using System.Web.Security;

namespace Rscm.Kencana.Helpdesk
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Page.Title = "Helpdesk RSCM Kencana V1.0";
            LoginName loginName = HeadLoginView.FindControl("HeadLoginName") as LoginName;
            if (loginName != null && Session != null)           
            {
                AppUser _user = new AppUser();
                _user.es.Connection.Name = "KENCANA";
                //_user.es.Connection.Name = "LOCAL_HIS";
                if (_user.LoadByPrimaryKey(HttpContext.Current.User.Identity.Name))
                loginName.FormatString = _user.UserName;
            }
        }
    }
}
