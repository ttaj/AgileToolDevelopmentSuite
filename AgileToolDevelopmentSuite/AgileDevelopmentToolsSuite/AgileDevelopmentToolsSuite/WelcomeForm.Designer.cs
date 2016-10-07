namespace AgileDevelopmentToolsSuite
{
    partial class WelcomeForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
      this.welcomeLabel = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.startButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // welcomeLabel
      // 
      this.welcomeLabel.AutoSize = true;
      this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
      this.welcomeLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.welcomeLabel.ForeColor = System.Drawing.Color.White;
      this.welcomeLabel.Location = new System.Drawing.Point(413, 25);
      this.welcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.welcomeLabel.Name = "welcomeLabel";
      this.welcomeLabel.Size = new System.Drawing.Size(214, 37);
      this.welcomeLabel.TabIndex = 0;
      this.welcomeLabel.Text = "Welcome to the";
      this.welcomeLabel.Click += new System.EventHandler(this.welcomeLabel_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(280, 105);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(479, 37);
      this.label1.TabIndex = 1;
      this.label1.Text = "Click the button below to get started.";
      // 
      // startButton
      // 
      this.startButton.BackColor = System.Drawing.Color.Gray;
      this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.startButton.ForeColor = System.Drawing.Color.White;
      this.startButton.Location = new System.Drawing.Point(489, 258);
      this.startButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.startButton.Name = "startButton";
      this.startButton.Size = new System.Drawing.Size(125, 37);
      this.startButton.TabIndex = 2;
      this.startButton.Text = "Start";
      this.startButton.UseVisualStyleBackColor = false;
      this.startButton.Click += new System.EventHandler(this.startButton_Click);
      // 
      // WelcomeForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1045, 690);
      this.Controls.Add(this.startButton);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.welcomeLabel);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "WelcomeForm";
      this.Text = "Agile Development Tools Suite";
      this.Load += new System.EventHandler(this.WelcomeForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
    }
}