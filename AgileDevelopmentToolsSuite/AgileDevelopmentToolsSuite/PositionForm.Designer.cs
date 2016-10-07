namespace AgileDevelopmentToolsSuite
{
    partial class PositionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PositionForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.positionBox = new System.Windows.Forms.ComboBox();
            this.positionQuestionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox1.Location = new System.Drawing.Point(247, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 44);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.positionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLabel.ForeColor = System.Drawing.Color.White;
            this.positionLabel.Location = new System.Drawing.Point(261, 210);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(78, 20);
            this.positionLabel.TabIndex = 11;
            this.positionLabel.Text = "Position:";
            // 
            // positionBox
            // 
            this.positionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionBox.FormattingEnabled = true;
            this.positionBox.Items.AddRange(new object[] {
            "Developer",
            "Project Manager"});
            this.positionBox.Location = new System.Drawing.Point(345, 210);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(187, 21);
            this.positionBox.TabIndex = 12;
            this.positionBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // positionQuestionLabel
            // 
            this.positionQuestionLabel.AutoSize = true;
            this.positionQuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.positionQuestionLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionQuestionLabel.ForeColor = System.Drawing.Color.White;
            this.positionQuestionLabel.Location = new System.Drawing.Point(158, 149);
            this.positionQuestionLabel.Name = "positionQuestionLabel";
            this.positionQuestionLabel.Size = new System.Drawing.Size(481, 29);
            this.positionQuestionLabel.TabIndex = 13;
            this.positionQuestionLabel.Text = "What position are you creating an account for?";
            // 
            // PositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.positionQuestionLabel);
            this.Controls.Add(this.positionBox);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PositionForm";
            this.Text = "Agile Development Tools Suite";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.ComboBox positionBox;
        private System.Windows.Forms.Label positionQuestionLabel;
    }
}