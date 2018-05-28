namespace iLibrary
{
    partial class userForm
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
            this.libraryNameBox = new System.Windows.Forms.Label();
            this.userLogBox = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.booksListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // libraryNameBox
            // 
            this.libraryNameBox.AutoSize = true;
            this.libraryNameBox.Font = new System.Drawing.Font("Segoe Script", 19.8F);
            this.libraryNameBox.Location = new System.Drawing.Point(318, 21);
            this.libraryNameBox.Name = "libraryNameBox";
            this.libraryNameBox.Size = new System.Drawing.Size(161, 42);
            this.libraryNameBox.TabIndex = 0;
            this.libraryNameBox.Text = "Biblioteka";
            // 
            // userLogBox
            // 
            this.userLogBox.AutoSize = true;
            this.userLogBox.Location = new System.Drawing.Point(300, 73);
            this.userLogBox.Name = "userLogBox";
            this.userLogBox.Size = new System.Drawing.Size(204, 13);
            this.userLogBox.TabIndex = 1;
            this.userLogBox.Text = "Prisijungta kaip: (Skaitytojas, Darbuotojas)";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(220, 407);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(213, 20);
            this.searchTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ieškoti knygų";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // booksListLabel
            // 
            this.booksListLabel.AutoSize = true;
            this.booksListLabel.Location = new System.Drawing.Point(13, 104);
            this.booksListLabel.Name = "booksListLabel";
            this.booksListLabel.Size = new System.Drawing.Size(79, 13);
            this.booksListLabel.TabIndex = 4;
            this.booksListLabel.Text = "Knygų sąrašas:";
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.booksListLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.userLogBox);
            this.Controls.Add(this.libraryNameBox);
            this.Name = "userForm";
            this.Text = "Biblioteka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label libraryNameBox;
        private System.Windows.Forms.Label userLogBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label booksListLabel;
    }
}