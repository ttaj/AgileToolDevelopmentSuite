namespace AgileDevelopmentToolsSuite
{
  partial class TaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            this.curTasksListBox = new System.Windows.Forms.ListBox();
            this.taskFormLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.curTasksLabel = new System.Windows.Forms.Label();
            this.curTasksComboBox = new System.Windows.Forms.ComboBox();
            this.curTasksSortLabel = new System.Windows.Forms.Label();
            this.curTaskDescriptions = new System.Windows.Forms.RichTextBox();
            this.rightArrow = new System.Windows.Forms.Label();
            this.curTasksSaveButton = new System.Windows.Forms.Button();
            this.curTasksRadio1 = new System.Windows.Forms.RadioButton();
            this.curTasksRadio2 = new System.Windows.Forms.RadioButton();
            this.curTasksRadio3 = new System.Windows.Forms.RadioButton();
            this.curTasksRadioGroup = new System.Windows.Forms.GroupBox();
            this.curTaskDescLabel = new System.Windows.Forms.Label();
            this.curTaskDescVScroll = new System.Windows.Forms.VScrollBar();
            this.curTasksRadioGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // curTasksListBox
            // 
            this.curTasksListBox.BackColor = System.Drawing.Color.Green;
            this.curTasksListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.curTasksListBox.FormattingEnabled = true;
            this.curTasksListBox.Location = new System.Drawing.Point(9, 126);
            this.curTasksListBox.Margin = new System.Windows.Forms.Padding(2);
            this.curTasksListBox.Name = "curTasksListBox";
            this.curTasksListBox.Size = new System.Drawing.Size(358, 420);
            this.curTasksListBox.TabIndex = 0;
            this.curTasksListBox.SelectedIndexChanged += new System.EventHandler(this.curTasksListBox_SelectedIndexChanged);
            // 
            // taskFormLabel
            // 
            this.taskFormLabel.AutoSize = true;
            this.taskFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.taskFormLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskFormLabel.ForeColor = System.Drawing.Color.White;
            this.taskFormLabel.Location = new System.Drawing.Point(244, 10);
            this.taskFormLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taskFormLabel.Name = "taskFormLabel";
            this.taskFormLabel.Size = new System.Drawing.Size(309, 28);
            this.taskFormLabel.TabIndex = 1;
            this.taskFormLabel.Text = "List of Current Project Tasks";
            this.taskFormLabel.UseWaitCursor = true;
            this.taskFormLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DarkGray;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.backButton.Location = new System.Drawing.Point(18, 10);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.backButton.Size = new System.Drawing.Size(90, 28);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back to Menu";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // curTasksLabel
            // 
            this.curTasksLabel.AutoSize = true;
            this.curTasksLabel.BackColor = System.Drawing.Color.Transparent;
            this.curTasksLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curTasksLabel.ForeColor = System.Drawing.Color.White;
            this.curTasksLabel.Location = new System.Drawing.Point(5, 100);
            this.curTasksLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.curTasksLabel.Name = "curTasksLabel";
            this.curTasksLabel.Size = new System.Drawing.Size(111, 19);
            this.curTasksLabel.TabIndex = 3;
            this.curTasksLabel.Text = "Current Tasks";
            this.curTasksLabel.Click += new System.EventHandler(this.curTasksLabel_Click);
            // 
            // curTasksComboBox
            // 
            this.curTasksComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.curTasksComboBox.FormattingEnabled = true;
            this.curTasksComboBox.Items.AddRange(new object[] {
            "Date Issued",
            "Importance",
            "Name"});
            this.curTasksComboBox.Location = new System.Drawing.Point(253, 101);
            this.curTasksComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.curTasksComboBox.Name = "curTasksComboBox";
            this.curTasksComboBox.Size = new System.Drawing.Size(114, 21);
            this.curTasksComboBox.TabIndex = 4;
            this.curTasksComboBox.SelectedIndexChanged += new System.EventHandler(this.curTasksComboBox_SelectedIndexChanged);
            // 
            // curTasksSortLabel
            // 
            this.curTasksSortLabel.AutoSize = true;
            this.curTasksSortLabel.BackColor = System.Drawing.Color.Transparent;
            this.curTasksSortLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curTasksSortLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.curTasksSortLabel.Location = new System.Drawing.Point(185, 99);
            this.curTasksSortLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.curTasksSortLabel.Name = "curTasksSortLabel";
            this.curTasksSortLabel.Size = new System.Drawing.Size(64, 19);
            this.curTasksSortLabel.TabIndex = 5;
            this.curTasksSortLabel.Text = "Sort By:";
            this.curTasksSortLabel.Click += new System.EventHandler(this.curTasksSortLabel_Click);
            // 
            // curTaskDescriptions
            // 
            this.curTaskDescriptions.BackColor = System.Drawing.Color.Green;
            this.curTaskDescriptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.curTaskDescriptions.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curTaskDescriptions.ForeColor = System.Drawing.Color.Snow;
            this.curTaskDescriptions.Location = new System.Drawing.Point(416, 126);
            this.curTaskDescriptions.Margin = new System.Windows.Forms.Padding(2);
            this.curTaskDescriptions.Name = "curTaskDescriptions";
            this.curTaskDescriptions.Size = new System.Drawing.Size(358, 417);
            this.curTaskDescriptions.TabIndex = 6;
            this.curTaskDescriptions.Text = "";
            this.curTaskDescriptions.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // rightArrow
            // 
            this.rightArrow.AutoSize = true;
            this.rightArrow.BackColor = System.Drawing.Color.Transparent;
            this.rightArrow.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightArrow.ForeColor = System.Drawing.Color.Snow;
            this.rightArrow.Location = new System.Drawing.Point(368, 365);
            this.rightArrow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rightArrow.Name = "rightArrow";
            this.rightArrow.Size = new System.Drawing.Size(47, 40);
            this.rightArrow.TabIndex = 7;
            this.rightArrow.Text = "→";
            this.rightArrow.Click += new System.EventHandler(this.rightArrow_Click);
            // 
            // curTasksSaveButton
            // 
            this.curTasksSaveButton.BackColor = System.Drawing.Color.Gray;
            this.curTasksSaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.curTasksSaveButton.Location = new System.Drawing.Point(329, 557);
            this.curTasksSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.curTasksSaveButton.Name = "curTasksSaveButton";
            this.curTasksSaveButton.Size = new System.Drawing.Size(122, 24);
            this.curTasksSaveButton.TabIndex = 8;
            this.curTasksSaveButton.Text = "Save Changes";
            this.curTasksSaveButton.UseVisualStyleBackColor = false;
            this.curTasksSaveButton.Click += new System.EventHandler(this.curTasksSaveButton_Click);
            // 
            // curTasksRadio1
            // 
            this.curTasksRadio1.AutoSize = true;
            this.curTasksRadio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curTasksRadio1.ForeColor = System.Drawing.Color.Snow;
            this.curTasksRadio1.Location = new System.Drawing.Point(4, 8);
            this.curTasksRadio1.Margin = new System.Windows.Forms.Padding(2);
            this.curTasksRadio1.Name = "curTasksRadio1";
            this.curTasksRadio1.Size = new System.Drawing.Size(63, 17);
            this.curTasksRadio1.TabIndex = 9;
            this.curTasksRadio1.TabStop = true;
            this.curTasksRadio1.Text = "Urgent";
            this.curTasksRadio1.UseVisualStyleBackColor = true;
            this.curTasksRadio1.CheckedChanged += new System.EventHandler(this.curTasksRadio1_CheckedChanged);
            // 
            // curTasksRadio2
            // 
            this.curTasksRadio2.AutoSize = true;
            this.curTasksRadio2.ForeColor = System.Drawing.Color.Snow;
            this.curTasksRadio2.Location = new System.Drawing.Point(66, 8);
            this.curTasksRadio2.Margin = new System.Windows.Forms.Padding(2);
            this.curTasksRadio2.Name = "curTasksRadio2";
            this.curTasksRadio2.Size = new System.Drawing.Size(59, 17);
            this.curTasksRadio2.TabIndex = 10;
            this.curTasksRadio2.TabStop = true;
            this.curTasksRadio2.Text = "TO-DO";
            this.curTasksRadio2.UseVisualStyleBackColor = true;
            // 
            // curTasksRadio3
            // 
            this.curTasksRadio3.AutoSize = true;
            this.curTasksRadio3.ForeColor = System.Drawing.Color.Snow;
            this.curTasksRadio3.Location = new System.Drawing.Point(127, 8);
            this.curTasksRadio3.Margin = new System.Windows.Forms.Padding(2);
            this.curTasksRadio3.Name = "curTasksRadio3";
            this.curTasksRadio3.Size = new System.Drawing.Size(75, 17);
            this.curTasksRadio3.TabIndex = 11;
            this.curTasksRadio3.TabStop = true;
            this.curTasksRadio3.Text = "Completed";
            this.curTasksRadio3.UseVisualStyleBackColor = true;
            // 
            // curTasksRadioGroup
            // 
            this.curTasksRadioGroup.BackColor = System.Drawing.Color.Transparent;
            this.curTasksRadioGroup.Controls.Add(this.curTasksRadio1);
            this.curTasksRadioGroup.Controls.Add(this.curTasksRadio3);
            this.curTasksRadioGroup.Controls.Add(this.curTasksRadio2);
            this.curTasksRadioGroup.Location = new System.Drawing.Point(575, 97);
            this.curTasksRadioGroup.Margin = new System.Windows.Forms.Padding(2);
            this.curTasksRadioGroup.Name = "curTasksRadioGroup";
            this.curTasksRadioGroup.Padding = new System.Windows.Forms.Padding(2);
            this.curTasksRadioGroup.Size = new System.Drawing.Size(199, 25);
            this.curTasksRadioGroup.TabIndex = 12;
            this.curTasksRadioGroup.TabStop = false;
            // 
            // curTaskDescLabel
            // 
            this.curTaskDescLabel.AutoSize = true;
            this.curTaskDescLabel.BackColor = System.Drawing.Color.Transparent;
            this.curTaskDescLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curTaskDescLabel.ForeColor = System.Drawing.Color.White;
            this.curTaskDescLabel.Location = new System.Drawing.Point(385, 103);
            this.curTaskDescLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.curTaskDescLabel.Name = "curTaskDescLabel";
            this.curTaskDescLabel.Size = new System.Drawing.Size(186, 19);
            this.curTaskDescLabel.TabIndex = 13;
            this.curTaskDescLabel.Text = "Modify task description";
            // 
            // curTaskDescVScroll
            // 
            this.curTaskDescVScroll.Location = new System.Drawing.Point(761, 126);
            this.curTaskDescVScroll.Name = "curTaskDescVScroll";
            this.curTaskDescVScroll.Size = new System.Drawing.Size(13, 419);
            this.curTaskDescVScroll.TabIndex = 14;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 592);
            this.Controls.Add(this.curTaskDescVScroll);
            this.Controls.Add(this.curTaskDescLabel);
            this.Controls.Add(this.curTasksRadioGroup);
            this.Controls.Add(this.curTasksSaveButton);
            this.Controls.Add(this.rightArrow);
            this.Controls.Add(this.curTaskDescriptions);
            this.Controls.Add(this.curTasksSortLabel);
            this.Controls.Add(this.curTasksComboBox);
            this.Controls.Add(this.curTasksLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.taskFormLabel);
            this.Controls.Add(this.curTasksListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.curTasksRadioGroup.ResumeLayout(false);
            this.curTasksRadioGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox curTasksListBox;
    private System.Windows.Forms.Label taskFormLabel;
    private System.Windows.Forms.Button backButton;
    private System.Windows.Forms.Label curTasksLabel;
    private System.Windows.Forms.ComboBox curTasksComboBox;
    private System.Windows.Forms.Label curTasksSortLabel;
    private System.Windows.Forms.RichTextBox curTaskDescriptions;
    private System.Windows.Forms.Label rightArrow;
    private System.Windows.Forms.Button curTasksSaveButton;
    private System.Windows.Forms.RadioButton curTasksRadio1;
    private System.Windows.Forms.RadioButton curTasksRadio2;
    private System.Windows.Forms.RadioButton curTasksRadio3;
    private System.Windows.Forms.GroupBox curTasksRadioGroup;
    private System.Windows.Forms.Label curTaskDescLabel;
    private System.Windows.Forms.VScrollBar curTaskDescVScroll;
  }
}