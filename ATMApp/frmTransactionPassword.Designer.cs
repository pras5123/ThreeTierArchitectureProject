namespace ATMApp
{
    partial class frmTransactionPassword
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
            this.lblProceed = new System.Windows.Forms.Label();
            this.txtTransactionPassword = new System.Windows.Forms.TextBox();
            this.lblToAccountNumber = new System.Windows.Forms.Label();
            this.lblGoBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProceed
            // 
            this.lblProceed.AutoSize = true;
            this.lblProceed.Image = global::ATMApp.Properties.Resources.Proceed;
            this.lblProceed.Location = new System.Drawing.Point(283, 90);
            this.lblProceed.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblProceed.Name = "lblProceed";
            this.lblProceed.Size = new System.Drawing.Size(200, 50);
            this.lblProceed.TabIndex = 56;
            this.lblProceed.Click += new System.EventHandler(this.lblProceed_Click);
            // 
            // txtTransactionPassword
            // 
            this.txtTransactionPassword.Location = new System.Drawing.Point(256, 36);
            this.txtTransactionPassword.Name = "txtTransactionPassword";
            this.txtTransactionPassword.Size = new System.Drawing.Size(227, 20);
            this.txtTransactionPassword.TabIndex = 58;
            // 
            // lblToAccountNumber
            // 
            this.lblToAccountNumber.AutoSize = true;
            this.lblToAccountNumber.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToAccountNumber.Location = new System.Drawing.Point(39, 36);
            this.lblToAccountNumber.Name = "lblToAccountNumber";
            this.lblToAccountNumber.Size = new System.Drawing.Size(180, 17);
            this.lblToAccountNumber.TabIndex = 57;
            this.lblToAccountNumber.Text = "Transaction Password";
            // 
            // lblGoBack
            // 
            this.lblGoBack.AutoSize = true;
            this.lblGoBack.Image = global::ATMApp.Properties.Resources.GoBackGreen1;
            this.lblGoBack.Location = new System.Drawing.Point(58, 90);
            this.lblGoBack.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblGoBack.Name = "lblGoBack";
            this.lblGoBack.Size = new System.Drawing.Size(200, 50);
            this.lblGoBack.TabIndex = 59;
            this.lblGoBack.Click += new System.EventHandler(this.lblGoBack_Click);
            // 
            // frmTransactionPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(597, 159);
            this.Controls.Add(this.lblGoBack);
            this.Controls.Add(this.txtTransactionPassword);
            this.Controls.Add(this.lblToAccountNumber);
            this.Controls.Add(this.lblProceed);
            this.Name = "frmTransactionPassword";
            this.Text = "Enter Transaction Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTransactionPassword_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProceed;
        private System.Windows.Forms.TextBox txtTransactionPassword;
        private System.Windows.Forms.Label lblToAccountNumber;
        private System.Windows.Forms.Label lblGoBack;
    }
}