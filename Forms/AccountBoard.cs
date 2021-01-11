using ATM.Object;
using System;
using System.Windows.Forms;

namespace ATM.Forms
{
    public partial class AccountBoard : Form
    {
        private Account account;

        public AccountBoard(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void AccountBoard_Load(object sender, EventArgs e)
        {
            accountID.Text = account.AccountID.Trim();
            accountName.Text = account.AccountName.Trim();
            accountBank.Text = DAO.GetBankName(account.AccountBank).Trim();
            if (account.AccountType)
            {
                accountType.Text = "是";
            }
            else
            {
                accountType.Text = "否";
            }
            if (Convert.ToSingle(account.Balance) < 0)
            {
                this.balance.ForeColor = System.Drawing.Color.Red;
            }
            balance.Text = account.Balance.ToString();
            grade.Text = DAO.GetGradeName(account.Grade).Trim();
            flow.Text = account.Flow.ToString();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            User user = new User(account.UserID);
            this.Close();
            MainFunction mainFunction = new MainFunction(user);
            mainFunction.Show();
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            this.Close();
            AccessBoard accessBoard = new AccessBoard(account, true);
            accessBoard.Show();
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            this.Close();
            AccessBoard accessBoard = new AccessBoard(account, false);
            accessBoard.Show();
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            this.Close();
            TransferBoard transferBoard = new TransferBoard(account);
            transferBoard.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if(account.Balance == 0)
            {
                if (DAO.DeleteAcount(account) == 0)
                {
                    this.Close();
                    User user = new User(account.UserID);
                    MainFunction mainFunction = new MainFunction(user);
                    mainFunction.Show();
                    MessageBox.Show(String.Format("删除{0}账户成功！", account.AccountName));
                }
                else
                {
                    MessageBox.Show(String.Format("删除{0}账户失败！", account.AccountName));
                }
            }
            else
            {
                MessageBox.Show(String.Format("您的账户上有{0}元，\n只有账户清零才可以删除账户！", account.Balance.ToString()));
            }
        }
    }
}
