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
    }
}