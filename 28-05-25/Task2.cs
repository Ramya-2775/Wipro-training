using System;
using System.Data.SqlClient;

public class GetOrdersByCustomer
{
    static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";

    public static void Execute(string customerId)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            string query = "SELECT OrderID, OrderDate, ShipCountry FROM Orders WHERE CustomerID = @CustomerID";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                
                cmd.Parameters.AddWithValue("@CustomerID", customerId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine($"Orders for Customer ID: {customerId}");

                    while (reader.Read())
                    {
                        Console.WriteLine($"OrderID: {reader["OrderID"]}, Date: {reader["OrderDate"]}, ShipCountry: {reader["ShipCountry"]}");
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
        GetOrdersByCustomer.Execute("TRADH");

    }
}
*/
