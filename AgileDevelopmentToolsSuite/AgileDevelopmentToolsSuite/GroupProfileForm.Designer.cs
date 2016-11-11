namespace AgileDevelopmentToolsSuite
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.editProfileButton = new System.Windows.Forms.Button();
            this.groupContactLabel = new System.Windows.Forms.Label();
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.groupContactListView = new System.Windows.Forms.ListView();
            this.groupGoalLabel = new System.Windows.Forms.Label();
            this.groupGoalTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(25, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(131, 64);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(117, 25);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name List";
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nicknameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknameLabel.ForeColor = System.Drawing.Color.White;
            this.nicknameLabel.Location = new System.Drawing.Point(131, 100);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(188, 25);
            this.nicknameLabel.TabIndex = 2;
            this.nicknameLabel.Text = "(Nicknames List)";
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.DarkGray;
            this.menuButton.Location = new System.Drawing.Point(676, 25);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(96, 23);
            this.menuButton.TabIndex = 25;
            this.menuButton.Text = "Back To Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // editProfileButton
            // 
            this.editProfileButton.BackColor = System.Drawing.Color.DarkGray;
            this.editProfileButton.Location = new System.Drawing.Point(576, 25);
            this.editProfileButton.Name = "editProfileButton";
            this.editProfileButton.Size = new System.Drawing.Size(94, 23);
            this.editProfileButton.TabIndex = 26;
            this.editProfileButton.Text = "Edit Profile";
            this.editProfileButton.UseVisualStyleBackColor = false;
            this.editProfileButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupContactLabel
            // 
            this.groupContactLabel.AutoSize = true;
            this.groupContactLabel.BackColor = System.Drawing.Color.Transparent;
            this.groupContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupContactLabel.ForeColor = System.Drawing.Color.White;
            this.groupContactLabel.Location = new System.Drawing.Point(20, 348);
            this.groupContactLabel.Name = "groupContactLabel";
            this.groupContactLabel.Size = new System.Drawing.Size(295, 25);
            this.groupContactLabel.TabIndex = 30;
            this.groupContactLabel.Text = "Group Contact Information:";
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.groupNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNameLabel.ForeColor = System.Drawing.Color.White;
            this.groupNameLabel.Location = new System.Drawing.Point(131, 25);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(143, 25);
            this.groupNameLabel.TabIndex = 35;
            this.groupNameLabel.Text = "Group Name";
            // 
            // groupContactListView
            // 
            this.groupContactListView.Location = new System.Drawing.Point(25, 376);
            this.groupContactListView.Name = "groupContactListView";
            this.groupContactListView.Size = new System.Drawing.Size(747, 173);
            this.groupContactListView.TabIndex = 36;
            this.groupContactListView.UseCompatibleStateImageBehavior = false;
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
            this.groupGoalLabel.TabIndex = 37;
            this.groupGoalLabel.Text = "Group Goal:";
            // 
            // groupGoalTextBox
            // 
            this.groupGoalTextBox.Location = new System.Drawing.Point(25, 166);
            this.groupGoalTextBox.Name = "groupGoalTextBox";
            this.groupGoalTextBox.Size = new System.Drawing.Size(747, 168);
            this.groupGoalTextBox.TabIndex = 38;
            this.groupGoalTextBox.Text = "";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupGoalTextBox);
            this.Controls.Add(this.groupGoalLabel);
            this.Controls.Add(this.groupContactListView);
            this.Controls.Add(this.groupNameLabel);
            this.Controls.Add(this.groupContactLabel);
            this.Controls.Add(this.editProfileButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.nicknameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProfileForm";
            this.Text = "Agile Development Tools Suite";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button editProfileButton;
        private System.Windows.Forms.Label groupContactLabel;
        private System.Windows.Forms.Label groupNameLabel;
        private System.Windows.Forms.ListView groupContactListView;
        private System.Windows.Forms.Label groupGoalLabel;
        private System.Windows.Forms.RichTextBox groupGoalTextBox;
    }
}