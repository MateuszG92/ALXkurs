using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicePlatform
{
    public class ADO
    {
        private string _connectionString;

        public ADO(string connectionSring)
        {
            _connectionString = connectionSring;
        }
        public void InsertInvoiceToDB(Invoice invoice)
        {
            var queryString = "insert into invoices(id, series_number, client_name,client_nip,user_firstname,user_lastname,amount)" +
                "values(@id, @series_number, @client_name,@client_nip,@user_firstname,@user_lastname,@amount)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@id", invoice.Id.ToString());
                command.Parameters.AddWithValue("@series_number", invoice.SeriesNumber);
                command.Parameters.AddWithValue("@client_name", invoice.CompanyName);
                command.Parameters.AddWithValue("@client_nip", invoice.NIPNumber);
                command.Parameters.AddWithValue("@user_firstname", invoice.UserFirstName);
                command.Parameters.AddWithValue("@user_lastname", invoice.UserLastName);
                command.Parameters.AddWithValue("@amount", invoice.Amount.ToString());


                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }
        public List<Invoice> GetAll()
        {
            var invoices = new List<Invoice>();
            var queryString = "select * from invoices";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var sqlCommand = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        var invoice = new Invoice
                        {
                            Id = Guid.Parse(sqlDataReader[0].ToString()),
                            SeriesNumber = sqlDataReader[1].ToString(),
                            CompanyName = sqlDataReader[2].ToString(),
                            NIPNumber = Int32.Parse(sqlDataReader[3].ToString()),
                            UserFirstName = sqlDataReader[4].ToString(),
                            UserLastName = sqlDataReader[5].ToString(),
                            Amount = Decimal.Parse(sqlDataReader[6].ToString()),

                        };
                        invoices.Add(invoice);
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
            return invoices;
        }
    }
}
