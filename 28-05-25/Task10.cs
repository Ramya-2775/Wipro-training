using System.Data.SqlClient;
using System.Data;
public class LoadProductsWithStockAbove20
{
    static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";

    public static void Execute()
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT ProductID, ProductName, UnitsInStock FROM Products";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet, "Products");

            DataTable productsTable = dataSet.Tables["Products"];

            Console.WriteLine("📦 Products with UnitsInStock > 20");
            Console.WriteLine("ProductID | ProductName                 | UnitsInStock");

            DataRow[] filteredRows = productsTable.Select("UnitsInStock > 20");

            foreach (DataRow row in filteredRows)
            {
                Console.WriteLine($"{row["ProductID"],-9} | {row["ProductName"],-28} | {row["UnitsInStock"]}");
            }
        }
    }
}
/*class program
{
    static void Main()
    {
        LoadProductsWithStockAbove20.Execute();

    }
}*/

