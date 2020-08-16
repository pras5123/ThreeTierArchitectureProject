namespace ATMApp
{
    partial class frmSelectAccount
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
            this.lblGoBack = new System.Windows.Forms.Label();
            this.lblProceed = new System.Windows.Forms.Label();
            this.ddlBank = new System.Windows.Forms.ComboBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.rbtnSavingAccount = new System.Windows.Forms.RadioButton();
            this.rbtnCurrentAccount = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Please select the Account";
            // 
            // lblGoBack
            // 
            this.lblGoBack.AutoSize = true;
            this.lblGoBack.Image = global::ATMApp.Properties.Resources.GoBackGreen1;
            this.lblGoBack.Location = new System.Drawing.Point(2, 344);
            this.lblGoBack.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblGoBack.Name = "lblGoBack";
            this.lblGoBack.Size = new System.Drawing.Size(200, 50);
            this.lblGoBack.TabIndex = 32;
            this.lblGoBack.Click += new System.EventHandler(this.lblGoBack_Click);
            // 
            // lblProceed
            // 
            this.lblProceed.AutoSize = true;
            this.lblProceed.Image = global::ATMApp.Properties.Resources.Proceed;
            this.lblProceed.Location = new System.Drawing.Point(454, 344);
            this.lblProceed.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblProceed.Name = "lblProceed";
            this.lblProceed.Size = new System.Drawing.Size(200, 50);
            this.lblProceed.TabIndex = 31;
            this.lblProceed.Click += new System.EventHandler(this.lblProceed_Click);
            // 
            // ddlBank
            // 
            this.ddlBank.FormattingEnabled = true;
            this.ddlBank.Location = new System.Drawing.Point(293, 114);
            this.ddlBank.Name = "ddlBank";
            this.ddlBank.Size = new System.Drawing.Size(200, 21);
            this.ddlBank.TabIndex = 34;
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBank.Location = new System.Drawing.Point(103, 118);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(112, 17);
            this.lblBank.TabIndex = 33;
            this.lblBank.Text = "Select a Bank";
            // 
            // rbtnSavingAccount
            // 
            this.rbtnSavingAccount.AutoSize = true;
            this.rbtnSavingAccount.BackgroundImage = global::ATMApp.Properties.Resources.Savings_Account;
            this.rbtnSavingAccount.Location = new System.Drawing.Point(293, 164);
            this.rbtnSavingAccount.MinimumSize = new System.Drawing.Size(200, 45);
            this.rbtnSavingAccount.Name = "rbtnSavingAccount";
            this.rbtnSavingAccount.Size = new System.Drawing.Size(200, 45);
            this.rbtnSavingAccount.TabIndex = 36;
            this.rbtnSavingAccount.TabStop = true;
            this.rbtnSavingAccount.UseVisualStyleBackColor = true;
            // 
            // rbtnCurrentAccount
            // 
            this.rbtnCurrentAccount.AutoSize = true;
            this.rbtnCurrentAccount.BackgroundImage = global::ATMApp.Properties.Resources.Current_Account;
            this.rbtnCurrentAccount.Location = new System.Drawing.Point(293, 238);
            this.rbtnCurrentAccount.MinimumSize = new System.Drawing.Size(200, 45);
            this.rbtnCurrentAccount.Name = "rbtnCurrentAccount";
            this.rbtnCurrentAccount.Size = new System.Drawing.Size(200, 45);
            this.rbtnCurrentAccount.TabIndex = 38;
            this.rbtnCurrentAccount.TabStop = true;
            this.rbtnCurrentAccount.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Select an Account";
            // 
            // frmSelectAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(657, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtnCurrentAccount);
            this.Controls.Add(this.rbtnSavingAccount);
            this.Controls.Add(this.ddlBank);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.lblGoBack);
            this.Controls.Add(this.lblProceed);
            this.Controls.Add(this.label1);
            this.Name = "frmSelectAccount";
            this.Text = "Select an Account";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSelectAccount_FormClosing);
            this.Load += new System.EventHandler(this.frmSelectAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProceed;
        private System.Windows.Forms.Label lblGoBack;
        private System.Windows.Forms.ComboBox ddlBank;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.RadioButton rbtnSavingAccount;
        private System.Windows.Forms.RadioButton rbtnCurrentAccount;
        private System.Windows.Forms.Label label2;
    }
}