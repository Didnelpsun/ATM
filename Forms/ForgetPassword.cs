using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.Forms
{
    public partial class ForgetPassword : Form
    {
        private int minLength = 3;
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            IDLabel.Text = "";
            nameLabel.Text = "";
            newLabel.Text = "";
            confirmLabel.Text = "";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Visible = false;
            Main main = new Main();
            main.Show();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            string UserID = userID.Text.ToString().Trim();
            string UserName = userName.Text.ToString().Trim();
            string NewPsw = newPsw.Text.ToString().Trim();
            string ConfirmPsw = confirmPsw.Text.ToString().Trim();
            string checkName = DAO.CheckUser(UserID).Trim();
            //Console.WriteLine(UserID);
            //Console.WriteLine(UserName);
            //Console.WriteLine(NewPsw);
            //Console.WriteLine(ConfirmPsw);
            //Console.WriteLine(checkName);
            if (UserID.Trim() == "")
            {
                IDLabel.Text = "ID不应为空！";
            }
            else
            {
                IDLabel.Text = "";
                if (checkName == null)
                {
                    IDLabel.Text = "ID不存在！";
                }
                else
                {
                    IDLabel.Text = "";
                    if (Convert.ToBoolean(UserName.CompareTo(checkName)))
                    {
                        nameLabel.Text = "ID与用户名不匹配！";
                    }
                    else
                    {
                        nameLabel.Text = "";
                        if(NewPsw.Length < minLength)
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
                            if (Convert.ToBoolean(ConfirmPsw.CompareTo(NewPsw))){
                                confirmLabel.Text = "密码不一致！";
                            }
                            else
                            {
                                confirmLabel.Text = "";
                                SqlConnection conn = DAO.Connection();
                                string updatePsw = "UPDATE [User] SET Password='" + NewPsw + "' WHERE UserID = '" + UserID + "'";
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
                                        Main main = new Main();
                                        main.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("密码更新失败！");
                                    }
                                }
                                catch(Exception exception)
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
}
