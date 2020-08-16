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
    public partial class DailyTransactionScreen : System.Web.UI.Page
    {
        clsCommonBL objCM = new clsCommonBL();
        CommunicationService objService = new CommunicationService();


        #region Page Load Event
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet dsCustomerBank = null;
            if (!IsPostBack)
            {
                try
                {
                    dsCustomerBank = objCM.GetBankForCustomer(Convert.ToInt32(Session["CustomerId"]));
                    ddlBank.DataSource = dsCustomerBank.Tables[0];
                    ddlBank.DataValueField = "BankID";
                    ddlBank.DataTextField = "name";
                    ddlBank.DataBind();
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    dsCustomerBank = null;
                }

            }
        } 
        #endregion

        #region btnSubmit_Click Event
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            DataSet dsTransaction = null;
            try
            {
                dsTransaction = objService.GetMyAccountDetails(Convert.ToInt32(Session["CustomerId"]), ddlBank.SelectedValue);
                if (dsTransaction != null)
                {
                    if (dsTransaction.Tables[0] != null)
                    {
                        if (dsTransaction.Tables[0].Rows.Count > 0)
                        {
                            gvBalance.DataSource = dsTransaction.Tables[0];
                            gvBalance.DataBind();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {

            }

        } 
        #endregion

        #region gvBalance_RowCommand Event
        protected void gvBalance_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "View")
            {
                // GridViewRow rw = (GridViewRow)(((Control)e.CommandSource).NamingContainer);
                // Label lblTaskName = (Label)rw.FindControl("lblTaskName");
                DataSet dsTransaction = null;
                try
                {
                    dsTransaction = objService.TransactionBetweenDates(null, null, Convert.ToInt32(Session["CustomerId"]), ddlBank.SelectedValue);
                    if (dsTransaction != null)
                    {
                        if (dsTransaction.Tables[0] != null)
                        {
                            if (dsTransaction.Tables[0].Rows.Count > 0)
                            {
                                Session["AllTransaction"] = dsTransaction.Tables[0];
                                gvTransaction.DataSource = dsTransaction.Tables[0];
                                gvTransaction.DataBind();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }
                finally
                {

                }
            }
        } 
        #endregion

        protected void gvTransaction_PageIndexChanged(object sender, EventArgs e)
        {
            //Session["AllTransaction"]

            try
            {
                gvTransaction.DataSource = Session["AllTransaction"];
                gvTransaction.DataBind();
            }
            catch (Exception ex)
            {
            }
            finally
            {

            }
        }

        protected void gvTransaction_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                gvTransaction.DataSource = Session["AllTransaction"];
                gvTransaction.PageIndex = e.NewPageIndex;
                gvTransaction.DataBind();
            }
            catch (Exception ex)
            {
            }
            finally
            {

            }

        }

        //private void SetVisibilityForUsers()
        //{
        //    LinkButton lnkTransaction = (LinkButton)Master.FindControl("lnkTransaction") as LinkButton;
        //    LinkButton lnkSecurityChallenge = (LinkButton)Master.FindControl("lnkSecurityChallenge") as LinkButton;
        //    LinkButton lnkExportOption = (LinkButton)Master.FindControl("lnkExportOption") as LinkButton;
        //    LinkButton lnkDailyTransaction = (LinkButton)Master.FindControl("lnkDailyTransaction") as LinkButton;
        //    LinkButton lnkTransactionPayment = (LinkButton)Master.FindControl("lnkTransactionPayment") as LinkButton;
        //    lnkTransaction.Visible = true;
        //    lnkSecurityChallenge.Visible = true;
        //    lnkExportOption.Visible = true;
        //    lnkDailyTransaction.Visible = true;
        //    lnkTransactionPayment.Visible = true;
        //    LinkButton lnkCustomerRegistration = (LinkButton)Master.FindControl("lnkCustomerRegistration") as LinkButton;
        //    LinkButton lnkCreditCardDetails = (LinkButton)Master.FindControl("lnkCreditCardDetails") as LinkButton;
        //    LinkButton lnkImportDetails = (LinkButton)Master.FindControl("lnkImportDetails") as LinkButton;
        //    LinkButton lnkValidateUnlock = (LinkButton)Master.FindControl("lnkValidateUnlock") as LinkButton;
        //    LinkButton lnkViewCustomerReport = (LinkButton)Master.FindControl("lnkViewCustomerReport") as LinkButton;
        //    LinkButton lnkMasterBankDetails = (LinkButton)Master.FindControl("lnkMasterBankDetails") as LinkButton;
        //    lnkCustomerRegistration.Visible = false;
        //    lnkCreditCardDetails.Visible = false;
        //    lnkImportDetails.Visible = false;
        //    lnkValidateUnlock.Visible = false;
        //    lnkViewCustomerReport.Visible = false;
        //    lnkMasterBankDetails.Enabled = false;
        //}


    }
}