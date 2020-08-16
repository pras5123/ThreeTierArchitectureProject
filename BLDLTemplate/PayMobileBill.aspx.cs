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
    public partial class PayMobileBill : System.Web.UI.Page
    {
        //clsCommonBL objCM = new clsCommonBL();
        CommunicationService objService = new CommunicationService();

        #region Page_Load Event
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //trUniquepay.Style.Add("display", "none");
                int CustomerId = 0;
                int AtmPin = 0;
                if (Request.QueryString["CustomerId"] != null)
                {
                    CustomerId = Convert.ToInt32(Request.QueryString["CustomerId"].ToString());
                    Session["CustomerId"] = CustomerId;
                }
                if(Request.QueryString["AtmPIN"] != null)
                {

                    AtmPin = Convert.ToInt32(Request.QueryString["AtmPIN"].ToString());
                    Session["AtmPin"] = AtmPin;
                }
                
                DataSet dsCustomerBank = objService.GetBankWithBranch(DBNull.Value.ToString(), CustomerId, AtmPin);
                ddlBank.DataSource = dsCustomerBank.Tables[0];
                ddlBank.DataValueField = "BankID";
                ddlBank.DataTextField = "name";
                ddlBank.DataBind();

            }
        } 
        #endregion

        #region ddlBank_SelectedIndexChanged Event
        protected void ddlBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["BankID"] = ddlBank.SelectedValue;
            Session["MobilePaymant"] = "BillPay";
        } 
        #endregion

        #region txtAmount_TextChanged Event
        protected void txtAmount_TextChanged(object sender, EventArgs e)
        {
          Session["ProductCost"] = txtAmount.Text;
          int ReturnCode=  objService.CheckAmountAvailability(Session["BankID"].ToString(),Convert.ToInt32(Session["CustomerId"]),Convert.ToDecimal(txtAmount.Text));
          if (ReturnCode == 1)
          {
              if (txtAmount.Text == "0")
              {
                  trUniquepay.Style.Add("display", "none");
              }
              else
              {
                  trUniquepay.Style.Add("display", "table-row");
              }
             
          }
          else
          {
              ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Success", "alert('You do not have sufficient amount to carry out this transaction');", true);
              trUniquepay.Style.Add("display", "none");
              return;
          }
          
        } 
        #endregion
    }
}