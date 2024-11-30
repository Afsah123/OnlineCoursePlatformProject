using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_project
{
    public partial class PR_form : Form
    {
        public PR_form()
        {
            InitializeComponent();
        }

        private void PR_form_Load(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog
            DialogResult result = MessageBox.Show(
                "Are you sure you want to proceed?", // Message
                "Confirmation", // Title
                MessageBoxButtons.YesNo, // Buttons
                MessageBoxIcon.Question); // Icon

            // Handle the result of the dialog
            if (result == DialogResult.Yes)
            {
                // If Yes is clicked, proceed with the action
                // Example: Open a new form, etc.

                this.Close();
            }
            else
            {
                // If Cancel is clicked, just return or do nothing
                // You can also log or display some message if needed
            }
        }

        // Submit button click event
        private void button3_Click(object sender, EventArgs e)
        {
            // Get values from the form
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string contactNo = textBox3.Text;
            string studentName = textBox4.Text;
            string studentId = textBox5.Text;
            string relationship = textBox6.Text;
            string occupation = textBox7.Text;
            string address = textBox8.Text;
            string username = textBox10.Text;
            string password = textBox9.Text;
            DateTime dob = dateTimePicker1.Value;
            //string dob = dateTimePicker1.Value.ToString("yyyy-MM-dd");


            // SQL Insert query
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["myconstr"].ConnectionString;
            string query = "INSERT INTO Parents (First_name, Last_name, Student_name, Student_ID, Relationship, Occupation,Contact_no,Address,Date_of_birth,username,passwordHash) " +
                           "VALUES (@First_name, @Last_name, @Student_name, @Student_ID, @Relationship, @Occupation,@Contact_no, @Address, @Date_of_birth, @username, @passwordHash)";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@First_name", firstName);
                        cmd.Parameters.AddWithValue("@Last_name", lastName);
                        cmd.Parameters.AddWithValue("@Contact_no", contactNo);
                        cmd.Parameters.AddWithValue("@Student_name", studentName);
                        cmd.Parameters.AddWithValue("@Student_ID", studentId);
                        cmd.Parameters.AddWithValue("@Relationship", relationship);
                        cmd.Parameters.AddWithValue("@Occupation", occupation);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@passwordHash", password);
                        cmd.Parameters.AddWithValue("@Date_of_birth", dob);

                        // Open the connection and execute the query
                        con.Open();
                        int result = cmd.ExecuteNonQuery();

                        // Check if the insertion was successful
                        if (result > 0)
                        {
                            // Registration was successful
                            MessageBox.Show("Registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Registration failed
                            MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
