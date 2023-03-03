using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathari_Level_5_Hospital
{
    public partial class Form2 : Form
    {
        private bool isAdmin = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            bool isAdmin;
            if (IsValidUser(username, password, out isAdmin))
            {
                MainForm mainForm = new MainForm(isAdmin);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidUser(string username, string password, out bool isAdmin)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Mathari Level 5 Hospital.accdb";

            string query = "SELECT * FROM [Login Table Details] WHERE [username] = @username AND [password] = @password";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))

                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    DataTable dt = new DataTable();
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))

                    {
                        adapter.Fill(dt);
                    }

                    if (dt.Rows.Count > 0 && dt.Rows[0]["isAdmin"].ToString().Equals("True", StringComparison.OrdinalIgnoreCase))
                    {
                        isAdmin = true;
                    }
                    else
                    {
                        isAdmin = false;
                    }


                    return dt.Rows.Count > 0;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void ClearTextboxes()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

    }
}
