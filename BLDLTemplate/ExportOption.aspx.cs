using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
namespace BLDLTemplate
{
    public partial class ExportOption : System.Web.UI.Page
    {
        clsCommonBL objCM = new clsCommonBL();
        CommunicationService objService = new CommunicationService();

        #region Page_Load
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtStartdate.Attributes.Add("readonly", "readonly");
                txtEnddate.Attributes.Add("readonly", "readonly");
            }
        }
        #endregion

        #region txtEnddate_TextChanged
        protected void txtEnddate_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region btnView_Click Event
        protected void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsTransaction = objService.TransactionBetweenDates(Convert.ToDateTime(txtStartdate.Text), Convert.ToDateTime(txtEnddate.Text), Convert.ToInt32(Session["CustomerId"].ToString()), Session["BankID"].ToString());
                if (dsTransaction.Tables[0].Rows.Count > 0)
                {
                    gvExport.DataSource = dsTransaction.Tables[0];
                    gvExport.DataBind();
                    btnExcelExport.Visible = true;
                    btnPdfExport.Visible = true;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {

            }

        }
        #endregion

        #region VerifyRenderingInServerForm
        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Confirms that an HtmlForm control is rendered for the specified ASP.NET
               server control at run time. */
        }
        #endregion

        #region btnPdfExport_Click Event

        protected void btnPdfExport_Click(object sender, EventArgs e)
        {
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=GridViewExport.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            gvExport.AllowPaging = false;
            gvExport.RenderControl(hw);
            StringReader sr = new StringReader(sw.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            htmlparser.Parse(sr);
            pdfDoc.Close();
            Response.Write(pdfDoc);
            Response.End();
        }
        #endregion

        #region btnExcelExport_Click Event

        protected void btnExcelExport_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.AddHeader("content-disposition", "attachment;filename=Transaction.xls");
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = "application/vnd.xls";
            System.IO.StringWriter stringWrite = new System.IO.StringWriter();
            System.Web.UI.HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvExport.RenderControl(htmlWrite);
            Response.Write(stringWrite.ToString());
            Response.End();
        }
        #endregion
    }
}