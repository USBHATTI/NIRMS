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

namespace WinFormsApp4.User_Control
{
    public partial class SignupControl : UserControl
    {
        public SignupControl()
        {
            InitializeComponent();
        }

       

       
        private void sign_btn_Click(object sender, EventArgs e)
        {

            if (!signchk.Checked)
            {
                MessageBox.Show("Please check the checkbox before logging in.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get inputs from text boxes
            string username = sname_txt.Text;
            string password = spass_txt.Text;
            string email = semail_txt.Text;

            if (!email.EndsWith("@gmail.com") && password.Length != 8)
            {
                MessageBox.Show("Please Fill all Credentions", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Name cannot be empty. Please enter your name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate email
            if (!email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email must end with '@gmail.com'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate password length
            if (password.Length != 8)
            {
                MessageBox.Show("Password must be exactly 8 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Define the connection string
            string connectionString = "Data Source=HADEEBA\\SQLEXPRESS01;Initial Catalog=SeProject;Integrated Security=True;Trust Server Certificate=True";

            // Insert into database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to insert new user
                    string query = "INSERT INTO signUp (Name, Password, Email) VALUES (@username, @password, @semail)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@semail", email);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sign-up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Sign-up failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
