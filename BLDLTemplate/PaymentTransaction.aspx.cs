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
    public partial class PaymentTransaction : System.Web.UI.Page
    {
        clsCommonBL objCM = new clsCommonBL();
        CommunicationService objService = new CommunicationService();

        #region Page_Load Event
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["CustomerId"] != null)
                {
                    DataSet dsCustomerBank = objCM.GetBankForCustomer(Convert.ToInt32(Session["CustomerId"]));
                    ddlBank.DataSource = dsCustomerBank.Tables[0];
                    ddlBank.DataValueField = "BankID";
                    ddlBank.DataTextField = "name";
                    ddlBank.DataBind();
                }
            }
        } 
        #endregion

        #region ddlBank_SelectedIndexChanged Event
        protected void ddlBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["BankID"] = ddlBank.SelectedValue;

            //replacing BankId so that transaction will carried out with that bank
        } 
        #endregion

        #region ddlProductType_SelectedIndexChanged Event
        protected void ddlProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlProductType.SelectedIndex == 0)
            {
                lblCostOfProduct.Text = "0";
             
            }
            else if (ddlProductType.SelectedIndex == 1)
            {
                lblCostOfProduct.Text = "100";
            }
            else if (ddlProductType.SelectedIndex == 2)
            {
                lblCostOfProduct.Text = "200";

            }
            else if (ddlProductType.SelectedIndex == 3)
            {
                lblCostOfProduct.Text = "300";
            }
            else
            {
                lblCostOfProduct.Text = "400";
            }
            Session["ProductCost"] = lblCostOfProduct.Text;

            int ReturnCode = objService.CheckAmountAvailability(Session["BankID"].ToString(), Convert.ToInt32(Session["CustomerId"]), Convert.ToDecimal(lblCostOfProduct.Text));
            if (ReturnCode == 1)
            {
                if (ddlProductType.SelectedIndex == 0)
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