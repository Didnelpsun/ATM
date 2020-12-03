using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ATM
{
    partial class DAO
    {
        // 返回UserID
        public static int ForgetPassword(string UserID, string UserName, string NewPsw, string ConfirmPsw, string CheckName)
        {
            int minLength = 3;
            if (UserID.Trim() == "")
            {
                return 1;
            }
            else
            {
                if (CheckName == null)
                {
                    return 2;
                }
                else
                {
                    if (Convert.ToBoolean(UserName.CompareTo(CheckName)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (NewPsw.Length < minLength)
                        {
                            return 4;
                        }
                        else if (!Utils.CheckValidChar(NewPsw))
                        {
                            return 5;
                        }
                        else
                        {
                            if (Convert.ToBoolean(ConfirmPsw.CompareTo(NewPsw)))
                            {
                                return 6;
                            }
                            else
                            {
                                SqlConnection conn = DAO.Connection();
                                string updatePsw = "UPDATE [User] SET Password='" + NewPsw + "' WHERE UserID = '" + UserID + "'";
                                //Console.WriteLine(updatePsw);
                                try
                                {
                                    conn.Open();
                                    SqlCommand command = conn.CreateCommand();
                                    command.CommandText = updatePsw;
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
                        }
                    }
                }
            }
        }
    }
}
