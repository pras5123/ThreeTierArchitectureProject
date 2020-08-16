using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace BLDLTemplate
{
    public partial class Customerregform : System.Web.UI.Page
    {
        clsCommonBL objCM = new clsCommonBL();
        CommunicationService objService = new CommunicationService();

        #region Page Load
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // SetVisibilityForBankadmin();
                DataSet dsCustomerAndBank = objCM.fnGetCountryAndBank();
                ddlCountry.DataSource = dsCustomerAndBank.Tables[0];
                ddlCountry.DataTextField = "countryname";
                ddlCountry.DataValueField = "countryID";
                ddlCountry.DataBind();
                ddlBank.DataSource = dsCustomerAndBank.Tables[1];
                ddlBank.DataTextField = "name";
                ddlBank.DataValueField = "BankID";
                ddlBank.DataBind();
            }
        } 
        #endregion

        #region Country selected Index changed event
        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataSet dsState = null;
            try
            {
                ddlState.Items.Clear();
                dsState = objCM.GetStateList(ddlCountry.SelectedValue);
                DataRow dr = dsState.Tables[0].NewRow();
                dr[0] = 0;
                dr[1] = "---Select State---";
                dsState.Tables[0].Rows.InsertAt(dr, 0);
                ddlState.DataSource = dsState.Tables[0];
                ddlState.DataTextField = "countryname";
                ddlState.DataValueField = "statesID";
                ddlState.DataBind();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                // dsState.Dispose();
            }


        } 
        #endregion

        #region State selected Index changed
        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dsCity = null;
            try
            {
                ddlCity.Items.Clear();
                dsCity = objCM.GetCityList(ddlState.SelectedValue);
                DataRow dr = dsCity.Tables[0].NewRow();
                dr[0] = 0;
                dr[1] = "---Select City---";
                dsCity.Tables[0].Rows.InsertAt(dr, 0);
                ddlCity.DataSource = dsCity.Tables[0];
                ddlCity.DataTextField = "cityname";
                ddlCity.DataValueField = "cityID";
                ddlCity.DataBind();
            }
            catch (Exception ex)
            {
            }
            finally
            {

            }
        } 
        #endregion

        #region Register Event
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            DataSet dsAvailabillity = objService.CheckCustomerName(txtCustomerName.Text);
            if (dsAvailabillity != null)
            {
                if (dsAvailabillity.Tables[0] != null)
                {
                    if (dsAvailabillity.Tables[0].Rows.Count > 0)
                    {
                        ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Failure", "alert('Entered Customer Name is already Taken');", true);
                        return;
                    }
                }
            }
            string NameofPDF = txtCustomerName.Text + txtContact.Text.Substring(txtContact.Text.Length - 4) + ".pdf"; //getting last 4 digit concatenated with
            string ReportPath = Server.MapPath("CustomerReports/" + NameofPDF);
            int ReturnID = InsertValuesToCustomer(ReportPath);
            string AttachmentPath = GenerateReport(ReturnID, ReportPath);
            string Subject = "Your Registration Details";
            string BodyDescription = "Thanks for Registering with us. You can get the registration details along with your credential in the auto attached pdf";
            string Body = PopulateBody(txtCustomerName.Text, BodyDescription);
            objCM.SendMail(AttachmentPath, txtEmail.Text, Subject, Body);
        } 
        #endregion

        #region PopulateBody
        private string PopulateBody(string userName, string BodyDescription)
        {
            string body = string.Empty;
            using (StreamReader reader = new StreamReader(Server.MapPath("EmailTemplate/EmailTemplate.htm")))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("{UserName}", userName);
            body = body.Replace("{MailBody}", BodyDescription);
            return body;
        } 
        #endregion

        #region Function to Insert values to customer,custbank,balancedetails
        private int InsertValuesToCustomer(string ReportPath)
        {
            decimal TotalBalance = 0;
            int ReturnID = 0;
            Random rnd = new Random();
            string UserId = txtCustomerName.Text + txtContact.Text.Substring(txtContact.Text.Length-2);
            string Password = rnd.Next(99998999).ToString();
            int OldAtmPIN = rnd.Next(1000,9999);
            long AccountNumber = Convert.ToInt64(rnd.Next(999779798).ToString() + rnd.Next(4324234).ToString());
            string TransactionPassword = rnd.Next(3423).ToString() + txtContact.Text;
            if (rbtnYesNo.SelectedIndex == 0)
            {
                TotalBalance = 1000;
            }
            else
            {
                TotalBalance = 500;
            }
            //clsCommonBL objCM = new clsCommonBL();
            int returnCode = objService.InsertCustomerAndBank(txtCustomerName.Text, txtAddressLine1.Text, txtAddressLine2.Text, txtAdddressLine3.Text, ddlCity.SelectedItem.Text, ddlState.SelectedItem.Text, ddlCountry.SelectedItem.Text, txtEmail.Text, rbtnSex.SelectedItem.Text.First().ToString(), txtContact.Text, txtOtherContact.Text, ddlBank.SelectedValue, UserId, Password, OldAtmPIN, TransactionPassword, AccountNumber, TotalBalance, out ReturnID, ReportPath, txtPanCardNumber.Text);
            if (returnCode == 1)
            {
                ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Success", "alert('Registration Successful. Please check your mail for Credentials');", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Success", "alert('registration failed');", true);
            }
            return ReturnID;
        }
        #endregion

        #region Function To Generate the Report in Pdf and Export it to disk
        public string GenerateReport(int ReturnID, string ReportPath)
        {
            ReportDocument rptDoc = null;
            System.IO.MemoryStream objStr = null;
            try
            {
                string Path = "~/Reports/rptCustomerRegistrationBank.rpt";
                rptDoc = new ReportDocument();
                rptDoc.Load(Server.MapPath(Path));
                rptDoc.SetParameterValue("@customerId", ReturnID);
                rptDoc.SetParameterValue("@BankID", ddlBank.SelectedValue);
                objStr = (System.IO.MemoryStream)rptDoc.ExportToStream(ExportFormatType.PortableDocFormat);             
                
                rptDoc.ExportToDisk(ExportFormatType.PortableDocFormat, ReportPath);
                return ReportPath;
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                return string.Empty;       
            }
            finally
            {

            }
        }
        #endregion

        //private void SetVisibilityForBankadmin()
        //{
        //    LinkButton lnkCustomerRegistration = (LinkButton)Master.FindControl("lnkCustomerRegistration") as LinkButton;
        //    LinkButton lnkCreditCardDetails = (LinkButton)Master.FindControl("lnkCreditCardDetails") as LinkButton;
        //    LinkButton lnkImportDetails = (LinkButton)Master.FindControl("lnkImportDetails") as LinkButton;
        //    LinkButton lnkValidateUnlock = (LinkButton)Master.FindControl("lnkValidateUnlock") as LinkButton;
        //    LinkButton lnkViewCustomerReport = (LinkButton)Master.FindControl("lnkViewCustomerReport") as LinkButton;
        //    LinkButton lnkMasterBankDetails = (LinkButton)Master.FindControl("lnkMasterBankDetails") as LinkButton;
        //    lnkCustomerRegistration.Visible = true;
        //    lnkCreditCardDetails.Visible = true;
        //    lnkImportDetails.Visible = true;
        //    lnkValidateUnlock.Visible = true;
        //    lnkViewCustomerReport.Visible = true;
        //    lnkMasterBankDetails.Visible = true;

        //    LinkButton lnkTransaction = (LinkButton)Master.FindControl("lnkTransaction") as LinkButton;
        //    LinkButton lnkSecurityChallenge = (LinkButton)Master.FindControl("lnkSecurityChallenge") as LinkButton;
        //    LinkButton lnkExportOption = (LinkButton)Master.FindControl("lnkExportOption") as LinkButton;
        //    LinkButton lnkDailyTransaction = (LinkButton)Master.FindControl("lnkDailyTransaction") as LinkButton;
        //    LinkButton lnkTransactionPayment = (LinkButton)Master.FindControl("lnkTransactionPayment") as LinkButton;
        //    lnkTransaction.Visible = false;
        //    lnkSecurityChallenge.Visible = false;
        //    lnkExportOption.Visible = false;
        //    lnkDailyTransaction.Visible = false;
        //    lnkTransactionPayment.Visible = false;



        //}

    }
}