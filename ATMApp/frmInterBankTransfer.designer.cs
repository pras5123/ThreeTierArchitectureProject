namespace ATMApp
{
    partial class frmInterBankTransfer
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
            this.lblBenificiaryName = new System.Windows.Forms.Label();
            this.lblToAccountNumber = new System.Windows.Forms.Label();
            this.lblToBank = new System.Windows.Forms.Label();
            this.lblFromAccountNumber = new System.Windows.Forms.Label();
            this.lblFromBank = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.ddlFromBank = new System.Windows.Forms.ComboBox();
            this.ddlToBank = new System.Windows.Forms.ComboBox();
            this.txtFromAccountNumber = new System.Windows.Forms.TextBox();
            this.txtToAccountNumber = new System.Windows.Forms.TextBox();
            this.txtBenificiaryName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblTransfer = new System.Windows.Forms.Label();
            this.lblGoBack = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBenificiaryName
            // 
            this.lblBenificiaryName.AutoSize = true;
            this.lblBenificiaryName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenificiaryName.Location = new System.Drawing.Point(42, 217);
            this.lblBenificiaryName.Name = "lblBenificiaryName";
            this.lblBenificiaryName.Size = new System.Drawing.Size(137, 17);
            this.lblBenificiaryName.TabIndex = 34;
            this.lblBenificiaryName.Text = "Benificiary Name";
            // 
            // lblToAccountNumber
            // 
            this.lblToAccountNumber.AutoSize = true;
            this.lblToAccountNumber.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToAccountNumber.Location = new System.Drawing.Point(42, 168);
            this.lblToAccountNumber.Name = "lblToAccountNumber";
            this.lblToAccountNumber.Size = new System.Drawing.Size(162, 17);
            this.lblToAccountNumber.TabIndex = 35;
            this.lblToAccountNumber.Text = "To Account Number";
            // 
            // lblToBank
            // 
            this.lblToBank.AutoSize = true;
            this.lblToBank.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToBank.Location = new System.Drawing.Point(42, 119);
            this.lblToBank.Name = "lblToBank";
            this.lblToBank.Size = new System.Drawing.Size(72, 17);
            this.lblToBank.TabIndex = 36;
            this.lblToBank.Text = "To Bank";
            // 
            // lblFromAccountNumber
            // 
            this.lblFromAccountNumber.AutoSize = true;
            this.lblFromAccountNumber.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromAccountNumber.Location = new System.Drawing.Point(42, 72);
            this.lblFromAccountNumber.Name = "lblFromAccountNumber";
            this.lblFromAccountNumber.Size = new System.Drawing.Size(182, 17);
            this.lblFromAccountNumber.TabIndex = 37;
            this.lblFromAccountNumber.Text = "From Account Number";
            // 
            // lblFromBank
            // 
            this.lblFromBank.AutoSize = true;
            this.lblFromBank.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromBank.Location = new System.Drawing.Point(42, 27);
            this.lblFromBank.Name = "lblFromBank";
            this.lblFromBank.Size = new System.Drawing.Size(92, 17);
            this.lblFromBank.TabIndex = 38;
            this.lblFromBank.Text = "From Bank";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(42, 267);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(69, 17);
            this.lblAmount.TabIndex = 39;
            this.lblAmount.Text = "Amount";
            // 
            // ddlFromBank
            // 
            this.ddlFromBank.FormattingEnabled = true;
            this.ddlFromBank.Location = new System.Drawing.Point(339, 27);
            this.ddlFromBank.Name = "ddlFromBank";
            this.ddlFromBank.Size = new System.Drawing.Size(314, 21);
            this.ddlFromBank.TabIndex = 40;
            this.ddlFromBank.SelectedIndexChanged += new System.EventHandler(this.ddlFromBank_SelectedIndexChanged);
            // 
            // ddlToBank
            // 
            this.ddlToBank.FormattingEnabled = true;
            this.ddlToBank.Location = new System.Drawing.Point(339, 119);
            this.ddlToBank.Name = "ddlToBank";
            this.ddlToBank.Size = new System.Drawing.Size(314, 21);
            this.ddlToBank.TabIndex = 41;
            // 
            // txtFromAccountNumber
            // 
            this.txtFromAccountNumber.Enabled = false;
            this.txtFromAccountNumber.Location = new System.Drawing.Point(339, 72);
            this.txtFromAccountNumber.Name = "txtFromAccountNumber";
            this.txtFromAccountNumber.Size = new System.Drawing.Size(314, 20);
            this.txtFromAccountNumber.TabIndex = 42;
            // 
            // txtToAccountNumber
            // 
            this.txtToAccountNumber.Location = new System.Drawing.Point(339, 168);
            this.txtToAccountNumber.Name = "txtToAccountNumber";
            this.txtToAccountNumber.Size = new System.Drawing.Size(314, 20);
            this.txtToAccountNumber.TabIndex = 43;
            // 
            // txtBenificiaryName
            // 
            this.txtBenificiaryName.Location = new System.Drawing.Point(339, 217);
            this.txtBenificiaryName.Name = "txtBenificiaryName";
            this.txtBenificiaryName.Size = new System.Drawing.Size(314, 20);
            this.txtBenificiaryName.TabIndex = 44;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(339, 264);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(314, 20);
            this.txtAmount.TabIndex = 45;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // lblTransfer
            // 
            this.lblTransfer.AutoSize = true;
            this.lblTransfer.Image = global::ATMApp.Properties.Resources.transfer;
            this.lblTransfer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblTransfer.Location = new System.Drawing.Point(397, 305);
            this.lblTransfer.MinimumSize = new System.Drawing.Size(150, 40);
            this.lblTransfer.Name = "lblTransfer";
            this.lblTransfer.Size = new System.Drawing.Size(150, 40);
            this.lblTransfer.TabIndex = 54;
            this.lblTransfer.Click += new System.EventHandler(this.lblTransfer_Click);
            // 
            // lblGoBack
            // 
            this.lblGoBack.AutoSize = true;
            this.lblGoBack.Image = global::ATMApp.Properties.Resources.GoBackCrystalSmall;
            this.lblGoBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblGoBack.Location = new System.Drawing.Point(207, 305);
            this.lblGoBack.MinimumSize = new System.Drawing.Size(150, 40);
            this.lblGoBack.Name = "lblGoBack";
            this.lblGoBack.Size = new System.Drawing.Size(150, 40);
            this.lblGoBack.TabIndex = 53;
            this.lblGoBack.Click += new System.EventHandler(this.lblGoBack_Click);
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(659, 72);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(60, 13);
            this.lblAvailable.TabIndex = 56;
            this.lblAvailable.Text = "Avail. Bal : ";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(726, 72);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 13);
            this.lblBalance.TabIndex = 57;
            // 
            // frmInterBankTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(779, 358);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lblTransfer);
            this.Controls.Add(this.lblGoBack);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtBenificiaryName);
            this.Controls.Add(this.txtToAccountNumber);
            this.Controls.Add(this.txtFromAccountNumber);
            this.Controls.Add(this.ddlToBank);
            this.Controls.Add(this.ddlFromBank);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblFromBank);
            this.Controls.Add(this.lblFromAccountNumber);
            this.Controls.Add(this.lblToBank);
            this.Controls.Add(this.lblToAccountNumber);
            this.Controls.Add(this.lblBenificiaryName);
            this.Name = "frmInterBankTransfer";
            this.Text = "Inter Bank Amount Transfer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInterBankTransfer_FormClosing);
            this.Load += new System.EventHandler(this.frmInterBankTransfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBenificiaryName;
        private System.Windows.Forms.Label lblToAccountNumber;
        private System.Windows.Forms.Label lblToBank;
        private System.Windows.Forms.Label lblFromAccountNumber;
        private System.Windows.Forms.Label lblFromBank;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox ddlFromBank;
        private System.Windows.Forms.ComboBox ddlToBank;
        private System.Windows.Forms.TextBox txtFromAccountNumber;
        private System.Windows.Forms.TextBox txtToAccountNumber;
        private System.Windows.Forms.TextBox txtBenificiaryName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblGoBack;
        private System.Windows.Forms.Label lblTransfer;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblBalance;
    }
}