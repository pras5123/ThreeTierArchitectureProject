using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;

namespace BLDLTemplate
{
    public partial class ReportBlankPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            GenerateReport();
        }


        #region Function To Generate the Report in Pdf and Export it to disk
        public void GenerateReport()
        {
            ReportDocument rptDoc = null;
            System.IO.MemoryStream objStr = null;
            string PathToreport = String.Empty;
            int customerId = 0;
            string BankId = string.Empty;
            try
            {
                if (Request.QueryString["CustomerId"] != null && Request.QueryString["BankId"] != null)
                {
                    customerId = Convert.ToInt32(Request.QueryString["CustomerId"]);
                    BankId = Request.QueryString["BankId"].ToString();//
                    PathToreport = "Reports/rptCreditCardDetailsBankCopy.rpt";
                    rptDoc = new ReportDocument();
                    rptDoc.Load(Server.MapPath(PathToreport));
                    rptDoc.SetParameterValue("@customerId", customerId);
                    rptDoc.SetParameterValue("@BankID", BankId);                   
                }
                else
                {
                    customerId = Convert.ToInt32(Request.QueryString["CustomerId"]);
                    PathToreport = "Reports/rptCustomerRegistrationBankCopy.rpt";
                    rptDoc = new ReportDocument();
                    rptDoc.Load(Server.MapPath(PathToreport));
                    rptDoc.SetParameterValue("@customerId", customerId);
                    rptDoc.SetParameterValue("@customerId", customerId);
                }
                objStr = (System.IO.MemoryStream)rptDoc.ExportToStream(ExportFormatType.PortableDocFormat);
                Response.Clear();
                Response.Buffer = true;
                Response.ContentType = "application/pdf";
                //Response.BinaryWrite(objStr.ToArray());
               // rptDoc.Refresh();
                rptDoc.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, true, "Report");

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
               
            }
            finally
            {

            }
        }
        #endregion
    }
}