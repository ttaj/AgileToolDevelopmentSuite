namespace AgileDevelopmentToolsSuite
{
    partial class SkillSetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkillSetForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.skillsetHeaderLabel = new System.Windows.Forms.Label();
            this.skillLabel = new System.Windows.Forms.Label();
            this.proficiencyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox1.Location = new System.Drawing.Point(87, 117);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(881, 530);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // skillsetHeaderLabel
            // 
            this.skillsetHeaderLabel.AutoSize = true;
            this.skillsetHeaderLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.skillsetHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillsetHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.skillsetHeaderLabel.Location = new System.Drawing.Point(343, 130);
            this.skillsetHeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skillsetHeaderLabel.Name = "skillsetHeaderLabel";
            this.skillsetHeaderLabel.Size = new System.Drawing.Size(344, 25);
            this.skillsetHeaderLabel.TabIndex = 13;
            this.skillsetHeaderLabel.Text = "Enter Your Skillset and Proficiency";
            // 
            // skillLabel
            // 
            this.skillLabel.AutoSize = true;
            this.skillLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.skillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillLabel.ForeColor = System.Drawing.Color.White;
            this.skillLabel.Location = new System.Drawing.Point(217, 166);
            this.skillLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skillLabel.Name = "skillLabel";
            this.skillLabel.Size = new System.Drawing.Size(64, 25);
            this.skillLabel.TabIndex = 14;
            this.skillLabel.Text = "Skills";
            // 
            // proficiencyLabel
            // 
            this.proficiencyLabel.AutoSize = true;
            this.proficiencyLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.proficiencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proficiencyLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.proficiencyLabel.Location = new System.Drawing.Point(719, 166);
            this.proficiencyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.proficiencyLabel.Name = "proficiencyLabel";
            this.proficiencyLabel.Size = new System.Drawing.Size(113, 25);
            this.proficiencyLabel.TabIndex = 15;
            this.proficiencyLabel.Text = "Proficency";
            // 
            // SkillSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.proficiencyLabel);
            this.Controls.Add(this.skillLabel);
            this.Controls.Add(this.skillsetHeaderLabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SkillSetForm";
            this.Text = "skillSetForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SkillSetForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label skillsetHeaderLabel;
        private System.Windows.Forms.Label skillLabel;
        private System.Windows.Forms.Label proficiencyLabel;
    }
}