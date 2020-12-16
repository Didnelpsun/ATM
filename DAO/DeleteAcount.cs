using System;
using System.Data.SqlClient;
using System.Diagnostics;
using ATM.Object;

namespace ATM
{
    partial class DAO
    {
        // 返回UserID
        public static int DeleteAcount(Account account)
        {
            SqlConnection conn = DAO.Connection();
            string delAccount = "DELETE FROM Account WHERE AccountID = '" + account.AccountID + "'";
            try
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = delAccount;
                int rows = command.ExecuteNonQuery();
                if (rows == 1)
                {
                    return 0;
                }
                else
                {
                    Console.WriteLine("影响行数为{0}", rows);
                    return -1;
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message.ToString());
                return -1;
            }
        }
    }
}
