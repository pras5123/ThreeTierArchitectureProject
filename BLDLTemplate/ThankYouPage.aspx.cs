using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
namespace BLDLTemplate
{
    public partial class ThankYouPage : System.Web.UI.Page
    {
        clsCommonBL objCM = new clsCommonBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    string Narration = String.Empty;
                    int CustomerId = 0;
                    if (Session["CustomerId"] != null)
                    {
                        CustomerId = Convert.ToInt32(Session["CustomerId"]);
                    }
                    string BankId = Session["BankID"].ToString();
                    //Response.Write(BankId);
                    lblAmount.Text = Request.QueryString.Get("amt");
                    
                    lblReferenceNumber.Text = Request.QueryString.Get("tx");
                    lblStatus.Text = Request.QueryString.Get("st");

                    if (Session["MobilePaymant"] != null)
                    {
                       // Response.Write("Seession is not null" + Session["MobilePaymant"]);
                        if (Session["MobilePaymant"].ToString() == "BillPay")
                        {
                            Narration = "Mobile Bill Payment. Reference No : " + lblReferenceNumber.Text;
                        }
                    }
                    else
                    {
                        Narration = "Online shopping. Product Purchase. Reference No : " + lblReferenceNumber.Text;
                    }
                    //Response.Write("Customer Id is" + CustomerId + "<br/>");
                    //Response.Write("Bank Id is" + BankId + "<br/>");
                    //Response.Write("reference number is" + lblReferenceNumber.Text + "<br/>");
                    //Response.Write("Amount is " + Convert.ToDecimal(lblAmount.Text) + "<br/>");
                    //Response.Write("Narration is" + Narration + "<br/>");
                    //Response.Write("status is " + lblStatus.Text + "<br/>");
                    objCM.InsertTransactionDaily(CustomerId, BankId, lblReferenceNumber.Text, Convert.ToDecimal(lblAmount.Text), Narration, lblStatus.Text);
                    //Disposing the resource
                    Session["MobilePaymant"] = null;
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }
    }
}