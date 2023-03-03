namespace Mathari_Level_5_Hospital
{
    partial class Form3
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
            System.Windows.Forms.Label transaction_nameLabel;
            System.Windows.Forms.Label transaction_typeLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label transaction_DateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.mathari_Level_5_HospitalDataSet = new Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSet();
            this.billing_and_Accounting_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billing_and_Accounting_TableTableAdapter = new Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSetTableAdapters.Billing_and_Accounting_TableTableAdapter();
            this.tableAdapterManager = new Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSetTableAdapters.TableAdapterManager();
            this.billing_and_Accounting_TableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnToolStrip = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.transaction_nameTextBox = new System.Windows.Forms.TextBox();
            this.transaction_typeTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.transaction_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.billing_and_Accounting_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            transaction_nameLabel = new System.Windows.Forms.Label();
            transaction_typeLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            transaction_DateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mathari_Level_5_HospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_and_Accounting_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_and_Accounting_TableBindingNavigator)).BeginInit();
            this.billing_and_Accounting_TableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billing_and_Accounting_TableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            iDLabel.Location = new System.Drawing.Point(35, 67);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(37, 25);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            iDLabel.Click += new System.EventHandler(this.iDLabel_Click);
            // 
            // transaction_nameLabel
            // 
            transaction_nameLabel.AutoSize = true;
            transaction_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            transaction_nameLabel.Location = new System.Drawing.Point(32, 114);
            transaction_nameLabel.Name = "transaction_nameLabel";
            transaction_nameLabel.Size = new System.Drawing.Size(175, 25);
            transaction_nameLabel.TabIndex = 3;
            transaction_nameLabel.Text = "Transaction name:";
            // 
            // transaction_typeLabel
            // 
            transaction_typeLabel.AutoSize = true;
            transaction_typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            transaction_typeLabel.Location = new System.Drawing.Point(32, 164);
            transaction_typeLabel.Name = "transaction_typeLabel";
            transaction_typeLabel.Size = new System.Drawing.Size(163, 25);
            transaction_typeLabel.TabIndex = 5;
            transaction_typeLabel.Text = "Transaction type:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            amountLabel.Location = new System.Drawing.Point(35, 218);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(86, 25);
            amountLabel.TabIndex = 7;
            amountLabel.Text = "Amount:";
            amountLabel.Click += new System.EventHandler(this.amountLabel_Click);
            // 
            // transaction_DateLabel
            // 
            transaction_DateLabel.AutoSize = true;
            transaction_DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            transaction_DateLabel.Location = new System.Drawing.Point(40, 270);
            transaction_DateLabel.Name = "transaction_DateLabel";
            transaction_DateLabel.Size = new System.Drawing.Size(167, 25);
            transaction_DateLabel.TabIndex = 9;
            transaction_DateLabel.Text = "Transaction Date:";
            // 
            // mathari_Level_5_HospitalDataSet
            // 
            this.mathari_Level_5_HospitalDataSet.DataSetName = "Mathari_Level_5_HospitalDataSet";
            this.mathari_Level_5_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billing_and_Accounting_TableBindingSource
            // 
            this.billing_and_Accounting_TableBindingSource.DataMember = "Billing and Accounting Table";
            this.billing_and_Accounting_TableBindingSource.DataSource = this.mathari_Level_5_HospitalDataSet;
            // 
            // billing_and_Accounting_TableTableAdapter
            // 
            this.billing_and_Accounting_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Billing_and_Accounting_TableTableAdapter = this.billing_and_Accounting_TableTableAdapter;
            this.tableAdapterManager.Departments_TableTableAdapter = null;
            this.tableAdapterManager.Employees__TableTableAdapter = null;
            this.tableAdapterManager.Patient_s_TableTableAdapter = null;
            this.tableAdapterManager.Pharmacy_Management_TableTableAdapter = null;
            this.tableAdapterManager.Rooms_TableTableAdapter = null;
            this.tableAdapterManager.Supply_Chain_TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Wards_TableTableAdapter = null;
            // 
            // billing_and_Accounting_TableBindingNavigator
            // 
            this.billing_and_Accounting_TableBindingNavigator.AddNewItem = this.btnAdd;
            this.billing_and_Accounting_TableBindingNavigator.BindingSource = this.billing_and_Accounting_TableBindingSource;
            this.billing_and_Accounting_TableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.billing_and_Accounting_TableBindingNavigator.DeleteItem = this.btnDelete;
            this.billing_and_Accounting_TableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.billing_and_Accounting_TableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnAdd,
            this.btnDelete,
            this.btnSave,
            this.btnToolStrip});
            this.billing_and_Accounting_TableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.billing_and_Accounting_TableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.billing_and_Accounting_TableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.billing_and_Accounting_TableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.billing_and_Accounting_TableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.billing_and_Accounting_TableBindingNavigator.Name = "billing_and_Accounting_TableBindingNavigator";
            this.billing_and_Accounting_TableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.billing_and_Accounting_TableBindingNavigator.Size = new System.Drawing.Size(745, 27);
            this.billing_and_Accounting_TableBindingNavigator.TabIndex = 0;
            this.billing_and_Accounting_TableBindingNavigator.Text = "bindingNavigator1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(29, 24);
            this.btnAdd.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(29, 24);
            this.btnDelete.Text = "Delete";
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
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(29, 24);
            this.btnSave.Text = "Save Data";
            this.btnSave.Click += new System.EventHandler(this.billing_and_Accounting_TableBindingNavigatorSaveItem_Click);
            // 
            // btnToolStrip
            // 
            this.btnToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnToolStrip.Image")));
            this.btnToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolStrip.Name = "btnToolStrip";
            this.btnToolStrip.Size = new System.Drawing.Size(29, 24);
            this.btnToolStrip.Text = "btnToolStrip";
            this.btnToolStrip.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billing_and_Accounting_TableBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iDTextBox.Location = new System.Drawing.Point(220, 62);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(253, 30);
            this.iDTextBox.TabIndex = 2;
            // 
            // transaction_nameTextBox
            // 
            this.transaction_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billing_and_Accounting_TableBindingSource, "Transaction name", true));
            this.transaction_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.transaction_nameTextBox.Location = new System.Drawing.Point(220, 109);
            this.transaction_nameTextBox.Name = "transaction_nameTextBox";
            this.transaction_nameTextBox.Size = new System.Drawing.Size(253, 30);
            this.transaction_nameTextBox.TabIndex = 4;
            // 
            // transaction_typeTextBox
            // 
            this.transaction_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billing_and_Accounting_TableBindingSource, "Transaction type", true));
            this.transaction_typeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.transaction_typeTextBox.Location = new System.Drawing.Point(220, 159);
            this.transaction_typeTextBox.Name = "transaction_typeTextBox";
            this.transaction_typeTextBox.Size = new System.Drawing.Size(253, 30);
            this.transaction_typeTextBox.TabIndex = 6;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billing_and_Accounting_TableBindingSource, "Amount", true));
            this.amountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.amountTextBox.Location = new System.Drawing.Point(220, 213);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(253, 30);
            this.amountTextBox.TabIndex = 8;
            // 
            // transaction_DateDateTimePicker
            // 
            this.transaction_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.billing_and_Accounting_TableBindingSource, "Transaction Date", true));
            this.transaction_DateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.transaction_DateDateTimePicker.Location = new System.Drawing.Point(220, 266);
            this.transaction_DateDateTimePicker.Name = "transaction_DateDateTimePicker";
            this.transaction_DateDateTimePicker.Size = new System.Drawing.Size(253, 30);
            this.transaction_DateDateTimePicker.TabIndex = 10;
            // 
            // billing_and_Accounting_TableDataGridView
            // 
            this.billing_and_Accounting_TableDataGridView.AutoGenerateColumns = false;
            this.billing_and_Accounting_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billing_and_Accounting_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.billing_and_Accounting_TableDataGridView.DataSource = this.billing_and_Accounting_TableBindingSource;
            this.billing_and_Accounting_TableDataGridView.Location = new System.Drawing.Point(0, 402);
            this.billing_and_Accounting_TableDataGridView.Name = "billing_and_Accounting_TableDataGridView";
            this.billing_and_Accounting_TableDataGridView.RowHeadersWidth = 51;
            this.billing_and_Accounting_TableDataGridView.RowTemplate.Height = 24;
            this.billing_and_Accounting_TableDataGridView.Size = new System.Drawing.Size(679, 220);
            this.billing_and_Accounting_TableDataGridView.TabIndex = 11;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Transaction name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Transaction name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Transaction type";
            this.dataGridViewTextBoxColumn3.HeaderText = "Transaction type";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Transaction Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Transaction Date";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(102, 361);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 26);
            this.textBox1.TabIndex = 13;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBack.Location = new System.Drawing.Point(91, 638);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 42);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(396, 638);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 42);
            this.button1.TabIndex = 15;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 683);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.billing_and_Accounting_TableDataGridView);
            this.Controls.Add(transaction_DateLabel);
            this.Controls.Add(this.transaction_DateDateTimePicker);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(transaction_typeLabel);
            this.Controls.Add(this.transaction_typeTextBox);
            this.Controls.Add(transaction_nameLabel);
            this.Controls.Add(this.transaction_nameTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.billing_and_Accounting_TableBindingNavigator);
            this.MaximumSize = new System.Drawing.Size(763, 730);
            this.MinimumSize = new System.Drawing.Size(763, 730);
            this.Name = "Form3";
            this.Text = "Billing and Accounting";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mathari_Level_5_HospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_and_Accounting_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_and_Accounting_TableBindingNavigator)).EndInit();
            this.billing_and_Accounting_TableBindingNavigator.ResumeLayout(false);
            this.billing_and_Accounting_TableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billing_and_Accounting_TableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mathari_Level_5_HospitalDataSet mathari_Level_5_HospitalDataSet;
        private System.Windows.Forms.BindingSource billing_and_Accounting_TableBindingSource;
        private Mathari_Level_5_HospitalDataSetTableAdapters.Billing_and_Accounting_TableTableAdapter billing_and_Accounting_TableTableAdapter;
        private Mathari_Level_5_HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator billing_and_Accounting_TableBindingNavigator;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox transaction_nameTextBox;
        private System.Windows.Forms.TextBox transaction_typeTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ToolStripButton btnToolStrip;
        private System.Windows.Forms.DateTimePicker transaction_DateDateTimePicker;
        private System.Windows.Forms.DataGridView billing_and_Accounting_TableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
    }
}