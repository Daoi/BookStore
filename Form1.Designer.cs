namespace BookStore
{
    partial class frmUserIdPrompt
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
            this.btnUserIDEntry = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.pnlPasswordScreen = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnPasswordEntry = new System.Windows.Forms.Button();
            this.lblPasswordText = new System.Windows.Forms.Label();
            this.pnlUserLogin = new System.Windows.Forms.Panel();
            this.lblUserID = new System.Windows.Forms.Label();
            this.pnlPasswordScreen.SuspendLayout();
            this.pnlUserLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUserIDEntry
            // 
            this.btnUserIDEntry.Location = new System.Drawing.Point(191, 136);
            this.btnUserIDEntry.Name = "btnUserIDEntry";
            this.btnUserIDEntry.Size = new System.Drawing.Size(75, 23);
            this.btnUserIDEntry.TabIndex = 0;
            this.btnUserIDEntry.Text = "Enter";
            this.btnUserIDEntry.UseVisualStyleBackColor = true;
            this.btnUserIDEntry.Click += new System.EventHandler(this.btnUserIDEntry_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(179, 110);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.TabIndex = 1;
            // 
            // pnlPasswordScreen
            // 
            this.pnlPasswordScreen.Controls.Add(this.lblPasswordText);
            this.pnlPasswordScreen.Controls.Add(this.btnPasswordEntry);
            this.pnlPasswordScreen.Controls.Add(this.txtPassword);
            this.pnlPasswordScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPasswordScreen.Enabled = false;
            this.pnlPasswordScreen.Location = new System.Drawing.Point(0, 0);
            this.pnlPasswordScreen.Name = "pnlPasswordScreen";
            this.pnlPasswordScreen.Size = new System.Drawing.Size(497, 257);
            this.pnlPasswordScreen.TabIndex = 2;
            this.pnlPasswordScreen.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(179, 139);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 0;
            // 
            // btnPasswordEntry
            // 
            this.btnPasswordEntry.Location = new System.Drawing.Point(191, 165);
            this.btnPasswordEntry.Name = "btnPasswordEntry";
            this.btnPasswordEntry.Size = new System.Drawing.Size(75, 23);
            this.btnPasswordEntry.TabIndex = 1;
            this.btnPasswordEntry.Text = "Enter";
            this.btnPasswordEntry.UseVisualStyleBackColor = true;
            this.btnPasswordEntry.Click += new System.EventHandler(this.btnPasswordEntry_Click);
            // 
            // lblPasswordText
            // 
            this.lblPasswordText.AutoSize = true;
            this.lblPasswordText.Location = new System.Drawing.Point(158, 110);
            this.lblPasswordText.Name = "lblPasswordText";
            this.lblPasswordText.Size = new System.Drawing.Size(138, 13);
            this.lblPasswordText.TabIndex = 2;
            this.lblPasswordText.Text = "Please enter your 4 digit Pin";
            // 
            // pnlUserLogin
            // 
            this.pnlUserLogin.Controls.Add(this.lblUserID);
            this.pnlUserLogin.Controls.Add(this.btnUserIDEntry);
            this.pnlUserLogin.Controls.Add(this.txtUserID);
            this.pnlUserLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlUserLogin.Name = "pnlUserLogin";
            this.pnlUserLogin.Size = new System.Drawing.Size(497, 257);
            this.pnlUserLogin.TabIndex = 3;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(158, 84);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(162, 13);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "Please enter your 5 digit User ID.";
            // 
            // frmUserIdPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 257);
            this.Controls.Add(this.pnlUserLogin);
            this.Controls.Add(this.pnlPasswordScreen);
            this.Name = "frmUserIdPrompt";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmUserIdPrompt_Load);
            this.pnlPasswordScreen.ResumeLayout(false);
            this.pnlPasswordScreen.PerformLayout();
            this.pnlUserLogin.ResumeLayout(false);
            this.pnlUserLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserIDEntry;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Panel pnlPasswordScreen;
        private System.Windows.Forms.Label lblPasswordText;
        private System.Windows.Forms.Button btnPasswordEntry;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlUserLogin;
        private System.Windows.Forms.Label lblUserID;
    }
}

