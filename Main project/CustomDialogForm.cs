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
    public partial class CustomDialogForm : Form
    {
        public string SelectedOption { get; private set; }

        public CustomDialogForm()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            SelectedOption = "Student";
            this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void btnParent_Click(object sender, EventArgs e)
        {
            SelectedOption = "Parent";
            this.DialogResult = DialogResult.OK;
            //this.Close();
        }
        
        private void btnTeacher_Click(object sender, EventArgs e)
        {
            SelectedOption = "Teacher";
            this.DialogResult = DialogResult.OK;
            //this.Close();
        }
    }
}
