namespace AgileDevelopmentToolsSuite
{
  partial class MainMenuForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
      this.menuGroupNameLabel = new System.Windows.Forms.Label();
      this.menuGroupNameTxt = new System.Windows.Forms.TextBox();
      this.menuSelfNameLabel = new System.Windows.Forms.Label();
      this.profileButton = new System.Windows.Forms.Button();
      this.chatButton = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.urgentTaskButton = new System.Windows.Forms.Button();
      this.listView1 = new System.Windows.Forms.ListView();
      this.toTaskFormButton = new System.Windows.Forms.Button();
      this.groupProfileButton = new System.Windows.Forms.Button();
      this.loggedInTextBox = new System.Windows.Forms.TextBox();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1SandBox = new System.Windows.Forms.TabPage();
      this.tabPage2TimeLine = new System.Windows.Forms.TabPage();
      this.tabControlLabel = new System.Windows.Forms.Label();
      this.createSuggestionButton = new System.Windows.Forms.Button();
      this.deleteSuggestionButton = new System.Windows.Forms.Button();
      this.suggestionTxtBox = new System.Windows.Forms.RichTextBox();
      this.listView2 = new System.Windows.Forms.ListView();
      this.sandBoxDescLabel = new System.Windows.Forms.Label();
      this.upvoteButton = new System.Windows.Forms.Button();
      this.sandBoxVoteLabel = new System.Windows.Forms.Label();
      this.downvoteButton = new System.Windows.Forms.Button();
      this.createSuggestionPanel = new System.Windows.Forms.Panel();
      this.cancelCreationButton = new System.Windows.Forms.Button();
      this.suggestionNameLabel = new System.Windows.Forms.Label();
      this.suggestionNameTextBox = new System.Windows.Forms.TextBox();
      this.suggestionDescLabel = new System.Windows.Forms.Label();
      this.createSuggestionDescTextBox = new System.Windows.Forms.RichTextBox();
      this.acceptSuggestionButton = new System.Windows.Forms.Button();
      this.createSuggestionLabel = new System.Windows.Forms.Label();
      this.confirmDeletePanel = new System.Windows.Forms.Panel();
      this.confirmationDeleteLabel = new System.Windows.Forms.Label();
      this.yesButton = new System.Windows.Forms.Button();
      this.noButton = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1SandBox.SuspendLayout();
      this.createSuggestionPanel.SuspendLayout();
      this.confirmDeletePanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuGroupNameLabel
      // 
      this.menuGroupNameLabel.AutoSize = true;
      this.menuGroupNameLabel.BackColor = System.Drawing.Color.Transparent;
      this.menuGroupNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.menuGroupNameLabel.ForeColor = System.Drawing.Color.White;
      this.menuGroupNameLabel.Location = new System.Drawing.Point(12, 9);
      this.menuGroupNameLabel.Name = "menuGroupNameLabel";
      this.menuGroupNameLabel.Size = new System.Drawing.Size(113, 19);
      this.menuGroupNameLabel.TabIndex = 0;
      this.menuGroupNameLabel.Text = "Group Profile:";
      // 
      // menuGroupNameTxt
      // 
      this.menuGroupNameTxt.BackColor = System.Drawing.SystemColors.ScrollBar;
      this.menuGroupNameTxt.Cursor = System.Windows.Forms.Cursors.Hand;
      this.menuGroupNameTxt.Location = new System.Drawing.Point(143, 7);
      this.menuGroupNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.menuGroupNameTxt.Name = "menuGroupNameTxt";
      this.menuGroupNameTxt.ReadOnly = true;
      this.menuGroupNameTxt.Size = new System.Drawing.Size(307, 22);
      this.menuGroupNameTxt.TabIndex = 1;
      this.menuGroupNameTxt.TextChanged += new System.EventHandler(this.menuGroupNameTxt_TextChanged);
      // 
      // menuSelfNameLabel
      // 
      this.menuSelfNameLabel.AutoSize = true;
      this.menuSelfNameLabel.BackColor = System.Drawing.Color.Transparent;
      this.menuSelfNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.menuSelfNameLabel.ForeColor = System.Drawing.Color.White;
      this.menuSelfNameLabel.Location = new System.Drawing.Point(673, 9);
      this.menuSelfNameLabel.Name = "menuSelfNameLabel";
      this.menuSelfNameLabel.Size = new System.Drawing.Size(108, 19);
      this.menuSelfNameLabel.TabIndex = 2;
      this.menuSelfNameLabel.Text = "Logged in as:";
      // 
      // profileButton
      // 
      this.profileButton.BackColor = System.Drawing.Color.DarkGray;
      this.profileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.profileButton.ForeColor = System.Drawing.Color.White;
      this.profileButton.Location = new System.Drawing.Point(844, 38);
      this.profileButton.Margin = new System.Windows.Forms.Padding(4);
      this.profileButton.Name = "profileButton";
      this.profileButton.Size = new System.Drawing.Size(149, 28);
      this.profileButton.TabIndex = 5;
      this.profileButton.Text = "View Profile";
      this.profileButton.UseVisualStyleBackColor = false;
      this.profileButton.Click += new System.EventHandler(this.button1_Click);
      // 
      // chatButton
      // 
      this.chatButton.BackColor = System.Drawing.Color.DarkGray;
      this.chatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chatButton.ForeColor = System.Drawing.Color.White;
      this.chatButton.Location = new System.Drawing.Point(16, 640);
      this.chatButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.chatButton.Name = "chatButton";
      this.chatButton.Size = new System.Drawing.Size(289, 38);
      this.chatButton.TabIndex = 6;
      this.chatButton.Text = "Chat";
      this.chatButton.UseVisualStyleBackColor = false;
      this.chatButton.Click += new System.EventHandler(this.button2_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.button3);
      this.panel1.Controls.Add(this.button2);
      this.panel1.Location = new System.Drawing.Point(311, 640);
      this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(339, 38);
      this.panel1.TabIndex = 7;
      this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.Color.DarkGray;
      this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button3.ForeColor = System.Drawing.Color.White;
      this.button3.Location = new System.Drawing.Point(163, 2);
      this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(173, 32);
      this.button3.TabIndex = 1;
      this.button3.Text = "Join Chat";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.DarkGray;
      this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.ForeColor = System.Drawing.Color.White;
      this.button2.Location = new System.Drawing.Point(4, 2);
      this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(155, 32);
      this.button2.TabIndex = 0;
      this.button2.Text = "Host Chat";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click_1);
      // 
      // urgentTaskButton
      // 
      this.urgentTaskButton.BackColor = System.Drawing.Color.Firebrick;
      this.urgentTaskButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.urgentTaskButton.ForeColor = System.Drawing.Color.White;
      this.urgentTaskButton.Location = new System.Drawing.Point(15, 142);
      this.urgentTaskButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.urgentTaskButton.Name = "urgentTaskButton";
      this.urgentTaskButton.Size = new System.Drawing.Size(389, 37);
      this.urgentTaskButton.TabIndex = 8;
      this.urgentTaskButton.UseVisualStyleBackColor = false;
      this.urgentTaskButton.Click += new System.EventHandler(this.urgentTaskButton_Click);
      this.urgentTaskButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.urgentTaskButton_MouseClick);
      // 
      // listView1
      // 
      this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.listView1.Location = new System.Drawing.Point(16, 173);
      this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(388, 406);
      this.listView1.TabIndex = 9;
      this.listView1.UseCompatibleStateImageBehavior = false;
      this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
      // 
      // toTaskFormButton
      // 
      this.toTaskFormButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.toTaskFormButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.toTaskFormButton.ForeColor = System.Drawing.Color.White;
      this.toTaskFormButton.Location = new System.Drawing.Point(16, 546);
      this.toTaskFormButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.toTaskFormButton.Name = "toTaskFormButton";
      this.toTaskFormButton.Size = new System.Drawing.Size(388, 37);
      this.toTaskFormButton.TabIndex = 10;
      this.toTaskFormButton.Text = "Go To Current Tasks";
      this.toTaskFormButton.UseVisualStyleBackColor = false;
      this.toTaskFormButton.Click += new System.EventHandler(this.toTaskFormButton_Click);
      // 
      // groupProfileButton
      // 
      this.groupProfileButton.BackColor = System.Drawing.Color.DarkGray;
      this.groupProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupProfileButton.ForeColor = System.Drawing.Color.White;
      this.groupProfileButton.Location = new System.Drawing.Point(184, 38);
      this.groupProfileButton.Margin = new System.Windows.Forms.Padding(4);
      this.groupProfileButton.Name = "groupProfileButton";
      this.groupProfileButton.Size = new System.Drawing.Size(220, 28);
      this.groupProfileButton.TabIndex = 11;
      this.groupProfileButton.Text = "View Group Profile";
      this.groupProfileButton.UseVisualStyleBackColor = false;
      this.groupProfileButton.Click += new System.EventHandler(this.groupProfileButton_Click);
      // 
      // loggedInTextBox
      // 
      this.loggedInTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.loggedInTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
      this.loggedInTextBox.Location = new System.Drawing.Point(787, 7);
      this.loggedInTextBox.Name = "loggedInTextBox";
      this.loggedInTextBox.Size = new System.Drawing.Size(246, 22);
      this.loggedInTextBox.TabIndex = 12;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1SandBox);
      this.tabControl1.Controls.Add(this.tabPage2TimeLine);
      this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tabControl1.Location = new System.Drawing.Point(410, 145);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(623, 438);
      this.tabControl1.TabIndex = 13;
      // 
      // tabPage1SandBox
      // 
      this.tabPage1SandBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.tabPage1SandBox.Controls.Add(this.confirmDeletePanel);
      this.tabPage1SandBox.Controls.Add(this.createSuggestionPanel);
      this.tabPage1SandBox.Controls.Add(this.downvoteButton);
      this.tabPage1SandBox.Controls.Add(this.sandBoxVoteLabel);
      this.tabPage1SandBox.Controls.Add(this.upvoteButton);
      this.tabPage1SandBox.Controls.Add(this.sandBoxDescLabel);
      this.tabPage1SandBox.Controls.Add(this.listView2);
      this.tabPage1SandBox.Controls.Add(this.suggestionTxtBox);
      this.tabPage1SandBox.Controls.Add(this.deleteSuggestionButton);
      this.tabPage1SandBox.Controls.Add(this.createSuggestionButton);
      this.tabPage1SandBox.Location = new System.Drawing.Point(4, 28);
      this.tabPage1SandBox.Name = "tabPage1SandBox";
      this.tabPage1SandBox.Size = new System.Drawing.Size(615, 406);
      this.tabPage1SandBox.TabIndex = 0;
      this.tabPage1SandBox.Text = "Sandbox             ";
      this.tabPage1SandBox.Click += new System.EventHandler(this.tabPage1SandBox_Click);
      // 
      // tabPage2TimeLine
      // 
      this.tabPage2TimeLine.Location = new System.Drawing.Point(4, 28);
      this.tabPage2TimeLine.Name = "tabPage2TimeLine";
      this.tabPage2TimeLine.Size = new System.Drawing.Size(615, 406);
      this.tabPage2TimeLine.TabIndex = 1;
      this.tabPage2TimeLine.Text = "Timeline             ";
      this.tabPage2TimeLine.UseVisualStyleBackColor = true;
      // 
      // tabControlLabel
      // 
      this.tabControlLabel.AutoSize = true;
      this.tabControlLabel.BackColor = System.Drawing.Color.Transparent;
      this.tabControlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tabControlLabel.ForeColor = System.Drawing.Color.White;
      this.tabControlLabel.Location = new System.Drawing.Point(407, 124);
      this.tabControlLabel.Name = "tabControlLabel";
      this.tabControlLabel.Size = new System.Drawing.Size(100, 18);
      this.tabControlLabel.TabIndex = 14;
      this.tabControlLabel.Text = "Select View:";
      // 
      // createSuggestionButton
      // 
      this.createSuggestionButton.BackColor = System.Drawing.Color.GreenYellow;
      this.createSuggestionButton.Location = new System.Drawing.Point(3, 366);
      this.createSuggestionButton.Name = "createSuggestionButton";
      this.createSuggestionButton.Size = new System.Drawing.Size(310, 37);
      this.createSuggestionButton.TabIndex = 0;
      this.createSuggestionButton.Text = "Create Suggestion";
      this.createSuggestionButton.UseVisualStyleBackColor = false;
      this.createSuggestionButton.Click += new System.EventHandler(this.createSuggestionButton_Click_1);
      // 
      // deleteSuggestionButton
      // 
      this.deleteSuggestionButton.BackColor = System.Drawing.Color.Firebrick;
      this.deleteSuggestionButton.ForeColor = System.Drawing.Color.White;
      this.deleteSuggestionButton.Location = new System.Drawing.Point(313, 366);
      this.deleteSuggestionButton.Name = "deleteSuggestionButton";
      this.deleteSuggestionButton.Size = new System.Drawing.Size(302, 37);
      this.deleteSuggestionButton.TabIndex = 1;
      this.deleteSuggestionButton.Text = "Delete Selected Suggestion";
      this.deleteSuggestionButton.UseVisualStyleBackColor = false;
      this.deleteSuggestionButton.Click += new System.EventHandler(this.deleteSuggestionButton_Click);
      // 
      // suggestionTxtBox
      // 
      this.suggestionTxtBox.BackColor = System.Drawing.SystemColors.ControlLight;
      this.suggestionTxtBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.suggestionTxtBox.Location = new System.Drawing.Point(3, 227);
      this.suggestionTxtBox.Name = "suggestionTxtBox";
      this.suggestionTxtBox.Size = new System.Drawing.Size(609, 133);
      this.suggestionTxtBox.TabIndex = 2;
      this.suggestionTxtBox.Text = "";
      this.suggestionTxtBox.TextChanged += new System.EventHandler(this.suggestionTxtBox_TextChanged);
      // 
      // listView2
      // 
      this.listView2.BackColor = System.Drawing.SystemColors.Control;
      this.listView2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listView2.Location = new System.Drawing.Point(3, 3);
      this.listView2.Name = "listView2";
      this.listView2.Size = new System.Drawing.Size(480, 193);
      this.listView2.TabIndex = 3;
      this.listView2.UseCompatibleStateImageBehavior = false;
      this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged_1);
      // 
      // sandBoxDescLabel
      // 
      this.sandBoxDescLabel.AutoSize = true;
      this.sandBoxDescLabel.Location = new System.Drawing.Point(4, 204);
      this.sandBoxDescLabel.Name = "sandBoxDescLabel";
      this.sandBoxDescLabel.Size = new System.Drawing.Size(175, 19);
      this.sandBoxDescLabel.TabIndex = 4;
      this.sandBoxDescLabel.Text = "Suggestion Description:";
      // 
      // upvoteButton
      // 
      this.upvoteButton.BackColor = System.Drawing.Color.GreenYellow;
      this.upvoteButton.Location = new System.Drawing.Point(489, 30);
      this.upvoteButton.Name = "upvoteButton";
      this.upvoteButton.Size = new System.Drawing.Size(122, 89);
      this.upvoteButton.TabIndex = 5;
      this.upvoteButton.Text = "Upvote";
      this.upvoteButton.UseVisualStyleBackColor = false;
      this.upvoteButton.Click += new System.EventHandler(this.upvoteButton_Click);
      // 
      // sandBoxVoteLabel
      // 
      this.sandBoxVoteLabel.AutoSize = true;
      this.sandBoxVoteLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.sandBoxVoteLabel.Location = new System.Drawing.Point(489, 8);
      this.sandBoxVoteLabel.Name = "sandBoxVoteLabel";
      this.sandBoxVoteLabel.Size = new System.Drawing.Size(106, 19);
      this.sandBoxVoteLabel.TabIndex = 6;
      this.sandBoxVoteLabel.Text = "Vote on Idea";
      // 
      // downvoteButton
      // 
      this.downvoteButton.BackColor = System.Drawing.Color.Firebrick;
      this.downvoteButton.ForeColor = System.Drawing.Color.White;
      this.downvoteButton.Location = new System.Drawing.Point(489, 119);
      this.downvoteButton.Name = "downvoteButton";
      this.downvoteButton.Size = new System.Drawing.Size(122, 77);
      this.downvoteButton.TabIndex = 7;
      this.downvoteButton.Text = "DownVote";
      this.downvoteButton.UseVisualStyleBackColor = false;
      this.downvoteButton.Click += new System.EventHandler(this.downvoteButton_Click);
      // 
      // createSuggestionPanel
      // 
      this.createSuggestionPanel.BackColor = System.Drawing.Color.YellowGreen;
      this.createSuggestionPanel.Controls.Add(this.createSuggestionLabel);
      this.createSuggestionPanel.Controls.Add(this.acceptSuggestionButton);
      this.createSuggestionPanel.Controls.Add(this.createSuggestionDescTextBox);
      this.createSuggestionPanel.Controls.Add(this.suggestionDescLabel);
      this.createSuggestionPanel.Controls.Add(this.suggestionNameTextBox);
      this.createSuggestionPanel.Controls.Add(this.suggestionNameLabel);
      this.createSuggestionPanel.Controls.Add(this.cancelCreationButton);
      this.createSuggestionPanel.Location = new System.Drawing.Point(3, 202);
      this.createSuggestionPanel.Name = "createSuggestionPanel";
      this.createSuggestionPanel.Size = new System.Drawing.Size(609, 201);
      this.createSuggestionPanel.TabIndex = 8;
      this.createSuggestionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.createSuggestionPanel_Paint);
      // 
      // cancelCreationButton
      // 
      this.cancelCreationButton.BackColor = System.Drawing.SystemColors.ControlLight;
      this.cancelCreationButton.Location = new System.Drawing.Point(517, 3);
      this.cancelCreationButton.Name = "cancelCreationButton";
      this.cancelCreationButton.Size = new System.Drawing.Size(91, 31);
      this.cancelCreationButton.TabIndex = 0;
      this.cancelCreationButton.Text = "Cancel";
      this.cancelCreationButton.UseVisualStyleBackColor = false;
      this.cancelCreationButton.Click += new System.EventHandler(this.cancelCreationButton_Click);
      // 
      // suggestionNameLabel
      // 
      this.suggestionNameLabel.AutoSize = true;
      this.suggestionNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.suggestionNameLabel.Location = new System.Drawing.Point(3, 48);
      this.suggestionNameLabel.Name = "suggestionNameLabel";
      this.suggestionNameLabel.Size = new System.Drawing.Size(137, 19);
      this.suggestionNameLabel.TabIndex = 9;
      this.suggestionNameLabel.Text = "Suggestion Name:";
      // 
      // suggestionNameTextBox
      // 
      this.suggestionNameTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.suggestionNameTextBox.Location = new System.Drawing.Point(185, 42);
      this.suggestionNameTextBox.Name = "suggestionNameTextBox";
      this.suggestionNameTextBox.Size = new System.Drawing.Size(365, 27);
      this.suggestionNameTextBox.TabIndex = 10;
      // 
      // suggestionDescLabel
      // 
      this.suggestionDescLabel.AutoSize = true;
      this.suggestionDescLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.suggestionDescLabel.Location = new System.Drawing.Point(3, 91);
      this.suggestionDescLabel.Name = "suggestionDescLabel";
      this.suggestionDescLabel.Size = new System.Drawing.Size(175, 19);
      this.suggestionDescLabel.TabIndex = 11;
      this.suggestionDescLabel.Text = "Suggestion Description:";
      // 
      // createSuggestionDescTextBox
      // 
      this.createSuggestionDescTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.createSuggestionDescTextBox.Location = new System.Drawing.Point(185, 91);
      this.createSuggestionDescTextBox.Name = "createSuggestionDescTextBox";
      this.createSuggestionDescTextBox.Size = new System.Drawing.Size(365, 107);
      this.createSuggestionDescTextBox.TabIndex = 11;
      this.createSuggestionDescTextBox.Text = "";
      // 
      // acceptSuggestionButton
      // 
      this.acceptSuggestionButton.BackColor = System.Drawing.Color.Chartreuse;
      this.acceptSuggestionButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.acceptSuggestionButton.Location = new System.Drawing.Point(556, 92);
      this.acceptSuggestionButton.Name = "acceptSuggestionButton";
      this.acceptSuggestionButton.Size = new System.Drawing.Size(49, 106);
      this.acceptSuggestionButton.TabIndex = 12;
      this.acceptSuggestionButton.Text = "✔";
      this.acceptSuggestionButton.UseVisualStyleBackColor = false;
      this.acceptSuggestionButton.Click += new System.EventHandler(this.acceptSuggestionButton_Click);
      // 
      // createSuggestionLabel
      // 
      this.createSuggestionLabel.AutoSize = true;
      this.createSuggestionLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.createSuggestionLabel.Location = new System.Drawing.Point(7, 8);
      this.createSuggestionLabel.Name = "createSuggestionLabel";
      this.createSuggestionLabel.Size = new System.Drawing.Size(204, 26);
      this.createSuggestionLabel.TabIndex = 13;
      this.createSuggestionLabel.Text = "Create a Suggestion";
      // 
      // confirmDeletePanel
      // 
      this.confirmDeletePanel.Controls.Add(this.noButton);
      this.confirmDeletePanel.Controls.Add(this.yesButton);
      this.confirmDeletePanel.Controls.Add(this.confirmationDeleteLabel);
      this.confirmDeletePanel.Location = new System.Drawing.Point(188, 102);
      this.confirmDeletePanel.Name = "confirmDeletePanel";
      this.confirmDeletePanel.Size = new System.Drawing.Size(232, 134);
      this.confirmDeletePanel.TabIndex = 9;
      // 
      // confirmationDeleteLabel
      // 
      this.confirmationDeleteLabel.AutoSize = true;
      this.confirmationDeleteLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.confirmationDeleteLabel.Location = new System.Drawing.Point(26, 17);
      this.confirmationDeleteLabel.Name = "confirmationDeleteLabel";
      this.confirmationDeleteLabel.Size = new System.Drawing.Size(184, 26);
      this.confirmationDeleteLabel.TabIndex = 0;
      this.confirmationDeleteLabel.Text = "Confirm deletion?";
      // 
      // yesButton
      // 
      this.yesButton.BackColor = System.Drawing.Color.GreenYellow;
      this.yesButton.Location = new System.Drawing.Point(14, 73);
      this.yesButton.Name = "yesButton";
      this.yesButton.Size = new System.Drawing.Size(82, 48);
      this.yesButton.TabIndex = 1;
      this.yesButton.Text = "Yes";
      this.yesButton.UseVisualStyleBackColor = false;
      this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
      // 
      // noButton
      // 
      this.noButton.BackColor = System.Drawing.Color.Firebrick;
      this.noButton.ForeColor = System.Drawing.Color.White;
      this.noButton.Location = new System.Drawing.Point(102, 73);
      this.noButton.Name = "noButton";
      this.noButton.Size = new System.Drawing.Size(117, 48);
      this.noButton.TabIndex = 2;
      this.noButton.Text = "No";
      this.noButton.UseVisualStyleBackColor = false;
      this.noButton.Click += new System.EventHandler(this.noButton_Click);
      // 
      // MainMenuForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1045, 690);
      this.Controls.Add(this.tabControlLabel);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.loggedInTextBox);
      this.Controls.Add(this.groupProfileButton);
      this.Controls.Add(this.toTaskFormButton);
      this.Controls.Add(this.listView1);
      this.Controls.Add(this.urgentTaskButton);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.chatButton);
      this.Controls.Add(this.profileButton);
      this.Controls.Add(this.menuSelfNameLabel);
      this.Controls.Add(this.menuGroupNameTxt);
      this.Controls.Add(this.menuGroupNameLabel);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "MainMenuForm";
      this.Text = "Agile Development Tools Suite";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
      this.Load += new System.EventHandler(this.MainMenuForm_Load);
      this.panel1.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1SandBox.ResumeLayout(false);
      this.tabPage1SandBox.PerformLayout();
      this.createSuggestionPanel.ResumeLayout(false);
      this.createSuggestionPanel.PerformLayout();
      this.confirmDeletePanel.ResumeLayout(false);
      this.confirmDeletePanel.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label menuGroupNameLabel;
    private System.Windows.Forms.TextBox menuGroupNameTxt;
    private System.Windows.Forms.Label menuSelfNameLabel;
    private System.Windows.Forms.Button profileButton;
    private System.Windows.Forms.Button chatButton;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button urgentTaskButton;
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.Button toTaskFormButton;
    private System.Windows.Forms.Button groupProfileButton;
    private System.Windows.Forms.TextBox loggedInTextBox;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1SandBox;
    private System.Windows.Forms.TabPage tabPage2TimeLine;
    private System.Windows.Forms.Label tabControlLabel;
    private System.Windows.Forms.RichTextBox suggestionTxtBox;
    private System.Windows.Forms.Button deleteSuggestionButton;
    private System.Windows.Forms.Button createSuggestionButton;
    private System.Windows.Forms.ListView listView2;
    private System.Windows.Forms.Button downvoteButton;
    private System.Windows.Forms.Label sandBoxVoteLabel;
    private System.Windows.Forms.Button upvoteButton;
    private System.Windows.Forms.Label sandBoxDescLabel;
    private System.Windows.Forms.Panel createSuggestionPanel;
    private System.Windows.Forms.Label suggestionNameLabel;
    private System.Windows.Forms.Button cancelCreationButton;
    private System.Windows.Forms.Label createSuggestionLabel;
    private System.Windows.Forms.Button acceptSuggestionButton;
    private System.Windows.Forms.RichTextBox createSuggestionDescTextBox;
    private System.Windows.Forms.Label suggestionDescLabel;
    private System.Windows.Forms.TextBox suggestionNameTextBox;
    private System.Windows.Forms.Panel confirmDeletePanel;
    private System.Windows.Forms.Button noButton;
    private System.Windows.Forms.Button yesButton;
    private System.Windows.Forms.Label confirmationDeleteLabel;
  }
}