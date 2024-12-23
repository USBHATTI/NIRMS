using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class AssignTask : Form
    {
        // Connection string
        string connectionString = "Data Source=HADEEBA\\SQLEXPRESS01;Initial Catalog=SeProject;Integrated Security=True;Trust Server Certificate=True";

        public AssignTask()
        {
            InitializeComponent();
        }

        // This event is triggered when the form loads


        // Method to load all data from the Issue table and display Title in ComboBox
        private void LoadIssueData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT IssueID, Title FROM Issue";  // Fetch both ID and Title from the Issue table

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        // Clear any existing items in the ComboBox
                        tasks_combo.Items.Clear();

                        // Loop through the results and add each ID and Title to the ComboBox
                        while (reader.Read())
                        {
                            // Get IssueID and Title from the database
                            int issueID = Convert.ToInt32(reader["IssueID"]);
                            string title = reader["Title"].ToString();

                            // Format the display string as "ID - Title"
                            string displayText = $"{issueID} - {title}";

                            // Add the formatted string to the ComboBox
                            tasks_combo.Items.Add(displayText);

                            // Print Title and ID for verification
                            MessageBox.Show("ID: " + issueID + " Title: " + title);  // For verification
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler for when the selected index of the ComboBox changes
        private void tasks_combo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Get the selected item's text (e.g., "ID - Title")
            string selectedItem = tasks_combo.SelectedItem.ToString();

            // Extract the IssueID from the selected string
            string[] parts = selectedItem.Split('-');
            int selectedIssueID = Convert.ToInt32(parts[0].Trim()); // Get the IssueID part from the string

            // Now retrieve all columns from the Issue table for the selected IssueID
            RetrieveIssueDetailsAndInsertHistory(selectedIssueID);
        }

        private void AssignTask_Load_1(object sender, EventArgs e)
        {
            LoadIssueData();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {

        }

        // Method to retrieve issue details by IssueID and insert them into the History table
        private void RetrieveIssueDetailsAndInsertHistory(int issueID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Query to get all the details from the Issue table for the selected IssueID
                    string issueQuery = "SELECT Title, Description, Image, Date, Location, GuardID FROM Issue WHERE IssueID = @IssueID";
                    using (SqlCommand command = new SqlCommand(issueQuery, connection))
                    {
                        command.Parameters.AddWithValue("@IssueID", issueID);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            // Safely retrieve values from the Issue table, checking for DBNull
                            string title = reader["Title"] != DBNull.Value ? reader["Title"].ToString() : string.Empty;
                            string description = reader["Description"] != DBNull.Value ? reader["Description"].ToString() : string.Empty;
                            string image = reader["Image"] != DBNull.Value ? reader["Image"].ToString() : string.Empty;
                            DateTime date = reader["Date"] != DBNull.Value ? Convert.ToDateTime(reader["Date"]) : DateTime.MinValue;
                            string location = reader["Location"] != DBNull.Value ? reader["Location"].ToString() : string.Empty;
                            int guardID = reader["GuardID"] != DBNull.Value ? Convert.ToInt32(reader["GuardID"]) : 0;

                            // Now insert the retrieved data into the History table
                            InsertIntoHistory(guardID, title, date, "In Processing", location, issueID);
                        }
                        else
                        {
                            MessageBox.Show("No issue found with the selected ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving issue details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to insert data into the History table
        private void InsertIntoHistory(int guardID, string issueTitle, DateTime date, string status, string location, int issueID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Query to insert data into the History table
                    string insertQuery = "INSERT INTO History (GuardID, IssueTitle, Date, Status, Location, IssueID) " +
                                         "VALUES (@GuardID, @IssueTitle, @Date, @Status, @Location, @IssueID)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters to the query
                        command.Parameters.AddWithValue("@GuardID", guardID);
                        command.Parameters.AddWithValue("@IssueTitle", issueTitle);
                        command.Parameters.AddWithValue("@Date", date);
                        command.Parameters.AddWithValue("@Status", status);
                        command.Parameters.AddWithValue("@Location", location);
                        command.Parameters.AddWithValue("@IssueID", issueID);

                        // Execute the insert command
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data inserted successfully into the History table.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while inserting data into the History table: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}