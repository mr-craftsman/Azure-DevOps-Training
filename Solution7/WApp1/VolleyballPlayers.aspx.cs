using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WApp1
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        public string SampleString { get; set; }
        public List<Player> PlayerList = new List<Player>();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sampleString = "hello 1!!";
            // Response.Write(sampleString);
            SampleString = sampleString;
            PlayerList = new List<Player>();


            // need to change connection string and add new database to this Visual Studio
            // or to a Azure account
            string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=VolleyBallDatabase;Integrated Security=True;Pooling=False";
            //also, in .NET framework SQL client is preloaded, not as in Core app          

            // using statement works similar to Context Manager in Python, so no need to close connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                try
                {
                    using (SqlCommand command = new SqlCommand("SELECT Id, FirstName, LastName FROM Persons", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                PlayerList.Add(new Player()
                                {
                                    id = reader.GetInt32(0),
                                    firstName = reader.GetString(1),
                                    lastName = reader.GetString(2),
                                    Country = reader.GetString(3),
                                });

                                //Console.WriteLine($"Id: {reader.GetInt32(0)}, " +
                                //    $"FirstName:{reader.GetString(1)}, " +
                                //    $"LastName: {reader.GetString(2)}");
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

            }



        }
    }
}