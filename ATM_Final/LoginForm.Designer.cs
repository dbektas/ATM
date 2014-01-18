namespace ATM_Final
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lbl_CardID = new System.Windows.Forms.Label();
            this.lbl_PIN = new System.Windows.Forms.Label();
            this.txt_CardID = new System.Windows.Forms.TextBox();
            this.txt_PIN = new System.Windows.Forms.TextBox();
            this.lbl_SelectLang = new System.Windows.Forms.Label();
            this.btn_enflag = new System.Windows.Forms.Button();
            this.btn_bsflag = new System.Windows.Forms.Button();
            this.en_flag = new System.Windows.Forms.PictureBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.en_flag)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CardID
            // 
            this.lbl_CardID.AutoSize = true;
            this.lbl_CardID.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CardID.Location = new System.Drawing.Point(27, 162);
            this.lbl_CardID.Name = "lbl_CardID";
            this.lbl_CardID.Size = new System.Drawing.Size(72, 21);
            this.lbl_CardID.TabIndex = 2;
            this.lbl_CardID.Text = "Card ID";
            // 
            // lbl_PIN
            // 
            this.lbl_PIN.AutoSize = true;
            this.lbl_PIN.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PIN.Location = new System.Drawing.Point(27, 240);
            this.lbl_PIN.Name = "lbl_PIN";
            this.lbl_PIN.Size = new System.Drawing.Size(43, 21);
            this.lbl_PIN.TabIndex = 3;
            this.lbl_PIN.Text = "PIN";
            // 
            // txt_CardID
            // 
            this.txt_CardID.Location = new System.Drawing.Point(129, 163);
            this.txt_CardID.Name = "txt_CardID";
            this.txt_CardID.Size = new System.Drawing.Size(197, 20);
            this.txt_CardID.TabIndex = 4;
            // 
            // txt_PIN
            // 
            this.txt_PIN.Location = new System.Drawing.Point(129, 243);
            this.txt_PIN.Name = "txt_PIN";
            this.txt_PIN.Size = new System.Drawing.Size(197, 20);
            this.txt_PIN.TabIndex = 5;
            // 
            // lbl_SelectLang
            // 
            this.lbl_SelectLang.AutoSize = true;
            this.lbl_SelectLang.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectLang.Location = new System.Drawing.Point(1, 37);
            this.lbl_SelectLang.Name = "lbl_SelectLang";
            this.lbl_SelectLang.Size = new System.Drawing.Size(325, 34);
            this.lbl_SelectLang.TabIndex = 6;
            this.lbl_SelectLang.Text = "Please select a language";
            // 
            // btn_enflag
            // 
            this.btn_enflag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_enflag.BackgroundImage")));
            this.btn_enflag.Location = new System.Drawing.Point(346, 35);
            this.btn_enflag.Name = "btn_enflag";
            this.btn_enflag.Size = new System.Drawing.Size(75, 36);
            this.btn_enflag.TabIndex = 7;
            this.btn_enflag.UseVisualStyleBackColor = true;
            this.btn_enflag.Click += new System.EventHandler(this.btn_enflag_Click);
            // 
            // btn_bsflag
            // 
            this.btn_bsflag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_bsflag.BackgroundImage")));
            this.btn_bsflag.Location = new System.Drawing.Point(437, 35);
            this.btn_bsflag.Name = "btn_bsflag";
            this.btn_bsflag.Size = new System.Drawing.Size(75, 36);
            this.btn_bsflag.TabIndex = 8;
            this.btn_bsflag.UseVisualStyleBackColor = true;
            this.btn_bsflag.Click += new System.EventHandler(this.btn_bsflag_Click);
            // 
            // en_flag
            // 
            this.en_flag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("en_flag.BackgroundImage")));
            this.en_flag.InitialImage = ((System.Drawing.Image)(resources.GetObject("en_flag.InitialImage")));
            this.en_flag.Location = new System.Drawing.Point(387, 275);
            this.en_flag.Name = "en_flag";
            this.en_flag.Size = new System.Drawing.Size(125, 65);
            this.en_flag.TabIndex = 9;
            this.en_flag.TabStop = false;
            // 
            // btn_Login
            // 
            this.btn_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Login.Location = new System.Drawing.Point(129, 317);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 10;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Exit.Location = new System.Drawing.Point(251, 317);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(524, 387);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.en_flag);
            this.Controls.Add(this.btn_bsflag);
            this.Controls.Add(this.btn_enflag);
            this.Controls.Add(this.lbl_SelectLang);
            this.Controls.Add(this.txt_PIN);
            this.Controls.Add(this.txt_CardID);
            this.Controls.Add(this.lbl_PIN);
            this.Controls.Add(this.lbl_CardID);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.en_flag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CardID;
        private System.Windows.Forms.Label lbl_PIN;
        private System.Windows.Forms.TextBox txt_CardID;
        private System.Windows.Forms.TextBox txt_PIN;
        private System.Windows.Forms.Label lbl_SelectLang;
        private System.Windows.Forms.Button btn_enflag;
        private System.Windows.Forms.Button btn_bsflag;
        private System.Windows.Forms.PictureBox en_flag;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Exit;
    }
}