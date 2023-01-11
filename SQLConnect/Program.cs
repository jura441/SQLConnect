using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLConnect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = null;
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Library; Integrated Security = True";
            connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("подключение было открыто");
            //connection.ConnectionString = connectionString;
            connection.Close();
            Console.WriteLine("подключение было закрыто");


            /*Connect Timeout = 30; 
            Encrypt = False; 
            TrustServerCertificate = False; 
            ApplicationIntent = ReadWrite;
            MultiSubnetFailover = False*/
        }
    }
}
