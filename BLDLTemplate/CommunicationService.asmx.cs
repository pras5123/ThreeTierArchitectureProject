using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;
using DataLayer;
using BusinessLayer;
namespace BLDLTemplate
{
    /// <summary>
    /// Summary description for CommunicationService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CommunicationService : System.Web.Services.WebService
    {       

        #region Insert Credit Card Details
        [WebMethod(Description="Method to Insert credit card details to a particular bank")]
        public int InsertCreditCardDetails(string customerID, string BankID, string creditID, string cdetails,
            DateTime expdate, int validity, int cvv, DateTime RegDate, Boolean valid, Boolean locked, string DMFlag, string CreditCardPath, out int ReturnCustomerId, out string EmailId)
        {
            clsCommonDL _objServ = _objServ = new clsCommonDL();
            try
            {
                _objServ.fnAddInputParam("@customerID", customerID);
                _objServ.fnAddInputParam("@BankID", BankID);
                _objServ.fnAddInputParam("@creditID", creditID);
                _objServ.fnAddInputParam("@cdetails", cdetails);
                _objServ.fnAddInputParam("@expdate", expdate);
                _objServ.fnAddInputParam("@validity", validity);
                _objServ.fnAddInputParam("@cvv", cvv);
                _objServ.fnAddInputParam("@regdate", RegDate);
                _objServ.fnAddInputParam("@valid", valid);
                _objServ.fnAddInputParam("@locked", locked);
                _objServ.fnAddInputParam("@DMLFlag", DMFlag);
                _objServ.fnAddInputParam("@CreditCardPath", CreditCardPath);
                _objServ.fnAddOutputParam("@spStatus", SqlDbType.Int);
                _objServ.fnAddOutputParam("@ReturnID", SqlDbType.Int);
                _objServ.fnAddOutputParam("@EmailId", SqlDbType.NVarChar, 100);
                _objServ.fnExecuteDataSet("IUDCreditCardDetails");
                ReturnCustomerId = Convert.ToInt32(_objServ.Output_Parameters[1].Value);
                EmailId = _objServ.Output_Parameters[2].Value.ToString();
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
                ReturnCustomerId = Convert.ToInt32(_objServ.Output_Parameters[1].Value);
                EmailId = _objServ.Output_Parameters[1].Value.ToString();
                return 0;
            }
            finally
            {
                _objServ = null;
            }
        }
        #endregion

        #region Inserting the list of Customer and Bank
        [WebMethod(Description = "Method to Insert Customer Registration details to a particulat Bank")]
        public int InsertCustomerAndBank(string customername, string add1, string add2, string add3,
  string city, string states, string country, string emailid, string sex, string contact,
  string othercontact, string BankID, string userID, string password, int oldATMpin,
  string transactionpassword, long AccNO, decimal totalBalance, out int ReturnID, string ReportPath, string PanCardNumber)
        {
            clsCommonDL _objServ = _objServ = new clsCommonDL();
            try
            {

                _objServ.fnAddInputParam("@customername", customername);
                _objServ.fnAddInputParam("@add1", add1);
                _objServ.fnAddInputParam("@add2", add2);
                _objServ.fnAddInputParam("@add3", add3);
                _objServ.fnAddInputParam("@city", city);
                _objServ.fnAddInputParam("@states", states);
                _objServ.fnAddInputParam("@country", country);
                _objServ.fnAddInputParam("@email", emailid);
                _objServ.fnAddInputParam("@sex", sex);
                _objServ.fnAddInputParam("@contact", contact);
                _objServ.fnAddInputParam("@othercontact", othercontact);
                _objServ.fnAddInputParam("@BankID", BankID);
                _objServ.fnAddInputParam("@userID", userID);
                _objServ.fnAddInputParam("@password", password);
                _objServ.fnAddInputParam("@oldATMpin", oldATMpin);
                _objServ.fnAddInputParam("@transactionpassword", transactionpassword);
                _objServ.fnAddInputParam("@AccNO", AccNO);
                _objServ.fnAddInputParam("@totalavailablebalance", totalBalance);
                _objServ.fnAddInputParam("@RegistrationPath", ReportPath);
                _objServ.fnAddInputParam("@PANCardNo", PanCardNumber);
                _objServ.fnAddOutputParam("@spStatus", SqlDbType.Int);
                _objServ.fnAddOutputParam("@ReturnID", SqlDbType.Int);
                _objServ.fnExecuteDataSet("Insertcustomer");
                ReturnID = Convert.ToInt32(_objServ.Output_Parameters[1].Value);
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
                ReturnID = Convert.ToInt32(_objServ.Output_Parameters[1].Value);
                return 0;
            }
            finally
            {
                _objServ = null;
            }
        }
        #endregion

        #region Get Account Details for the customer
        [WebMethod(Description = "Getting Account Details of a Bank")]
        public DataSet GetMyAccountDetails(int CustomerId, string BankId)
        {
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                SqlParameter[] param = new SqlParameter[] 
                { 
                new SqlParameter("@customerID",CustomerId),
                new SqlParameter("@bankid",BankId)
                };
                DataSet dsnew = _objServ.fnExecuteDataSet("GetMyAccountDetails", param);
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

        #region Get Transaction Between the dates
        [WebMethod(Description = "Get Transaction Between the dates")]
        public DataSet TransactionBetweenDates(DateTime? startdateoftrans, DateTime? enddateoftrans, int CustomerID, string BankID)
        {
            clsCommonDL _objServ = _objServ = new clsCommonDL();
            try
            {
                _objServ.fnAddInputParam("@startdateoftrans", startdateoftrans);
                _objServ.fnAddInputParam("@enddateoftrans", enddateoftrans);
                _objServ.fnAddInputParam("@customerID", CustomerID);
                _objServ.fnAddInputParam("@BankID", BankID);
                DataSet dsTransaction = _objServ.fnExecuteDataSet("TransactionBetweenDates");
                return dsTransaction;
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

        #region Import Customer Details
        [WebMethod(Description = "Method to Import customer details")]
        public int ImportCustomerDetails(string BankID, string userID, string password, int oldATMpin,
            string transactionpassword, long NewAccNO, decimal totalavailablebalance, string RegistrationPath, out int ReturnId, long OldAcctNo)
        {
            clsCommonDL _objServ = _objServ = new clsCommonDL();
            try
            {
                _objServ.fnAddInputParam("@BankID", BankID);
                _objServ.fnAddInputParam("@userID", userID);
                _objServ.fnAddInputParam("@password", password);
                _objServ.fnAddInputParam("@oldATMpin", oldATMpin);
                _objServ.fnAddInputParam("@transactionpassword", transactionpassword);
                _objServ.fnAddInputParam("@NewAccNO", NewAccNO);
                _objServ.fnAddInputParam("@OldAccNO", OldAcctNo);
                _objServ.fnAddInputParam("@totalavailablebalance", totalavailablebalance);
                _objServ.fnAddInputParam("@RegistrationPath", RegistrationPath);
                _objServ.fnAddOutputParam("@spStatus", SqlDbType.Int);
                _objServ.fnAddOutputParam("@ReturnID", SqlDbType.Int);
                _objServ.fnExecuteDataSet("ImportCustomerDetails");
                ReturnId = Convert.ToInt32(_objServ.Output_Parameters[1].Value);
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
                ReturnId = Convert.ToInt32(_objServ.Output_Parameters[1].Value);
                return 0;
            }
            finally
            {
                _objServ = null;
            }
        }
        #endregion

        #region Search Card Details
        [WebMethod(Description = "Method to Search card details")]
        public DataSet SearchCardDetails(string CustomerName, string CreditCardNumber, string AccountNumber, string BankID)
        {
            clsCommonDL _objServ = _objServ = new clsCommonDL();
            try
            {


                _objServ.fnAddInputParam("@CustomerName", CustomerName);
                _objServ.fnAddInputParam("@CreditCardNumber", CreditCardNumber);
                _objServ.fnAddInputParam("@AcountNumber", AccountNumber);
                _objServ.fnAddInputParam("@BankID", BankID);
                DataSet dsCustomerRpt = _objServ.fnExecuteDataSet("SearchInvalidateCard");
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

        #region Insert Customer Answers
        [WebMethod(Description = "Method to Insert Customer Answers")]
        public int InsertCustomerAnswer(int CustomerId, string BankId, int QuestionId, string Answer)
        {
            clsCommonDL _objServ = _objServ = new clsCommonDL();
            try
            {
                _objServ.fnAddInputParam("@CustId", CustomerId);
                _objServ.fnAddInputParam("@BankId", BankId);
                _objServ.fnAddInputParam("@questionid", QuestionId);
                _objServ.fnAddInputParam("@Answer", Answer);
                _objServ.fnAddOutputParam("@spStatus", SqlDbType.Int);
                _objServ.fnExecuteDataSet("InsertCustomerAnswer");
                return Convert.ToInt32(_objServ.Output_Parameters[0].Value);

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

        #region Getting the record for Bank Credit
        [WebMethod(Description = "Method to Get the Bank Credit")]
        public DataSet GetBankCredit(string BankId)
        {
            DataSet dsnew = null;
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                SqlParameter[] param = new SqlParameter[] 
                { 
                new SqlParameter("@BankID",BankId),
                };
                dsnew = _objServ.fnExecuteDataSet("ViewBankCredit", param);

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

        #region Update PIN details
        [WebMethod(Description="To Update PIN Details")]
        public int UpdatePINDetails(int newATMPIN, int oldATMPIN, string BankID, int customerID)
        {
            int ReturnCode = 0;
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                _objServ.fnAddInputParam("@NewATMPin", newATMPIN);
                _objServ.fnAddInputParam("@oldATMpin", oldATMPIN);
                _objServ.fnAddInputParam("@BankID", BankID);
                _objServ.fnAddInputParam("@customerID", customerID);
                _objServ.fnAddOutputParam("@spStatus", SqlDbType.Int);
                _objServ.fnExecuteDataSet("UpdateATMPin");
                ReturnCode = Convert.ToInt32(_objServ.Output_Parameters[0].Value);
                return ReturnCode;
            }
            catch (Exception ex)
            {
                return ReturnCode;
            }
            finally
            {

            }
        }

        #endregion

        #region Getting user credential
        [WebMethod(Description = "Method for Getting user credential")]
        public DataSet GetUserCredential(string userId, string Password, int ATMPIN)
        {
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                SqlParameter[] param = new SqlParameter[] 
                { 
                new SqlParameter("@userID",userId),
                new SqlParameter("@password",Password),
                new SqlParameter("@oldATMpin",ATMPIN)
                };
                DataSet dsnew = _objServ.fnExecuteDataSet("EnterATMTransaction", param);
                dsnew.Tables[0].TableName = "ValidateUser";
                dsnew.Tables[1].TableName = "IsLockedAndValid";
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

        #region Populate bank dropdown
        [WebMethod(Description = "Method to Populate bank dropdown")]
        public DataSet GetBankForm(int CustomerId)
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



        #region Deduct Amount From user Account
        [WebMethod(Description = "Method to Deduct Amount From user Account")]
        public int DeductAmount(string bankid, int customerid, decimal DeductionAmount)
        {
            int ReturnCode = 0;
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                _objServ.fnAddInputParam("@bankid", bankid);
                _objServ.fnAddInputParam("@customerid", customerid);
                _objServ.fnAddInputParam("@DeductionAmount", DeductionAmount); ;
                _objServ.fnAddOutputParam("@spStatus", SqlDbType.Int);
                _objServ.fnExecuteDataSet("DeductAmount");
                ReturnCode = Convert.ToInt32(_objServ.Output_Parameters[0].Value);
                return ReturnCode;
            }
            catch (Exception ex)
            {
                return ReturnCode;
            }
            finally
            {

            }
        }

        #endregion

        #region Lock Card of the User
        [WebMethod(Description = "Method to Lock Card of the User")]
        public DataSet LockCard(string userId, string Password, int ATMPIN)
        {
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                SqlParameter[] param = new SqlParameter[] 
                { 
                new SqlParameter("@userID",userId),
                new SqlParameter("@password",Password),
                new SqlParameter("@oldATMpin",ATMPIN)
                };
                DataSet dsnew = _objServ.fnExecuteDataSet("LockCard", param);
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

        #region Get Bank with Branch for a User
        [WebMethod(Description = "Method to Get Bank with Branch for a User")]
        public DataSet GetBankWithBranch(string BankID, int customerID,int AtmPin)
        {
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                SqlParameter[] param = new SqlParameter[] 
                { 
                new SqlParameter("@BankID",BankID),
                new SqlParameter("@customerID",customerID),
                new SqlParameter("@ATMPin",AtmPin)
                };
                DataSet dsnew = _objServ.fnExecuteDataSet("GetBankWithBranch", param);
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

        #region Get Account Number for a Bank
        [WebMethod(Description = "Method to Get Account Number for a Bank")]
        public DataSet GetAccountNumberForBank(string BankID, int customerID)
        {
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                SqlParameter[] param = new SqlParameter[] 
                { 
                new SqlParameter("@BankID",BankID),
                new SqlParameter("@customerID",customerID)

                };
                DataSet dsnew = _objServ.fnExecuteDataSet("GetAccountNumberFromBank", param);
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

        #region Insert Deposit Transaction
        [WebMethod(Description = "Method to Insert Deposit Transaction")]
        public int DepositTransaction(string frombankcode, string tobankcode, string fromaccountno, string toaccountno, string benificiaryname, decimal amount, int CustomerId)
        {
            int ReturnCode = 0;
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                _objServ.fnAddInputParam("frombankcode", frombankcode);
                _objServ.fnAddInputParam("tobankcode", tobankcode);
                _objServ.fnAddInputParam("fromaccountno", fromaccountno);
                _objServ.fnAddInputParam("toaccountno", toaccountno);
                _objServ.fnAddInputParam("benificiaryname", benificiaryname);
                _objServ.fnAddInputParam("amount", amount);
                _objServ.fnAddInputParam("@customerID", CustomerId);
                _objServ.fnAddOutputParam("@spStatus", SqlDbType.Int);
                _objServ.fnExecuteDataSet("DepositAmount");
                ReturnCode = Convert.ToInt32(_objServ.Output_Parameters[0].Value);
                return ReturnCode;
            }
            catch (Exception ex)
            {
                return ReturnCode;
            }
            finally
            {

            }
        }
        #endregion

        #region Getting Bank Details
        [WebMethod(Description = "Method for Getting Bank Details")]
        public DataSet GetBankList()
        {
            DataSet dsnew = null;
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

        #region Process Deposit Amount - Inter Bank transfer
        [WebMethod(Description = "Method to Process Deposit Amount - Inter Bank transfer")]
        public int InsertDepositTransaction(int customerID, string BankID, string RefNo, decimal creditamt, string narration,
             string status, string ToAccountNumber, string BankIdCheck)
        {
            clsCommonDL _objServ = _objServ = new clsCommonDL();
            try
            {
                _objServ.fnAddInputParam("@customerID", customerID);
                _objServ.fnAddInputParam("@BankID", BankID);
                _objServ.fnAddInputParam("@refno", RefNo);
                _objServ.fnAddInputParam("@creditamount", creditamt);
                _objServ.fnAddInputParam("@narration", narration);
                _objServ.fnAddInputParam("@status", status);
                _objServ.fnAddInputParam("@bankaccNo", ToAccountNumber);
                _objServ.fnAddInputParam("@bankIDCheck", BankIdCheck);
                _objServ.fnAddOutputParam("@spStatus", SqlDbType.Int);
                _objServ.fnExecuteDataSet("InsertDepositTransaction");
                return Convert.ToInt32(_objServ.Output_Parameters[0].Value);

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

        #region Process Deposit Amount - Intra Bank Transfer
        [WebMethod(Description = "Method to Process Deposit Amount - Intra Bank Transfer")]
        public int InsertDepositTransactions(int customerID, string BankID, string RefNo, decimal creditamt, string narration,
             string status, string ToAccountNumber)
        {

            clsCommonDL _objServ = new clsCommonDL();
            try
            {
                _objServ.fnAddInputParam("@customerID", customerID);
                _objServ.fnAddInputParam("@BankID", BankID);
                _objServ.fnAddInputParam("@refno", RefNo);
                _objServ.fnAddInputParam("@creditamount", creditamt);
                _objServ.fnAddInputParam("@narration", narration);
                _objServ.fnAddInputParam("@status", status);
                _objServ.fnAddInputParam("@bankaccNo", ToAccountNumber);
                _objServ.fnAddOutputParam("@spStatus", SqlDbType.Int);
                _objServ.fnExecuteDataSet("IntraBankDepositTransaction");
                return Convert.ToInt32(_objServ.Output_Parameters[0].Value);
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


        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="Password"></param>
        /// <param name="ATMPIN"></param>
        /// <returns></returns>
        #region Monthly Maintainance charges
        [WebMethod(Description = "Method for Monthly Maintainance charges applicable")]
        public int MonthlyMaintainanceCharges(string userId, string Password, int ATMPIN)
        {
            clsCommonDL _objServ = _objServ = new clsCommonDL();
            try
            {
                _objServ.fnAddInputParam("@userID", userId);
                _objServ.fnAddInputParam("@password", Password);
                _objServ.fnAddInputParam("@oldATMpin", ATMPIN);
                _objServ.fnAddOutputParam("@spStatus", SqlDbType.Int);
                _objServ.fnExecuteDataSet("MonthlyMaintainanceCharges");
                return Convert.ToInt32(_objServ.Output_Parameters[0].Value);
               
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

        //Added from here

        #region Method to Get Only Requied Bank
        [WebMethod(Description = "Method to Get Only Requied Bank")]
        public DataSet GetOnlyRequiedBank(int CustomerId)
        {
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                SqlParameter[] param = new SqlParameter[] 
                { 
                new SqlParameter("@customerId",CustomerId),
                };
                DataSet dsnew = _objServ.fnExecuteDataSet("GetOnlyRequiedBank", param);
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

        #region Method to Get Registration Date
        [WebMethod(Description = "Method to Get Registration Date")]
        public DataSet GetRegistrationDate(int CustomerId, string BankId)
        {
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                SqlParameter[] param = new SqlParameter[] 
                { 
                new SqlParameter("@customerId",CustomerId),
                new SqlParameter("@BankID",BankId)
                };
                DataSet dsnew = _objServ.fnExecuteDataSet("GetRegistrationDate", param);
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

        #region Method to Check Credit Card Number
        [WebMethod(Description = "Method to Check Credit Card Number")]
        public DataSet CheckCreditCardNumber(string CreditId)
        {
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                SqlParameter[] param = new SqlParameter[] 
                { 
                new SqlParameter("@creditID",CreditId)
                };
                DataSet dsnew = _objServ.fnExecuteDataSet("CheckCreditNoAvailability", param);
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

        #region Method to Check Credit Card Number
        [WebMethod(Description = "Validate Credit card Availability")]
        public DataSet ValidateCreditAvailability(int CustomerId, string BankId)
        {
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                SqlParameter[] param = new SqlParameter[] 
                { 
                new SqlParameter("@customerID",CustomerId),
                new SqlParameter("@BankID",BankId)
                };
                DataSet dsnew = _objServ.fnExecuteDataSet("ValidateCreditAvailability", param);
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

        #region Method to Get Current Bank Based on Account Number
        [WebMethod(Description = "Method to Get Current Bank Based on Account Number")]
        public DataSet BankBasedAccountNumber(string AccountNo)
        {
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                SqlParameter[] param = new SqlParameter[] 
                { 
                new SqlParameter("@AccNO",AccountNo)
                };
                DataSet dsnew = _objServ.fnExecuteDataSet("GetCurrentBank", param);
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

        #region Method to Check for the customer name
        [WebMethod(Description = "Method to Check for the customer name")]
        public DataSet CheckCustomerName(string CustomerName)
        {
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                SqlParameter[] param = new SqlParameter[] 
                { 
                new SqlParameter("@customername",CustomerName)
                };
                DataSet dsnew = _objServ.fnExecuteDataSet("CheckCustomerName", param);
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

        #region Method to Check for the customer name
        [WebMethod(Description = "Method to populate the customer name")]
        public DataSet PopulateName(long AccounNo)
        {
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                SqlParameter[] param = new SqlParameter[] 
                { 
                new SqlParameter("@AccNO",AccounNo)
                };
                DataSet dsnew = _objServ.fnExecuteDataSet("PopulateName", param);
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


        #region Check for the amount availability
        [WebMethod(Description = "Method to Check for the amount availability")]
        public int CheckAmountAvailability(string bankid, int customerid, decimal DeductionAmount)
        {
            int ReturnCode = 0;
            try
            {
                clsCommonDL _objServ = new clsCommonDL();
                _objServ.fnAddInputParam("@bankid", bankid);
                _objServ.fnAddInputParam("@customerid", customerid);
                _objServ.fnAddInputParam("@DeductionAmount", DeductionAmount); ;
                _objServ.fnAddOutputParam("@spStatus", SqlDbType.Int);
                _objServ.fnExecuteDataSet("CheckAmountAvailability");
                ReturnCode = Convert.ToInt32(_objServ.Output_Parameters[0].Value);
                return ReturnCode;
            }
            catch (Exception ex)
            {
                return ReturnCode;
            }
            finally
            {

            }
        }

        #endregion
    }
}
