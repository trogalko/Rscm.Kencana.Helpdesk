using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Rscm.Kencana.Helpdesk.BusinessObjects;
using Ext.Net;
using System.Data;
using System.Web.Security;

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
            //foreach (ADefHelpDeskUsers uuu in uuC)
            //{
            //    Session["UserID"] = uuu.UserID;
            //    Session["ServiceUnitID"] = string.Empty;
            //    ADefHelpDeskUserUserGroupQuery ug = new ADefHelpDeskUserUserGroupQuery("a");
            //    ADefHelpDeskUserUserGroupCollection ugC = new ADefHelpDeskUserUserGroupCollection();
            //    ug.SelectAll().Where(ug.UserID == username);
            //    ug.es.Top = 1;
            //    ugC.Load(ug);
            //    if (ugC.Count > 0)
            //    {
            //        foreach (ADefHelpDeskUserUserGroup uug in ugC)
            //        {
            //            Session["ServiceUnitID"] = uug.UserServiceUnitID;
            //        }
            //    }
            //}
            
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
                    StoreReadDataEventArgs ee = new StoreReadDataEventArgs();
                    storeTask_ReadData(sender,ee);
                    storeNeedApproval_ReadData(sender, ee);
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
            if (AppSession.ServiceUnit.UserServiceUnitID == null)
                return;

            ADefHelpDeskTasksQuery t = new ADefHelpDeskTasksQuery("a");
            ADefHelpDeskTaskDetailsQuery tD = new ADefHelpDeskTaskDetailsQuery("b");
            ADefHelpDeskUsersQuery u = new ADefHelpDeskUsersQuery("c");
            //RequesterEmail == Requestor Service Unit
            //RequesterPhone == Destination Service Unit
            //t.Select(t.TaskID, t.Status, t.DueDate, t.CreatedDate, t.AssignedRoleID, t.Description, t.RequesterUserID, t.RequesterName, u.Username);
            t.Select(t.TaskID, t.Status, t.DueDate, t.CreatedDate,t.ConfirmAsFinishDate, t.AssignedRoleID, t.Description, t.RequesterUserID, t.RequesterName, t.RequesterEmail, t.RequesterPhone);
            //t.Where(t.Status.Like("%" + cmbStatus.SelectedItem.Value + "%") && (t.RequesterEmail == Session["ServiceUnit"].ToString() || t.RequesterPhone == Session["ServiceUnit"].ToString()));
            //t.Where(t.Status.Like("%" + cmbStatus.SelectedItem.Value + "%"));
            if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                t.Where(t.Description.Like("%" + txtSearch.Text + "%"));
            }
            //|| t.Description.Like("%" + txtSearch.Text + "%") || (t.RequesterEmail == Session["ServiceUnit"].ToString() | t.RequesterPhone == Session["ServiceUnit"].ToString()));
            if (AppSession.ServiceUnit.UserServiceUnitID != null)
            {
                if (!(AppSession.ServiceUnit.UserServiceUnitID == "HIT" || AppSession.ServiceUnit.UserServiceUnitID == "IT"))
                {
                    t.Where(t.Status.Like("%" + cmbStatus.SelectedItem.Value + "%") && t.Description.Like("%" + txtSearch.Text + "%") && (t.RequesterEmail == Session["ServiceUnitID"].ToString() | t.RequesterPhone == AppSession.ServiceUnit.UserServiceUnitID));
                }
                else
                {
                    t.Where(t.Status.Like("%" + cmbStatus.SelectedItem.Value + "%"));
                }
            }
            else
            {
                Session.Abandon();
                Session.RemoveAll();
                FormsAuthentication.SignOut();
                FormsAuthentication.RedirectToLoginPage();
            }
            //t.InnerJoin(u).On(t.AssignedRoleID == u.UserID);
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
            t.Select(t.TaskID, t.Status, t.DueDate, t.CreatedDate,t.ConfirmAsFinishDate, t.AssignedRoleID, t.Description, t.RequesterUserID, t.RequesterName, t.RequesterEmail,t.RequesterPhone);
                //tD.DetailID,tD.DetailType,tD.UserID,tD.InsertDate,tD.Description.As("Comment"),tD.StartTime,tD.StopTime,u.Username);
            //t.RightJoin(tD).On(t.TaskID == tD.TaskID);
            if (AppSession.ServiceUnit.UserServiceUnitID != null)
            {
                if (!(AppSession.ServiceUnit.UserServiceUnitID == "HIT" || AppSession.ServiceUnit.UserServiceUnitID == "IT"))
                {
                    t.Where(t.RequesterEmail == AppSession.ServiceUnit.UserServiceUnitID | t.RequesterPhone == AppSession.ServiceUnit.UserServiceUnitID);
                }
                if (!X.IsAjaxRequest)
                {
                    t.Where(t.Status == "New");
                }
                
            }            
            //t.InnerJoin(u).On(t.AssignedRoleID == u.UserID);
            t.es.Distinct = true;
            //t.OrderBy(t.TaskID.Ascending);
            DataTable dTask = t.LoadDataTable();
            storeTask.DataSource = dTask;
            storeTask.DataBind();            
        }

        [DirectMethod]
        public void storeNeedApproval_ReadData(object sender, StoreReadDataEventArgs e)
        {
            ADefHelpDeskTasksQuery t = new ADefHelpDeskTasksQuery("a");
            ADefHelpDeskTaskDetailsQuery tD = new ADefHelpDeskTaskDetailsQuery("b");
            ADefHelpDeskUsersQuery u = new ADefHelpDeskUsersQuery("c");
            t.Select(t.TaskID, t.Status, t.DueDate, t.CreatedDate, t.ConfirmAsFinishDate, t.AssignedRoleID, t.Description, t.RequesterUserID, t.RequesterName, t.RequesterEmail, t.RequesterPhone);
            t.Where(t.Status == "Resolved",t.ApprovedByRequestorID.IsNull());

            //RequesterEmail = Service unit peminta
            //RequesterPhone = Service unit tujuan
            if (AppSession.ServiceUnit.UserServiceUnitID != null)
            {
                //if (!(AppSession.ServiceUnit.UserServiceUnitID == "HIT" || AppSession.ServiceUnit.UserServiceUnitID == "IT"))
                //{
                    t.Where(t.RequesterEmail == AppSession.ServiceUnit.UserServiceUnitID);
                //}                
            }
            
            t.es.Distinct = true;            
            DataTable dTask = t.LoadDataTable();
            storeNeedApproval.DataSource = dTask;
            storeNeedApproval.DataBind();
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
            t.InnerJoin(tD).On(t.TaskID == tD.TaskID);
            t.InnerJoin(u).On(t.RequesterUserID == u.UserID);
            t.Select(t.TaskID, t.Status, t.DueDate, t.CreatedDate,t.ConfirmAsFinishDate, t.AssignedRoleID, t.Description, t.RequesterUserID, t.RequesterName, t.RequesterEmail,t.RequesterPhone,
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
            int taskID = 0;
            if (!int.TryParse(TaskID, out taskID))
                taskID = 0;
            ADefHelpDeskTasks t = new ADefHelpDeskTasks();
            if (t.LoadByPrimaryKey(taskID))
            {
                if (t.Status == "Resolved" || t.Status == "Cancelled" || t.Status == "OnHold")
                {
                    X.Msg.Notify("Info", "Unable to mark as finished, either task already confirmed or cancelled").Show();
                    return;
                }
                if (AppSession.ServiceUnit.UserServiceUnitID == "HIT" || AppSession.ServiceUnit.UserServiceUnitID == "IT" || AppSession.ServiceUnit.UserServiceUnitID == t.RequesterPhone)
                {
                    Session["TaskID"] = taskID;
                    X.Msg.Show(new MessageBoxConfig
                        {
                            Title = "Confirm?",
                            Message = "Are You sure want to confirm as finished ?",
                            Buttons = MessageBox.Button.YESNO,
                            MessageBoxButtonsConfig = new MessageBoxButtonsConfig 
                            {
                                Yes = new MessageBoxButtonConfig
                                {
                                    Text = "Yes",
                                    Handler = "App.direct.ConfirmAsFinished()"
                                },
                                No = new MessageBoxButtonConfig
                                {
                                    Text = "No",
                                    Handler = "App.direct.CancelConfirmAsFinished()"
                                }
                            },
                            AnimEl = this.grdTask.ClientID,
                            Icon = MessageBox.Icon.QUESTION
                        });

                    //t.Status = "Resolved";
                    //t.Save();
                    //X.Msg.Show(new MessageBoxConfig
                    //{
                    //    Title = "Success",
                    //    Message = "Request Confirmed",
                    //    Buttons = MessageBox.Button.OK,
                    //    Icon = MessageBox.Icon.INFO,
                    //    AnimEl = this.grdTask.ClientID
                    //});
                    ////Refresh GridPanel
                    //MessageBus.Default.Publish("grdTask_Refresh");  
                }
                else
                    X.Msg.Notify("Error", "You don not have the privileges to confirm this task").Show();
            }            
        }

        [DirectMethod]
        public void ConfirmAsFinished()
        {
            int taskID = (int)Session["TaskID"];
            ADefHelpDeskTasks t = new ADefHelpDeskTasks();
            if (t.LoadByPrimaryKey(taskID))
            {
                t.ConfirmAsFinishDate = DateTime.Now;
                t.Status = "Resolved";
                t.Save();
                X.Msg.Notify("Success", "Successfully confirmed as finished").Show();
                //Refresh GridPanel
                MessageBus.Default.Publish("grdTask_Refresh");
            }
        }

        [DirectMethod]
        public void CancelConfirmAsFinished()
        {
            //int taskID = (int)Session["TaskID"];
            //ADefHelpDeskTasks t = new ADefHelpDeskTasks();
            //if (t.LoadByPrimaryKey(taskID))
            //{
            //    t.ConfirmAsFinishDate = DateTime.Now;
            //    t.Status = "Resolved";
            //    t.Save();
            //    X.Msg.Notify("Success", "Successfully confirmed as finished").Show();
            //    //Refresh GridPanel
            //    MessageBus.Default.Publish("grdTask_Refresh");
            //}
            return;
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
                    if (AppSession.ServiceUnit.UserServiceUnitID == "HIT" || AppSession.ServiceUnit.UserServiceUnitID == "IT" || AppSession.ServiceUnit.UserServiceUnitID == t.RequesterPhone)
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
                    else
                        X.Msg.Notify("Error", "You don not have the privileges to cancell this task").Show();
                }
            }
        }

        [DirectMethod]
        public void grdTask_ApproveByPic(string TaskID)
        {
            ADefHelpDeskTasks t = new ADefHelpDeskTasks();
            int taskID = 0;
            if (int.TryParse(TaskID, out taskID))
            {
                if (t.LoadByPrimaryKey(taskID))
                {
                    Session["TaskID"] = taskID;
                    X.Msg.Show(new MessageBoxConfig
                    {
                        Title = "Confirm?",
                        Message = "You agree to declare that this task has been done completely ?",
                        Buttons = MessageBox.Button.YESNO,
                        MessageBoxButtonsConfig = new MessageBoxButtonsConfig
                        {
                            Yes = new MessageBoxButtonConfig
                            {
                                Text = "Yes",
                                Handler = "App.direct.PicConfirmAsFinished()"
                            },
                            No = new MessageBoxButtonConfig
                            {
                                Text = "No",
                                Handler = "App.direct.PicCancelConfirmAsFinished()"
                            }
                        },
                        AnimEl = this.grdTask.ClientID,
                        Icon = MessageBox.Icon.QUESTION
                    });
                }
            }
        }

        [DirectMethod]
        public void PicConfirmAsFinished()
        {
            int taskID = (int)Session["TaskID"];
            ADefHelpDeskTasks t = new ADefHelpDeskTasks();
            if (t.LoadByPrimaryKey(taskID))
            {
                t.ApprovedByRequestorID = AppSession.UserLogin.UserID;
                t.ApprovedByRequestorDateTime = DateTime.Now;
                t.Save();
                X.Msg.Notify("Success", "PIC successfully confirms the task as finished completely").Show();
                //Refresh GridPanel
                MessageBus.Default.Publish("grdTask_Refresh");
            }
        }

        [DirectMethod]
        public void PicCancelConfirmAsFinished()
        {            
            return;
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
                X.Msg.Notify("Empty comment disallowed", "Comment must not empty").Show();
                return;
            }            
            if (Session["TaskID"] == null)
            {
                X.Msg.Notify("Select at least one task", "You must select a task above first").Show();
                return;
            }
            if (AppSession.UserLogin == null)
            {
                X.Msg.Notify("Session timeout", "Your Session has expired, Please do some re-login first").Show();
                Session.Abandon();
                Session.RemoveAll();
                FormsAuthentication.SignOut();
                return;
            }
            ADefHelpDeskUsers u = (ADefHelpDeskUsers)AppSession.UserLogin;
            int UserID = (int)u.UserID;
            int TaskID = (int)Session["TaskID"];
            //int UserID = (int)Session["UserID"];
            ADefHelpDeskTaskDetails td = new ADefHelpDeskTaskDetails();
            td.TaskID = TaskID;
            td.DetailType = "Comment-Visible";
            td.InsertDate = DateTime.Now;
            //td.UserID = (int)Session["UserID"];
            td.UserID = (int)u.UserID;
            td.Description = txtComment.Text.Trim();
            td.Save();
            X.Msg.Notify("Excelent. You, as the RSCM Kencana best employee", "Just made the greatest and the wisest comment in the human history").Show();
            txtComment.Text = string.Empty;
            grdTask_Select();
        }
    }
}