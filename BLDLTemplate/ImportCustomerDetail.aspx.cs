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
    public partial class ImportCustomerDetail : System.Web.UI.Page
    {
        clsCommonBL objCM = new clsCommonBL();
        CommunicationService objService = new CommunicationService();


        #region Page_Load Event
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtContact.Attributes.Add("readonly", "readonly");

                txtCustomerName.Attributes.Add("readonly", "readonly");
                txtEmail.Attributes.Add("readonly", "readonly");
                DataSet dsCustomerAndBank = objCM.fnGetCountryAndBank();
                ddlToBank.DataSource = dsCustomerAndBank.Tables[1];
                ddlToBank.DataTextField = "name";
                ddlToBank.DataValueField = "BankID";
                ddlToBank.DataBind();
                ddlFromBank.DataSource = dsCustomerAndBank.Tables[1];
                ddlFromBank.DataTextField = "name";
                ddlFromBank.DataValueField = "BankID";
                ddlFromBank.DataBind();
            }
        } 
        #endregion

        #region btnImport_Click Event
        protected void btnImport_Click(object sender, EventArgs e)
        {
            if (ddlFromBank.SelectedValue == ddlToBank.SelectedValue)
            {
                ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Success", "alert('Existing Bank cannot be same as To Bank Branch');", true);
                return;
            }
            string NameofPDF = txtCustomerName.Text + txtContact.Text.Substring(txtContact.Text.Length - 6) + ".pdf"; //getting last 4 digit concatenated with
            string ReportPath = Server.MapPath("CustomerReports/" + NameofPDF);
            int ReturnID = InsertValuesToCustomer(ReportPath);
            string AttachmentPath = GenerateReport(ReturnID, ddlToBank.SelectedValue, ReportPath);
            string Subject = "Your Registration Details";
            string BodyDescription = "Please find the attachment which contains your credential";
            string Body = PopulateBody(txtCustomerName.Text, BodyDescription);
            objCM.SendMail(AttachmentPath, txtEmail.Text, Subject, Body);
            ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Success", "alert('Import is successful. Please check your mail for Credentials');", true);
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

        #region Function to Insert values to customer,custbank,balancedetails
        private int InsertValuesToCustomer(string ReportPath)
        {
            decimal TotalBalance = 0;
            int ReturnID = 0;
            Random rnd = new Random();
            string UserId = txtCustomerName.Text + txtContact.Text.Substring(txtContact.Text.Length - 2);
            string Password = rnd.Next(89999898).ToString();
            int OldAtmPIN = rnd.Next(9999);
            long AccountNumber =Convert.ToInt64(rnd.Next(989898989).ToString() + rnd.Next(9999999).ToString());
            string TransactionPassword = rnd.Next(3243423).ToString() + txtContact.Text;
            if (rbtnYesNo.SelectedIndex == 0)
            {
                TotalBalance = 1000;
            }
            else
            {
                TotalBalance = 500;
            }
            //clsCommonBL objCM = new clsCommonBL();
            // out ReturnID
            int returnCode = objService.ImportCustomerDetails(ddlToBank.SelectedValue, UserId, Password, OldAtmPIN, TransactionPassword, AccountNumber, TotalBalance, ReportPath, out ReturnID, Convert.ToInt64(txtAccountNumber.Text));
           
            return ReturnID;
        }
        #endregion

        #region Function To Generate the Report in Pdf and Export it to disk
        public string GenerateReport(int ReturnID,string BankID, string ReportPath)
        {
            ReportDocument rptDoc = null;
            System.IO.MemoryStream objStr = null;
            try
            {
                string Path = "~/Reports/rptCustomerRegistrationBank.rpt";
                rptDoc = new ReportDocument();
                rptDoc.Load(Server.MapPath(Path));
                rptDoc.SetParameterValue("@customerId", ReturnID);
                rptDoc.SetParameterValue("@BankID", BankID);
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

        #region Function to populate the current Bank
        protected void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {

            DataSet dsBank = new DataSet();
            try
            {
                ddlFromBank.Items.Clear();
                CommunicationService objService = new CommunicationService();
                dsBank = objService.BankBasedAccountNumber(txtAccountNumber.Text);
                DataRow dr = dsBank.Tables[0].NewRow();
                dr[0] = "---------------------------Select Bank----------------------------------";
                dr[1] = 0;

                dsBank.Tables[0].Rows.InsertAt(dr, 0);
                ddlFromBank.DataSource = dsBank.Tables[0];
                ddlFromBank.DataTextField = "BankName";
                ddlFromBank.DataValueField = "BankID";
                ddlFromBank.DataBind();

                CommunicationService objServiceNext = new CommunicationService();
                DataSet dsPopulateName = objServiceNext.PopulateName(Convert.ToInt64(txtAccountNumber.Text));
                if (dsPopulateName != null)
                {
                    if (dsPopulateName.Tables[0] != null)
                    {
                        if (dsPopulateName.Tables[0].Rows.Count > 0)
                        {
                            txtCustomerName.Text = dsPopulateName.Tables[0].Rows[0]["customername"].ToString();
                            txtEmail.Text = dsPopulateName.Tables[0].Rows[0]["email"].ToString();
                            txtContact.Text = dsPopulateName.Tables[0].Rows[0]["contact"].ToString();
                        }
                    }
                }
            }
            catch
            {
            }
            finally
            {
                objService = null;
                dsBank = null;
            }
            //GetCurrentBank
        }
        #endregion
    }
}