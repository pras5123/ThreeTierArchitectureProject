using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATMApp.BL;
namespace ATMApp
{
    public partial class frmCustomLogin : Form
    {
        //clCommonBL objBL = new clCommonBL();
        CommunicationRef.CommunicationService objService = new CommunicationRef.CommunicationService();
        public static int LoginAttempt = 0;
        public frmCustomLogin()
        {
            InitializeComponent();
        }

        private void frmCustomLogin_Load(object sender, EventArgs e)
        {

        }

        #region ClassValues
        public static class ClassValue
        {
            public static string UserName;
            public static int CustomerId;
            public static string BankID;
            public static int AtmPin;
            public static int OtherBankTransactionInd;
            public static string Password;
        }
        #endregion

        #region Button Click Event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataSet dsCustomer;
            try
            {
                if (txtUserName.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter the User Name");
                    return;
                }

                if (txtPassword.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Password");
                    return;
                }

                if (txtATMPin.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter ATM Pin");
                    return;
                }

                dsCustomer = objService.GetUserCredential(txtUserName.Text, txtPassword.Text, Convert.ToInt32(txtATMPin.Text));
                if (dsCustomer != null)
                {
                    if (dsCustomer.Tables["ValidateUser"] != null)
                    {
                        if (dsCustomer.Tables["ValidateUser"].Rows.Count > 0)
                        {
                            if (dsCustomer.Tables["IsLockedAndValid"].Rows.Count > 0)
                            {
                                if (Convert.ToInt32(dsCustomer.Tables["IsLockedAndValid"].Rows[0]["locked"]) == 1)
                                {
                                    MessageBox.Show("Your Card has been locked. Please contact your bank Administrator");
                                    return;
                                }
                                if (Convert.ToInt32(dsCustomer.Tables["IsLockedAndValid"].Rows[0]["valid"]) == 0)
                                {
                                    MessageBox.Show("Your Card is invalid. Please renew your card");
                                    return;
                                }

                            }
                            this.Hide();
                            ClassValue.UserName = txtUserName.Text;
                            ClassValue.CustomerId = Convert.ToInt32(dsCustomer.Tables[0].Rows[0]["customerID"]);
                            ClassValue.BankID = dsCustomer.Tables[0].Rows[0]["BankID"].ToString();
                            ClassValue.AtmPin = Convert.ToInt32(txtATMPin.Text);
                            ClassValue.Password = txtPassword.Text;
                            frmOptions formoptions = new frmOptions();
                            formoptions.ShowDialog();
                            this.Close();

                        }
                        //This line need to be included in your project
                        else
                        {
                            MessageBox.Show("Invalid credential");
                            LoginAttempt++;
                            if (LoginAttempt == 3)
                            {

                                objService.LockCard(txtUserName.Text, txtPassword.Text, Convert.ToInt32(txtATMPin.Text));
                                MessageBox.Show("Your account has been locked due to 3 successive failure attempts.Contact your Bank Administrator");
                            }
                        }

                       
                    }
                }
                else
                {
                    MessageBox.Show("Invalid credential");
                    LoginAttempt++;
                    if (LoginAttempt == 3)
                    {

                        objService.LockCard(txtUserName.Text, txtPassword.Text, Convert.ToInt32(txtATMPin.Text));
                        MessageBox.Show("Your account has been locked due to 3 successive failure attempts.Contact your Bank Administrator");
                    }
                }
            }
            catch
            {
                
            }
            finally
            {
                dsCustomer = null;
               // this.Close();
            }
        }


        #endregion


        private void txtATMPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtATMPin.Clear();
        }


    }
}
