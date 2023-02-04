using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookLibrary
{
    public class ADO
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=bookstore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void SelectAllBooks()
        {
            var queryString = "select * from books";

            using (SqlConnection connection = new SqlConnection(connectionString))
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
                catch (Exception ex)
                {
                    //searchTextBox.Text(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

    }
}
