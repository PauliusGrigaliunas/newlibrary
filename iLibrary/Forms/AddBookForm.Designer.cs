namespace iLibrary.Forms
{
    partial class AddBookForm
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
            this.newBookLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.publishLabel = new System.Windows.Forms.Label();
            this.publishYearLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.unitBox = new System.Windows.Forms.TextBox();
            this.publisherBox = new System.Windows.Forms.TextBox();
            this.publishYearBox = new System.Windows.Forms.TextBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newBookLabel
            // 
            this.newBookLabel.AutoSize = true;
            this.newBookLabel.Font = new System.Drawing.Font("Segoe Script", 19.8F);
            this.newBookLabel.Location = new System.Drawing.Point(122, 18);
            this.newBookLabel.Name = "newBookLabel";
            this.newBookLabel.Size = new System.Drawing.Size(198, 42);
            this.newBookLabel.TabIndex = 0;
            this.newBookLabel.Text = "Nauja knyga";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameLabel.Location = new System.Drawing.Point(66, 106);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(97, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Pavadinimas*:";
            this.nameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.authorLabel.Location = new System.Drawing.Point(94, 142);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(69, 17);
            this.authorLabel.TabIndex = 0;
            this.authorLabel.Text = "Autorius*:";
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.unitLabel.Location = new System.Drawing.Point(58, 176);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(105, 17);
            this.unitLabel.TabIndex = 0;
            this.unitLabel.Text = "Egzempliorius*:";
            // 
            // publishLabel
            // 
            this.publishLabel.AutoSize = true;
            this.publishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.publishLabel.Location = new System.Drawing.Point(94, 212);
            this.publishLabel.Name = "publishLabel";
            this.publishLabel.Size = new System.Drawing.Size(69, 17);
            this.publishLabel.TabIndex = 0;
            this.publishLabel.Text = "Leidykla*:";
            // 
            // publishYearLabel
            // 
            this.publishYearLabel.AutoSize = true;
            this.publishYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.publishYearLabel.Location = new System.Drawing.Point(59, 249);
            this.publishYearLabel.Name = "publishYearLabel";
            this.publishYearLabel.Size = new System.Drawing.Size(104, 17);
            this.publishYearLabel.TabIndex = 0;
            this.publishYearLabel.Text = "Leidimo metai*:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(180, 305);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Pridėti";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(164, 106);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(242, 20);
            this.nameBox.TabIndex = 2;
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(164, 141);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(242, 20);
            this.authorBox.TabIndex = 2;
            // 
            // unitBox
            // 
            this.unitBox.Location = new System.Drawing.Point(164, 175);
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(242, 20);
            this.unitBox.TabIndex = 2;
            // 
            // publisherBox
            // 
            this.publisherBox.Location = new System.Drawing.Point(164, 211);
            this.publisherBox.Name = "publisherBox";
            this.publisherBox.Size = new System.Drawing.Size(242, 20);
            this.publisherBox.TabIndex = 2;
            // 
            // publishYearBox
            // 
            this.publishYearBox.Location = new System.Drawing.Point(164, 246);
            this.publishYearBox.Name = "publishYearBox";
            this.publishYearBox.Size = new System.Drawing.Size(242, 20);
            this.publishYearBox.TabIndex = 2;
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(350, 349);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(83, 13);
            this.commentLabel.TabIndex = 3;
            this.commentLabel.Text = "*privalomi laukai";
            this.commentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.commentLabel.Click += new System.EventHandler(this.commentLabel_Click);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 371);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.publishYearBox);
            this.Controls.Add(this.publisherBox);
            this.Controls.Add(this.unitBox);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.publishYearLabel);
            this.Controls.Add(this.publishLabel);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.newBookLabel);
            this.Name = "AddBookForm";
            this.Text = "Pridėti knygą";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newBookLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Label publishLabel;
        private System.Windows.Forms.Label publishYearLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.TextBox unitBox;
        private System.Windows.Forms.TextBox publisherBox;
        private System.Windows.Forms.TextBox publishYearBox;
        private System.Windows.Forms.Label commentLabel;
    }
}