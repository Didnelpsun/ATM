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
        private int minLength = 3;
        public ChangePassword(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            this.oldLabel.Text = "";
            this.newLabel.Text = "";
            this.confirmLabel.Text = "";
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
            if (OldPsw.Trim() == "")
            {
                oldLabel.Text = "旧密码不应为空！";
            }
            else
            {
                oldLabel.Text = "";
                if (OldPsw != user.Password)
                {
                    oldLabel.Text = "旧密码错误！";
                }
                else
                {
                    oldLabel.Text = "";
                    if (NewPsw.Length < minLength)
                    {
                        newLabel.Text = "密码过短！";
                    }
                    else if (!Utils.CheckValidChar(NewPsw))
                    {
                        newLabel.Text = "密码存在非法值";
                    }
                    else
                    {
                        newLabel.Text = "";
                        if (Convert.ToBoolean(ConfirmPsw.CompareTo(NewPsw)))
                        {
                            confirmLabel.Text = "密码不一致！";
                        }
                        else
                        {
                            confirmLabel.Text = "";
                            SqlConnection conn = DAO.Connection();
                            string updatePsw = "UPDATE [User] SET Password='" + NewPsw + "' WHERE UserID = '" + user.UserId + "'";
                            //Console.WriteLine(updatePsw);
                            try
                            {
                                conn.Open();
                                SqlCommand command = conn.CreateCommand();
                                command.CommandText = updatePsw;
                                int rows = command.ExecuteNonQuery();
                                conn.Close();
                                if (rows > 0)
                                {
                                    MessageBox.Show("密码更新成功！");
                                    Visible = false;
                                    MainFunction mainFunction = new MainFunction(user);
                                    mainFunction.Show();
                                }
                                else
                                {
                                    MessageBox.Show("密码更新失败！");
                                }
                            }
                            catch (Exception exception)
                            {
                                Debug.WriteLine(exception.Message.ToString());
                                MessageBox.Show("程序出现错误！");
                            }
                        }
                    }
                }
            }
        }
    }
}
