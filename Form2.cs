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

            if (AuthenticationManager.AuthenticateUser(username, password))
            {
                MessageBox.Show("Login successful!");

                // Open main form and close login form
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
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

        private void btnCreateNewAccount_Click(object sender, EventArgs e)
        {
            //Create a connection object
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Mathari Level 5 Hospital.accdb");

            //Create a command object
            OleDbCommand cmd = new OleDbCommand();

            //Set the command text to an SQL statement that counts the number of records with the given username
            cmd.CommandText = "SELECT COUNT(*) FROM [Login Table Details] WHERE [username] = ?";

            //Set the command type to text
            cmd.CommandType = CommandType.Text;

            //Set the connection property of the command object to the connection object
            cmd.Connection = conn;

            //Add a parameter to the command object with the value from the textbox
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);

            //Open the connection
            conn.Open();

            //Execute the command and get the result as an integer
            int count = (int)cmd.ExecuteScalar();

            //Close the connection
            conn.Close();

            //Check if the count is zero
            if (count == 0)
            {
                //The username is unique, proceed with insertion

                //Create a new command object
                cmd = new OleDbCommand();

                //Set the command text to an SQL statement that inserts a new record into the Login Table Details
                cmd.CommandText = "INSERT INTO [Login Table Details] ([username], [password], [isAdmin]) VALUES (?, ?, ?)";

                //Set the command type to text
                cmd.CommandType = CommandType.Text;

                //Set the connection property of the command object to the connection object
                cmd.Connection = conn;

                //Add parameters to the command object with the values from the textboxes
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                //Set the isAdmin parameter to false by default
                cmd.Parameters.AddWithValue("@isAdmin", false);

                //Open the connection
                conn.Open();

                //Execute the command
                cmd.ExecuteNonQuery();

                //Close the connection
                conn.Close();

                //Display a message that the account was created successfully
                MessageBox.Show("Account created successfully!");
            }
            else
            {
                //The username is taken, display a message
                MessageBox.Show("The username is already taken. Please choose a different one.");
            }
        }
    }
}
