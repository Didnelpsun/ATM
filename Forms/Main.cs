using System;
using System.Windows.Forms;
using ATM.Object;

namespace ATM.Forms
{
    public partial class Main : Form
    {
        private readonly User user = new User();
        public Main()
        {
            InitializeComponent();
        }
        private void TextBoxUser_TextChanged(object sender, EventArgs e)
        {
            user.UserName = textBoxUser.Text.ToString().Trim();
        }
        private void TextBoxPsw_TextChanged(object sender, EventArgs e)
        {
            user.Password = textBoxPsw.Text.ToString().Trim();
        }
        private void Login_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("户名{0}是在...", user.UserName);
            if(textBoxUser.Text == "")
            {
                MessageBox.Show("请输入用户名");
            }
            else
            {
                DAO.Login(user);
                switch (user.UserId)
                {
                    case "1":
                        MessageBox.Show("不存在该用户，请重新输入！");
                        break;
                    case "2":
                        MessageBox.Show("密码输入有误，请重新输入！");
                        break;
                    case "3":
                        MessageBox.Show("程序异常，请联系管理员");
                        break;
                    default:
                        MainFunction mainFunction = new MainFunction(user);
                        mainFunction.Show();
                        this.Close();
                        MessageBox.Show("欢迎" + user.UserName + "登入", "自助存取款系统");
                        break;
                }
            }
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ForgetPsw_Click(object sender, EventArgs e)
        {
            this.Close();
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
        }

        private void Logon_Click(object sender, EventArgs e)
        {
            this.Close();
            AddUser addUser = new AddUser();
            addUser.Show();
        }
    }
}
