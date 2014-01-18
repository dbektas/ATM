namespace ATM_Final
{
    partial class WithdrawForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WithdrawForm));
            this.lbl_Please = new System.Windows.Forms.Label();
            this.txt_Withdraw = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_enflag = new System.Windows.Forms.Button();
            this.btn_bsflag = new System.Windows.Forms.Button();
            this.en_flag = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.en_flag)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Please
            // 
            this.lbl_Please.AutoSize = true;
            this.lbl_Please.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Please.Location = new System.Drawing.Point(3, 93);
            this.lbl_Please.Name = "lbl_Please";
            this.lbl_Please.Size = new System.Drawing.Size(522, 21);
            this.lbl_Please.TabIndex = 0;
            this.lbl_Please.Text = "PLEASE, ENTER THE AMOUNT YOU WANT TO WITDRAW";
            // 
            // txt_Withdraw
            // 
            this.txt_Withdraw.Location = new System.Drawing.Point(27, 166);
            this.txt_Withdraw.Name = "txt_Withdraw";
            this.txt_Withdraw.Size = new System.Drawing.Size(289, 20);
            this.txt_Withdraw.TabIndex = 1;
            // 
            // btn_Back
            // 
            this.btn_Back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Back.Location = new System.Drawing.Point(27, 265);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Confirm.Location = new System.Drawing.Point(132, 265);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 3;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Exit.Location = new System.Drawing.Point(241, 265);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_enflag
            // 
            this.btn_enflag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_enflag.BackgroundImage")));
            this.btn_enflag.Location = new System.Drawing.Point(351, 23);
            this.btn_enflag.Name = "btn_enflag";
            this.btn_enflag.Size = new System.Drawing.Size(75, 36);
            this.btn_enflag.TabIndex = 9;
            this.btn_enflag.UseVisualStyleBackColor = true;
            this.btn_enflag.Click += new System.EventHandler(this.btn_enflag_Click);
            // 
            // btn_bsflag
            // 
            this.btn_bsflag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_bsflag.BackgroundImage")));
            this.btn_bsflag.Location = new System.Drawing.Point(432, 23);
            this.btn_bsflag.Name = "btn_bsflag";
            this.btn_bsflag.Size = new System.Drawing.Size(75, 36);
            this.btn_bsflag.TabIndex = 10;
            this.btn_bsflag.UseVisualStyleBackColor = true;
            this.btn_bsflag.Click += new System.EventHandler(this.btn_bsflag_Click);
            // 
            // en_flag
            // 
            this.en_flag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("en_flag.BackgroundImage")));
            this.en_flag.InitialImage = ((System.Drawing.Image)(resources.GetObject("en_flag.InitialImage")));
            this.en_flag.Location = new System.Drawing.Point(382, 297);
            this.en_flag.Name = "en_flag";
            this.en_flag.Size = new System.Drawing.Size(125, 65);
            this.en_flag.TabIndex = 11;
            this.en_flag.TabStop = false;
            // 
            // WithdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(524, 387);
            this.Controls.Add(this.en_flag);
            this.Controls.Add(this.btn_bsflag);
            this.Controls.Add(this.btn_enflag);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.txt_Withdraw);
            this.Controls.Add(this.lbl_Please);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WithdrawForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WithdrawForm";
            this.Load += new System.EventHandler(this.WithdrawForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.en_flag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Please;
        private System.Windows.Forms.TextBox txt_Withdraw;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_enflag;
        private System.Windows.Forms.Button btn_bsflag;
        private System.Windows.Forms.PictureBox en_flag;
    }
}