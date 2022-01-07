namespace EmployeeManagement
{
    partial class EmpMgmt
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.designation = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtdesignation = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name :";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(155, 115);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(89, 15);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Employee Age :";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(155, 151);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(92, 15);
            this.lblDOB.TabIndex = 3;
            this.lblDOB.Text = "Employee DOB :";
            // 
            // designation
            // 
            this.designation.AutoSize = true;
            this.designation.Location = new System.Drawing.Point(168, 192);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(76, 15);
            this.designation.TabIndex = 4;
            this.designation.Text = "Designation :";
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(265, 145);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(247, 23);
            this.dob.TabIndex = 5;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(265, 71);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.PlaceholderText = "Enter Employee Name";
            this.txtEmpName.Size = new System.Drawing.Size(247, 23);
            this.txtEmpName.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(265, 107);
            this.txtAge.Name = "txtAge";
            this.txtAge.PlaceholderText = "Enter Employee Age";
            this.txtAge.Size = new System.Drawing.Size(247, 23);
            this.txtAge.TabIndex = 7;
            // 
            // txtdesignation
            // 
            this.txtdesignation.Location = new System.Drawing.Point(265, 189);
            this.txtdesignation.Name = "txtdesignation";
            this.txtdesignation.PlaceholderText = "Enter Employee Designation";
            this.txtdesignation.Size = new System.Drawing.Size(247, 23);
            this.txtdesignation.TabIndex = 8;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(265, 245);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(247, 23);
            this.Save.TabIndex = 9;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // EmpMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.txtdesignation);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.designation);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmpMgmt";
            this.Text = "Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblAge;
        private Label lblDOB;
        private Label designation;
        private DateTimePicker dob;
        private TextBox txtEmpName;
        private TextBox txtAge;
        private TextBox txtdesignation;
        private Button Save;
    }
}