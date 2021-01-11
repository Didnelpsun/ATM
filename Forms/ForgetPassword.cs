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
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void ResetLabel()
        {
            IDLabel.Text = "";
            nameLabel.Text = "";
            newLabel.Text = "";
            confirmLabel.Text = "";
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            ResetLabel();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            string UserID = userID.Text.ToString().Trim();
            string UserName = userName.Text.ToString().Trim();
            string NewPsw = newPsw.Text.ToString().Trim();
            string ConfirmPsw = confirmPsw.Text.ToString().Trim();
            string CheckName = DAO.CheckUser(UserID).ToString().Trim();
            //Console.WriteLine(UserID);
            //Console.WriteLine(UserName);
            //Console.WriteLine(NewPsw);
            //Console.WriteLine(ConfirmPsw);
            //Console.WriteLine(checkName);
            ResetLabel();
            int result = DAO.ForgetPassword(UserID, UserName, NewPsw, ConfirmPsw, CheckName);
            switch (result)
            {
                case -1:
                    MessageBox.Show("密码更新失败！");
                    break;
                case 0:
                    MessageBox.Show("密码更新成功！");
                    this.Close();
                    Main main = new Main();
                    main.Show();
                    break;
                case 1:
                    IDLabel.Text = "ID不应为空！";
                    break;
                case 2:
                    IDLabel.Text = "ID不存在！";
                    break;
                case 3:
                    nameLabel.Text = "ID与用户名不匹配！";
                    break;
                case 4:
                    newLabel.Text = "密码过短！";
                    break;
                case 5:
                    newLabel.Text = "密码存在非法值";
                    break;
                case 6:
                    confirmLabel.Text = "密码不一致！";
                    break;
            }
        }
    }
}
