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
                
            }

            MessageBus.Default.Publish("grdServiceUnit_Select", ServiceUnitID);

            //Select all user that still unassigned
            ADefHelpDeskUserUserGroupQuery userGroupC = new ADefHelpDeskUserUserGroupQuery("ug");
            userGroupC.Select(userGroupC.UserID);

            ADefHelpDeskUsersQuery userQ = new ADefHelpDeskUsersQuery("u");
            ADefHelpDeskUsersCollection userC = new ADefHelpDeskUsersCollection();
            userQ.Select(userQ.Username.As("UserID"), userQ.FirstName.As("UserName")).Where(userQ.Username.NotIn(userGroupC));
            DataTable dtU = new DataTable();
            dtU = userQ.LoadDataTable();
            storeUser.DataSource = dtU;
            storeUser.DataBind();

            //Select all user that belong to selected service unit
            ADefHelpDeskUserUserGroupCollection userSelectedSU = new ADefHelpDeskUserUserGroupCollection();
            userSelectedSU.Query.SelectAll().Where(userSelectedSU.Query.UserServiceUnitID == ServiceUnitID);
            DataTable dtUSU = userSelectedSU.Query.LoadDataTable();
            storeUserOfServiceUnit.DataSource = dtUSU;
            storeUserOfServiceUnit.DataBind();
        }

        [DirectMethod]
        public void grdUser_Select(object sender, DirectEventArgs e)
        {
 
        }

        [DirectMethod]
        public void grdUser_Refresh_From_Select(string ServiceUnitID)
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

            var storeSU = X.GetCmp<Store>("storeServiceUnit");
            Model m = new Model();
            //model for Service Unit ID
            m.ID = "model_1";
            m.IDProperty = "ServiceUnitID";
            ModelField mf1 = new ModelField("ServiceUnitID");
            m.Fields.Add(mf1);
            //model for Service Name
            ModelField mf2 = new ModelField("ServiceUnitName");
            m.Fields.Add(mf2);
            storeSU.Model.Clear();
            storeSU.Model.Add(m);
            storeSU.DataSource = dtS;
            storeSU.DataBind();
            //storeServiceUnit.DataSource = dtS;
            //storeServiceUnit.DataBind();
            storeUser.DataSource = dtU;
            storeUser.DataBind();
            this.grdUser.Store.Primary.DataBind();
        }
    }
}