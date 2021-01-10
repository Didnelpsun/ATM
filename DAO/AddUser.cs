using System;
using System.Data.SqlClient;
using System.Diagnostics;
using ATM.Object;

namespace ATM
{
    partial class DAO
    {
        // 返回UserID
        public static int AddUser(User user)
        {
            int minLength = 4;
            if (user.Password.Length < minLength)
            {
                return 1;
            }
            else
            {
                int status = DAO.CheckRepeatUserName(user.UserId, user.UserName);
                if (status == 0)
                {
                    SqlConnection conn = DAO.Connection();
                    string addUser = "INSERT INTO [User] VALUES ('{0}', N'{1}', '{2}')";
                    addUser = string.Format(addUser, user.UserId, user.UserName, user.Password);
                    //Console.WriteLine(addAccount);
                    try
                    {
                        conn.Open();
                        SqlCommand command = conn.CreateCommand();
                        command.CommandText = addUser;
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
                    return 2;
                }
            }
        }
    }
}
