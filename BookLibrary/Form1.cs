using BookLibrary.Models;
using System.Data.SqlClient;

namespace BookLibrary
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=bookstore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        Book book;
        public Form1()
        {
            InitializeComponent();
            SelectAllBooks();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void addBookButton_Click(object sender, EventArgs e)
        {

        }

        private void borrowButton_Click(object sender, EventArgs e)
        {

        }

        private void returnButton_Click(object sender, EventArgs e)
        {

        }
        public void SelectAllBooks()
        {
            var queryString = "select * from books inner join genres on books.genre_id=genres.id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var sqlCommand = new SqlCommand(queryString, connection);
                string stocktext; 
                try
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        book = new Book
                        {
                            Id = Guid.Parse(sqlDataReader[0].ToString()),
                            Title = sqlDataReader[1].ToString(),
                            Author = sqlDataReader[2].ToString(),
                            InStock = bool.Parse(sqlDataReader[3].ToString()),
                            Genre = sqlDataReader[6].ToString()
                        };
                        if (sqlDataReader[3].ToString() == "True")
                        {
                            stocktext = "Dostêpna";
                        }
                        else
                        {
                            stocktext = "Wypo¿yczona";
                        }
                        bookListComboBox.Items.Add($"{sqlDataReader[1]}, {sqlDataReader[2]}, {stocktext}, {sqlDataReader[6]}");
                    }
                }
                catch (Exception ex)
                {
                    bookListComboBox.Text=ex.Message;
                    searchTextBox.Text=ex.StackTrace;
                }
            }
        }

        private void bookListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
            authorTextBox.Text= book.Author;
            titleTextBox.Text = book.Title;
            genreTextBox.Text = book.Genre;

        }
    }
}