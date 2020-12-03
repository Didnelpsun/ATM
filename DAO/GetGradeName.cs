using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using ATM.Object;

namespace ATM
{
    partial class DAO
    {
        public static string GetGradeName(int id)
        {
            SqlConnection conn = DAO.Connection();
            string queryName = "SELECT Name FROM [Grade] WHERE ID ='" + id.ToString() + "'";
            try
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = queryName;
                SqlDataReader dataReader = command.ExecuteReader();
                if (!dataReader.HasRows)
                {
                    dataReader.Close();
                    conn.Close();
                    return "等级无对应值";
                }
                else
                {
                    while (dataReader.Read())
                    {
                        return dataReader["Name"].ToString();
                    }
                    dataReader.Close();
                    conn.Close();
                    return "等级缺失";

                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message.ToString());
                return "程序错误";
            }
        }
        public static string GetGradeName(string id)
        {
            int intid = Convert.ToInt16(id);
            return GetGradeName(intid);
        }
    }
}
