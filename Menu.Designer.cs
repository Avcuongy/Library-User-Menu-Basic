namespace Library_Management
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label = new System.Windows.Forms.Label();
            this.UsernameWord = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.PasswordWord = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.PicMenu = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.label.Location = new System.Drawing.Point(355, 39);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(597, 76);
            this.label.TabIndex = 0;
            this.label.Text = "Library Management";
            // 
            // UsernameWord
            // 
            this.UsernameWord.AutoSize = true;
            this.UsernameWord.BackColor = System.Drawing.Color.White;
            this.UsernameWord.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.UsernameWord.Location = new System.Drawing.Point(3, 11);
            this.UsernameWord.Name = "UsernameWord";
            this.UsernameWord.Size = new System.Drawing.Size(238, 57);
            this.UsernameWord.TabIndex = 1;
            this.UsernameWord.Text = "Username:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.UsernameInput);
            this.panel1.Controls.Add(this.UsernameWord);
            this.panel1.Location = new System.Drawing.Point(49, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 75);
            this.panel1.TabIndex = 3;
            // 
            // UsernameInput
            // 
            this.UsernameInput.BackColor = System.Drawing.Color.White;
            this.UsernameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameInput.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameInput.ForeColor = System.Drawing.Color.Black;
            this.UsernameInput.Location = new System.Drawing.Point(247, 10);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(362, 58);
            this.UsernameInput.TabIndex = 7;
            // 
            // PasswordWord
            // 
            this.PasswordWord.AutoSize = true;
            this.PasswordWord.BackColor = System.Drawing.Color.White;
            this.PasswordWord.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.PasswordWord.Location = new System.Drawing.Point(10, 10);
            this.PasswordWord.Name = "PasswordWord";
            this.PasswordWord.Size = new System.Drawing.Size(231, 57);
            this.PasswordWord.TabIndex = 1;
            this.PasswordWord.Text = "Password:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.PasswordInput);
            this.panel2.Controls.Add(this.PasswordWord);
            this.panel2.Location = new System.Drawing.Point(49, 375);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 75);
            this.panel2.TabIndex = 4;
            // 
            // PasswordInput
            // 
            this.PasswordInput.BackColor = System.Drawing.Color.White;
            this.PasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordInput.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordInput.ForeColor = System.Drawing.Color.Black;
            this.PasswordInput.Location = new System.Drawing.Point(247, 10);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(362, 58);
            this.PasswordInput.TabIndex = 6;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.White;
            this.Login.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.Login.Location = new System.Drawing.Point(245, 494);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(168, 75);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // PicMenu
            // 
            this.PicMenu.BackColor = System.Drawing.Color.Transparent;
            this.PicMenu.Image = ((System.Drawing.Image)(resources.GetObject("PicMenu.Image")));
            this.PicMenu.Location = new System.Drawing.Point(709, 159);
            this.PicMenu.Name = "PicMenu";
            this.PicMenu.Size = new System.Drawing.Size(521, 410);
            this.PicMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicMenu.TabIndex = 6;
            this.PicMenu.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1262, 653);
            this.Controls.Add(this.PicMenu);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label UsernameWord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PasswordWord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.PictureBox PicMenu;
        private System.Windows.Forms.TextBox UsernameInput;
    }
}