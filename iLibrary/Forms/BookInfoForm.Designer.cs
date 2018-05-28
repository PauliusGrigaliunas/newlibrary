namespace iLibrary.Forms
{
    partial class BookInfoForm
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.publishYearLabel = new System.Windows.Forms.Label();
            this.nameInsertLabel = new System.Windows.Forms.Label();
            this.authorTextLabel = new System.Windows.Forms.Label();
            this.unitTextLabel = new System.Windows.Forms.Label();
            this.publisherTextLabel = new System.Windows.Forms.Label();
            this.yearTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Segoe Script", 19.8F);
            this.infoLabel.Location = new System.Drawing.Point(114, 21);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(299, 42);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Knygos informacija";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(97, 95);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(70, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Pavadinimas:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(118, 131);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(48, 13);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Autorius:";
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Location = new System.Drawing.Point(92, 166);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(74, 13);
            this.unitLabel.TabIndex = 1;
            this.unitLabel.Text = "Egzempliorius:";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(117, 203);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(49, 13);
            this.publisherLabel.TabIndex = 1;
            this.publisherLabel.Text = "Leidykla:";
            // 
            // publishYearLabel
            // 
            this.publishYearLabel.AutoSize = true;
            this.publishYearLabel.Location = new System.Drawing.Point(92, 239);
            this.publishYearLabel.Name = "publishYearLabel";
            this.publishYearLabel.Size = new System.Drawing.Size(74, 13);
            this.publishYearLabel.TabIndex = 1;
            this.publishYearLabel.Text = "Leidimo metai:";
            // 
            // nameInsertLabel
            // 
            this.nameInsertLabel.AutoSize = true;
            this.nameInsertLabel.Location = new System.Drawing.Point(186, 94);
            this.nameInsertLabel.Name = "nameInsertLabel";
            this.nameInsertLabel.Size = new System.Drawing.Size(33, 13);
            this.nameInsertLabel.TabIndex = 2;
            this.nameInsertLabel.Text = "name";
            // 
            // authorTextLabel
            // 
            this.authorTextLabel.AutoSize = true;
            this.authorTextLabel.Location = new System.Drawing.Point(186, 131);
            this.authorTextLabel.Name = "authorTextLabel";
            this.authorTextLabel.Size = new System.Drawing.Size(37, 13);
            this.authorTextLabel.TabIndex = 2;
            this.authorTextLabel.Text = "author";
            // 
            // unitTextLabel
            // 
            this.unitTextLabel.AutoSize = true;
            this.unitTextLabel.Location = new System.Drawing.Point(186, 166);
            this.unitTextLabel.Name = "unitTextLabel";
            this.unitTextLabel.Size = new System.Drawing.Size(24, 13);
            this.unitTextLabel.TabIndex = 2;
            this.unitTextLabel.Text = "unit";
            // 
            // publisherTextLabel
            // 
            this.publisherTextLabel.AutoSize = true;
            this.publisherTextLabel.Location = new System.Drawing.Point(186, 203);
            this.publisherTextLabel.Name = "publisherTextLabel";
            this.publisherTextLabel.Size = new System.Drawing.Size(49, 13);
            this.publisherTextLabel.TabIndex = 2;
            this.publisherTextLabel.Text = "publisher";
            // 
            // yearTextLabel
            // 
            this.yearTextLabel.AutoSize = true;
            this.yearTextLabel.Location = new System.Drawing.Point(186, 239);
            this.yearTextLabel.Name = "yearTextLabel";
            this.yearTextLabel.Size = new System.Drawing.Size(32, 13);
            this.yearTextLabel.TabIndex = 2;
            this.yearTextLabel.Text = "years";
            // 
            // BookInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 349);
            this.Controls.Add(this.yearTextLabel);
            this.Controls.Add(this.publisherTextLabel);
            this.Controls.Add(this.unitTextLabel);
            this.Controls.Add(this.authorTextLabel);
            this.Controls.Add(this.nameInsertLabel);
            this.Controls.Add(this.publishYearLabel);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.infoLabel);
            this.Name = "BookInfoForm";
            this.Text = "Knygos informacija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label publishYearLabel;
        private System.Windows.Forms.Label nameInsertLabel;
        private System.Windows.Forms.Label authorTextLabel;
        private System.Windows.Forms.Label unitTextLabel;
        private System.Windows.Forms.Label publisherTextLabel;
        private System.Windows.Forms.Label yearTextLabel;
    }
}