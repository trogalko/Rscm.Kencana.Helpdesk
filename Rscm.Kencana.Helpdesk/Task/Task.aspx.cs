using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Rscm.Kencana.Helpdesk.BusinessObjects;
using Ext.Net;
using System.Data;

namespace Rscm.Kencana.Helpdesk.Task
{
    public partial class Task : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!X.IsAjaxRequest)
            {
                this.storeStatus.DataSource = new object[]
                {
                    new object[] {"New", "New"},
                    new object[] {"Finished","Finished"},
                    new object[] {"Cancelled", "Cancelled"}
                };
                    this.storeStatus.DataBind();
                    this.cmbStatus.SetRawValue("New");
                }
        }

        [DirectMethod]
        public void txtSearch_Change()
        {
 
        }

        [DirectMethod]
        public void btnSearch_Click()
        {
            
        }

        [DirectMethod]
        public void btnNew_Click()
        {
            Window winNew = new Window
            {
                ID = "winNew",
                Title = "Add New",
                Height = 400,
                Width = 700,
                BodyPadding = 5,
                Modal = true,
                Closable = true,
                CloseAction = CloseAction.Hide, 
                AutoShow = false
            };
            winNew.Loader = new ComponentLoader 
            {
                Url = "~/Task/TaskAdd.aspx?isnew=1",
                Mode = LoadMode.Frame
            };
            winNew.Render(this.Form);
            //winNew.Show();
        }

        [DirectMethod]
        public void storeTask_ReadData(object sender, StoreReadDataEventArgs e)
        {
            ADefHelpDeskTasksQuery t = new ADefHelpDeskTasksQuery("a");
            ADefHelpDeskTaskDetailsQuery tD = new ADefHelpDeskTaskDetailsQuery("b");
            ADefHelpDeskUsersQuery u = new ADefHelpDeskUsersQuery("c");
            t.Select(t.TaskID, t.Status, t.DueDate, t.CreatedDate, t.AssignedRoleID, t.Description, t.RequesterUserID, t.RequesterName,
                tD.DetailID,tD.DetailType,tD.UserID,tD.InsertDate,tD.Description.As("Comment"),tD.StartTime,tD.StopTime,u.Username);
            t.LeftJoin(tD).On(t.TaskID == tD.TaskID);
            t.InnerJoin(u).On(t.AssignedRoleID == u.UserID);
            //t.OrderBy(t.TaskID.Ascending);
            DataTable dTask = t.LoadDataTable();
            storeTask.DataSource = dTask;
            storeTask.DataBind();            
        }

        [DirectMethod]
        public void cmbStatus_Change()
        {
            X.Msg.Alert("Info", cmbStatus.SelectedItem.Value).Show();
            if (cmbStatus.SelectedItems.Count <= 0)
                return;
            if (string.IsNullOrEmpty(cmbStatus.SelectedItem.Value))
                return;
            ADefHelpDeskTasksQuery t = new ADefHelpDeskTasksQuery("a");
            ADefHelpDeskTaskDetailsQuery tD = new ADefHelpDeskTaskDetailsQuery("b");
            ADefHelpDeskUsersQuery u = new ADefHelpDeskUsersQuery("c");
            t.Select(t.TaskID, t.Status, t.DueDate, t.CreatedDate, t.AssignedRoleID, t.Description, t.RequesterUserID, t.RequesterName,
                tD.DetailID, tD.DetailType, tD.UserID, tD.InsertDate, tD.Description.As("Comment"), tD.StartTime, tD.StopTime, u.Username);
            t.InnerJoin(tD).On(t.TaskID == tD.TaskID);
            t.InnerJoin(u).On(t.AssignedRoleID == u.UserID);
            t.Where(t.Status == cmbStatus.SelectedItem.Value.Trim());
            //t.Where(t.Status == value);
            DataTable dTask = t.LoadDataTable();
            storeTask.DataSource = dTask;           
            storeTask.DataBind();  
        }

        [DirectMethod]
        public void grdTask_Edit(string TaskID)
        {
            X.Msg.Alert("Edit",TaskID).Show();
        }

        [DirectMethod]
        public void grdTask_Confirm(string TaskID)
        {
            X.Msg.Alert("Confirm as Finished", TaskID).Show();
        }

        [DirectMethod]
        public void grdTask_Cancel(string TaskID)
        {
            ADefHelpDeskTasks t = new ADefHelpDeskTasks();
            int taskID = 0;
            if (int.TryParse(TaskID, out taskID))
            {
                if (t.LoadByPrimaryKey(taskID))
                {
                    if (t.Status == "Resolved")
                    {
                        X.Msg.Alert("Error", "This request has been resolved").Show();
                        return;
                    }
                    if (t.Status == "Cancelled")
                    {
                        X.Msg.Alert("Error", "This request has been cancelled").Show();
                        return;
                    }
                    t.Status = "Cancelled";
                    t.Save();
                    X.Msg.Show(new MessageBoxConfig
                    {
                        Title = "Success",
                        Message = "Request Cancelled",
                        Buttons = MessageBox.Button.OK,
                        Icon = MessageBox.Icon.INFO,
                        AnimEl = this.grdTask.ClientID
                    });
                    //Refresh GridPanel
                    MessageBus.Default.Publish("grdTask_Refresh");                    
                }
            }
        }
    }
}