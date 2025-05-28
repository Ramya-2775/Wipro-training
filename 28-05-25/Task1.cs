using System;
using System.Data.SqlClient;

public class ListAllCustomers
{
    static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";

    public static void Execute()
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT CustomerID, CompanyName, Country FROM Customers";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["CustomerID"]} - {reader["CompanyName"]} - {reader["Country"]}");
                    }
                }
            }
        }
    }
}
/*class program
{
    static void Main()
    {
        ListAllCustomers.Execute();
    }
}*/