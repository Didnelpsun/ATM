using System;
using System.Data.SqlClient;
using System.Diagnostics;
using ATM.Object;

namespace ATM
{
    partial class DAO
    {
        // 返回UserID
        public static int ChangeUserName(string OldUserName, string NewUserName, User user)
        {
            int minLength = 2;
            if (OldUserName == "")
            {
                return 1;
            }
            else
            {
                if (OldUserName != user.UserName)
                {
                    return 2;
                }
                else
                {
                    if (NewUserName.Length < minLength)
                    {
                        return 3;
                    }
                    else
                    {
                        if (OldUserName == NewUserName)
                        {
                            return 4;
                        }
                        else
                        {
                            int status = DAO.CheckRepeatUserName(user.UserId, NewUserName);
                            if (status == 0)
                            {
                                SqlConnection conn = DAO.Connection();
                                string updateUserName = "UPDATE [User] SET UserName=N'" + NewUserName + "' WHERE UserID = '" + user.UserId + "'";
                                //Console.WriteLine(updateUserName);
                                try
                                {
                                    conn.Open();
                                    SqlCommand command = conn.CreateCommand();
                                    command.CommandText = updateUserName;
                                    int rows = command.ExecuteNonQuery();
                                    conn.Close();
                                    if (rows > 0)
                                    {
                                        return 0;
                                    }
                                    else
                                    {
                                        return -1;
                                    }
                                }
                                catch (Exception exception)
                                {
                                    Debug.WriteLine(exception.Message.ToString());
                                    return -1;
                                }
                            }
                            else if (status == 2)
                            {
                                return 5;
                            }
                            else if (status == 3)
                            {
                                return 6;
                            }
                            else
                            {
                                return 7;
                            }
                        }
                    }
                }
            }
        }
    }
}
