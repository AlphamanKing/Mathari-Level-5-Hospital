﻿namespace Mathari_Level_5_Hospital
{
    partial class Form8
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
            System.Windows.Forms.Label room_NameLabel;
            System.Windows.Forms.Label capacityLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.mathari_Level_5_HospitalDataSet = new Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSet();
            this.rooms_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rooms_TableTableAdapter = new Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSetTableAdapters.Rooms_TableTableAdapter();
            this.tableAdapterManager = new Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSetTableAdapters.TableAdapterManager();
            this.rooms_TableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.rooms_TableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.room_NameTextBox = new System.Windows.Forms.TextBox();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rooms_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            room_NameLabel = new System.Windows.Forms.Label();
            capacityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mathari_Level_5_HospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rooms_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rooms_TableBindingNavigator)).BeginInit();
            this.rooms_TableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rooms_TableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            iDLabel.Location = new System.Drawing.Point(11, 67);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(37, 25);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // room_NameLabel
            // 
            room_NameLabel.AutoSize = true;
            room_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            room_NameLabel.Location = new System.Drawing.Point(10, 111);
            room_NameLabel.Name = "room_NameLabel";
            room_NameLabel.Size = new System.Drawing.Size(126, 25);
            room_NameLabel.TabIndex = 3;
            room_NameLabel.Text = "Room Name:";
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            capacityLabel.Location = new System.Drawing.Point(10, 150);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new System.Drawing.Size(95, 25);
            capacityLabel.TabIndex = 5;
            capacityLabel.Text = "Capacity:";
            // 
            // mathari_Level_5_HospitalDataSet
            // 
            this.mathari_Level_5_HospitalDataSet.DataSetName = "Mathari_Level_5_HospitalDataSet";
            this.mathari_Level_5_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rooms_TableBindingSource
            // 
            this.rooms_TableBindingSource.DataMember = "Rooms Table";
            this.rooms_TableBindingSource.DataSource = this.mathari_Level_5_HospitalDataSet;
            // 
            // rooms_TableTableAdapter
            // 
            this.rooms_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Billing_and_Accounting_TableTableAdapter = null;
            this.tableAdapterManager.Departments_TableTableAdapter = null;
            this.tableAdapterManager.Employees__TableTableAdapter = null;
            this.tableAdapterManager.Patient_s_TableTableAdapter = null;
            this.tableAdapterManager.Pharmacy_Management_TableTableAdapter = null;
            this.tableAdapterManager.Rooms_TableTableAdapter = this.rooms_TableTableAdapter;
            this.tableAdapterManager.Supply_Chain_TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Wards_TableTableAdapter = null;
            // 
            // rooms_TableBindingNavigator
            // 
            this.rooms_TableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rooms_TableBindingNavigator.BindingSource = this.rooms_TableBindingSource;
            this.rooms_TableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rooms_TableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rooms_TableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rooms_TableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.rooms_TableBindingNavigatorSaveItem});
            this.rooms_TableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rooms_TableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rooms_TableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rooms_TableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rooms_TableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rooms_TableBindingNavigator.Name = "rooms_TableBindingNavigator";
            this.rooms_TableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rooms_TableBindingNavigator.Size = new System.Drawing.Size(887, 31);
            this.rooms_TableBindingNavigator.TabIndex = 0;
            this.rooms_TableBindingNavigator.Text = "bindingNavigator1";
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
            // rooms_TableBindingNavigatorSaveItem
            // 
            this.rooms_TableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rooms_TableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rooms_TableBindingNavigatorSaveItem.Image")));
            this.rooms_TableBindingNavigatorSaveItem.Name = "rooms_TableBindingNavigatorSaveItem";
            this.rooms_TableBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.rooms_TableBindingNavigatorSaveItem.Text = "Save Data";
            this.rooms_TableBindingNavigatorSaveItem.Click += new System.EventHandler(this.rooms_TableBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rooms_TableBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iDTextBox.Location = new System.Drawing.Point(141, 62);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(288, 30);
            this.iDTextBox.TabIndex = 2;
            // 
            // room_NameTextBox
            // 
            this.room_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rooms_TableBindingSource, "Room Name", true));
            this.room_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.room_NameTextBox.Location = new System.Drawing.Point(141, 106);
            this.room_NameTextBox.Name = "room_NameTextBox";
            this.room_NameTextBox.Size = new System.Drawing.Size(288, 30);
            this.room_NameTextBox.TabIndex = 4;
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rooms_TableBindingSource, "Capacity", true));
            this.capacityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.capacityTextBox.Location = new System.Drawing.Point(141, 150);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(288, 30);
            this.capacityTextBox.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(90, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 30);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(9, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search";
            // 
            // rooms_TableDataGridView
            // 
            this.rooms_TableDataGridView.AutoGenerateColumns = false;
            this.rooms_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rooms_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.rooms_TableDataGridView.DataSource = this.rooms_TableBindingSource;
            this.rooms_TableDataGridView.Location = new System.Drawing.Point(20, 259);
            this.rooms_TableDataGridView.MaximumSize = new System.Drawing.Size(842, 220);
            this.rooms_TableDataGridView.MinimumSize = new System.Drawing.Size(842, 220);
            this.rooms_TableDataGridView.Name = "rooms_TableDataGridView";
            this.rooms_TableDataGridView.RowHeadersWidth = 51;
            this.rooms_TableDataGridView.RowTemplate.Height = 24;
            this.rooms_TableDataGridView.Size = new System.Drawing.Size(842, 220);
            this.rooms_TableDataGridView.TabIndex = 12;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Room Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Room Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Capacity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Capacity";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(294, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 42);
            this.button1.TabIndex = 27;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBack.Location = new System.Drawing.Point(20, 507);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 42);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 568);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rooms_TableDataGridView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(capacityLabel);
            this.Controls.Add(this.capacityTextBox);
            this.Controls.Add(room_NameLabel);
            this.Controls.Add(this.room_NameTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.rooms_TableBindingNavigator);
            this.MaximumSize = new System.Drawing.Size(905, 615);
            this.MinimumSize = new System.Drawing.Size(905, 615);
            this.Name = "Form8";
            this.Text = "Our Rooms";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mathari_Level_5_HospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rooms_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rooms_TableBindingNavigator)).EndInit();
            this.rooms_TableBindingNavigator.ResumeLayout(false);
            this.rooms_TableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rooms_TableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mathari_Level_5_HospitalDataSet mathari_Level_5_HospitalDataSet;
        private System.Windows.Forms.BindingSource rooms_TableBindingSource;
        private Mathari_Level_5_HospitalDataSetTableAdapters.Rooms_TableTableAdapter rooms_TableTableAdapter;
        private Mathari_Level_5_HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rooms_TableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton rooms_TableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox room_NameTextBox;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView rooms_TableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
    }
}