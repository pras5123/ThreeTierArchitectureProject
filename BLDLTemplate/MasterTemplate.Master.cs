using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BLDLTemplate
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkLogOut_Click(object sender, EventArgs e)
        {
           // Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }

        protected void lnkExportOption_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ExportOption.aspx");           
        }
    }
}