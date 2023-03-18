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
    public partial class Form3 : Form
    {
        private bool isAdmin = false;
        public static bool IsAdmin { get; set; }

        public Form3(bool isAdmin)
        {
            InitializeComponent();
            // set the value of the property using the parameter value
            this.isAdmin = isAdmin;
            btnAdd.Enabled = isAdmin;
            btnDelete.Enabled = isAdmin;
            btnSave.Enabled = isAdmin;
            btnToolStrip.Enabled = isAdmin;
        }
        public Form3()
        {
            InitializeComponent();
            btnAdd.Enabled = isAdmin || CurrentUser.IsAdmin;
            btnDelete.Enabled = isAdmin || CurrentUser.IsAdmin;
            btnSave.Enabled = isAdmin || CurrentUser.IsAdmin;
            btnToolStrip.Enabled = isAdmin || CurrentUser.IsAdmin;
        }

        private void billing_and_Accounting_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.billing_and_Accounting_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathari_Level_5_HospitalDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathari_Level_5_HospitalDataSet.Billing_and_Accounting_Table' table. You can move, or remove it, as needed.
            this.billing_and_Accounting_TableTableAdapter.Fill(this.mathari_Level_5_HospitalDataSet.Billing_and_Accounting_Table);
            btnAdd.Enabled = CurrentUser.IsAdmin;
            btnDelete.Enabled = CurrentUser.IsAdmin;
            btnSave.Enabled = CurrentUser.IsAdmin;
            btnToolStrip.Enabled = CurrentUser.IsAdmin;
        }

        private void iDLabel_Click(object sender, EventArgs e)
        {

        }

        private void amountLabel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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

            foreach (DataGridViewRow row in billing_and_Accounting_TableDataGridView.Rows)
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
