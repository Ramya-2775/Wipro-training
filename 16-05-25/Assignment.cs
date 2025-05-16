using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
            "Integrated Security=true";

        string query = @"
            SELECT  
                c.ContactName AS CustomerName,
                e.FirstName + ' ' + e.LastName AS EmployeeName,
                o.OrderID,
                o.OrderDate,
                od.ProductID,
                od.Quantity,
                od.UnitPrice
            FROM Customers c
            INNER JOIN Orders o ON c.CustomerID = o.CustomerID
            INNER JOIN Employees e ON o.EmployeeID = e.EmployeeID
            INNER JOIN [Order Details] od ON o.OrderID = od.OrderID
        ";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Header with alignment
                Console.WriteLine(
                    "CustomerName".PadRight(25) +
                    "EmployeeName".PadRight(25) +
                    "OrderID".PadRight(10) +
                    "OrderDate".PadRight(15) +
                    "ProductID".PadRight(12) +
                    "Quantity".PadRight(10) +
                    "UnitPrice".PadRight(12)
                );

                Console.WriteLine(new string('-', 110)); // optional separator

                // Row data with alignment
                while (reader.Read())
                {
                    string customername = reader["CustomerName"].ToString();
                    string employeename = reader["EmployeeName"].ToString();
                    string orderID = reader["OrderID"].ToString();
                    string orderdate = Convert.ToDateTime(reader["OrderDate"]).ToShortDateString();
                    string productID = reader["ProductID"].ToString();
                    string quantity = reader["Quantity"].ToString();
                    string unitprice = reader["UnitPrice"].ToString();

                    Console.WriteLine(
                        customername.PadRight(25) +
                        employeename.PadRight(25) +
                        orderID.PadRight(10) +
                        orderdate.PadRight(15) +
                        productID.PadRight(12) +
                        quantity.PadRight(10) +
                        unitprice.PadRight(12)
                    );
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}