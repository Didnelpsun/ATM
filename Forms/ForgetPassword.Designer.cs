
namespace ATM.Forms
{
    partial class ForgetPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
            this.userIDLabel = new System.Windows.Forms.Label();
            this.userID = new System.Windows.Forms.TextBox();
            this.newPsw = new System.Windows.Forms.TextBox();
            this.newPswLabel = new System.Windows.Forms.Label();
            this.confirmPswLabel = new System.Windows.Forms.Label();
            this.confirmPsw = new System.Windows.Forms.TextBox();
            this.change = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.newLabel = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userIDLabel
            // 
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userIDLabel.ForeColor = System.Drawing.Color.White;
            this.userIDLabel.Location = new System.Drawing.Point(127, 38);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(72, 16);
            this.userIDLabel.TabIndex = 0;
            this.userIDLabel.Text = "用户ID：";
            // 
            // userID
            // 
            this.userID.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userID.Location = new System.Drawing.Point(198, 35);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(219, 26);
            this.userID.TabIndex = 1;
            // 
            // newPsw
            // 
            this.newPsw.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newPsw.Location = new System.Drawing.Point(198, 158);
            this.newPsw.Name = "newPsw";
            this.newPsw.Size = new System.Drawing.Size(219, 26);
            this.newPsw.TabIndex = 2;
            // 
            // newPswLabel
            // 
            this.newPswLabel.AutoSize = true;
            this.newPswLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newPswLabel.ForeColor = System.Drawing.Color.White;
            this.newPswLabel.Location = new System.Drawing.Point(111, 161);
            this.newPswLabel.Name = "newPswLabel";
            this.newPswLabel.Size = new System.Drawing.Size(88, 16);
            this.newPswLabel.TabIndex = 3;
            this.newPswLabel.Text = "新的密码：";
            // 
            // confirmPswLabel
            // 
            this.confirmPswLabel.AutoSize = true;
            this.confirmPswLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmPswLabel.ForeColor = System.Drawing.Color.White;
            this.confirmPswLabel.Location = new System.Drawing.Point(111, 217);
            this.confirmPswLabel.Name = "confirmPswLabel";
            this.confirmPswLabel.Size = new System.Drawing.Size(88, 16);
            this.confirmPswLabel.TabIndex = 4;
            this.confirmPswLabel.Text = "确认密码：";
            // 
            // confirmPsw
            // 
            this.confirmPsw.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmPsw.Location = new System.Drawing.Point(198, 214);
            this.confirmPsw.Name = "confirmPsw";
            this.confirmPsw.Size = new System.Drawing.Size(219, 26);
            this.confirmPsw.TabIndex = 5;
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.Color.LimeGreen;
            this.change.FlatAppearance.BorderSize = 0;
            this.change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.change.ForeColor = System.Drawing.Color.White;
            this.change.Location = new System.Drawing.Point(176, 266);
            this.change.Margin = new System.Windows.Forms.Padding(0);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 23);
            this.change.TabIndex = 14;
            this.change.Text = "更改";
            this.change.UseVisualStyleBackColor = false;
            this.change.Click += new System.EventHandler(this.Change_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.White;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Location = new System.Drawing.Point(333, 266);
            this.cancel.Margin = new System.Windows.Forms.Padding(0);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmLabel.ForeColor = System.Drawing.Color.Crimson;
            this.confirmLabel.Location = new System.Drawing.Point(423, 217);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(104, 16);
            this.confirmLabel.TabIndex = 16;
            this.confirmLabel.Text = "密码不一致！";
            // 
            // newLabel
            // 
            this.newLabel.AutoSize = true;
            this.newLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newLabel.ForeColor = System.Drawing.Color.Crimson;
            this.newLabel.Location = new System.Drawing.Point(423, 161);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(88, 16);
            this.newLabel.TabIndex = 17;
            this.newLabel.Text = "密码过短！";
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userName.Location = new System.Drawing.Point(198, 97);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(219, 26);
            this.userName.TabIndex = 18;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(127, 100);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(72, 16);
            this.userNameLabel.TabIndex = 19;
            this.userNameLabel.Text = "用户名：";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDLabel.ForeColor = System.Drawing.Color.Crimson;
            this.IDLabel.Location = new System.Drawing.Point(423, 38);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(88, 16);
            this.IDLabel.TabIndex = 20;
            this.IDLabel.Text = "ID不存在！";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLabel.ForeColor = System.Drawing.Color.Crimson;
            this.nameLabel.Location = new System.Drawing.Point(423, 100);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(152, 16);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "ID与用户名不匹配！";
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(585, 310);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.newLabel);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.change);
            this.Controls.Add(this.confirmPsw);
            this.Controls.Add(this.confirmPswLabel);
            this.Controls.Add(this.newPswLabel);
            this.Controls.Add(this.newPsw);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.userIDLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPassword";
            this.Load += new System.EventHandler(this.ForgetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userIDLabel;
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.TextBox newPsw;
        private System.Windows.Forms.Label newPswLabel;
        private System.Windows.Forms.Label confirmPswLabel;
        private System.Windows.Forms.TextBox confirmPsw;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.Label newLabel;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}