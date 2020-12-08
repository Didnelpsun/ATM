
namespace ATM.Forms
{
    partial class AccountBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountBoard));
            this.accountIDLabel = new System.Windows.Forms.Label();
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.accountID = new System.Windows.Forms.Label();
            this.accountName = new System.Windows.Forms.Label();
            this.accountBankLabel = new System.Windows.Forms.Label();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.accountBank = new System.Windows.Forms.Label();
            this.accountType = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.flow = new System.Windows.Forms.Label();
            this.flowLabel = new System.Windows.Forms.Label();
            this.deposit = new System.Windows.Forms.Button();
            this.withdraw = new System.Windows.Forms.Button();
            this.transfer = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountIDLabel
            // 
            this.accountIDLabel.AutoSize = true;
            this.accountIDLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.accountIDLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountIDLabel.ForeColor = System.Drawing.Color.Black;
            this.accountIDLabel.Location = new System.Drawing.Point(67, 46);
            this.accountIDLabel.Name = "accountIDLabel";
            this.accountIDLabel.Size = new System.Drawing.Size(72, 16);
            this.accountIDLabel.TabIndex = 0;
            this.accountIDLabel.Text = "账户ID：";
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.AutoSize = true;
            this.accountNameLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.accountNameLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountNameLabel.ForeColor = System.Drawing.Color.Black;
            this.accountNameLabel.Location = new System.Drawing.Point(326, 46);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(72, 16);
            this.accountNameLabel.TabIndex = 1;
            this.accountNameLabel.Text = "账户名：";
            // 
            // accountID
            // 
            this.accountID.AutoSize = true;
            this.accountID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.accountID.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountID.ForeColor = System.Drawing.Color.Black;
            this.accountID.Location = new System.Drawing.Point(168, 46);
            this.accountID.Name = "accountID";
            this.accountID.Size = new System.Drawing.Size(88, 16);
            this.accountID.TabIndex = 2;
            this.accountID.Text = "0000000000";
            // 
            // accountName
            // 
            this.accountName.AutoSize = true;
            this.accountName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.accountName.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountName.ForeColor = System.Drawing.Color.Black;
            this.accountName.Location = new System.Drawing.Point(404, 46);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(48, 16);
            this.accountName.TabIndex = 3;
            this.accountName.Text = "admin";
            // 
            // accountBankLabel
            // 
            this.accountBankLabel.AutoSize = true;
            this.accountBankLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.accountBankLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountBankLabel.ForeColor = System.Drawing.Color.Black;
            this.accountBankLabel.Location = new System.Drawing.Point(67, 109);
            this.accountBankLabel.Name = "accountBankLabel";
            this.accountBankLabel.Size = new System.Drawing.Size(88, 16);
            this.accountBankLabel.TabIndex = 4;
            this.accountBankLabel.Text = "账户银行：";
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.accountTypeLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.accountTypeLabel.Location = new System.Drawing.Point(60, 176);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(120, 16);
            this.accountTypeLabel.TabIndex = 5;
            this.accountTypeLabel.Text = "是否为信用卡：";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.balanceLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.balanceLabel.ForeColor = System.Drawing.Color.Black;
            this.balanceLabel.Location = new System.Drawing.Point(216, 176);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(56, 16);
            this.balanceLabel.TabIndex = 6;
            this.balanceLabel.Text = "余额：";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gradeLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gradeLabel.ForeColor = System.Drawing.Color.Black;
            this.gradeLabel.Location = new System.Drawing.Point(316, 109);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(80, 16);
            this.gradeLabel.TabIndex = 7;
            this.gradeLabel.Text = "账户等级:";
            // 
            // accountBank
            // 
            this.accountBank.AutoSize = true;
            this.accountBank.BackColor = System.Drawing.Color.WhiteSmoke;
            this.accountBank.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountBank.ForeColor = System.Drawing.Color.Black;
            this.accountBank.Location = new System.Drawing.Point(168, 109);
            this.accountBank.Name = "accountBank";
            this.accountBank.Size = new System.Drawing.Size(104, 16);
            this.accountBank.TabIndex = 8;
            this.accountBank.Text = "中国建设银行";
            // 
            // accountType
            // 
            this.accountType.AutoSize = true;
            this.accountType.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountType.ForeColor = System.Drawing.Color.Black;
            this.accountType.Location = new System.Drawing.Point(168, 176);
            this.accountType.Name = "accountType";
            this.accountType.Size = new System.Drawing.Size(24, 16);
            this.accountType.TabIndex = 9;
            this.accountType.Text = "是";
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.balance.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.balance.ForeColor = System.Drawing.Color.Green;
            this.balance.Location = new System.Drawing.Point(265, 176);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(40, 16);
            this.balance.TabIndex = 10;
            this.balance.Text = "4700";
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grade.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grade.ForeColor = System.Drawing.Color.Black;
            this.grade.Location = new System.Drawing.Point(404, 109);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(72, 16);
            this.grade.TabIndex = 11;
            this.grade.Text = "钻石账户";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel.Controls.Add(this.flow);
            this.panel.Controls.Add(this.flowLabel);
            this.panel.Controls.Add(this.accountType);
            this.panel.Controls.Add(this.grade);
            this.panel.Controls.Add(this.accountBankLabel);
            this.panel.Controls.Add(this.accountBank);
            this.panel.Controls.Add(this.accountName);
            this.panel.Controls.Add(this.gradeLabel);
            this.panel.Controls.Add(this.balance);
            this.panel.Controls.Add(this.accountID);
            this.panel.Controls.Add(this.accountTypeLabel);
            this.panel.Controls.Add(this.accountIDLabel);
            this.panel.Controls.Add(this.accountNameLabel);
            this.panel.Controls.Add(this.balanceLabel);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(561, 237);
            this.panel.TabIndex = 12;
            // 
            // flow
            // 
            this.flow.AutoSize = true;
            this.flow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flow.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flow.ForeColor = System.Drawing.Color.Black;
            this.flow.Location = new System.Drawing.Point(440, 176);
            this.flow.Name = "flow";
            this.flow.Size = new System.Drawing.Size(48, 16);
            this.flow.TabIndex = 17;
            this.flow.Text = "35564";
            // 
            // flowLabel
            // 
            this.flowLabel.AutoSize = true;
            this.flowLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flowLabel.ForeColor = System.Drawing.Color.Black;
            this.flowLabel.Location = new System.Drawing.Point(354, 176);
            this.flowLabel.Name = "flowLabel";
            this.flowLabel.Size = new System.Drawing.Size(80, 16);
            this.flowLabel.TabIndex = 12;
            this.flowLabel.Text = "账目流水:";
            // 
            // deposit
            // 
            this.deposit.BackColor = System.Drawing.Color.White;
            this.deposit.FlatAppearance.BorderSize = 0;
            this.deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deposit.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deposit.Location = new System.Drawing.Point(38, 266);
            this.deposit.Margin = new System.Windows.Forms.Padding(0);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(75, 23);
            this.deposit.TabIndex = 13;
            this.deposit.Text = "存入";
            this.deposit.UseVisualStyleBackColor = false;
            this.deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // withdraw
            // 
            this.withdraw.BackColor = System.Drawing.Color.White;
            this.withdraw.FlatAppearance.BorderSize = 0;
            this.withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdraw.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.withdraw.Location = new System.Drawing.Point(145, 266);
            this.withdraw.Margin = new System.Windows.Forms.Padding(0);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(75, 23);
            this.withdraw.TabIndex = 14;
            this.withdraw.Text = "取出";
            this.withdraw.UseVisualStyleBackColor = false;
            this.withdraw.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // transfer
            // 
            this.transfer.BackColor = System.Drawing.Color.White;
            this.transfer.FlatAppearance.BorderSize = 0;
            this.transfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transfer.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.transfer.Location = new System.Drawing.Point(256, 266);
            this.transfer.Margin = new System.Windows.Forms.Padding(0);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(75, 23);
            this.transfer.TabIndex = 15;
            this.transfer.Text = "转账";
            this.transfer.UseVisualStyleBackColor = false;
            this.transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Crimson;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(472, 266);
            this.exit.Margin = new System.Windows.Forms.Padding(0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 16;
            this.exit.Text = "退出账户";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.LightCoral;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(369, 266);
            this.delete.Margin = new System.Windows.Forms.Padding(0);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 17;
            this.delete.Text = "删除账户";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AccountBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(585, 310);
            this.ControlBox = false;
            this.Controls.Add(this.delete);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.transfer);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.panel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountBoard";
            this.Load += new System.EventHandler(this.AccountBoard_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label accountIDLabel;
        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.Label accountID;
        private System.Windows.Forms.Label accountName;
        private System.Windows.Forms.Label accountBankLabel;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label accountBank;
        private System.Windows.Forms.Label accountType;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label grade;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Button transfer;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label flow;
        private System.Windows.Forms.Label flowLabel;
        private System.Windows.Forms.Button delete;
    }
}