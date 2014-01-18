namespace ATM_Final
{
    partial class ChangePINForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePINForm));
            this.lbl_OldPIN = new System.Windows.Forms.Label();
            this.lbl_NewPIN = new System.Windows.Forms.Label();
            this.txt_OldPIN = new System.Windows.Forms.TextBox();
            this.txt_NewPIN = new System.Windows.Forms.TextBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_enflag = new System.Windows.Forms.Button();
            this.btn_bsflag = new System.Windows.Forms.Button();
            this.en_flag = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.en_flag)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_OldPIN
            // 
            this.lbl_OldPIN.AutoSize = true;
            this.lbl_OldPIN.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OldPIN.Location = new System.Drawing.Point(61, 73);
            this.lbl_OldPIN.Name = "lbl_OldPIN";
            this.lbl_OldPIN.Size = new System.Drawing.Size(124, 21);
            this.lbl_OldPIN.TabIndex = 0;
            this.lbl_OldPIN.Text = "Enter Old PIN";
            // 
            // lbl_NewPIN
            // 
            this.lbl_NewPIN.AutoSize = true;
            this.lbl_NewPIN.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewPIN.Location = new System.Drawing.Point(61, 156);
            this.lbl_NewPIN.Name = "lbl_NewPIN";
            this.lbl_NewPIN.Size = new System.Drawing.Size(130, 21);
            this.lbl_NewPIN.TabIndex = 1;
            this.lbl_NewPIN.Text = "Enter New PIN";
            // 
            // txt_OldPIN
            // 
            this.txt_OldPIN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_OldPIN.Location = new System.Drawing.Point(220, 73);
            this.txt_OldPIN.Name = "txt_OldPIN";
            this.txt_OldPIN.Size = new System.Drawing.Size(128, 20);
            this.txt_OldPIN.TabIndex = 2;
            // 
            // txt_NewPIN
            // 
            this.txt_NewPIN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_NewPIN.Location = new System.Drawing.Point(220, 156);
            this.txt_NewPIN.Name = "txt_NewPIN";
            this.txt_NewPIN.Size = new System.Drawing.Size(128, 20);
            this.txt_NewPIN.TabIndex = 3;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Confirm.Location = new System.Drawing.Point(171, 281);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 4;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Back.Location = new System.Drawing.Point(44, 281);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Exit.Location = new System.Drawing.Point(291, 281);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_enflag
            // 
            this.btn_enflag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_enflag.BackgroundImage")));
            this.btn_enflag.Location = new System.Drawing.Point(356, 12);
            this.btn_enflag.Name = "btn_enflag";
            this.btn_enflag.Size = new System.Drawing.Size(75, 36);
            this.btn_enflag.TabIndex = 10;
            this.btn_enflag.UseVisualStyleBackColor = true;
            this.btn_enflag.Click += new System.EventHandler(this.btn_enflag_Click);
            // 
            // btn_bsflag
            // 
            this.btn_bsflag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_bsflag.BackgroundImage")));
            this.btn_bsflag.Location = new System.Drawing.Point(437, 12);
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
            this.en_flag.Location = new System.Drawing.Point(387, 297);
            this.en_flag.Name = "en_flag";
            this.en_flag.Size = new System.Drawing.Size(125, 65);
            this.en_flag.TabIndex = 12;
            this.en_flag.TabStop = false;
            // 
            // ChangePINForm
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
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.txt_NewPIN);
            this.Controls.Add(this.txt_OldPIN);
            this.Controls.Add(this.lbl_NewPIN);
            this.Controls.Add(this.lbl_OldPIN);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePINForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePINForm";
            this.Load += new System.EventHandler(this.ChangePINForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.en_flag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_OldPIN;
        private System.Windows.Forms.Label lbl_NewPIN;
        private System.Windows.Forms.TextBox txt_OldPIN;
        private System.Windows.Forms.TextBox txt_NewPIN;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_enflag;
        private System.Windows.Forms.Button btn_bsflag;
        private System.Windows.Forms.PictureBox en_flag;
    }
}