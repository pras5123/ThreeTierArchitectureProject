using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATMApp
{
    public partial class frmSelectBankFund : Form
    {
        public frmSelectBankFund()
        {
            InitializeComponent();
        }

        private void frmSelectBankFund_Load(object sender, EventArgs e)
        {

        }

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void GoBack()
        {
            this.Hide();
            frmOptions options = new frmOptions();
            options.ShowDialog();
            this.Close();
        }

        private void lblSavingsAccount_Click(object sender, EventArgs e)
        {
            IntraSavingAccount();
        }

        private void imgSavingsAcount_Click(object sender, EventArgs e)
        {
            IntraSavingAccount();
        }


        private void IntraSavingAccount()
        {
            this.Hide();
            frmIntraBankTransfer options = new frmIntraBankTransfer();
            options.ShowDialog();
            this.Close();
        }

        private void lblOtherAccount_Click(object sender, EventArgs e)
        {
            OtherAccount();
        }

        private void imgOtherAccount_Click(object sender, EventArgs e)
        {
            OtherAccount();
        }


        private void OtherAccount()
        {
            this.Hide();
            frmIntraBankTransfer options = new frmIntraBankTransfer();
            options.ShowDialog();
            this.Close();
        }

        private void lblInterbankTransfer_Click(object sender, EventArgs e)
        {
            InterBankAccount();
        }

        private void imgInterbankTransfer_Click(object sender, EventArgs e)
        {
            InterBankAccount();
        }

        private void lblIntraBankTransfer_Click(object sender, EventArgs e)
        {
            IntraBankAccount();
        }

        private void imgIntraBankTransfer_Click(object sender, EventArgs e)
        {
            IntraBankAccount();
        }



        private void IntraBankAccount()
        {
            this.Hide();
            frmIntraBankTransfer options = new frmIntraBankTransfer();
            options.ShowDialog();
            this.Close();
        }


        private void InterBankAccount()
        {
            this.Hide();
            frmInterBankTransfer options = new frmInterBankTransfer();
            options.ShowDialog();
            this.Close();
        }

        private void frmSelectBankFund_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }


    }
}
