using System;
using System.Data.SqlClient;
using System.Diagnostics;
using ATM.Object;

namespace ATM
{
    partial class DAO
    {
        // 返回UserID
        public static void Login(User user)
        {
            SqlConnection conn = DAO.Connection();
            // 查询账户是否存在
            string queryUser = "SELECT UserID, Password FROM [User] WHERE UserName=N'" + user.UserName + "'";
            try
            {
                // 打开数据链接
                conn.Open();
                //Console.WriteLine("检查用户名{0}是否存在...", user.UserName);
                // 新建一个命令对象
                SqlCommand command = conn.CreateCommand();
                // 写入SQL语句
                command.CommandText = queryUser;
                // 读取对应的结果集
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //Console.WriteLine(reader["UserID"]);
                        if (reader["Password"].ToString().CompareTo(user.Password) == 0)
                        {
                            user.UserId = reader["UserID"].ToString();
                            return;
                        }
                        else
                        {
                            user.UserId = "2";
                        }
                    }
                }
                else
                {
                    user.UserId = "1";
                }
                reader.Close();
                conn.Close();
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message.ToString());
                user.UserId = "3";
            }
        }
    }
}
