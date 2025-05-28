using System;
using System.Data.SqlClient;

public class JoinOrdersAndCustomers
{
    static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";

    public static void Execute()
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            string query = @"
                SELECT o.OrderID, c.CompanyName, o.OrderDate
                FROM Orders o
                INNER JOIN Customers c ON o.CustomerID = c.CustomerID";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("OrderID | CompanyName | OrderDate");

                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["OrderID"],-8} | {reader["CompanyName"],-30} | {((DateTime)reader["OrderDate"]).ToShortDateString()}");
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
        JoinOrdersAndCustomers.Execute();
    }
}*/
