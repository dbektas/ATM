namespace ATM_Final
{
    partial class AccountInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountInfoForm));
            this.lbl_FirstAndLastName = new System.Windows.Forms.Label();
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.lbl_FLName = new System.Windows.Forms.Label();
            this.lbl_CurrentBalance = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_enflag = new System.Windows.Forms.Button();
            this.btn_bsflag = new System.Windows.Forms.Button();
            this.en_flag = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.en_flag)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_FirstAndLastName
            // 
            this.lbl_FirstAndLastName.AutoSize = true;
            this.lbl_FirstAndLastName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FirstAndLastName.Location = new System.Drawing.Point(12, 54);
            this.lbl_FirstAndLastName.Name = "lbl_FirstAndLastName";
            this.lbl_FirstAndLastName.Size = new System.Drawing.Size(179, 21);
            this.lbl_FirstAndLastName.TabIndex = 0;
            this.lbl_FirstAndLastName.Text = "First and Last Name: ";
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Balance.Location = new System.Drawing.Point(12, 160);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(191, 21);
            this.lbl_Balance.TabIndex = 1;
            this.lbl_Balance.Text = "Your Current Balance: ";
            // 
            // lbl_FLName
            // 
            this.lbl_FLName.AutoSize = true;
            this.lbl_FLName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FLName.Location = new System.Drawing.Point(197, 54);
            this.lbl_FLName.Name = "lbl_FLName";
            this.lbl_FLName.Size = new System.Drawing.Size(0, 21);
            this.lbl_FLName.TabIndex = 2;
            // 
            // lbl_CurrentBalance
            // 
            this.lbl_CurrentBalance.AutoSize = true;
            this.lbl_CurrentBalance.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentBalance.Location = new System.Drawing.Point(209, 160);
            this.lbl_CurrentBalance.Name = "lbl_CurrentBalance";
            this.lbl_CurrentBalance.Size = new System.Drawing.Size(0, 21);
            this.lbl_CurrentBalance.TabIndex = 3;
            // 
            // btn_Back
            // 
            this.btn_Back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Back.Location = new System.Drawing.Point(42, 246);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(104, 23);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Exit.Location = new System.Drawing.Point(246, 246);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(101, 23);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_enflag
            // 
            this.btn_enflag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_enflag.BackgroundImage")));
            this.btn_enflag.Location = new System.Drawing.Point(353, 24);
            this.btn_enflag.Name = "btn_enflag";
            this.btn_enflag.Size = new System.Drawing.Size(75, 36);
            this.btn_enflag.TabIndex = 10;
            this.btn_enflag.UseVisualStyleBackColor = true;
            this.btn_enflag.Click += new System.EventHandler(this.btn_enflag_Click);
            // 
            // btn_bsflag
            // 
            this.btn_bsflag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_bsflag.BackgroundImage")));
            this.btn_bsflag.Location = new System.Drawing.Point(434, 24);
            this.btn_bsflag.Name = "btn_bsflag";
            this.btn_bsflag.Size = new System.Drawing.Size(75, 36);
            this.btn_bsflag.TabIndex = 11;
            this.btn_bsflag.UseVisualStyleBackColor = true;
            this.btn_bsflag.Click += new System.EventHandler(this.btn_bsflag_Click);
            // 
            // en_flag
            // 
            this.en_flag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("en_flag.BackgroundImage")));
            this.en_flag.InitialImage = ((System.Drawing.Image)(resources.GetObject("en_flag.InitialImage")));
            this.en_flag.Location = new System.Drawing.Point(384, 293);
            this.en_flag.Name = "en_flag";
            this.en_flag.Size = new System.Drawing.Size(125, 65);
            this.en_flag.TabIndex = 12;
            this.en_flag.TabStop = false;
            // 
            // AccountInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(524, 387);
            this.Controls.Add(this.en_flag);
            this.Controls.Add(this.btn_bsflag);
            this.Controls.Add(this.btn_enflag);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_CurrentBalance);
            this.Controls.Add(this.lbl_FLName);
            this.Controls.Add(this.lbl_Balance);
            this.Controls.Add(this.lbl_FirstAndLastName);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountInfoForm";
            this.Load += new System.EventHandler(this.AccountInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.en_flag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_FirstAndLastName;
        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.Label lbl_FLName;
        private System.Windows.Forms.Label lbl_CurrentBalance;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_enflag;
        private System.Windows.Forms.Button btn_bsflag;
        private System.Windows.Forms.PictureBox en_flag;
    }
}