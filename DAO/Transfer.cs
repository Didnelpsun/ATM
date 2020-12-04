using System;
using System.Data.SqlClient;
using System.Diagnostics;
using ATM.Object;

namespace ATM
{
    partial class DAO
    {
        // 返回UserID
        public static int Transfer(Account souAccount, Account tarAccount, float amount)
        {
            SqlConnection conn = DAO.Connection();
            if (amount > DAO.AccessAuthority(souAccount.Grade).Draw)
            {
                return 1;
            }
            if(souAccount.Balance - amount < 0)
            {
                return 2;
            }
            string sourceAmount = "UPDATE Account SET Balance = " + Convert.ToSingle(souAccount.Balance - amount) + ", Flow = " + Convert.ToSingle(souAccount.Flow + amount) + " WHERE AccountID = '" + souAccount.AccountID + "'";
            string targetAmount = "UPDATE Account SET Balance = " + Convert.ToSingle(tarAccount.Balance + amount) + ", Flow = " + Convert.ToSingle(tarAccount.Flow + amount) + " WHERE AccountID = '" + tarAccount.AccountID + "'";
            conn.Open();
            SqlTransaction sqlTransaction = conn.BeginTransaction();
            SqlCommand command = conn.CreateCommand();
            try
            {
                command.CommandText = sourceAmount;
                command.Transaction = sqlTransaction;
                command.ExecuteNonQuery();
                command = conn.CreateCommand();
                command.CommandText = targetAmount;
                command.Transaction = sqlTransaction;
                command.ExecuteNonQuery();
                sqlTransaction.Commit();
                return 0;
            }
            catch (Exception exception)
            {
                sqlTransaction.Rollback();
                Debug.WriteLine(exception.Message.ToString());
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
