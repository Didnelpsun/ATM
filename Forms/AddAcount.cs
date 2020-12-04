using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using ATM.Object;

namespace ATM.Forms
{
    public partial class AddAcount : Form
    {
        private User user;
        private Account account = new Account();
        public AddAcount(User user)
        {
            InitializeComponent();
            this.user = user;
            account.UserID = user.UserId;
        }

        private void ResetLabel()
        {

            idLabel.Text = "";
            nameLabel.Text = "";
            bankLabel.Text = "";
            creditLabel.Text = "";
        }

        private void AddAcount_Load(object sender, EventArgs e)
        {
            ResetLabel();
            account.AccountID = Utils.GetID();
            accountID.Text = account.AccountID;
            accountBank.DataSource = DAO.GetBankList();
            accountBank.ValueMember = "ID";
            accountBank.DisplayMember = "Name";
            accountBank.SelectedIndex = -1;
        }

        private void GroupBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Visible = false;
            MainFunction mainFunction = new MainFunction(user);
            mainFunction.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            ResetLabel();
            account.AccountName = accountName.Text.ToString().Trim();
            if(accountBank.SelectedIndex == -1)
            {
                account.AccountBank = -1;
            }
            else
            {
                account.AccountBank = Convert.ToInt16(accountBank.SelectedValue);
            }
            if (yes.Checked)
            {
                account.AccountType = true;
                account.Grade = 1;
            }
            else if(no.Checked)
            {
                account.AccountType = false;
                account.Grade = 0;
            }
            int result = DAO.AddAcount(account);
            switch (result)
            {
                case -1:
                    MessageBox.Show("添加账户失败！");
                    break;
                case 0:
                    MessageBox.Show("添加账户成功！");
                    Visible = false;
                    MainFunction mainFunction = new MainFunction(user);
                    mainFunction.Show();
                    break;
                case 1:
                    idLabel.Text = "程序异常！";
                    break;
                case 2:
                    nameLabel.Text = "请输入！";
                    break;
                case 3:
                    nameLabel.Text = "账户名过短！";
                    break;
                case 4:
                    bankLabel.Text = "请选择！";
                    break;
                case 5:
                    creditLabel.Text = "请选择！";
                    break;
            }
        }
    }
}
