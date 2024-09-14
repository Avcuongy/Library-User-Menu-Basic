namespace Library_Management
{
    partial class MenuListBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ListViewBooks = new System.Windows.Forms.DataGridView();
            this.BackToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // ListViewBooks
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ListViewBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListViewBooks.BackgroundColor = System.Drawing.Color.White;
            this.ListViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListViewBooks.Location = new System.Drawing.Point(22, 29);
            this.ListViewBooks.Name = "ListViewBooks";
            this.ListViewBooks.RowHeadersWidth = 51;
            this.ListViewBooks.RowTemplate.Height = 24;
            this.ListViewBooks.Size = new System.Drawing.Size(984, 596);
            this.ListViewBooks.TabIndex = 0;
            this.ListViewBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListViewBooks_CellContentClick);
            // 
            // BackToMenu
            // 
            this.BackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.BackToMenu.Location = new System.Drawing.Point(1030, 277);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(211, 91);
            this.BackToMenu.TabIndex = 1;
            this.BackToMenu.Text = "Back To Menu";
            this.BackToMenu.UseVisualStyleBackColor = true;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // MenuListBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1262, 653);
            this.Controls.Add(this.BackToMenu);
            this.Controls.Add(this.ListViewBooks);
            this.Name = "MenuListBook";
            this.Text = "MenuListBook";
            ((System.ComponentModel.ISupportInitialize)(this.ListViewBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListViewBooks;
        private System.Windows.Forms.Button BackToMenu;
    }
}