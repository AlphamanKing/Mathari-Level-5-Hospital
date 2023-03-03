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
        private bool isAdmin;

        public Form3(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            btnAdd.Enabled = isAdmin;
            btnDelete.Enabled = isAdmin;
            btnSave.Enabled = isAdmin;
            btnToolStrip.Enabled = isAdmin;
        }
        public Form3()
        {
            InitializeComponent();
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
            MainForm form11 = new MainForm(); 
            form11.Show(); 
            this.Close(); //hide the current form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
