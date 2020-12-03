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
        private int minLength = 2;
        public AddAcount(User user)
        {
            InitializeComponent();
            this.user = user;
            account.UserID = user.UserId;
            account.Balance = 0;
        }

        private void AddAcount_Load(object sender, EventArgs e)
        {
            account.AccountID = Utils.GetID();
            accountID.Text = account.AccountID;
            idLabel.Text = "";
            nameLabel.Text = "";
            bankLabel.Text = "";
            accountBank.DataSource = DAO.GetBankList();
            accountBank.ValueMember = "ID";
            accountBank.DisplayMember = "Name";
            accountBank.SelectedIndex = -1;
            creditLabel.Text = "";
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
            if (accountID.Text.Trim() == "")
            {
                idLabel.Text = "程序异常！";
            }
            else
            {
                idLabel.Text = "";
                if (accountName.Text == "")
                {
                    nameLabel.Text = "请输入！";
                }
                else if(accountName.Text.Length < minLength)
                {
                    nameLabel.Text = "账户名过短！";
                }
                else
                {
                    nameLabel.Text = "";
                    account.AccountName = accountName.Text;
                    if (accountBank.SelectedIndex == -1)
                    {
                        bankLabel.Text = "请选择！";
                    }
                    else
                    {
                        bankLabel.Text = "";
                        account.AccountBank = Convert.ToInt16(accountBank.SelectedValue);
                        if (yes.Checked||no.Checked)
                        {
                            creditLabel.Text = "";
                            if (yes.Checked)
                            {
                                account.AccountType = true;
                                account.Grade = 1;
                            }
                            else
                            {
                                account.AccountType = false;
                                account.Grade = 0;
                            }
                            SqlConnection conn = DAO.Connection();
                            string addAccount = "INSERT INTO Account VALUES ('{0}', N'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')";
                            addAccount = string.Format(addAccount, account.AccountID, account.AccountName, account.AccountBank, account.AccountType, account.Balance, account.Grade, account.UserID, account.Flow);
                            Console.WriteLine(addAccount);
                            try
                            {
                                conn.Open();
                                SqlCommand command = conn.CreateCommand();
                                command.CommandText = addAccount;
                                int rows = command.ExecuteNonQuery();
                                if(rows == 1)
                                {
                                    MessageBox.Show("添加账户成功！");
                                    Visible = false;
                                    MainFunction mainFunction = new MainFunction(user);
                                    mainFunction.Show();
                                }
                                else
                                {
                                    Console.WriteLine("影响行数为{0}", rows);
                                    MessageBox.Show("添加账户失败！");
                                }
                            }
                            catch (Exception exception)
                            {
                                Debug.WriteLine(exception.Message.ToString());
                                MessageBox.Show("程序出现错误！");
                            }
                        }
                        else
                        {
                            creditLabel.Text = "请选择！";
                        }
                    }
                }
            }
        }
    }
}
