namespace SoundOffDrill.GUI
{
    partial class DrillForm
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
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.nextWordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wordTextBox
            // 
            this.wordTextBox.Font = new System.Drawing.Font("OpenDyslexic 3", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordTextBox.Location = new System.Drawing.Point(12, 12);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(776, 198);
            this.wordTextBox.TabIndex = 1;
            this.wordTextBox.TabStop = false;
            this.wordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nextWordButton
            // 
            this.nextWordButton.Location = new System.Drawing.Point(362, 234);
            this.nextWordButton.Name = "nextWordButton";
            this.nextWordButton.Size = new System.Drawing.Size(75, 23);
            this.nextWordButton.TabIndex = 0;
            this.nextWordButton.Text = "&Next Word";
            this.nextWordButton.UseVisualStyleBackColor = true;
            this.nextWordButton.Click += new System.EventHandler(this.nextWordButton_Click);
            // 
            // DrillForm
            // 
            this.AcceptButton = this.nextWordButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 269);
            this.Controls.Add(this.nextWordButton);
            this.Controls.Add(this.wordTextBox);
            this.Name = "DrillForm";
            this.Text = "Drill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.Button nextWordButton;
    }
}