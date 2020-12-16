using System;
using System.Data.SqlClient;
using System.Diagnostics;
using ATM.Object;

namespace ATM
{
    partial class DAO
    {
        // 返回UserID
        public static int AddAcount(Account account)
        {
            int minLength = 2;
            if (account.AccountID == "")
            {
                return 1;
            }
            else
            {
                if (account.AccountName == "")
                {
                    return 2;
                }
                else if (account.AccountName.Length < minLength)
                {
                    return 3;
                }
                else
                {
                    if (account.AccountBank == -1)
                    {
                        return 4;
                    }
                    else
                    {
                        if (account.Grade > -1)
                        {
                            SqlConnection conn = DAO.Connection();
                            string addAccount = "INSERT INTO Account VALUES ('{0}', N'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')";
                            addAccount = string.Format(addAccount, account.AccountID, account.AccountName, account.AccountBank, account.AccountType, account.Balance, account.Grade, account.UserID, account.Flow);
                            //Console.WriteLine(addAccount);
                            try
                            {
                                conn.Open();
                                SqlCommand command = conn.CreateCommand();
                                command.CommandText = addAccount;
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
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
