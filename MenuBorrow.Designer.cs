namespace Library_Management
{
    partial class MenuBorrow
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
            this.BoxID = new System.Windows.Forms.ComboBox();
            this.ShowResultFind = new System.Windows.Forms.DataGridView();
            this.BackToMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CountBorrow = new System.Windows.Forms.TextBox();
            this.ConfirmBorrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShowResultFind)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(38, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Book:";
            // 
            // BoxID
            // 
            this.BoxID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxID.FormattingEnabled = true;
            this.BoxID.Location = new System.Drawing.Point(224, 46);
            this.BoxID.Name = "BoxID";
            this.BoxID.Size = new System.Drawing.Size(135, 52);
            this.BoxID.TabIndex = 1;
            this.BoxID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ShowResultFind
            // 
            this.ShowResultFind.BackgroundColor = System.Drawing.Color.White;
            this.ShowResultFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowResultFind.Location = new System.Drawing.Point(46, 137);
            this.ShowResultFind.Name = "ShowResultFind";
            this.ShowResultFind.RowHeadersWidth = 51;
            this.ShowResultFind.RowTemplate.Height = 24;
            this.ShowResultFind.Size = new System.Drawing.Size(1184, 83);
            this.ShowResultFind.TabIndex = 2;
            // 
            // BackToMenu
            // 
            this.BackToMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackToMenu.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.BackToMenu.Location = new System.Drawing.Point(655, 433);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(195, 52);
            this.BackToMenu.TabIndex = 3;
            this.BackToMenu.Text = "Back To Menu";
            this.BackToMenu.UseVisualStyleBackColor = false;
            this.BackToMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(38, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity Of Borrow:";
            // 
            // CountBorrow
            // 
            this.CountBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountBorrow.Location = new System.Drawing.Point(448, 302);
            this.CountBorrow.Name = "CountBorrow";
            this.CountBorrow.Size = new System.Drawing.Size(78, 55);
            this.CountBorrow.TabIndex = 5;
            // 
            // ConfirmBorrow
            // 
            this.ConfirmBorrow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ConfirmBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.ConfirmBorrow.Location = new System.Drawing.Point(404, 433);
            this.ConfirmBorrow.Name = "ConfirmBorrow";
            this.ConfirmBorrow.Size = new System.Drawing.Size(195, 52);
            this.ConfirmBorrow.TabIndex = 6;
            this.ConfirmBorrow.Text = "Xác Nhận Mượn";
            this.ConfirmBorrow.UseVisualStyleBackColor = false;
            this.ConfirmBorrow.Click += new System.EventHandler(this.ConfirmBorrow_Click);
            // 
            // MenuBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1262, 653);
            this.Controls.Add(this.ConfirmBorrow);
            this.Controls.Add(this.CountBorrow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackToMenu);
            this.Controls.Add(this.ShowResultFind);
            this.Controls.Add(this.BoxID);
            this.Controls.Add(this.label1);
            this.Name = "MenuBorrow";
            this.Text = "MenuBorrow";
            ((System.ComponentModel.ISupportInitialize)(this.ShowResultFind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BoxID;
        private System.Windows.Forms.DataGridView ShowResultFind;
        private System.Windows.Forms.Button BackToMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CountBorrow;
        private System.Windows.Forms.Button ConfirmBorrow;
    }
}