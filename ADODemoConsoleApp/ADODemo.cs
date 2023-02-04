using ADODemoConsoleApp.Models;
using ADODemoConsoleApp.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemoConsoleApp
{
    public class ADODemo
    {
        private string _connectionString;
        private EmployeeRepos _companyDbRepos;

        public ADODemo(string connectionString)
        {
            _connectionString = connectionString;
            _companyDbRepos = new EmployeeRepos(connectionString);
        }

        public void RunSelectAllFromEmployees()
        {
            var queryString = "select * from employees";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var sqlCommand = new SqlCommand(queryString, connection);

                try 
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        Console.WriteLine($"{sqlDataReader[0]}, {sqlDataReader[1]}, {sqlDataReader[2]}, {sqlDataReader[3]}, {sqlDataReader[4]}");
                    }
                }
                catch(Exception ex) 
                { 
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        public void RunSelectDefinedColumnSet(string column1, string column2)
        {
            var queryString = $"select {column1}, {column2} email from employees";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    var sqlDataReader = command.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        Console.WriteLine($"{sqlDataReader[0]}, {sqlDataReader[1]}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }
        public void InsertEmployee()
        {
            var employee = new Employee
            {
                Id = Guid.NewGuid(),
                FirstName = "Andrzej",
                LastName = "Pandrzej",
                Email = "apapa@asd.com",
                DepartmentId = Guid.Parse("3C915F4A-6BA6-49B6-877F-877340F63192"),
            };

            _companyDbRepos.InsertEmployeeToDB(employee);
            RunSelectAllFromEmployees();
        }
        public void InsertManyEmployeesDemo()
        {
            var employeeList = new List<Employee>();
            var random = new Random();

            string[] names = { "Michał", "Andrzej", "Marcin", "Monika" };
            string[] lastNames = { "Kowalski", "Nowak", "Miau", "Hau" };


            for (int i = 0; i < 100; i++)
            {
                employeeList.Add(new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = names[random.NextInt64(0, 4)],
                    LastName = lastNames[random.NextInt64(0, 4)],
                    Email = names[random.NextInt64(0, 3)] + names[random.NextInt64(0, 3)] + names[random.NextInt64(0, 3)] + random.NextInt64().ToString() + "@gmail.com",
                    DepartmentId = Guid.Parse("3C915F4A-6BA6-49B6-877F-877340F63192")
                });
                Console.WriteLine("Employee created...");
            }

            foreach (var employee in employeeList)
            {
                _companyDbRepos.InsertEmployeeToDB(employee);
                Console.WriteLine("Employee inserted...");
            }
        }
    }
}
