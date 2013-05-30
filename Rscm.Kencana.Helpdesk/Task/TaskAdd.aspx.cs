using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;
using Rscm.Kencana.Helpdesk.BusinessObjects;
using System.Data;

namespace Rscm.Kencana.Helpdesk.Task
{
    public partial class TaskAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["isnew"] == null)
                Response.Redirect("~/Default.aspx");
            //X.Js.Call("onWinClose");  
            if (!X.IsAjaxRequest)
            {
                ServiceUnitQuery sQ = new ServiceUnitQuery("a");
                sQ.SelectAll().Where(sQ.IsActive == true);
                sQ.es2.Connection.Name = "KENCANA";                                
                storeSU.DataSource = sQ.LoadDataTable();
                storeSU.DataBind();
            }
        }

        [DirectMethod]
        public void btnSave_Click()
        {
            if (string.IsNullOrEmpty(txtTitle.Text) && string.IsNullOrEmpty(txtDesc.Text) && string.IsNullOrEmpty(cmbServiceUnit.SelectedItem.Value))
            {
                return;
            }
            ADefHelpDeskTasks t = new ADefHelpDeskTasks();
            ADefHelpDeskTasksQuery tQ = new ADefHelpDeskTasksQuery("a");
            ADefHelpDeskTasksCollection tC = new ADefHelpDeskTasksCollection();
            ADefHelpDeskTaskDetails tD = new ADefHelpDeskTaskDetails();
            t.PortalID = 0;
            t.Description = txtTitle.Text;
            t.Status = "New";
            t.Priority = "High";
            t.CreatedDate = DateTime.Now;
            t.EstimatedStart = DateTime.Now;
            t.EstimatedCompletion = DateTime.Now.AddDays(7);
            t.DueDate = DateTime.Now.AddDays(14);
            t.AssignedRoleID = 1;
            //Password Ticket            
            string tikPass = Guid.NewGuid().ToString();
            t.TicketPassword = tikPass;
            //Get username ID
            ADefHelpDeskUsersQuery uq = new ADefHelpDeskUsersQuery("a");
            ADefHelpDeskUsersCollection uc = new ADefHelpDeskUsersCollection();
            uq.SelectAll().Where(uq.Username == HttpContext.Current.User.Identity.Name.ToString().Trim());
            uq.es.Top = 1;
            uc.Load(uq);
            if (uc.Count > 0)
            {
                foreach (ADefHelpDeskUsers u in uc)
                {
                    t.RequesterUserID = u.UserID;
                    t.RequesterName = u.FirstName;
                }
            }
            t.Save();
            tQ.SelectAll().Where(tQ.TicketPassword == tikPass);
            tQ.es.Top = 1;
            tC.Load(tQ);
            if (tC.Count > 0)
            {
                foreach (ADefHelpDeskTasks tt in tC)
                {
                    tD.TaskID = tt.TaskID;
                    tD.DetailType = "Details";
                    tD.InsertDate = tt.CreatedDate;
                    tD.Description = txtDesc.Text;
                    tD.UserID = tt.RequesterUserID;
                    tD.Save();
                }
            }
            MessageBus.Default.Publish("grdTask_Refresh");
            //X.Js.Call("onWinClose");
        }
    }
}