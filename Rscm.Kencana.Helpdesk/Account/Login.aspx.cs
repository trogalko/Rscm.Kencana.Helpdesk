using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Rscm.Kencana.Helpdesk.BusinessObjects;
using Ext.Net;

namespace Rscm.Kencana.Helpdesk.Account
{
    public partial class Login : System.Web.UI.Page
    {
        private AppUser _user = new AppUser();
        protected void Page_Load(object sender, EventArgs e)
        {
            //RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
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
                    ADefHelpDeskUsers a = new ADefHelpDeskUsers();
                    if (c.Count == 0 )
                    {
                        a.Username = userName;
                        a.Password = _user.Password;
                        a.FirstName = _user.UserName;
                        a.LastName = ".";
                        a.IsSuperUser = false;
                        a.Email = userName + "@rscmkencana.com";
                        a.Save();

                        ADefHelpDeskUsersQuery aa = new ADefHelpDeskUsersQuery();
                        ADefHelpDeskUsersCollection ac = new ADefHelpDeskUsersCollection();
                        aa.SelectAll().Where(aa.Username == userName);
                        ac.Load(aa);

                        foreach (ADefHelpDeskUsers U in ac)
                        {
                            ADefHelpDeskUsers _u = new ADefHelpDeskUsers();
                            _u.UserID = (int)U.UserID;
                            _u.Username = userName;
                            _u.FirstName = _user.UserName;
                            AppSession.UserLogin = _u;
                        }                        
                    }
                    if (c.Count == 1)
                    {
                        foreach (ADefHelpDeskUsers U in c)
                        {
                            if (a.LoadByPrimaryKey((int)U.UserID))
                            {
                                ADefHelpDeskUsers _u = new ADefHelpDeskUsers();
                                _u.UserID = (int)U.UserID;
                                _u.Username = userName;
                                _u.FirstName = _user.UserName;
                                AppSession.UserLogin = _u;

                                a.Username = userName;
                                a.Password = _user.Password;
                                a.FirstName = _user.UserName;
                                a.LastName = ".";
                                a.IsSuperUser = false;
                                a.Email = userName + "@rscmkencana.com";
                                a.Save(); 
                            }
                        }
                    }
                    //Get user service unit
                    ADefHelpDeskUserUserGroupQuery ugQ = new ADefHelpDeskUserUserGroupQuery("a");
                    ADefHelpDeskUserUserGroupCollection ugC = new ADefHelpDeskUserUserGroupCollection();
                    ugQ.SelectAll().Where(ugQ.UserID == userName).es.Top = 1;
                    ugC.Load(ugQ);
                    if (ugC.Count == 1)
                    {
                        foreach (ADefHelpDeskUserUserGroup ug in ugC)
                        {
                            Session["ServiceUnitID"] = ug.UserServiceUnitID;
                            AppSession.ServiceUnit = ug;
                        }
                    }
                    else
                    {
                        X.Msg.Notify("Error", "This user has not been registered to any service unit").Show();
                        return false;
                    }
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        protected void LoginUser_LoggedIn(object sender, EventArgs e)
        {
            if (Request.QueryString["ReturnUrl"] == null)
                Response.Redirect("~/Default.aspx");
        }
    }
}
