using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using ATM.Object;

namespace ATM
{
    partial class DAO
    {
        public static IList<Account> GetAccountList(User user)
        {
            SqlConnection conn = DAO.Connection();
            IList<Account> accounts = new List<Account>();
            string queryAccount = "SELECT AccountID, AccountName, AccountBank, AccountType, Balance, Grade, Flow FROM [Account] WHERE UserID ='" + user.UserId + "'";
            try
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = queryAccount;
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    accounts.Add(new Account(dataReader["AccountID"].ToString().Trim(), dataReader["AccountName"].ToString().Trim(), Convert.ToInt16(dataReader["AccountBank"]), Convert.ToBoolean(dataReader["AccountType"]), Convert.ToSingle(dataReader["Balance"]), Convert.ToInt16(dataReader["Grade"]), user.UserId, Convert.ToSingle(dataReader["Flow"])));
                }
                dataReader.Close();
                conn.Close();
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message.ToString());
            }
            return accounts;
        }

        public static IList<Account> GetAccountList(User user, Account account)
        {
            SqlConnection conn = DAO.Connection();
            IList<Account> accounts = new List<Account>();
            string queryAccount = "SELECT AccountID, AccountName, AccountBank, AccountType, Balance, Grade, Flow FROM [Account] WHERE UserID ='" + user.UserId + "'";
            try
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = queryAccount;
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    if (account.AccountID != dataReader["AccountID"].ToString().Trim())
                    {
                        accounts.Add(new Account(dataReader["AccountID"].ToString().Trim(), dataReader["AccountName"].ToString().Trim(), Convert.ToInt16(dataReader["AccountBank"]), Convert.ToBoolean(dataReader["AccountType"]), Convert.ToSingle(dataReader["Balance"]), Convert.ToInt16(dataReader["Grade"]), user.UserId, Convert.ToSingle(dataReader["Flow"])));
                    }
                }
                dataReader.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message.ToString());
            }
            return accounts;
        }
    }
}
