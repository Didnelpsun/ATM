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
            Visible = false;
            MainFunction mainFunction = new MainFunction(user);
            mainFunction.Show();
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            Visible = false;
            AccessBoard accessBoard = new AccessBoard(account, true);
            accessBoard.Show();
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {

            Visible = false;
            AccessBoard accessBoard = new AccessBoard(account, false);
            accessBoard.Show();
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            Visible = false;
            TransferBoard transferBoard = new TransferBoard(account);
            transferBoard.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
