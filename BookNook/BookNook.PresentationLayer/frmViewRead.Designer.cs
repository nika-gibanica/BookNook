﻿
namespace BookNook.PresentationLayer
{
    partial class frmViewRead
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
            this.listRead = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backButton = new System.Windows.Forms.Button();
            this.addNewReadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listRead
            // 
            this.listRead.BackColor = System.Drawing.SystemColors.GrayText;
            this.listRead.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listRead.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRead.ForeColor = System.Drawing.SystemColors.Info;
            this.listRead.HideSelection = false;
            this.listRead.Location = new System.Drawing.Point(12, 24);
            this.listRead.Name = "listRead";
            this.listRead.Size = new System.Drawing.Size(953, 393);
            this.listRead.TabIndex = 1;
            this.listRead.UseCompatibleStateImageBehavior = false;
            this.listRead.View = System.Windows.Forms.View.Details;
            this.listRead.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Author";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Publisher";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date published";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Number of pages";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Genre";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Date read";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Rating";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 100;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Window;
            this.backButton.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.backButton.Location = new System.Drawing.Point(43, 438);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(101, 40);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addNewReadButton
            // 
            this.addNewReadButton.BackColor = System.Drawing.SystemColors.Window;
            this.addNewReadButton.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewReadButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.addNewReadButton.Location = new System.Drawing.Point(646, 438);
            this.addNewReadButton.Name = "addNewReadButton";
            this.addNewReadButton.Size = new System.Drawing.Size(226, 40);
            this.addNewReadButton.TabIndex = 3;
            this.addNewReadButton.Text = "Add a read book";
            this.addNewReadButton.UseVisualStyleBackColor = false;
            this.addNewReadButton.Click += new System.EventHandler(this.addNewReadButton_Click);
            // 
            // frmViewRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(977, 513);
            this.Controls.Add(this.addNewReadButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.listRead);
            this.Name = "frmViewRead";
            this.Text = "Read Books";
            this.Load += new System.EventHandler(this.frmViewRead_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listRead;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addNewReadButton;
    }
}