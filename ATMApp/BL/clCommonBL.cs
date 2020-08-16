using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ATMApp.DL;
namespace ATMApp.BL
{
    class clCommonBL
    {

        #region Get Account Details for the customer
        //[WebMethod(Description = "Getting Account Details of a Bank")]
        public DataSet ValidateTransactionPassword(int CustomerId, string BankId, string transactionpassword)
        {
            try
            {
                clDbSqlServer _objServ = new clDbSqlServer();
                SqlParameter[] param = new SqlParameter[] 
                { 
                new SqlParameter("@customerID",CustomerId),
                new SqlParameter("@BankID",BankId),
                new SqlParameter("@transactionpassword",transactionpassword)
                };
                DataSet dsnew = _objServ.fnExecuteDataSet("ValidateTransactionPassword", param);
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


        public int MonthlyMaintainanceCharges(string userId, string Password, int ATMPIN)
        {
            clDbSqlServer _objServ = _objServ = new clDbSqlServer();
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

     }
  }

