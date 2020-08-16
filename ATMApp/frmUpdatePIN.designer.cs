namespace ATMApp
{
    partial class frmUpdatePIN
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
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblOldPIN = new System.Windows.Forms.Label();
            this.lblNewPIN = new System.Windows.Forms.Label();
            this.lblSelectBank = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblExpDateValue = new System.Windows.Forms.Label();
            this.txtOldPIN = new System.Windows.Forms.TextBox();
            this.txtNewPIN = new System.Windows.Forms.TextBox();
            this.ddlBank = new System.Windows.Forms.ComboBox();
            this.lblCardNOValue = new System.Windows.Forms.Label();
            this.lblUpdatePIN = new System.Windows.Forms.Label();
            this.lblGoBack = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(97, 46);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(69, 13);
            this.lblCardNumber.TabIndex = 12;
            this.lblCardNumber.Text = "Card Number";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(97, 103);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(64, 13);
            this.lblExpiryDate.TabIndex = 13;
            this.lblExpiryDate.Text = "Expirty Date";
            // 
            // lblOldPIN
            // 
            this.lblOldPIN.AutoSize = true;
            this.lblOldPIN.Location = new System.Drawing.Point(97, 151);
            this.lblOldPIN.Name = "lblOldPIN";
            this.lblOldPIN.Size = new System.Drawing.Size(44, 13);
            this.lblOldPIN.TabIndex = 14;
            this.lblOldPIN.Text = "Old PIN";
            // 
            // lblNewPIN
            // 
            this.lblNewPIN.AutoSize = true;
            this.lblNewPIN.Location = new System.Drawing.Point(97, 210);
            this.lblNewPIN.Name = "lblNewPIN";
            this.lblNewPIN.Size = new System.Drawing.Size(50, 13);
            this.lblNewPIN.TabIndex = 15;
            this.lblNewPIN.Text = "New PIN";
            // 
            // lblSelectBank
            // 
            this.lblSelectBank.AutoSize = true;
            this.lblSelectBank.Location = new System.Drawing.Point(97, 269);
            this.lblSelectBank.Name = "lblSelectBank";
            this.lblSelectBank.Size = new System.Drawing.Size(65, 13);
            this.lblSelectBank.TabIndex = 16;
            this.lblSelectBank.Text = "Select Bank";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 17;
            // 
            // lblExpDateValue
            // 
            this.lblExpDateValue.AutoSize = true;
            this.lblExpDateValue.Location = new System.Drawing.Point(259, 103);
            this.lblExpDateValue.Name = "lblExpDateValue";
            this.lblExpDateValue.Size = new System.Drawing.Size(41, 13);
            this.lblExpDateValue.TabIndex = 18;
            this.lblExpDateValue.Text = "Display";
            // 
            // txtOldPIN
            // 
            this.txtOldPIN.Location = new System.Drawing.Point(262, 151);
            this.txtOldPIN.MaxLength = 4;
            this.txtOldPIN.Name = "txtOldPIN";
            this.txtOldPIN.PasswordChar = '*';
            this.txtOldPIN.Size = new System.Drawing.Size(154, 20);
            this.txtOldPIN.TabIndex = 19;
            this.txtOldPIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOldPIN_KeyPress);
            // 
            // txtNewPIN
            // 
            this.txtNewPIN.Location = new System.Drawing.Point(262, 210);
            this.txtNewPIN.MaxLength = 4;
            this.txtNewPIN.Name = "txtNewPIN";
            this.txtNewPIN.PasswordChar = '*';
            this.txtNewPIN.Size = new System.Drawing.Size(154, 20);
            this.txtNewPIN.TabIndex = 20;
            this.txtNewPIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPIN_KeyPress);
            // 
            // ddlBank
            // 
            this.ddlBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlBank.FormattingEnabled = true;
            this.ddlBank.Items.AddRange(new object[] {
            "---Select Bank ---"});
            this.ddlBank.Location = new System.Drawing.Point(262, 260);
            this.ddlBank.Name = "ddlBank";
            this.ddlBank.Size = new System.Drawing.Size(154, 21);
            this.ddlBank.TabIndex = 21;
            // 
            // lblCardNOValue
            // 
            this.lblCardNOValue.AutoSize = true;
            this.lblCardNOValue.Location = new System.Drawing.Point(259, 46);
            this.lblCardNOValue.Name = "lblCardNOValue";
            this.lblCardNOValue.Size = new System.Drawing.Size(41, 13);
            this.lblCardNOValue.TabIndex = 22;
            this.lblCardNOValue.Text = "Display";
            // 
            // lblUpdatePIN
            // 
            this.lblUpdatePIN.AutoSize = true;
            this.lblUpdatePIN.Image = global::ATMApp.Properties.Resources.UpdatePINSmall;
            this.lblUpdatePIN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblUpdatePIN.Location = new System.Drawing.Point(259, 307);
            this.lblUpdatePIN.MinimumSize = new System.Drawing.Size(150, 40);
            this.lblUpdatePIN.Name = "lblUpdatePIN";
            this.lblUpdatePIN.Size = new System.Drawing.Size(150, 40);
            this.lblUpdatePIN.TabIndex = 29;
            this.lblUpdatePIN.Click += new System.EventHandler(this.lblUpdatePIN_Click);
            // 
            // lblGoBack
            // 
            this.lblGoBack.AutoSize = true;
            this.lblGoBack.Image = global::ATMApp.Properties.Resources.GoBackSmall;
            this.lblGoBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblGoBack.Location = new System.Drawing.Point(97, 307);
            this.lblGoBack.MinimumSize = new System.Drawing.Size(150, 40);
            this.lblGoBack.Name = "lblGoBack";
            this.lblGoBack.Size = new System.Drawing.Size(150, 40);
            this.lblGoBack.TabIndex = 28;
            this.lblGoBack.Click += new System.EventHandler(this.lblGoBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ATMApp.Properties.Resources.cards1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(458, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 318);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // frmUpdatePIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(815, 412);
            this.Controls.Add(this.lblUpdatePIN);
            this.Controls.Add(this.lblGoBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCardNOValue);
            this.Controls.Add(this.ddlBank);
            this.Controls.Add(this.txtNewPIN);
            this.Controls.Add(this.txtOldPIN);
            this.Controls.Add(this.lblExpDateValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSelectBank);
            this.Controls.Add(this.lblNewPIN);
            this.Controls.Add(this.lblOldPIN);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.lblCardNumber);
            this.Name = "frmUpdatePIN";
            this.Text = "Update ATM PIN Number";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUpdatePIN_FormClosing);
            this.Load += new System.EventHandler(this.frmUpdatePIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblOldPIN;
        private System.Windows.Forms.Label lblNewPIN;
        private System.Windows.Forms.Label lblSelectBank;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblExpDateValue;
        private System.Windows.Forms.TextBox txtOldPIN;
        private System.Windows.Forms.TextBox txtNewPIN;
        private System.Windows.Forms.ComboBox ddlBank;
        private System.Windows.Forms.Label lblCardNOValue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGoBack;
        private System.Windows.Forms.Label lblUpdatePIN;
    }
}