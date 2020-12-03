using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ATM
{
    partial class DAO
    {
        // 返回UserID
        public static string CheckUser(string userID)
        {
            if (userID.ToString().Trim() == "")
            {
                return "";
            }
            else
            {
                SqlConnection conn = DAO.Connection();
                // 查询账户是否存在
                string queryId = "SELECT UserName FROM [User] WHERE UserId='" + userID + "'";
                try
                {
                    // 打开数据链接
                    conn.Open();
                    //Console.WriteLine("检查用户名{0}是否存在...", user.UserName);
                    // 新建一个命令对象
                    SqlCommand command = conn.CreateCommand();
                    // 写入SQL语句
                    command.CommandText = queryId;
                    // 读取对应的结果集
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        return reader["UserName"].ToString();
                    }
                    reader.Close();
                    conn.Close();
                    return "";
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message.ToString());
                    return "";
                }
            }
        }
    }
}
