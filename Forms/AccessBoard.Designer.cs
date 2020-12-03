
namespace ATM.Forms
{
    partial class AccessBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessBoard));
            this.title = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.bankLabel = new System.Windows.Forms.Label();
            this.bank = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.loanLabel = new System.Windows.Forms.Label();
            this.loan = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.flowLabel = new System.Windows.Forms.Label();
            this.flow = new System.Windows.Forms.Label();
            this.determine = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.keyBoard = new ATM.Control.KeyBoard();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(35, 36);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(49, 20);
            this.title.TabIndex = 1;
            this.title.Text = "存款";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.idLabel.ForeColor = System.Drawing.Color.White;
            this.idLabel.Location = new System.Drawing.Point(28, 81);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(72, 16);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "账户ID：";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.id.ForeColor = System.Drawing.Color.White;
            this.id.Location = new System.Drawing.Point(102, 81);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(88, 16);
            this.id.TabIndex = 3;
            this.id.Text = "0000000000";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(200, 81);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(72, 16);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "账户名：";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(266, 81);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(48, 16);
            this.name.TabIndex = 5;
            this.name.Text = "admin";
            // 
            // bankLabel
            // 
            this.bankLabel.AutoSize = true;
            this.bankLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bankLabel.ForeColor = System.Drawing.Color.White;
            this.bankLabel.Location = new System.Drawing.Point(28, 119);
            this.bankLabel.Name = "bankLabel";
            this.bankLabel.Size = new System.Drawing.Size(88, 16);
            this.bankLabel.TabIndex = 6;
            this.bankLabel.Text = "账户银行：";
            // 
            // bank
            // 
            this.bank.AutoSize = true;
            this.bank.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bank.ForeColor = System.Drawing.Color.White;
            this.bank.Location = new System.Drawing.Point(110, 119);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(104, 16);
            this.bank.TabIndex = 7;
            this.bank.Text = "中国建设银行";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gradeLabel.ForeColor = System.Drawing.Color.White;
            this.gradeLabel.Location = new System.Drawing.Point(220, 119);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(88, 16);
            this.gradeLabel.TabIndex = 8;
            this.gradeLabel.Text = "账户等级：";
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grade.ForeColor = System.Drawing.Color.White;
            this.grade.Location = new System.Drawing.Point(301, 119);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(72, 16);
            this.grade.TabIndex = 9;
            this.grade.Text = "钻石账户";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.typeLabel.ForeColor = System.Drawing.Color.White;
            this.typeLabel.Location = new System.Drawing.Point(28, 158);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(120, 16);
            this.typeLabel.TabIndex = 10;
            this.typeLabel.Text = "是否为信用卡：";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.type.ForeColor = System.Drawing.Color.White;
            this.type.Location = new System.Drawing.Point(158, 158);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(24, 16);
            this.type.TabIndex = 11;
            this.type.Text = "是";
            // 
            // loanLabel
            // 
            this.loanLabel.AutoSize = true;
            this.loanLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loanLabel.ForeColor = System.Drawing.Color.White;
            this.loanLabel.Location = new System.Drawing.Point(220, 158);
            this.loanLabel.Name = "loanLabel";
            this.loanLabel.Size = new System.Drawing.Size(72, 16);
            this.loanLabel.TabIndex = 12;
            this.loanLabel.Text = "信用额：";
            // 
            // loan
            // 
            this.loan.AutoSize = true;
            this.loan.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loan.ForeColor = System.Drawing.Color.White;
            this.loan.Location = new System.Drawing.Point(292, 158);
            this.loan.Name = "loan";
            this.loan.Size = new System.Drawing.Size(48, 16);
            this.loan.TabIndex = 13;
            this.loan.Text = "10000";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.balanceLabel.ForeColor = System.Drawing.Color.White;
            this.balanceLabel.Location = new System.Drawing.Point(28, 198);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(88, 16);
            this.balanceLabel.TabIndex = 14;
            this.balanceLabel.Text = "账户余额：";
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.balance.ForeColor = System.Drawing.Color.Green;
            this.balance.Location = new System.Drawing.Point(110, 198);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(72, 16);
            this.balance.TabIndex = 15;
            this.balance.Text = "14545.75";
            // 
            // flowLabel
            // 
            this.flowLabel.AutoSize = true;
            this.flowLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flowLabel.ForeColor = System.Drawing.Color.White;
            this.flowLabel.Location = new System.Drawing.Point(210, 198);
            this.flowLabel.Name = "flowLabel";
            this.flowLabel.Size = new System.Drawing.Size(72, 16);
            this.flowLabel.TabIndex = 16;
            this.flowLabel.Text = "流水额：";
            // 
            // flow
            // 
            this.flow.AutoSize = true;
            this.flow.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flow.ForeColor = System.Drawing.Color.White;
            this.flow.Location = new System.Drawing.Point(276, 198);
            this.flow.Name = "flow";
            this.flow.Size = new System.Drawing.Size(64, 16);
            this.flow.TabIndex = 17;
            this.flow.Text = "23443.6";
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
            this.determine.TabIndex = 18;
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
            this.cancel.TabIndex = 19;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // keyBoard
            // 
            this.keyBoard.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.keyBoard.Location = new System.Drawing.Point(418, 36);
            this.keyBoard.Name = "keyBoard";
            this.keyBoard.Size = new System.Drawing.Size(136, 229);
            this.keyBoard.TabIndex = 20;
            // 
            // AccessBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(585, 310);
            this.ControlBox = false;
            this.Controls.Add(this.keyBoard);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.determine);
            this.Controls.Add(this.flow);
            this.Controls.Add(this.flowLabel);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.loan);
            this.Controls.Add(this.loanLabel);
            this.Controls.Add(this.type);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.bank);
            this.Controls.Add(this.bankLabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.id);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccessBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccessBoard";
            this.Load += new System.EventHandler(this.AccessBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label bankLabel;
        private System.Windows.Forms.Label bank;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label grade;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label loanLabel;
        private System.Windows.Forms.Label loan;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label flowLabel;
        private System.Windows.Forms.Label flow;
        private System.Windows.Forms.Button determine;
        private System.Windows.Forms.Button cancel;
        private Control.KeyBoard keyBoard;
    }
}