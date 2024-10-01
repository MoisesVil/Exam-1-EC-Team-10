namespace Exam_1_EC
{
    partial class LibraryView
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
            this.addToLibBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listCloudLib = new System.Windows.Forms.ListBox();
            this.viewABookBtn = new System.Windows.Forms.Button();
            this.listBookLib = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addToLibBtn
            // 
            this.addToLibBtn.BackColor = System.Drawing.Color.NavajoWhite;
            this.addToLibBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToLibBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToLibBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addToLibBtn.Location = new System.Drawing.Point(316, 358);
            this.addToLibBtn.Margin = new System.Windows.Forms.Padding(1);
            this.addToLibBtn.Name = "addToLibBtn";
            this.addToLibBtn.Size = new System.Drawing.Size(186, 38);
            this.addToLibBtn.TabIndex = 1;
            this.addToLibBtn.Text = "Add To Library";
            this.addToLibBtn.UseVisualStyleBackColor = false;
            this.addToLibBtn.Click += new System.EventHandler(this.addToLibBtnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to MyReader+";
            // 
            // listCloudLib
            // 
            this.listCloudLib.FormattingEnabled = true;
            this.listCloudLib.Location = new System.Drawing.Point(316, 92);
            this.listCloudLib.Margin = new System.Windows.Forms.Padding(1);
            this.listCloudLib.Name = "listCloudLib";
            this.listCloudLib.Size = new System.Drawing.Size(188, 251);
            this.listCloudLib.TabIndex = 3;
            // 
            // viewABookBtn
            // 
            this.viewABookBtn.BackColor = System.Drawing.Color.NavajoWhite;
            this.viewABookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewABookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewABookBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewABookBtn.Location = new System.Drawing.Point(25, 358);
            this.viewABookBtn.Margin = new System.Windows.Forms.Padding(1);
            this.viewABookBtn.Name = "viewABookBtn";
            this.viewABookBtn.Size = new System.Drawing.Size(188, 38);
            this.viewABookBtn.TabIndex = 4;
            this.viewABookBtn.Text = "View Book";
            this.viewABookBtn.UseVisualStyleBackColor = false;
            this.viewABookBtn.Click += new System.EventHandler(this.viewBookBtn);
            // 
            // listBookLib
            // 
            this.listBookLib.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBookLib.FormattingEnabled = true;
            this.listBookLib.Location = new System.Drawing.Point(25, 92);
            this.listBookLib.Margin = new System.Windows.Forms.Padding(1);
            this.listBookLib.Name = "listBookLib";
            this.listBookLib.Size = new System.Drawing.Size(188, 251);
            this.listBookLib.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cloud Library";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Library";
            // 
            // LibraryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(529, 406);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBookLib);
            this.Controls.Add(this.viewABookBtn);
            this.Controls.Add(this.listCloudLib);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addToLibBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "LibraryView";
            this.Text = "Library View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addToLibBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listCloudLib;
        private System.Windows.Forms.Button viewABookBtn;
        private System.Windows.Forms.ListBox listBookLib;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

