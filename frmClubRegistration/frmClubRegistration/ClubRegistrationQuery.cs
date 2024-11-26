using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace frmClubRegistration
{
    public class ClubRegistrationQuery
    {
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;

        public DataTable dataTable;
        public BindingSource bindingSource;

        private string connectionString;

        public string _FirstName, _MiddleName, _LastName, _Gender, _Program;
        public int _Age;

        // Constructor
        public ClubRegistrationQuery()
        {
            // Set connection string
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ikawparin\\source\\repos\\frmClubRegistration\\frmClubRegistration\\ClubDB.mdf;Integrated Security=True"; // Replace with actual connection string

            // Initialize SQL components
            sqlConnect = new SqlConnection(connectionString);
            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }

      
        public bool DisplayList()
        {
            try
            {
                sqlAdapter = new SqlDataAdapter("SELECT StudentID, FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers", sqlConnect);
                dataTable.Clear();
                sqlAdapter.Fill(dataTable);
                bindingSource.DataSource = dataTable;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }


        public bool RegisterStudent(long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {
            try
            {
                sqlCommand = new SqlCommand("INSERT INTO ClubMembers VALUES( @StudentID, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)", sqlConnect);

                
                sqlCommand.Parameters.AddWithValue("@StudentID", StudentID);
                sqlCommand.Parameters.AddWithValue("@FirstName", FirstName);
                sqlCommand.Parameters.AddWithValue("@MiddleName", MiddleName);
                sqlCommand.Parameters.AddWithValue("@LastName", LastName);
                sqlCommand.Parameters.AddWithValue("@Age", Age);
                sqlCommand.Parameters.AddWithValue("@Gender", Gender);
                sqlCommand.Parameters.AddWithValue("@Program", Program);

                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                sqlConnect.Close();
                return false;
            }
        }
    }
}
