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
    public partial class LockInvalidateCard : System.Web.UI.Page
    {
        clsCommonBL objBL = new clsCommonBL();
        CommunicationService objService = new CommunicationService();

        #region Page_Load Event
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


                ddlBankID.DataSource = dsSearch.Tables[3];
                ddlBankID.DataTextField = "BankID";
                ddlBankID.DataValueField = "BankID";
                ddlBankID.DataBind();
            }



        } 
        #endregion

        #region btnSearch_Click Event
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindData();

        }

        private void BindData()
        {
            try
            {
                Session["CardDetails"] = objService.SearchCardDetails(ddlCustomerName.SelectedItem.Text, ddlCreditCardNumber.SelectedItem.Text, ddlAccountNumber.SelectedItem.Text, ddlBankID.SelectedItem.Text);
                gvSearchInvalidated.DataSource = Session["CardDetails"];
                gvSearchInvalidated.DataBind();
            }
            catch (Exception Ex)
            {
            }
            finally
            {
                objBL = null;
            }
        } 
        #endregion

        #region gvSearchInvalidated_RowEditing Event
        protected void gvSearchInvalidated_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvSearchInvalidated.EditIndex = e.NewEditIndex;

            try
            {
                gvSearchInvalidated.DataSource = Session["CardDetails"];
                gvSearchInvalidated.DataBind();
                Label lblValidEdit = (Label)gvSearchInvalidated.Rows[e.NewEditIndex].FindControl("lblValidEdit");
                Label lblLockedEdit = (Label)gvSearchInvalidated.Rows[e.NewEditIndex].FindControl("lblLockedEdit");
                RadioButtonList rbtnYesNoLockedEdit = (RadioButtonList)gvSearchInvalidated.Rows[e.NewEditIndex].FindControl("rbtnYesNoLockedEdit");
                RadioButtonList rbtnYesNoValidEdit = (RadioButtonList)gvSearchInvalidated.Rows[e.NewEditIndex].FindControl("rbtnYesNoValidEdit");
                rbtnYesNoLockedEdit.SelectedValue = lblLockedEdit.Text == "True" ? "1" : "0";
                rbtnYesNoValidEdit.SelectedValue = lblValidEdit.Text == "True" ? "1" : "0";

                /* if (lblLockedEdit.Text == "True")
                 {
                     rbtnYesNoLockedEdit.SelectedValue = "1";

                     //rbtnYesNoLockedEdit.Items.FindByValue("1").Selected = true;
                 }
                 else
                 {
                     rbtnYesNoLockedEdit.SelectedValue = "0";
                     //rbtnYesNoLockedEdit.Items.FindByValue("0").Selected = true;
                 }

                 if (lblValidEdit.Text == "True")
                 {
                     rbtnYesNoValidEdit.SelectedValue = "0";
                     //rbtnYesNoValidEdit.Items.FindByValue("0").Selected = true;
                 }
                 else
                 {
                     rbtnYesNoValidEdit.SelectedValue = "1";
                     //rbtnYesNoValidEdit.Items.FindByValue("1").Selected = true;
                 }
                */
            }
            catch (Exception ex)
            {
            }
            finally
            {
            }

        } 
        #endregion

        #region gvSearchInvalidated_RowUpdating Event
        protected void gvSearchInvalidated_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = (GridViewRow)gvSearchInvalidated.Rows[e.RowIndex];
            RadioButtonList rbtnYesNoValidEdit = (RadioButtonList)row.FindControl("rbtnYesNoValidEdit");
            RadioButtonList rbtnYesNoLockedEdit = (RadioButtonList)row.FindControl("rbtnYesNoLockedEdit");
            Label lblBankIDEdit = (Label)row.FindControl("lblBankIDEdit");
            Label lblcustomerIDEdit = (Label)row.FindControl("lblcustomerIDEdit");
            int CustomerId = Convert.ToInt32(lblcustomerIDEdit.Text);
            int Validity = Convert.ToInt32(rbtnYesNoValidEdit.SelectedValue);
            int locked = Convert.ToInt32(rbtnYesNoLockedEdit.SelectedValue);
            int ReturnCode = objBL.UpdateLocking(CustomerId, lblBankIDEdit.Text, Validity, locked);
            if (ReturnCode == 1)
            {
                ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Success", "alert('Card Details has been updated successfully');", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Failure", "alert('Bank Details update failed');", true);
            }
            gvSearchInvalidated.EditIndex = -1;
            BindData();
        } 
        #endregion

        #region gvSearchInvalidated_RowCancelingEdit Event
        protected void gvSearchInvalidated_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvSearchInvalidated.EditIndex = -1;
            try
            {
                gvSearchInvalidated.DataSource = Session["CardDetails"];
                gvSearchInvalidated.DataBind();
            }
            catch (Exception ex)
            {
            }
            finally
            {
            }

        } 
        #endregion

        #region gvSearchInvalidated_PageIndexChanged Event
        protected void gvSearchInvalidated_PageIndexChanged(object sender, EventArgs e)
        {
            try
            {
                gvSearchInvalidated.DataSource = Session["CardDetails"];
                gvSearchInvalidated.DataBind();
            }
            catch (Exception ex)
            {
            }
            finally
            {
            }
        } 
        #endregion

        #region gvSearchInvalidated_PageIndexChanging Event
        protected void gvSearchInvalidated_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        } 
        #endregion

        #region gvSearchInvalidated_RowDataBound Event
        protected void gvSearchInvalidated_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {

                    Label lblValidItem = (Label)e.Row.FindControl("lblValidItem");
                    Label lblLockedItem = (Label)e.Row.FindControl("lblLockedItem");
                    lblValidItem.Text = Convert.ToBoolean(lblValidItem.Text) ? "Yes" : "No";
                    lblLockedItem.Text = Convert.ToBoolean(lblLockedItem.Text) ? " Yes" : "No";
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


    }
}