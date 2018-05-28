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
            this.SuspendLayout();
            // 
            // greetLabel
            // 
            this.greetLabel.AutoSize = true;
            this.greetLabel.Font = new System.Drawing.Font("Segoe Script", 19.8F);
            this.greetLabel.Location = new System.Drawing.Point(79, 9);
            this.greetLabel.Name = "greetLabel";
            this.greetLabel.Size = new System.Drawing.Size(425, 42);
            this.greetLabel.TabIndex = 0;
            this.greetLabel.Text = "Sveiki prisjungę (UserName)";
            // 
            // takeBookButton
            // 
            this.takeBookButton.Location = new System.Drawing.Point(106, 72);
            this.takeBookButton.Name = "takeBookButton";
            this.takeBookButton.Size = new System.Drawing.Size(137, 26);
            this.takeBookButton.TabIndex = 1;
            this.takeBookButton.Text = "Pasiimti knygą";
            this.takeBookButton.UseVisualStyleBackColor = true;
            // 
            // returnBookButton
            // 
            this.returnBookButton.Location = new System.Drawing.Point(286, 72);
            this.returnBookButton.Name = "returnBookButton";
            this.returnBookButton.Size = new System.Drawing.Size(137, 26);
            this.returnBookButton.TabIndex = 1;
            this.returnBookButton.Text = "Gražinti knygą";
            this.returnBookButton.UseVisualStyleBackColor = true;
            // 
            // UserSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 355);
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
    }
}