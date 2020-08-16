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
    public partial class frmIntraBankTransfer : Form
    {
        clCommonBL objBL = new clCommonBL();
        CommunicationRef.CommunicationService objService = new CommunicationRef.CommunicationService();
        public frmIntraBankTransfer()
        {
            InitializeComponent();
        }

        private void frmIntraBankTransfer_Load(object sender, EventArgs e)
        {
            
            try
            {
                DataSet dsBankWithBranch = objService.GetBankWithBranch(ATMApp.frmCustomLogin.ClassValue.BankID, ATMApp.frmCustomLogin.ClassValue.CustomerId, ATMApp.frmCustomLogin.ClassValue.AtmPin);
                if (dsBankWithBranch.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsBankWithBranch.Tables[0].NewRow();
                    dr[0] = 0;
                    dr[1] = "---Select Bank---";
                    dsBankWithBranch.Tables[0].Rows.InsertAt(dr, 0);
                    ddlFromBank.DataSource = dsBankWithBranch.Tables[0];
                    ddlFromBank.ValueMember = "BankID";
                    ddlFromBank.DisplayMember = "name";
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }

        }

        private void lblTransfer_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == String.Empty)
            {
                MessageBox.Show("Please Enter the amount");
                return;
            }
            if (ddlFromBank.SelectedIndex == 0)
            {
                MessageBox.Show("From Bank Field is required");
                return;
            }
            if (txtBenificiaryName.Text == String.Empty)
            {
                MessageBox.Show("Benificiary Name is required");
                return;
            }
            if (txtToAccountNumber.Text == String.Empty)
            {
                MessageBox.Show("Destination Account number is required");
                return;

            }
            if (Convert.ToInt32(txtAmount.Text) > 100000)
            {
                MessageBox.Show("Day wise transfer limit : 100000. Unable to complete this transaction");
                return;
            }
            if (Convert.ToInt32(txtAmount.Text) == 0)
            {
                MessageBox.Show("Invalid Amount");
                return;
            }

            int Customerid = ATMApp.frmCustomLogin.ClassValue.CustomerId;
            string BankID = ddlFromBank.SelectedValue.ToString();
            Random rn = new Random();
            string ReferenceNumber = rn.Next(111111111, 999999999).ToString();
            string Narration = string.Format("Deposit Transaction from Account Number {0} ", txtFromAccountNumber.Text);
            int Returncode =objService.InsertDepositTransactions(Customerid, BankID, ReferenceNumber, Convert.ToDecimal(txtAmount.Text), Narration, "Completed",txtToAccountNumber.Text);
            if (ATMApp.frmCustomLogin.ClassValue.BankID != ddlFromBank.SelectedValue.ToString())
            {
                ATMApp.frmCustomLogin.ClassValue.OtherBankTransactionInd++;
            }
            
            if (Returncode == 1)
            {
                MessageBox.Show("Funds has been transferred successfully");
                //lblProceed.Visible = true;
            }
            else if (Returncode == 2)
            {
                MessageBox.Show("Account number is incorrect");
            }
            else if (Returncode == 3)
            {
                MessageBox.Show("You do not have sufficient amount to complete this transaction");
            }
            else
            {
                MessageBox.Show("Fund transfer has failed. Double check your account number");
            }
        }

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            GoBack();
        }


        private void GoBack()
        {
            this.Hide();
            frmSelectBankFund options = new frmSelectBankFund();
            options.ShowDialog();
            this.Close();
        }

        private void ddlFromBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dsAccountNumberWithBranch = null;
            dsAccountNumberWithBranch = objService.GetAccountNumberForBank(ddlFromBank.SelectedValue.ToString(), Convert.ToInt32(ATMApp.frmCustomLogin.ClassValue.CustomerId));
            if (dsAccountNumberWithBranch.Tables[0] != null)
            {
                if (dsAccountNumberWithBranch.Tables[0].Rows.Count > 0)
                {
                    txtFromAccountNumber.Text = dsAccountNumberWithBranch.Tables[0].Rows[0]["AccNO"].ToString();
                    lblBalance.Text = dsAccountNumberWithBranch.Tables[0].Rows[0]["totalavailablebalance"].ToString();
                }
            }
        }

        //private void lblProceed_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    frmCompleted updatepin = new frmCompleted();
        //    updatepin.ShowDialog();
        //    this.Close();
        //}

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmIntraBankTransfer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
