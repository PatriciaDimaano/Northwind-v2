using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Unit_3
{
    public partial class Form1 : Form
    {
        private string srvr;
        private string db;
        private string uname;
        private string pword;
        public Form1(string server, string database, string user, string pass)
        {
            InitializeComponent();

            srvr = server;
            db = database;
            uname = user;
            pword = pass;

            SetUserRecordPermissions();
            Greeting.Text = "Hello, " + user + "!";
            Greeting.Visible = true;
        }
        //method is updated to have a more centralized access control
        //sets record access permissions based on the user's role
        private void SetUserRecordPermissions()
        {
            Data data = new Data(srvr, db, uname, pword);
            List<string> AccessibleRecords = new List<string>();

            try
            {
                if (data.GetRoleMembership("CEORole") == 1)
                {
                    AccessibleRecords.Add("Employees");
                    AccessibleRecords.Add("Orders");
                    AccessibleRecords.Add("Customers");
                }

                if (data.GetRoleMembership("SalesRole") == 1)
                {
                    // Add permitted records only if they're not already present to avoid duplicates
                    if (!AccessibleRecords.Contains("Orders")) AccessibleRecords.Add("Orders");
                    if (!AccessibleRecords.Contains("Customers")) AccessibleRecords.Add("Customers");
                }

                if (data.GetRoleMembership("HRRole") == 1)
                {
                    if (!AccessibleRecords.Contains("Employees")) AccessibleRecords.Add("Employees");
                }
            }
            catch (SqlException ex)
            {
                // Log exception info in the console but provide end-users generic error messages
                Console.WriteLine($"Database access error during role check: {ex.Message}");
                MessageBox.Show("A database error occurred while setting user permissions. Please contact support.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoginForm login = new LoginForm();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General error during role check: {ex.Message}");
                MessageBox.Show("An unexpected error occurred while setting user permissions. Please contact support.", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoginForm login = new LoginForm();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }

            foreach (string table in AccessibleRecords)
            {
                Selection.Items.Add(table);
            }

            if (Selection.Items.Count > 0)
            {
                Selection.SelectedIndex = 0;
            }
            else
            {
                //inform the end-user if they don't have any record permissions and disable the load button
                //end-user can only logout to prevent unauthorized data access attempts
                MessageBox.Show("You do not have access to any records. Please contact the administrator.", "Record Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadBtn.Enabled = false;
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            Data data = new Data(srvr, db, uname, pword);
            DataSet dataset = new DataSet();
            //added a null-conditional operator for safer access to selected records
            string selectedTable = Selection.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedTable))
            {
                MessageBox.Show("Please select a record to load.", "Record Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string queryList = "";
                string queryCount = "";

                switch (selectedTable)
                {
                    case "Employees":
                        queryList = data.EmployeeList;
                        queryCount = data.EmployeeCount;
                        break;
                    case "Orders":
                        queryList = data.OrderList;
                        queryCount = data.OrderCount;
                        break;
                    case "Customers":
                        queryList = data.CustomerList;
                        queryCount = data.CustomerCount;
                        break;
                    default:
                        MessageBox.Show("Invalid selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                //Retrieve count and data using the GetScalarData from the Data class
                object number = data.GetScalarData(queryCount);
                DataNumber.Text = "Number of Data: " + number.ToString();
                DataNumber.Visible = true;

                dataset = data.GetDataSet(queryList);
                DataView.DataSource = dataset.Tables[0];
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database data loading error: {ex.Message}");
                MessageBox.Show("A database error occurred while loading data. Please contact support.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General data loading error: {ex.Message}");
                MessageBox.Show("An unexpected error occurred while loading data. Please contact support.", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
