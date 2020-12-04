using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using ATM.Object;

namespace ATM.Forms
{
    public partial class ChangePassword : Form
    {
        private User user;
        public ChangePassword(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void ResetLabel()
        {
            oldLabel.Text = "";
            newLabel.Text = "";
            confirmLabel.Text = "";
        }

        private void ChangePassword_Load(object sender, EventArgs e)
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
            string OldPsw = oldPsw.Text.ToString().Trim();
            string NewPsw = newPsw.Text.ToString().Trim();
            string ConfirmPsw = confirmPsw.Text.ToString().Trim();
            //Console.WriteLine(UserID);
            //Console.WriteLine(UserName);
            //Console.WriteLine(NewPsw);
            //Console.WriteLine(ConfirmPsw);
            //Console.WriteLine(checkName);
            ResetLabel();
            int result = DAO.ChangePassword(OldPsw, NewPsw, ConfirmPsw, user);
            switch (result)
            {
                case -1:
                    MessageBox.Show("密码更新失败！");
                    break;
                case 0:
                    MessageBox.Show("密码更新成功！");
                    Visible = false;
                    MainFunction mainFunction = new MainFunction(user);
                    mainFunction.Show();
                    break;
                case 1:
                    oldLabel.Text = "旧密码不应为空！";
                    break;
                case 2:
                    oldLabel.Text = "旧密码错误！";
                    break;
                case 3:
                    newLabel.Text = "密码过短！";
                    break;
                case 4:
                    newLabel.Text = "密码存在非法值";
                    break;
                case 5:
                    confirmLabel.Text = "密码不一致！";
                    break;
            }
        }
    }
}
