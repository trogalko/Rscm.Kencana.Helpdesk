using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;

namespace Rscm.Kencana.Helpdesk.Task
{
    public partial class TaskEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [DirectMethod]
        public void Close()
        {
            X.Msg.Alert("A", "Alooo").Show();
        }
    }
}