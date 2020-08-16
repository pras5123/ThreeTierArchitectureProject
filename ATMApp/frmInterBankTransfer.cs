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
    public partial class frmInterBankTransfer : Form
    {
        //clCommonBL objBL = new clCommonBL();
        //CommunicationRef.CommunicationService objService = new CommunicationRef.CommunicationService();
        public frmInterBankTransfer()
        {
            InitializeComponent();
        }

        private void frmInterBankTransfer_Load(object sender, EventArgs e)
        {
          DataSet dsBankWithBranch=null;
          DataSet dsToBank = null;
            try
            {
                CommunicationRef.CommunicationService objService = new CommunicationRef.CommunicationService();
                dsBankWithBranch = objService.GetBankWithBranch(ATMApp.frmCustomLogin.ClassValue.BankID, ATMApp.frmCustomLogin.ClassValue.CustomerId, ATMApp.frmCustomLogin.ClassValue.AtmPin);
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

               // clCommonBL objBLNew = new clCommonBL();
                //CommunicationRef.CommunicationService objService = new CommunicationRef.CommunicationService();
                dsToBank = objService.GetBankList();
                ddlToBank.DataSource = dsToBank.Tables[0];
                DataRow drToBank = dsToBank.Tables[0].NewRow();
                drToBank[0] = 0;
                drToBank[1] = "---Select Bank---";
                dsToBank.Tables[0].Rows.InsertAt(drToBank, 0);
                ddlToBank.ValueMember = "BankID";
                ddlToBank.DisplayMember = "name";             
            }
            catch (Exception ex)
            {

            }
            finally
            {
                dsBankWithBranch = null;
                dsToBank = null;

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
            if (ddlToBank.SelectedIndex == 0)
            {
                MessageBox.Show("To Bank Field is required");
                return;
            }
            if (txtBenificiaryName.Text == String.Empty)
            {
                MessageBox.Show("Benificiary Name is required");
                return;
            }

            if (Convert.ToInt32(txtAmount.Text) > 100000)
            {
                MessageBox.Show("Day wise transfer limit : 100000. Unable to complete this transaction");
                return;
            }

            if (Convert.ToInt32(txtAmount.Text) ==0)
            {
                MessageBox.Show("Invalid Amount");
                return;
            }
            int Customerid = ATMApp.frmCustomLogin.ClassValue.CustomerId;
            string BankID = ATMApp.frmCustomLogin.ClassValue.BankID;
            Random rn =new Random();
            string ReferenceNumber =rn.Next(11111111,99999999).ToString(); 
            string Narration= string.Format("Deposit Transaction from Account Number {0} ",txtFromAccountNumber.Text);
            CommunicationRef.CommunicationService objService = new CommunicationRef.CommunicationService();
            int Returncode = objService.InsertDepositTransaction(Customerid, BankID, ReferenceNumber, Convert.ToDecimal(txtAmount.Text), Narration, "Completed", txtToAccountNumber.Text, ddlToBank.SelectedValue.ToString());
            if (ATMApp.frmCustomLogin.ClassValue.BankID != ddlFromBank.SelectedValue.ToString())
            {
                ATMApp.frmCustomLogin.ClassValue.OtherBankTransactionInd++;
            }
            if (Returncode == 1)
            {
                MessageBox.Show("Funds has been transferred successfully");
              
               // lblProceed.Visible = true;
            }
            else if (Returncode == 2)
            {
                MessageBox.Show("Combination of Bank and its account number is incorrect");
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

        //private void lblProceed_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    frmCompleted updatepin = new frmCompleted();
        //    updatepin.ShowDialog();
        //    this.Close();
        //}

        private void ddlFromBank_SelectedIndexChanged(object sender, EventArgs e)
        {
           DataSet dsAccountNumberWithBranch=null;
           CommunicationRef.CommunicationService objService = new CommunicationRef.CommunicationService();
           dsAccountNumberWithBranch= objService.GetAccountNumberForBank(ddlFromBank.SelectedValue.ToString(), Convert.ToInt32(ATMApp.frmCustomLogin.ClassValue.CustomerId));
           if (dsAccountNumberWithBranch.Tables[0] != null)
           {
               if (dsAccountNumberWithBranch.Tables[0].Rows.Count > 0)
               {
                   txtFromAccountNumber.Text = dsAccountNumberWithBranch.Tables[0].Rows[0]["AccNO"].ToString();
                   lblBalance.Text = dsAccountNumberWithBranch.Tables[0].Rows[0]["totalavailablebalance"].ToString();
               }
           }
           
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmInterBankTransfer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
