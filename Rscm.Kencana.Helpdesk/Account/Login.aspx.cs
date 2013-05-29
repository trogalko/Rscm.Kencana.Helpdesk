using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Rscm.Kencana.Helpdesk.BusinessObjects;

namespace Rscm.Kencana.Helpdesk.Account
{
    public partial class Login : System.Web.UI.Page
    {
        private AppUser _user = new AppUser();
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            LoginUser.Authenticate +=new AuthenticateEventHandler(LoginUser_Authenticate);
        }

        protected void LoginUser_Authenticate(object sender, System.Web.UI.WebControls.AuthenticateEventArgs e)
        {
            string userName = LoginUser.UserName;
            string password = LoginUser.Password;


            bool result = UserLogin(userName, password);
            if ((result))
            {
                e.Authenticated = true;
            }
            else
            {
                e.Authenticated = false;
            }
        }

        protected bool UserLogin(string userName, string password)
        {
            _user.es.Connection.Name = "KENCANA";
            //_user.es.Connection.Name = "LOCAL_HIS";
            if (_user.LoadByPrimaryKey(userName))
            {
                if (_user.Password.Equals(Crypto.Encrypt(password)))
                {
                    ADefHelpDeskUsersQuery q = new ADefHelpDeskUsersQuery();
                    q.SelectAll().Where(q.Username == userName);
                    ADefHelpDeskUsersCollection c = new ADefHelpDeskUsersCollection();
                    c.Load(q);
                    if (c.Count == 1 || c.Count ==0 )
                    {
                        ADefHelpDeskUsers a = new ADefHelpDeskUsers();
                        a.Username = userName;
                        a.Password = _user.Password;
                        a.FirstName = _user.UserName;
                        a.LastName = ".";
                        a.IsSuperUser = false;
                        a.Email = userName + "@rscmkencana.com";
                        a.Save();
                    }
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
    }
}
