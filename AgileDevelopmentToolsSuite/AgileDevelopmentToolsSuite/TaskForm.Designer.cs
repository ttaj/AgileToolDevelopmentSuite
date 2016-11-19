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
            this.curTasksSaveButton = new System.Windows.Forms.Button();
            this.curTasksRadio1 = new System.Windows.Forms.RadioButton();
            this.curTasksRadio2 = new System.Windows.Forms.RadioButton();
            this.curTasksRadio3 = new System.Windows.Forms.RadioButton();
            this.curTasksRadioGroup = new System.Windows.Forms.GroupBox();
            this.curTaskDescLabel = new System.Windows.Forms.Label();
            this.createTaskButton = new System.Windows.Forms.Button();
            this.aDTSDLoginInfoDataSet = new AgileDevelopmentToolsSuite.ADTSDInfoDataSet();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasksTableAdapter = new AgileDevelopmentToolsSuite.ADTSDInfoDataSetTableAdapters.TasksTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.selectedIDLbl = new System.Windows.Forms.Label();
            this.instructionsButton = new System.Windows.Forms.Button();
            this.curTasksRadioGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDTSDLoginInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
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
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back to Menu";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
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
            "Task Name",
            "ID",
            "Date Modified",
            "User Assigned"});
            this.curTasksComboBox.Location = new System.Drawing.Point(206, 62);
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
            this.curTasksSortLabel.Location = new System.Drawing.Point(134, 62);
            this.curTasksSortLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.curTasksSortLabel.Name = "curTasksSortLabel";
            this.curTasksSortLabel.Size = new System.Drawing.Size(64, 19);
            this.curTasksSortLabel.TabIndex = 5;
            this.curTasksSortLabel.Text = "Sort By:";
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
            this.curTasksRadioGroup.Location = new System.Drawing.Point(18, 340);
            this.curTasksRadioGroup.Margin = new System.Windows.Forms.Padding(2);
            this.curTasksRadioGroup.Name = "curTasksRadioGroup";
            this.curTasksRadioGroup.Padding = new System.Windows.Forms.Padding(2);
            this.curTasksRadioGroup.Size = new System.Drawing.Size(206, 29);
            this.curTasksRadioGroup.TabIndex = 12;
            this.curTasksRadioGroup.TabStop = false;
            // 
            // curTaskDescLabel
            // 
            this.curTaskDescLabel.AutoSize = true;
            this.curTaskDescLabel.BackColor = System.Drawing.Color.Transparent;
            this.curTaskDescLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curTaskDescLabel.ForeColor = System.Drawing.Color.White;
            this.curTaskDescLabel.Location = new System.Drawing.Point(228, 348);
            this.curTaskDescLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.curTaskDescLabel.Name = "curTaskDescLabel";
            this.curTaskDescLabel.Size = new System.Drawing.Size(210, 19);
            this.curTaskDescLabel.TabIndex = 13;
            this.curTaskDescLabel.Text = "↓ Modify task description ↓";
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
            this.listView1.Location = new System.Drawing.Point(9, 88);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(767, 256);
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
            // instructionsButton
            // 
            this.instructionsButton.BackColor = System.Drawing.Color.DarkGray;
            this.instructionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsButton.ForeColor = System.Drawing.Color.White;
            this.instructionsButton.Location = new System.Drawing.Point(350, 50);
            this.instructionsButton.Margin = new System.Windows.Forms.Padding(2);
            this.instructionsButton.Name = "instructionsButton";
            this.instructionsButton.Size = new System.Drawing.Size(206, 31);
            this.instructionsButton.TabIndex = 17;
            this.instructionsButton.Text = "?      Click for Instructions      ?";
            this.instructionsButton.UseVisualStyleBackColor = false;
            this.instructionsButton.Click += new System.EventHandler(this.instructionsButton_Click);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TaskForm";
            this.Text = "Agile Development Tools Suite";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskForm_FormClosing);
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
    private System.Windows.Forms.Button curTasksSaveButton;
    private System.Windows.Forms.RadioButton curTasksRadio1;
    private System.Windows.Forms.RadioButton curTasksRadio2;
    private System.Windows.Forms.RadioButton curTasksRadio3;
    private System.Windows.Forms.GroupBox curTasksRadioGroup;
    private System.Windows.Forms.Label curTaskDescLabel;
    private System.Windows.Forms.Button createTaskButton;
    private ADTSDInfoDataSet aDTSDLoginInfoDataSet;
    private System.Windows.Forms.BindingSource tasksBindingSource;
    private ADTSDInfoDataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.Label selectedIDLbl;
    private System.Windows.Forms.Button instructionsButton;
  }
}