namespace Mathari_Level_5_Hospital
{
    partial class Form7
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label drug_NameLabel;
            System.Windows.Forms.Label stock_StatusLabel;
            System.Windows.Forms.Label prescriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.mathari_Level_5_HospitalDataSet = new Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSet();
            this.pharmacy_Management_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacy_Management_TableTableAdapter = new Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSetTableAdapters.Pharmacy_Management_TableTableAdapter();
            this.tableAdapterManager = new Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSetTableAdapters.TableAdapterManager();
            this.pharmacy_Management_TableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pharmacy_Management_TableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.drug_NameTextBox = new System.Windows.Forms.TextBox();
            this.stock_StatusTextBox = new System.Windows.Forms.TextBox();
            this.prescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pharmacy_Management_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            drug_NameLabel = new System.Windows.Forms.Label();
            stock_StatusLabel = new System.Windows.Forms.Label();
            prescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mathari_Level_5_HospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_Management_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_Management_TableBindingNavigator)).BeginInit();
            this.pharmacy_Management_TableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_Management_TableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            iDLabel.Location = new System.Drawing.Point(49, 65);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(37, 25);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // drug_NameLabel
            // 
            drug_NameLabel.AutoSize = true;
            drug_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            drug_NameLabel.Location = new System.Drawing.Point(49, 109);
            drug_NameLabel.Name = "drug_NameLabel";
            drug_NameLabel.Size = new System.Drawing.Size(117, 25);
            drug_NameLabel.TabIndex = 3;
            drug_NameLabel.Text = "Drug Name:";
            // 
            // stock_StatusLabel
            // 
            stock_StatusLabel.AutoSize = true;
            stock_StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            stock_StatusLabel.Location = new System.Drawing.Point(49, 151);
            stock_StatusLabel.Name = "stock_StatusLabel";
            stock_StatusLabel.Size = new System.Drawing.Size(129, 25);
            stock_StatusLabel.TabIndex = 5;
            stock_StatusLabel.Text = "Stock Status:";
            // 
            // prescriptionLabel
            // 
            prescriptionLabel.AutoSize = true;
            prescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            prescriptionLabel.Location = new System.Drawing.Point(46, 189);
            prescriptionLabel.Name = "prescriptionLabel";
            prescriptionLabel.Size = new System.Drawing.Size(120, 25);
            prescriptionLabel.TabIndex = 7;
            prescriptionLabel.Text = "Prescription:";
            // 
            // mathari_Level_5_HospitalDataSet
            // 
            this.mathari_Level_5_HospitalDataSet.DataSetName = "Mathari_Level_5_HospitalDataSet";
            this.mathari_Level_5_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pharmacy_Management_TableBindingSource
            // 
            this.pharmacy_Management_TableBindingSource.DataMember = "Pharmacy Management Table";
            this.pharmacy_Management_TableBindingSource.DataSource = this.mathari_Level_5_HospitalDataSet;
            // 
            // pharmacy_Management_TableTableAdapter
            // 
            this.pharmacy_Management_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Billing_and_Accounting_TableTableAdapter = null;
            this.tableAdapterManager.Departments_TableTableAdapter = null;
            this.tableAdapterManager.Employees__TableTableAdapter = null;
            this.tableAdapterManager.Patient_s_TableTableAdapter = null;
            this.tableAdapterManager.Pharmacy_Management_TableTableAdapter = this.pharmacy_Management_TableTableAdapter;
            this.tableAdapterManager.Rooms_TableTableAdapter = null;
            this.tableAdapterManager.Supply_Chain_TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Wards_TableTableAdapter = null;
            // 
            // pharmacy_Management_TableBindingNavigator
            // 
            this.pharmacy_Management_TableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pharmacy_Management_TableBindingNavigator.BindingSource = this.pharmacy_Management_TableBindingSource;
            this.pharmacy_Management_TableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pharmacy_Management_TableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pharmacy_Management_TableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pharmacy_Management_TableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pharmacy_Management_TableBindingNavigatorSaveItem});
            this.pharmacy_Management_TableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pharmacy_Management_TableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pharmacy_Management_TableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pharmacy_Management_TableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pharmacy_Management_TableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pharmacy_Management_TableBindingNavigator.Name = "pharmacy_Management_TableBindingNavigator";
            this.pharmacy_Management_TableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pharmacy_Management_TableBindingNavigator.Size = new System.Drawing.Size(1069, 27);
            this.pharmacy_Management_TableBindingNavigator.TabIndex = 0;
            this.pharmacy_Management_TableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // pharmacy_Management_TableBindingNavigatorSaveItem
            // 
            this.pharmacy_Management_TableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pharmacy_Management_TableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pharmacy_Management_TableBindingNavigatorSaveItem.Image")));
            this.pharmacy_Management_TableBindingNavigatorSaveItem.Name = "pharmacy_Management_TableBindingNavigatorSaveItem";
            this.pharmacy_Management_TableBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.pharmacy_Management_TableBindingNavigatorSaveItem.Text = "Save Data";
            this.pharmacy_Management_TableBindingNavigatorSaveItem.Click += new System.EventHandler(this.pharmacy_Management_TableBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_Management_TableBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iDTextBox.Location = new System.Drawing.Point(185, 62);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(253, 30);
            this.iDTextBox.TabIndex = 2;
            // 
            // drug_NameTextBox
            // 
            this.drug_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_Management_TableBindingSource, "Drug Name", true));
            this.drug_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drug_NameTextBox.Location = new System.Drawing.Point(185, 106);
            this.drug_NameTextBox.Name = "drug_NameTextBox";
            this.drug_NameTextBox.Size = new System.Drawing.Size(253, 30);
            this.drug_NameTextBox.TabIndex = 4;
            // 
            // stock_StatusTextBox
            // 
            this.stock_StatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_Management_TableBindingSource, "Stock Status", true));
            this.stock_StatusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.stock_StatusTextBox.Location = new System.Drawing.Point(184, 146);
            this.stock_StatusTextBox.Name = "stock_StatusTextBox";
            this.stock_StatusTextBox.Size = new System.Drawing.Size(253, 30);
            this.stock_StatusTextBox.TabIndex = 6;
            // 
            // prescriptionTextBox
            // 
            this.prescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_Management_TableBindingSource, "Prescription", true));
            this.prescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.prescriptionTextBox.Location = new System.Drawing.Point(184, 186);
            this.prescriptionTextBox.Name = "prescriptionTextBox";
            this.prescriptionTextBox.Size = new System.Drawing.Size(253, 30);
            this.prescriptionTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(6, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearch.Location = new System.Drawing.Point(87, 239);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(351, 30);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pharmacy_Management_TableDataGridView
            // 
            this.pharmacy_Management_TableDataGridView.AutoGenerateColumns = false;
            this.pharmacy_Management_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pharmacy_Management_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.pharmacy_Management_TableDataGridView.DataSource = this.pharmacy_Management_TableBindingSource;
            this.pharmacy_Management_TableDataGridView.Location = new System.Drawing.Point(3, 288);
            this.pharmacy_Management_TableDataGridView.MaximumSize = new System.Drawing.Size(1054, 220);
            this.pharmacy_Management_TableDataGridView.MinimumSize = new System.Drawing.Size(1054, 220);
            this.pharmacy_Management_TableDataGridView.Name = "pharmacy_Management_TableDataGridView";
            this.pharmacy_Management_TableDataGridView.RowHeadersWidth = 51;
            this.pharmacy_Management_TableDataGridView.RowTemplate.Height = 24;
            this.pharmacy_Management_TableDataGridView.Size = new System.Drawing.Size(1054, 220);
            this.pharmacy_Management_TableDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Drug Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Drug Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Stock Status";
            this.dataGridViewTextBoxColumn3.HeaderText = "Stock Status";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Prescription";
            this.dataGridViewTextBoxColumn4.HeaderText = "Prescription";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(361, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 42);
            this.button1.TabIndex = 25;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Cornsilk;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBack.Location = new System.Drawing.Point(30, 542);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 42);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1069, 596);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pharmacy_Management_TableDataGridView);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(prescriptionLabel);
            this.Controls.Add(this.prescriptionTextBox);
            this.Controls.Add(stock_StatusLabel);
            this.Controls.Add(this.stock_StatusTextBox);
            this.Controls.Add(drug_NameLabel);
            this.Controls.Add(this.drug_NameTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.pharmacy_Management_TableBindingNavigator);
            this.MaximumSize = new System.Drawing.Size(1087, 643);
            this.MinimumSize = new System.Drawing.Size(1087, 643);
            this.Name = "Form7";
            this.Text = "Pharmacy Management";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mathari_Level_5_HospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_Management_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_Management_TableBindingNavigator)).EndInit();
            this.pharmacy_Management_TableBindingNavigator.ResumeLayout(false);
            this.pharmacy_Management_TableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_Management_TableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mathari_Level_5_HospitalDataSet mathari_Level_5_HospitalDataSet;
        private System.Windows.Forms.BindingSource pharmacy_Management_TableBindingSource;
        private Mathari_Level_5_HospitalDataSetTableAdapters.Pharmacy_Management_TableTableAdapter pharmacy_Management_TableTableAdapter;
        private Mathari_Level_5_HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pharmacy_Management_TableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pharmacy_Management_TableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox drug_NameTextBox;
        private System.Windows.Forms.TextBox stock_StatusTextBox;
        private System.Windows.Forms.TextBox prescriptionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView pharmacy_Management_TableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
    }
}