using System;
using MySql.Data.MySqlClient;

class Program
{
    static void Main()
    {
        private string connectionString = "server=localhost;user id=guitar_app;password=5;database=guitar_learning;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        try
        {
            connection.Open();
            Console.WriteLine("Connection successful!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }
}