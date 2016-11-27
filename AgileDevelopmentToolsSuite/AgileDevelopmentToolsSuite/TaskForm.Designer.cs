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
      this.taskFormLabel = new System.Windows.Forms.Label();
      this.backButton = new System.Windows.Forms.Button();
      this.curTasksLabel = new System.Windows.Forms.Label();
      this.curTasksComboBox = new System.Windows.Forms.ComboBox();
      this.curTasksSortLabel = new System.Windows.Forms.Label();
      this.curTaskDescriptions = new System.Windows.Forms.RichTextBox();
      this.curTasksSaveButton = new System.Windows.Forms.Button();
      this.curTasksRadio1 = new System.Windows.Forms.RadioButton();
      this.curTasksRadio2 = new System.Windows.Forms.RadioButton();
      this.curTasksRadio3 = new System.Windows.Forms.RadioButton();
      this.curTasksRadioGroup = new System.Windows.Forms.GroupBox();
      this.curTaskDescLabel = new System.Windows.Forms.Label();
      this.createTaskButton = new System.Windows.Forms.Button();
      this.listView1 = new System.Windows.Forms.ListView();
      this.selectedIDLbl = new System.Windows.Forms.Label();
      this.instructionsButton = new System.Windows.Forms.Button();
      this.setSprintNumBox = new System.Windows.Forms.NumericUpDown();
      this.setSprintLbl = new System.Windows.Forms.Label();
      this.setImportanceLbl = new System.Windows.Forms.Label();
      this.testLabel = new System.Windows.Forms.Label();
      this.sortByUpOrDown = new System.Windows.Forms.Label();
      this.curTasksRadioGroup.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.setSprintNumBox)).BeginInit();
      this.SuspendLayout();
      // 
      // taskFormLabel
      // 
      this.taskFormLabel.AutoSize = true;
      this.taskFormLabel.BackColor = System.Drawing.Color.Transparent;
      this.taskFormLabel.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.taskFormLabel.ForeColor = System.Drawing.Color.White;
      this.taskFormLabel.Location = new System.Drawing.Point(275, 12);
      this.taskFormLabel.Name = "taskFormLabel";
      this.taskFormLabel.Size = new System.Drawing.Size(411, 37);
      this.taskFormLabel.TabIndex = 1;
      this.taskFormLabel.Text = "List of Current Project Tasks";
      this.taskFormLabel.UseWaitCursor = true;
      this.taskFormLabel.Click += new System.EventHandler(this.label1_Click);
      // 
      // backButton
      // 
      this.backButton.BackColor = System.Drawing.Color.DarkGray;
      this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.backButton.Location = new System.Drawing.Point(24, 12);
      this.backButton.Name = "backButton";
      this.backButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.backButton.Size = new System.Drawing.Size(166, 35);
      this.backButton.TabIndex = 2;
      this.backButton.Text = "Back to Menu";
      this.backButton.UseVisualStyleBackColor = false;
      this.backButton.Click += new System.EventHandler(this.backButton_Click);
      // 
      // curTasksLabel
      // 
      this.curTasksLabel.AutoSize = true;
      this.curTasksLabel.BackColor = System.Drawing.Color.Transparent;
      this.curTasksLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.curTasksLabel.ForeColor = System.Drawing.Color.White;
      this.curTasksLabel.Location = new System.Drawing.Point(13, 73);
      this.curTasksLabel.Name = "curTasksLabel";
      this.curTasksLabel.Size = new System.Drawing.Size(150, 27);
      this.curTasksLabel.TabIndex = 3;
      this.curTasksLabel.Text = "Current Tasks";
      this.curTasksLabel.Click += new System.EventHandler(this.curTasksLabel_Click);
      // 
      // curTasksComboBox
      // 
      this.curTasksComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.curTasksComboBox.FormattingEnabled = true;
      this.curTasksComboBox.Items.AddRange(new object[] {
            "(Show All Tasks)",
            "(Show Non-Sprints)"});
      this.curTasksComboBox.Location = new System.Drawing.Point(267, 52);
      this.curTasksComboBox.MaxDropDownItems = 99;
      this.curTasksComboBox.Name = "curTasksComboBox";
      this.curTasksComboBox.Size = new System.Drawing.Size(135, 24);
      this.curTasksComboBox.TabIndex = 4;
      this.curTasksComboBox.SelectedIndexChanged += new System.EventHandler(this.curTasksComboBox_SelectedIndexChanged);
      // 
      // curTasksSortLabel
      // 
      this.curTasksSortLabel.AutoSize = true;
      this.curTasksSortLabel.BackColor = System.Drawing.Color.Transparent;
      this.curTasksSortLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.curTasksSortLabel.ForeColor = System.Drawing.Color.White;
      this.curTasksSortLabel.Location = new System.Drawing.Point(179, 81);
      this.curTasksSortLabel.Name = "curTasksSortLabel";
      this.curTasksSortLabel.Size = new System.Drawing.Size(82, 24);
      this.curTasksSortLabel.TabIndex = 5;
      this.curTasksSortLabel.Text = "Sprint #:";
      this.curTasksSortLabel.Click += new System.EventHandler(this.curTasksSortLabel_Click);
      // 
      // curTaskDescriptions
      // 
      this.curTaskDescriptions.BackColor = System.Drawing.Color.YellowGreen;
      this.curTaskDescriptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.curTaskDescriptions.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.curTaskDescriptions.ForeColor = System.Drawing.Color.Black;
      this.curTaskDescriptions.Location = new System.Drawing.Point(12, 460);
      this.curTaskDescriptions.Name = "curTaskDescriptions";
      this.curTaskDescriptions.Size = new System.Drawing.Size(1021, 218);
      this.curTaskDescriptions.TabIndex = 6;
      this.curTaskDescriptions.Text = "";
      this.curTaskDescriptions.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
      // 
      // curTasksSaveButton
      // 
      this.curTasksSaveButton.BackColor = System.Drawing.Color.LimeGreen;
      this.curTasksSaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.curTasksSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.curTasksSaveButton.Location = new System.Drawing.Point(714, 428);
      this.curTasksSaveButton.Name = "curTasksSaveButton";
      this.curTasksSaveButton.Size = new System.Drawing.Size(319, 29);
      this.curTasksSaveButton.TabIndex = 8;
      this.curTasksSaveButton.Text = "Save Changes to: ";
      this.curTasksSaveButton.UseVisualStyleBackColor = false;
      this.curTasksSaveButton.Click += new System.EventHandler(this.curTasksSaveButton_Click);
      // 
      // curTasksRadio1
      // 
      this.curTasksRadio1.AutoSize = true;
      this.curTasksRadio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.curTasksRadio1.ForeColor = System.Drawing.Color.Snow;
      this.curTasksRadio1.Location = new System.Drawing.Point(6, 10);
      this.curTasksRadio1.Name = "curTasksRadio1";
      this.curTasksRadio1.Size = new System.Drawing.Size(78, 21);
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
      this.curTasksRadio2.Location = new System.Drawing.Point(91, 10);
      this.curTasksRadio2.Name = "curTasksRadio2";
      this.curTasksRadio2.Size = new System.Drawing.Size(75, 21);
      this.curTasksRadio2.TabIndex = 10;
      this.curTasksRadio2.TabStop = true;
      this.curTasksRadio2.Text = "TO-DO";
      this.curTasksRadio2.UseVisualStyleBackColor = true;
      this.curTasksRadio2.CheckedChanged += new System.EventHandler(this.curTasksRadio2_CheckedChanged_1);
      // 
      // curTasksRadio3
      // 
      this.curTasksRadio3.AutoSize = true;
      this.curTasksRadio3.ForeColor = System.Drawing.Color.Snow;
      this.curTasksRadio3.Location = new System.Drawing.Point(172, 10);
      this.curTasksRadio3.Name = "curTasksRadio3";
      this.curTasksRadio3.Size = new System.Drawing.Size(96, 21);
      this.curTasksRadio3.TabIndex = 11;
      this.curTasksRadio3.TabStop = true;
      this.curTasksRadio3.Text = "Completed";
      this.curTasksRadio3.UseVisualStyleBackColor = true;
      this.curTasksRadio3.CheckedChanged += new System.EventHandler(this.curTasksRadio3_CheckedChanged_1);
      // 
      // curTasksRadioGroup
      // 
      this.curTasksRadioGroup.BackColor = System.Drawing.Color.Transparent;
      this.curTasksRadioGroup.Controls.Add(this.curTasksRadio1);
      this.curTasksRadioGroup.Controls.Add(this.curTasksRadio3);
      this.curTasksRadioGroup.Controls.Add(this.curTasksRadio2);
      this.curTasksRadioGroup.Location = new System.Drawing.Point(151, 421);
      this.curTasksRadioGroup.Name = "curTasksRadioGroup";
      this.curTasksRadioGroup.Size = new System.Drawing.Size(274, 36);
      this.curTasksRadioGroup.TabIndex = 12;
      this.curTasksRadioGroup.TabStop = false;
      // 
      // curTaskDescLabel
      // 
      this.curTaskDescLabel.AutoSize = true;
      this.curTaskDescLabel.BackColor = System.Drawing.Color.Transparent;
      this.curTaskDescLabel.Font = new System.Drawing.Font("Microsoft YaHei", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.curTaskDescLabel.ForeColor = System.Drawing.Color.White;
      this.curTaskDescLabel.Location = new System.Drawing.Point(427, 400);
      this.curTaskDescLabel.Name = "curTaskDescLabel";
      this.curTaskDescLabel.Size = new System.Drawing.Size(269, 30);
      this.curTaskDescLabel.TabIndex = 13;
      this.curTaskDescLabel.Text = "↓ Set task description ↓";
      // 
      // createTaskButton
      // 
      this.createTaskButton.BackColor = System.Drawing.Color.GreenYellow;
      this.createTaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.createTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.createTaskButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
      this.createTaskButton.Location = new System.Drawing.Point(829, 12);
      this.createTaskButton.Name = "createTaskButton";
      this.createTaskButton.Size = new System.Drawing.Size(204, 88);
      this.createTaskButton.TabIndex = 15;
      this.createTaskButton.Text = "Create Task";
      this.createTaskButton.UseVisualStyleBackColor = false;
      this.createTaskButton.Click += new System.EventHandler(this.createTaskButton_Click);
      // 
      // listView1
      // 
      this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.listView1.Location = new System.Drawing.Point(12, 108);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(1021, 285);
      this.listView1.TabIndex = 0;
      this.listView1.UseCompatibleStateImageBehavior = false;
      this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
      this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
      // 
      // selectedIDLbl
      // 
      this.selectedIDLbl.AutoSize = true;
      this.selectedIDLbl.BackColor = System.Drawing.Color.YellowGreen;
      this.selectedIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.selectedIDLbl.Location = new System.Drawing.Point(12, 661);
      this.selectedIDLbl.Name = "selectedIDLbl";
      this.selectedIDLbl.Size = new System.Drawing.Size(150, 17);
      this.selectedIDLbl.TabIndex = 16;
      this.selectedIDLbl.Text = "Selected FORM ID: ";
      this.selectedIDLbl.Click += new System.EventHandler(this.label1_Click_1);
      // 
      // instructionsButton
      // 
      this.instructionsButton.BackColor = System.Drawing.Color.DarkGray;
      this.instructionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.instructionsButton.Location = new System.Drawing.Point(467, 62);
      this.instructionsButton.Name = "instructionsButton";
      this.instructionsButton.Size = new System.Drawing.Size(274, 38);
      this.instructionsButton.TabIndex = 17;
      this.instructionsButton.Text = "?      Click for Instructions      ?";
      this.instructionsButton.UseVisualStyleBackColor = false;
      this.instructionsButton.Click += new System.EventHandler(this.instructionsButton_Click);
      // 
      // setSprintNumBox
      // 
      this.setSprintNumBox.Location = new System.Drawing.Point(151, 400);
      this.setSprintNumBox.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
      this.setSprintNumBox.Name = "setSprintNumBox";
      this.setSprintNumBox.Size = new System.Drawing.Size(120, 22);
      this.setSprintNumBox.TabIndex = 18;
      // 
      // setSprintLbl
      // 
      this.setSprintLbl.AutoSize = true;
      this.setSprintLbl.BackColor = System.Drawing.Color.Transparent;
      this.setSprintLbl.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.setSprintLbl.ForeColor = System.Drawing.Color.White;
      this.setSprintLbl.Location = new System.Drawing.Point(7, 400);
      this.setSprintLbl.Name = "setSprintLbl";
      this.setSprintLbl.Size = new System.Drawing.Size(124, 19);
      this.setSprintLbl.TabIndex = 19;
      this.setSprintLbl.Text = "Set to Sprint #: ";
      // 
      // setImportanceLbl
      // 
      this.setImportanceLbl.AutoSize = true;
      this.setImportanceLbl.BackColor = System.Drawing.Color.Transparent;
      this.setImportanceLbl.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.setImportanceLbl.ForeColor = System.Drawing.Color.White;
      this.setImportanceLbl.Location = new System.Drawing.Point(7, 430);
      this.setImportanceLbl.Name = "setImportanceLbl";
      this.setImportanceLbl.Size = new System.Drawing.Size(133, 19);
      this.setImportanceLbl.TabIndex = 20;
      this.setImportanceLbl.Text = "Set Importance: ";
      // 
      // testLabel
      // 
      this.testLabel.AutoSize = true;
      this.testLabel.BackColor = System.Drawing.Color.Transparent;
      this.testLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.testLabel.ForeColor = System.Drawing.Color.White;
      this.testLabel.Location = new System.Drawing.Point(267, 79);
      this.testLabel.Name = "testLabel";
      this.testLabel.Size = new System.Drawing.Size(146, 24);
      this.testLabel.TabIndex = 21;
      this.testLabel.Text = "(Select an Item)";
      // 
      // sortByUpOrDown
      // 
      this.sortByUpOrDown.AutoSize = true;
      this.sortByUpOrDown.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.sortByUpOrDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.sortByUpOrDown.Location = new System.Drawing.Point(1000, 112);
      this.sortByUpOrDown.Name = "sortByUpOrDown";
      this.sortByUpOrDown.Size = new System.Drawing.Size(19, 20);
      this.sortByUpOrDown.TabIndex = 22;
      this.sortByUpOrDown.Text = "↓";
      // 
      // TaskForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1045, 690);
      this.Controls.Add(this.sortByUpOrDown);
      this.Controls.Add(this.testLabel);
      this.Controls.Add(this.setImportanceLbl);
      this.Controls.Add(this.setSprintLbl);
      this.Controls.Add(this.setSprintNumBox);
      this.Controls.Add(this.instructionsButton);
      this.Controls.Add(this.selectedIDLbl);
      this.Controls.Add(this.listView1);
      this.Controls.Add(this.createTaskButton);
      this.Controls.Add(this.curTaskDescLabel);
      this.Controls.Add(this.curTasksRadioGroup);
      this.Controls.Add(this.curTasksSaveButton);
      this.Controls.Add(this.curTaskDescriptions);
      this.Controls.Add(this.curTasksSortLabel);
      this.Controls.Add(this.curTasksComboBox);
      this.Controls.Add(this.curTasksLabel);
      this.Controls.Add(this.backButton);
      this.Controls.Add(this.taskFormLabel);
      this.Name = "TaskForm";
      this.Text = "Agile Development Tools Suite";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskForm_FormClosing);
      this.Load += new System.EventHandler(this.TaskForm_Load);
      this.curTasksRadioGroup.ResumeLayout(false);
      this.curTasksRadioGroup.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.setSprintNumBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label taskFormLabel;
    private System.Windows.Forms.Button backButton;
    private System.Windows.Forms.Label curTasksLabel;
    private System.Windows.Forms.ComboBox curTasksComboBox;
    private System.Windows.Forms.Label curTasksSortLabel;
    private System.Windows.Forms.RichTextBox curTaskDescriptions;
    private System.Windows.Forms.Button curTasksSaveButton;
    private System.Windows.Forms.RadioButton curTasksRadio1;
    private System.Windows.Forms.RadioButton curTasksRadio2;
    private System.Windows.Forms.RadioButton curTasksRadio3;
    private System.Windows.Forms.GroupBox curTasksRadioGroup;
    private System.Windows.Forms.Label curTaskDescLabel;
    private System.Windows.Forms.Button createTaskButton;
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.Label selectedIDLbl;
    private System.Windows.Forms.Button instructionsButton;
    private System.Windows.Forms.NumericUpDown setSprintNumBox;
    private System.Windows.Forms.Label setSprintLbl;
    private System.Windows.Forms.Label setImportanceLbl;
    private System.Windows.Forms.Label testLabel;
    private System.Windows.Forms.Label sortByUpOrDown;
  }
}