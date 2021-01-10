using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using ATM.Object;

namespace ATM.Forms
{
    public partial class AddUser : Form
    {
        private User user = new User();

        public AddUser()
        {
            InitializeComponent();
        }

        private void ResetLabel()
        {
            idLabel.Text = "";
            nameLabel.Text = "";
            passLabel.Text = "";
            confirmLabel.Text = "";
        }

        private void AddAcount_Load(object sender, EventArgs e)
        {
            ResetLabel();
            user.UserId = Utils.GetID();
            userID.Text = user.UserId;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Visible = false;
            Main main = new Main();
            main.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            ResetLabel();
            if (userName.Text.ToString().Trim().Length == 0)
            {
                nameLabel.Text = "用户名不应为空！";
                return;
            }
            user.UserName = userName.Text.ToString().Trim();
            if (passWord.Text.ToString().Trim().Length == 0)
            {
                passLabel.Text = "密码不应为空！";
                return;
            }
            user.Password = passWord.Text.ToString().Trim();
            if (user.Password != confirmWord.Text.ToString().Trim())
            {
                confirmLabel.Text = "密码不一致！";
                return;
            }
            int result = DAO.AddUser(user);
            switch (result)
            {
                case -1:
                    MessageBox.Show("添加用户失败！");
                    break;
                case 0:
                    MessageBox.Show("添加用户成功！");
                    Visible = false;
                    Main main = new Main();
                    main.Show();
                    break;
                case 1:
                    MessageBox.Show("程序异常！");
                    break;
                case 2:
                    MessageBox.Show("用户名重复！");
                    break;
            }
        }
    }
}
