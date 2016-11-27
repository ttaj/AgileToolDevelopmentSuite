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
            this.curTasksComboBox = new System.Windows.Forms.ComboBox();
            this.curTasksSortLabel = new System.Windows.Forms.Label();
            this.curTaskDescriptions = new System.Windows.Forms.RichTextBox();
            this.curTasksSaveButton = new System.Windows.Forms.Button();
            this.curTasksRadio1 = new System.Windows.Forms.RadioButton();
            this.curTasksRadio2 = new System.Windows.Forms.RadioButton();
            this.curTasksRadio3 = new System.Windows.Forms.RadioButton();
            this.curTasksRadioGroup = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.selectedIDLbl = new System.Windows.Forms.Label();
            this.setSprintNumBox = new System.Windows.Forms.NumericUpDown();
            this.setSprintLbl = new System.Windows.Forms.Label();
            this.setImportanceLbl = new System.Windows.Forms.Label();
            this.sortByUpOrDown = new System.Windows.Forms.Label();
            this.createTaskButton = new System.Windows.Forms.Button();
            this.instructionsButton = new System.Windows.Forms.Button();
            this.curTaskDescLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.curTasksLabel = new System.Windows.Forms.Label();
            this.testLabel = new System.Windows.Forms.Label();
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
            this.taskFormLabel.Location = new System.Drawing.Point(206, 10);
            this.taskFormLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taskFormLabel.Name = "taskFormLabel";
            this.taskFormLabel.Size = new System.Drawing.Size(325, 30);
            this.taskFormLabel.TabIndex = 1;
            this.taskFormLabel.Text = "List of Current Project Tasks";
            this.taskFormLabel.UseWaitCursor = true;
            this.taskFormLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // curTasksComboBox
            // 
            this.curTasksComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.curTasksComboBox.FormattingEnabled = true;
            this.curTasksComboBox.Items.AddRange(new object[] {
            "(Show All Tasks)",
            "(Show Non-Sprints)"});
            this.curTasksComboBox.Location = new System.Drawing.Point(206, 62);
            this.curTasksComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.curTasksComboBox.MaxDropDownItems = 99;
            this.curTasksComboBox.Name = "curTasksComboBox";
            this.curTasksComboBox.Size = new System.Drawing.Size(102, 21);
            this.curTasksComboBox.TabIndex = 4;
            this.curTasksComboBox.SelectedIndexChanged += new System.EventHandler(this.curTasksComboBox_SelectedIndexChanged);
            // 
            // curTasksSortLabel
            // 
            this.curTasksSortLabel.AutoSize = true;
            this.curTasksSortLabel.BackColor = System.Drawing.Color.Transparent;
            this.curTasksSortLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curTasksSortLabel.ForeColor = System.Drawing.Color.White;
            this.curTasksSortLabel.Location = new System.Drawing.Point(135, 63);
            this.curTasksSortLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.curTasksSortLabel.Name = "curTasksSortLabel";
            this.curTasksSortLabel.Size = new System.Drawing.Size(68, 19);
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
            this.curTaskDescriptions.Location = new System.Drawing.Point(9, 374);
            this.curTaskDescriptions.Margin = new System.Windows.Forms.Padding(2);
            this.curTaskDescriptions.Name = "curTaskDescriptions";
            this.curTaskDescriptions.Size = new System.Drawing.Size(766, 177);
            this.curTaskDescriptions.TabIndex = 6;
            this.curTaskDescriptions.Text = "";
            this.curTaskDescriptions.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // curTasksSaveButton
            // 
            this.curTasksSaveButton.BackColor = System.Drawing.Color.LimeGreen;
            this.curTasksSaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.curTasksSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curTasksSaveButton.ForeColor = System.Drawing.Color.White;
            this.curTasksSaveButton.Location = new System.Drawing.Point(536, 348);
            this.curTasksSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.curTasksSaveButton.Name = "curTasksSaveButton";
            this.curTasksSaveButton.Size = new System.Drawing.Size(239, 24);
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
            this.curTasksRadio2.Location = new System.Drawing.Point(68, 8);
            this.curTasksRadio2.Margin = new System.Windows.Forms.Padding(2);
            this.curTasksRadio2.Name = "curTasksRadio2";
            this.curTasksRadio2.Size = new System.Drawing.Size(59, 17);
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
            this.curTasksRadio3.Location = new System.Drawing.Point(129, 8);
            this.curTasksRadio3.Margin = new System.Windows.Forms.Padding(2);
            this.curTasksRadio3.Name = "curTasksRadio3";
            this.curTasksRadio3.Size = new System.Drawing.Size(75, 17);
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
            this.curTasksRadioGroup.Location = new System.Drawing.Point(113, 342);
            this.curTasksRadioGroup.Margin = new System.Windows.Forms.Padding(2);
            this.curTasksRadioGroup.Name = "curTasksRadioGroup";
            this.curTasksRadioGroup.Padding = new System.Windows.Forms.Padding(2);
            this.curTasksRadioGroup.Size = new System.Drawing.Size(206, 29);
            this.curTasksRadioGroup.TabIndex = 12;
            this.curTasksRadioGroup.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.Location = new System.Drawing.Point(9, 88);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(767, 232);
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
            this.selectedIDLbl.Location = new System.Drawing.Point(9, 537);
            this.selectedIDLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedIDLbl.Name = "selectedIDLbl";
            this.selectedIDLbl.Size = new System.Drawing.Size(121, 13);
            this.selectedIDLbl.TabIndex = 16;
            this.selectedIDLbl.Text = "Selected FORM ID: ";
            this.selectedIDLbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // setSprintNumBox
            // 
            this.setSprintNumBox.Location = new System.Drawing.Point(113, 325);
            this.setSprintNumBox.Margin = new System.Windows.Forms.Padding(2);
            this.setSprintNumBox.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.setSprintNumBox.Name = "setSprintNumBox";
            this.setSprintNumBox.Size = new System.Drawing.Size(90, 20);
            this.setSprintNumBox.TabIndex = 18;
            // 
            // setSprintLbl
            // 
            this.setSprintLbl.AutoSize = true;
            this.setSprintLbl.BackColor = System.Drawing.Color.Transparent;
            this.setSprintLbl.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setSprintLbl.ForeColor = System.Drawing.Color.White;
            this.setSprintLbl.Location = new System.Drawing.Point(5, 325);
            this.setSprintLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.setSprintLbl.Name = "setSprintLbl";
            this.setSprintLbl.Size = new System.Drawing.Size(104, 17);
            this.setSprintLbl.TabIndex = 19;
            this.setSprintLbl.Text = "Set to Sprint #: ";
            // 
            // setImportanceLbl
            // 
            this.setImportanceLbl.AutoSize = true;
            this.setImportanceLbl.BackColor = System.Drawing.Color.Transparent;
            this.setImportanceLbl.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setImportanceLbl.ForeColor = System.Drawing.Color.White;
            this.setImportanceLbl.Location = new System.Drawing.Point(5, 349);
            this.setImportanceLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.setImportanceLbl.Name = "setImportanceLbl";
            this.setImportanceLbl.Size = new System.Drawing.Size(108, 17);
            this.setImportanceLbl.TabIndex = 20;
            this.setImportanceLbl.Text = "Set Importance: ";
            // 
            // sortByUpOrDown
            // 
            this.sortByUpOrDown.AutoSize = true;
            this.sortByUpOrDown.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sortByUpOrDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByUpOrDown.Location = new System.Drawing.Point(750, 91);
            this.sortByUpOrDown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sortByUpOrDown.Name = "sortByUpOrDown";
            this.sortByUpOrDown.Size = new System.Drawing.Size(16, 17);
            this.sortByUpOrDown.TabIndex = 22;
            this.sortByUpOrDown.Text = "↓";
            // 
            // createTaskButton
            // 
            this.createTaskButton.BackColor = System.Drawing.Color.DarkGray;
            this.createTaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTaskButton.ForeColor = System.Drawing.Color.White;
            this.createTaskButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.createTaskButton.Location = new System.Drawing.Point(622, 50);
            this.createTaskButton.Margin = new System.Windows.Forms.Padding(2);
            this.createTaskButton.Name = "createTaskButton";
            this.createTaskButton.Size = new System.Drawing.Size(153, 32);
            this.createTaskButton.TabIndex = 23;
            this.createTaskButton.Text = "Create Task";
            this.createTaskButton.UseVisualStyleBackColor = false;
            this.createTaskButton.Click += new System.EventHandler(this.createTaskButton_Click_1);
            // 
            // instructionsButton
            // 
            this.instructionsButton.BackColor = System.Drawing.Color.DarkGray;
            this.instructionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsButton.ForeColor = System.Drawing.Color.White;
            this.instructionsButton.Location = new System.Drawing.Point(453, 50);
            this.instructionsButton.Margin = new System.Windows.Forms.Padding(2);
            this.instructionsButton.Name = "instructionsButton";
            this.instructionsButton.Size = new System.Drawing.Size(165, 31);
            this.instructionsButton.TabIndex = 24;
            this.instructionsButton.Text = "?  Click for Instructions  ?";
            this.instructionsButton.UseVisualStyleBackColor = false;
            // 
            // curTaskDescLabel
            // 
            this.curTaskDescLabel.AutoSize = true;
            this.curTaskDescLabel.BackColor = System.Drawing.Color.Transparent;
            this.curTaskDescLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curTaskDescLabel.ForeColor = System.Drawing.Color.White;
            this.curTaskDescLabel.Location = new System.Drawing.Point(323, 350);
            this.curTaskDescLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.curTaskDescLabel.Name = "curTaskDescLabel";
            this.curTaskDescLabel.Size = new System.Drawing.Size(210, 19);
            this.curTaskDescLabel.TabIndex = 25;
            this.curTaskDescLabel.Text = "↓ Modify task description ↓";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DarkGray;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(9, 10);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.backButton.Size = new System.Drawing.Size(127, 28);
            this.backButton.TabIndex = 26;
            this.backButton.Text = "Back to Menu";
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // curTasksLabel
            // 
            this.curTasksLabel.AutoSize = true;
            this.curTasksLabel.BackColor = System.Drawing.Color.Transparent;
            this.curTasksLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curTasksLabel.ForeColor = System.Drawing.Color.White;
            this.curTasksLabel.Location = new System.Drawing.Point(10, 59);
            this.curTasksLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.curTasksLabel.Name = "curTasksLabel";
            this.curTasksLabel.Size = new System.Drawing.Size(121, 22);
            this.curTasksLabel.TabIndex = 27;
            this.curTasksLabel.Text = "Current Tasks";
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.BackColor = System.Drawing.Color.Transparent;
            this.testLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLabel.ForeColor = System.Drawing.Color.White;
            this.testLabel.Location = new System.Drawing.Point(312, 62);
            this.testLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(118, 19);
            this.testLabel.TabIndex = 28;
            this.testLabel.Text = "(Select an Item)";
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.curTasksLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.curTaskDescLabel);
            this.Controls.Add(this.instructionsButton);
            this.Controls.Add(this.createTaskButton);
            this.Controls.Add(this.sortByUpOrDown);
            this.Controls.Add(this.setImportanceLbl);
            this.Controls.Add(this.setSprintLbl);
            this.Controls.Add(this.setSprintNumBox);
            this.Controls.Add(this.selectedIDLbl);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.curTasksRadioGroup);
            this.Controls.Add(this.curTasksSaveButton);
            this.Controls.Add(this.curTaskDescriptions);
            this.Controls.Add(this.curTasksSortLabel);
            this.Controls.Add(this.curTasksComboBox);
            this.Controls.Add(this.taskFormLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    private System.Windows.Forms.ComboBox curTasksComboBox;
    private System.Windows.Forms.Label curTasksSortLabel;
    private System.Windows.Forms.RichTextBox curTaskDescriptions;
    private System.Windows.Forms.Button curTasksSaveButton;
    private System.Windows.Forms.RadioButton curTasksRadio1;
    private System.Windows.Forms.RadioButton curTasksRadio2;
    private System.Windows.Forms.RadioButton curTasksRadio3;
    private System.Windows.Forms.GroupBox curTasksRadioGroup;
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.Label selectedIDLbl;
    private System.Windows.Forms.NumericUpDown setSprintNumBox;
    private System.Windows.Forms.Label setSprintLbl;
    private System.Windows.Forms.Label setImportanceLbl;
    private System.Windows.Forms.Label sortByUpOrDown;
        private System.Windows.Forms.Button createTaskButton;
        private System.Windows.Forms.Button instructionsButton;
        private System.Windows.Forms.Label curTaskDescLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label curTasksLabel;
        private System.Windows.Forms.Label testLabel;
    }
}