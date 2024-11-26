namespace frmClubRegistration
{
    partial class frmClubRegistration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dataGridView = new DataGridView();
            Register = new Button();
            button2 = new Button();
            button3 = new Button();
            txtStudentID = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            comboProgram = new ComboBox();
            comboGender = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(41, 27);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(41, 91);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(264, 91);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 2;
            label3.Text = "FirstName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(513, 91);
            label4.Name = "label4";
            label4.Size = new Size(109, 21);
            label4.TabIndex = 3;
            label4.Text = "Middle Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(513, 27);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 4;
            label5.Text = "Program";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(41, 158);
            label6.Name = "label6";
            label6.Size = new Size(40, 21);
            label6.TabIndex = 5;
            label6.Text = "Age";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(264, 158);
            label7.Name = "label7";
            label7.Size = new Size(64, 21);
            label7.TabIndex = 6;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(41, 239);
            label8.Name = "label8";
            label8.Size = new Size(168, 21);
            label8.TabIndex = 14;
            label8.Text = "List Of Club Members";
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.AppWorkspace;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(24, 285);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(692, 258);
            dataGridView.TabIndex = 15;
            // 
            // Register
            // 
            Register.Location = new Point(733, 27);
            Register.Name = "Register";
            Register.Size = new Size(106, 52);
            Register.TabIndex = 16;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = true;
            Register.Click += Register_Click;
            // 
            // button2
            // 
            button2.Location = new Point(733, 91);
            button2.Name = "button2";
            button2.Size = new Size(106, 47);
            button2.TabIndex = 17;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(733, 285);
            button3.Name = "button3";
            button3.Size = new Size(106, 47);
            button3.TabIndex = 18;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(41, 56);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(155, 23);
            txtStudentID.TabIndex = 19;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(41, 115);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(155, 23);
            txtLastName.TabIndex = 20;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(41, 182);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(155, 23);
            txtAge.TabIndex = 21;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(264, 115);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(155, 23);
            txtFirstName.TabIndex = 22;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(513, 115);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(155, 23);
            txtMiddleName.TabIndex = 23;
            // 
            // comboProgram
            // 
            comboProgram.FormattingEnabled = true;
            comboProgram.Location = new Point(513, 56);
            comboProgram.Name = "comboProgram";
            comboProgram.Size = new Size(155, 23);
            comboProgram.TabIndex = 24;
            // 
            // comboGender
            // 
            comboGender.FormattingEnabled = true;
            comboGender.Location = new Point(264, 182);
            comboGender.Name = "comboGender";
            comboGender.Size = new Size(155, 23);
            comboGender.TabIndex = 25;
            // 
            // frmClubRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 565);
            Controls.Add(comboGender);
            Controls.Add(comboProgram);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentID);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Register);
            Controls.Add(dataGridView);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmClubRegistration";
            Text = "frmClubRegistration";
            Load += frmClubRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox StudentID;
        private TextBox LastName;
        private TextBox FirstName;
        private TextBox MiddleName;
        private ComboBox Program;
        private TextBox Age;
        private ComboBox Gender;
        private Label label8;
        private DataGridView dataGridView;
        private Button Register;
        private Button button2;
        private Button button3;
        private TextBox txtStudentID;
        private TextBox txtLastName;
        private TextBox txtAge;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private ComboBox comboProgram;
        private ComboBox comboGender;
    }
}
