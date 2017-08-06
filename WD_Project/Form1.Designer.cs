namespace WD_Project
{
    partial class Form1
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
            this.ActionStart = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.PathDisplay = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Browser = new System.Windows.Forms.Button();
            this.AuthStatus = new System.Windows.Forms.Label();
            this.AuthMe = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActionStart
            // 
            this.ActionStart.Enabled = false;
            this.ActionStart.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionStart.Location = new System.Drawing.Point(15, 361);
            this.ActionStart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ActionStart.Name = "ActionStart";
            this.ActionStart.Size = new System.Drawing.Size(953, 100);
            this.ActionStart.TabIndex = 0;
            this.ActionStart.Text = "Start!";
            this.ActionStart.UseVisualStyleBackColor = true;
            this.ActionStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.AuthMe);
            this.groupBox.Controls.Add(this.AuthStatus);
            this.groupBox.Controls.Add(this.Browser);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.Password);
            this.groupBox.Controls.Add(this.Email);
            this.groupBox.Controls.Add(this.PathDisplay);
            this.groupBox.Location = new System.Drawing.Point(15, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(956, 340);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            // 
            // PathDisplay
            // 
            this.PathDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathDisplay.Location = new System.Drawing.Point(167, 31);
            this.PathDisplay.Name = "PathDisplay";
            this.PathDisplay.ReadOnly = true;
            this.PathDisplay.Size = new System.Drawing.Size(332, 32);
            this.PathDisplay.TabIndex = 0;
            this.PathDisplay.Text = "C:\\\\";
            // 
            // Email
            // 
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email.Location = new System.Drawing.Point(726, 31);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(224, 32);
            this.Email.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Location = new System.Drawing.Point(726, 84);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(224, 32);
            this.Password.TabIndex = 2;
            this.Password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Path to Watch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "E-Mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password :";
            // 
            // Browser
            // 
            this.Browser.Location = new System.Drawing.Point(11, 84);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(93, 37);
            this.Browser.TabIndex = 6;
            this.Browser.Text = "Browse";
            this.Browser.UseVisualStyleBackColor = true;
            this.Browser.Click += new System.EventHandler(this.Browser_Click);
            // 
            // AuthStatus
            // 
            this.AuthStatus.AutoSize = true;
            this.AuthStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.AuthStatus.Location = new System.Drawing.Point(578, 209);
            this.AuthStatus.Name = "AuthStatus";
            this.AuthStatus.Size = new System.Drawing.Size(253, 27);
            this.AuthStatus.TabIndex = 7;
            this.AuthStatus.Text = "Authentication required.";
            // 
            // AuthMe
            // 
            this.AuthMe.Location = new System.Drawing.Point(673, 144);
            this.AuthMe.Name = "AuthMe";
            this.AuthMe.Size = new System.Drawing.Size(93, 37);
            this.AuthMe.TabIndex = 8;
            this.AuthMe.Text = "Submit";
            this.AuthMe.UseVisualStyleBackColor = true;
            this.AuthMe.Click += new System.EventHandler(this.AuthMe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 476);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.ActionStart);
            this.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ActionStart;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button AuthMe;
        private System.Windows.Forms.Label AuthStatus;
        private System.Windows.Forms.Button Browser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox PathDisplay;
    }
}

