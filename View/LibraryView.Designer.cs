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
            this.returnBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addToLibBtn
            // 
            this.addToLibBtn.BackColor = System.Drawing.Color.NavajoWhite;
            this.addToLibBtn.Enabled = false;
            this.addToLibBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToLibBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToLibBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addToLibBtn.Location = new System.Drawing.Point(421, 441);
            this.addToLibBtn.Margin = new System.Windows.Forms.Padding(1);
            this.addToLibBtn.Name = "addToLibBtn";
            this.addToLibBtn.Size = new System.Drawing.Size(248, 47);
            this.addToLibBtn.TabIndex = 1;
            this.addToLibBtn.Text = "Add To Library";
            this.addToLibBtn.UseVisualStyleBackColor = false;
            this.addToLibBtn.Click += new System.EventHandler(this.addToLibBtnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to MyReader+";
            // 
            // listCloudLib
            // 
            this.listCloudLib.FormattingEnabled = true;
            this.listCloudLib.ItemHeight = 16;
            this.listCloudLib.Location = new System.Drawing.Point(421, 113);
            this.listCloudLib.Margin = new System.Windows.Forms.Padding(1);
            this.listCloudLib.Name = "listCloudLib";
            this.listCloudLib.Size = new System.Drawing.Size(249, 308);
            this.listCloudLib.TabIndex = 3;
            // 
            // viewABookBtn
            // 
            this.viewABookBtn.BackColor = System.Drawing.Color.NavajoWhite;
            this.viewABookBtn.Enabled = false;
            this.viewABookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewABookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewABookBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewABookBtn.Location = new System.Drawing.Point(33, 441);
            this.viewABookBtn.Margin = new System.Windows.Forms.Padding(1);
            this.viewABookBtn.Name = "viewABookBtn";
            this.viewABookBtn.Size = new System.Drawing.Size(251, 47);
            this.viewABookBtn.TabIndex = 4;
            this.viewABookBtn.Text = "View Book";
            this.viewABookBtn.UseVisualStyleBackColor = false;
            this.viewABookBtn.Click += new System.EventHandler(this.viewBookBtn);
            // 
            // listBookLib
            // 
            this.listBookLib.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBookLib.FormattingEnabled = true;
            this.listBookLib.ItemHeight = 16;
            this.listBookLib.Location = new System.Drawing.Point(33, 113);
            this.listBookLib.Margin = new System.Windows.Forms.Padding(1);
            this.listBookLib.Name = "listBookLib";
            this.listBookLib.Size = new System.Drawing.Size(249, 308);
            this.listBookLib.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cloud Library";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Library";
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.NavajoWhite;
            this.returnBtn.Enabled = false;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.returnBtn.Location = new System.Drawing.Point(299, 222);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(1);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(109, 41);
            this.returnBtn.TabIndex = 8;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 52);
            this.label4.TabIndex = 9;
            this.label4.Text = "--->";
            // 
            // LibraryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(707, 510);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBookLib);
            this.Controls.Add(this.viewABookBtn);
            this.Controls.Add(this.listCloudLib);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addToLibBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label label4;
    }
}

