using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using ATM.Object;

namespace ATM
{
    partial class DAO
    {
        public static IList<Bank> GetBankList()
        {
            SqlConnection conn = DAO.Connection();
            string queryName = "SELECT ID, Name FROM [Bank]";
            IList<Bank> list = new List<Bank>();
            try
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = queryName;
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    list.Add(new Bank(Convert.ToInt16(dataReader["ID"]), dataReader["Name"].ToString().Trim()));
                }
                dataReader.Close();
                conn.Close();
                return list;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message.ToString());
                return new List<Bank>();
            }
        }
    }
}
