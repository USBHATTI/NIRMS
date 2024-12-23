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
    public partial class Login : Form
    {
        //  string connectionString = "Data Source=HADEEBA\\SQLEXPRESS01;Initial Catalog = SeProject; Integrated Security = True; Trust Server Certificate=True";
        public static int guardId;
        public Login()
        {
            InitializeComponent();
        }

        private void log_btn_Click(object sender, EventArgs e)
        {

            if (!log_chk.Checked)
            {
                MessageBox.Show("Please check the checkbox before logging in.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Get the username and password from the textboxes
            string username = lname_txt.Text;
            string password = lpass_txt.Text;

            // Define the connection string
            string connectionString = "Data Source=HADEEBA\\SQLEXPRESS01;Initial Catalog=SeProject;Integrated Security=True;Trust Server Certificate=True";

            // Check for admin credentials
            if ((username == "Hadeeba" && password == "Admin1") || (username == "Umair" && password == "Admin2"))
            {
                // Open the admin interface
                Admin adminForm = new Admin();
                adminForm.Show();

                return;
            }

            // Initialize connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to check for user credentials and retrieve ID
                    string query = "SELECT ID FROM signUp WHERE Name = @username AND Password = @password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Check if a result is returned
                            {
                                // Save the ID into the global variable
                                guardId = Convert.ToInt32(reader["ID"]);

                                // Check for operation team roles
                                if (username == "Installation" && password == "IT1" ||
                                    username == "Operational" && password == "OT1" ||
                                    username == "Hanging" && password == "HT1" ||
                                    username == "Pulling" && password == "PT1")
                                {
                                    OperationTeam operationForm = new OperationTeam();
                                    operationForm.Show();
                                }
                                else
                                {
                                    Guard guardForm = new Guard(guardId);
                                    guardForm.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            Signup signUpForm = new Signup();
            signUpForm.Show();



        }

        private void lname_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
