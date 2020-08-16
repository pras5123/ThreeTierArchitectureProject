namespace ATMApp
{
    partial class frmCompleted
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imgYes = new System.Windows.Forms.PictureBox();
            this.imgNo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(777, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Your Transaction has been completed successfully";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(523, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Would you like to make another transaction ?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(807, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Yes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(802, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "No";
            // 
            // imgYes
            // 
            this.imgYes.BackgroundImage = global::ATMApp.Properties.Resources.yesbutton;
            this.imgYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgYes.Location = new System.Drawing.Point(865, 206);
            this.imgYes.Name = "imgYes";
            this.imgYes.Size = new System.Drawing.Size(98, 90);
            this.imgYes.TabIndex = 18;
            this.imgYes.TabStop = false;
            this.imgYes.Click += new System.EventHandler(this.imgYes_Click);
            // 
            // imgNo
            // 
            this.imgNo.BackgroundImage = global::ATMApp.Properties.Resources.nobutton;
            this.imgNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgNo.Location = new System.Drawing.Point(865, 309);
            this.imgNo.Name = "imgNo";
            this.imgNo.Size = new System.Drawing.Size(98, 90);
            this.imgNo.TabIndex = 19;
            this.imgNo.TabStop = false;
            this.imgNo.Click += new System.EventHandler(this.imgNo_Click);
            // 
            // frmCompleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(998, 411);
            this.Controls.Add(this.imgNo);
            this.Controls.Add(this.imgYes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCompleted";
            this.Text = "Transaction Completed Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCompleted_FormClosing);
            this.Load += new System.EventHandler(this.frmCompleted_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox imgYes;
        private System.Windows.Forms.PictureBox imgNo;
    }
}