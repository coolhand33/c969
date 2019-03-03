namespace ScheduleIt
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginPasswdLabel = new System.Windows.Forms.Label();
            this.loginPasswdText = new System.Windows.Forms.TextBox();
            this.loginUsernameLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginUsernameText = new System.Windows.Forms.TextBox();
            this.loginError = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.loginError);
            this.loginPanel.Controls.Add(this.loginPasswdLabel);
            this.loginPanel.Controls.Add(this.loginPasswdText);
            this.loginPanel.Controls.Add(this.loginUsernameLabel);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.loginUsernameText);
            resources.ApplyResources(this.loginPanel, "loginPanel");
            this.loginPanel.Name = "loginPanel";
            // 
            // loginPasswdLabel
            // 
            resources.ApplyResources(this.loginPasswdLabel, "loginPasswdLabel");
            this.loginPasswdLabel.Name = "loginPasswdLabel";
            // 
            // loginPasswdText
            // 
            resources.ApplyResources(this.loginPasswdText, "loginPasswdText");
            this.loginPasswdText.Name = "loginPasswdText";
            // 
            // loginUsernameLabel
            // 
            resources.ApplyResources(this.loginUsernameLabel, "loginUsernameLabel");
            this.loginUsernameLabel.Name = "loginUsernameLabel";
            // 
            // loginButton
            // 
            resources.ApplyResources(this.loginButton, "loginButton");
            this.loginButton.Name = "loginButton";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginUsernameText
            // 
            resources.ApplyResources(this.loginUsernameText, "loginUsernameText");
            this.loginUsernameText.Name = "loginUsernameText";
            // 
            // loginError
            // 
            this.loginError.BackColor = System.Drawing.Color.MistyRose;
            this.loginError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.loginError, "loginError");
            this.loginError.ForeColor = System.Drawing.Color.DarkRed;
            this.loginError.Name = "loginError";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loginPanel);
            this.Name = "Login";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label loginUsernameLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox loginUsernameText;
        private System.Windows.Forms.Label loginPasswdLabel;
        private System.Windows.Forms.TextBox loginPasswdText;
        private System.Windows.Forms.Label loginError;
    }
}

