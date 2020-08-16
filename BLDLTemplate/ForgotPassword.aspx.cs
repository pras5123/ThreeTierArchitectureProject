using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.IO;

namespace BLDLTemplate
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        clsCommonBL objCM = new clsCommonBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Submit button Click to send the password
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Random rnNumber = new Random();
            string Subject = "Your New Password";
            string Password = rnNumber.Next(9999999).ToString();
            string BodyDescription = "As requested, your new password is " + Password + " . Please change your password while you log in";
            string Body = PopulateBody(String.Empty, BodyDescription);
            int ReturnCode = objCM.UpdatePassword(txtEmailID.Text, Password);
            if (ReturnCode == 1)
            {
                objCM.SendMail(String.Empty, txtEmailID.Text, Subject, Body);
                ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Success", "alert('Password has been sent successfully. Please check your mail');", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(base.Page, this.GetType(), "Success", "alert('This Email is not registered with us. Please check your mail id');", true);
            }
        }
        #endregion

        #region Region to populate the Body of the mail
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
    }
}