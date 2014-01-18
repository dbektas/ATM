namespace ATM_Final
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.btn_QuickMoney = new System.Windows.Forms.Button();
            this.btn_Withdraw = new System.Windows.Forms.Button();
            this.btn_AccountInfo = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_ChangePIN = new System.Windows.Forms.Button();
            this.btn_enflag = new System.Windows.Forms.Button();
            this.btn_bsflag = new System.Windows.Forms.Button();
            this.en_flag = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.en_flag)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_QuickMoney
            // 
            this.btn_QuickMoney.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_QuickMoney.Location = new System.Drawing.Point(35, 36);
            this.btn_QuickMoney.Name = "btn_QuickMoney";
            this.btn_QuickMoney.Size = new System.Drawing.Size(183, 49);
            this.btn_QuickMoney.TabIndex = 0;
            this.btn_QuickMoney.Text = "Quick Money";
            this.btn_QuickMoney.UseVisualStyleBackColor = true;
            this.btn_QuickMoney.Click += new System.EventHandler(this.btn_QuickMoney_Click);
            // 
            // btn_Withdraw
            // 
            this.btn_Withdraw.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Withdraw.Location = new System.Drawing.Point(35, 109);
            this.btn_Withdraw.Name = "btn_Withdraw";
            this.btn_Withdraw.Size = new System.Drawing.Size(183, 46);
            this.btn_Withdraw.TabIndex = 1;
            this.btn_Withdraw.Text = "Withdraw";
            this.btn_Withdraw.UseVisualStyleBackColor = true;
            this.btn_Withdraw.Click += new System.EventHandler(this.btn_Withdraw_Click);
            // 
            // btn_AccountInfo
            // 
            this.btn_AccountInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AccountInfo.Location = new System.Drawing.Point(35, 186);
            this.btn_AccountInfo.Name = "btn_AccountInfo";
            this.btn_AccountInfo.Size = new System.Drawing.Size(183, 41);
            this.btn_AccountInfo.TabIndex = 2;
            this.btn_AccountInfo.Text = "Account Info";
            this.btn_AccountInfo.UseVisualStyleBackColor = true;
            this.btn_AccountInfo.Click += new System.EventHandler(this.btn_AccountInfo_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Exit.Location = new System.Drawing.Point(235, 312);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(83, 30);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_ChangePIN
            // 
            this.btn_ChangePIN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ChangePIN.Location = new System.Drawing.Point(35, 258);
            this.btn_ChangePIN.Name = "btn_ChangePIN";
            this.btn_ChangePIN.Size = new System.Drawing.Size(183, 46);
            this.btn_ChangePIN.TabIndex = 5;
            this.btn_ChangePIN.Text = "Change PIN";
            this.btn_ChangePIN.UseVisualStyleBackColor = true;
            this.btn_ChangePIN.Click += new System.EventHandler(this.btn_ChangePIN_Click);
            // 
            // btn_enflag
            // 
            this.btn_enflag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_enflag.BackgroundImage")));
            this.btn_enflag.Location = new System.Drawing.Point(350, 36);
            this.btn_enflag.Name = "btn_enflag";
            this.btn_enflag.Size = new System.Drawing.Size(75, 36);
            this.btn_enflag.TabIndex = 8;
            this.btn_enflag.UseVisualStyleBackColor = true;
            this.btn_enflag.Click += new System.EventHandler(this.btn_enflag_Click);
            // 
            // btn_bsflag
            // 
            this.btn_bsflag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_bsflag.BackgroundImage")));
            this.btn_bsflag.Location = new System.Drawing.Point(437, 36);
            this.btn_bsflag.Name = "btn_bsflag";
            this.btn_bsflag.Size = new System.Drawing.Size(75, 36);
            this.btn_bsflag.TabIndex = 9;
            this.btn_bsflag.UseVisualStyleBackColor = true;
            this.btn_bsflag.Click += new System.EventHandler(this.btn_bsflag_Click);
            // 
            // en_flag
            // 
            this.en_flag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("en_flag.BackgroundImage")));
            this.en_flag.InitialImage = ((System.Drawing.Image)(resources.GetObject("en_flag.InitialImage")));
            this.en_flag.Location = new System.Drawing.Point(387, 277);
            this.en_flag.Name = "en_flag";
            this.en_flag.Size = new System.Drawing.Size(125, 65);
            this.en_flag.TabIndex = 10;
            this.en_flag.TabStop = false;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(524, 387);
            this.Controls.Add(this.en_flag);
            this.Controls.Add(this.btn_bsflag);
            this.Controls.Add(this.btn_enflag);
            this.Controls.Add(this.btn_ChangePIN);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_AccountInfo);
            this.Controls.Add(this.btn_Withdraw);
            this.Controls.Add(this.btn_QuickMoney);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeForm";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.en_flag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_QuickMoney;
        private System.Windows.Forms.Button btn_Withdraw;
        private System.Windows.Forms.Button btn_AccountInfo;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_ChangePIN;
        private System.Windows.Forms.Button btn_enflag;
        private System.Windows.Forms.Button btn_bsflag;
        private System.Windows.Forms.PictureBox en_flag;
    }
}