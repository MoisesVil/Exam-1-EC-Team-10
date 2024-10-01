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
            this.SuspendLayout();
            // 
            // flipRight
            // 
            this.flipRight.Location = new System.Drawing.Point(269, 437);
            this.flipRight.Name = "flipRight";
            this.flipRight.Size = new System.Drawing.Size(83, 34);
            this.flipRight.TabIndex = 0;
            this.flipRight.Text = "-->";
            this.flipRight.UseVisualStyleBackColor = true;
            this.flipRight.Click += new System.EventHandler(this.flipRight_Click);
            // 
            // flipLeft
            // 
            this.flipLeft.Location = new System.Drawing.Point(34, 437);
            this.flipLeft.Name = "flipLeft";
            this.flipLeft.Size = new System.Drawing.Size(83, 34);
            this.flipLeft.TabIndex = 1;
            this.flipLeft.Text = "<--";
            this.flipLeft.UseVisualStyleBackColor = true;
            // 
            // bookmarkButton
            // 
            this.bookmarkButton.Location = new System.Drawing.Point(139, 434);
            this.bookmarkButton.Name = "bookmarkButton";
            this.bookmarkButton.Size = new System.Drawing.Size(108, 41);
            this.bookmarkButton.TabIndex = 2;
            this.bookmarkButton.Text = "Bookmark";
            this.bookmarkButton.UseVisualStyleBackColor = true;
            // 
            // pageText
            // 
            this.pageText.Location = new System.Drawing.Point(39, 25);
            this.pageText.Multiline = true;
            this.pageText.Name = "pageText";
            this.pageText.ReadOnly = true;
            this.pageText.Size = new System.Drawing.Size(318, 380);
            this.pageText.TabIndex = 3;
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 517);
            this.Controls.Add(this.pageText);
            this.Controls.Add(this.bookmarkButton);
            this.Controls.Add(this.flipLeft);
            this.Controls.Add(this.flipRight);
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
    }
}