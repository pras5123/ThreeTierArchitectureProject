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
    public partial class ViewBankCredit : System.Web.UI.Page
    {
        clsCommonBL objCM = new clsCommonBL();
        CommunicationService objService = new CommunicationService();

        #region Page_Load Event
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet dsCustomerBank = null;
            if (!IsPostBack)
            {
                try
                {
                    dsCustomerBank = objCM.GetBankList();
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
            DataSet dsCustomerBank = null;
            try
            {
                dsCustomerBank = objService.GetBankCredit(ddlBank.SelectedValue);
                if (dsCustomerBank.Tables[0] != null)
                {
                    if (dsCustomerBank.Tables[0].Rows.Count > 0)
                    {
                        gvBankCredit.DataSource = dsCustomerBank.Tables[0];
                        gvBankCredit.DataBind();
                    }
                    else
                    {
                        gvBankCredit.DataSource = null;
                        gvBankCredit.DataBind();

                    }
                }


            }
            catch (Exception ex)
            {
            }
            finally
            {
                dsCustomerBank = null;
            }
        } 
        #endregion

        #region gvBalance_RowCommand Event
        protected void gvBalance_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        } 
        #endregion
    }
}