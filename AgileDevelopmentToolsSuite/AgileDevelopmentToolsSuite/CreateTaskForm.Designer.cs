namespace AgileDevelopmentToolsSuite
{
  partial class CreateTaskForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTaskForm));
      this.submitButton = new System.Windows.Forms.Button();
      this.taskNameLbl = new System.Windows.Forms.Label();
      this.importanceLbl = new System.Windows.Forms.Label();
      this.taskDescriptionLbl = new System.Windows.Forms.Label();
      this.taskNameTxtBox = new System.Windows.Forms.TextBox();
      this.curTasksRadioGroup = new System.Windows.Forms.GroupBox();
      this.curTasksRadio1 = new System.Windows.Forms.RadioButton();
      this.curTasksRadio3 = new System.Windows.Forms.RadioButton();
      this.curTasksRadio2 = new System.Windows.Forms.RadioButton();
      this.taskDescTxtBox = new System.Windows.Forms.RichTextBox();
      this.userDesigLbl = new System.Windows.Forms.Label();
      this.userDesigTxtBox = new System.Windows.Forms.TextBox();
      this.projectGroupLbl = new System.Windows.Forms.Label();
      this.projectGroupTxt = new System.Windows.Forms.TextBox();
      this.curTasksRadioGroup.SuspendLayout();
      this.SuspendLayout();
      // 
      // submitButton
      // 
      this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.submitButton.Location = new System.Drawing.Point(251, 478);
      this.submitButton.Name = "submitButton";
      this.submitButton.Size = new System.Drawing.Size(226, 42);
      this.submitButton.TabIndex = 5;
      this.submitButton.Text = "Submit";
      this.submitButton.UseVisualStyleBackColor = true;
      this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
      // 
      // taskNameLbl
      // 
      this.taskNameLbl.AutoSize = true;
      this.taskNameLbl.BackColor = System.Drawing.Color.Transparent;
      this.taskNameLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.taskNameLbl.ForeColor = System.Drawing.Color.White;
      this.taskNameLbl.Location = new System.Drawing.Point(14, 100);
      this.taskNameLbl.Name = "taskNameLbl";
      this.taskNameLbl.Size = new System.Drawing.Size(110, 24);
      this.taskNameLbl.TabIndex = 1;
      this.taskNameLbl.Text = "Task Name:";
      // 
      // importanceLbl
      // 
      this.importanceLbl.AutoSize = true;
      this.importanceLbl.BackColor = System.Drawing.Color.Transparent;
      this.importanceLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.importanceLbl.ForeColor = System.Drawing.Color.White;
      this.importanceLbl.Location = new System.Drawing.Point(14, 169);
      this.importanceLbl.Name = "importanceLbl";
      this.importanceLbl.Size = new System.Drawing.Size(114, 24);
      this.importanceLbl.TabIndex = 2;
      this.importanceLbl.Text = "Importance:";
      // 
      // taskDescriptionLbl
      // 
      this.taskDescriptionLbl.AutoSize = true;
      this.taskDescriptionLbl.BackColor = System.Drawing.Color.Transparent;
      this.taskDescriptionLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.taskDescriptionLbl.ForeColor = System.Drawing.Color.White;
      this.taskDescriptionLbl.Location = new System.Drawing.Point(12, 264);
      this.taskDescriptionLbl.Name = "taskDescriptionLbl";
      this.taskDescriptionLbl.Size = new System.Drawing.Size(156, 24);
      this.taskDescriptionLbl.TabIndex = 3;
      this.taskDescriptionLbl.Text = "Task Description:";
      // 
      // taskNameTxtBox
      // 
      this.taskNameTxtBox.Location = new System.Drawing.Point(198, 102);
      this.taskNameTxtBox.Name = "taskNameTxtBox";
      this.taskNameTxtBox.Size = new System.Drawing.Size(356, 22);
      this.taskNameTxtBox.TabIndex = 0;
      this.taskNameTxtBox.TextChanged += new System.EventHandler(this.taskNameTxtBox_TextChanged);
      // 
      // curTasksRadioGroup
      // 
      this.curTasksRadioGroup.BackColor = System.Drawing.Color.Transparent;
      this.curTasksRadioGroup.Controls.Add(this.curTasksRadio1);
      this.curTasksRadioGroup.Controls.Add(this.curTasksRadio3);
      this.curTasksRadioGroup.Controls.Add(this.curTasksRadio2);
      this.curTasksRadioGroup.Location = new System.Drawing.Point(134, 159);
      this.curTasksRadioGroup.Name = "curTasksRadioGroup";
      this.curTasksRadioGroup.Size = new System.Drawing.Size(274, 36);
      this.curTasksRadioGroup.TabIndex = 13;
      this.curTasksRadioGroup.TabStop = false;
      this.curTasksRadioGroup.Enter += new System.EventHandler(this.curTasksRadioGroup_Enter);
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
      this.curTasksRadio1.Text = "Urgent";
      this.curTasksRadio1.UseVisualStyleBackColor = true;
      this.curTasksRadio1.CheckedChanged += new System.EventHandler(this.curTasksRadio1_CheckedChanged);
      // 
      // curTasksRadio3
      // 
      this.curTasksRadio3.AutoSize = true;
      this.curTasksRadio3.ForeColor = System.Drawing.Color.Snow;
      this.curTasksRadio3.Location = new System.Drawing.Point(172, 10);
      this.curTasksRadio3.Name = "curTasksRadio3";
      this.curTasksRadio3.Size = new System.Drawing.Size(96, 21);
      this.curTasksRadio3.TabIndex = 11;
      this.curTasksRadio3.Text = "Completed";
      this.curTasksRadio3.UseVisualStyleBackColor = true;
      this.curTasksRadio3.CheckedChanged += new System.EventHandler(this.curTasksRadio3_CheckedChanged);
      // 
      // curTasksRadio2
      // 
      this.curTasksRadio2.AutoSize = true;
      this.curTasksRadio2.Checked = true;
      this.curTasksRadio2.ForeColor = System.Drawing.Color.Snow;
      this.curTasksRadio2.Location = new System.Drawing.Point(91, 10);
      this.curTasksRadio2.Name = "curTasksRadio2";
      this.curTasksRadio2.Size = new System.Drawing.Size(75, 21);
      this.curTasksRadio2.TabIndex = 2;
      this.curTasksRadio2.TabStop = true;
      this.curTasksRadio2.Text = "TO-DO";
      this.curTasksRadio2.UseVisualStyleBackColor = true;
      this.curTasksRadio2.CheckedChanged += new System.EventHandler(this.curTasksRadio2_CheckedChanged);
      // 
      // taskDescTxtBox
      // 
      this.taskDescTxtBox.Location = new System.Drawing.Point(134, 291);
      this.taskDescTxtBox.Name = "taskDescTxtBox";
      this.taskDescTxtBox.Size = new System.Drawing.Size(551, 166);
      this.taskDescTxtBox.TabIndex = 4;
      this.taskDescTxtBox.Text = "(Insert Description)";
      this.taskDescTxtBox.TextChanged += new System.EventHandler(this.taskDescTxtBox_TextChanged);
      // 
      // userDesigLbl
      // 
      this.userDesigLbl.AutoSize = true;
      this.userDesigLbl.BackColor = System.Drawing.Color.Transparent;
      this.userDesigLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.userDesigLbl.ForeColor = System.Drawing.Color.White;
      this.userDesigLbl.Location = new System.Drawing.Point(14, 217);
      this.userDesigLbl.Name = "userDesigLbl";
      this.userDesigLbl.Size = new System.Drawing.Size(160, 24);
      this.userDesigLbl.TabIndex = 15;
      this.userDesigLbl.Text = "User Designation:";
      // 
      // userDesigTxtBox
      // 
      this.userDesigTxtBox.Location = new System.Drawing.Point(198, 219);
      this.userDesigTxtBox.Name = "userDesigTxtBox";
      this.userDesigTxtBox.Size = new System.Drawing.Size(356, 22);
      this.userDesigTxtBox.TabIndex = 3;
      // 
      // projectGroupLbl
      // 
      this.projectGroupLbl.AutoSize = true;
      this.projectGroupLbl.BackColor = System.Drawing.Color.Transparent;
      this.projectGroupLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.projectGroupLbl.ForeColor = System.Drawing.Color.White;
      this.projectGroupLbl.Location = new System.Drawing.Point(14, 133);
      this.projectGroupLbl.Name = "projectGroupLbl";
      this.projectGroupLbl.Size = new System.Drawing.Size(149, 24);
      this.projectGroupLbl.TabIndex = 17;
      this.projectGroupLbl.Text = "Project Group #:";
      // 
      // projectGroupTxt
      // 
      this.projectGroupTxt.Location = new System.Drawing.Point(198, 135);
      this.projectGroupTxt.Name = "projectGroupTxt";
      this.projectGroupTxt.Size = new System.Drawing.Size(102, 22);
      this.projectGroupTxt.TabIndex = 1;
      // 
      // CreateTaskForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(717, 532);
      this.Controls.Add(this.projectGroupTxt);
      this.Controls.Add(this.projectGroupLbl);
      this.Controls.Add(this.userDesigTxtBox);
      this.Controls.Add(this.userDesigLbl);
      this.Controls.Add(this.taskDescTxtBox);
      this.Controls.Add(this.curTasksRadioGroup);
      this.Controls.Add(this.taskNameTxtBox);
      this.Controls.Add(this.taskDescriptionLbl);
      this.Controls.Add(this.importanceLbl);
      this.Controls.Add(this.taskNameLbl);
      this.Controls.Add(this.submitButton);
      this.Name = "CreateTaskForm";
      this.Text = "CreateTaskForm";
      this.Load += new System.EventHandler(this.CreateTaskForm_Load);
      this.curTasksRadioGroup.ResumeLayout(false);
      this.curTasksRadioGroup.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button submitButton;
    private System.Windows.Forms.Label taskNameLbl;
    private System.Windows.Forms.Label importanceLbl;
    private System.Windows.Forms.Label taskDescriptionLbl;
    private System.Windows.Forms.TextBox taskNameTxtBox;
    private System.Windows.Forms.GroupBox curTasksRadioGroup;
    private System.Windows.Forms.RadioButton curTasksRadio1;
    private System.Windows.Forms.RadioButton curTasksRadio3;
    private System.Windows.Forms.RadioButton curTasksRadio2;
    private System.Windows.Forms.RichTextBox taskDescTxtBox;
    private System.Windows.Forms.Label userDesigLbl;
    private System.Windows.Forms.TextBox userDesigTxtBox;
    private System.Windows.Forms.Label projectGroupLbl;
    private System.Windows.Forms.TextBox projectGroupTxt;
  }
}