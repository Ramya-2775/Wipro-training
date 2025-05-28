using System;
using System.Data.SqlClient;


public class ExecuteCustOrderHist
{
    static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";

    public static void Execute(string customerId)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            using (SqlCommand cmd = new SqlCommand("CustOrderHist", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerID", customerId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine($"Order History for Customer ID: {customerId}");
                    Console.WriteLine("ProductName                     | Total");

                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["ProductName"],-30} | {reader["Total"]}");
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
        ExecuteCustOrderHist.Execute("ALFKI");

    }
}*/