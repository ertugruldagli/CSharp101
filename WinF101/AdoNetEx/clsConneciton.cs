using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetEx
{
    public class clsConneciton
    {


        public static string GetConnectionString()
        {
            return @"Data Source=ED-INTERN;Initial Catalog=Northwind;Integrated Security=True";
        }

        public static void openConnection()
        {
            string connectionString = GetConnectionString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
            }


        }

            
        
           
     
    }
}
