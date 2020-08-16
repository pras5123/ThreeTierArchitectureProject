using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataLayer;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;
namespace BusinessLayer
{
    public class clsCommonBL 
    {


        #region Get the Country List and Bank
        public DataSet fnGetCountryAndBank()
        {
            DataSet ds=null;
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                ds = _objServ.fnExecuteDataSet("GetCountry");
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                ds = null;
            }
        }
        #endregion

        #region Getting List of Country
        public DataSet GetCountryList()
        {
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                DataSet dsnew = _objServ.fnExecuteDataSet("GetCountry");

                if (dsnew != null)
                {
                    return dsnew;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {

            }
        }
        #endregion

        #region Getting Security Question
        public DataSet GetSecurityQuestion()
        {
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                DataSet dsnew = _objServ.fnExecuteDataSet("GetSecurityQuestion");

                if (dsnew != null)
                {
                    return dsnew;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {

            }
        }
        #endregion
     
        #region Getting List of States
        public DataSet GetStateList(string CountryId)
        {
            DataSet dsnew=null;
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                SqlParameter[] param = new SqlParameter[] 
                { 
                new SqlParameter("@countryid",CountryId),
                };
                dsnew = _objServ.fnExecuteDataSet("GetStates", param);

                if (dsnew != null)
                {
                    return dsnew;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                dsnew = null;
            }
        }
        #endregion

        #region Getting List of Cities
        public DataSet GetCityList(string CityId)
        {
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                SqlParameter[] param = new SqlParameter[] 
                { 
                new SqlParameter("@statesID",CityId),
                };
                DataSet dsnew = _objServ.fnExecuteDataSet("GetCity", param);

                if (dsnew != null)
                {
                    return dsnew;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {

            }
        }
        #endregion

        #region Getting List of Bank
        public DataSet GetBankList()
        {
            DataSet dsnew =null;
            try
            {
                clsCommonDL _objServ = new clsCommonDL();

                dsnew = _objServ.fnExecuteDataSet("GetBank");

                if (dsnew != null)
                {
                    return dsnew;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                dsnew = null;
            }
        }
        #endregion

        #region Getting Bank Details
        public DataSet GetBankDetails()
        {
            DataSet dsnew = null;
            try
            {
                clsCommonDL _objServ = new clsCommonDL();

                dsnew = _objServ.fnExecuteDataSet("GetBankDetails");

                if (dsnew != null)
                {
                    return dsnew;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                dsnew = null;
            }
        }
        #endregion

        #region Getting List of common drop down in Search
        public DataSet GetSearchDropDown()
        {
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                DataSet dsnew = _objServ.fnExecuteDataSet("SearchCommonLoad");

                if (dsnew != null)
                {
                    return dsnew;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {

            }
        }
        #endregion

        #region Getting User Credential
        public DataSet GetUserCredential(string userId, string Password)
        {
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                _objServ.fnAddInputParam("@userID", userId);
                _objServ.fnAddInputParam("@password", Password);
               
               // _objServ.fnAddOutputParam("@spStatus", SqlDbType.Int);
                
                DataSet dsnew = _objServ.fnExecuteDataSet("GetCredential");

                if (dsnew != null)
                {
                    return dsnew;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {

            }
        }
        #endregion

        #region Function To Send Mail
        public void SendMail(string AttachmentPath,string To, string subject, string body)
        {
            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress("Prashanth.trainer@gmail.com");
                message.To.Add(new MailAddress(To));
                message.Subject = subject;
                message.Body = body;
                message.Priority = MailPriority.Normal;
                message.IsBodyHtml = true;
                SmtpClient emailClient = new SmtpClient("smtp.gmail.com", 587);
                emailClient.EnableSsl = true;
                emailClient.UseDefaultCredentials = true;
                emailClient.Credentials = new System.Net.NetworkCredential("Prashanth.trainer@gmail.com", "Prashanth@123");
                if (AttachmentPath != string.Empty)
                {
                    Attachment attachment = new Attachment(AttachmentPath);
                    message.Attachments.Add(attachment);
                }
                emailClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                emailClient.Send(message);
            }
            catch (Exception ex)
            {
                /* 
                 * UseDefaultCredentials = true;
                 * Error : The SMTP server requires a secure connection or the client was not authenticated. The server response was: 5.7.0 Must issue a STARTTLS command first. si6sm4607029pab.19 - gsmtp 
                 * UseDefaultCredentials = false;
                 * Error : The SMTP server requires a secure connection or the client was not authenticated. The server response was: 5.5.1 Authentication Required. Learn more at 
                 //Fix 1 :https://accounts.google.com/DisplayUnlockCaptcha : Enabled  
                 //Fix 2 :https://www.google.com/settings/security : Go here and disable two step verification code. This is also one of the reason for this issue
                 //Fix 3 : by default(if not specified) emailClient.EnableSsl = false; if this is the case we get the above error. Instead change it to true, which will solve the issue
                 * Info 1 :http://www.arclab.com/en/amlc/list-of-smtp-and-pop3-servers-mailserver-list.html : list the available ports
                 */
                //Response.Write(ex.Message);
                //Response.Write(ex.InnerException);
            }
            /*
             Try out the following : 
             * yahoo mail and rediffmail accounts mail sending
             * create new account and without doing modification check for it, note down the issues
             * sending the mail with attachment
             
             
             */
        }
        #endregion

        
        #region Change the Password of the User
        public int ChangePassword(int CustomerId, string oldpassword, string newpassword )
        {
            clsCommonDL _objServ = _objServ = new clsCommonDL();
            try
            {

                _objServ.fnAddInputParam("@customerID", CustomerId);
                _objServ.fnAddInputParam("@oldpassword", oldpassword);
                _objServ.fnAddInputParam("@newpassword", newpassword);
                _objServ.fnAddOutputParam("@spStatus", SqlDbType.Int);
                _objServ.fnExecuteDataSet("ChangePassword");              
                if (Convert.ToInt32(_objServ.Output_Parameters[0].Value) != 1)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }

            }
            catch (Exception ex)
            {
                  return 0;
            }
            finally
            {
                _objServ = null;
            }
        }
        #endregion

        #region Update the password before sending the mail
        public int UpdatePassword(string emailid, string password)
        {
            clsCommonDL _objServ = _objServ = new clsCommonDL();
            try
            {

                _objServ.fnAddInputParam("@emailid", emailid);
                _objServ.fnAddInputParam("@password", password);
                _objServ.fnAddOutputParam("@spStatus", SqlDbType.Int);
                _objServ.fnExecuteDataSet("UpdatePassword");
                if (Convert.ToInt32(_objServ.Output_Parameters[0].Value) != 1)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }

            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                _objServ = null;
            }
        }
        #endregion

        #region Getting name of the customer
        public DataSet GetCustomerName()
        {
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                DataSet dsnew = _objServ.fnExecuteDataSet("GetcustomerName");

                if (dsnew != null)
                {
                    return dsnew;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {

            }
        }
        #endregion

        #region Insert Bank Details
        public int InsertBankDetails(string BankID, string BankName, string Address, string Branch, string IFSCCode, string Action)
        {
            clsCommonDL _objServ = _objServ = new clsCommonDL();
            try
            {
                    _objServ.fnAddInputParam("@BankID", BankID);
                    _objServ.fnAddInputParam("@name", BankName);
                    _objServ.fnAddInputParam("@addr", Address);
                    _objServ.fnAddInputParam("@branch", Branch);
                    _objServ.fnAddInputParam("@ifscode", IFSCCode);
                    _objServ.fnAddInputParam("@Action", Action);                    
                    _objServ.fnAddOutputParam("@spStatus", SqlDbType.Int);
                    _objServ.fnExecuteDataSet("IUDBankDetails");
                if(Convert.ToInt32(_objServ.Output_Parameters[0].Value) == 1)
                {
                    return 1;
                }
                if (Convert.ToInt32(_objServ.Output_Parameters[0].Value) == 2)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }


            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                _objServ = null;
            }
        }
        #endregion

        #region Get Bank Report
        public DataSet SearchReportByBank(string CustomerName, string CreditCardNumber, string AccountNumber, string EmailId)
        {
            clsCommonDL _objServ = _objServ = new clsCommonDL();
            try
            {


                _objServ.fnAddInputParam("@CustomerName", CustomerName);
                _objServ.fnAddInputParam("@CreditCardNumber", CreditCardNumber);
                _objServ.fnAddInputParam("@AcountNumber", AccountNumber);
                _objServ.fnAddInputParam("@EmailId", EmailId);
                DataSet dsCustomerRpt = _objServ.fnExecuteDataSet("SearchReportByBank");
                return dsCustomerRpt;


            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                _objServ = null;
            }
        }
        #endregion

        #region Get Customer Report
        public DataSet SearchReportByBank(int CustomerId , string BankId)
        {
            clsCommonDL _objServ = _objServ = new clsCommonDL();
            try
            {
                _objServ.fnAddInputParam("@customerID", CustomerId);
                _objServ.fnAddInputParam("@BankID", BankId);
                DataSet dsCustomerRpt = _objServ.fnExecuteDataSet("SearchReportByCustomer");
                return dsCustomerRpt;


            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                _objServ = null;
            }
        }
        #endregion
      
        #region Increment Login Count
        public int IncrementCount(int CustomerID, string BankId)
        {
            clsCommonDL _objServ = _objServ = new clsCommonDL();
            try
            {
                _objServ.fnAddInputParam("@customerID", CustomerID);
                _objServ.fnAddInputParam("@BankID", BankId);
                _objServ.fnAddOutputParam("@spStatus", SqlDbType.Int);
                _objServ.fnExecuteDataSet("IncrementCount");
                if (Convert.ToInt32(_objServ.Output_Parameters[0].Value) == 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }


            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                _objServ = null;
            }
        }
        #endregion 

        #region Insert Transaction Daily and Process Amount
        public int InsertTransactionDaily(int customerID, string BankID,string RefNo,decimal creditamt, string narration,
             string status)
        {
            clsCommonDL _objServ = _objServ = new clsCommonDL();
            try
            {
                _objServ.fnAddInputParam("@customerID", customerID);
                _objServ.fnAddInputParam("@BankID", BankID);
                _objServ.fnAddInputParam("@refno", RefNo);
                _objServ.fnAddInputParam("@crdtdbtamt", creditamt);
                _objServ.fnAddInputParam("@narration", narration);
                _objServ.fnAddInputParam("@status", status);                
                _objServ.fnAddOutputParam("@spStatus", SqlDbType.Int);
                _objServ.fnExecuteDataSet("InsertTransactionDaily");
                if (Convert.ToInt32(_objServ.Output_Parameters[0].Value) == 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                _objServ = null;
            }
        }
        #endregion

        #region Update Locking
        public int UpdateLocking(int CustomerID, string BankId, int valid, int Locked)
        {
            clsCommonDL _objServ = _objServ = new clsCommonDL();
            try
            {
                _objServ.fnAddInputParam("@valid ", valid);
                _objServ.fnAddInputParam("@locked ", Locked);
                _objServ.fnAddInputParam("@customerID", CustomerID);
                _objServ.fnAddInputParam("@BankID ", BankId);               
                _objServ.fnAddOutputParam("@spStatus", SqlDbType.Int);
                _objServ.fnExecuteDataSet("UpdateLocking");
                if (Convert.ToInt32(_objServ.Output_Parameters[0].Value) == 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }


            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                _objServ = null;
            }
        }
        #endregion

        #region Populate bank dropdown based on customer id
        public DataSet GetBankForCustomer(int CustomerId)
        {
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                SqlParameter[] param = new SqlParameter[] 
                { 
                new SqlParameter("@customerID",CustomerId),
                };
                DataSet dsnew = _objServ.fnExecuteDataSet("GetCustomerBank", param);
                if (dsnew != null)
                {
                    return dsnew;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {

            }
        }
        #endregion

      


    }
 }

