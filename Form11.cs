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
    public partial class MainForm : Form
    {
        internal static bool IsAdmin;
        private bool isAdmin;

        public MainForm()
        {
        }

        public MainForm(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void btnBilling_and_accounting_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); //create a new instance of Form3
            form3.Show(); //show Form3
            this.Hide(); //hide the current form
        }

        private void btnOur_Departments_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(); //create a new instance of Form3
            form4.Show(); //show Form3
            this.Hide(); //hide the current form
        }

        private void btnEmployeeDetails_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(); //create a new instance of Form3
            form5.Show(); //show Form3
            this.Hide(); //hide the current form
        }

        private void btnPatient_Details_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(); //create a new instance of Form3
            form6.Show(); //show Form3
            this.Hide(); //hide the current form
        }

        private void btnPharmacy_management_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(); //create a new instance of Form3
            form7.Show(); //show Form3
            this.Hide(); //hide the current form
        }

        private void btnOur_rooms_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(); //create a new instance of Form3
            form8.Show(); //show Form3
            this.Hide(); //hide the current form
        }

        private void btnSupply_chain_management_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9(); //create a new instance of Form3
            form9.Show(); //show Form3
            this.Hide(); //hide the current form
        }

        private void btnOur_wards_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10(); //create a new instance of Form3
            form10.Show(); //show Form3
            this.Hide(); //hide the current form
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Log_out_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); //create a new instance of Form3
            form2.Show(); //show Form3
            this.Hide(); //hide the current form
        }
    }
}
