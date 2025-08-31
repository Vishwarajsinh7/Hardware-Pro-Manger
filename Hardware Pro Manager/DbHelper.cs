using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hardware_Pro_Manager
{
    public static class DbHelper
    {
        // Method to get the connection string from App.config
        private static string GetConnectionString()
        {
            // IMPORTANT: You might need to add a reference to System.Configuration
            // Right-click "References" in Solution Explorer, click "Add Reference...",
            // and check "System.Configuration" from the Assemblies list.
            return ConfigurationManager.ConnectionStrings["HardwareDb"].ConnectionString;
        }

        // Method to execute queries that don't return data (e.g., INSERT, UPDATE, DELETE)
        public static void ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to get data and return it as a DataTable (for displaying in grids)
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        if (parameters != null)
                        {
                            da.SelectCommand.Parameters.AddRange(parameters);
                        }
                        da.Fill(dt);
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
    }
}