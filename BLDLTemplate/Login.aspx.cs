using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Data;

namespace BLDLTemplate
{
    public partial class Login : System.Web.UI.Page
    {
        clsCommonBL objCM = new clsCommonBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Abandon();
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DataSet dsCustomer = objCM.GetUserCredential(txtUserName.Text, txtPassword.Text);

            if (dsCustomer.Tables[0].Rows != null)
            {
                if (dsCustomer.Tables[0].Rows.Count > 0)
                {
                    Session["CustomerId"] = dsCustomer.Tables[0].Rows[0]["customerID"];
                    if (Session["CustomerId"].ToString() == "Bank Admin")
                    {
                        Response.Redirect("~/CustomerRegform.aspx");
                    }
                    else
                    {
                       
                        if (dsCustomer.Tables[0].Rows[0]["LoginCount"] != null)
                        {
                            
                            Session["BankID"]=dsCustomer.Tables[0].Rows[0]["BankID"].ToString();
                            objCM.IncrementCount(Convert.ToInt32(Session["CustomerId"]), Session["BankID"].ToString());
                            if (Convert.ToInt32(dsCustomer.Tables[0].Rows[0]["LoginCount"]) == 0)
                            {
                                Response.Redirect("~/ChangePasswordScreen.aspx");
                            }
                            else
                            {
                                Response.Redirect("~/DailyTransactionScreen.aspx");                          
                            }
                        }
                        
                    }
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Success", "alert('You are not Authorized');", true);
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Success", "alert('You are not Authorized');", true);
            }
        }

        protected void lnkForgotPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ForgotPassword.aspx");
        }

  


       

    }
}