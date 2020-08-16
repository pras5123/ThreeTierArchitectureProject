using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;

using System.IO;

namespace ATMApp
{
    public partial class frmCashReciept : Form
    {
        public frmCashReciept()
        {
            InitializeComponent();
        }

        private void frmCashReciept_Load(object sender, EventArgs e)
        {
            int test = 0;
            int Customerid = ATMApp.frmCustomLogin.ClassValue.CustomerId;
            string BankID = String.Empty;
            if (ATMApp.frmEnterAmount.EnterAmt.BankID != null)
            {
                if (ATMApp.frmEnterAmount.EnterAmt.BankID.ToString() != "")
                {
                    BankID = ATMApp.frmEnterAmount.EnterAmt.BankID;
                }
            }
            else if (ATMApp.frmSelectAccount.SelectAcct.BankID != null)
            {
                if (ATMApp.frmSelectAccount.SelectAcct.BankID.ToString() != "")
                {
                    BankID = ATMApp.frmSelectAccount.SelectAcct.BankID;
                }
            }
            else
            {
                BankID = ATMApp.frmCustomLogin.ClassValue.BankID;
            }

            
            GenerateReport(Customerid, BankID);
            DisposeResource();
            
        }

        private static void DisposeResource()
        {
            ATMApp.frmEnterAmount.EnterAmt.BankID = null;
            ATMApp.frmSelectAccount.SelectAcct.BankID = null;
            ATMApp.frmOptions.frmOpt.PathIndicator = null;
        }


        #region Function To Generate the Report in Pdf and Export it to disk
        public void GenerateReport(int ReturnID,string BankId)
        {
            ReportDocument rptDoc = null;
            try
            {
                string Paths = String.Empty;
                if(frmOptions.frmOpt.PathIndicator ==Convert.ToString(frmOptions.EnumValueData.MiniReport))
                {
                    Paths = "Reports/MiniBalanceDetailsRpt.rpt";                    
                }
                else
                {
                    Paths = "Reports/BalanceDetailsRpt.rpt";
                }
                rptDoc = new ReportDocument();
                string FullPath = Path.GetFullPath(Paths);
                rptDoc.Load(FullPath);
                rptDoc.SetParameterValue("@BankID", BankId);
                rptDoc.SetParameterValue("@customerId", ReturnID);
                rptCrystalViewer.ReportSource = rptDoc;
            }
            catch (Exception ex)
            {
                
               // return string.Empty;
            }
            finally
            {

            }
        }
        #endregion

        private void rptCrystalViewer_Load(object sender, EventArgs e)
        {

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

    

        private void frmCashReciept_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this is the last form , user can close it 
            e.Cancel = true;
        }
    }
}
