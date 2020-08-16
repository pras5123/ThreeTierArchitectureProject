namespace ATMApp
{
    partial class frmCashReciept
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rptCrystalViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.BalanceDetailsRpt1 = new ATMApp.Reports.BalanceDetailsRpt();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGoBack = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rptCrystalViewer
            // 
            this.rptCrystalViewer.ActiveViewIndex = -1;
            this.rptCrystalViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptCrystalViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptCrystalViewer.DisplayStatusBar = false;
            this.rptCrystalViewer.EnableDrillDown = false;
            this.rptCrystalViewer.Location = new System.Drawing.Point(3, 3);
            this.rptCrystalViewer.Name = "rptCrystalViewer";
            this.rptCrystalViewer.Size = new System.Drawing.Size(450, 441);
            this.rptCrystalViewer.TabIndex = 0;
            this.rptCrystalViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.rptCrystalViewer.ToolPanelWidth = 100;
            this.rptCrystalViewer.Load += new System.EventHandler(this.rptCrystalViewer_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rptCrystalViewer);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 447);
            this.panel1.TabIndex = 1;
            // 
            // lblGoBack
            // 
            this.lblGoBack.AutoSize = true;
            this.lblGoBack.Image = global::ATMApp.Properties.Resources.GoBackGreen1;
            this.lblGoBack.Location = new System.Drawing.Point(128, 462);
            this.lblGoBack.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblGoBack.Name = "lblGoBack";
            this.lblGoBack.Size = new System.Drawing.Size(200, 50);
            this.lblGoBack.TabIndex = 33;
            this.lblGoBack.Click += new System.EventHandler(this.lblGoBack_Click);
            // 
            // frmCashReciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 515);
            this.Controls.Add(this.lblGoBack);
            this.Controls.Add(this.panel1);
            this.Name = "frmCashReciept";
            this.Text = "Cash Reciept";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCashReciept_FormClosing);
            this.Load += new System.EventHandler(this.frmCashReciept_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptCrystalViewer;
        private Reports.BalanceDetailsRpt BalanceDetailsRpt1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGoBack;


    }
}