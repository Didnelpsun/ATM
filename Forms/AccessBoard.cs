using ATM.Object;
using System;
using System.Windows.Forms;

namespace ATM.Forms
{
    public partial class AccessBoard : Form
    {
        private Account account;
        private bool status;
        private Authority authority;
        public AccessBoard(Account account, bool status)
        {
            InitializeComponent();
            this.account = account;
            this.status = status;
            this.authority = new Authority();
        }

        private void AccessBoard_Load(object sender, EventArgs e)
        {
            if (status)
            {
                title.Text = "存款";
            }
            else
            {
                title.Text = "取款";
            }
            id.Text = account.AccountID.Trim();
            name.Text = account.AccountName.Trim();
            bank.Text = DAO.GetBankName(account.AccountBank).Trim();
            if (account.AccountType)
            {
                type.Text = "是";
            }
            else
            {
                type.Text = "否";
            }
            if (Convert.ToSingle(account.Balance) < 0)
            {
                this.balance.ForeColor = System.Drawing.Color.Red;
            }
            balance.Text = account.Balance.ToString();
            authority = DAO.AccessAuthority(account.Grade);
            loan.Text = authority.Loan.ToString();
            grade.Text = DAO.GetGradeName(account.Grade).Trim();
            flow.Text = account.Flow.ToString();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Visible = false;
            AccountBoard accountBoard = new AccountBoard(account);
            accountBoard.Show();
        }

        private void Determine_Click(object sender, EventArgs e)
        {
            float amount = keyBoard.GetAmount();
            //Console.WriteLine(amount);
            if (amount == 0)
            {
                MessageBox.Show("请输入不为0的数字");
                return;
            }
            int result = DAO.Access(account, status, amount);
            switch (result)
            {
                case -1:
                    MessageBox.Show("账户金额变动失败");
                    break;
                case 0:
                    Visible = false;
                    DAO.GetAccount(account);
                    AccountBoard accountBoard = new AccountBoard(account);
                    accountBoard.Show();
                    break;
                case 1:
                    MessageBox.Show(String.Format("存款金额{0}超过权限（{1}元）", amount.ToString(), authority.Draw.ToString()));
                    break;
                case 2:
                    MessageBox.Show(String.Format("取款金额{0}后超过信用额（{1}元）", amount.ToString(), authority.Loan.ToString()));
                    break;
            }
        }
    }
}
