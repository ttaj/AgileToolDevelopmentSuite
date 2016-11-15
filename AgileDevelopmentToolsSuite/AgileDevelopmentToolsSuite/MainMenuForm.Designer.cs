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
      System.Windows.Forms.TextBox menuSelfNameTxt;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
      this.menuGroupNameLabel = new System.Windows.Forms.Label();
      this.menuGroupNameTxt = new System.Windows.Forms.TextBox();
      this.menuSelfNameLabel = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.chatButton = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.urgentTaskButton = new System.Windows.Forms.Button();
      this.listView1 = new System.Windows.Forms.ListView();
      this.toTaskFormButton = new System.Windows.Forms.Button();
      menuSelfNameTxt = new System.Windows.Forms.TextBox();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuSelfNameTxt
      // 
      menuSelfNameTxt.BackColor = System.Drawing.SystemColors.ScrollBar;
      menuSelfNameTxt.Cursor = System.Windows.Forms.Cursors.Hand;
      menuSelfNameTxt.Location = new System.Drawing.Point(808, 7);
      menuSelfNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      menuSelfNameTxt.Name = "menuSelfNameTxt";
      menuSelfNameTxt.ReadOnly = true;
      menuSelfNameTxt.Size = new System.Drawing.Size(231, 22);
      menuSelfNameTxt.TabIndex = 3;
      // 
      // menuGroupNameLabel
      // 
      this.menuGroupNameLabel.AutoSize = true;
      this.menuGroupNameLabel.BackColor = System.Drawing.Color.Transparent;
      this.menuGroupNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
      this.menuGroupNameTxt.Location = new System.Drawing.Point(131, 7);
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
      this.menuSelfNameLabel.Location = new System.Drawing.Point(689, 9);
      this.menuSelfNameLabel.Name = "menuSelfNameLabel";
      this.menuSelfNameLabel.Size = new System.Drawing.Size(108, 19);
      this.menuSelfNameLabel.TabIndex = 2;
      this.menuSelfNameLabel.Text = "Logged in as:";
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.DarkGray;
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.Location = new System.Drawing.Point(859, 35);
      this.button1.Margin = new System.Windows.Forms.Padding(4);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(149, 28);
      this.button1.TabIndex = 5;
      this.button1.Text = "View Profile";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // chatButton
      // 
      this.chatButton.BackColor = System.Drawing.Color.YellowGreen;
      this.chatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chatButton.Location = new System.Drawing.Point(16, 640);
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
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(339, 38);
      this.panel1.TabIndex = 7;
      this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(162, 3);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(174, 32);
      this.button3.TabIndex = 1;
      this.button3.Text = "Join Chat";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(4, 3);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(155, 32);
      this.button2.TabIndex = 0;
      this.button2.Text = "Host Chat";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click_1);
      // 
      // urgentTaskButton
      // 
      this.urgentTaskButton.BackColor = System.Drawing.Color.Firebrick;
      this.urgentTaskButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.urgentTaskButton.ForeColor = System.Drawing.Color.White;
      this.urgentTaskButton.Location = new System.Drawing.Point(16, 126);
      this.urgentTaskButton.Name = "urgentTaskButton";
      this.urgentTaskButton.Size = new System.Drawing.Size(327, 37);
      this.urgentTaskButton.TabIndex = 8;
      this.urgentTaskButton.UseVisualStyleBackColor = false;
      this.urgentTaskButton.Click += new System.EventHandler(this.urgentTaskButton_Click);
      // 
      // listView1
      // 
      this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.listView1.Location = new System.Drawing.Point(16, 158);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(327, 404);
      this.listView1.TabIndex = 9;
      this.listView1.UseCompatibleStateImageBehavior = false;
      this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
      // 
      // toTaskFormButton
      // 
      this.toTaskFormButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.toTaskFormButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.toTaskFormButton.ForeColor = System.Drawing.Color.Black;
      this.toTaskFormButton.Location = new System.Drawing.Point(16, 546);
      this.toTaskFormButton.Name = "toTaskFormButton";
      this.toTaskFormButton.Size = new System.Drawing.Size(327, 37);
      this.toTaskFormButton.TabIndex = 10;
      this.toTaskFormButton.Text = "Go To Current Tasks";
      this.toTaskFormButton.UseVisualStyleBackColor = false;
      this.toTaskFormButton.Click += new System.EventHandler(this.toTaskFormButton_Click);
      // 
      // MainMenuForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1045, 690);
      this.Controls.Add(this.toTaskFormButton);
      this.Controls.Add(this.listView1);
      this.Controls.Add(this.urgentTaskButton);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.chatButton);
      this.Controls.Add(this.button1);
      this.Controls.Add(menuSelfNameTxt);
      this.Controls.Add(this.menuSelfNameLabel);
      this.Controls.Add(this.menuGroupNameTxt);
      this.Controls.Add(this.menuGroupNameLabel);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "MainMenuForm";
      this.Text = "Agile Development Tools Suite";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing_1);
      this.Load += new System.EventHandler(this.MainMenuForm_Load);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label menuGroupNameLabel;
    private System.Windows.Forms.TextBox menuGroupNameTxt;
    private System.Windows.Forms.Label menuSelfNameLabel;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button chatButton;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button urgentTaskButton;
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.Button toTaskFormButton;
  }
}