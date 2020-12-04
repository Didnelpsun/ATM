using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using ATM.Object;

namespace ATM
{
    partial class DAO
    {
        public static Account GetAccount(Account account)
        {
            SqlConnection conn = DAO.Connection();
            // 查询对应ID下的多个账户
            string queryAccount = "SELECT AccountName, AccountBank, AccountType, Balance, Grade, Flow FROM [Account] WHERE AccountID ='" + account.AccountID + "'";
            try
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = queryAccount;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        account.AccountName = reader["AccountName"].ToString().Trim();
                        account.AccountBank = Convert.ToInt16(reader["AccountBank"]);
                        account.AccountType = Convert.ToBoolean(reader["AccountType"]);
                        account.Balance = Convert.ToSingle(reader["Balance"]);
                        account.Grade = Convert.ToInt16(reader["Grade"]);
                        account.Flow = Convert.ToSingle(reader["Flow"]);
                    }
                }
                reader.Close();
                conn.Close();
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message.ToString());
            }
            return account;
        }
    }
}
