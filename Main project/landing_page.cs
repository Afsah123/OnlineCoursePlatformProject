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
    public partial class landing_page : Form
    {
        public landing_page()
        {
            InitializeComponent();
        }

        //private void sqlConnection
        //{
            
        //}
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(getConnectionstring)
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            DisableLandingPageControls();

            // Show the custom dialog form
            using (CustomDialogForm dialog = new CustomDialogForm())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {   
                    // Handle the selected option
                    if (dialog.SelectedOption == "Student")
                    {
                        OpenRegisterForm("Student"); // Handle Student
                    }
                    else if (dialog.SelectedOption == "Parent")
                    {
                        OpenRegisterForm("Parent"); // Handle Parent
                    }
                    else if (dialog.SelectedOption == "Teacher")
                    {
                        OpenRegisterForm("Teacher"); // Handle Teacher
                    }
                }
            }
        }

        private void OpenRegisterForm(string ourUserAgent)
        {
            // Disable all controls to make the landing page non-interactive
            DisableLandingPageControls();

            // Open the new form based on the user selection
            Form newForm = null;

            switch (ourUserAgent)
            {
                case "Student":
                    newForm = new SR_form();
                    break;
                case "Teacher":
                    newForm = new TR_form();
                    break;
                case "Parent":
                    newForm = new PR_form();
                    break;
            }

            // Show the new form
            if (newForm != null)
            {
                newForm.Show();
            }

            // Hide the landing page form (don't close it)
            this.Hide();
        }

        private void DisableLandingPageControls()
        {
            // Disable all controls on the landing page to make it non-editable
            foreach (Control control in this.Controls)
            {
                control.Enabled = false;
            }
        }
    }
}
