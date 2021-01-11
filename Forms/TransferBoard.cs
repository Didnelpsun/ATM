using ATM.Object;
using System;
using System.Windows.Forms;

namespace ATM.Forms
{
    public partial class TransferBoard : Form
    {
        private Account account;
        private Account tarAccount = new Account();
        private Authority authority;
        public TransferBoard(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void TransferBoard_Load(object sender, EventArgs e)
        {
            id.Text = account.AccountID.Trim();
            name.Text = account.AccountName.Trim();
            if (Convert.ToSingle(account.Balance) < 0)
            {
                this.balance.ForeColor = System.Drawing.Color.Red;
            }
            balance.Text = account.Balance.ToString();
            authority = DAO.AccessAuthority(account.Grade);
            loan.Text = authority.Loan.ToString();
            loan.Text = account.Flow.ToString();
            tarAccountID.Text = "";
            User user = new User(account.UserID);
            accountList.DataSource = DAO.GetAccountList(user, account);
            accountList.ValueMember = "AccountID";
            accountList.DisplayMember = "AccountName";
            accountList.SelectedIndex = -1;
        }

        private void GroupBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            AccountBoard accountBoard = new AccountBoard(account);
            accountBoard.Show();
        }

        private void Determine_Click(object sender, EventArgs e)
        {
            float amount = keyBoard.GetAmount();
            //Console.WriteLine(amount);
            if (account.Balance < 0)
            {
                MessageBox.Show("您已负债，不能转账！");
                return;
            }
            if (amount == 0)
            {
                MessageBox.Show("请输入不为0的数字！");
                return;
            }
            if (inUser.Checked || allUser.Checked)
            {
                if (inUser.Checked)
                {
                    if (accountList.SelectedIndex == -1)
                    {
                        MessageBox.Show("请选择！");
                        return;
                    }
                    else
                    {
                        tarAccount.AccountID = accountList.SelectedValue.ToString().Trim();
                    }
                }
                else
                {
                    if (account.AccountID == tarAccountID.Text.ToString().Trim())
                    {
                        MessageBox.Show("账户ID不能相同");
                        return;
                    }
                    else
                    {
                        if (DAO.GetAccount(new Account(tarAccountID.Text.ToString().Trim())).AccountName == null)
                        {
                            MessageBox.Show(String.Format("找不到这个账户ID（{0}）！", tarAccountID.Text.ToString().Trim()));
                            return;
                        }
                        else
                        {
                            tarAccount.AccountID = tarAccountID.Text.ToString().Trim();
                        }
                    }
                }
                DAO.GetAccount(tarAccount);
                int result = DAO.Transfer(account, tarAccount, amount);
                switch (result)
                {
                    case -1:
                        MessageBox.Show(String.Format("转账失败！{0}->{1}", account.AccountID, tarAccount.AccountID));
                        break;
                    case 0:
                        MessageBox.Show(String.Format("转账{0}成功！{1}->{2}", amount, account.AccountID, tarAccount.AccountID));
                        this.Close();
                        DAO.GetAccount(account);
                        AccountBoard accountBoard = new AccountBoard(account);
                        accountBoard.Show();
                        break;
                    case 1:
                        MessageBox.Show(String.Format("转账数额{0}超过取款限制{1}元！", amount, DAO.AccessAuthority(account.Grade).Draw));
                        break;
                    case 2:
                        MessageBox.Show(String.Format("转账数额{0}后源账户余额小于0！", amount));
                        break;
                }
            }
            else
            {
                MessageBox.Show("请选择转账方式！");
            }
        }

        private void InUser_CheckedChanged(object sender, EventArgs e)
        {
            accountList.Enabled = true;
            tarAccountID.Enabled = false;
            accountList.SelectedIndex = -1;
            tarAccountID.Text = "";
        }

        private void AllUser_CheckedChanged(object sender, EventArgs e)
        {
            accountList.Enabled = false;
            tarAccountID.Enabled = true;
            accountList.SelectedIndex = -1;
        }
    }
}
