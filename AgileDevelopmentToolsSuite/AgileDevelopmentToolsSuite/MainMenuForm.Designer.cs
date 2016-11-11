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
            System.Windows.Forms.TextBox menuNumUrgentTasks;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.menuGroupNameLabel = new System.Windows.Forms.Label();
            this.menuGroupNameTxt = new System.Windows.Forms.TextBox();
            this.menuSelfNameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            menuSelfNameTxt = new System.Windows.Forms.TextBox();
            menuNumUrgentTasks = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // menuSelfNameTxt
            // 
            menuSelfNameTxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            menuSelfNameTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            menuSelfNameTxt.Location = new System.Drawing.Point(606, 6);
            menuSelfNameTxt.Margin = new System.Windows.Forms.Padding(2);
            menuSelfNameTxt.Name = "menuSelfNameTxt";
            menuSelfNameTxt.ReadOnly = true;
            menuSelfNameTxt.Size = new System.Drawing.Size(174, 20);
            menuSelfNameTxt.TabIndex = 3;
            // 
            // menuNumUrgentTasks
            // 
            menuNumUrgentTasks.BackColor = System.Drawing.Color.Firebrick;
            menuNumUrgentTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            menuNumUrgentTasks.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            menuNumUrgentTasks.ForeColor = System.Drawing.Color.Snow;
            menuNumUrgentTasks.Location = new System.Drawing.Point(290, 95);
            menuNumUrgentTasks.Margin = new System.Windows.Forms.Padding(2);
            menuNumUrgentTasks.Name = "menuNumUrgentTasks";
            menuNumUrgentTasks.ReadOnly = true;
            menuNumUrgentTasks.Size = new System.Drawing.Size(218, 25);
            menuNumUrgentTasks.TabIndex = 4;
            menuNumUrgentTasks.Text = "(# of Urgent Tasks Clickable)";
            menuNumUrgentTasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            menuNumUrgentTasks.TextChanged += new System.EventHandler(this.menuNumUrgentTasks_TextChanged);
            // 
            // menuGroupNameLabel
            // 
            this.menuGroupNameLabel.AutoSize = true;
            this.menuGroupNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.menuGroupNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuGroupNameLabel.Location = new System.Drawing.Point(9, 7);
            this.menuGroupNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.menuGroupNameLabel.Name = "menuGroupNameLabel";
            this.menuGroupNameLabel.Size = new System.Drawing.Size(94, 17);
            this.menuGroupNameLabel.TabIndex = 0;
            this.menuGroupNameLabel.Text = "Group Profile:";
            // 
            // menuGroupNameTxt
            // 
            this.menuGroupNameTxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuGroupNameTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuGroupNameTxt.Location = new System.Drawing.Point(98, 6);
            this.menuGroupNameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.menuGroupNameTxt.Name = "menuGroupNameTxt";
            this.menuGroupNameTxt.ReadOnly = true;
            this.menuGroupNameTxt.Size = new System.Drawing.Size(231, 20);
            this.menuGroupNameTxt.TabIndex = 1;
            this.menuGroupNameTxt.TextChanged += new System.EventHandler(this.menuGroupNameTxt_TextChanged);
            // 
            // menuSelfNameLabel
            // 
            this.menuSelfNameLabel.AutoSize = true;
            this.menuSelfNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.menuSelfNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSelfNameLabel.Location = new System.Drawing.Point(517, 7);
            this.menuSelfNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.menuSelfNameLabel.Name = "menuSelfNameLabel";
            this.menuSelfNameLabel.Size = new System.Drawing.Size(90, 17);
            this.menuSelfNameLabel.TabIndex = 2;
            this.menuSelfNameLabel.Text = "Logged in as:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(660, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "View Profile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(menuNumUrgentTasks);
            this.Controls.Add(menuSelfNameTxt);
            this.Controls.Add(this.menuSelfNameLabel);
            this.Controls.Add(this.menuGroupNameTxt);
            this.Controls.Add(this.menuGroupNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenuForm";
            this.Text = "Agile Development Tools Suite";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label menuGroupNameLabel;
    private System.Windows.Forms.TextBox menuGroupNameTxt;
    private System.Windows.Forms.Label menuSelfNameLabel;
    private System.Windows.Forms.Button button1;
  }
}