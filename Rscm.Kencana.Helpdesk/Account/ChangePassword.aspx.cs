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
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ChangeUserPassword.ChangingPassword += new LoginCancelEventHandler(ChangeUserPassword_ChangingPassword);
            ChangeUserPassword.ChangedPassword += new EventHandler(ChangeUserPassword_ChangedPassword);
        }

        void ChangeUserPassword_ChangedPassword(object sender, EventArgs e)
        {
            
        }

        void ChangeUserPassword_ChangingPassword(object sender, LoginCancelEventArgs e)
        {
            if (ChangeUserPassword.CurrentPassword.ToString() == ChangeUserPassword.NewPassword.ToString())
            {
                e.Cancel = true;
                return;
            }
            else
            {
                AppUser au = new AppUser();
                au.es.Connection.Name = "KENCANA";
                if (au.LoadByPrimaryKey(HttpContext.Current.User.Identity.Name))
                {
                    au.Password = Crypto.Encrypt(ChangeUserPassword.NewPassword.ToString());
                    au.Save();
                }
            }
        }

        [DirectMethod]
        public void btnSave_Clicked()
        {
            if (txtNewPassword.Text != txtConfirmNewPassword.Text)
            {
                X.Msg.Alert("Error", "New Password does not match").Show();
                return;
            }
            if (txtOldPassword.Text == txtNewPassword.Text || txtOldPassword.Text == txtConfirmNewPassword.Text)
            {
                X.Msg.Alert("Error", "New Password must not same with Old Password").Show();
                return;
            }
            AppUser au = new AppUser();
            au.es.Connection.Name = "KENCANA";
            if (au.LoadByPrimaryKey(HttpContext.Current.User.Identity.Name))
            {
                au.Password = Crypto.Encrypt(txtNewPassword.Text);
                au.Save();
                Response.Redirect("~/Account/ChangePasswordSuccess.aspx");
            }
        }
    }
}
