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
            string username = HttpContext.Current.User.Identity.Name;            
            ADefHelpDeskUsersQuery uu = new ADefHelpDeskUsersQuery();
            ADefHelpDeskUsersCollection uuC = new ADefHelpDeskUsersCollection();
            uu.SelectAll().Where(uu.Username == username);
            uu.es.Top = 1;
            uuC.Load(uu);
            foreach (ADefHelpDeskUsers uuu in uuC)
            {
                Session["UserID"] = uuu.UserID;
            }
            
            if (!X.IsAjaxRequest)
            {
                this.storeStatus.DataSource = new object[]
                {
                    new object[] {"New", "New"},
                    new object[] {"Resolved","Resolved"},
                    new object[] {"Cancelled", "Cancelled"},
                    new object[] {"On Hold", "On Hold"}
                };
                    this.storeStatus.DataBind();
                    this.cmbStatus.SetRawValue("New");                    
            }
        }

        [DirectMethod]
        public void txtSearch_Change()
        {
            //if (string.IsNullOrEmpty(cmbStatus.SelectedItem.Value))
            //    return;

            //ADefHelpDeskTasksQuery t = new ADefHelpDeskTasksQuery("a");
            //ADefHelpDeskTaskDetailsQuery tD = new ADefHelpDeskTaskDetailsQuery("b");
            //ADefHelpDeskUsersQuery u = new ADefHelpDeskUsersQuery("c");
            //t.Select(t.TaskID, t.Status, t.DueDate, t.CreatedDate, t.AssignedRoleID, t.Description, t.RequesterUserID, t.RequesterName, u.Username);           
            //t.Where(t.Status.Like("%"+ cmbStatus.SelectedItem.Value +"%"));
            //t.Where(t.Description.Like("%" + txtSearch.Text + "%"));
            //t.InnerJoin(u).On(t.AssignedRoleID == u.UserID);
            //t.es.Distinct = true;            
            //DataTable dTask = t.LoadDataTable();
            //storeTask.DataSource = dTask;
            //storeTask.DataBind();
        }

        [DirectMethod]
        public void btnSearch_Click()
        {
            if (string.IsNullOrEmpty(cmbStatus.SelectedItem.Value))
                return;

            ADefHelpDeskTasksQuery t = new ADefHelpDeskTasksQuery("a");
            ADefHelpDeskTaskDetailsQuery tD = new ADefHelpDeskTaskDetailsQuery("b");
            ADefHelpDeskUsersQuery u = new ADefHelpDeskUsersQuery("c");
            t.Select(t.TaskID, t.Status, t.DueDate, t.CreatedDate, t.AssignedRoleID, t.Description, t.RequesterUserID, t.RequesterName, u.Username);
            t.Where(t.Status.Like("%" + cmbStatus.SelectedItem.Value + "%") && t.Description.Like("%" + txtSearch.Text + "%"));            
            t.InnerJoin(u).On(t.AssignedRoleID == u.UserID);
            t.es.Distinct = true;
            DataTable dTask = t.LoadDataTable();
            this.grdTask.Store.Primary.DataSource = dTask;
            this.grdTask.Store.Primary.DataBind();
            storeTask.DataSource = dTask;
            storeTask.DataBind();
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
            t.Select(t.TaskID, t.Status, t.DueDate, t.CreatedDate, t.AssignedRoleID, t.Description, t.RequesterUserID, t.RequesterName,u.Username);
                //tD.DetailID,tD.DetailType,tD.UserID,tD.InsertDate,tD.Description.As("Comment"),tD.StartTime,tD.StopTime,u.Username);
            //t.RightJoin(tD).On(t.TaskID == tD.TaskID);
            t.InnerJoin(u).On(t.AssignedRoleID == u.UserID);
            t.es.Distinct = true;
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
            Window winNew = new Window
            {
                ID = "winEdit",
                Title = "Edit",
                Height = 400,
                Width = 700,
                BodyPadding = 5,
                Modal = true,
                Closable = true,
                CloseAction = CloseAction.Destroy,
                AutoShow = false
            };
            winNew.Loader = new ComponentLoader
            {
                Url = "~/Task/TaskEdit.aspx?isedit=1&TaskID=" + TaskID,
                Mode = LoadMode.Frame
            };
            winNew.Render(this.Form);
            //winNew.Show();
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

        [DirectMethod]
        public void grdTask_Select()
        {
            int taskID = 0;
            RowSelectionModel rm = this.grdTask.GetSelectionModel() as RowSelectionModel;
            if (rm.SelectedRows.Count > 0)
            {
                if (!int.TryParse(rm.SelectedRow.RecordID, out taskID))
                    taskID = 0;
                if (taskID <= 0)
                    return;
                Session["TaskID"] = taskID;
                ADefHelpDeskTasks t = new ADefHelpDeskTasks();
                if (t.LoadByPrimaryKey(taskID))
                {
                    ADefHelpDeskTaskDetailsQuery tQ = new ADefHelpDeskTaskDetailsQuery("a");
                    ADefHelpDeskTaskDetailsCollection tC = new ADefHelpDeskTaskDetailsCollection();
                    tQ.SelectAll().Where(tQ.TaskID == taskID);
                    tC.Load(tQ);
                    if (tC.Count > 0)
                    {
                        string detail = string.Empty;
                        foreach (ADefHelpDeskTaskDetails tD in tC)
                        {
                            ADefHelpDeskUsers u = new ADefHelpDeskUsers();
                            detail += tD.Description;
                            if (u.LoadByPrimaryKey((int)tD.UserID))
                            {                                                                
                                detail += "<br><br><b>User : </b>" + u.FirstName;
                                //detail += "<b>User : </b>" + u.FirstName + ", <b>Insert Date : </b>" + tD.InsertDate.ToString();
                                //detail += "<br><br><br>";                                
                            }
                            detail += ", <b>Insert Date : </b>" + tD.InsertDate.ToString() + "<br>---------------------------------------------------------<br>";
                            lblHtml.Html = detail;
                        }
                    }
                    else
                        lblHtml.Html = string.Empty;
                }
            }
        }

        [DirectMethod]
        public void btnComment_Click()
        {
            if (string.IsNullOrEmpty(txtComment.Text.Trim()))
            {
                X.Msg.Notify("Dire news indeed", "Your Excellency, Comment must not empty").Show();
                return;
            }            
            if (Session["TaskID"] == null)
            {
                X.Msg.Notify("Dire news indeed", "Your Excellency, You must select a task above first").Show();
                return;
            }
            if (Session["UserID"] == null)
            {
                X.Msg.Notify("Dire news indeed", "Your Excellency, Please do some re-login first").Show();
                return;
            }
            int TaskID = (int)Session["TaskID"];
            //int UserID = (int)Session["UserID"];
            ADefHelpDeskTaskDetails td = new ADefHelpDeskTaskDetails();
            td.TaskID = TaskID;
            td.DetailType = "Comment-Visible";
            td.InsertDate = DateTime.Now;
            td.UserID = (int)Session["UserID"]; ;
            td.Description = txtComment.Text.Trim();
            td.Save();
            X.Msg.Notify("Excelent job my Liege", "Your Excellency, I am happy to inform You that your comment has been saved successfully").Show();
            txtComment.Text = string.Empty;
            grdTask_Select();
        }
    }
}