using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Data;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace BLDLTemplate
{
    public partial class CreditCardDetails : System.Web.UI.Page
    {
        clsCommonBL objCM = new clsCommonBL();
        CommunicationService objService = new CommunicationService();
        int GlobalValue = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCustomerName.DataSource = objCM.GetCustomerName();
                ddlCustomerName.DataTextField = "customername";
                ddlCustomerName.DataValueField = "customerID";
                ddlCustomerName.DataBind();
               /* DataSet dsCustomerAndBank = objCM.fnGetCountryAndBank();
                ddlBank.DataSource = dsCustomerAndBank.Tables[1];
                ddlBank.DataTextField = "name";
                ddlBank.DataValueField = "BankID";
                ddlBank.DataBind(); */
            }
        }

        protected void ValidateDuration(object sender, ServerValidateEventArgs e)
        {
            
            DateTime start = DateTime.Parse(txtRegistrationdate.Text);
            DateTime end = DateTime.Parse(txtExpirydate.Text);
            TimeSpan ts = end - start;
            e.IsValid = ts.Days >= (365 * 10);
            if (e.IsValid == true)
            {
                GlobalValue = 1;
            }
            
        }

        protected void txtRegistrationdate_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtCreditcarddetails_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
           DataSet dsNumberCheck= objService.CheckCreditCardNumber(txtCreditnumber.Text);
           if (dsNumberCheck != null)
           {
               if (dsNumberCheck.Tables[0] != null)
               {
                   if (dsNumberCheck.Tables[0].Rows.Count > 0)
                   {
                       ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "failure", "alert('This Credit Card number has been taken.Please specify different number');", true);
                       return;
                   }
               }
           }

           if (ddlBank.SelectedIndex != 0 && ddlCustomerName.SelectedIndex != 0)
           {
               DataSet dsValidityCheck = objService.ValidateCreditAvailability(Convert.ToInt32(ddlCustomerName.SelectedValue), ddlBank.SelectedValue);
               if (dsValidityCheck != null)
               {
                   if (dsValidityCheck.Tables[0] != null)
                   {
                       if (dsValidityCheck.Tables[0].Rows.Count > 0)
                       {
                           ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "failure", "alert('Credit card is already dispatched.Multiple credit cards are not allowed');", true);
                           return;
                       }
                   }
               }
           }


            if (GlobalValue == 1)
            {
                DateTime start = DateTime.Parse(txtRegistrationdate.Text);
                DateTime end = DateTime.Parse(txtExpirydate.Text);
                TimeSpan ts = end - start;
                int years = ts.Days / 365;
                Boolean FalgLocked = Convert.ToBoolean(Convert.ToInt32(rbtLocked.SelectedValue));
                Boolean FalgValid = Convert.ToBoolean(Convert.ToInt32(rbtValid.SelectedValue));
                string NameofPDF = txtCreditnumber.Text + ".pdf";
                string ReportPath = Server.MapPath("CustomerReports/" + NameofPDF);
                int ReturnId = 0;
                int ReturnCustomerId = 0;
                string ReturnEmailId = String.Empty;
                objService.InsertCreditCardDetails(ddlCustomerName.SelectedValue, ddlBank.SelectedValue, txtCreditnumber.Text, txtCreditcarddetails.Text, Convert.ToDateTime(txtExpirydate.Text), Convert.ToInt32(years), Convert.ToInt32(txtcvvnumber.Text), Convert.ToDateTime(txtRegistrationdate.Text), FalgValid, FalgLocked, "I", ReportPath, out ReturnCustomerId, out ReturnEmailId);
                string AttachmentPath = GenerateReport(ReturnCustomerId, ddlBank.SelectedValue, ReportPath);
                string Subject = "Your Credit Card Details";
                string BodyDescription = "Please find the attachment which contains your Credit Card Details";
                string Body = PopulateBody(ddlCustomerName.SelectedItem.Text, BodyDescription);
                objCM.SendMail(AttachmentPath, ReturnEmailId, Subject, Body);
                ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Success", "alert('Credit Card has been dispatched. Please check your mail for details');", true);
            }
            }


        #region Function To Generate the Report in Pdf and Export it to disk
        public string GenerateReport(int ReturnID, string BankID, string ReportPath)
        {
            ReportDocument rptDoc = null;
            System.IO.MemoryStream objStr = null;
            try
            {
                string Path = "~/Reports/rptCreditCardDetails.rpt";
                rptDoc = new ReportDocument();
                rptDoc.Load(Server.MapPath(Path));
                rptDoc.SetParameterValue("@customerId", ReturnID);
                rptDoc.SetParameterValue("@BankId", BankID);
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
            return "";
        }
        #endregion

        #region Function to populate the body
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


        #region Function to Populate the bank Details in drop down
        protected void ddlCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dsBank = new DataSet();
            try
            {
                ddlBank.Items.Clear();
                CommunicationService objService = new CommunicationService();
                dsBank = objService.GetOnlyRequiedBank(Convert.ToInt32(ddlCustomerName.SelectedValue));
                DataRow dr = dsBank.Tables[0].NewRow();
                dr[0] = "---------------------------Select Bank----------------------------------";
                dr[1] = 0;
                
                dsBank.Tables[0].Rows.InsertAt(dr, 0);
                ddlBank.DataSource = dsBank.Tables[0];
                ddlBank.DataTextField = "BankName";
                ddlBank.DataValueField = "BankID";
                ddlBank.DataBind();
            }
            catch
            {
            }
            finally
            {
                objService = null;
                dsBank = null;
            }

        }
        #endregion

        #region Fucntion to Populate registration date
        protected void ddlBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dsBank = new DataSet();
            try
            {
                //ddlBank.Items.Clear();
                CommunicationService objService = new CommunicationService();
                dsBank = objService.GetRegistrationDate(Convert.ToInt32(ddlCustomerName.SelectedValue), ddlBank.SelectedValue);
                //DataRow dr = dsBank.Tables[0].NewRow();
                //dr[0] = 0;
                //dr[1] = "---Select State---";
                //dsBank.Tables[0].Rows.InsertAt(dr, 0);
                //ddlBank.DataSource = dsBank.Tables[0];
                txtRegistrationdate.Text = dsBank.Tables[0].Rows[0]["regdate"].ToString().Split(' ')[0];
            }
            catch
            {
            }
            finally
            {
                objService = null;
                dsBank = null;
                
            }
        }
        #endregion 
    }
}