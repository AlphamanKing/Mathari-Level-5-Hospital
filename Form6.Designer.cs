namespace Mathari_Level_5_Hospital
{
    partial class Form6
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
            System.Windows.Forms.Label patient_s_NameLabel;
            System.Windows.Forms.Label diagnosisLabel;
            System.Windows.Forms.Label doctorLabel;
            System.Windows.Forms.Label admissionLabel;
            System.Windows.Forms.Label dependant_s_NameLabel;
            System.Windows.Forms.Label payment_StatusLabel;
            System.Windows.Forms.Label bed_NoLabel;
            System.Windows.Forms.Label dependant_s_PhoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.mathari_Level_5_HospitalDataSet = new Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSet();
            this.patient_s_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patient_s_TableTableAdapter = new Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSetTableAdapters.Patient_s_TableTableAdapter();
            this.tableAdapterManager = new Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSetTableAdapters.TableAdapterManager();
            this.patient_s_TableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.patient_s_TableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.patient_s_NameTextBox = new System.Windows.Forms.TextBox();
            this.diagnosisTextBox = new System.Windows.Forms.TextBox();
            this.doctorTextBox = new System.Windows.Forms.TextBox();
            this.admissionTextBox = new System.Windows.Forms.TextBox();
            this.dependant_s_NameTextBox = new System.Windows.Forms.TextBox();
            this.payment_StatusTextBox = new System.Windows.Forms.TextBox();
            this.bed_NoTextBox = new System.Windows.Forms.TextBox();
            this.dependant_s_PhoneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.patient_s_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            patient_s_NameLabel = new System.Windows.Forms.Label();
            diagnosisLabel = new System.Windows.Forms.Label();
            doctorLabel = new System.Windows.Forms.Label();
            admissionLabel = new System.Windows.Forms.Label();
            dependant_s_NameLabel = new System.Windows.Forms.Label();
            payment_StatusLabel = new System.Windows.Forms.Label();
            bed_NoLabel = new System.Windows.Forms.Label();
            dependant_s_PhoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mathari_Level_5_HospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_s_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_s_TableBindingNavigator)).BeginInit();
            this.patient_s_TableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_s_TableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            iDLabel.Location = new System.Drawing.Point(40, 58);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(37, 25);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            iDLabel.Click += new System.EventHandler(this.iDLabel_Click);
            // 
            // patient_s_NameLabel
            // 
            patient_s_NameLabel.AutoSize = true;
            patient_s_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            patient_s_NameLabel.Location = new System.Drawing.Point(40, 113);
            patient_s_NameLabel.Name = "patient_s_NameLabel";
            patient_s_NameLabel.Size = new System.Drawing.Size(147, 25);
            patient_s_NameLabel.TabIndex = 3;
            patient_s_NameLabel.Text = "patient\'s Name:";
            // 
            // diagnosisLabel
            // 
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            diagnosisLabel.Location = new System.Drawing.Point(40, 158);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new System.Drawing.Size(104, 25);
            diagnosisLabel.TabIndex = 5;
            diagnosisLabel.Text = "Diagnosis:";
            // 
            // doctorLabel
            // 
            doctorLabel.AutoSize = true;
            doctorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            doctorLabel.Location = new System.Drawing.Point(40, 207);
            doctorLabel.Name = "doctorLabel";
            doctorLabel.Size = new System.Drawing.Size(75, 25);
            doctorLabel.TabIndex = 7;
            doctorLabel.Text = "Doctor:";
            // 
            // admissionLabel
            // 
            admissionLabel.AutoSize = true;
            admissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            admissionLabel.Location = new System.Drawing.Point(40, 250);
            admissionLabel.Name = "admissionLabel";
            admissionLabel.Size = new System.Drawing.Size(109, 25);
            admissionLabel.TabIndex = 9;
            admissionLabel.Text = "Admission:";
            admissionLabel.Click += new System.EventHandler(this.admissionLabel_Click);
            // 
            // dependant_s_NameLabel
            // 
            dependant_s_NameLabel.AutoSize = true;
            dependant_s_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dependant_s_NameLabel.Location = new System.Drawing.Point(527, 192);
            dependant_s_NameLabel.Name = "dependant_s_NameLabel";
            dependant_s_NameLabel.Size = new System.Drawing.Size(185, 25);
            dependant_s_NameLabel.TabIndex = 11;
            dependant_s_NameLabel.Text = "Dependant\'s Name:";
            dependant_s_NameLabel.Click += new System.EventHandler(this.dependant_s_NameLabel_Click);
            // 
            // payment_StatusLabel
            // 
            payment_StatusLabel.AutoSize = true;
            payment_StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            payment_StatusLabel.Location = new System.Drawing.Point(527, 96);
            payment_StatusLabel.Name = "payment_StatusLabel";
            payment_StatusLabel.Size = new System.Drawing.Size(156, 25);
            payment_StatusLabel.TabIndex = 13;
            payment_StatusLabel.Text = "Payment Status:";
            payment_StatusLabel.Click += new System.EventHandler(this.payment_StatusLabel_Click);
            // 
            // bed_NoLabel
            // 
            bed_NoLabel.AutoSize = true;
            bed_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            bed_NoLabel.Location = new System.Drawing.Point(527, 141);
            bed_NoLabel.Name = "bed_NoLabel";
            bed_NoLabel.Size = new System.Drawing.Size(83, 25);
            bed_NoLabel.TabIndex = 15;
            bed_NoLabel.Text = "Bed No:";
            // 
            // dependant_s_PhoneLabel
            // 
            dependant_s_PhoneLabel.AutoSize = true;
            dependant_s_PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dependant_s_PhoneLabel.Location = new System.Drawing.Point(527, 53);
            dependant_s_PhoneLabel.Name = "dependant_s_PhoneLabel";
            dependant_s_PhoneLabel.Size = new System.Drawing.Size(190, 25);
            dependant_s_PhoneLabel.TabIndex = 17;
            dependant_s_PhoneLabel.Text = "Dependant\'s Phone:";
            dependant_s_PhoneLabel.Click += new System.EventHandler(this.dependant_s_PhoneLabel_Click);
            // 
            // mathari_Level_5_HospitalDataSet
            // 
            this.mathari_Level_5_HospitalDataSet.DataSetName = "Mathari_Level_5_HospitalDataSet";
            this.mathari_Level_5_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patient_s_TableBindingSource
            // 
            this.patient_s_TableBindingSource.DataMember = "Patient\'s Table";
            this.patient_s_TableBindingSource.DataSource = this.mathari_Level_5_HospitalDataSet;
            // 
            // patient_s_TableTableAdapter
            // 
            this.patient_s_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Billing_and_Accounting_TableTableAdapter = null;
            this.tableAdapterManager.Departments_TableTableAdapter = null;
            this.tableAdapterManager.Employees__TableTableAdapter = null;
            this.tableAdapterManager.Patient_s_TableTableAdapter = this.patient_s_TableTableAdapter;
            this.tableAdapterManager.Pharmacy_Management_TableTableAdapter = null;
            this.tableAdapterManager.Rooms_TableTableAdapter = null;
            this.tableAdapterManager.Supply_Chain_TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Mathari_Level_5_Hospital.Mathari_Level_5_HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Wards_TableTableAdapter = null;
            // 
            // patient_s_TableBindingNavigator
            // 
            this.patient_s_TableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patient_s_TableBindingNavigator.BindingSource = this.patient_s_TableBindingSource;
            this.patient_s_TableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patient_s_TableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patient_s_TableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.patient_s_TableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.patient_s_TableBindingNavigatorSaveItem});
            this.patient_s_TableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patient_s_TableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patient_s_TableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patient_s_TableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patient_s_TableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patient_s_TableBindingNavigator.Name = "patient_s_TableBindingNavigator";
            this.patient_s_TableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patient_s_TableBindingNavigator.Size = new System.Drawing.Size(1183, 27);
            this.patient_s_TableBindingNavigator.TabIndex = 0;
            this.patient_s_TableBindingNavigator.Text = "bindingNavigator1";
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
            // patient_s_TableBindingNavigatorSaveItem
            // 
            this.patient_s_TableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patient_s_TableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patient_s_TableBindingNavigatorSaveItem.Image")));
            this.patient_s_TableBindingNavigatorSaveItem.Name = "patient_s_TableBindingNavigatorSaveItem";
            this.patient_s_TableBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.patient_s_TableBindingNavigatorSaveItem.Text = "Save Data";
            this.patient_s_TableBindingNavigatorSaveItem.Click += new System.EventHandler(this.patient_s_TableBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_s_TableBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iDTextBox.Location = new System.Drawing.Point(193, 53);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(220, 30);
            this.iDTextBox.TabIndex = 2;
            this.iDTextBox.TextChanged += new System.EventHandler(this.iDTextBox_TextChanged);
            // 
            // patient_s_NameTextBox
            // 
            this.patient_s_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_s_TableBindingSource, "patient\'s Name", true));
            this.patient_s_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.patient_s_NameTextBox.Location = new System.Drawing.Point(193, 108);
            this.patient_s_NameTextBox.Name = "patient_s_NameTextBox";
            this.patient_s_NameTextBox.Size = new System.Drawing.Size(220, 30);
            this.patient_s_NameTextBox.TabIndex = 4;
            // 
            // diagnosisTextBox
            // 
            this.diagnosisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_s_TableBindingSource, "Diagnosis", true));
            this.diagnosisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.diagnosisTextBox.Location = new System.Drawing.Point(193, 152);
            this.diagnosisTextBox.Name = "diagnosisTextBox";
            this.diagnosisTextBox.Size = new System.Drawing.Size(220, 30);
            this.diagnosisTextBox.TabIndex = 6;
            // 
            // doctorTextBox
            // 
            this.doctorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_s_TableBindingSource, "Doctor", true));
            this.doctorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.doctorTextBox.Location = new System.Drawing.Point(193, 202);
            this.doctorTextBox.Name = "doctorTextBox";
            this.doctorTextBox.Size = new System.Drawing.Size(220, 30);
            this.doctorTextBox.TabIndex = 8;
            // 
            // admissionTextBox
            // 
            this.admissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_s_TableBindingSource, "Admission", true));
            this.admissionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.admissionTextBox.Location = new System.Drawing.Point(193, 250);
            this.admissionTextBox.Name = "admissionTextBox";
            this.admissionTextBox.Size = new System.Drawing.Size(220, 30);
            this.admissionTextBox.TabIndex = 10;
            this.admissionTextBox.TextChanged += new System.EventHandler(this.admissionTextBox_TextChanged);
            // 
            // dependant_s_NameTextBox
            // 
            this.dependant_s_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_s_TableBindingSource, "Dependant\'s Name", true));
            this.dependant_s_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dependant_s_NameTextBox.Location = new System.Drawing.Point(723, 187);
            this.dependant_s_NameTextBox.Name = "dependant_s_NameTextBox";
            this.dependant_s_NameTextBox.Size = new System.Drawing.Size(190, 30);
            this.dependant_s_NameTextBox.TabIndex = 12;
            // 
            // payment_StatusTextBox
            // 
            this.payment_StatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_s_TableBindingSource, "Payment Status", true));
            this.payment_StatusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.payment_StatusTextBox.Location = new System.Drawing.Point(723, 93);
            this.payment_StatusTextBox.Name = "payment_StatusTextBox";
            this.payment_StatusTextBox.Size = new System.Drawing.Size(190, 30);
            this.payment_StatusTextBox.TabIndex = 14;
            this.payment_StatusTextBox.TextChanged += new System.EventHandler(this.payment_StatusTextBox_TextChanged);
            // 
            // bed_NoTextBox
            // 
            this.bed_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_s_TableBindingSource, "Bed No", true));
            this.bed_NoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bed_NoTextBox.Location = new System.Drawing.Point(723, 136);
            this.bed_NoTextBox.Name = "bed_NoTextBox";
            this.bed_NoTextBox.Size = new System.Drawing.Size(190, 30);
            this.bed_NoTextBox.TabIndex = 16;
            // 
            // dependant_s_PhoneTextBox
            // 
            this.dependant_s_PhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_s_TableBindingSource, "Dependant\'s Phone", true));
            this.dependant_s_PhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dependant_s_PhoneTextBox.Location = new System.Drawing.Point(723, 50);
            this.dependant_s_PhoneTextBox.Name = "dependant_s_PhoneTextBox";
            this.dependant_s_PhoneTextBox.Size = new System.Drawing.Size(190, 30);
            this.dependant_s_PhoneTextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(5, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(86, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 30);
            this.textBox1.TabIndex = 20;
            // 
            // patient_s_TableDataGridView
            // 
            this.patient_s_TableDataGridView.AutoGenerateColumns = false;
            this.patient_s_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patient_s_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.patient_s_TableDataGridView.DataSource = this.patient_s_TableBindingSource;
            this.patient_s_TableDataGridView.Location = new System.Drawing.Point(0, 334);
            this.patient_s_TableDataGridView.MaximumSize = new System.Drawing.Size(1179, 220);
            this.patient_s_TableDataGridView.MinimumSize = new System.Drawing.Size(1179, 220);
            this.patient_s_TableDataGridView.Name = "patient_s_TableDataGridView";
            this.patient_s_TableDataGridView.RowHeadersWidth = 51;
            this.patient_s_TableDataGridView.RowTemplate.Height = 24;
            this.patient_s_TableDataGridView.Size = new System.Drawing.Size(1179, 220);
            this.patient_s_TableDataGridView.TabIndex = 21;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "patient\'s Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "patient\'s Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Diagnosis";
            this.dataGridViewTextBoxColumn3.HeaderText = "Diagnosis";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Doctor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Doctor";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Admission";
            this.dataGridViewTextBoxColumn5.HeaderText = "Admission";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Dependant\'s Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Dependant\'s Name";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Dependant\'s Phone";
            this.dataGridViewTextBoxColumn7.HeaderText = "Dependant\'s Phone";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Payment Status";
            this.dataGridViewTextBoxColumn8.HeaderText = "Payment Status";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Bed No";
            this.dataGridViewTextBoxColumn9.HeaderText = "Bed No";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBack.Location = new System.Drawing.Point(127, 585);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 42);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(458, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 42);
            this.button1.TabIndex = 23;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 631);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.patient_s_TableDataGridView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(dependant_s_PhoneLabel);
            this.Controls.Add(this.dependant_s_PhoneTextBox);
            this.Controls.Add(bed_NoLabel);
            this.Controls.Add(this.bed_NoTextBox);
            this.Controls.Add(payment_StatusLabel);
            this.Controls.Add(this.payment_StatusTextBox);
            this.Controls.Add(dependant_s_NameLabel);
            this.Controls.Add(this.dependant_s_NameTextBox);
            this.Controls.Add(admissionLabel);
            this.Controls.Add(this.admissionTextBox);
            this.Controls.Add(doctorLabel);
            this.Controls.Add(this.doctorTextBox);
            this.Controls.Add(diagnosisLabel);
            this.Controls.Add(this.diagnosisTextBox);
            this.Controls.Add(patient_s_NameLabel);
            this.Controls.Add(this.patient_s_NameTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.patient_s_TableBindingNavigator);
            this.MaximumSize = new System.Drawing.Size(1201, 678);
            this.MinimumSize = new System.Drawing.Size(1201, 678);
            this.Name = "Form6";
            this.Text = "Patients\' Details";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mathari_Level_5_HospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_s_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_s_TableBindingNavigator)).EndInit();
            this.patient_s_TableBindingNavigator.ResumeLayout(false);
            this.patient_s_TableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_s_TableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mathari_Level_5_HospitalDataSet mathari_Level_5_HospitalDataSet;
        private System.Windows.Forms.BindingSource patient_s_TableBindingSource;
        private Mathari_Level_5_HospitalDataSetTableAdapters.Patient_s_TableTableAdapter patient_s_TableTableAdapter;
        private Mathari_Level_5_HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patient_s_TableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton patient_s_TableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox patient_s_NameTextBox;
        private System.Windows.Forms.TextBox diagnosisTextBox;
        private System.Windows.Forms.TextBox doctorTextBox;
        private System.Windows.Forms.TextBox admissionTextBox;
        private System.Windows.Forms.TextBox dependant_s_NameTextBox;
        private System.Windows.Forms.TextBox payment_StatusTextBox;
        private System.Windows.Forms.TextBox bed_NoTextBox;
        private System.Windows.Forms.TextBox dependant_s_PhoneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView patient_s_TableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
    }
}