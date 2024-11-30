using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_project
{
    public partial class SR_form : Form
    {
        public SR_form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SR_form_Load(object sender, EventArgs e)
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
    }
}
