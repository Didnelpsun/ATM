
using System;

namespace ATM.Object
{
    public class Account
    {
        private string accountid;
        private string accountname;
        private int accountbank;
        private bool accounttype;
        private float balance;
        private int grade;
        private string userid;
        private float flow;
        public string AccountID
        {
            set
            {
                accountid = value.ToString();
            }
            get
            {
                return accountid;
            }
        }
        public string AccountName
        {
            set
            {
                accountname = value.ToString();
            }
            get
            {
                return accountname;
            }
        }
        public int AccountBank
        {
            set
            {
                accountbank = value;
            }
            get
            {
                return accountbank;
            }
        }
        public bool AccountType
        {
            set
            {
                accounttype = Convert.ToBoolean(value);
            }
            get
            {
                return accounttype;
            }
        }
        public float Balance
        {
            set
            {
                balance = Convert.ToSingle(value);
            }
            get
            {
                return balance;
            }
        }
        public int Grade
        {
            set
            {
                grade = Convert.ToInt16(value);
            }
            get
            {
                return grade;
            }
        }
        public string UserID
        {
            set
            {
                userid = value.ToString();
            }
            get
            {
                return userid;
            }
        }
        public float Flow
        {
            set
            {
                flow = Convert.ToSingle(value);
            }
            get
            {
                return flow;
            }
        }
        public Account()
        {
            accountid = null;
            accountname = null;
            accountbank = 0;
            AccountType = false;
            balance = 0;
            grade = -1;
            userid = null;
            flow = 0;
        }

        public Account(string id)
        {
            accountid = id;
            accountname = null;
            accountbank = 0;
            AccountType = false;
            balance = 0;
            grade = -1;
            userid = null;
            flow = 0;
        }

        public Account(string id, string name, int bank, bool type, float bal, int g, string uid, float fl)
        {
            accountid = id;
            accountname = name;
            accountbank = bank;
            accounttype = type;
            balance = bal;
            grade = g;
            userid = uid;
            flow = fl;
        }
    }
}
