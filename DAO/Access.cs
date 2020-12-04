using System;
using System.Data.SqlClient;
using System.Diagnostics;
using ATM.Object;

namespace ATM
{
    partial class DAO
    {
        // 返回UserID
        public static int Access(Account account, bool status, float amount)
        {
            SqlConnection conn = DAO.Connection();

            Authority authority = DAO.AccessAuthority(account.Grade);
            if (status)
            {
                if (amount < 0)
                {
                    amount *= (-1);
                }
                if (amount>authority.Draw)
                {
                    return 1;
                }
            }
            else
            {
                if (amount > 0)
                {
                    amount *= (-1);
                }
                if (Math.Abs(account.Balance + amount) > authority.Loan)
                {
                    return 2;
                }
            }
            string accessAmount = "UPDATE Account SET Balance = " + Convert.ToSingle(account.Balance + amount) + ", Flow = " + Convert.ToSingle(account.Flow + Math.Abs(amount)) + " WHERE AccountID = '" + account.AccountID + "'";
            try
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                //Console.WriteLine(authority.Loan);
                //Console.WriteLine(Convert.ToSingle(account.Balance + amount));
                //Console.WriteLine(accessAmount);
                command.CommandText = accessAmount;
                int rows = command.ExecuteNonQuery();
                if (rows == 1)
                {
                    conn.Close();
                    return 0;
                }
                else
                {
                    Console.WriteLine("影响行数为{0}", rows);
                    conn.Close();
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
