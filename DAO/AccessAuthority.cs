using System;
using System.Data.SqlClient;
using System.Diagnostics;
using ATM.Object;

namespace ATM
{
    partial class DAO
    {
        public static Authority AccessAuthority(int ID)
        {
            Authority authority = new Authority();
            SqlConnection conn = DAO.Connection();
            string queryId = "SELECT Draw, Loan FROM [Authority] WHERE Id='" + ID.ToString() + "'";
            try
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = queryId;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    authority.Draw = Convert.ToSingle(reader["Draw"]);
                    authority.Loan = Convert.ToSingle(reader["Loan"]);
                }
                reader.Close();
                conn.Close();
                return authority;
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message.ToString());
                return null;
            }
        }
    }
}
