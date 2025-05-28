using System;
using System.Data.SqlClient;

public class UpdateEmployeeTitle
{
    static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";

    public static void Execute(int employeeId, string newTitle)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            string query = "UPDATE Employees SET Title = @Title WHERE EmployeeID = @EmployeeID";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                
                cmd.Parameters.AddWithValue("@Title", newTitle);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeId);

                int rowsAffected = cmd.ExecuteNonQuery();

                Console.WriteLine($" {rowsAffected} row(s) updated in Employees table.");
            }
        }
    }
}
/*class program
{
    static void Main()
    {
        UpdateEmployeeTitle.Execute(1, "Sales");
    }
}*/