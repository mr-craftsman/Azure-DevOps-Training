using Microsoft.Data.SqlClient;

SqlConnection connection; // info about connection to db 

SqlCommand command; // sql commands 

SqlDataReader reader; // read data from db

string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=VolleyBallDatabase;Integrated Security=True;Pooling=False";
connection = new SqlConnection(connectionString);

command = new SqlCommand("select * from players", connection);

connection.Open();

reader = command.ExecuteReader();

while (reader.Read())
{
    string result = reader.GetValue(2) + " " + reader.GetValue(3);
    Console.WriteLine(result);
}

connection.Close();

