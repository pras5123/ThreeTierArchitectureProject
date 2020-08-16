namespace ATMApp
{
    partial class frmTest
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
            this.imgSavingsAcount = new System.Windows.Forms.PictureBox();
            this.imgOtherAccount = new System.Windows.Forms.PictureBox();
            this.lblSavingsAccount = new System.Windows.Forms.Label();
            this.lblOtherAccount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgSavingsAcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOtherAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // imgSavingsAcount
            // 
            this.imgSavingsAcount.BackgroundImage = global::ATMApp.Properties.Resources.arrow_button;
            this.imgSavingsAcount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgSavingsAcount.Location = new System.Drawing.Point(27, 46);
            this.imgSavingsAcount.Name = "imgSavingsAcount";
            this.imgSavingsAcount.Size = new System.Drawing.Size(81, 75);
            this.imgSavingsAcount.TabIndex = 42;
            this.imgSavingsAcount.TabStop = false;
            this.imgSavingsAcount.Visible = false;
            // 
            // imgOtherAccount
            // 
            this.imgOtherAccount.BackgroundImage = global::ATMApp.Properties.Resources.arrow_button;
            this.imgOtherAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgOtherAccount.Location = new System.Drawing.Point(399, 46);
            this.imgOtherAccount.Name = "imgOtherAccount";
            this.imgOtherAccount.Size = new System.Drawing.Size(81, 75);
            this.imgOtherAccount.TabIndex = 41;
            this.imgOtherAccount.TabStop = false;
            this.imgOtherAccount.Visible = false;
            // 
            // lblSavingsAccount
            // 
            this.lblSavingsAccount.AutoSize = true;
            this.lblSavingsAccount.Image = global::ATMApp.Properties.Resources.Saving_Account_N;
            this.lblSavingsAccount.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSavingsAccount.Location = new System.Drawing.Point(136, 98);
            this.lblSavingsAccount.MinimumSize = new System.Drawing.Size(240, 50);
            this.lblSavingsAccount.Name = "lblSavingsAccount";
            this.lblSavingsAccount.Size = new System.Drawing.Size(240, 50);
            this.lblSavingsAccount.TabIndex = 40;
            this.lblSavingsAccount.Visible = false;
            // 
            // lblOtherAccount
            // 
            this.lblOtherAccount.AutoSize = true;
            this.lblOtherAccount.Image = global::ATMApp.Properties.Resources.Other_Account_N;
            this.lblOtherAccount.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblOtherAccount.Location = new System.Drawing.Point(136, 34);
            this.lblOtherAccount.MinimumSize = new System.Drawing.Size(240, 50);
            this.lblOtherAccount.Name = "lblOtherAccount";
            this.lblOtherAccount.Size = new System.Drawing.Size(240, 50);
            this.lblOtherAccount.TabIndex = 39;
            this.lblOtherAccount.Visible = false;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 261);
            this.Controls.Add(this.imgSavingsAcount);
            this.Controls.Add(this.imgOtherAccount);
            this.Controls.Add(this.lblSavingsAccount);
            this.Controls.Add(this.lblOtherAccount);
            this.Name = "frmTest";
            this.Text = "frmTest";
            ((System.ComponentModel.ISupportInitialize)(this.imgSavingsAcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOtherAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgSavingsAcount;
        private System.Windows.Forms.PictureBox imgOtherAccount;
        private System.Windows.Forms.Label lblSavingsAccount;
        private System.Windows.Forms.Label lblOtherAccount;
    }
}