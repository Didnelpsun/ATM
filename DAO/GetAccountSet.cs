using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using ATM.Object;

namespace ATM
{
    partial class DAO
    {
        public static DataSet GetAccountSet(User user)
        {
            SqlConnection conn = DAO.Connection();
            // 查询对应ID下的多个账户
            string queryAccount = "SELECT AccountID, AccountName, AccountBank, AccountType, Balance, Grade, Flow FROM [Account] WHERE UserID ='" + user.UserId + "'";
            try
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(queryAccount, conn);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Account");
                conn.Close();
                return dataSet;
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message.ToString());
                return new DataSet();
            }
        }
    }
}
