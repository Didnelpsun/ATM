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
        private int minLength = 2;
        public ChangeUserName(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void ChangeUserName_Load(object sender, EventArgs e)
        {
            oldLabel.Text = "";
            newLabel.Text = "";
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
            if (OldUserName == "")
            {
                oldLabel.Text = "旧用户名不应为空！";
            }
            else
            {
                oldLabel.Text = "";
                if (OldUserName != user.UserName)
                {
                    oldLabel.Text = "旧用户名错误！";
                }
                else
                {
                    oldLabel.Text = "";
                    if (NewUserName.Length < minLength)
                    {
                        newLabel.Text = "新用户名过短！";
                    }
                    else
                    {
                        if(OldUserName == NewUserName)
                        {
                            newLabel.Text = "新名不应与旧名一致！";
                        }
                        else
                        {
                            newLabel.Text = "";
                            int status = DAO.CheckRepeatUserName(user.UserId,NewUserName);
                            if (status == 0)
                            {
                                newLabel.Text = "";
                                SqlConnection conn = DAO.Connection();
                                string updateUserName = "UPDATE [User] SET UserName=N'" + NewUserName + "' WHERE UserID = '" + user.UserId + "'";
                                //Console.WriteLine(updateUserName);
                                try
                                {
                                    conn.Open();
                                    SqlCommand command = conn.CreateCommand();
                                    command.CommandText = updateUserName;
                                    int rows = command.ExecuteNonQuery();
                                    conn.Close();
                                    if (rows > 0)
                                    {
                                        MessageBox.Show("用户名更新成功！");
                                        Visible = false;
                                        MainFunction mainFunction = new MainFunction(user);
                                        mainFunction.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("用户名更新失败！");
                                    }
                                }
                                catch (Exception exception)
                                {
                                    Debug.WriteLine(exception.Message.ToString());
                                    MessageBox.Show("程序出现错误！");
                                }
                            }
                            else if (status == 2)
                            {
                                newLabel.Text = "新名重名！";
                            }
                            else if (status == 3)
                            {
                                newLabel.Text = "数据库中有重名数据！";
                            }
                            else
                            {
                                newLabel.Text = "检查重名出错！";
                            }
                        }
                    }
                }
            }
        }
    }
}
