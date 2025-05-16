using System;
using System.Data.SqlClient;
using System.Linq.Expressions;

/*class sqlconnectiondemo
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

            SqlCommand command = new SqlCommand("select * from customers", conn);

            rdr = command.ExecuteReader();

            Console.WriteLine("{0,-25} {1,-20} {2}", "Contact Name", "City", "Company Name");
            Console.WriteLine(new string('-', 70));

            while (rdr.Read())

            {
                string ContactName = rdr["ContactName"].ToString();
                string City = rdr["City"].ToString();
                string CompanyName = rdr["CompanyName"].ToString();
                Console.WriteLine("{0,-25} {1,-20} {2}", ContactName, City, CompanyName);
                

            }
        }
        catch
        {

        }
        finally
        {
            if (rdr != null)

                rdr.Close();
            if (conn != null)
                conn.Close();

        }
             

            
             
            
    }
}*/

