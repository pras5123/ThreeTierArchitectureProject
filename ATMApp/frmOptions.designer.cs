namespace ATMApp
{
    partial class frmOptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblProceed = new System.Windows.Forms.Label();
            this.lblMoreServices = new System.Windows.Forms.Label();
            this.lblBillPayment = new System.Windows.Forms.Label();
            this.lblMiniStatement = new System.Windows.Forms.Label();
            this.lblPinChange = new System.Windows.Forms.Label();
            this.lblCashWithdrawal = new System.Windows.Forms.Label();
            this.lblBalanceEnquiry = new System.Windows.Forms.Label();
            this.imgMiniStatement = new System.Windows.Forms.PictureBox();
            this.imgBillPayment = new System.Windows.Forms.PictureBox();
            this.imgMoreServices = new System.Windows.Forms.PictureBox();
            this.imgPinChange = new System.Windows.Forms.PictureBox();
            this.imgCashWithdrawal = new System.Windows.Forms.PictureBox();
            this.imgBalanceEnquiry = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgMiniStatement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBillPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMoreServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPinChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCashWithdrawal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBalanceEnquiry)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Please choose an option";
            // 
            // lblProceed
            // 
            this.lblProceed.AutoSize = true;
            this.lblProceed.Image = global::ATMApp.Properties.Resources.exitbutton;
            this.lblProceed.Location = new System.Drawing.Point(270, 344);
            this.lblProceed.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblProceed.Name = "lblProceed";
            this.lblProceed.Size = new System.Drawing.Size(200, 50);
            this.lblProceed.TabIndex = 57;
            this.lblProceed.Click += new System.EventHandler(this.lblProceed_Click);
            // 
            // lblMoreServices
            // 
            this.lblMoreServices.AutoSize = true;
            this.lblMoreServices.Image = global::ATMApp.Properties.Resources.Fund_Transfer;
            this.lblMoreServices.Location = new System.Drawing.Point(99, 273);
            this.lblMoreServices.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblMoreServices.Name = "lblMoreServices";
            this.lblMoreServices.Size = new System.Drawing.Size(200, 50);
            this.lblMoreServices.TabIndex = 32;
            this.lblMoreServices.Click += new System.EventHandler(this.lblMoreServices_Click);
            // 
            // lblBillPayment
            // 
            this.lblBillPayment.AutoSize = true;
            this.lblBillPayment.Image = global::ATMApp.Properties.Resources.Bill_Payment;
            this.lblBillPayment.Location = new System.Drawing.Point(99, 173);
            this.lblBillPayment.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblBillPayment.Name = "lblBillPayment";
            this.lblBillPayment.Size = new System.Drawing.Size(200, 50);
            this.lblBillPayment.TabIndex = 31;
            this.lblBillPayment.Click += new System.EventHandler(this.lblBillPayment_Click);
            // 
            // lblMiniStatement
            // 
            this.lblMiniStatement.AutoSize = true;
            this.lblMiniStatement.Image = global::ATMApp.Properties.Resources.Mini_Statement;
            this.lblMiniStatement.Location = new System.Drawing.Point(99, 78);
            this.lblMiniStatement.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblMiniStatement.Name = "lblMiniStatement";
            this.lblMiniStatement.Size = new System.Drawing.Size(200, 50);
            this.lblMiniStatement.TabIndex = 30;
            this.lblMiniStatement.Click += new System.EventHandler(this.lblMiniStatement_Click);
            // 
            // lblPinChange
            // 
            this.lblPinChange.AutoSize = true;
            this.lblPinChange.Image = global::ATMApp.Properties.Resources.PIN_Change;
            this.lblPinChange.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblPinChange.Location = new System.Drawing.Point(448, 273);
            this.lblPinChange.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblPinChange.Name = "lblPinChange";
            this.lblPinChange.Size = new System.Drawing.Size(200, 50);
            this.lblPinChange.TabIndex = 29;
            this.lblPinChange.Click += new System.EventHandler(this.lblPinChange_Click);
            // 
            // lblCashWithdrawal
            // 
            this.lblCashWithdrawal.AutoSize = true;
            this.lblCashWithdrawal.Image = global::ATMApp.Properties.Resources.cash_Withdrawal;
            this.lblCashWithdrawal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblCashWithdrawal.Location = new System.Drawing.Point(448, 173);
            this.lblCashWithdrawal.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblCashWithdrawal.Name = "lblCashWithdrawal";
            this.lblCashWithdrawal.Size = new System.Drawing.Size(200, 50);
            this.lblCashWithdrawal.TabIndex = 28;
            this.lblCashWithdrawal.Click += new System.EventHandler(this.lblCashWithdrawal_Click);
            // 
            // lblBalanceEnquiry
            // 
            this.lblBalanceEnquiry.AutoSize = true;
            this.lblBalanceEnquiry.Image = global::ATMApp.Properties.Resources.Balance_Enquiry;
            this.lblBalanceEnquiry.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblBalanceEnquiry.Location = new System.Drawing.Point(448, 78);
            this.lblBalanceEnquiry.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblBalanceEnquiry.Name = "lblBalanceEnquiry";
            this.lblBalanceEnquiry.Size = new System.Drawing.Size(200, 50);
            this.lblBalanceEnquiry.TabIndex = 27;
            this.lblBalanceEnquiry.Click += new System.EventHandler(this.lblBalanceEnquiry_Click);
            // 
            // imgMiniStatement
            // 
            this.imgMiniStatement.BackgroundImage = global::ATMApp.Properties.Resources.arrow_button;
            this.imgMiniStatement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgMiniStatement.Location = new System.Drawing.Point(12, 65);
            this.imgMiniStatement.Name = "imgMiniStatement";
            this.imgMiniStatement.Size = new System.Drawing.Size(81, 75);
            this.imgMiniStatement.TabIndex = 19;
            this.imgMiniStatement.TabStop = false;
            this.imgMiniStatement.Click += new System.EventHandler(this.imgCashReciept_Click);
            // 
            // imgBillPayment
            // 
            this.imgBillPayment.BackgroundImage = global::ATMApp.Properties.Resources.arrow_button;
            this.imgBillPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgBillPayment.Location = new System.Drawing.Point(12, 162);
            this.imgBillPayment.Name = "imgBillPayment";
            this.imgBillPayment.Size = new System.Drawing.Size(81, 75);
            this.imgBillPayment.TabIndex = 18;
            this.imgBillPayment.TabStop = false;
            this.imgBillPayment.Click += new System.EventHandler(this.imgBillPayment_Click);
            // 
            // imgMoreServices
            // 
            this.imgMoreServices.BackgroundImage = global::ATMApp.Properties.Resources.arrow_button;
            this.imgMoreServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgMoreServices.Location = new System.Drawing.Point(12, 264);
            this.imgMoreServices.Name = "imgMoreServices";
            this.imgMoreServices.Size = new System.Drawing.Size(81, 75);
            this.imgMoreServices.TabIndex = 17;
            this.imgMoreServices.TabStop = false;
            this.imgMoreServices.Click += new System.EventHandler(this.imgMoreServices_Click);
            // 
            // imgPinChange
            // 
            this.imgPinChange.BackgroundImage = global::ATMApp.Properties.Resources.arrow_button;
            this.imgPinChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgPinChange.Location = new System.Drawing.Point(654, 264);
            this.imgPinChange.Name = "imgPinChange";
            this.imgPinChange.Size = new System.Drawing.Size(81, 75);
            this.imgPinChange.TabIndex = 16;
            this.imgPinChange.TabStop = false;
            this.imgPinChange.Click += new System.EventHandler(this.imgPinChange_Click);
            // 
            // imgCashWithdrawal
            // 
            this.imgCashWithdrawal.BackgroundImage = global::ATMApp.Properties.Resources.arrow_button;
            this.imgCashWithdrawal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCashWithdrawal.Location = new System.Drawing.Point(654, 162);
            this.imgCashWithdrawal.Name = "imgCashWithdrawal";
            this.imgCashWithdrawal.Size = new System.Drawing.Size(81, 75);
            this.imgCashWithdrawal.TabIndex = 15;
            this.imgCashWithdrawal.TabStop = false;
            this.imgCashWithdrawal.Click += new System.EventHandler(this.imgCashWithdrawal_Click);
            // 
            // imgBalanceEnquiry
            // 
            this.imgBalanceEnquiry.BackgroundImage = global::ATMApp.Properties.Resources.arrow_button;
            this.imgBalanceEnquiry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgBalanceEnquiry.Location = new System.Drawing.Point(654, 65);
            this.imgBalanceEnquiry.Name = "imgBalanceEnquiry";
            this.imgBalanceEnquiry.Size = new System.Drawing.Size(81, 75);
            this.imgBalanceEnquiry.TabIndex = 14;
            this.imgBalanceEnquiry.TabStop = false;
            this.imgBalanceEnquiry.Click += new System.EventHandler(this.imgBalanceEnquiry_Click);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(746, 403);
            this.Controls.Add(this.lblProceed);
            this.Controls.Add(this.lblMoreServices);
            this.Controls.Add(this.lblBillPayment);
            this.Controls.Add(this.lblMiniStatement);
            this.Controls.Add(this.lblPinChange);
            this.Controls.Add(this.lblCashWithdrawal);
            this.Controls.Add(this.lblBalanceEnquiry);
            this.Controls.Add(this.imgMiniStatement);
            this.Controls.Add(this.imgBillPayment);
            this.Controls.Add(this.imgMoreServices);
            this.Controls.Add(this.imgPinChange);
            this.Controls.Add(this.imgCashWithdrawal);
            this.Controls.Add(this.imgBalanceEnquiry);
            this.Controls.Add(this.label1);
            this.Name = "frmOptions";
            this.Text = "Choose Option";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOptions_FormClosing);
            this.Load += new System.EventHandler(this.frmOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgMiniStatement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBillPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMoreServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPinChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCashWithdrawal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBalanceEnquiry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgBalanceEnquiry;
        private System.Windows.Forms.PictureBox imgCashWithdrawal;
        private System.Windows.Forms.PictureBox imgPinChange;
        private System.Windows.Forms.PictureBox imgMoreServices;
        private System.Windows.Forms.PictureBox imgBillPayment;
        private System.Windows.Forms.PictureBox imgMiniStatement;
        private System.Windows.Forms.Label lblBalanceEnquiry;
        private System.Windows.Forms.Label lblCashWithdrawal;
        private System.Windows.Forms.Label lblPinChange;
        private System.Windows.Forms.Label lblMiniStatement;
        private System.Windows.Forms.Label lblBillPayment;
        private System.Windows.Forms.Label lblMoreServices;
        private System.Windows.Forms.Label lblProceed;
    }
}