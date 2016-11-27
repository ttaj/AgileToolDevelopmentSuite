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
      this.panel1.SuspendLayout();
      this.tabControl1.SuspendLayout();
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
      this.tabPage1SandBox.Location = new System.Drawing.Point(4, 28);
      this.tabPage1SandBox.Name = "tabPage1SandBox";
      this.tabPage1SandBox.Size = new System.Drawing.Size(615, 406);
      this.tabPage1SandBox.TabIndex = 0;
      this.tabPage1SandBox.Text = "Sandbox             ";
      // 
      // tabPage2TimeLine
      // 
      this.tabPage2TimeLine.Location = new System.Drawing.Point(4, 28);
      this.tabPage2TimeLine.Name = "tabPage2TimeLine";
      this.tabPage2TimeLine.Size = new System.Drawing.Size(675, 406);
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
      this.tabControlLabel.Location = new System.Drawing.Point(347, 124);
      this.tabControlLabel.Name = "tabControlLabel";
      this.tabControlLabel.Size = new System.Drawing.Size(100, 18);
      this.tabControlLabel.TabIndex = 14;
      this.tabControlLabel.Text = "Select View:";
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
  }
}