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
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginPasswdLabel = new System.Windows.Forms.Label();
            this.loginPasswdText = new System.Windows.Forms.TextBox();
            this.loginUsernameLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginUsernameText = new System.Windows.Forms.TextBox();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.loginPasswdLabel);
            this.loginPanel.Controls.Add(this.loginPasswdText);
            this.loginPanel.Controls.Add(this.loginUsernameLabel);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.loginUsernameText);
            this.loginPanel.Location = new System.Drawing.Point(12, 12);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(210, 284);
            this.loginPanel.TabIndex = 0;
            // 
            // loginPasswdLabel
            // 
            this.loginPasswdLabel.AutoSize = true;
            this.loginPasswdLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPasswdLabel.Location = new System.Drawing.Point(1, 156);
            this.loginPasswdLabel.Name = "loginPasswdLabel";
            this.loginPasswdLabel.Size = new System.Drawing.Size(76, 19);
            this.loginPasswdLabel.TabIndex = 4;
            this.loginPasswdLabel.Text = "Password";
            // 
            // loginPasswdText
            // 
            this.loginPasswdText.Location = new System.Drawing.Point(5, 178);
            this.loginPasswdText.Name = "loginPasswdText";
            this.loginPasswdText.Size = new System.Drawing.Size(200, 20);
            this.loginPasswdText.TabIndex = 3;
            // 
            // loginUsernameLabel
            // 
            this.loginUsernameLabel.AutoSize = true;
            this.loginUsernameLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUsernameLabel.Location = new System.Drawing.Point(1, 54);
            this.loginUsernameLabel.Name = "loginUsernameLabel";
            this.loginUsernameLabel.Size = new System.Drawing.Size(80, 19);
            this.loginUsernameLabel.TabIndex = 2;
            this.loginUsernameLabel.Text = "Username";
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginButton.Location = new System.Drawing.Point(0, 240);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(210, 44);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginUsernameText
            // 
            this.loginUsernameText.Location = new System.Drawing.Point(5, 76);
            this.loginUsernameText.Name = "loginUsernameText";
            this.loginUsernameText.Size = new System.Drawing.Size(200, 20);
            this.loginUsernameText.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 308);
            this.Controls.Add(this.loginPanel);
            this.Name = "Login";
            this.Text = "Form1";
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
    }
}

