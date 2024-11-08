﻿namespace Library_Management
{
    partial class MenuManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuManagement));
            this.label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Borrow = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.PrintBooks = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.label.Location = new System.Drawing.Point(433, 38);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(417, 76);
            this.label.TabIndex = 0;
            this.label.Text = "Menu Option";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(704, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 399);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Borrow
            // 
            this.Borrow.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.Borrow.Location = new System.Drawing.Point(21, 34);
            this.Borrow.Name = "Borrow";
            this.Borrow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Borrow.Size = new System.Drawing.Size(521, 73);
            this.Borrow.TabIndex = 5;
            this.Borrow.Text = "   1. Mượn Sách";
            this.Borrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Borrow.UseVisualStyleBackColor = true;
            this.Borrow.Click += new System.EventHandler(this.Borrow_Click);
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.Return.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Return.Location = new System.Drawing.Point(21, 128);
            this.Return.Name = "Return";
            this.Return.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Return.Size = new System.Drawing.Size(521, 73);
            this.Return.TabIndex = 6;
            this.Return.Text = "   2. Trả Sách";
            this.Return.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Return.UseVisualStyleBackColor = true;
            // 
            // PrintBooks
            // 
            this.PrintBooks.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.PrintBooks.Location = new System.Drawing.Point(21, 227);
            this.PrintBooks.Name = "PrintBooks";
            this.PrintBooks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PrintBooks.Size = new System.Drawing.Size(521, 73);
            this.PrintBooks.TabIndex = 7;
            this.PrintBooks.Text = "   3. In danh sách sách";
            this.PrintBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintBooks.UseVisualStyleBackColor = true;
            this.PrintBooks.Click += new System.EventHandler(this.PrintBooks_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.PrintBooks);
            this.panel.Controls.Add(this.Return);
            this.panel.Controls.Add(this.Borrow);
            this.panel.Location = new System.Drawing.Point(36, 142);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(578, 423);
            this.panel.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.button1.Location = new System.Drawing.Point(21, 326);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(521, 73);
            this.button1.TabIndex = 8;
            this.button1.Text = "   4. Thoát";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuManagement
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1262, 653);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libary";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Borrow;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button PrintBooks;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button1;
    }
}