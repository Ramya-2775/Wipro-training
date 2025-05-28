using System;
using System.Data.SqlClient;

public class InsertNewProduct
{
    static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";

    public static void Execute()
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            string query = @"
                INSERT INTO Products (ProductName, SupplierID, CategoryID, UnitPrice)
                VALUES (@ProductName, @SupplierID, @CategoryID, @UnitPrice)";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
               
                cmd.Parameters.AddWithValue("@ProductName", "Test Product");
                cmd.Parameters.AddWithValue("@SupplierID", 1);
                cmd.Parameters.AddWithValue("@CategoryID", 1);
                cmd.Parameters.AddWithValue("@UnitPrice", 25);

                int rowsAffected = cmd.ExecuteNonQuery();

                Console.WriteLine($"{rowsAffected} row(s) inserted into Products table.");
            }
        }
    }
}
class program
{
    static void Main()
    {
        InsertNewProduct.Execute();

    }
}
