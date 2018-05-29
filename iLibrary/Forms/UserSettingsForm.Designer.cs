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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettingsForm));
            this.greetLabel = new System.Windows.Forms.Label();
            this.takeBookButton = new System.Windows.Forms.Button();
            this.returnBookButton = new System.Windows.Forms.Button();
            this.libraryDataDataSet = new iLibrary.LibraryDataDataSet();
            this.knygosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knygosTableAdapter = new iLibrary.LibraryDataDataSetTableAdapters.KnygosTableAdapter();
            this.tableAdapterManager = new iLibrary.LibraryDataDataSetTableAdapters.TableAdapterManager();
            this.knygosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.knygosDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoriusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pavadinimasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leidyklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosBindingNavigator)).BeginInit();
            this.knygosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // greetLabel
            // 
            this.greetLabel.AutoSize = true;
            this.greetLabel.Font = new System.Drawing.Font("Segoe Script", 19.8F);
            this.greetLabel.Location = new System.Drawing.Point(103, 27);
            this.greetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greetLabel.Name = "greetLabel";
            this.greetLabel.Size = new System.Drawing.Size(516, 52);
            this.greetLabel.TabIndex = 0;
            this.greetLabel.Text = "Sveiki prisjungę (UserName)";
            // 
            // takeBookButton
            // 
            this.takeBookButton.Location = new System.Drawing.Point(141, 89);
            this.takeBookButton.Margin = new System.Windows.Forms.Padding(4);
            this.takeBookButton.Name = "takeBookButton";
            this.takeBookButton.Size = new System.Drawing.Size(183, 32);
            this.takeBookButton.TabIndex = 1;
            this.takeBookButton.Text = "Pasiimti knygą";
            this.takeBookButton.UseVisualStyleBackColor = true;
            // 
            // returnBookButton
            // 
            this.returnBookButton.Location = new System.Drawing.Point(381, 89);
            this.returnBookButton.Margin = new System.Windows.Forms.Padding(4);
            this.returnBookButton.Name = "returnBookButton";
            this.returnBookButton.Size = new System.Drawing.Size(183, 32);
            this.returnBookButton.TabIndex = 1;
            this.returnBookButton.Text = "Gražinti knygą";
            this.returnBookButton.UseVisualStyleBackColor = true;
            // 
            // libraryDataDataSet
            // 
            this.libraryDataDataSet.DataSetName = "LibraryDataDataSet";
            this.libraryDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // knygosBindingSource
            // 
            this.knygosBindingSource.DataMember = "Knygos";
            this.knygosBindingSource.DataSource = this.libraryDataDataSet;
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
            this.knygosBindingNavigator.Size = new System.Drawing.Size(754, 27);
            this.knygosBindingNavigator.TabIndex = 2;
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
            this.knygosBindingNavigatorSaveItem.Enabled = false;
            this.knygosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("knygosBindingNavigatorSaveItem.Image")));
            this.knygosBindingNavigatorSaveItem.Name = "knygosBindingNavigatorSaveItem";
            this.knygosBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.knygosBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // knygosDataGridView
            // 
            this.knygosDataGridView.AutoGenerateColumns = false;
            this.knygosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.knygosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoriusDataGridViewTextBoxColumn,
            this.pavadinimasDataGridViewTextBoxColumn,
            this.leidyklaDataGridViewTextBoxColumn,
            this.metaiDataGridViewTextBoxColumn});
            this.knygosDataGridView.DataSource = this.knygosBindingSource;
            this.knygosDataGridView.Location = new System.Drawing.Point(12, 145);
            this.knygosDataGridView.Name = "knygosDataGridView";
            this.knygosDataGridView.RowTemplate.Height = 24;
            this.knygosDataGridView.Size = new System.Drawing.Size(719, 263);
            this.knygosDataGridView.TabIndex = 4;
            // 
            // knygosDataGridView1
            // 
            this.knygosDataGridView1.AutoGenerateColumns = false;
            this.knygosDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.knygosDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.knygosDataGridView1.DataSource = this.knygosBindingSource;
            this.knygosDataGridView1.Location = new System.Drawing.Point(12, 431);
            this.knygosDataGridView1.Name = "knygosDataGridView1";
            this.knygosDataGridView1.RowTemplate.Height = 24;
            this.knygosDataGridView1.Size = new System.Drawing.Size(719, 135);
            this.knygosDataGridView1.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Isbn";
            this.dataGridViewTextBoxColumn1.HeaderText = "Isbn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Leidykla";
            this.dataGridViewTextBoxColumn4.HeaderText = "Leidykla";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Metai";
            this.dataGridViewTextBoxColumn5.HeaderText = "Metai";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Expr1";
            this.dataGridViewTextBoxColumn6.HeaderText = "Expr1";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Skaitytojas";
            this.dataGridViewTextBoxColumn8.HeaderText = "Skaitytojas";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Gražinimo laikas";
            this.dataGridViewTextBoxColumn9.HeaderText = "Gražinimo laikas";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
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
            // UserSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 592);
            this.Controls.Add(this.knygosDataGridView1);
            this.Controls.Add(this.knygosDataGridView);
            this.Controls.Add(this.knygosBindingNavigator);
            this.Controls.Add(this.returnBookButton);
            this.Controls.Add(this.takeBookButton);
            this.Controls.Add(this.greetLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserSettingsForm";
            this.Text = "Vartotojo meniu";
            this.Load += new System.EventHandler(this.UserSettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosBindingNavigator)).EndInit();
            this.knygosBindingNavigator.ResumeLayout(false);
            this.knygosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetLabel;
        private System.Windows.Forms.Button takeBookButton;
        private System.Windows.Forms.Button returnBookButton;
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
        private System.Windows.Forms.DataGridView knygosDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoriusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavadinimasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leidyklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metaiDataGridViewTextBoxColumn;
    }
}