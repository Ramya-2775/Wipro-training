using System.Data.SqlClient;
using System;

public class SimulateOrderTransaction
{
    static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";

    public static void Execute()
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlTransaction transaction = conn.BeginTransaction();

            try
            {
                string insertOrderQuery = @"
                    INSERT INTO Orders (CustomerID, EmployeeID, OrderDate, ShipCountry)
                    VALUES (@CustomerID, @EmployeeID, @OrderDate, @ShipCountry);
                    SELECT SCOPE_IDENTITY();"; 

                int newOrderId;

                using (SqlCommand cmd = new SqlCommand(insertOrderQuery, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", "ALFKI");
                    cmd.Parameters.AddWithValue("@EmployeeID", 1);
                    cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@ShipCountry", "Germany");

                    newOrderId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                
                string insertDetailQuery = @"
                    INSERT INTO [Order Details] (OrderID, ProductID, UnitPrice, Quantity, Discount)
                    VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount)";

                using (SqlCommand cmd = new SqlCommand(insertDetailQuery, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@OrderID", newOrderId);
                    cmd.Parameters.AddWithValue("@ProductID", 1); 
                    cmd.Parameters.AddWithValue("@UnitPrice", 25.00m);
                    cmd.Parameters.AddWithValue("@Quantity", 3);
                    cmd.Parameters.AddWithValue("@Discount", 0);

                    cmd.ExecuteNonQuery();
                }

               
                transaction.Commit();
                Console.WriteLine($"Order {newOrderId} and its detail inserted successfully.");
            }
            catch (Exception ex)
            {
               
                transaction.Rollback();
                Console.WriteLine("Transaction failed: " + ex.Message);
            }
        }
    }
}
/*class program
{
    static void Main()
    {
        SimulateOrderTransaction.Execute();
    }
}*/