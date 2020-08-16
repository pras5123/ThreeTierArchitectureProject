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
    public partial class ViewCustomerReport : System.Web.UI.Page
    {
        clsCommonBL objBL = new clsCommonBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet dsCustomerBank = null;
            if (!IsPostBack)
            {
                try
                {
                    dsCustomerBank = objBL.GetBankForCustomer(Convert.ToInt32(Session["CustomerId"]));
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

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                gvCustomerReport.DataSource = objBL.SearchReportByBank(Convert.ToInt32(Session["CustomerId"].ToString()), ddlBank.SelectedValue);
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
                PathToreport = "Reports/rptCreditCardDetails.rpt";
            }
            if (e.CommandName == "ViewRegistration")
            {
                PathToreport = "Reports/rptCustomerRegistrationBank.rpt";
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
    }
}