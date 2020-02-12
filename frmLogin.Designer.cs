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
            this.lblPasswordText = new System.Windows.Forms.Label();
            this.btnPasswordEntry = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlUserLogin = new System.Windows.Forms.Panel();
            this.lblUserID = new System.Windows.Forms.Label();
            this.pnlPasswordScreen.SuspendLayout();
            this.pnlUserLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUserIDEntry
            // 
            this.btnUserIDEntry.Location = new System.Drawing.Point(255, 167);
            this.btnUserIDEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUserIDEntry.Name = "btnUserIDEntry";
            this.btnUserIDEntry.Size = new System.Drawing.Size(100, 28);
            this.btnUserIDEntry.TabIndex = 0;
            this.btnUserIDEntry.Text = "Enter";
            this.btnUserIDEntry.UseVisualStyleBackColor = true;
            this.btnUserIDEntry.Click += new System.EventHandler(this.btnUserIDEntry_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(239, 135);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(132, 22);
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
            this.pnlPasswordScreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPasswordScreen.Name = "pnlPasswordScreen";
            this.pnlPasswordScreen.Size = new System.Drawing.Size(663, 316);
            this.pnlPasswordScreen.TabIndex = 2;
            this.pnlPasswordScreen.Visible = false;
            // 
            // lblPasswordText
            // 
            this.lblPasswordText.AutoSize = true;
            this.lblPasswordText.Location = new System.Drawing.Point(211, 103);
            this.lblPasswordText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordText.Name = "lblPasswordText";
            this.lblPasswordText.Size = new System.Drawing.Size(186, 17);
            this.lblPasswordText.TabIndex = 2;
            this.lblPasswordText.Text = "Please enter your 4 digit Pin";
            // 
            // btnPasswordEntry
            // 
            this.btnPasswordEntry.Location = new System.Drawing.Point(255, 167);
            this.btnPasswordEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPasswordEntry.Name = "btnPasswordEntry";
            this.btnPasswordEntry.Size = new System.Drawing.Size(100, 28);
            this.btnPasswordEntry.TabIndex = 1;
            this.btnPasswordEntry.Text = "Enter";
            this.btnPasswordEntry.UseVisualStyleBackColor = true;
            this.btnPasswordEntry.Click += new System.EventHandler(this.btnPasswordEntry_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(239, 135);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(132, 22);
            this.txtPassword.TabIndex = 0;
            // 
            // pnlUserLogin
            // 
            this.pnlUserLogin.Controls.Add(this.lblUserID);
            this.pnlUserLogin.Controls.Add(this.btnUserIDEntry);
            this.pnlUserLogin.Controls.Add(this.txtUserID);
            this.pnlUserLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlUserLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlUserLogin.Name = "pnlUserLogin";
            this.pnlUserLogin.Size = new System.Drawing.Size(663, 316);
            this.pnlUserLogin.TabIndex = 3;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(211, 103);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(217, 17);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "Please enter your 5 digit User ID.";
            // 
            // frmUserIdPrompt
            // 
            this.AcceptButton = this.btnUserIDEntry;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 316);
            this.Controls.Add(this.pnlUserLogin);
            this.Controls.Add(this.pnlPasswordScreen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

