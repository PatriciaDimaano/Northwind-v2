using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_3
{
    internal class Data
    {
        public String ConnectionString { get; private set; }

        public String EmployeeList = @"Select * from Employees";
        public String EmployeeCount = @"Select Count(EmployeeID) from Employees";
        public String OrderList = @"Select * from Orders";
        public String OrderCount = @"Select Count(OrderID) from Orders";
        public String CustomerList = @"Select * from Customers";
        public String CustomerCount = @"Select Count(CustomerID) from Customers";
        public Data(string server, string database, string user, string pass) {
            this.ConnectionString = $"Data source = {server}; " +
                $"Initial catalog = {database}; " +
                $"User ID = {user}; " +
                $"Password = {pass}";
        }

        public bool TestConnection()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                //Log exception info in the console
                catch (SqlException ex)
                {
                    Console.WriteLine($"Database connection error: {ex.Message}");
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Connection error: {ex.Message}");
                    return false;
                }
            }
        }
        //Method that checks if a user belongs to a specific role
        public int GetRoleMembership(string roleName)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                //parameterized query to prevent SQL injection
                using (SqlCommand command = new SqlCommand("select is_member(@roleName)", connection))
                {
                    command.Parameters.AddWithValue("@roleName", roleName);
                    object result = command.ExecuteScalar();
                    return (result != DBNull.Value) ? (int)result : 0;
                }
            }
        }
        //Method that fetches data from the database and returns it as a dataset
        public DataSet GetDataSet(string query)
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                {
                    dataAdapter.Fill(dataSet);
                }
            }
            return dataSet;
        }
        //Method to get the data count using parameterized query
        public object GetScalarData(string query)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    return command.ExecuteScalar();
                }
            }
        }
    }
}
