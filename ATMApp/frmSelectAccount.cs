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
    public partial class frmSelectAccount : Form
    {
        clCommonBL objBL = new clCommonBL();
        CommunicationRef.CommunicationService objService = new CommunicationRef.CommunicationService();
        public frmSelectAccount()
        {
            InitializeComponent();
        }

        private void frmSelectAccount_Load(object sender, EventArgs e)
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

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            //Report with reciept : table name balancedetails
            //Remaining : Exact reciept of the ATM and its field has to be checked
        }

        private void btnSaving_Click(object sender, EventArgs e)
        {
        

        }

        private void lblProceed_Click(object sender, EventArgs e)
        {
            SelectAcct.BankID = ddlBank.SelectedValue.ToString();
            if (ATMApp.frmCustomLogin.ClassValue.BankID != SelectAcct.BankID)
            {
                ATMApp.frmCustomLogin.ClassValue.OtherBankTransactionInd++;
            }
            this.Hide();
            frmCashReciept updatepin = new frmCashReciept();
            updatepin.ShowDialog();
            this.Close();
        }

        public static class SelectAcct
        {
            public static string BankID;
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

        private void frmSelectAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        
    }
}
