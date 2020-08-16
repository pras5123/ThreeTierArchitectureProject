namespace ATMApp
{
    partial class frmSelectBankFund
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
            this.lblIntraBankTransfer = new System.Windows.Forms.Label();
            this.lblInterbankTransfer = new System.Windows.Forms.Label();
            this.imgIntraBankTransfer = new System.Windows.Forms.PictureBox();
            this.imgInterbankTransfer = new System.Windows.Forms.PictureBox();
            this.lblGoBack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgIntraBankTransfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInterbankTransfer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIntraBankTransfer
            // 
            this.lblIntraBankTransfer.AutoSize = true;
            this.lblIntraBankTransfer.Image = global::ATMApp.Properties.Resources.Intra_Bank_Transfer;
            this.lblIntraBankTransfer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblIntraBankTransfer.Location = new System.Drawing.Point(517, 46);
            this.lblIntraBankTransfer.MinimumSize = new System.Drawing.Size(240, 50);
            this.lblIntraBankTransfer.Name = "lblIntraBankTransfer";
            this.lblIntraBankTransfer.Size = new System.Drawing.Size(240, 50);
            this.lblIntraBankTransfer.TabIndex = 31;
            this.lblIntraBankTransfer.Click += new System.EventHandler(this.lblIntraBankTransfer_Click);
            // 
            // lblInterbankTransfer
            // 
            this.lblInterbankTransfer.AutoSize = true;
            this.lblInterbankTransfer.Image = global::ATMApp.Properties.Resources.Inter_Bank_Transfer;
            this.lblInterbankTransfer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblInterbankTransfer.Location = new System.Drawing.Point(126, 46);
            this.lblInterbankTransfer.MinimumSize = new System.Drawing.Size(240, 50);
            this.lblInterbankTransfer.Name = "lblInterbankTransfer";
            this.lblInterbankTransfer.Size = new System.Drawing.Size(240, 50);
            this.lblInterbankTransfer.TabIndex = 29;
            this.lblInterbankTransfer.Click += new System.EventHandler(this.lblInterbankTransfer_Click);
            // 
            // imgIntraBankTransfer
            // 
            this.imgIntraBankTransfer.BackgroundImage = global::ATMApp.Properties.Resources.arrow_button;
            this.imgIntraBankTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgIntraBankTransfer.Location = new System.Drawing.Point(430, 34);
            this.imgIntraBankTransfer.Name = "imgIntraBankTransfer";
            this.imgIntraBankTransfer.Size = new System.Drawing.Size(81, 75);
            this.imgIntraBankTransfer.TabIndex = 36;
            this.imgIntraBankTransfer.TabStop = false;
            this.imgIntraBankTransfer.Click += new System.EventHandler(this.imgIntraBankTransfer_Click);
            // 
            // imgInterbankTransfer
            // 
            this.imgInterbankTransfer.BackgroundImage = global::ATMApp.Properties.Resources.arrow_button;
            this.imgInterbankTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgInterbankTransfer.Location = new System.Drawing.Point(39, 32);
            this.imgInterbankTransfer.Name = "imgInterbankTransfer";
            this.imgInterbankTransfer.Size = new System.Drawing.Size(81, 75);
            this.imgInterbankTransfer.TabIndex = 37;
            this.imgInterbankTransfer.TabStop = false;
            this.imgInterbankTransfer.Click += new System.EventHandler(this.imgInterbankTransfer_Click);
            // 
            // lblGoBack
            // 
            this.lblGoBack.AutoSize = true;
            this.lblGoBack.Image = global::ATMApp.Properties.Resources.GoBackSmall;
            this.lblGoBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblGoBack.Location = new System.Drawing.Point(329, 156);
            this.lblGoBack.MinimumSize = new System.Drawing.Size(150, 40);
            this.lblGoBack.Name = "lblGoBack";
            this.lblGoBack.Size = new System.Drawing.Size(150, 40);
            this.lblGoBack.TabIndex = 39;
            this.lblGoBack.Click += new System.EventHandler(this.lblGoBack_Click);
            // 
            // frmSelectBankFund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(806, 220);
            this.Controls.Add(this.lblGoBack);
            this.Controls.Add(this.imgInterbankTransfer);
            this.Controls.Add(this.imgIntraBankTransfer);
            this.Controls.Add(this.lblIntraBankTransfer);
            this.Controls.Add(this.lblInterbankTransfer);
            this.Name = "frmSelectBankFund";
            this.Text = "frmSelectBankFund";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSelectBankFund_FormClosing);
            this.Load += new System.EventHandler(this.frmSelectBankFund_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgIntraBankTransfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInterbankTransfer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInterbankTransfer;
        private System.Windows.Forms.Label lblIntraBankTransfer;
        private System.Windows.Forms.PictureBox imgIntraBankTransfer;
        private System.Windows.Forms.PictureBox imgInterbankTransfer;
        private System.Windows.Forms.Label lblGoBack;
    }
}