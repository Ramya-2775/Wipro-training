using System;
using System.Data.SqlClient;

public class DeleteProduct
{
    static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";

    public static void Execute(int productId)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            string query = "DELETE FROM Products WHERE ProductID = @ProductID";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                
                cmd.Parameters.AddWithValue("@ProductID", productId);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine($"Product with ID {productId} deleted successfully.");
                }
                else
                {
                    Console.WriteLine($"No product found with ID {productId}.");
                }
            }
        }
    }
}
/*class program
{
    static void Main()
    {
        DeleteProduct.Execute(78);
    }

}*/