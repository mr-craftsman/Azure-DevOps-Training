using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml;


namespace DB01EXlibraryManager
{
    internal class Program

    {
        // template local connection string here
        static string connectionString = "Data Source=(local);Initial Catalog=LibrarySystem;Integrated Security=True"; 
        static SqlConnection connection;

        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
            public bool Availability { get; set; }

            public Book(int bookID, string title, string author, string isbn, bool availability)
            {
                BookID = bookID;
                Title = title;
                Author = author;
                ISBN = isbn;
                Availability = availability;
            }
        }

        public class Borrower
        {
            public int BorrowerID { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public int TotalBorrowedBooks { get; set; }

            public Borrower(int borrowerID, string name, string email, string phone, int totalBorrowedBooks)
            {
                BorrowerID = borrowerID;
                Name = name;
                Email = email;
                Phone = phone;
                TotalBorrowedBooks = totalBorrowedBooks;
            }
        }

        static void Main(string[] args)
        {
            using (connection = new SqlConnection(connectionString))
            {
                ShowMenu();
            }
        }
        static void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("1.add a book record");
                Console.WriteLine("2.add a borrower record");
                Console.WriteLine("3.delete a book record");
                Console.WriteLine("4.delete a borrower record");
                Console.WriteLine("5.edit a book record");
                Console.WriteLine("6.edit a borrower record");
                Console.WriteLine("7.read and display all book records");
                Console.WriteLine("8.read and display all borrower records");
                Console.WriteLine("9.search for books");
                Console.WriteLine("10.search for borrowers");
                Console.WriteLine("11.borrow a book");
                Console.WriteLine("12.return a book");
                Console.WriteLine("13.exit");
                Console.Write("Provide your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBookRecord();
                        break;
                    case 2:
                        AddBorrowerRecord();
                        break;
                    case 3:
                        DeleteBookRecord();
                        break;
                    case 4:
                        DeleteBorrowerRecord();
                        break;
                    case 5:
                        EditBookRecord();
                        break;
                    case 6:
                        EditBorrowerRecord();
                        break;
                    case 7:
                        ReadAllBookRecords();
                        break;
                    case 8:
                        ReadAllBorrowerRecords();
                        break;
                    case 9:
                        SearchBooks();
                        break;
                    case 10:
                        SearchBorrowers();
                        break;
                    case 11:
                        BorrowBook();
                        break;
                    case 12:
                        ReturnBook();
                        break;
                    case 13:
                        return;

                    default:
                        Console.WriteLine("Wrong. Try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
        static void AddBookRecord()
        {
            Console.Write("enter book title: ");
            string title = Console.ReadLine();
            Console.Write("enter author: ");
            string author = Console.ReadLine();
            Console.Write("enter ISBN: ");
            string isbn = Console.ReadLine();
            Console.Write("enter book availability: ");
            bool availability = bool.Parse(Console.ReadLine());

            string query = "INSERT INTO Books (Title, Author, ISBN, Availability) VALUES (@Title, @Author, @ISBN, @Availability)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Title", title);
            command.Parameters.AddWithValue("@Author", author);
            command.Parameters.AddWithValue("@ISBN", isbn);
            command.Parameters.AddWithValue("@Availability", availability);
            command.ExecuteNonQuery();

            Console.WriteLine("book record added.");
        }
        static void AddBorrowerRecord()
        {
            Console.Write("enter borrower name: ");
            string name = Console.ReadLine();
            Console.Write("enter email: ");
            string email = Console.ReadLine();
            Console.Write("enter phone: ");
            string phone = Console.ReadLine();
            Console.Write("enter total borrowed books: ");
            int totalBorrowedBooks = int.Parse(Console.ReadLine());

            string query = "INSERT INTO Borrowers (Name, Email, Phone, TotalBorrowedBooks) VALUES (@Name, @Email, @Phone, @TotalBorrowedBooks)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@TotalBorrowedBooks", totalBorrowedBooks);
            command.ExecuteNonQuery();

            Console.WriteLine("borrower record added.");
        }
        static void DeleteBookRecord()
        {
            Console.Write("enter book ID to delete: ");
            int bookID = int.Parse(Console.ReadLine());

            string query = "DELETE FROM Books WHERE BookID = @BookID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookID", bookID);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
                Console.WriteLine("book record deleted.");
            else
                Console.WriteLine("book record not found.");
        }
        static void DeleteBorrowerRecord()
        {
            Console.Write("nter borrower ID to delete: ");
            int borrowerID = int.Parse(Console.ReadLine());

            string query = "DELETE FROM Borrowers WHERE BorrowerID = @BorrowerID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BorrowerID", borrowerID);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
                Console.WriteLine("borrower record deleted.");
            else
                Console.WriteLine("borrower record not found.");
        }
        static void EditBookRecord()
        {
            Console.Write("enter book ID to edit: ");
            int bookID = int.Parse(Console.ReadLine());
            Console.Write("enter changed title: ");
            string title = Console.ReadLine();
            Console.Write("enter changed author: ");
            string author = Console.ReadLine();
            Console.Write("enter changed ISBN: ");
            string isbn = Console.ReadLine();
            Console.Write("enter changed availability status: ");
            bool availability = bool.Parse(Console.ReadLine());

            string query = "UPDATE Books SET Title = @Title, Author = @Author, ISBN = @ISBN, Availability = @Availability WHERE BookID = @BookID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Title", title);
            command.Parameters.AddWithValue("@Author", author);
            command.Parameters.AddWithValue("@ISBN", isbn);
            command.Parameters.AddWithValue("@Availability", availability);
            command.Parameters.AddWithValue("@BookID", bookID);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
                Console.WriteLine("book record updated.");
            else
                Console.WriteLine("book record not found.");
        }
        static void EditBorrowerRecord()
        {
            Console.Write("enter borrower ID to edit: ");
            int borrowerID = int.Parse(Console.ReadLine());
            Console.Write("enter changed name: ");
            string name = Console.ReadLine();
            Console.Write("enter changed email: ");
            string email = Console.ReadLine();
            Console.Write("enter changed phone: ");
            string phone = Console.ReadLine();
            Console.Write("enter changed total borrowed books: ");
            int totalBorrowedBooks = int.Parse(Console.ReadLine());

            string query = "UPDATE Borrowers SET Name = @Name, Email = @Email, Phone = @Phone, TotalBorrowedBooks = @TotalBorrowedBooks WHERE BorrowerID = @BorrowerID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@TotalBorrowedBooks", totalBorrowedBooks);
            command.Parameters.AddWithValue("@BorrowerID", borrowerID);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
                Console.WriteLine("borrower record updated.");
            else
                Console.WriteLine("borrower record not found.");
        }
        static void ReadAllBookRecords()
        {
            string query = "SELECT * FROM Books";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            Console.WriteLine("BookID\tTitle\tAuthor\tISBN\tAvailability");
            while (reader.Read())
            {
                int bookID = (int)reader["BookID"];
                string title = (string)reader["Title"];
                string author = (string)reader["Author"];
                string isbn = (string)reader["ISBN"];
                bool availability = (bool)reader["Availability"];

                Console.WriteLine($"{bookID}\t{title}\t{author}\t{isbn}\t{availability}");
            }

            reader.Close();
        }
        static void ReadAllBorrowerRecords()
        {
            string query = "SELECT * FROM Borrowers";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            Console.WriteLine("BorrowerID\tName\tEmail\tPhone\tTotalBorrowedBooks");
            while (reader.Read())
            {
                int borrowerID = (int)reader["BorrowerID"];
                string name = (string)reader["Name"];
                string email = (string)reader["Email"];
                string phone = (string)reader["Phone"];
                int totalBorrowedBooks = (int)reader["TotalBorrowedBooks"];

                Console.WriteLine($"{borrowerID}\t{name}\t{email}\t{phone}\t{totalBorrowedBooks}");
            }

            reader.Close();
        }
        static void SearchBooks()
        {
            Console.Write("enter search keyword: ");
            string keyword = Console.ReadLine();

            string query = "SELECT * FROM Books WHERE Title LIKE @Keyword OR Author LIKE @Keyword OR ISBN LIKE @Keyword";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
            SqlDataReader reader = command.ExecuteReader();

            Console.WriteLine("search results:");
            Console.WriteLine("BookID\tTitle\tAuthor\tISBN\tAvailability");
            while (reader.Read())
            {
                int bookID = (int)reader["BookID"];
                string title = (string)reader["Title"];
                string author = (string)reader["Author"];
                string isbn = (string)reader["ISBN"];
                bool availability = (bool)reader["Availability"];

                Console.WriteLine($"{bookID}\t{title}\t{author}\t{isbn}\t{availability}");
            }

            reader.Close();
        }
        static void SearchBorrowers()
        {
            Console.Write("enter search keyword: ");
            string keyword = Console.ReadLine();

            string query = "SELECT * FROM Borrowers WHERE Name LIKE @Keyword OR Email LIKE @Keyword OR Phone LIKE @Keyword";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
            SqlDataReader reader = command.ExecuteReader();

            Console.WriteLine("search eesults:");
            Console.WriteLine("BorrowerID\tName\tEmail\tPhone\tTotalBorrowedBooks");
            while (reader.Read())
            {
                int borrowerID = (int)reader["BorrowerID"];
                string name = (string)reader["Name"];
                string email = (string)reader["Email"];
                string phone = (string)reader["Phone"];
                int totalBorrowedBooks = (int)reader["TotalBorrowedBooks"];

                Console.WriteLine($"{borrowerID}\t{name}\t{email}\t{phone}\t{totalBorrowedBooks}");
            }

            reader.Close();
        }
        static void BorrowBook()
        {
            Console.Write("enter book ID to borrow: ");
            int bookID = int.Parse(Console.ReadLine());

            // Check if the book is available
            string query = "SELECT Availability FROM Books WHERE BookID = @BookID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookID", bookID);
            bool availability = (bool)command.ExecuteScalar();

            if (availability)
            {
                Console.Write("enter borrower ID: ");
                int borrowerID = int.Parse(Console.ReadLine());

                // Check if the borrower exists
                query = "SELECT COUNT(*) FROM Borrowers WHERE BorrowerID = @BorrowerID";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BorrowerID", borrowerID);
                int borrowerCount = (int)command.ExecuteScalar();

                if (borrowerCount > 0)
                {
                    // Update book availability
                    query = "UPDATE Books SET Availability = 0 WHERE BookID = @BookID";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BookID", bookID);
                    command.ExecuteNonQuery();

                    // Increment total borrowed books count for the borrower
                    query = "UPDATE Borrowers SET TotalBorrowedBooks = TotalBorrowedBooks + 1 WHERE BorrowerID = @BorrowerID";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BorrowerID", borrowerID);
                    command.ExecuteNonQuery();

                    Console.WriteLine("book borrowed.");
                }
                else
                {
                    Console.WriteLine("borrower not found.");
                }
            }
            else
            {
                Console.WriteLine("book not available.");
            }
        }
        static void ReturnBook()
        {
            Console.Write("enter book ID to return: ");
            int bookID = int.Parse(Console.ReadLine());

            // Check if the book is borrowed
            string query = "SELECT Availability FROM Books WHERE BookID = @BookID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookID", bookID);
            bool availability = (bool)command.ExecuteScalar();

            if (!availability)
            {
                Console.Write("enter borrower ID: ");
                int borrowerID = int.Parse(Console.ReadLine());

                // Check if the borrower exists
                query = "SELECT COUNT(*) FROM Borrowers WHERE BorrowerID = @BorrowerID";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BorrowerID", borrowerID);
                int borrowerCount = (int)command.ExecuteScalar();

                if (borrowerCount > 0)
                {
                    // Update book availability
                    query = "UPDATE Books SET Availability = 1 WHERE BookID = @BookID";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BookID", bookID);
                    command.ExecuteNonQuery();

                    // Decrement total borrowed books count for the borrower
                    query = "UPDATE Borrowers SET TotalBorrowedBooks = TotalBorrowedBooks - 1 WHERE BorrowerID = @BorrowerID";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BorrowerID", borrowerID);
                    command.ExecuteNonQuery();

                    Console.WriteLine("book returned.");
                }
                else
                {
                    Console.WriteLine("borrower not found.");
                }
            }
            else
            {
                Console.WriteLine("book is not borrowed.");
            }
        }

        static void UserAuthentication()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            // Validate username and password against the database or some predefined values
            // For simplicity, we will assume that the username is "admin" and the password is "password"

            if (username == "admin" && password == "password")
            {
                Console.WriteLine("Authentication successful.");
                // Perform library management operations
                // PerformLibraryOperations();
            }
            else
            {
                Console.WriteLine("Authentication failed. Invalid username or password.");
            }
        }
    }
}
