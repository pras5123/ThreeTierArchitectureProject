namespace ATMApp
{
    partial class frmEnterAmount
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGoBack = new System.Windows.Forms.Label();
            this.imgClear = new System.Windows.Forms.PictureBox();
            this.imgOK = new System.Windows.Forms.PictureBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.ddlBank = new System.Windows.Forms.ComboBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enter amount ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Rs.";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(366, 111);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(213, 20);
            this.txtAmount.TabIndex = 17;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Select OK  to confirm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(414, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Select CLEAR to re-type the amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(520, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "CLEAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(561, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "OK";
            // 
            // lblGoBack
            // 
            this.lblGoBack.AutoSize = true;
            this.lblGoBack.Image = global::ATMApp.Properties.Resources.GoBack;
            this.lblGoBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblGoBack.Location = new System.Drawing.Point(247, 394);
            this.lblGoBack.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblGoBack.Name = "lblGoBack";
            this.lblGoBack.Size = new System.Drawing.Size(200, 50);
            this.lblGoBack.TabIndex = 30;
            this.lblGoBack.Click += new System.EventHandler(this.lblGoBack_Click);
            // 
            // imgClear
            // 
            this.imgClear.BackgroundImage = global::ATMApp.Properties.Resources.nobutton;
            this.imgClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgClear.Location = new System.Drawing.Point(611, 299);
            this.imgClear.Name = "imgClear";
            this.imgClear.Size = new System.Drawing.Size(98, 90);
            this.imgClear.TabIndex = 25;
            this.imgClear.TabStop = false;
            this.imgClear.Click += new System.EventHandler(this.imgClear_Click);
            // 
            // imgOK
            // 
            this.imgOK.BackgroundImage = global::ATMApp.Properties.Resources.yesbutton;
            this.imgOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgOK.Location = new System.Drawing.Point(611, 197);
            this.imgOK.Name = "imgOK";
            this.imgOK.Size = new System.Drawing.Size(98, 90);
            this.imgOK.TabIndex = 24;
            this.imgOK.TabStop = false;
            this.imgOK.Click += new System.EventHandler(this.imgOK_Click);
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBank.Location = new System.Drawing.Point(124, 44);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(112, 17);
            this.lblBank.TabIndex = 31;
            this.lblBank.Text = "Select a Bank";
            // 
            // ddlBank
            // 
            this.ddlBank.FormattingEnabled = true;
            this.ddlBank.Location = new System.Drawing.Point(366, 44);
            this.ddlBank.Name = "ddlBank";
            this.ddlBank.Size = new System.Drawing.Size(213, 21);
            this.ddlBank.TabIndex = 32;
            this.ddlBank.SelectedIndexChanged += new System.EventHandler(this.ddlBank_SelectedIndexChanged);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(655, 81);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 13);
            this.lblBalance.TabIndex = 59;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(588, 81);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(60, 13);
            this.lblAvailable.TabIndex = 58;
            this.lblAvailable.Text = "Avail. Bal : ";
            // 
            // frmEnterAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(721, 462);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.ddlBank);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.lblGoBack);
            this.Controls.Add(this.imgClear);
            this.Controls.Add(this.imgOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEnterAmount";
            this.Text = "Enter Amount";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEnterAmount_FormClosing);
            this.Load += new System.EventHandler(this.frmEnterAmount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox imgOK;
        private System.Windows.Forms.PictureBox imgClear;
        private System.Windows.Forms.Label lblGoBack;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.ComboBox ddlBank;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblAvailable;
    }
}