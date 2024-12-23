using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp4
{
    public partial class ReportIssue : Form
    {
        private string selectedImagePath = "";
        private int receivedData;
        public ReportIssue(int data)
        {
            InitializeComponent();
            receivedData = data;
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {

            // Retrieve input values from form controls
            string issueTitle = issuename_txt.Text;
            string description = desc_txt.Text;
            DateTime date = datepicker.Value;
            string location = location_txt.Text;
            

            // Validate inputs
            if (string.IsNullOrWhiteSpace(issueTitle))
            {
                MessageBox.Show("Issue title is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(location))
            {
                MessageBox.Show("Location is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Description is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(selectedImagePath))
            {
                MessageBox.Show("No image selected. Please select an image before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Connection string
            string connectionString = "Data Source=HADEEBA\\SQLEXPRESS01;Initial Catalog=SeProject;Integrated Security=True;Trust Server Certificate=True";

            // Insert data into the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Issue (Title, Description, Date, Location, Image,GuardID) VALUES (@Title, @Description, @Date, @Location, @Image,@Id)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@Title", issueTitle);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@Date", date);
                        command.Parameters.AddWithValue("@Location", location);
                        command.Parameters.AddWithValue("@Image", selectedImagePath);
                        command.Parameters.AddWithValue("@Id",receivedData);
                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Issue reported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Optionally clear the fields after submission
                            issuename_txt.Clear();
                            desc_txt.Clear();
                            location_txt.Clear();
                            selectedImagePath = ""; // Reset the image path
                        }
                        else
                        {
                            MessageBox.Show("Failed to report the issue. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void image_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // Start at Desktop
                openFileDialog.Filter = "Image Files|.jpg;.jpeg;.png;.bmp";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    MessageBox.Show($"Image selected: {selectedImagePath}", "Image Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No image selected. Please select an image to continue.", "Image Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
