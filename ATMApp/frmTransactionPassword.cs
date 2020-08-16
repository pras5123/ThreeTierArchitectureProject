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
    public partial class frmTransactionPassword : Form
    {
        clCommonBL objBL = new clCommonBL();
        public frmTransactionPassword()
        {
            InitializeComponent();
        }

        private void lblProceed_Click(object sender, EventArgs e)
        {
          DataSet dsValidate= objBL.ValidateTransactionPassword(ATMApp.frmCustomLogin.ClassValue.CustomerId, ATMApp.frmCustomLogin.ClassValue.BankID,txtTransactionPassword.Text);
          if (dsValidate != null)
          {
              if (dsValidate.Tables[0] != null)
              {
                  if (dsValidate.Tables[0].Rows.Count > 0)
                  {
                      if(ATMApp.frmOptions.frmOpt.OptionIndicator != null)
                      {
                          if (ATMApp.frmOptions.frmOpt.OptionIndicator == "Transfer")
                          {
                              SelectBankFund();
                          }
                          else
                          {
                              CallCashWithDrawal();
                          }
                      }
                  }
                  else
                  {
                      MessageBox.Show("Transaction Password is incorrect");
                      return;
                  }
              }
          }

        }

        private void SelectBankFund()
        {
            this.Hide();
            frmSelectBankFund updatepin = new frmSelectBankFund();
            updatepin.ShowDialog();
            this.Close();

        }

        private void CallCashWithDrawal()
        {
            this.Hide();
            frmEnterAmount updatepin = new frmEnterAmount();
            updatepin.ShowDialog();
            this.Close();

        }

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOptions updatepin = new frmOptions();
            updatepin.ShowDialog();
            this.Close();
        }

        private void frmTransactionPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
