using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ATMApp
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }
        string Url = String.Empty;
        private void frmOptions_Load(object sender, EventArgs e)
        {
            Url = string.Format("http://localhost:50316/PayMobileBill.aspx?CustomerId={0}&AtmPIN={1}", ATMApp.frmCustomLogin.ClassValue.CustomerId,ATMApp.frmCustomLogin.ClassValue.AtmPin);
        }

        private void imgCashReciept_Click(object sender, EventArgs e)
        {
            // 1.Please seelct your account screen
            // 2.New screen to show the mini statement. Need Proceed button
            // 3.Transaction completed successfully screen
            frmOpt.PathIndicator = Convert.ToString(EnumValueData.MiniReport);
            CashReciept();
        }

        private void CashReciept()
        {
            this.Hide();
            frmSelectAccount updatepin = new frmSelectAccount();
            updatepin.ShowDialog();
            this.Close();
        }

        private void imgPinChange_Click(object sender, EventArgs e)
        {
            // 1. Change pin by selecting bank 
            // 2. Going back to Select options screen
            CallUpdatePIN();
        }

        private void CallUpdatePIN()
        {
            this.Hide();
            frmUpdatePIN updatepin = new frmUpdatePIN();
            updatepin.ShowDialog();
            this.Close();
        }

        private void imgCashWithdrawal_Click(object sender, EventArgs e)
        {
            frmOpt.OptionIndicator = "withdrawal";
            // 1.Please select your Account Screen
            // 2.Please enter the amount in multiples of 500
            // 3. Cash Reciept : Report
            CallCashWithDrawal();
        }

        private void imgBalanceEnquiry_Click(object sender, EventArgs e)
        {
            frmOpt.PathIndicator = Convert.ToString(EnumValueData.FullReport);
            SelectAccount();
            // 1. Please select Acoount screen
            // 2. Showing Balance Details
            // 3. Would you like another transaction screen; exit
            
        }

        private void imgMoreServices_Click(object sender, EventArgs e)
        {
            frmOpt.OptionIndicator = "Transfer";
            SelectBankFund();
        }

        private void imgBillPayment_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(Url);
            Process.Start(startInfo);
        }

        private void lblMiniStatement_Click(object sender, EventArgs e)
        {
            frmOpt.PathIndicator = Convert.ToString(EnumValueData.MiniReport);
            CashReciept();
        }

        private void lblBillPayment_Click(object sender, EventArgs e)
        {
            
            ProcessStartInfo startInfo = new ProcessStartInfo(Url);
            Process.Start(startInfo);
        }

        private void lblMoreServices_Click(object sender, EventArgs e)
        {
            frmOpt.OptionIndicator = "Transfer";
            SelectBankFund(); 
        }

        private void lblBalanceEnquiry_Click(object sender, EventArgs e)
        {
            frmOpt.PathIndicator = Convert.ToString(EnumValueData.FullReport);
            SelectAccount();
            // 1. Please select Account screen
            // 2. Showing Balance Details : Report
            // 3. Would you like another transaction screen; exit
        }

        public enum EnumValueData
        {
            FullReport,
            MiniReport
        }

        private void lblCashWithdrawal_Click(object sender, EventArgs e)
        {
            frmOpt.OptionIndicator = "withdrawal";
            // 1.Please select your Account Screen
            // 2.Please enter the amount in multiples of 500
            // 3. Cash Reciept : Report
            CallCashWithDrawal();
        }

        private void CallCashWithDrawal()
        {
            this.Hide();
            frmTransactionPassword updatepin = new frmTransactionPassword();
            updatepin.ShowDialog();
            this.Close();
            
        }

        private void SelectAccount()
        {
            this.Hide();
            frmSelectAccount updatepin = new frmSelectAccount();
            updatepin.ShowDialog();
            this.Close();

        }

         private void SelectBankFund()
        {
            this.Hide();
            frmTransactionPassword updatepin = new frmTransactionPassword();
            updatepin.ShowDialog();
            this.Close();

        }
        
        private void lblPinChange_Click(object sender, EventArgs e)
        {
            // 1. Change pin by selecting bank 
            // 2. Going back to Select options screen
            CallUpdatePIN();
        }



        public static class frmOpt
        {
            public static string PathIndicator;
            public static string OptionIndicator;
 
        }

        private void frmOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void lblProceed_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCompleted updatepin = new frmCompleted();
            updatepin.ShowDialog();
            this.Close();
        }
       
    }
}
