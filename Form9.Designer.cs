namespace Mathari_Level_5_Hospital
{
    partial class Form9
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
            System.Windows.Forms.Label supplier_NameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label suppliesLabel;
            System.Windows.Forms.Label payment_StatusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.mathari_Level_5_HospitalDataSet = new Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSet();
            this.supply_Chain_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supply_Chain_TableTableAdapter = new Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSetTableAdapters.Supply_Chain_TableTableAdapter();
            this.tableAdapterManager = new Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSetTableAdapters.TableAdapterManager();
            this.supply_Chain_TableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.supply_Chain_TableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.supplier_NameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.suppliesTextBox = new System.Windows.Forms.TextBox();
            this.payment_StatusTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.supply_Chain_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            supplier_NameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            suppliesLabel = new System.Windows.Forms.Label();
            payment_StatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mathari_Level_5_HospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supply_Chain_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supply_Chain_TableBindingNavigator)).BeginInit();
            this.supply_Chain_TableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supply_Chain_TableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            iDLabel.Location = new System.Drawing.Point(22, 57);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(37, 25);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // supplier_NameLabel
            // 
            supplier_NameLabel.AutoSize = true;
            supplier_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            supplier_NameLabel.Location = new System.Drawing.Point(18, 104);
            supplier_NameLabel.Name = "supplier_NameLabel";
            supplier_NameLabel.Size = new System.Drawing.Size(147, 25);
            supplier_NameLabel.TabIndex = 3;
            supplier_NameLabel.Text = "Supplier Name:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            phoneLabel.Location = new System.Drawing.Point(16, 148);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(75, 25);
            phoneLabel.TabIndex = 5;
            phoneLabel.Text = "Phone:";
            // 
            // suppliesLabel
            // 
            suppliesLabel.AutoSize = true;
            suppliesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            suppliesLabel.Location = new System.Drawing.Point(15, 194);
            suppliesLabel.Name = "suppliesLabel";
            suppliesLabel.Size = new System.Drawing.Size(94, 25);
            suppliesLabel.TabIndex = 7;
            suppliesLabel.Text = "Supplies:";
            // 
            // payment_StatusLabel
            // 
            payment_StatusLabel.AutoSize = true;
            payment_StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            payment_StatusLabel.Location = new System.Drawing.Point(15, 248);
            payment_StatusLabel.Name = "payment_StatusLabel";
            payment_StatusLabel.Size = new System.Drawing.Size(156, 25);
            payment_StatusLabel.TabIndex = 9;
            payment_StatusLabel.Text = "Payment Status:";
            // 
            // mathari_Level_5_HospitalDataSet
            // 
            this.mathari_Level_5_HospitalDataSet.DataSetName = "Mathari_Level_5_HospitalDataSet";
            this.mathari_Level_5_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supply_Chain_TableBindingSource
            // 
            this.supply_Chain_TableBindingSource.DataMember = "Supply Chain Table";
            this.supply_Chain_TableBindingSource.DataSource = this.mathari_Level_5_HospitalDataSet;
            // 
            // supply_Chain_TableTableAdapter
            // 
            this.supply_Chain_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Billing_and_Accounting_TableTableAdapter = null;
            this.tableAdapterManager.Departments_TableTableAdapter = null;
            this.tableAdapterManager.Employees__TableTableAdapter = null;
            this.tableAdapterManager.Patient_s_TableTableAdapter = null;
            this.tableAdapterManager.Pharmacy_Management_TableTableAdapter = null;
            this.tableAdapterManager.Rooms_TableTableAdapter = null;
            this.tableAdapterManager.Supply_Chain_TableTableAdapter = this.supply_Chain_TableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Wards_TableTableAdapter = null;
            // 
            // supply_Chain_TableBindingNavigator
            // 
            this.supply_Chain_TableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.supply_Chain_TableBindingNavigator.BindingSource = this.supply_Chain_TableBindingSource;
            this.supply_Chain_TableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.supply_Chain_TableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.supply_Chain_TableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.supply_Chain_TableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.supply_Chain_TableBindingNavigatorSaveItem});
            this.supply_Chain_TableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.supply_Chain_TableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.supply_Chain_TableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.supply_Chain_TableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.supply_Chain_TableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.supply_Chain_TableBindingNavigator.Name = "supply_Chain_TableBindingNavigator";
            this.supply_Chain_TableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.supply_Chain_TableBindingNavigator.Size = new System.Drawing.Size(1120, 31);
            this.supply_Chain_TableBindingNavigator.TabIndex = 0;
            this.supply_Chain_TableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
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
            // supply_Chain_TableBindingNavigatorSaveItem
            // 
            this.supply_Chain_TableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.supply_Chain_TableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("supply_Chain_TableBindingNavigatorSaveItem.Image")));
            this.supply_Chain_TableBindingNavigatorSaveItem.Name = "supply_Chain_TableBindingNavigatorSaveItem";
            this.supply_Chain_TableBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.supply_Chain_TableBindingNavigatorSaveItem.Text = "Save Data";
            this.supply_Chain_TableBindingNavigatorSaveItem.Click += new System.EventHandler(this.supply_Chain_TableBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supply_Chain_TableBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iDTextBox.Location = new System.Drawing.Point(196, 52);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(275, 30);
            this.iDTextBox.TabIndex = 2;
            // 
            // supplier_NameTextBox
            // 
            this.supplier_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supply_Chain_TableBindingSource, "Supplier Name", true));
            this.supplier_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.supplier_NameTextBox.Location = new System.Drawing.Point(196, 104);
            this.supplier_NameTextBox.Name = "supplier_NameTextBox";
            this.supplier_NameTextBox.Size = new System.Drawing.Size(275, 30);
            this.supplier_NameTextBox.TabIndex = 4;
            this.supplier_NameTextBox.TextChanged += new System.EventHandler(this.supplier_NameTextBox_TextChanged);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supply_Chain_TableBindingSource, "Phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.phoneTextBox.Location = new System.Drawing.Point(196, 148);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(275, 30);
            this.phoneTextBox.TabIndex = 6;
            // 
            // suppliesTextBox
            // 
            this.suppliesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supply_Chain_TableBindingSource, "Supplies", true));
            this.suppliesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.suppliesTextBox.Location = new System.Drawing.Point(196, 194);
            this.suppliesTextBox.Name = "suppliesTextBox";
            this.suppliesTextBox.Size = new System.Drawing.Size(275, 30);
            this.suppliesTextBox.TabIndex = 8;
            // 
            // payment_StatusTextBox
            // 
            this.payment_StatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supply_Chain_TableBindingSource, "Payment Status", true));
            this.payment_StatusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.payment_StatusTextBox.Location = new System.Drawing.Point(196, 243);
            this.payment_StatusTextBox.Name = "payment_StatusTextBox";
            this.payment_StatusTextBox.Size = new System.Drawing.Size(275, 30);
            this.payment_StatusTextBox.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(84, 295);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(387, 30);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(3, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(464, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 42);
            this.button1.TabIndex = 29;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBack.Location = new System.Drawing.Point(133, 579);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 42);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // supply_Chain_TableDataGridView
            // 
            this.supply_Chain_TableDataGridView.AutoGenerateColumns = false;
            this.supply_Chain_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supply_Chain_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.supply_Chain_TableDataGridView.DataSource = this.supply_Chain_TableBindingSource;
            this.supply_Chain_TableDataGridView.Location = new System.Drawing.Point(8, 340);
            this.supply_Chain_TableDataGridView.MaximumSize = new System.Drawing.Size(1100, 220);
            this.supply_Chain_TableDataGridView.MinimumSize = new System.Drawing.Size(1100, 220);
            this.supply_Chain_TableDataGridView.Name = "supply_Chain_TableDataGridView";
            this.supply_Chain_TableDataGridView.RowHeadersWidth = 51;
            this.supply_Chain_TableDataGridView.RowTemplate.Height = 24;
            this.supply_Chain_TableDataGridView.Size = new System.Drawing.Size(1100, 220);
            this.supply_Chain_TableDataGridView.TabIndex = 29;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Supplier Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Supplier Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Supplies";
            this.dataGridViewTextBoxColumn4.HeaderText = "Supplies";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Payment Status";
            this.dataGridViewTextBoxColumn5.HeaderText = "Payment Status";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 632);
            this.Controls.Add(this.supply_Chain_TableDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(payment_StatusLabel);
            this.Controls.Add(this.payment_StatusTextBox);
            this.Controls.Add(suppliesLabel);
            this.Controls.Add(this.suppliesTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(supplier_NameLabel);
            this.Controls.Add(this.supplier_NameTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.supply_Chain_TableBindingNavigator);
            this.MaximumSize = new System.Drawing.Size(1138, 679);
            this.MinimumSize = new System.Drawing.Size(1138, 679);
            this.Name = "Form9";
            this.Text = "Supply Chain Management";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mathari_Level_5_HospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supply_Chain_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supply_Chain_TableBindingNavigator)).EndInit();
            this.supply_Chain_TableBindingNavigator.ResumeLayout(false);
            this.supply_Chain_TableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supply_Chain_TableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mathari_Level_5_HospitalDataSet mathari_Level_5_HospitalDataSet;
        private System.Windows.Forms.BindingSource supply_Chain_TableBindingSource;
        private Mathari_Level_5_HospitalDataSetTableAdapters.Supply_Chain_TableTableAdapter supply_Chain_TableTableAdapter;
        private Mathari_Level_5_HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator supply_Chain_TableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton supply_Chain_TableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox supplier_NameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox suppliesTextBox;
        private System.Windows.Forms.TextBox payment_StatusTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView supply_Chain_TableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}