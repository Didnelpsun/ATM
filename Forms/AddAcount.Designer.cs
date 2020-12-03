
namespace ATM.Forms
{
    partial class AddAcount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAcount));
            this.accountName = new System.Windows.Forms.TextBox();
            this.accountID = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.accountBank = new System.Windows.Forms.ComboBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.no = new System.Windows.Forms.RadioButton();
            this.yes = new System.Windows.Forms.RadioButton();
            this.accountIDLabel = new System.Windows.Forms.Label();
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.accountBankLabel = new System.Windows.Forms.Label();
            this.isCreditLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.bankLabel = new System.Windows.Forms.Label();
            this.creditLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountName
            // 
            this.accountName.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountName.Location = new System.Drawing.Point(198, 91);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(219, 26);
            this.accountName.TabIndex = 3;
            // 
            // accountID
            // 
            this.accountID.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountID.Location = new System.Drawing.Point(198, 35);
            this.accountID.Name = "accountID";
            this.accountID.ReadOnly = true;
            this.accountID.Size = new System.Drawing.Size(219, 26);
            this.accountID.TabIndex = 5;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.LimeGreen;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(176, 266);
            this.add.Margin = new System.Windows.Forms.Padding(0);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 16;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.Add_Click);
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
            this.cancel.TabIndex = 17;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // accountBank
            // 
            this.accountBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountBank.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountBank.FormattingEnabled = true;
            this.accountBank.Location = new System.Drawing.Point(198, 148);
            this.accountBank.Name = "accountBank";
            this.accountBank.Size = new System.Drawing.Size(219, 24);
            this.accountBank.TabIndex = 18;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.no);
            this.groupBox.Controls.Add(this.yes);
            this.groupBox.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox.Location = new System.Drawing.Point(198, 194);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox.Size = new System.Drawing.Size(219, 46);
            this.groupBox.TabIndex = 19;
            this.groupBox.TabStop = false;
            this.groupBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GroupBox_Paint);
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.no.Location = new System.Drawing.Point(135, 17);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(42, 20);
            this.no.TabIndex = 21;
            this.no.TabStop = true;
            this.no.Text = "否";
            this.no.UseVisualStyleBackColor = true;
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yes.Location = new System.Drawing.Point(45, 17);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(42, 20);
            this.yes.TabIndex = 20;
            this.yes.TabStop = true;
            this.yes.Text = "是";
            this.yes.UseVisualStyleBackColor = true;
            // 
            // accountIDLabel
            // 
            this.accountIDLabel.AutoSize = true;
            this.accountIDLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountIDLabel.ForeColor = System.Drawing.Color.White;
            this.accountIDLabel.Location = new System.Drawing.Point(120, 38);
            this.accountIDLabel.Name = "accountIDLabel";
            this.accountIDLabel.Size = new System.Drawing.Size(72, 16);
            this.accountIDLabel.TabIndex = 20;
            this.accountIDLabel.Text = "账户ID：";
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.AutoSize = true;
            this.accountNameLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountNameLabel.ForeColor = System.Drawing.Color.White;
            this.accountNameLabel.Location = new System.Drawing.Point(120, 94);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(72, 16);
            this.accountNameLabel.TabIndex = 21;
            this.accountNameLabel.Text = "账户名：";
            // 
            // accountBankLabel
            // 
            this.accountBankLabel.AutoSize = true;
            this.accountBankLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountBankLabel.ForeColor = System.Drawing.Color.White;
            this.accountBankLabel.Location = new System.Drawing.Point(104, 151);
            this.accountBankLabel.Name = "accountBankLabel";
            this.accountBankLabel.Size = new System.Drawing.Size(88, 16);
            this.accountBankLabel.TabIndex = 22;
            this.accountBankLabel.Text = "开户银行：";
            // 
            // isCreditLabel
            // 
            this.isCreditLabel.AutoSize = true;
            this.isCreditLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.isCreditLabel.ForeColor = System.Drawing.Color.White;
            this.isCreditLabel.Location = new System.Drawing.Point(117, 211);
            this.isCreditLabel.Name = "isCreditLabel";
            this.isCreditLabel.Size = new System.Drawing.Size(120, 16);
            this.isCreditLabel.TabIndex = 23;
            this.isCreditLabel.Text = "是否为信用卡：";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLabel.ForeColor = System.Drawing.Color.Crimson;
            this.nameLabel.Location = new System.Drawing.Point(423, 94);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(72, 16);
            this.nameLabel.TabIndex = 24;
            this.nameLabel.Text = "请输入！";
            // 
            // bankLabel
            // 
            this.bankLabel.AutoSize = true;
            this.bankLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bankLabel.ForeColor = System.Drawing.Color.Crimson;
            this.bankLabel.Location = new System.Drawing.Point(423, 151);
            this.bankLabel.Name = "bankLabel";
            this.bankLabel.Size = new System.Drawing.Size(72, 16);
            this.bankLabel.TabIndex = 25;
            this.bankLabel.Text = "请选择！";
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.creditLabel.ForeColor = System.Drawing.Color.Crimson;
            this.creditLabel.Location = new System.Drawing.Point(423, 211);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(72, 16);
            this.creditLabel.TabIndex = 26;
            this.creditLabel.Text = "请选择！";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.idLabel.ForeColor = System.Drawing.Color.Crimson;
            this.idLabel.Location = new System.Drawing.Point(423, 35);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(72, 16);
            this.idLabel.TabIndex = 27;
            this.idLabel.Text = "程序异常";
            // 
            // AddAcount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(585, 310);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.bankLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.isCreditLabel);
            this.Controls.Add(this.accountBankLabel);
            this.Controls.Add(this.accountNameLabel);
            this.Controls.Add(this.accountIDLabel);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.accountBank);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.add);
            this.Controls.Add(this.accountID);
            this.Controls.Add(this.accountName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAcount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAcount";
            this.Load += new System.EventHandler(this.AddAcount_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox accountName;
        private System.Windows.Forms.TextBox accountID;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ComboBox accountBank;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.RadioButton yes;
        private System.Windows.Forms.Label accountIDLabel;
        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.Label accountBankLabel;
        private System.Windows.Forms.Label isCreditLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label bankLabel;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.Label idLabel;
    }
}