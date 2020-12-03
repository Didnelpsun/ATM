using System;
using System.Data.SqlClient;
using System.Diagnostics;
using ATM.Object;

namespace ATM
{
    partial class DAO
    {
        // 返回UserID
        public static int ChangePassword(string OldPsw, string NewPsw, string ConfirmPsw, User user)
        {
            int minLength = 3;
            if (OldPsw == "")
            {
                return 1;
            }
            else
            {
                if (OldPsw != user.Password)
                {
                    return 2;
                }
                else
                {
                    if (NewPsw.Length < minLength)
                    {
                        return 3;
                    }
                    else if (!Utils.CheckValidChar(NewPsw))
                    {
                        return 4;
                    }
                    else
                    {
                        if (Convert.ToBoolean(ConfirmPsw.CompareTo(NewPsw)))
                        {
                            return 5;
                        }
                        else
                        {
                            SqlConnection conn = DAO.Connection();
                            string updatePsw = "UPDATE [User] SET Password='" + NewPsw + "' WHERE UserID = '" + user.UserId + "'";
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
