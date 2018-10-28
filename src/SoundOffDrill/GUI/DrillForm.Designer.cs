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
            this.prevWordButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.leftPrevCardButton = new System.Windows.Forms.Button();
            this.leftNextCardButton = new System.Windows.Forms.Button();
            this.centerPrevCardButton = new System.Windows.Forms.Button();
            this.centerNextCardButton = new System.Windows.Forms.Button();
            this.rightLeftCardButton = new System.Windows.Forms.Button();
            this.rightNextCardButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // wordTextBox
            // 
            this.wordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wordTextBox.Font = new System.Drawing.Font("OpenDyslexic 3", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordTextBox.Location = new System.Drawing.Point(3, 5);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(572, 198);
            this.wordTextBox.TabIndex = 1;
            this.wordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nextWordButton
            // 
            this.nextWordButton.Location = new System.Drawing.Point(439, 30);
            this.nextWordButton.Name = "nextWordButton";
            this.nextWordButton.Size = new System.Drawing.Size(75, 21);
            this.nextWordButton.TabIndex = 0;
            this.nextWordButton.Text = "&Next Word";
            this.nextWordButton.UseVisualStyleBackColor = true;
            this.nextWordButton.Click += new System.EventHandler(this.nextWordButton_Click);
            // 
            // prevWordButton
            // 
            this.prevWordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prevWordButton.Location = new System.Drawing.Point(58, 30);
            this.prevWordButton.Name = "prevWordButton";
            this.prevWordButton.Size = new System.Drawing.Size(75, 21);
            this.prevWordButton.TabIndex = 2;
            this.prevWordButton.Text = "&Prev Word";
            this.prevWordButton.UseVisualStyleBackColor = true;
            this.prevWordButton.Click += new System.EventHandler(this.prevWordButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.wordTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(578, 266);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.leftPrevCardButton, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.leftNextCardButton, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.prevWordButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.nextWordButton, 8, 1);
            this.tableLayoutPanel2.Controls.Add(this.centerPrevCardButton, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.centerNextCardButton, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.rightLeftCardButton, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.rightNextCardButton, 7, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 209);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(572, 54);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(139, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Left Card";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label2, 2);
            this.label2.Location = new System.Drawing.Point(239, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Center Card";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label3, 2);
            this.label3.Location = new System.Drawing.Point(339, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Right Card";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftPrevCardButton
            // 
            this.leftPrevCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftPrevCardButton.Location = new System.Drawing.Point(139, 30);
            this.leftPrevCardButton.Name = "leftPrevCardButton";
            this.leftPrevCardButton.Size = new System.Drawing.Size(44, 21);
            this.leftPrevCardButton.TabIndex = 6;
            this.leftPrevCardButton.Tag = "0";
            this.leftPrevCardButton.Text = "←";
            this.leftPrevCardButton.UseVisualStyleBackColor = true;
            this.leftPrevCardButton.Click += new System.EventHandler(this.PrevCard_Click);
            // 
            // leftNextCardButton
            // 
            this.leftNextCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftNextCardButton.Location = new System.Drawing.Point(189, 30);
            this.leftNextCardButton.Name = "leftNextCardButton";
            this.leftNextCardButton.Size = new System.Drawing.Size(44, 21);
            this.leftNextCardButton.TabIndex = 7;
            this.leftNextCardButton.Tag = "0";
            this.leftNextCardButton.Text = "→";
            this.leftNextCardButton.UseVisualStyleBackColor = true;
            this.leftNextCardButton.Click += new System.EventHandler(this.NextCard_Click);
            // 
            // centerPrevCardButton
            // 
            this.centerPrevCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerPrevCardButton.Location = new System.Drawing.Point(239, 30);
            this.centerPrevCardButton.Name = "centerPrevCardButton";
            this.centerPrevCardButton.Size = new System.Drawing.Size(44, 21);
            this.centerPrevCardButton.TabIndex = 8;
            this.centerPrevCardButton.Tag = "1";
            this.centerPrevCardButton.Text = "←";
            this.centerPrevCardButton.UseVisualStyleBackColor = true;
            this.centerPrevCardButton.Click += new System.EventHandler(this.PrevCard_Click);
            // 
            // centerNextCardButton
            // 
            this.centerNextCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerNextCardButton.Location = new System.Drawing.Point(289, 30);
            this.centerNextCardButton.Name = "centerNextCardButton";
            this.centerNextCardButton.Size = new System.Drawing.Size(44, 21);
            this.centerNextCardButton.TabIndex = 9;
            this.centerNextCardButton.Tag = "1";
            this.centerNextCardButton.Text = "→";
            this.centerNextCardButton.UseVisualStyleBackColor = true;
            this.centerNextCardButton.Click += new System.EventHandler(this.NextCard_Click);
            // 
            // rightLeftCardButton
            // 
            this.rightLeftCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightLeftCardButton.Location = new System.Drawing.Point(339, 30);
            this.rightLeftCardButton.Name = "rightLeftCardButton";
            this.rightLeftCardButton.Size = new System.Drawing.Size(44, 21);
            this.rightLeftCardButton.TabIndex = 10;
            this.rightLeftCardButton.Tag = "2";
            this.rightLeftCardButton.Text = "←";
            this.rightLeftCardButton.UseVisualStyleBackColor = true;
            this.rightLeftCardButton.Click += new System.EventHandler(this.PrevCard_Click);
            // 
            // rightNextCardButton
            // 
            this.rightNextCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightNextCardButton.Location = new System.Drawing.Point(389, 30);
            this.rightNextCardButton.Name = "rightNextCardButton";
            this.rightNextCardButton.Size = new System.Drawing.Size(44, 21);
            this.rightNextCardButton.TabIndex = 11;
            this.rightNextCardButton.Tag = "2";
            this.rightNextCardButton.Text = "→";
            this.rightNextCardButton.UseVisualStyleBackColor = true;
            this.rightNextCardButton.Click += new System.EventHandler(this.NextCard_Click);
            // 
            // DrillForm
            // 
            this.AcceptButton = this.nextWordButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 291);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(620, 330);
            this.Name = "DrillForm";
            this.Text = "Drill";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.Button nextWordButton;
        private System.Windows.Forms.Button prevWordButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button leftPrevCardButton;
        private System.Windows.Forms.Button leftNextCardButton;
        private System.Windows.Forms.Button centerPrevCardButton;
        private System.Windows.Forms.Button centerNextCardButton;
        private System.Windows.Forms.Button rightLeftCardButton;
        private System.Windows.Forms.Button rightNextCardButton;
    }
}