using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Rscm.Kencana.Helpdesk.BusinessObjects;
using Ext.Net;

namespace Rscm.Kencana.Helpdesk.User
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!X.IsAjaxRequest)
            {
                DataTable dtU = new DataTable();
                DataTable dtS = new DataTable();
                AppUserQuery uQ = new AppUserQuery("a");
                uQ.SelectAll();
                uQ.es2.Connection.Name = "KENCANA";
                ServiceUnitQuery sQ = new ServiceUnitQuery("b");
                sQ.SelectAll();
                sQ.es2.Connection.Name = "KENCANA";
                dtU = uQ.LoadDataTable();
                dtS = sQ.LoadDataTable();

                storeServiceUnit.DataSource = dtS;
                storeServiceUnit.DataBind();
                storeUser.DataSource = dtU;
                storeUser.DataBind();
                
                smGrdServiceUnit.Select(0);               
                smGrdServiceUnit.UpdateSelection();
            }
        }

        [DirectMethod]
        public void storeServiceUnit_Refresh(object sender, StoreReadDataEventArgs e)
        {
            DataTable dtU = new DataTable();
            DataTable dtS = new DataTable();            
            AppUserQuery uQ = new AppUserQuery("a");
            uQ.es2.Connection.Name = "KENCANA";
            ServiceUnitQuery sQ = new ServiceUnitQuery("b");
            sQ.es2.Connection.Name = "KENCANA";
            dtU = uQ.LoadDataTable();
            dtS = sQ.LoadDataTable();

            storeServiceUnit.DataSource = dtS;
            storeServiceUnit.DataBind();            
        }

        [DirectMethod]
        public void storeUser_Refresh(object sender, StoreReadDataEventArgs e)
        {
            DataTable dtU = new DataTable();
            DataTable dtS = new DataTable();
            AppUserQuery uQ = new AppUserQuery("a");
            uQ.es2.Connection.Name = "KENCANA";
            ServiceUnitQuery sQ = new ServiceUnitQuery("b");
            sQ.es2.Connection.Name = "KENCANA";
            dtU = uQ.LoadDataTable();
            dtS = sQ.LoadDataTable();
            
            storeUser.DataSource = dtU;
            storeUser.DataBind();
        }

        [DirectMethod]
        public void storeUserOfServiceUnit_Refresh(object sender, StoreReadDataEventArgs e)
        {

        }

        [DirectMethod]
        public void grdServiceUnit_Select()
        {
            string ServiceUnitID = string.Empty;
            RowSelectionModel rmSU = this.grdServiceUnit.GetSelectionModel() as RowSelectionModel;
            if (rmSU.SelectedRows.Count > 0)
            {
                ServiceUnitID = rmSU.SelectedRow.RecordID;
                Session["ServiceUnitID"] = ServiceUnitID;
            }

            MessageBus.Default.Publish("grdServiceUnit_Select", ServiceUnitID);

            //Select all user that still unassigned
            ADefHelpDeskUserUserGroupQuery userGroupC = new ADefHelpDeskUserUserGroupQuery("ug");
            ADefHelpDeskUserRolesCollection userGroupCol = new ADefHelpDeskUserRolesCollection();
            userGroupC.Select(userGroupC.UserID);
            //userGroupC.Where(userGroupC.UserServiceUnitID == Session["ServiceUnitID"].ToString().Trim());

            ADefHelpDeskUsersQuery userQ = new ADefHelpDeskUsersQuery("u");
            ADefHelpDeskUsersCollection userC = new ADefHelpDeskUsersCollection();
            userQ.Select(userQ.Username.As("UserID"), userQ.FirstName.As("UserName")).Where(userQ.Username.NotIn(userGroupC)).OrderBy(userQ.FirstName.Ascending);
            DataTable dtU = new DataTable();
            dtU = userQ.LoadDataTable();

            string UserID = string.Empty;
            foreach (DataRow dr in dtU.Rows)
            {
                UserID = dr["UserID"].ToString();
                ADefHelpDeskUserUserGroupQuery uQ = new ADefHelpDeskUserUserGroupQuery("a");
                ADefHelpDeskUserUserGroupCollection uC = new ADefHelpDeskUserUserGroupCollection();
                uQ.SelectAll().Where(uQ.UserID == UserID);
                uC.Load(uQ);
                if (uC.Count > 0)
                    dr.Delete();
            }
            dtU.AcceptChanges();
            storeUser.DataSource = dtU;
            storeUser.DataBind();

            //Select all user that belong to selected service unit
            ADefHelpDeskUsersQuery user = new ADefHelpDeskUsersQuery("uu");
            ADefHelpDeskUserUserGroupQuery usergroup = new ADefHelpDeskUserUserGroupQuery("uugg");
            usergroup.Select(usergroup.UserID, usergroup.UserServiceUnitID, user.FirstName.As("UserName"))
                .Where(usergroup.UserServiceUnitID == ServiceUnitID)
                .InnerJoin(user).On(usergroup.UserID == user.Username);
            //ADefHelpDeskUserUserGroupCollection userSelectedSU = new ADefHelpDeskUserUserGroupCollection();
            //userSelectedSU.Query.SelectAll().Where(userSelectedSU.Query.UserServiceUnitID == ServiceUnitID);
            //DataTable dtUSU = userSelectedSU.Query.LoadDataTable();
            DataTable dtUSU = usergroup.LoadDataTable();
            //foreach (DataRow dr in dtUSU.Rows)
            //{
 
            //}
            storeUserOfServiceUnit.DataSource = dtUSU;
            storeUserOfServiceUnit.DataBind();
        }

        [DirectMethod]
        public void grdUser_Select()
        {
 
        }

        [DirectMethod]
        public void grdUser_Refresh_From_Select(string ServiceUnitID)
        {
            //DataTable dtU = new DataTable();
            //DataTable dtS = new DataTable();
            //AppUserQuery uQ = new AppUserQuery("a");
            //uQ.SelectAll();
            //uQ.es2.Connection.Name = "KENCANA";
            //ServiceUnitQuery sQ = new ServiceUnitQuery("b");
            //sQ.SelectAll();
            //sQ.es2.Connection.Name = "KENCANA";
            //dtU = uQ.LoadDataTable();
            //dtS = sQ.LoadDataTable();
            //storeServiceUnit.DataSource = dtS;
            //storeServiceUnit.DataBind();
            //storeUser.DataSource = dtU;
            //storeUser.DataBind();            
        }

        [DirectMethod]
        public void grdUserOfServiceUnit_Drop(string UserID)
        {
            if (Session["ServiceUnitID"] == null)
                return;
            string ServiceUnitID = Session["ServiceUnitID"].ToString().Trim();
            ADefHelpDeskUserUserGroup ug = new ADefHelpDeskUserUserGroup();
            if (!ug.LoadByPrimaryKey(UserID, ServiceUnitID))
            {
                ug.UserID = UserID;
                ug.UserServiceUnitID = ServiceUnitID;
                ug.Save();
            }
        }

        [DirectMethod]
        public void grdUser_Drop(string UserID)
        {
            if (Session["ServiceUnitID"] == null)
                return;
            string ServiceUnitID = Session["ServiceUnitID"].ToString().Trim();
            ADefHelpDeskUserUserGroup ug = new ADefHelpDeskUserUserGroup();
            if (ug.LoadByPrimaryKey(UserID, ServiceUnitID))
            {
                ug.MarkAsDeleted();
                ug.Save();
            }
        }
    }
}