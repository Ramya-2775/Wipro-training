using System.Data.SqlClient;

/*class program
{
    static void Main()
    {
        string connectionString =

        "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"

        + "Integrated Security=true";


        // Provide the query string with a parameter placeholder.

        string queryString =

        "SELECT ProductID, UnitPrice, ProductName from dbo.products "

        + "WHERE UnitPrice > @pricePoint "

        + "ORDER BY UnitPrice DESC;";

        int paramvalue = 5;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@pricepoint", paramvalue);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}",
                        reader[0], reader[1], reader[2]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            Console.ReadLine();
        }
    }
}

class sqlconnectiondemo
{
    static void Main()
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"

        + "Integrated Security=true");

        SqlDataReader rdr = null;

        try
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from customers", conn);

            rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                Console.WriteLine(rdr[1]);
            }
        }
        catch
        {

        }
        finally
        {
            if (rdr !=null)
            {
                rdr.Close();
            }

            if(conn!= null)
            {
                conn.Close();   
            }
        }

    }
}*/

