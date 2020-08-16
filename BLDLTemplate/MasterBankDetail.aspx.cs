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
    public partial class MasterBankDetail : System.Web.UI.Page
    {
        clsCommonBL objCM = new clsCommonBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              

            }
        }

        

        protected void btnAdd_Click(object sender, EventArgs e)
        {
           int ReturnCode= objCM.InsertBankDetails(txtBankid.Text, txtBankname.Text, txtBankaddress.Text, txtBranch.Text, txtIFSCcode.Text, "I");
           if (ReturnCode == 1)
            {
                ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Success", "alert('New Bank Details has been added successfully');", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Success", "alert('Failed to add Bank Details');", true);
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                Session["BankDetails"] = objCM.GetBankDetails();
                gvBankDetails.DataSource = Session["BankDetails"];
                gvBankDetails.DataBind();
            }
            catch (Exception ex)
            {
            }
            finally
            {

            }

        }

        protected void gvBankDetails_PageIndexChanged(object sender, EventArgs e)
        {
            try
            {
                gvBankDetails.DataSource = Session["BankDetails"];
                gvBankDetails.DataBind();
            }
            catch (Exception ex)
            {
            }
            finally
            {

            }

        }

       

        protected void gvBankDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvBankDetails.EditIndex = e.NewEditIndex;
            try
            {
                gvBankDetails.DataSource = Session["BankDetails"];
                gvBankDetails.DataBind();
            }
            catch (Exception ex)
            {
            }
            finally
            {

            }

        }

        protected void gvBankDetails_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvBankDetails.EditIndex = -1;
            try
            {
                gvBankDetails.DataSource = Session["BankDetails"];
                gvBankDetails.DataBind();
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        protected void gvBankDetails_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = (GridViewRow)gvBankDetails.Rows[e.RowIndex];
            TextBox txtMICRCode = (TextBox)row.FindControl("txtMICRCode");
            TextBox txtBname = (TextBox)row.FindControl("txtBname");
            TextBox txtBranch = (TextBox)row.FindControl("txtBranch");
            TextBox txtBaddress = (TextBox)row.FindControl("txtBaddress");
            TextBox txtIFSCCode = (TextBox)row.FindControl("txtIFSCCode");
            int ReturnCode = objCM.InsertBankDetails(txtMICRCode.Text, txtBname.Text, txtBaddress.Text, txtBranch.Text, txtIFSCcode.Text, "U");
            if (ReturnCode == 2)
            {
                ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Success", "alert('Bank Details has been updated successfully');", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Failure", "alert('Bank Details update failed');", true);
            }
            gvBankDetails.EditIndex = -1;
            BindData();

        }

        protected void gvBankDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string BankId = gvBankDetails.DataKeys[e.RowIndex].Value.ToString();
            int ReturnCode = objCM.InsertBankDetails(BankId, String.Empty, String.Empty, String.Empty, String.Empty, "D");
            if (ReturnCode == 3)
            {
                ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Success", "alert('Bank Details has been deleted successfully');", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Failure", "alert('Bank Details deletion failed');", true);
            }
            BindData();

        }

        private void BindData()
        {
            Session["BankDetails"] = objCM.GetBankDetails();
            gvBankDetails.DataSource = Session["BankDetails"];
            gvBankDetails.DataBind();
        }

        protected void gvBankDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                gvBankDetails.DataSource = Session["BankDetails"];
                gvBankDetails.PageIndex = e.NewPageIndex;
                gvBankDetails.DataBind();
            }
            catch (Exception ex)
            {
            }
            finally
            {

            }
        }
    }
}