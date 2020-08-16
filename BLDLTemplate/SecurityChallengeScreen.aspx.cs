using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
namespace BLDLTemplate
{
    public partial class SecurityChallengeScreen : System.Web.UI.Page
    {
        clsCommonBL objCM = new clsCommonBL();
        CommunicationService objService = new CommunicationService();

        #region Page_Load Event
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlQuestion.DataSource = objCM.GetSecurityQuestion();
                ddlQuestion.DataTextField = "question";
                ddlQuestion.DataValueField = "questionid";
                ddlQuestion.DataBind();
            }
        } 
        #endregion

        #region btnSubmit_Click Event
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int Returncode = objService.InsertCustomerAnswer(Convert.ToInt32(Session["CustomerId"]), Session["BankID"].ToString(), Convert.ToInt32(ddlQuestion.SelectedValue), txtAnswer.Text);
            if (Returncode == 1)
            {
                ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Success", "alert('Security answer has been Inserted successfully');", true);
                Response.Redirect("~/DailyTransactionScreen.aspx");
            }
            if (Returncode == 2)
            {
                ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Success", "alert('Security answer has been Updated successfully');", true);
                Response.Redirect("~/DailyTransactionScreen.aspx");
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Success", "alert('Security answer insertion failed');", true);
            }


        } 
        #endregion
    }
}