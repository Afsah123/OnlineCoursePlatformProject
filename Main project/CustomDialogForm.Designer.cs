namespace Main_project
{
    partial class CustomDialogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnParent = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStudent.Location = new System.Drawing.Point(50, 50);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(100, 30);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnParent
            // 
            this.btnParent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnParent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnParent.Location = new System.Drawing.Point(50, 100);
            this.btnParent.Name = "btnParent";
            this.btnParent.Size = new System.Drawing.Size(100, 30);
            this.btnParent.TabIndex = 1;
            this.btnParent.Text = "Parent";
            this.btnParent.UseVisualStyleBackColor = false;
            this.btnParent.Click += new System.EventHandler(this.btnParent_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTeacher.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTeacher.Location = new System.Drawing.Point(50, 150);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(100, 30);
            this.btnTeacher.TabIndex = 2;
            this.btnTeacher.Text = "Teacher";
            this.btnTeacher.UseVisualStyleBackColor = false;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // CustomDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(250, 250);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnParent);
            this.Controls.Add(this.btnTeacher);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "CustomDialogForm";
            this.Text = "Select an Option";
            this.ResumeLayout(false);

        }

        // Declare the buttons
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnParent;
        private System.Windows.Forms.Button btnTeacher;


        #endregion
    }
}