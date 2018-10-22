namespace SoundOffDrill.GUI
{
    partial class DrillSettingsForm
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
            this.cardsListBox = new System.Windows.Forms.ListBox();
            this.cardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cardsListBox
            // 
            this.cardsListBox.DisplayMember = "Sound";
            this.cardsListBox.FormattingEnabled = true;
            this.cardsListBox.Location = new System.Drawing.Point(12, 38);
            this.cardsListBox.Name = "cardsListBox";
            this.cardsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.cardsListBox.Size = new System.Drawing.Size(95, 277);
            this.cardsListBox.TabIndex = 1;
            // 
            // cardBindingSource
            // 
            this.cardBindingSource.DataSource = typeof(SoundOffDrill.Biz.Card);
            // 
            // DrillSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 327);
            this.Controls.Add(this.cardsListBox);
            this.Name = "DrillSettingsForm";
            this.Text = "Drill Settings";
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource cardBindingSource;
        private System.Windows.Forms.ListBox cardsListBox;
    }
}