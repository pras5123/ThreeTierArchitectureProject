using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;

namespace BLDLTemplate
{
    public partial class ViewReportByBank : System.Web.UI.Page
    {
        clsCommonBL objBL = new clsCommonBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet dsSearch = objBL.GetSearchDropDown();
                ddlCustomerName.DataSource = dsSearch.Tables[0];
                ddlCustomerName.DataTextField = "customername";
                ddlCustomerName.DataValueField = "customerID";
                ddlCustomerName.DataBind();

                ddlAccountNumber.DataSource = dsSearch.Tables[1];
                ddlAccountNumber.DataTextField = "bankaccNo";
                ddlAccountNumber.DataValueField = "bankaccNo";
                ddlAccountNumber.DataBind();


                ddlCreditCardNumber.DataSource = dsSearch.Tables[2];
                ddlCreditCardNumber.DataTextField = "creditID";
                ddlCreditCardNumber.DataValueField = "creditID";
                ddlCreditCardNumber.DataBind();



            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                gvCustomerReport.DataSource = objBL.SearchReportByBank(ddlCustomerName.SelectedItem.Text, ddlCreditCardNumber.SelectedItem.Text, ddlAccountNumber.SelectedItem.Text, txtEmailId.Text);
                gvCustomerReport.DataBind();
            }
            catch (Exception Ex)
            {
            }
            finally
            {
                objBL = null;
            }
        }

        protected void gvCustomerReport_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow rw = (GridViewRow)(((Control)e.CommandSource).NamingContainer);
            Label lnkBankID = (Label)rw.FindControl("lblbankid");
            Label lblcustomerID = (Label)rw.FindControl("lblcustomerID");
            ReportDocument rptDoc = null;
            System.IO.MemoryStream objStr = null;
            string PathToreport = String.Empty;
         
           
            if (e.CommandName == "ViewCredit")
            {
               // string Url = string.Format("ReportBlankPage.aspx?BankId={0}&CustomerId={1}", lnkBankID.Text, lblcustomerID.Text);
               // OpenPopUpWindow(Url);
                PathToreport = "Reports/rptCreditCardDetailsBankCopy.rpt";
                
            }
            if (e.CommandName == "ViewRegistration")
            {
                string OneUrl = string.Format("ReportBlankPage.aspx?CustomerId={0}",lblcustomerID.Text);
                //OpenPopUpWindow(OneUrl);
                PathToreport = "Reports/rptCustomerRegistrationBankCopy.rpt";
            }

            rptDoc = new ReportDocument();
            rptDoc.Load(Server.MapPath(PathToreport));
            rptDoc.SetParameterValue("@customerId", Convert.ToInt32(lblcustomerID.Text));
            rptDoc.SetParameterValue("@BankID", lnkBankID.Text);
            objStr = (System.IO.MemoryStream)rptDoc.ExportToStream(ExportFormatType.PortableDocFormat);
            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/pdf";
            rptDoc.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, true, "Report");
        }


        #region OpenPopUpWindow
        private void OpenPopUpWindow(string URL)
        {
            ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "MyScript", "<script> screenW = screen.width;screenH = screen.height;window.open('" + URL + "', null, 'height=' + screenH + ', width=' + screenW + ', scrollbars=yes,top=0,left=0');</script>", false);
        }
        #endregion
    }
}