namespace AgileDevelopmentToolsSuite
{
    partial class DeveloperForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeveloperForm));
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.profileLinkLabel = new System.Windows.Forms.Label();
            this.profileLinkBox = new System.Windows.Forms.TextBox();
            this.yesProfileButton = new System.Windows.Forms.RadioButton();
            this.noProfileButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(464, 258);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameBox.MaxLength = 10;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(163, 22);
            this.usernameBox.TabIndex = 10;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(328, 258);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(117, 25);
            this.usernameLabel.TabIndex = 11;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(464, 311);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordBox.MaxLength = 10;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(163, 22);
            this.passwordBox.TabIndex = 12;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(335, 311);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(113, 25);
            this.passwordLabel.TabIndex = 13;
            this.passwordLabel.Text = "Password:";
            // 
            // profileLinkLabel
            // 
            this.profileLinkLabel.AutoSize = true;
            this.profileLinkLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.profileLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLinkLabel.ForeColor = System.Drawing.Color.White;
            this.profileLinkLabel.Location = new System.Drawing.Point(319, 422);
            this.profileLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.profileLinkLabel.Name = "profileLinkLabel";
            this.profileLinkLabel.Size = new System.Drawing.Size(126, 25);
            this.profileLinkLabel.TabIndex = 14;
            this.profileLinkLabel.Text = "Profile Link:";
            this.profileLinkLabel.Visible = false;
            // 
            // profileLinkBox
            // 
            this.profileLinkBox.Location = new System.Drawing.Point(464, 422);
            this.profileLinkBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profileLinkBox.MaxLength = 40;
            this.profileLinkBox.Name = "profileLinkBox";
            this.profileLinkBox.Size = new System.Drawing.Size(163, 22);
            this.profileLinkBox.TabIndex = 15;
            this.profileLinkBox.Visible = false;
            // 
            // yesProfileButton
            // 
            this.yesProfileButton.AutoSize = true;
            this.yesProfileButton.Location = new System.Drawing.Point(511, 372);
            this.yesProfileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yesProfileButton.Name = "yesProfileButton";
            this.yesProfileButton.Size = new System.Drawing.Size(53, 21);
            this.yesProfileButton.TabIndex = 16;
            this.yesProfileButton.TabStop = true;
            this.yesProfileButton.Text = "Yes";
            this.yesProfileButton.UseVisualStyleBackColor = true;
            this.yesProfileButton.CheckedChanged += new System.EventHandler(this.yesProfileButton_CheckedChanged);
            // 
            // noProfileButton
            // 
            this.noProfileButton.AutoSize = true;
            this.noProfileButton.Location = new System.Drawing.Point(576, 372);
            this.noProfileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.noProfileButton.Name = "noProfileButton";
            this.noProfileButton.Size = new System.Drawing.Size(47, 21);
            this.noProfileButton.TabIndex = 17;
            this.noProfileButton.TabStop = true;
            this.noProfileButton.Text = "No";
            this.noProfileButton.UseVisualStyleBackColor = true;
            this.noProfileButton.CheckedChanged += new System.EventHandler(this.noProfileButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(287, 372);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Have a profile link?";
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.Gray;
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.ForeColor = System.Drawing.Color.White;
            this.continueButton.Location = new System.Drawing.Point(476, 468);
            this.continueButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(125, 37);
            this.continueButton.TabIndex = 19;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox1.Location = new System.Drawing.Point(279, 215);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 309);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // DeveloperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noProfileButton);
            this.Controls.Add(this.yesProfileButton);
            this.Controls.Add(this.profileLinkBox);
            this.Controls.Add(this.profileLinkLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DeveloperForm";
            this.Text = "Agile Development Tools Suite";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeveloperForm_FormClosing);
            this.Load += new System.EventHandler(this.DeveloperForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label profileLinkLabel;
        private System.Windows.Forms.TextBox profileLinkBox;
        private System.Windows.Forms.RadioButton yesProfileButton;
        private System.Windows.Forms.RadioButton noProfileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}