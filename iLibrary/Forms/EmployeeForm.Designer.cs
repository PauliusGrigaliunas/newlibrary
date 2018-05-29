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
            this.components = new System.ComponentModel.Container();
            this.workerLabel = new System.Windows.Forms.Label();
            this.addBook = new System.Windows.Forms.Button();
            this.removeBookButton = new System.Windows.Forms.Button();
            this.addUnitButton = new System.Windows.Forms.Button();
            this.deleteUnitButton = new System.Windows.Forms.Button();
            this.knygosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataDataSet = new iLibrary.LibraryDataDataSet();
            this.knygosTableAdapter = new iLibrary.LibraryDataDataSetTableAdapters.KnygosTableAdapter();
            this.tableAdapterManager = new iLibrary.LibraryDataDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leidykla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skaitytojas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bwcListView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.knygosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // workerLabel
            // 
            this.workerLabel.AutoSize = true;
            this.workerLabel.Font = new System.Drawing.Font("Segoe Script", 19.8F);
            this.workerLabel.Location = new System.Drawing.Point(135, 31);
            this.workerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.workerLabel.Name = "workerLabel";
            this.workerLabel.Size = new System.Drawing.Size(337, 52);
            this.workerLabel.TabIndex = 0;
            this.workerLabel.Text = "Darbuotojo meniu";
            // 
            // addBook
            // 
            this.addBook.Location = new System.Drawing.Point(41, 105);
            this.addBook.Margin = new System.Windows.Forms.Padding(4);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(188, 38);
            this.addBook.TabIndex = 2;
            this.addBook.Text = "Pridėti knygą";
            this.addBook.UseVisualStyleBackColor = true;
            // 
            // removeBookButton
            // 
            this.removeBookButton.Location = new System.Drawing.Point(41, 162);
            this.removeBookButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeBookButton.Name = "removeBookButton";
            this.removeBookButton.Size = new System.Drawing.Size(188, 38);
            this.removeBookButton.TabIndex = 2;
            this.removeBookButton.Text = "Pašalinti knygą";
            this.removeBookButton.UseVisualStyleBackColor = true;
            // 
            // addUnitButton
            // 
            this.addUnitButton.Location = new System.Drawing.Point(391, 105);
            this.addUnitButton.Margin = new System.Windows.Forms.Padding(4);
            this.addUnitButton.Name = "addUnitButton";
            this.addUnitButton.Size = new System.Drawing.Size(188, 38);
            this.addUnitButton.TabIndex = 2;
            this.addUnitButton.Text = "Pridėti egzempliorių";
            this.addUnitButton.UseVisualStyleBackColor = true;
            // 
            // deleteUnitButton
            // 
            this.deleteUnitButton.Location = new System.Drawing.Point(391, 162);
            this.deleteUnitButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteUnitButton.Name = "deleteUnitButton";
            this.deleteUnitButton.Size = new System.Drawing.Size(188, 38);
            this.deleteUnitButton.TabIndex = 2;
            this.deleteUnitButton.Text = "Pašalinti egzempliorių";
            this.deleteUnitButton.UseVisualStyleBackColor = true;
            // 
            // knygosBindingSource
            // 
            this.knygosBindingSource.DataMember = "Knygos";
            this.knygosBindingSource.DataSource = this.libraryDataDataSet;
            // 
            // libraryDataDataSet
            // 
            this.libraryDataDataSet.DataSetName = "LibraryDataDataSet";
            this.libraryDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // knygosTableAdapter
            // 
            this.knygosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = iLibrary.LibraryDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Autorius";
            this.dataGridViewTextBoxColumn2.HeaderText = "Autorius";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Pavadinimas";
            this.dataGridViewTextBoxColumn3.HeaderText = "Pavadinimas";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Leidykla
            // 
            this.Leidykla.DataPropertyName = "Leidykla";
            this.Leidykla.HeaderText = "Leidykla";
            this.Leidykla.Name = "Leidykla";
            // 
            // Metai
            // 
            this.Metai.DataPropertyName = "Metai";
            this.Metai.HeaderText = "Metai";
            this.Metai.Name = "Metai";
            // 
            // Skaitytojas
            // 
            this.Skaitytojas.DataPropertyName = "Skaitytojas";
            this.Skaitytojas.HeaderText = "Skaitytojas";
            this.Skaitytojas.Name = "Skaitytojas";
            // 
            // bwcListView
            // 
            this.bwcListView.Location = new System.Drawing.Point(12, 219);
            this.bwcListView.Name = "bwcListView";
            this.bwcListView.Size = new System.Drawing.Size(620, 268);
            this.bwcListView.TabIndex = 5;
            this.bwcListView.UseCompatibleStateImageBehavior = false;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 574);
            this.Controls.Add(this.bwcListView);
            this.Controls.Add(this.deleteUnitButton);
            this.Controls.Add(this.addUnitButton);
            this.Controls.Add(this.removeBookButton);
            this.Controls.Add(this.addBook);
            this.Controls.Add(this.workerLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeForm";
            this.Text = "Darbuotojo meniu";
            ((System.ComponentModel.ISupportInitialize)(this.knygosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workerLabel;
        private System.Windows.Forms.Button addBook;
        private System.Windows.Forms.Button removeBookButton;
        private System.Windows.Forms.Button addUnitButton;
        private System.Windows.Forms.Button deleteUnitButton;
        private LibraryDataDataSet libraryDataDataSet;
        private System.Windows.Forms.BindingSource knygosBindingSource;
        private LibraryDataDataSetTableAdapters.KnygosTableAdapter knygosTableAdapter;
        private LibraryDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leidykla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skaitytojas;
        private System.Windows.Forms.ListView bwcListView;
    }
}