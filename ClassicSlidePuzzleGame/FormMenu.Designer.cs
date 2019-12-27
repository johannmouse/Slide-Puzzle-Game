namespace ClassicSlidePuzzleGame
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.buttonEasy = new System.Windows.Forms.Button();
            this.buttonMedium = new System.Windows.Forms.Button();
            this.buttonHard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEasy
            // 
            this.buttonEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEasy.Location = new System.Drawing.Point(186, 163);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(100, 30);
            this.buttonEasy.TabIndex = 0;
            this.buttonEasy.Text = "Easy";
            this.buttonEasy.UseVisualStyleBackColor = true;
            this.buttonEasy.Click += new System.EventHandler(this.ButtonEasy_Click);
            // 
            // buttonMedium
            // 
            this.buttonMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMedium.Location = new System.Drawing.Point(186, 225);
            this.buttonMedium.Name = "buttonMedium";
            this.buttonMedium.Size = new System.Drawing.Size(100, 30);
            this.buttonMedium.TabIndex = 1;
            this.buttonMedium.Text = "Medium";
            this.buttonMedium.UseVisualStyleBackColor = true;
            this.buttonMedium.Click += new System.EventHandler(this.ButtonMedium_Click);
            // 
            // buttonHard
            // 
            this.buttonHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHard.Location = new System.Drawing.Point(186, 285);
            this.buttonHard.Name = "buttonHard";
            this.buttonHard.Size = new System.Drawing.Size(100, 30);
            this.buttonHard.TabIndex = 2;
            this.buttonHard.Text = "Hard";
            this.buttonHard.UseVisualStyleBackColor = true;
            this.buttonHard.Click += new System.EventHandler(this.ButtonHard_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.buttonHard);
            this.Controls.Add(this.buttonMedium);
            this.Controls.Add(this.buttonEasy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.Text = "Game Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEasy;
        private System.Windows.Forms.Button buttonMedium;
        private System.Windows.Forms.Button buttonHard;
    }
}