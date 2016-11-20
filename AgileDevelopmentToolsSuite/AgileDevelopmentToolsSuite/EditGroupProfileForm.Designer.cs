namespace AgileDevelopmentToolsSuite
{
    partial class EditGroupProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGroupProfileForm));
            this.saveButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DarkGray;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(531, 25);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 25);
            this.saveButton.TabIndex = 44;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.DarkGray;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Location = new System.Drawing.Point(655, 25);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(117, 25);
            this.menuButton.TabIndex = 45;
            this.menuButton.Text = "Back To Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // EditGroupProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.saveButton);
            this.Name = "EditGroupProfileForm";
            this.Text = "Agile Development Tools Suite";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button menuButton;
    }
}