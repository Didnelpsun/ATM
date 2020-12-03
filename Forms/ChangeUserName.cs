using ATM.Object;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace ATM.Forms
{
    public partial class ChangeUserName : Form
    {
        private User user;
        public ChangeUserName(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void ResetLabel()
        {
            oldLabel.Text = "";
            newLabel.Text = "";
        }

        private void ChangeUserName_Load(object sender, EventArgs e)
        {
            ResetLabel();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Visible = false;
            MainFunction mainFunction = new MainFunction(user);
            mainFunction.Show();
        }

        private void Change_Click(object sender, EventArgs e)
        {

            string OldUserName = oldUserName.Text.ToString().Trim();
            string NewUserName = newUserName.Text.ToString().Trim();
            //Console.WriteLine(UserID);
            //Console.WriteLine(UserName);
            //Console.WriteLine(NewPsw);
            //Console.WriteLine(ConfirmPsw);
            //Console.WriteLine(checkName);
            ResetLabel();
            int result = DAO.ChangeUserName(OldUserName, NewUserName, user);
            switch (result)
            {
                case -1:
                    MessageBox.Show("用户名更新失败！");
                    break;
                case 0:
                    MessageBox.Show("用户名更新成功！");
                    Visible = false;
                    MainFunction mainFunction = new MainFunction(user);
                    mainFunction.Show();
                    break;
                case 1:
                    oldLabel.Text = "旧用户名不应为空！";
                    break;
                case 2:
                    oldLabel.Text = "旧用户名错误！";
                    break;
                case 3:
                    newLabel.Text = "新用户名过短！";
                    break;
                case 4:
                    newLabel.Text = "新名不应与旧名一致！";
                    break;
                case 5:
                    newLabel.Text = "新名旧名重名！";
                    break;
                case 6:
                    newLabel.Text = "数据库中有重名数据！";
                    break;
                case 7:
                    newLabel.Text = "检查重名出错！";
                    break;
            }
        }
    }
}
