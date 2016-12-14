namespace AgileDevelopmentToolsSuite
{
    partial class EditGroupProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGroupProfileForm));
            this.saveButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.groupNameHeaderLabel = new System.Windows.Forms.Label();
            this.groupProfilePictureLinkLabel = new System.Windows.Forms.Label();
            this.groupGoalLabel = new System.Windows.Forms.Label();
            this.groupGoalTextBox = new System.Windows.Forms.RichTextBox();
            this.groupNameBox = new System.Windows.Forms.TextBox();
            this.groupProfilePictureLinkBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DarkGray;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(531, 25);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 25);
            this.saveButton.TabIndex = 44;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.DarkGray;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Location = new System.Drawing.Point(655, 25);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(117, 25);
            this.menuButton.TabIndex = 45;
            this.menuButton.Text = "Back To Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.profilePictureBox.Location = new System.Drawing.Point(25, 25);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(100, 100);
            this.profilePictureBox.TabIndex = 46;
            this.profilePictureBox.TabStop = false;
            // 
            // groupNameHeaderLabel
            // 
            this.groupNameHeaderLabel.AutoSize = true;
            this.groupNameHeaderLabel.BackColor = System.Drawing.Color.Transparent;
            this.groupNameHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNameHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.groupNameHeaderLabel.Location = new System.Drawing.Point(131, 25);
            this.groupNameHeaderLabel.Name = "groupNameHeaderLabel";
            this.groupNameHeaderLabel.Size = new System.Drawing.Size(150, 25);
            this.groupNameHeaderLabel.TabIndex = 47;
            this.groupNameHeaderLabel.Text = "Group Name:";
            // 
            // groupProfilePictureLinkLabel
            // 
            this.groupProfilePictureLinkLabel.AutoSize = true;
            this.groupProfilePictureLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.groupProfilePictureLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupProfilePictureLinkLabel.ForeColor = System.Drawing.Color.White;
            this.groupProfilePictureLinkLabel.Location = new System.Drawing.Point(131, 64);
            this.groupProfilePictureLinkLabel.Name = "groupProfilePictureLinkLabel";
            this.groupProfilePictureLinkLabel.Size = new System.Drawing.Size(205, 25);
            this.groupProfilePictureLinkLabel.TabIndex = 48;
            this.groupProfilePictureLinkLabel.Text = "ProfilePictureLink:";
            // 
            // groupGoalLabel
            // 
            this.groupGoalLabel.AutoSize = true;
            this.groupGoalLabel.BackColor = System.Drawing.Color.Transparent;
            this.groupGoalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupGoalLabel.ForeColor = System.Drawing.Color.White;
            this.groupGoalLabel.Location = new System.Drawing.Point(24, 138);
            this.groupGoalLabel.Name = "groupGoalLabel";
            this.groupGoalLabel.Size = new System.Drawing.Size(139, 25);
            this.groupGoalLabel.TabIndex = 49;
            this.groupGoalLabel.Text = "Group Goal:";
            // 
            // groupGoalTextBox
            // 
            this.groupGoalTextBox.BackColor = System.Drawing.Color.YellowGreen;
            this.groupGoalTextBox.Location = new System.Drawing.Point(25, 166);
            this.groupGoalTextBox.Name = "groupGoalTextBox";
            this.groupGoalTextBox.Size = new System.Drawing.Size(747, 383);
            this.groupGoalTextBox.TabIndex = 50;
            this.groupGoalTextBox.Text = "";
            // 
            // groupNameBox
            // 
            this.groupNameBox.Location = new System.Drawing.Point(287, 30);
            this.groupNameBox.MaxLength = 32;
            this.groupNameBox.Name = "groupNameBox";
            this.groupNameBox.Size = new System.Drawing.Size(154, 20);
            this.groupNameBox.TabIndex = 51;
            // 
            // groupProfilePictureLinkBox
            // 
            this.groupProfilePictureLinkBox.Location = new System.Drawing.Point(136, 92);
            this.groupProfilePictureLinkBox.MaxLength = 32;
            this.groupProfilePictureLinkBox.Name = "groupProfilePictureLinkBox";
            this.groupProfilePictureLinkBox.Size = new System.Drawing.Size(305, 20);
            this.groupProfilePictureLinkBox.TabIndex = 52;
            // 
            // EditGroupProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupProfilePictureLinkBox);
            this.Controls.Add(this.groupNameBox);
            this.Controls.Add(this.groupGoalTextBox);
            this.Controls.Add(this.groupGoalLabel);
            this.Controls.Add(this.groupProfilePictureLinkLabel);
            this.Controls.Add(this.groupNameHeaderLabel);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.saveButton);
            this.Name = "EditGroupProfileForm";
            this.Text = "Agile Development Tools Suite";
            this.Load += new System.EventHandler(this.EditGroupProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label groupNameHeaderLabel;
        private System.Windows.Forms.Label groupProfilePictureLinkLabel;
        private System.Windows.Forms.Label groupGoalLabel;
        private System.Windows.Forms.RichTextBox groupGoalTextBox;
        private System.Windows.Forms.TextBox groupNameBox;
        private System.Windows.Forms.TextBox groupProfilePictureLinkBox;
    }
}