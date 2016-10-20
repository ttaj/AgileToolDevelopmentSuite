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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
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
      this.createTaskButton = new System.Windows.Forms.Button();
      this.aDTSDLoginInfoDataSet = new AgileDevelopmentToolsSuite.ADTSDLoginInfoDataSet();
      this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.tasksTableAdapter = new AgileDevelopmentToolsSuite.ADTSDLoginInfoDataSetTableAdapters.TasksTableAdapter();
      this.listView1 = new System.Windows.Forms.ListView();
      this.curTasksRadioGroup.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.aDTSDLoginInfoDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // taskFormLabel
      // 
      this.taskFormLabel.AutoSize = true;
      this.taskFormLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.taskFormLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.taskFormLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.taskFormLabel.Location = new System.Drawing.Point(321, 12);
      this.taskFormLabel.Name = "taskFormLabel";
      this.taskFormLabel.Size = new System.Drawing.Size(482, 35);
      this.taskFormLabel.TabIndex = 1;
      this.taskFormLabel.Text = "List of Current Project Tasks";
      this.taskFormLabel.UseWaitCursor = true;
      this.taskFormLabel.Click += new System.EventHandler(this.label1_Click);
      // 
      // backButton
      // 
      this.backButton.BackColor = System.Drawing.Color.DarkSeaGreen;
      this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.backButton.Location = new System.Drawing.Point(24, 12);
      this.backButton.Name = "backButton";
      this.backButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.backButton.Size = new System.Drawing.Size(120, 35);
      this.backButton.TabIndex = 2;
      this.backButton.Text = "Back to Menu";
      this.backButton.UseVisualStyleBackColor = false;
      this.backButton.Click += new System.EventHandler(this.backButton_Click);
      // 
      // curTasksLabel
      // 
      this.curTasksLabel.AutoSize = true;
      this.curTasksLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.curTasksLabel.Location = new System.Drawing.Point(13, 73);
      this.curTasksLabel.Name = "curTasksLabel";
      this.curTasksLabel.Size = new System.Drawing.Size(140, 27);
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
      this.curTasksComboBox.Location = new System.Drawing.Point(338, 78);
      this.curTasksComboBox.Name = "curTasksComboBox";
      this.curTasksComboBox.Size = new System.Drawing.Size(150, 24);
      this.curTasksComboBox.TabIndex = 4;
      this.curTasksComboBox.SelectedIndexChanged += new System.EventHandler(this.curTasksComboBox_SelectedIndexChanged);
      // 
      // curTasksSortLabel
      // 
      this.curTasksSortLabel.AutoSize = true;
      this.curTasksSortLabel.BackColor = System.Drawing.Color.Transparent;
      this.curTasksSortLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.curTasksSortLabel.ForeColor = System.Drawing.SystemColors.Control;
      this.curTasksSortLabel.Location = new System.Drawing.Point(255, 76);
      this.curTasksSortLabel.Name = "curTasksSortLabel";
      this.curTasksSortLabel.Size = new System.Drawing.Size(77, 24);
      this.curTasksSortLabel.TabIndex = 5;
      this.curTasksSortLabel.Text = "Sort By:";
      this.curTasksSortLabel.Click += new System.EventHandler(this.curTasksSortLabel_Click);
      // 
      // curTaskDescriptions
      // 
      this.curTaskDescriptions.BackColor = System.Drawing.Color.Gray;
      this.curTaskDescriptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.curTaskDescriptions.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.curTaskDescriptions.ForeColor = System.Drawing.Color.Snow;
      this.curTaskDescriptions.Location = new System.Drawing.Point(582, 123);
      this.curTaskDescriptions.Name = "curTaskDescriptions";
      this.curTaskDescriptions.Size = new System.Drawing.Size(451, 545);
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
      this.rightArrow.Location = new System.Drawing.Point(516, 386);
      this.rightArrow.Name = "rightArrow";
      this.rightArrow.Size = new System.Drawing.Size(60, 50);
      this.rightArrow.TabIndex = 7;
      this.rightArrow.Text = "→";
      this.rightArrow.Click += new System.EventHandler(this.rightArrow_Click);
      // 
      // curTasksSaveButton
      // 
      this.curTasksSaveButton.BackColor = System.Drawing.Color.LightGreen;
      this.curTasksSaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.curTasksSaveButton.Location = new System.Drawing.Point(871, 71);
      this.curTasksSaveButton.Name = "curTasksSaveButton";
      this.curTasksSaveButton.Size = new System.Drawing.Size(162, 29);
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
      // 
      // curTasksRadioGroup
      // 
      this.curTasksRadioGroup.BackColor = System.Drawing.Color.Transparent;
      this.curTasksRadioGroup.Controls.Add(this.curTasksRadio1);
      this.curTasksRadioGroup.Controls.Add(this.curTasksRadio3);
      this.curTasksRadioGroup.Controls.Add(this.curTasksRadio2);
      this.curTasksRadioGroup.Location = new System.Drawing.Point(555, 87);
      this.curTasksRadioGroup.Name = "curTasksRadioGroup";
      this.curTasksRadioGroup.Size = new System.Drawing.Size(274, 36);
      this.curTasksRadioGroup.TabIndex = 12;
      this.curTasksRadioGroup.TabStop = false;
      // 
      // curTaskDescLabel
      // 
      this.curTaskDescLabel.AutoSize = true;
      this.curTaskDescLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.curTaskDescLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.curTaskDescLabel.Location = new System.Drawing.Point(553, 58);
      this.curTaskDescLabel.Name = "curTaskDescLabel";
      this.curTaskDescLabel.Size = new System.Drawing.Size(241, 26);
      this.curTaskDescLabel.TabIndex = 13;
      this.curTaskDescLabel.Text = "Modify task description";
      // 
      // curTaskDescVScroll
      // 
      this.curTaskDescVScroll.Location = new System.Drawing.Point(1015, 123);
      this.curTaskDescVScroll.Name = "curTaskDescVScroll";
      this.curTaskDescVScroll.Size = new System.Drawing.Size(17, 548);
      this.curTaskDescVScroll.TabIndex = 14;
      // 
      // createTaskButton
      // 
      this.createTaskButton.BackColor = System.Drawing.Color.GreenYellow;
      this.createTaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.createTaskButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
      this.createTaskButton.Location = new System.Drawing.Point(871, 12);
      this.createTaskButton.Name = "createTaskButton";
      this.createTaskButton.Size = new System.Drawing.Size(162, 53);
      this.createTaskButton.TabIndex = 15;
      this.createTaskButton.Text = "Create Task";
      this.createTaskButton.UseVisualStyleBackColor = false;
      this.createTaskButton.Click += new System.EventHandler(this.createTaskButton_Click);
      // 
      // aDTSDLoginInfoDataSet
      // 
      this.aDTSDLoginInfoDataSet.DataSetName = "ADTSDLoginInfoDataSet";
      this.aDTSDLoginInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // tasksBindingSource
      // 
      this.tasksBindingSource.DataMember = "Tasks";
      this.tasksBindingSource.DataSource = this.aDTSDLoginInfoDataSet;
      // 
      // tasksTableAdapter
      // 
      this.tasksTableAdapter.ClearBeforeFill = true;
      // 
      // listView1
      // 
      this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.listView1.Location = new System.Drawing.Point(12, 123);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(498, 548);
      this.listView1.TabIndex = 0;
      this.listView1.UseCompatibleStateImageBehavior = false;
      this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
      // 
      // TaskForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1045, 690);
      this.Controls.Add(this.listView1);
      this.Controls.Add(this.createTaskButton);
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
      this.Name = "TaskForm";
      this.Text = "TaskForm";
      this.Load += new System.EventHandler(this.TaskForm_Load);
      this.curTasksRadioGroup.ResumeLayout(false);
      this.curTasksRadioGroup.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.aDTSDLoginInfoDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
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
    private System.Windows.Forms.Label rightArrow;
    private System.Windows.Forms.Button curTasksSaveButton;
    private System.Windows.Forms.RadioButton curTasksRadio1;
    private System.Windows.Forms.RadioButton curTasksRadio2;
    private System.Windows.Forms.RadioButton curTasksRadio3;
    private System.Windows.Forms.GroupBox curTasksRadioGroup;
    private System.Windows.Forms.Label curTaskDescLabel;
    private System.Windows.Forms.VScrollBar curTaskDescVScroll;
    private System.Windows.Forms.Button createTaskButton;
    private ADTSDLoginInfoDataSet aDTSDLoginInfoDataSet;
    private System.Windows.Forms.BindingSource tasksBindingSource;
    private ADTSDLoginInfoDataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
    private System.Windows.Forms.ListView listView1;
  }
}