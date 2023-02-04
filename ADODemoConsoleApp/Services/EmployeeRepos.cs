using ADODemoConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemoConsoleApp.Services
{
    public class EmployeeRepos
    {
        private string _connectionString;

        public EmployeeRepos(string connectionSring)
        {
            _connectionString = connectionSring;
        }

        public void InsertEmployeeToDB (Employee employee)
        {
            var queryString = "insert into employees(id, first_name, last_name, email, department_id)" +
                "values(@id, @first_name, @last_name, @email, @department_id)";

            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@id", employee.Id.ToString());
                command.Parameters.AddWithValue("@first_name", employee.FirstName);
                command.Parameters.AddWithValue("@last_name", employee.LastName);
                command.Parameters.AddWithValue("@email", employee.Email);
                command.Parameters.AddWithValue("@department_id", employee.DepartmentId.ToString());

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }
        public List<Employee> GetAllEmployees()
        {
            var employees = new List<Employee>();
            var queryString = "select * from epmployees";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var sqlCommand = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        var employee = new Employee
                        {
                            Id = Guid.Parse(sqlDataReader[0].ToString()),
                            FirstName = sqlDataReader[1].ToString(),
                            LastName = sqlDataReader[2].ToString(),
                            Email = sqlDataReader[3].ToString(),
                            DepartmentId = Guid.Parse(sqlDataReader[4].ToString()),
                        };
                        employees.Add(employee);
                    }
                    sqlDataReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
                connection.Close();
            }

        return employees;
        }

        public Employee GetById(Guid Id)
        {
            var queryString = "select * from epmployees where employees.id=@id";
            var employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var sqlCommand = new SqlCommand(queryString, connection);

                sqlCommand.Parameters.AddWithValue("@id", Id.ToString());
                try
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        var employee = new Employee
                        {
                            Id = Guid.Parse(sqlDataReader[0].ToString()),
                            FirstName = sqlDataReader[1].ToString(),
                            LastName = sqlDataReader[2].ToString(),
                            Email = sqlDataReader[3].ToString(),
                            DepartmentId = Guid.Parse(sqlDataReader[4].ToString()),
                        };
                        employees.Add(employee);
                    }
                    sqlDataReader.Close();
                    return employees.FirstOrDefault();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
