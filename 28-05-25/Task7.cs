using System;
using System.Data;
using System.Data.SqlClient;

public class DisplayTotalSalesByCategory
{
    static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";

    public static void Execute()
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = @"
                SELECT p.CategoryID, SUM(od.UnitPrice * od.Quantity) AS TotalSales
                FROM [Order Details] od
                INNER JOIN Products p ON od.ProductID = p.ProductID
                GROUP BY p.CategoryID";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            Console.WriteLine("CategoryID | TotalSales");

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"{row["CategoryID"],-11} | {((decimal)row["TotalSales"]):C}");
            }
        }
    }
}
/*class program
{
    static void Main()
    {
        DisplayTotalSalesByCategory.Execute();

    }
}*/