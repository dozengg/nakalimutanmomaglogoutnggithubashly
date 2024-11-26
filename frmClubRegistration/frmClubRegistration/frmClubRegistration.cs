using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace frmClubRegistration
{
    public partial class frmClubRegistration : Form
    {

        private ClubRegistrationQuery clubRegistrationQuery;
        private int  age;
        private string firstName, middleName, lastName, gender, program;
        private long studentID;


        public frmClubRegistration()
        {
            InitializeComponent();
            clubRegistrationQuery = new ClubRegistrationQuery();
            RefreshListOfClubMembers();
        }
        private void RefreshListOfClubMembers()
        {
            if (clubRegistrationQuery.DisplayList())
            {
                dataGridView.DataSource = clubRegistrationQuery.bindingSource;
            }
        }
        private void frmClubRegistration_Load(object sender, EventArgs e)
        {
            comboGender.Items.Add("Male");
            comboGender.Items.Add("Female");

            comboProgram.Items.Add("BSIT");
            comboProgram.Items.Add("BSCS");
            comboProgram.Items.Add("BSCPE");
            comboProgram.Items.Add("BSIS");
        }
        private void Register_Click(object sender, EventArgs e)
        {

            try
            {

                studentID = Convert.ToInt64(txtStudentID.Text);
                firstName = txtFirstName.Text;
                middleName = txtMiddleName.Text;
                lastName = txtLastName.Text;
                age = Convert.ToInt32(txtAge.Text);
                gender = comboGender.Text.ToString();
                program = comboProgram.Text.ToString();


                if (clubRegistrationQuery.RegisterStudent(studentID, firstName, middleName, lastName, age, gender, program))
                {
                    MessageBox.Show("Registration successful!");
                    RefreshListOfClubMembers();
                }
                else
                {
                    MessageBox.Show("Error in registration!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

       
    }
}
