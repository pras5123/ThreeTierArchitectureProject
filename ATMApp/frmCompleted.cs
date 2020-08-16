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
    public partial class frmCompleted : Form
    {
        private static int CloseIndicator = 0;
        public frmCompleted()
        {
            InitializeComponent();
        }

        private void frmCompleted_Load(object sender, EventArgs e)
        {

        }

        private void imgNo_Click(object sender, EventArgs e)
        {
            CloseIndicator = 1;
            CommunicationRef.CommunicationService objService = new CommunicationRef.CommunicationService();
            //clCommonBL objService = new clCommonBL();
            if (ATMApp.frmCustomLogin.ClassValue.OtherBankTransactionInd > 0)
            {
             int Returncode=  objService.MonthlyMaintainanceCharges(ATMApp.frmCustomLogin.ClassValue.UserName.ToString(), ATMApp.frmCustomLogin.ClassValue.Password.ToString(), Convert.ToInt32(ATMApp.frmCustomLogin.ClassValue.AtmPin));
            }
            this.Close();
            //comment for the time being 
           // CallCashReciept();
        }

        private void imgYes_Click(object sender, EventArgs e)
        {
            CallUpdatePIN();
        }


        private void CallCashReciept()
        {
            this.Hide();
            frmCashReciept updatepin = new frmCashReciept();
            updatepin.ShowDialog();
            this.Close();
        }

        private void CallUpdatePIN()
        {
            this.Hide();
            frmOptions updatepin = new frmOptions();
            updatepin.ShowDialog();
            this.Close();
        }

        private void frmCompleted_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseIndicator == 1)
            {
                e.Cancel = false;
            }
            else
            {
                //preventing the user from closing the form
                e.Cancel = true;
            }
        }
    }
}
