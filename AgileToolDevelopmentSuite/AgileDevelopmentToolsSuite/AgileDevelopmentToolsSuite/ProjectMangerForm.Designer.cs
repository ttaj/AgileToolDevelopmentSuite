namespace AgileDevelopmentToolsSuite
{
    partial class ProjectMangerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectMangerForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yesProfileButton = new System.Windows.Forms.RadioButton();
            this.noProfileButton = new System.Windows.Forms.RadioButton();
            this.profileLinkBox = new System.Windows.Forms.TextBox();
            this.profileLinkLabel = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox1.Location = new System.Drawing.Point(209, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 251);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(348, 210);
            this.usernameBox.MaxLength = 10;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(123, 20);
            this.usernameBox.TabIndex = 11;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(246, 210);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(96, 20);
            this.usernameLabel.TabIndex = 12;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(348, 253);
            this.passwordBox.MaxLength = 10;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(123, 20);
            this.passwordBox.TabIndex = 13;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(251, 253);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(91, 20);
            this.passwordLabel.TabIndex = 14;
            this.passwordLabel.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(215, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Have a profile link?";
            // 
            // yesProfileButton
            // 
            this.yesProfileButton.AutoSize = true;
            this.yesProfileButton.Location = new System.Drawing.Point(383, 302);
            this.yesProfileButton.Name = "yesProfileButton";
            this.yesProfileButton.Size = new System.Drawing.Size(43, 17);
            this.yesProfileButton.TabIndex = 20;
            this.yesProfileButton.TabStop = true;
            this.yesProfileButton.Text = "Yes";
            this.yesProfileButton.UseVisualStyleBackColor = true;
            // 
            // noProfileButton
            // 
            this.noProfileButton.AutoSize = true;
            this.noProfileButton.Location = new System.Drawing.Point(432, 302);
            this.noProfileButton.Name = "noProfileButton";
            this.noProfileButton.Size = new System.Drawing.Size(39, 17);
            this.noProfileButton.TabIndex = 21;
            this.noProfileButton.TabStop = true;
            this.noProfileButton.Text = "No";
            this.noProfileButton.UseVisualStyleBackColor = true;
            // 
            // profileLinkBox
            // 
            this.profileLinkBox.Location = new System.Drawing.Point(348, 343);
            this.profileLinkBox.MaxLength = 40;
            this.profileLinkBox.Name = "profileLinkBox";
            this.profileLinkBox.Size = new System.Drawing.Size(123, 20);
            this.profileLinkBox.TabIndex = 22;
            this.profileLinkBox.Visible = false;
            // 
            // profileLinkLabel
            // 
            this.profileLinkLabel.AutoSize = true;
            this.profileLinkLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.profileLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLinkLabel.ForeColor = System.Drawing.Color.White;
            this.profileLinkLabel.Location = new System.Drawing.Point(239, 343);
            this.profileLinkLabel.Name = "profileLinkLabel";
            this.profileLinkLabel.Size = new System.Drawing.Size(103, 20);
            this.profileLinkLabel.TabIndex = 23;
            this.profileLinkLabel.Text = "Profile Link:";
            this.profileLinkLabel.Visible = false;
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.Gray;
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.ForeColor = System.Drawing.Color.White;
            this.continueButton.Location = new System.Drawing.Point(357, 380);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(94, 30);
            this.continueButton.TabIndex = 24;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // ProjectMangerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.profileLinkLabel);
            this.Controls.Add(this.profileLinkBox);
            this.Controls.Add(this.noProfileButton);
            this.Controls.Add(this.yesProfileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProjectMangerForm";
            this.Text = "Agile Development Tools Suite";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton yesProfileButton;
        private System.Windows.Forms.RadioButton noProfileButton;
        private System.Windows.Forms.TextBox profileLinkBox;
        private System.Windows.Forms.Label profileLinkLabel;
        private System.Windows.Forms.Button continueButton;
    }
}