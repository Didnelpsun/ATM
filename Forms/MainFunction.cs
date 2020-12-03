using System;
using System.Windows.Forms;
using ATM.Object;

namespace ATM.Forms
{
    public partial class MainFunction : Form
    {
        private readonly User user;
        public MainFunction(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void MainFunction_Load(object sender, EventArgs e)
        {
            // 取消每行首格
            this.accountView.RowHeadersVisible = false;
            // 只读
            this.accountView.ReadOnly = true;
            // 去除多余的一行
            this.accountView.AllowUserToAddRows = false;
            // 禁止多选
            this.accountView.MultiSelect = false;
            // 选择时选取一行
            this.accountView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.accountView.DataSource = DAO.GetAccount(this.user).Tables["Account"];
            this.accountView.Columns[0].HeaderText = "账户ID";
            this.accountView.Columns[1].HeaderText = "账户名";
            this.accountView.Columns[2].HeaderText = "银行类型";
            this.accountView.Columns[3].HeaderText = "是否为信用卡";
            this.accountView.Columns[4].HeaderText = "账户余额";
            this.accountView.Columns[5].HeaderText = "账户等级";
            this.accountView.Columns[6].HeaderText = "账户流水";
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Visible = false;
            Main main = new Main();
            main.Show();
        }

        private void AccountView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.accountView.Rows[this.accountView.CurrentRow.Index];
            Account account = new Account(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), Convert.ToInt16(row.Cells[2].Value), Convert.ToBoolean(row.Cells[3].Value), Convert.ToSingle(row.Cells[4].Value), Convert.ToInt16(row.Cells[5].Value), user.UserId.ToString(), Convert.ToSingle(row.Cells[6].Value));
            Visible = false;
            AccountBoard accountBoard = new AccountBoard(account);
            accountBoard.Show();
        }

        private void ChangePass_Click(object sender, EventArgs e)
        {
            Visible = false;
            ChangePassword changePassword = new ChangePassword(user);
            changePassword.Show();
        }

        private void ChangeUserName_Click(object sender, EventArgs e)
        {
            Visible = false;
            ChangeUserName changeUserName = new ChangeUserName(user);
            changeUserName.Show();
        }

        private void AddAccount_Click(object sender, EventArgs e)
        {
            Visible = false;
            AddAcount addAccount = new AddAcount(user);
            addAccount.Show();
        }
    }
}
