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
    public partial class Form4 : Form
    {
        private bool isAdmin = false;
        public static bool IsAdmin { get; set; }

        public Form4(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            btnAdd.Enabled = isAdmin;
            btnDelete.Enabled = isAdmin;
            btnSave.Enabled = isAdmin;

        }
        public Form4()
        {
            InitializeComponent();
            btnAdd.Enabled = isAdmin || CurrentUser.IsAdmin;
            btnDelete.Enabled = isAdmin || CurrentUser.IsAdmin;
            btnSave.Enabled = isAdmin || CurrentUser.IsAdmin;
        }

        private void departments_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departments_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathari_Level_5_HospitalDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathari_Level_5_HospitalDataSet.Departments_Table' table. You can move, or remove it, as needed.
            this.departments_TableTableAdapter.Fill(this.mathari_Level_5_HospitalDataSet.Departments_Table);
            btnAdd.Enabled = CurrentUser.IsAdmin;
            btnDelete.Enabled = CurrentUser.IsAdmin;
            btnSave.Enabled = CurrentUser.IsAdmin;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm form11 = (MainForm)Application.OpenForms["MainForm"]; //Get the instance of MainForm
            form11.Show();
            this.Close(); //Close the current form
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim().ToLower();
            bool found = false;

            foreach (DataGridViewRow row in departments_TableDataGridView.Rows)
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // create a report object
            Report report = new Report();

            // load the report template from file
            report.Load("Reports\\Departments Report.frx");

            // show the report preview
            report.Show();
        }
    }
}
