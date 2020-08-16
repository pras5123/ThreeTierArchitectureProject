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
    public partial class frmUpdatePIN : Form
    {
        //clCommonBL objBL = new clCommonBL();
        CommunicationRef.CommunicationService objService = new CommunicationRef.CommunicationService();
        public frmUpdatePIN()
        {
            InitializeComponent();
        }

    
        
        private void frmUpdatePIN_Load(object sender, EventArgs e)
        {
            
            DataSet dsBank;
            try
            {
                dsBank = objService.GetBankForm(Convert.ToInt32(ATMApp.frmCustomLogin.ClassValue.CustomerId));
                if (dsBank.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsBank.Tables[0].NewRow();
                    dr[0] = 0;
                    dr[1] = "---Select Bank---";
                    dsBank.Tables[0].Rows.InsertAt(dr, 0);
                    ddlBank.DisplayMember = "name";
                    ddlBank.ValueMember = "BankID";
                    ddlBank.DataSource = dsBank.Tables[0];
                }
                if (dsBank.Tables[1] != null)
                {
                    if (dsBank.Tables[1].Rows.Count > 0)
                    {
                        lblCardNOValue.Text = dsBank.Tables[1].Rows[0]["creditID"].ToString();
                        lblExpDateValue.Text = dsBank.Tables[1].Rows[0]["expdate"].ToString().Split(' ')[0]; 
                    }
                }
            }
            catch
            {
                
            }
            finally
            {
                dsBank = null;
               // this.Close();
            }
        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void txtOldPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyCheck(e);
        }

        private void txtNewPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyCheck(e);
        }

        private static void KeyCheck(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOptions options = new frmOptions();
            options.ShowDialog();
            this.Close();
        }

        private void lblUpdatePIN_Click(object sender, EventArgs e)
        {
            
           
            try
            {
                if (txtOldPIN.Text == String.Empty)
                {
                    MessageBox.Show("Please enter Old ATM Pin");
                    return;
                }
                if (txtNewPIN.Text == String.Empty)
                {
                    MessageBox.Show("Please enter New ATM Pin");
                    return;
                }

                if (ddlBank.SelectedIndex == 0)
                {
                    MessageBox.Show("Please select Bank");
                    return;
                }

                if (txtOldPIN.Text == txtNewPIN.Text)
                {
                    MessageBox.Show("Old ATM Pin should be different from New ATM Pin");
                    return;
                }

                if (txtNewPIN.Text.Length != 4)
                {
                    MessageBox.Show("Invalid ATM pin.ATM Pin should have 4 digits ");
                    return;
                }
                clCommonBL objcmBL = new clCommonBL();
                int CustomerId = Convert.ToInt32(ATMApp.frmCustomLogin.ClassValue.CustomerId);
                CommunicationRef.CommunicationService objService = new CommunicationRef.CommunicationService();
         
                int ReturnResult = objService.UpdatePINDetails(Convert.ToInt32(txtNewPIN.Text), Convert.ToInt32(txtOldPIN.Text), ddlBank.SelectedValue.ToString(), CustomerId);
                if (ATMApp.frmCustomLogin.ClassValue.BankID != ddlBank.SelectedValue.ToString())
                {
                    ATMApp.frmCustomLogin.ClassValue.OtherBankTransactionInd++;
                }
                
                if (ReturnResult == 1)
                {
                    ATMApp.frmCustomLogin.ClassValue.AtmPin = Convert.ToInt32(txtNewPIN.Text);
                    MessageBox.Show("ATM PIN has been updated successfully");
                }
                if (ReturnResult == 0)
                {
                    MessageBox.Show("System could not update your PIN. Your Old ATM PIN might be incorrect");
                }
            }
            catch
            {

            }
            finally
            {
                objService = null;
            }
        }

        private void frmUpdatePIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
