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
    public partial class Form5 : Form
    {
        private bool isAdmin; public bool IsAdmin { get; set; }
        

        public Form5(bool isAdmin)
        {
            InitializeComponent();
            this.IsAdmin = isAdmin; // use the property instead of the field
            btnAdd.Enabled = IsAdmin;
            btnDelete.Enabled = IsAdmin;
            btnSave.Enabled = IsAdmin;
        }
        public Form5()
        {
            InitializeComponent();
            btnAdd.Enabled = CurrentUser.IsAdmin;
            btnDelete.Enabled = CurrentUser.IsAdmin;
            btnSave.Enabled = CurrentUser.IsAdmin;
        }

        private void employees__TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employees__TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathari_Level_5_HospitalDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathari_Level_5_HospitalDataSet._Employees__Table' table. You can move, or remove it, as needed.
            this.employees__TableTableAdapter.Fill(this.mathari_Level_5_HospitalDataSet._Employees__Table);
            btnAdd.Enabled = CurrentUser.IsAdmin;
            btnDelete.Enabled = CurrentUser.IsAdmin;
            btnSave.Enabled = CurrentUser.IsAdmin;

        }

        private void employee_NameTextBox_TextChanged(object sender, EventArgs e)
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

            foreach (DataGridViewRow row in employees__TableDataGridView.Rows)
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
    }
}
