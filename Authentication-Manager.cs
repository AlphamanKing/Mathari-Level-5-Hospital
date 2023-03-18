using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathari_Level_5_Hospital
{
    public static class AuthenticationManager
    {
        public static bool AuthenticateUser(string username, string password)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Mathari Level 5 Hospital.accdb";

            string query = "SELECT * FROM [Login Table Details] WHERE [username] = ? AND [password] = ?";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("?", username);
                    command.Parameters.AddWithValue("?", password);

                    DataTable dt = new DataTable();
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }

                    if (dt.Rows.Count > 0 && dt.Rows[0]["isAdmin"].ToString().Equals("True", StringComparison.OrdinalIgnoreCase))
                    {
                        CurrentUser.IsAdmin = true;
                    }
                    else
                    {
                        CurrentUser.IsAdmin = false;
                    }

                    return dt.Rows.Count > 0;
                }
            }
        }
    }

}
