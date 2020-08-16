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
    public partial class frmEnterAmount : Form
    {
        //clCommonBL objBL = new clCommonBL();
        CommunicationRef.CommunicationService objService = new CommunicationRef.CommunicationService();

        public static class EnterAmt
        {
            public static string BankID;
        }

        public frmEnterAmount()
        {
            InitializeComponent();
        }

        private void imgClear_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
        }

        private void frmEnterAmount_Load(object sender, EventArgs e)
        {
            DataSet dsBankWithBranch = objService.GetBankWithBranch(ATMApp.frmCustomLogin.ClassValue.BankID, ATMApp.frmCustomLogin.ClassValue.CustomerId, ATMApp.frmCustomLogin.ClassValue.AtmPin);
            if (dsBankWithBranch.Tables[0].Rows.Count > 0)
            {
                DataRow dr = dsBankWithBranch.Tables[0].NewRow();
                dr[0] = 0;
                dr[1] = "---Select Bank---";
                dsBankWithBranch.Tables[0].Rows.InsertAt(dr, 0);
                ddlBank.DataSource = dsBankWithBranch.Tables[0];
                ddlBank.ValueMember = "BankID";
                ddlBank.DisplayMember = "name";
            }
        }

        private void imgOK_Click(object sender, EventArgs e)
        {

            if (txtAmount.Text == String.Empty)
            {
                MessageBox.Show("Please enter the amount");
                return;
            }
            if (ddlBank.SelectedIndex == 0)
            {
                MessageBox.Show("Please select Bank");
                return;
            }
            if (Convert.ToInt32(txtAmount.Text) > 40000)
            {
                MessageBox.Show("Transaction limit is 40000. Cannot proceed  with the current amount");
                return;
            }
            //This  will prevent the user entering amount like 0 / 50 etc
            if (txtAmount.Text.Length <= 2)
            {
                MessageBox.Show("Invalid Amount");
                return;
            }

            //This  will prevent the user entering amount like 1050 / 150 etc
            int length = txtAmount.Text.Length;
            if (Convert.ToInt32(txtAmount.Text.Substring(length - 2)) == 50)
            {
                MessageBox.Show("Please Enter the amount in multiples of 100");
                return;
            }

            int ReturnCode = objService.DeductAmount(ddlBank.SelectedValue.ToString(), Convert.ToInt32(ATMApp.frmCustomLogin.ClassValue.CustomerId), Convert.ToDecimal(txtAmount.Text));
            EnterAmt.BankID = ddlBank.SelectedValue.ToString();
            if (ReturnCode == 1)
            {
                if (ATMApp.frmCustomLogin.ClassValue.BankID != ddlBank.SelectedValue.ToString())
                {
                    ATMApp.frmCustomLogin.ClassValue.OtherBankTransactionInd++;
                }
                CallCompletionScreen();
            }
            else
            {
                MessageBox.Show("There is no sufficient balance in your Account");
                return;
            }
            
        }

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            CallOptionScreen();
        }


        private void CallOptionScreen()
        {
            this.Hide();
            frmOptions updatepin = new frmOptions();
            updatepin.ShowDialog();
            this.Close();

        }


        private void CallCompletionScreen()
        {
            this.Hide();
            frmCompleted updatepin = new frmCompleted();
            updatepin.ShowDialog();
            this.Close();

        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ddlBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dsAccountNumberWithBranch = null;
            CommunicationRef.CommunicationService objService = new CommunicationRef.CommunicationService();
            dsAccountNumberWithBranch = objService.GetAccountNumberForBank(ddlBank.SelectedValue.ToString(), Convert.ToInt32(ATMApp.frmCustomLogin.ClassValue.CustomerId));
            if (dsAccountNumberWithBranch.Tables[0] != null)
            {
                if (dsAccountNumberWithBranch.Tables[0].Rows.Count > 0)
                {
                    
                    lblBalance.Text = dsAccountNumberWithBranch.Tables[0].Rows[0]["totalavailablebalance"].ToString();
                }
            }
        }

        private void frmEnterAmount_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
