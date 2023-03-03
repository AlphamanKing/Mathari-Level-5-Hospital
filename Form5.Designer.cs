namespace Mathari_Level_5_Hospital
{
    partial class Form5
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
            System.Windows.Forms.Label employee_NameLabel;
            System.Windows.Forms.Label designationLabel;
            System.Windows.Forms.Label phoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.mathari_Level_5_HospitalDataSet = new Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSet();
            this.employees__TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employees__TableTableAdapter = new Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSetTableAdapters.Employees__TableTableAdapter();
            this.tableAdapterManager = new Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSetTableAdapters.TableAdapterManager();
            this.employees__TableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.employees__TableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.employee_NameTextBox = new System.Windows.Forms.TextBox();
            this.designationTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.employees__TableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            employee_NameLabel = new System.Windows.Forms.Label();
            designationLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mathari_Level_5_HospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees__TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees__TableBindingNavigator)).BeginInit();
            this.employees__TableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employees__TableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            iDLabel.Location = new System.Drawing.Point(37, 64);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(37, 25);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // employee_NameLabel
            // 
            employee_NameLabel.AutoSize = true;
            employee_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            employee_NameLabel.Location = new System.Drawing.Point(33, 101);
            employee_NameLabel.Name = "employee_NameLabel";
            employee_NameLabel.Size = new System.Drawing.Size(162, 25);
            employee_NameLabel.TabIndex = 3;
            employee_NameLabel.Text = "Employee Name:";
            // 
            // designationLabel
            // 
            designationLabel.AutoSize = true;
            designationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            designationLabel.Location = new System.Drawing.Point(31, 133);
            designationLabel.Name = "designationLabel";
            designationLabel.Size = new System.Drawing.Size(121, 25);
            designationLabel.TabIndex = 5;
            designationLabel.Text = "Designation:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            phoneLabel.Location = new System.Drawing.Point(34, 170);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(75, 25);
            phoneLabel.TabIndex = 7;
            phoneLabel.Text = "Phone:";
            // 
            // mathari_Level_5_HospitalDataSet
            // 
            this.mathari_Level_5_HospitalDataSet.DataSetName = "Mathari_Level_5_HospitalDataSet";
            this.mathari_Level_5_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employees__TableBindingSource
            // 
            this.employees__TableBindingSource.DataMember = "Employees\' Table";
            this.employees__TableBindingSource.DataSource = this.mathari_Level_5_HospitalDataSet;
            // 
            // employees__TableTableAdapter
            // 
            this.employees__TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Billing_and_Accounting_TableTableAdapter = null;
            this.tableAdapterManager.Departments_TableTableAdapter = null;
            this.tableAdapterManager.Employees__TableTableAdapter = this.employees__TableTableAdapter;
            this.tableAdapterManager.Patient_s_TableTableAdapter = null;
            this.tableAdapterManager.Pharmacy_Management_TableTableAdapter = null;
            this.tableAdapterManager.Rooms_TableTableAdapter = null;
            this.tableAdapterManager.Supply_Chain_TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Wards_TableTableAdapter = null;
            // 
            // employees__TableBindingNavigator
            // 
            this.employees__TableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employees__TableBindingNavigator.BindingSource = this.employees__TableBindingSource;
            this.employees__TableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employees__TableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employees__TableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.employees__TableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.employees__TableBindingNavigatorSaveItem});
            this.employees__TableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employees__TableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employees__TableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employees__TableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employees__TableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employees__TableBindingNavigator.Name = "employees__TableBindingNavigator";
            this.employees__TableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employees__TableBindingNavigator.Size = new System.Drawing.Size(952, 31);
            this.employees__TableBindingNavigator.TabIndex = 0;
            this.employees__TableBindingNavigator.Text = "bindingNavigator1";
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
            // employees__TableBindingNavigatorSaveItem
            // 
            this.employees__TableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employees__TableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employees__TableBindingNavigatorSaveItem.Image")));
            this.employees__TableBindingNavigatorSaveItem.Name = "employees__TableBindingNavigatorSaveItem";
            this.employees__TableBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.employees__TableBindingNavigatorSaveItem.Text = "Save Data";
            this.employees__TableBindingNavigatorSaveItem.Click += new System.EventHandler(this.employees__TableBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employees__TableBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iDTextBox.Location = new System.Drawing.Point(201, 59);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(280, 30);
            this.iDTextBox.TabIndex = 2;
            // 
            // employee_NameTextBox
            // 
            this.employee_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employees__TableBindingSource, "Employee Name", true));
            this.employee_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.employee_NameTextBox.Location = new System.Drawing.Point(201, 98);
            this.employee_NameTextBox.Name = "employee_NameTextBox";
            this.employee_NameTextBox.Size = new System.Drawing.Size(280, 30);
            this.employee_NameTextBox.TabIndex = 4;
            this.employee_NameTextBox.TextChanged += new System.EventHandler(this.employee_NameTextBox_TextChanged);
            // 
            // designationTextBox
            // 
            this.designationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employees__TableBindingSource, "Designation", true));
            this.designationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.designationTextBox.Location = new System.Drawing.Point(201, 134);
            this.designationTextBox.Name = "designationTextBox";
            this.designationTextBox.Size = new System.Drawing.Size(280, 30);
            this.designationTextBox.TabIndex = 6;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employees__TableBindingSource, "Phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.phoneTextBox.Location = new System.Drawing.Point(201, 170);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(280, 30);
            this.phoneTextBox.TabIndex = 8;
            // 
            // employees__TableDataGridView
            // 
            this.employees__TableDataGridView.AutoGenerateColumns = false;
            this.employees__TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employees__TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.employees__TableDataGridView.DataSource = this.employees__TableBindingSource;
            this.employees__TableDataGridView.Location = new System.Drawing.Point(0, 276);
            this.employees__TableDataGridView.MaximumSize = new System.Drawing.Size(952, 220);
            this.employees__TableDataGridView.MinimumSize = new System.Drawing.Size(952, 220);
            this.employees__TableDataGridView.Name = "employees__TableDataGridView";
            this.employees__TableDataGridView.RowHeadersWidth = 51;
            this.employees__TableDataGridView.RowTemplate.Height = 24;
            this.employees__TableDataGridView.Size = new System.Drawing.Size(952, 220);
            this.employees__TableDataGridView.TabIndex = 9;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Employee Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Employee Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Designation";
            this.dataGridViewTextBoxColumn3.HeaderText = "Designation";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(37, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 231);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 22);
            this.textBox1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(372, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 42);
            this.button1.TabIndex = 18;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBack.Location = new System.Drawing.Point(94, 525);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 42);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 579);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employees__TableDataGridView);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(designationLabel);
            this.Controls.Add(this.designationTextBox);
            this.Controls.Add(employee_NameLabel);
            this.Controls.Add(this.employee_NameTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.employees__TableBindingNavigator);
            this.MaximumSize = new System.Drawing.Size(970, 626);
            this.MinimumSize = new System.Drawing.Size(970, 626);
            this.Name = "Form5";
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mathari_Level_5_HospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees__TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees__TableBindingNavigator)).EndInit();
            this.employees__TableBindingNavigator.ResumeLayout(false);
            this.employees__TableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employees__TableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mathari_Level_5_HospitalDataSet mathari_Level_5_HospitalDataSet;
        private System.Windows.Forms.BindingSource employees__TableBindingSource;
        private Mathari_Level_5_HospitalDataSetTableAdapters.Employees__TableTableAdapter employees__TableTableAdapter;
        private Mathari_Level_5_HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employees__TableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton employees__TableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox employee_NameTextBox;
        private System.Windows.Forms.TextBox designationTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.DataGridView employees__TableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
    }
}