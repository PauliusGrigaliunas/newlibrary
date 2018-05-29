namespace iLibrary.Forms
{
    partial class UserSettingsForm
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
            this.greetLabel = new System.Windows.Forms.Label();
            this.takeBookButton = new System.Windows.Forms.Button();
            this.returnBookButton = new System.Windows.Forms.Button();
            this.ownedBooksListView = new System.Windows.Forms.ListView();
            this.takenLabel = new System.Windows.Forms.Label();
            this.AllBooksListView = new System.Windows.Forms.ListView();
            this.ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pavadinimas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Autorius = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Skaitytojas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GrazinimoLaikas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.allBooksLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // greetLabel
            // 
            this.greetLabel.AutoSize = true;
            this.greetLabel.Font = new System.Drawing.Font("Segoe Script", 19.8F);
            this.greetLabel.Location = new System.Drawing.Point(51, 9);
            this.greetLabel.Name = "greetLabel";
            this.greetLabel.Size = new System.Drawing.Size(425, 42);
            this.greetLabel.TabIndex = 0;
            this.greetLabel.Text = "Sveiki prisjungę (UserName)";
            // 
            // takeBookButton
            // 
            this.takeBookButton.Location = new System.Drawing.Point(12, 567);
            this.takeBookButton.Name = "takeBookButton";
            this.takeBookButton.Size = new System.Drawing.Size(137, 26);
            this.takeBookButton.TabIndex = 1;
            this.takeBookButton.Text = "Pasiimti knygą";
            this.takeBookButton.UseVisualStyleBackColor = true;
            this.takeBookButton.Click += new System.EventHandler(this.takeBookButton_Click);
            // 
            // returnBookButton
            // 
            this.returnBookButton.Location = new System.Drawing.Point(12, 253);
            this.returnBookButton.Name = "returnBookButton";
            this.returnBookButton.Size = new System.Drawing.Size(137, 26);
            this.returnBookButton.TabIndex = 1;
            this.returnBookButton.Text = "Gražinti knygą";
            this.returnBookButton.UseVisualStyleBackColor = true;
            // 
            // ownedBooksListView
            // 
            this.ownedBooksListView.FullRowSelect = true;
            this.ownedBooksListView.Location = new System.Drawing.Point(12, 78);
            this.ownedBooksListView.Name = "ownedBooksListView";
            this.ownedBooksListView.Size = new System.Drawing.Size(459, 169);
            this.ownedBooksListView.TabIndex = 2;
            this.ownedBooksListView.UseCompatibleStateImageBehavior = false;
            // 
            // takenLabel
            // 
            this.takenLabel.AutoSize = true;
            this.takenLabel.Location = new System.Drawing.Point(9, 62);
            this.takenLabel.Name = "takenLabel";
            this.takenLabel.Size = new System.Drawing.Size(113, 13);
            this.takenLabel.TabIndex = 3;
            this.takenLabel.Text = "Paimtų knygų sąrašas:";
            // 
            // AllBooksListView
            // 
            this.AllBooksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ISBN,
            this.ID,
            this.Pavadinimas,
            this.Autorius,
            this.Skaitytojas,
            this.GrazinimoLaikas});
            this.AllBooksListView.FullRowSelect = true;
            this.AllBooksListView.Location = new System.Drawing.Point(12, 313);
            this.AllBooksListView.Name = "AllBooksListView";
            this.AllBooksListView.Size = new System.Drawing.Size(459, 248);
            this.AllBooksListView.TabIndex = 2;
            this.AllBooksListView.UseCompatibleStateImageBehavior = false;
            // 
            // ISBN
            // 
            this.ISBN.Text = "ISBN";
            this.ISBN.Width = 40;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 35;
            // 
            // Pavadinimas
            // 
            this.Pavadinimas.Text = "Pavadinimas";
            this.Pavadinimas.Width = 150;
            // 
            // Autorius
            // 
            this.Autorius.Text = "Autorius";
            this.Autorius.Width = 150;
            // 
            // Skaitytojas
            // 
            this.Skaitytojas.Text = "Skaitytojas";
            this.Skaitytojas.Width = 65;
            // 
            // GrazinimoLaikas
            // 
            this.GrazinimoLaikas.Text = "Gražinimo Laikas";
            this.GrazinimoLaikas.Width = 120;
            // 
            // allBooksLabel
            // 
            this.allBooksLabel.AutoSize = true;
            this.allBooksLabel.Location = new System.Drawing.Point(12, 297);
            this.allBooksLabel.Name = "allBooksLabel";
            this.allBooksLabel.Size = new System.Drawing.Size(101, 13);
            this.allBooksLabel.TabIndex = 4;
            this.allBooksLabel.Text = "Visų knygų sąrašas:";
            // 
            // UserSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 600);
            this.Controls.Add(this.allBooksLabel);
            this.Controls.Add(this.takenLabel);
            this.Controls.Add(this.AllBooksListView);
            this.Controls.Add(this.ownedBooksListView);
            this.Controls.Add(this.returnBookButton);
            this.Controls.Add(this.takeBookButton);
            this.Controls.Add(this.greetLabel);
            this.Name = "UserSettingsForm";
            this.Text = "Vartotojo meniu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetLabel;
        private System.Windows.Forms.Button takeBookButton;
        private System.Windows.Forms.Button returnBookButton;
        private System.Windows.Forms.ListView ownedBooksListView;
        private System.Windows.Forms.Label takenLabel;
        private System.Windows.Forms.ListView AllBooksListView;
        private System.Windows.Forms.Label allBooksLabel;
        private System.Windows.Forms.ColumnHeader ISBN;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Pavadinimas;
        private System.Windows.Forms.ColumnHeader Autorius;
        private System.Windows.Forms.ColumnHeader Skaitytojas;
        private System.Windows.Forms.ColumnHeader GrazinimoLaikas;
    }
}