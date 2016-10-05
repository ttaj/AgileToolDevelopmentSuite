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
      menuSelfNameTxt = new System.Windows.Forms.TextBox();
      menuNumUrgentTasks = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // menuSelfNameTxt
      // 
      menuSelfNameTxt.BackColor = System.Drawing.SystemColors.ScrollBar;
      menuSelfNameTxt.Cursor = System.Windows.Forms.Cursors.Hand;
      menuSelfNameTxt.Location = new System.Drawing.Point(808, 8);
      menuSelfNameTxt.Name = "menuSelfNameTxt";
      menuSelfNameTxt.ReadOnly = true;
      menuSelfNameTxt.Size = new System.Drawing.Size(231, 22);
      menuSelfNameTxt.TabIndex = 3;
      // 
      // menuNumUrgentTasks
      // 
      menuNumUrgentTasks.BackColor = System.Drawing.Color.Firebrick;
      menuNumUrgentTasks.Cursor = System.Windows.Forms.Cursors.Hand;
      menuNumUrgentTasks.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      menuNumUrgentTasks.ForeColor = System.Drawing.Color.Snow;
      menuNumUrgentTasks.Location = new System.Drawing.Point(387, 117);
      menuNumUrgentTasks.Name = "menuNumUrgentTasks";
      menuNumUrgentTasks.ReadOnly = true;
      menuNumUrgentTasks.Size = new System.Drawing.Size(290, 30);
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
      this.menuGroupNameTxt.Location = new System.Drawing.Point(131, 8);
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
      // MainMenuForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1045, 690);
      this.Controls.Add(menuNumUrgentTasks);
      this.Controls.Add(menuSelfNameTxt);
      this.Controls.Add(this.menuSelfNameLabel);
      this.Controls.Add(this.menuGroupNameTxt);
      this.Controls.Add(this.menuGroupNameLabel);
      this.Name = "MainMenuForm";
      this.Text = "MainMenuForm";
      this.Load += new System.EventHandler(this.MainMenuForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label menuGroupNameLabel;
    private System.Windows.Forms.TextBox menuGroupNameTxt;
    private System.Windows.Forms.Label menuSelfNameLabel;
  }
}