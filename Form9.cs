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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void supply_Chain_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supply_Chain_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathari_Level_5_HospitalDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathari_Level_5_HospitalDataSet.Supply_Chain_Table' table. You can move, or remove it, as needed.
            this.supply_Chain_TableTableAdapter.Fill(this.mathari_Level_5_HospitalDataSet.Supply_Chain_Table);

        }

        private void supplier_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
