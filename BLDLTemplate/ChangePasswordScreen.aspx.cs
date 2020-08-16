using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
namespace BLDLTemplate
{
    public partial class ChangePasswordScreen : System.Web.UI.Page
    {
        clsCommonBL objCM = new clsCommonBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    try
            //    {
            //        int ReturnCode = objCM.IncrementCount(Convert.ToInt32(Session["CustomerId"]));
            //    }
            //    catch (Exception ex)
            //    {
            //    }
            //    finally
            //    {
            //        objCM = null;
            //    }
            //}
            
        }

        protected void btnchange_Click(object sender, EventArgs e)
        {
            int CustomerId = Convert.ToInt32(Session["CustomerId"]);
            int ReturnCode = objCM.ChangePassword(CustomerId, txtoldpassword.Text, txtNewPassword.Text);
            if (ReturnCode == 1)
            {
                ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Success", "alert('Password has been changed successfully');", true);
                Response.Redirect("~/SecurityChallengeScreen.aspx");
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Success", "alert('Password change failed. Your old password might be incorrect');", true);
            }
        }
    }
}