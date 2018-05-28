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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.workerLabel = new System.Windows.Forms.Label();
            this.addBook = new System.Windows.Forms.Button();
            this.removeBookButton = new System.Windows.Forms.Button();
            this.addUnitButton = new System.Windows.Forms.Button();
            this.deleteUnitButton = new System.Windows.Forms.Button();
            this.knygosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.knygosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataDataSet = new iLibrary.LibraryDataDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.knygosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.knygosDataGridView = new System.Windows.Forms.DataGridView();
            this.autoriusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pavadinimasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leidyklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skaitytojasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gražinimoLaikasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knygosTableAdapter = new iLibrary.LibraryDataDataSetTableAdapters.KnygosTableAdapter();
            this.tableAdapterManager = new iLibrary.LibraryDataDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leidykla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skaitytojas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.knygosBindingNavigator)).BeginInit();
            this.knygosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knygosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataGridView)).BeginInit();
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
            // knygosBindingNavigator
            // 
            this.knygosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.knygosBindingNavigator.BindingSource = this.knygosBindingSource;
            this.knygosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.knygosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.knygosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.knygosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.knygosBindingNavigatorSaveItem});
            this.knygosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.knygosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.knygosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.knygosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.knygosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.knygosBindingNavigator.Name = "knygosBindingNavigator";
            this.knygosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.knygosBindingNavigator.Size = new System.Drawing.Size(644, 27);
            this.knygosBindingNavigator.TabIndex = 3;
            this.knygosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // knygosBindingNavigatorSaveItem
            // 
            this.knygosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.knygosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("knygosBindingNavigatorSaveItem.Image")));
            this.knygosBindingNavigatorSaveItem.Name = "knygosBindingNavigatorSaveItem";
            this.knygosBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.knygosBindingNavigatorSaveItem.Text = "Save Data";
            this.knygosBindingNavigatorSaveItem.Click += new System.EventHandler(this.knygosBindingNavigatorSaveItem_Click);
            // 
            // knygosDataGridView
            // 
            this.knygosDataGridView.AutoGenerateColumns = false;
            this.knygosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.knygosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoriusDataGridViewTextBoxColumn,
            this.pavadinimasDataGridViewTextBoxColumn,
            this.leidyklaDataGridViewTextBoxColumn,
            this.metaiDataGridViewTextBoxColumn,
            this.skaitytojasDataGridViewTextBoxColumn,
            this.gražinimoLaikasDataGridViewTextBoxColumn});
            this.knygosDataGridView.DataSource = this.knygosBindingSource;
            this.knygosDataGridView.Location = new System.Drawing.Point(12, 216);
            this.knygosDataGridView.Name = "knygosDataGridView";
            this.knygosDataGridView.RowTemplate.Height = 24;
            this.knygosDataGridView.Size = new System.Drawing.Size(620, 254);
            this.knygosDataGridView.TabIndex = 6;
            // 
            // autoriusDataGridViewTextBoxColumn
            // 
            this.autoriusDataGridViewTextBoxColumn.DataPropertyName = "Autorius";
            this.autoriusDataGridViewTextBoxColumn.HeaderText = "Autorius";
            this.autoriusDataGridViewTextBoxColumn.Name = "autoriusDataGridViewTextBoxColumn";
            // 
            // pavadinimasDataGridViewTextBoxColumn
            // 
            this.pavadinimasDataGridViewTextBoxColumn.DataPropertyName = "Pavadinimas";
            this.pavadinimasDataGridViewTextBoxColumn.HeaderText = "Pavadinimas";
            this.pavadinimasDataGridViewTextBoxColumn.Name = "pavadinimasDataGridViewTextBoxColumn";
            // 
            // leidyklaDataGridViewTextBoxColumn
            // 
            this.leidyklaDataGridViewTextBoxColumn.DataPropertyName = "Leidykla";
            this.leidyklaDataGridViewTextBoxColumn.HeaderText = "Leidykla";
            this.leidyklaDataGridViewTextBoxColumn.Name = "leidyklaDataGridViewTextBoxColumn";
            // 
            // metaiDataGridViewTextBoxColumn
            // 
            this.metaiDataGridViewTextBoxColumn.DataPropertyName = "Metai";
            this.metaiDataGridViewTextBoxColumn.HeaderText = "Metai";
            this.metaiDataGridViewTextBoxColumn.Name = "metaiDataGridViewTextBoxColumn";
            // 
            // skaitytojasDataGridViewTextBoxColumn
            // 
            this.skaitytojasDataGridViewTextBoxColumn.DataPropertyName = "Skaitytojas";
            this.skaitytojasDataGridViewTextBoxColumn.HeaderText = "Skaitytojas";
            this.skaitytojasDataGridViewTextBoxColumn.Name = "skaitytojasDataGridViewTextBoxColumn";
            // 
            // gražinimoLaikasDataGridViewTextBoxColumn
            // 
            this.gražinimoLaikasDataGridViewTextBoxColumn.DataPropertyName = "Gražinimo laikas";
            this.gražinimoLaikasDataGridViewTextBoxColumn.HeaderText = "Gražinimo laikas";
            this.gražinimoLaikasDataGridViewTextBoxColumn.Name = "gražinimoLaikasDataGridViewTextBoxColumn";
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
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 574);
            this.Controls.Add(this.knygosDataGridView);
            this.Controls.Add(this.knygosBindingNavigator);
            this.Controls.Add(this.deleteUnitButton);
            this.Controls.Add(this.addUnitButton);
            this.Controls.Add(this.removeBookButton);
            this.Controls.Add(this.addBook);
            this.Controls.Add(this.workerLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeForm";
            this.Text = "Darbuotojo meniu";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.knygosBindingNavigator)).EndInit();
            this.knygosBindingNavigator.ResumeLayout(false);
            this.knygosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knygosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingNavigator knygosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton knygosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView knygosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leidykla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skaitytojas;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoriusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavadinimasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leidyklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skaitytojasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gražinimoLaikasDataGridViewTextBoxColumn;
    }
}