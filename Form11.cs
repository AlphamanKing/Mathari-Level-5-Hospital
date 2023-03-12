using System.Windows.Forms;
using System;

namespace Mathari_Level_5_Hospital
{
    public partial class MainForm : Form
    {
        public bool CurrentUserIsAdmin { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(bool isAdmin) : this()
        {
            CurrentUserIsAdmin = isAdmin;
        }

        private void btnBilling_and_accounting_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(CurrentUserIsAdmin);
            form3.Show();
            this.Hide();
        }

        private void btnOur_Departments_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(CurrentUserIsAdmin);
            form4.Show();
            this.Hide();
        }

        private void btnEmployeeDetails_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(CurrentUserIsAdmin);
            form5.Show();
            this.Hide();
        }

        private void btnPatient_Details_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(CurrentUserIsAdmin);
            form6.Show();
            this.Hide();
        }

        private void btnPharmacy_management_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(CurrentUserIsAdmin);
            form7.Show();
            this.Hide();
        }

        private void btnOur_rooms_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(CurrentUserIsAdmin);
            form8.Show();
            this.Hide();
        }

        private void btnSupply_chain_management_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9(CurrentUserIsAdmin);
            form9.Show();
            this.Hide();
        }

        private void btnOur_wards_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10(CurrentUserIsAdmin);
            form10.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Log_out_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Logout()
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}

