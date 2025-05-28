/*using System.Data;
using System.Data.SqlClient;

class Program
{
    static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";

    static void TestConnection()
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            Console.WriteLine("Connection successful!");
        }
    }
    static void Main()
    {
        TestConnection();
    }
}*/