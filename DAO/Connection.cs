using System;
using System.Data.SqlClient;

namespace ATM
{
    partial class DAO
    {
        public static SqlConnection Connection()
        {
            //return new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            return new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=atm;Integrated Security=True");
        }
        public static SqlConnection Connection(String s)
        {
            return new SqlConnection(s);
        }
    }
}
