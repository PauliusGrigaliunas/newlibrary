namespace iLibrary
{
    partial class EmployeeForm
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
            this.workerLabel = new System.Windows.Forms.Label();
            this.addBook = new System.Windows.Forms.Button();
            this.removeBookButton = new System.Windows.Forms.Button();
            this.addUnitButton = new System.Windows.Forms.Button();
            this.deleteUnitButton = new System.Windows.Forms.Button();
            this.bwcListView = new System.Windows.Forms.ListView();
            this.ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pavadinimas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Autorius = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Skaitytojas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GrazinimoLaikas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // workerLabel
            // 
            this.workerLabel.AutoSize = true;
            this.workerLabel.Font = new System.Drawing.Font("Segoe Script", 19.8F);
            this.workerLabel.Location = new System.Drawing.Point(101, 25);
            this.workerLabel.Name = "workerLabel";
            this.workerLabel.Size = new System.Drawing.Size(278, 42);
            this.workerLabel.TabIndex = 0;
            this.workerLabel.Text = "Darbuotojo meniu";
            // 
            // addBook
            // 
            this.addBook.Location = new System.Drawing.Point(31, 85);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(141, 31);
            this.addBook.TabIndex = 2;
            this.addBook.Text = "Pridėti knygą";
            this.addBook.UseVisualStyleBackColor = true;
            // 
            // removeBookButton
            // 
            this.removeBookButton.Location = new System.Drawing.Point(31, 132);
            this.removeBookButton.Name = "removeBookButton";
            this.removeBookButton.Size = new System.Drawing.Size(141, 31);
            this.removeBookButton.TabIndex = 2;
            this.removeBookButton.Text = "Pašalinti knygą";
            this.removeBookButton.UseVisualStyleBackColor = true;
            // 
            // addUnitButton
            // 
            this.addUnitButton.Location = new System.Drawing.Point(293, 85);
            this.addUnitButton.Name = "addUnitButton";
            this.addUnitButton.Size = new System.Drawing.Size(141, 31);
            this.addUnitButton.TabIndex = 2;
            this.addUnitButton.Text = "Pridėti egzempliorių";
            this.addUnitButton.UseVisualStyleBackColor = true;
            // 
            // deleteUnitButton
            // 
            this.deleteUnitButton.Location = new System.Drawing.Point(293, 132);
            this.deleteUnitButton.Name = "deleteUnitButton";
            this.deleteUnitButton.Size = new System.Drawing.Size(141, 31);
            this.deleteUnitButton.TabIndex = 2;
            this.deleteUnitButton.Text = "Pašalinti egzempliorių";
            this.deleteUnitButton.UseVisualStyleBackColor = true;
            // 
            // bwcListView
            // 
            this.bwcListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.bwcListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ISBN,
            this.ID,
            this.Pavadinimas,
            this.Autorius,
            this.Skaitytojas,
            this.GrazinimoLaikas});
            this.bwcListView.FullRowSelect = true;
            this.bwcListView.Location = new System.Drawing.Point(12, 192);
            this.bwcListView.Name = "bwcListView";
            this.bwcListView.Size = new System.Drawing.Size(459, 248);
            this.bwcListView.TabIndex = 3;
            this.bwcListView.UseCompatibleStateImageBehavior = false;
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
            this.GrazinimoLaikas.Text = "GrazinimoLaikas";
            this.GrazinimoLaikas.Width = 120;
            // 
            // bookListLabel
            // 
            this.bookListLabel.AutoSize = true;
            this.bookListLabel.Location = new System.Drawing.Point(9, 176);
            this.bookListLabel.Name = "bookListLabel";
            this.bookListLabel.Size = new System.Drawing.Size(159, 13);
            this.bookListLabel.TabIndex = 4;
            this.bookListLabel.Text = "Knygų ir jų egzempliorių sąrašas:";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 491);
            this.Controls.Add(this.bookListLabel);
            this.Controls.Add(this.bwcListView);
            this.Controls.Add(this.deleteUnitButton);
            this.Controls.Add(this.addUnitButton);
            this.Controls.Add(this.removeBookButton);
            this.Controls.Add(this.addBook);
            this.Controls.Add(this.workerLabel);
            this.Name = "EmployeeForm";
            this.Text = "Darbuotojo meniu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workerLabel;
        private System.Windows.Forms.Button addBook;
        private System.Windows.Forms.Button removeBookButton;
        private System.Windows.Forms.Button addUnitButton;
        private System.Windows.Forms.Button deleteUnitButton;
        private System.Windows.Forms.ListView bwcListView;
        private System.Windows.Forms.Label bookListLabel;
        private System.Windows.Forms.ColumnHeader ISBN;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Pavadinimas;
        private System.Windows.Forms.ColumnHeader Autorius;
        private System.Windows.Forms.ColumnHeader Skaitytojas;
        private System.Windows.Forms.ColumnHeader GrazinimoLaikas;
    }
}