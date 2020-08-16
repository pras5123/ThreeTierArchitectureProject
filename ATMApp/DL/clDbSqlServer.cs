using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace ATMApp.DL
{
    class clDbSqlServer
    {
        #region Global Variable
        //ConfigurationManager is not accessible inside the Class library 
        private SqlConnection _objSqlConnection = new SqlConnection();
        private string _strSqlConnection = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        private SqlCommand _objSqlCommand = new SqlCommand();
        private SqlDataAdapter _objDataAdapter;
        public SqlParameter _objSqlParameter;
        private DataSet _objDataSet;
        public SqlParameter[] Input_Parameters = { };
        public SqlParameter[] Output_Parameters = { };
        #endregion

        #region Open Connection
        private Boolean fnOpenConnection()
        {
            try
            {
                if (_objSqlConnection.State != ConnectionState.Open)
                {
                   // _strSqlConnection = "Data Source=Prashanth-PC\\SQLEXPRESS;Initial Catalog=learn_sql;Integrated Security=True;";
                    _objSqlConnection.ConnectionString = _strSqlConnection;
                    _objSqlConnection.Open();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region Close Connection
        private Boolean fnCloseConnection()
        {
            try
            {
                if (_objSqlConnection.State != ConnectionState.Closed)
                {
                    _objSqlConnection.Close();
                    return true;
                }
                else if (_objSqlConnection.State == ConnectionState.Closed)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region Execute Stored Procedure returns Boolean
        /// <summary>
        /// Objective : Execute Stored Procedure by passing sp name and Parameters  
        /// and return boolean value
        /// Developed By : Prashanth.
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="Parameters"></param>
        /// <returns>Boolean</returns>
        public Boolean fnExecuteStoredProcedure(string spName, SqlParameter[] Parameters)
        {
            if (spName != null)
            {
                if (fnOpenConnection())
                {
                    _objSqlCommand.Connection = _objSqlConnection;
                    _objSqlCommand.CommandType = CommandType.StoredProcedure;
                    _objSqlCommand.CommandText = spName;
                    foreach (SqlParameter Param in Parameters)
                    {
                        _objSqlCommand.Parameters.Add(Param);
                    }
                    _objSqlCommand.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Execute Stored Procedure returns Boolean
        /// <summary>
        /// Objective : Execute Stored Procedure by passing sp name and Parameters  
        /// and return boolean value
        /// Developed By : Prashanth.
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="Parameters"></param>
        /// <returns>Boolean</returns>
        public Boolean fnExecuteStoredProcedure(string spName)
        {
            if (spName != null)
            {
                if (fnOpenConnection())
                {

                    _objSqlCommand.Connection = _objSqlConnection;
                    _objSqlCommand.CommandType = CommandType.StoredProcedure;
                    _objSqlCommand.CommandText = spName;
                    if (Input_Parameters != null)
                    {
                        if (Input_Parameters.Length > 0)
                        {
                            foreach (SqlParameter InParam in Input_Parameters)
                            {
                                _objSqlCommand.Parameters.Add(InParam);
                            }
                        }
                    }
                    if (Output_Parameters != null)
                    {
                        if (Output_Parameters.Length > 0)
                        {
                            foreach (SqlParameter OutParam in Output_Parameters)
                            {
                                _objSqlCommand.Parameters.Add(OutParam);
                            }
                        }
                    }
                    _objSqlCommand.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Execute DataSet by passing the parameters
        /// <summary>
        /// Objective : Execute DataSet by passing output parameters
        /// Developed By : Prashanth
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="Parameters"></param>
        /// <returns>DataSet</returns>
        public DataSet fnExecuteDataSet(string spName, SqlParameter[] Parameters)
        {
            try
            {
                _objDataSet = new DataSet();
                _objDataAdapter = new SqlDataAdapter();
                if (spName != null)
                {
                    if (fnOpenConnection())
                    {
                        _objSqlCommand.Connection = _objSqlConnection;
                        _objSqlCommand.CommandType = CommandType.StoredProcedure;
                        _objSqlCommand.CommandText = spName;
                        if (Parameters.Length > 0)
                        {
                            foreach (SqlParameter Param in Parameters)
                            {
                                _objSqlCommand.Parameters.Add(Param);
                            }
                        }
                        _objDataAdapter.SelectCommand = _objSqlCommand;
                        _objDataAdapter.Fill(_objDataSet);
                        return _objDataSet;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException Ex)
            {
                return null;
            }
            catch (Exception Ex)
            {
                return null;
            }
            finally
            {
            }
        }


        #endregion

        #region Execute DataSet without passing the parameters
        /// <summary>
        /// Objective : Execute DataSet without passing the parameters.But
        /// with adding input and output parameters(optional) which returns Dataset 
        /// Developed By : Prashanth
        /// </summary>
        /// <param name="spName"></param>
        /// <returns>DataSet</returns>
        public DataSet fnExecuteDataSet(string spName)
        {
            try
            {
                _objDataSet = new DataSet();
                _objDataAdapter = new SqlDataAdapter();
                if (spName != null)
                {
                    if (fnOpenConnection())
                    {
                        _objSqlCommand.Connection = _objSqlConnection;
                        _objSqlCommand.CommandType = CommandType.StoredProcedure;
                        _objSqlCommand.CommandText = spName;
                        if (Input_Parameters != null)
                        {
                            if (Input_Parameters.Length > 0)
                            {
                                foreach (SqlParameter InParam in Input_Parameters)
                                {
                                    _objSqlCommand.Parameters.Add(InParam);
                                }
                            }
                        }
                        if (Output_Parameters != null)
                        {
                            if (Output_Parameters.Length > 0)
                            {
                                foreach (SqlParameter OutParam in Output_Parameters)
                                {
                                    _objSqlCommand.Parameters.Add(OutParam);
                                }
                            }
                        }
                        _objDataAdapter.SelectCommand = _objSqlCommand;
                        _objDataAdapter.Fill(_objDataSet);
                        return _objDataSet;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException Ex)
            {
                return null;
            }
            catch (Exception Ex)
            {
                return null;
            }
            finally
            {

            }
        }


        #endregion

        #region Adding Input Parameters
        public void fnAddInputParam(string strParamName, object objParamValue)
        {
            try
            {
                _objSqlParameter = new SqlParameter(strParamName, objParamValue);
                Array.Resize(ref Input_Parameters, Input_Parameters.Length + 1);
                Input_Parameters[Input_Parameters.Length - 1] = _objSqlParameter;
            }
            catch (Exception ex)
            {
            }
            finally
            {
            }

        }
        #endregion

        #region "Add Output Parameter"
        /// <summary>
        /// To add Output Parameter
        /// </summary>
        /// <param name="paramName">Parameter Name</param>
        /// <param name="sqlDataType">Parameter Type</param>
        /// <param name="size">Parameter Size</param>
        public void fnAddOutputParam(string paramName, SqlDbType sqlDataType, int size = 0)
        {
            try
            {
                _objSqlParameter = new SqlParameter(paramName, sqlDataType);
                _objSqlParameter.Direction = ParameterDirection.Output;

                if (size > 0) //Default value is zero
                {
                    _objSqlParameter.Size = size;
                }

                Array.Resize(ref Output_Parameters, Output_Parameters.Length + 1);
                Output_Parameters[Output_Parameters.Length - 1] = _objSqlParameter;
            }
            catch (SqlException dbEx)
            {
                //fnLogErrorInFile("clsDbSqlServer_fnAddOutputParam", dbEx.Message, dbEx.Number);
            }
            catch (Exception ex)
            {
                // fnLogError("clsDbSqlServer_fnAddOutputParam", ex.Message);
            }
            finally
            {
                //_objSQLParameter = null;
            }

        }

        #endregion
    }
}
