﻿
namespace BookNook.PresentationLayer
{
    partial class frmAddOwned
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
            this.label1 = new System.Windows.Forms.Label();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.authorInput = new System.Windows.Forms.TextBox();
            this.pagesInput = new System.Windows.Forms.TextBox();
            this.genreInput = new System.Windows.Forms.TextBox();
            this.publisherInput = new System.Windows.Forms.TextBox();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.datePublishedPicker = new System.Windows.Forms.DateTimePicker();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.placeInput = new System.Windows.Forms.TextBox();
            this.readYes = new System.Windows.Forms.RadioButton();
            this.readNo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // titleInput
            // 
            this.titleInput.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleInput.Location = new System.Drawing.Point(194, 54);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(197, 32);
            this.titleInput.TabIndex = 1;
            // 
            // authorInput
            // 
            this.authorInput.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorInput.Location = new System.Drawing.Point(194, 121);
            this.authorInput.Name = "authorInput";
            this.authorInput.Size = new System.Drawing.Size(197, 32);
            this.authorInput.TabIndex = 2;
            // 
            // pagesInput
            // 
            this.pagesInput.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagesInput.Location = new System.Drawing.Point(641, 186);
            this.pagesInput.MaxLength = 4;
            this.pagesInput.Name = "pagesInput";
            this.pagesInput.Size = new System.Drawing.Size(197, 32);
            this.pagesInput.TabIndex = 4;
            // 
            // genreInput
            // 
            this.genreInput.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreInput.Location = new System.Drawing.Point(194, 186);
            this.genreInput.Name = "genreInput";
            this.genreInput.Size = new System.Drawing.Size(197, 32);
            this.genreInput.TabIndex = 5;
            // 
            // publisherInput
            // 
            this.publisherInput.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherInput.Location = new System.Drawing.Point(641, 54);
            this.publisherInput.Name = "publisherInput";
            this.publisherInput.Size = new System.Drawing.Size(197, 32);
            this.publisherInput.TabIndex = 7;
            // 
            // priceInput
            // 
            this.priceInput.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceInput.Location = new System.Drawing.Point(226, 277);
            this.priceInput.MaxLength = 1;
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(197, 32);
            this.priceInput.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Genre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Publisher:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date published:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "Number of pages:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Place bought:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(139, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "Price:";
            // 
            // datePublishedPicker
            // 
            this.datePublishedPicker.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePublishedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePublishedPicker.Location = new System.Drawing.Point(641, 117);
            this.datePublishedPicker.Name = "datePublishedPicker";
            this.datePublishedPicker.Size = new System.Drawing.Size(197, 32);
            this.datePublishedPicker.TabIndex = 17;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.Window;
            this.cancelButton.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cancelButton.Location = new System.Drawing.Point(514, 440);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(159, 40);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Window;
            this.addButton.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.addButton.Location = new System.Drawing.Point(275, 440);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(159, 40);
            this.addButton.TabIndex = 19;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(547, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 28);
            this.label9.TabIndex = 20;
            this.label9.Text = "Read:";
            // 
            // placeInput
            // 
            this.placeInput.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeInput.Location = new System.Drawing.Point(226, 338);
            this.placeInput.MaxLength = 1;
            this.placeInput.Name = "placeInput";
            this.placeInput.Size = new System.Drawing.Size(197, 32);
            this.placeInput.TabIndex = 21;
            // 
            // readYes
            // 
            this.readYes.AutoSize = true;
            this.readYes.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readYes.Location = new System.Drawing.Point(664, 307);
            this.readYes.Name = "readYes";
            this.readYes.Size = new System.Drawing.Size(62, 28);
            this.readYes.TabIndex = 22;
            this.readYes.TabStop = true;
            this.readYes.Text = "Yes";
            this.readYes.UseVisualStyleBackColor = true;
            // 
            // readNo
            // 
            this.readNo.AutoSize = true;
            this.readNo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readNo.Location = new System.Drawing.Point(769, 307);
            this.readNo.Name = "readNo";
            this.readNo.Size = new System.Drawing.Size(59, 28);
            this.readNo.TabIndex = 23;
            this.readNo.TabStop = true;
            this.readNo.Text = "No";
            this.readNo.UseVisualStyleBackColor = true;
            // 
            // frmAddOwned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(937, 513);
            this.Controls.Add(this.readNo);
            this.Controls.Add(this.readYes);
            this.Controls.Add(this.placeInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.datePublishedPicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.publisherInput);
            this.Controls.Add(this.genreInput);
            this.Controls.Add(this.pagesInput);
            this.Controls.Add(this.authorInput);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "frmAddOwned";
            this.Text = "Add Read Book";
            this.Load += new System.EventHandler(this.frmAddOwned_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.TextBox authorInput;
        private System.Windows.Forms.TextBox pagesInput;
        private System.Windows.Forms.TextBox genreInput;
        private System.Windows.Forms.TextBox publisherInput;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker datePublishedPicker;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox placeInput;
        private System.Windows.Forms.RadioButton readYes;
        private System.Windows.Forms.RadioButton readNo;
    }
}