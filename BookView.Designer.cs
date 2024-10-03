namespace Exam_1_EC
{
    partial class BookView
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
            this.flipRight = new System.Windows.Forms.Button();
            this.flipLeft = new System.Windows.Forms.Button();
            this.bookmarkButton = new System.Windows.Forms.Button();
            this.pageText = new System.Windows.Forms.TextBox();
            this.bookM = new System.Windows.Forms.Label();
            this.pageNumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flipRight
            // 
            this.flipRight.Location = new System.Drawing.Point(202, 355);
            this.flipRight.Margin = new System.Windows.Forms.Padding(2);
            this.flipRight.Name = "flipRight";
            this.flipRight.Size = new System.Drawing.Size(62, 28);
            this.flipRight.TabIndex = 0;
            this.flipRight.Text = "-->";
            this.flipRight.UseVisualStyleBackColor = true;
            this.flipRight.Click += new System.EventHandler(this.flipRight_Click);
            // 
            // flipLeft
            // 
            this.flipLeft.Location = new System.Drawing.Point(26, 355);
            this.flipLeft.Margin = new System.Windows.Forms.Padding(2);
            this.flipLeft.Name = "flipLeft";
            this.flipLeft.Size = new System.Drawing.Size(62, 28);
            this.flipLeft.TabIndex = 1;
            this.flipLeft.Text = "<--";
            this.flipLeft.UseVisualStyleBackColor = true;
            this.flipLeft.Click += new System.EventHandler(this.flipLeft_Click);
            // 
            // bookmarkButton
            // 
            this.bookmarkButton.Location = new System.Drawing.Point(104, 353);
            this.bookmarkButton.Margin = new System.Windows.Forms.Padding(2);
            this.bookmarkButton.Name = "bookmarkButton";
            this.bookmarkButton.Size = new System.Drawing.Size(81, 33);
            this.bookmarkButton.TabIndex = 2;
            this.bookmarkButton.Text = "Bookmark";
            this.bookmarkButton.UseVisualStyleBackColor = true;
            this.bookmarkButton.Click += new System.EventHandler(this.bookmarkButton_Click);
            // 
            // pageText
            // 
            this.pageText.Location = new System.Drawing.Point(29, 20);
            this.pageText.Margin = new System.Windows.Forms.Padding(2);
            this.pageText.Multiline = true;
            this.pageText.Name = "pageText";
            this.pageText.ReadOnly = true;
            this.pageText.Size = new System.Drawing.Size(240, 310);
            this.pageText.TabIndex = 3;
            // 
            // bookM
            // 
            this.bookM.AutoSize = true;
            this.bookM.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bookM.ForeColor = System.Drawing.Color.Transparent;
            this.bookM.Location = new System.Drawing.Point(231, 5);
            this.bookM.Name = "bookM";
            this.bookM.Size = new System.Drawing.Size(67, 13);
            this.bookM.TabIndex = 4;
            this.bookM.Text = "Bookmarked";
            // 
            // pageNumLabel
            // 
            this.pageNumLabel.AutoSize = true;
            this.pageNumLabel.Location = new System.Drawing.Point(13, 4);
            this.pageNumLabel.Name = "pageNumLabel";
            this.pageNumLabel.Size = new System.Drawing.Size(79, 13);
            this.pageNumLabel.TabIndex = 5;
            this.pageNumLabel.Text = "pageNumLabel";
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 420);
            this.Controls.Add(this.pageNumLabel);
            this.Controls.Add(this.bookM);
            this.Controls.Add(this.pageText);
            this.Controls.Add(this.bookmarkButton);
            this.Controls.Add(this.flipLeft);
            this.Controls.Add(this.flipRight);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookView";
            this.Text = "Book View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button flipRight;
        private System.Windows.Forms.Button flipLeft;
        private System.Windows.Forms.Button bookmarkButton;
        private System.Windows.Forms.TextBox pageText;
        private System.Windows.Forms.Label bookM;
        private System.Windows.Forms.Label pageNumLabel;
    }
}