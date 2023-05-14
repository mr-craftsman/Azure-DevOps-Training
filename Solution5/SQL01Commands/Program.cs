using System.Data.Common;
using Microsoft.Data.SqlClient;  //System.Data was for .NET, as for core this is true
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using static System.Runtime.InteropServices.JavaScript.JSType;




string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=VolleyBallDatabase;Integrated Security=True;Pooling=False";


// using statement works similar to Context Manager in Python, so no need to close connection
using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();
    try
    {
        using (SqlCommand command = new SqlCommand("INSERT INTO Persons (FirstName,LastName) VALUES(@FirstName, @LastName)", connection))
        {
            command.Parameters.AddWithValue("@FirstName", "John");
            command.Parameters.AddWithValue("@LastName", "Doe");
            int rowsAffected = command.ExecuteNonQuery();
            Console.WriteLine($"{rowsAffected} rows affected.");
        }
    }
    catch (SqlException ex)
    {

        Console.WriteLine("An error with DB" + ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Just another exception" + ex.Message);
    }

    try
    {
        using (SqlCommand command = new SqlCommand("SELECT Id, FirstName, LastName FROM Persons", connection))
        {
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"Id: {reader.GetInt32(0)}, FirstName:{reader.GetString(1)}, LastName: {reader.GetString(2)}");
                }
            }
        }
    }
    catch (SqlException ex)
    {

        Console.WriteLine("An error with DB" + ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Just another exception" + ex.Message);
    }


    try
    {
        using (SqlCommand command = new SqlCommand("UPDATE Persons SET FirstName = @FirstName WHERE Id = @Id", connection))
        {
            command.Parameters.AddWithValue("@Id", 1);
            command.Parameters.AddWithValue("@FirstName", "UpdatedFirstName");
            int rowsAffected = command.ExecuteNonQuery();
            Console.WriteLine($"{rowsAffected} rows affected.");
        }
    }
    catch (SqlException ex)
    {

        Console.WriteLine("An error with DB" + ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Just another exception" + ex.Message);
    }


    try
    {
        using (SqlCommand command = new SqlCommand("DELETE FROM Persons WHERE Id = @Id", connection))
        {
            command.Parameters.AddWithValue("@Id", 1);
            int rowsAffected = command.ExecuteNonQuery();
            Console.WriteLine($"{rowsAffected} rows affected.");
        }
    }
    catch (SqlException ex)
    {

        Console.WriteLine("An error with DB" + ex.Message);
    }
    catch(Exception ex)
    {
        Console.WriteLine("Just another exception" + ex.Message);
    }


}




