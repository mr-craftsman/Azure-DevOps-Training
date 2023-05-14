using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SQL02Repos;



internal class PersonsRepo
{
    private string connectionString =
        "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=VolleyBallDatabase;Integrated Security=True;Pooling=False";


    public Person[] GetPersons()  // array has fixed length for business logic
    {
        {
            List<Person> persons = new List<Person>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                using (SqlCommand command =
                    new SqlCommand("SELECT Id, FirstName, LastName FROM Persons", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Person person = new Person();
                            person.Id = reader.GetInt32(0);
                            person.FirstName = reader.GetString(1);
                            person.LastName = reader.GetString(2);
                            persons.Add(person);
                        }
                    }
                }
            }
            return persons.ToArray();
        }
    }
    public List<Person> GetPersons2() // list can be updated, for business logic
    {
        List<Person> persons = new List<Person>();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {

            connection.Open();
            using (SqlCommand command =
                new SqlCommand("SELECT Id, FirstName, LastName FROM Persons", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Person person = new Person();
                        person.Id = reader.GetInt32(0);
                        person.FirstName = reader.GetString(1);
                        person.LastName = reader.GetString(2);
                        persons.Add(person);
                    }
                }
            }
        }
        return persons;
    }
    public void CreatePersons(Person person)  // array has fixed length for business logic
    {
        {
            List<Person> persons = new List<Person>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                using (SqlCommand command =
                    new SqlCommand("INSERT INTO Persons (FirstName,LastName) VALUES(@FirstName, @LastName)", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        command.Parameters.AddWithValue("@FirstName", "John");
                        command.Parameters.AddWithValue("@LastName", "Doe");
                        int rowsAffected = command.ExecuteNonQuery();
                        //Console.WriteLine($"{rowsAffected} rows affected.");
                    }
                }
            }
            
        }
    }
    public void UpdatePersons(Person person)  // array has fixed length for business logic
    {
        {
            List<Person> persons = new List<Person>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                using (SqlCommand command =
                    new SqlCommand("UPDATE Persons SET FirstName = @FirstName WHERE Id = @Id", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        command.Parameters.AddWithValue("@Id", 1);
                        command.Parameters.AddWithValue("@FirstName", "UpdatedFirstName");
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} rows affected.");
                    }
                }
            }
            
        }
    }
    public void DeletePersons(int id)  // array has fixed length for business logic
    {
        {
            List<Person> persons = new List<Person>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                using (SqlCommand command =
                    new SqlCommand("DELETE FROM Persons WHERE Id = @Id", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        command.Parameters.AddWithValue("@Id", 1);
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} rows affected.");
                    }
                }
            }
           
        }
    }

    public void TestingMethod(int a, int b, int c)
    {

    }
    public void TestingMethod2(int[] arr)
    {

    }
    public void TestingMethod3(params int[] arr)
    {
        Console.WriteLine(arr[0]);
        Console.WriteLine(arr[1]);
    }
}
