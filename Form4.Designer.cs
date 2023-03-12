namespace Mathari_Level_5_Hospital
{
    partial class Form4
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
            System.Windows.Forms.Label department_NameLabel;
            System.Windows.Forms.Label head_of_DepartmentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.mathari_Level_5_HospitalDataSet = new Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSet();
            this.departments_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departments_TableTableAdapter = new Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSetTableAdapters.Departments_TableTableAdapter();
            this.tableAdapterManager = new Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSetTableAdapters.TableAdapterManager();
            this.departments_TableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.departments_TableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.department_NameTextBox = new System.Windows.Forms.TextBox();
            this.head_of_DepartmentTextBox = new System.Windows.Forms.TextBox();
            this.departments_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            department_NameLabel = new System.Windows.Forms.Label();
            head_of_DepartmentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mathari_Level_5_HospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departments_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departments_TableBindingNavigator)).BeginInit();
            this.departments_TableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departments_TableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            iDLabel.Location = new System.Drawing.Point(74, 60);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(37, 25);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // department_NameLabel
            // 
            department_NameLabel.AutoSize = true;
            department_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            department_NameLabel.Location = new System.Drawing.Point(74, 106);
            department_NameLabel.Name = "department_NameLabel";
            department_NameLabel.Size = new System.Drawing.Size(176, 25);
            department_NameLabel.TabIndex = 3;
            department_NameLabel.Text = "Department Name:";
            // 
            // head_of_DepartmentLabel
            // 
            head_of_DepartmentLabel.AutoSize = true;
            head_of_DepartmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            head_of_DepartmentLabel.Location = new System.Drawing.Point(74, 148);
            head_of_DepartmentLabel.Name = "head_of_DepartmentLabel";
            head_of_DepartmentLabel.Size = new System.Drawing.Size(192, 25);
            head_of_DepartmentLabel.TabIndex = 5;
            head_of_DepartmentLabel.Text = "Head of Department:";
            // 
            // mathari_Level_5_HospitalDataSet
            // 
            this.mathari_Level_5_HospitalDataSet.DataSetName = "Mathari_Level_5_HospitalDataSet";
            this.mathari_Level_5_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departments_TableBindingSource
            // 
            this.departments_TableBindingSource.DataMember = "Departments Table";
            this.departments_TableBindingSource.DataSource = this.mathari_Level_5_HospitalDataSet;
            // 
            // departments_TableTableAdapter
            // 
            this.departments_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Billing_and_Accounting_TableTableAdapter = null;
            this.tableAdapterManager.Departments_TableTableAdapter = this.departments_TableTableAdapter;
            this.tableAdapterManager.Employees__TableTableAdapter = null;
            this.tableAdapterManager.Patient_s_TableTableAdapter = null;
            this.tableAdapterManager.Pharmacy_Management_TableTableAdapter = null;
            this.tableAdapterManager.Rooms_TableTableAdapter = null;
            this.tableAdapterManager.Supply_Chain_TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Wards_TableTableAdapter = null;
            // 
            // departments_TableBindingNavigator
            // 
            this.departments_TableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.departments_TableBindingNavigator.BindingSource = this.departments_TableBindingSource;
            this.departments_TableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.departments_TableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.departments_TableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.departments_TableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.departments_TableBindingNavigatorSaveItem});
            this.departments_TableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.departments_TableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.departments_TableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.departments_TableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.departments_TableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.departments_TableBindingNavigator.Name = "departments_TableBindingNavigator";
            this.departments_TableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.departments_TableBindingNavigator.Size = new System.Drawing.Size(870, 27);
            this.departments_TableBindingNavigator.TabIndex = 0;
            this.departments_TableBindingNavigator.Text = "bindingNavigator1";
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
            // departments_TableBindingNavigatorSaveItem
            // 
            this.departments_TableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.departments_TableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("departments_TableBindingNavigatorSaveItem.Image")));
            this.departments_TableBindingNavigatorSaveItem.Name = "departments_TableBindingNavigatorSaveItem";
            this.departments_TableBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.departments_TableBindingNavigatorSaveItem.Text = "Save Data";
            this.departments_TableBindingNavigatorSaveItem.Click += new System.EventHandler(this.departments_TableBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departments_TableBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iDTextBox.Location = new System.Drawing.Point(280, 60);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(273, 30);
            this.iDTextBox.TabIndex = 2;
            // 
            // department_NameTextBox
            // 
            this.department_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departments_TableBindingSource, "Department Name", true));
            this.department_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.department_NameTextBox.Location = new System.Drawing.Point(280, 106);
            this.department_NameTextBox.Name = "department_NameTextBox";
            this.department_NameTextBox.Size = new System.Drawing.Size(273, 30);
            this.department_NameTextBox.TabIndex = 4;
            // 
            // head_of_DepartmentTextBox
            // 
            this.head_of_DepartmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departments_TableBindingSource, "Head of Department", true));
            this.head_of_DepartmentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.head_of_DepartmentTextBox.Location = new System.Drawing.Point(280, 145);
            this.head_of_DepartmentTextBox.Name = "head_of_DepartmentTextBox";
            this.head_of_DepartmentTextBox.Size = new System.Drawing.Size(273, 30);
            this.head_of_DepartmentTextBox.TabIndex = 6;
            // 
            // departments_TableDataGridView
            // 
            this.departments_TableDataGridView.AutoGenerateColumns = false;
            this.departments_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departments_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.departments_TableDataGridView.DataSource = this.departments_TableBindingSource;
            this.departments_TableDataGridView.Location = new System.Drawing.Point(0, 268);
            this.departments_TableDataGridView.MaximumSize = new System.Drawing.Size(858, 220);
            this.departments_TableDataGridView.MinimumSize = new System.Drawing.Size(858, 220);
            this.departments_TableDataGridView.Name = "departments_TableDataGridView";
            this.departments_TableDataGridView.RowHeadersWidth = 51;
            this.departments_TableDataGridView.RowTemplate.Height = 24;
            this.departments_TableDataGridView.Size = new System.Drawing.Size(858, 220);
            this.departments_TableDataGridView.TabIndex = 7;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Department Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Department Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Head of Department";
            this.dataGridViewTextBoxColumn3.HeaderText = "Head of Department";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(75, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearch.Location = new System.Drawing.Point(161, 226);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(392, 26);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Cornsilk;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBack.Location = new System.Drawing.Point(70, 514);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 42);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(348, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 42);
            this.button1.TabIndex = 16;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(870, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departments_TableDataGridView);
            this.Controls.Add(head_of_DepartmentLabel);
            this.Controls.Add(this.head_of_DepartmentTextBox);
            this.Controls.Add(department_NameLabel);
            this.Controls.Add(this.department_NameTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.departments_TableBindingNavigator);
            this.MaximumSize = new System.Drawing.Size(888, 605);
            this.MinimumSize = new System.Drawing.Size(888, 605);
            this.Name = "Form4";
            this.Text = "Our Departments";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mathari_Level_5_HospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departments_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departments_TableBindingNavigator)).EndInit();
            this.departments_TableBindingNavigator.ResumeLayout(false);
            this.departments_TableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departments_TableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mathari_Level_5_HospitalDataSet mathari_Level_5_HospitalDataSet;
        private System.Windows.Forms.BindingSource departments_TableBindingSource;
        private Mathari_Level_5_HospitalDataSetTableAdapters.Departments_TableTableAdapter departments_TableTableAdapter;
        private Mathari_Level_5_HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator departments_TableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton departments_TableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox department_NameTextBox;
        private System.Windows.Forms.TextBox head_of_DepartmentTextBox;
        private System.Windows.Forms.DataGridView departments_TableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
    }
}