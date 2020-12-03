using ATM.Object;
using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ATM
{
    partial class DAO
    {
        // 返回UserID
        public static int CheckRepeatUserName(string userID, string userName)
        {
            SqlConnection conn = DAO.Connection();
            // 查询账户是否存在
            string queryUserName = "SELECT UserID, UserName FROM [User] WHERE UserName='" + userName + "'";
            try
            {
                // 打开数据链接
                conn.Open();
                //Console.WriteLine("检查用户名{0}是否存在...", user.UserName);
                // 新建一个命令对象
                SqlCommand command = conn.CreateCommand();
                // 写入SQL语句
                command.CommandText = queryUserName;
                // 读取对应的结果集
                SqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return 0;
                }
                else
                {
                    int rows = 0;
                    string id = "";
                    string name = "";
                    while (reader.Read())
                    {
                        id = reader["UserID"].ToString();
                        name = reader["UserName"].ToString();
                        rows++;
                    }
                    //Console.WriteLine(id);
                    if (rows == 1)
                    {
                        if(id == userID)
                        {
                            reader.Close();
                            conn.Close();
                            return 1;
                        }
                        else
                        {
                            reader.Close();
                            conn.Close();
                            if(name != userName)
                            {
                                return 0;
                            }
                            return 2;
                        }
                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
                        return 3;
                    }
                }
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message.ToString());
                return 4;
            }
        }
        //public static int CheckRepeatUserName(User user)
        //{
        //    return CheckRepeatUserName(user.UserId, user.UserName);
        //}
    }
}
