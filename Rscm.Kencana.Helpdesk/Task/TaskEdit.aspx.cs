﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;
using Rscm.Kencana.Helpdesk.BusinessObjects;

namespace Rscm.Kencana.Helpdesk.Task
{
    public partial class TaskEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int taskID = 0;            
            if (Request.QueryString["isedit"] == null & Request.QueryString["TaskID"] == null)
                Response.Redirect("~/Default.aspx");
            if(!int.TryParse(Request.QueryString["TaskID"].ToString(),out taskID))
                taskID = 0;
            ADefHelpDeskTasks t = new ADefHelpDeskTasks();  
            if (!t.LoadByPrimaryKey(taskID))
                Response.Redirect("~/Default.aspx");
            ADefHelpDeskTaskDetailsQuery tQ = new ADefHelpDeskTaskDetailsQuery("a");
            ADefHelpDeskTaskDetailsCollection tC = new ADefHelpDeskTaskDetailsCollection();
            tQ.SelectAll().Where(tQ.TaskID == taskID && tQ.DetailType == "Details");
            tQ.es.Top = 1;
            tC.Load(tQ);
            //Fill the Form
            txtTitle.Text = t.Description;
            if (tC.Count > 0)
            {
                foreach (ADefHelpDeskTaskDetails aT in tC)
                    txtDesc.Text = aT.Description;
            }
        }

        [DirectMethod]
        public void Close()
        {
            X.Msg.Alert("A", "Alooo").Show();
        }

        [DirectMethod]
        public void btnSave_Click()
        {
            ADefHelpDeskTasks t = new ADefHelpDeskTasks();
            t.PortalID = 0;
            t.Description = txtDesc.Text;
            t.Status = "New";
            t.Priority = "High";
            t.CreatedDate = DateTime.Now;
            t.EstimatedStart = DateTime.Now;
            t.EstimatedCompletion = DateTime.Now.AddDays(7);
            t.DueDate = DateTime.Now.AddDays(14);
            t.AssignedRoleID = 1;
            //Password Ticket
            Guid g = new Guid();
            t.TicketPassword = Guid.NewGuid().ToString();
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
            MessageBus.Default.Publish("grdTask_Refresh");
            //X.Js.Call("onWinClose");
        }
    }
}