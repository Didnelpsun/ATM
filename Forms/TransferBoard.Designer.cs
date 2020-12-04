
namespace ATM.Forms
{
    partial class TransferBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferBoard));
            this.keyBoard = new ATM.Control.KeyBoard();
            this.determine = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.loanLabel = new System.Windows.Forms.Label();
            this.loan = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.allUser = new System.Windows.Forms.RadioButton();
            this.inUser = new System.Windows.Forms.RadioButton();
            this.accountList = new System.Windows.Forms.ComboBox();
            this.tarAccountID = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // keyBoard
            // 
            this.keyBoard.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.keyBoard.Location = new System.Drawing.Point(418, 36);
            this.keyBoard.Name = "keyBoard";
            this.keyBoard.Size = new System.Drawing.Size(136, 229);
            this.keyBoard.TabIndex = 0;
            // 
            // determine
            // 
            this.determine.BackColor = System.Drawing.Color.LimeGreen;
            this.determine.FlatAppearance.BorderSize = 0;
            this.determine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.determine.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.determine.ForeColor = System.Drawing.Color.White;
            this.determine.Location = new System.Drawing.Point(99, 242);
            this.determine.Margin = new System.Windows.Forms.Padding(0);
            this.determine.Name = "determine";
            this.determine.Size = new System.Drawing.Size(75, 23);
            this.determine.TabIndex = 1;
            this.determine.Text = "确定";
            this.determine.UseVisualStyleBackColor = false;
            this.determine.Click += new System.EventHandler(this.Determine_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.White;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Location = new System.Drawing.Point(239, 242);
            this.cancel.Margin = new System.Windows.Forms.Padding(0);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.idLabel.ForeColor = System.Drawing.Color.White;
            this.idLabel.Location = new System.Drawing.Point(28, 36);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(72, 16);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "账户ID：";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.id.ForeColor = System.Drawing.Color.White;
            this.id.Location = new System.Drawing.Point(106, 36);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(88, 16);
            this.id.TabIndex = 4;
            this.id.Text = "0000000000";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(207, 36);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(72, 16);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "账户名：";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(275, 36);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(48, 16);
            this.name.TabIndex = 6;
            this.name.Text = "admin";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.balanceLabel.ForeColor = System.Drawing.Color.White;
            this.balanceLabel.Location = new System.Drawing.Point(28, 72);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(88, 16);
            this.balanceLabel.TabIndex = 7;
            this.balanceLabel.Text = "账户余额：";
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.balance.ForeColor = System.Drawing.Color.Green;
            this.balance.Location = new System.Drawing.Point(112, 72);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(72, 16);
            this.balance.TabIndex = 8;
            this.balance.Text = "14545.75";
            // 
            // loanLabel
            // 
            this.loanLabel.AutoSize = true;
            this.loanLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loanLabel.ForeColor = System.Drawing.Color.White;
            this.loanLabel.Location = new System.Drawing.Point(225, 72);
            this.loanLabel.Name = "loanLabel";
            this.loanLabel.Size = new System.Drawing.Size(72, 16);
            this.loanLabel.TabIndex = 9;
            this.loanLabel.Text = "信用额：";
            // 
            // loan
            // 
            this.loan.AutoSize = true;
            this.loan.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loan.ForeColor = System.Drawing.Color.White;
            this.loan.Location = new System.Drawing.Point(303, 72);
            this.loan.Name = "loan";
            this.loan.Size = new System.Drawing.Size(40, 16);
            this.loan.TabIndex = 10;
            this.loan.Text = "1000";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.allUser);
            this.groupBox.Controls.Add(this.inUser);
            this.groupBox.Location = new System.Drawing.Point(31, 103);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(214, 116);
            this.groupBox.TabIndex = 11;
            this.groupBox.TabStop = false;
            this.groupBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GroupBox_Paint);
            // 
            // allUser
            // 
            this.allUser.AutoSize = true;
            this.allUser.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.allUser.ForeColor = System.Drawing.Color.White;
            this.allUser.Location = new System.Drawing.Point(7, 79);
            this.allUser.Name = "allUser";
            this.allUser.Size = new System.Drawing.Size(218, 20);
            this.allUser.TabIndex = 1;
            this.allUser.TabStop = true;
            this.allUser.Text = "全部用户账户（账户ID）：";
            this.allUser.UseVisualStyleBackColor = true;
            this.allUser.CheckedChanged += new System.EventHandler(this.AllUser_CheckedChanged);
            // 
            // inUser
            // 
            this.inUser.AutoSize = true;
            this.inUser.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inUser.ForeColor = System.Drawing.Color.White;
            this.inUser.Location = new System.Drawing.Point(7, 26);
            this.inUser.Name = "inUser";
            this.inUser.Size = new System.Drawing.Size(138, 20);
            this.inUser.TabIndex = 0;
            this.inUser.TabStop = true;
            this.inUser.Text = "该用户内账户：";
            this.inUser.UseVisualStyleBackColor = true;
            this.inUser.CheckedChanged += new System.EventHandler(this.InUser_CheckedChanged);
            // 
            // accountList
            // 
            this.accountList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountList.Enabled = false;
            this.accountList.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountList.FormattingEnabled = true;
            this.accountList.Location = new System.Drawing.Point(173, 125);
            this.accountList.Name = "accountList";
            this.accountList.Size = new System.Drawing.Size(211, 24);
            this.accountList.TabIndex = 12;
            // 
            // tarAccountID
            // 
            this.tarAccountID.Enabled = false;
            this.tarAccountID.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tarAccountID.Location = new System.Drawing.Point(251, 182);
            this.tarAccountID.Name = "tarAccountID";
            this.tarAccountID.Size = new System.Drawing.Size(133, 26);
            this.tarAccountID.TabIndex = 13;
            // 
            // TransferBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(585, 310);
            this.ControlBox = false;
            this.Controls.Add(this.tarAccountID);
            this.Controls.Add(this.accountList);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.loan);
            this.Controls.Add(this.loanLabel);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.id);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.determine);
            this.Controls.Add(this.keyBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransferBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransferBoard";
            this.Load += new System.EventHandler(this.TransferBoard_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.KeyBoard keyBoard;
        private System.Windows.Forms.Button determine;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label loanLabel;
        private System.Windows.Forms.Label loan;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton allUser;
        private System.Windows.Forms.RadioButton inUser;
        private System.Windows.Forms.ComboBox accountList;
        private System.Windows.Forms.TextBox tarAccountID;
    }
}