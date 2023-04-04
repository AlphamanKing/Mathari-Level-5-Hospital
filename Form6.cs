using FastReport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathari_Level_5_Hospital
{
    public partial class Form6 : Form
    {
        private bool isAdmin; public bool IsAdmin { get; set; }
 
        public Form6(bool isAdmin)
        {
            InitializeComponent();
            this.IsAdmin = isAdmin; 
            btnAdd.Enabled = IsAdmin;
            btnDelete.Enabled = IsAdmin;
            btnSave.Enabled = IsAdmin;
        }
        public Form6()
        {
            InitializeComponent();
            btnAdd.Enabled = CurrentUser.IsAdmin;
            btnDelete.Enabled = CurrentUser.IsAdmin;
            btnSave.Enabled = CurrentUser.IsAdmin;
        }

        private void patient_s_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patient_s_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathari_Level_5_HospitalDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathari_Level_5_HospitalDataSet._Patient_s_Table' table. You can move, or remove it, as needed.
            this.patient_s_TableTableAdapter.Fill(this.mathari_Level_5_HospitalDataSet._Patient_s_Table);
            btnAdd.Enabled = CurrentUser.IsAdmin;
            btnDelete.Enabled = CurrentUser.IsAdmin;
            btnSave.Enabled = CurrentUser.IsAdmin;

        }

        private void iDLabel_Click(object sender, EventArgs e)
        {

        }

        private void iDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void payment_StatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void payment_StatusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void admissionLabel_Click(object sender, EventArgs e)
        {

        }

        private void admissionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dependant_s_NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void dependant_s_PhoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm form11 = (MainForm)Application.OpenForms["MainForm"]; //Get the instance of MainForm
            form11.Show();
            this.Close(); //Close the current form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim().ToLower();
            bool found = false;

            foreach (DataGridViewRow row in patient_s_TableDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchValue))
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        found = true;
                        break;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show("No matching record found!");
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // create a report object
            Report report = new Report();

            // load the report template from file
            report.Load("Reports\\Patients Report.frx");

            // show the report preview
            report.Show();
        }
    }
}
