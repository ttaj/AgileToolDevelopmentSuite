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
            this.pictureBox1.Location = new System.Drawing.Point(65, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(661, 431);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // skillsetHeaderLabel
            // 
            this.skillsetHeaderLabel.AutoSize = true;
            this.skillsetHeaderLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.skillsetHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillsetHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.skillsetHeaderLabel.Location = new System.Drawing.Point(257, 106);
            this.skillsetHeaderLabel.Name = "skillsetHeaderLabel";
            this.skillsetHeaderLabel.Size = new System.Drawing.Size(286, 20);
            this.skillsetHeaderLabel.TabIndex = 13;
            this.skillsetHeaderLabel.Text = "Enter Your Skillset and Proficiency";
            // 
            // skillLabel
            // 
            this.skillLabel.AutoSize = true;
            this.skillLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.skillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillLabel.ForeColor = System.Drawing.Color.White;
            this.skillLabel.Location = new System.Drawing.Point(163, 135);
            this.skillLabel.Name = "skillLabel";
            this.skillLabel.Size = new System.Drawing.Size(51, 20);
            this.skillLabel.TabIndex = 14;
            this.skillLabel.Text = "Skills";
            // 
            // proficiencyLabel
            // 
            this.proficiencyLabel.AutoSize = true;
            this.proficiencyLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.proficiencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proficiencyLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.proficiencyLabel.Location = new System.Drawing.Point(539, 135);
            this.proficiencyLabel.Name = "proficiencyLabel";
            this.proficiencyLabel.Size = new System.Drawing.Size(92, 20);
            this.proficiencyLabel.TabIndex = 15;
            this.proficiencyLabel.Text = "Proficency";
            // 
            // skillSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.proficiencyLabel);
            this.Controls.Add(this.skillLabel);
            this.Controls.Add(this.skillsetHeaderLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "skillSetForm";
            this.Text = "skillSetForm";
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