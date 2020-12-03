
namespace ATM.Forms
{
    partial class ChangeUserName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeUserName));
            this.change = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.oldUserNameLabel = new System.Windows.Forms.Label();
            this.oldLabel = new System.Windows.Forms.Label();
            this.newUserNameLabel = new System.Windows.Forms.Label();
            this.newLabel = new System.Windows.Forms.Label();
            this.oldUserName = new System.Windows.Forms.TextBox();
            this.newUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.change.TabIndex = 16;
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
            this.cancel.TabIndex = 17;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // oldUserNameLabel
            // 
            this.oldUserNameLabel.AutoSize = true;
            this.oldUserNameLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.oldUserNameLabel.ForeColor = System.Drawing.Color.White;
            this.oldUserNameLabel.Location = new System.Drawing.Point(104, 65);
            this.oldUserNameLabel.Name = "oldUserNameLabel";
            this.oldUserNameLabel.Size = new System.Drawing.Size(88, 16);
            this.oldUserNameLabel.TabIndex = 19;
            this.oldUserNameLabel.Text = "旧用户名：";
            // 
            // oldLabel
            // 
            this.oldLabel.AutoSize = true;
            this.oldLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.oldLabel.ForeColor = System.Drawing.Color.Crimson;
            this.oldLabel.Location = new System.Drawing.Point(423, 65);
            this.oldLabel.Name = "oldLabel";
            this.oldLabel.Size = new System.Drawing.Size(120, 16);
            this.oldLabel.TabIndex = 20;
            this.oldLabel.Text = "旧用户名错误！";
            // 
            // newUserNameLabel
            // 
            this.newUserNameLabel.AutoSize = true;
            this.newUserNameLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newUserNameLabel.ForeColor = System.Drawing.Color.White;
            this.newUserNameLabel.Location = new System.Drawing.Point(104, 164);
            this.newUserNameLabel.Name = "newUserNameLabel";
            this.newUserNameLabel.Size = new System.Drawing.Size(88, 16);
            this.newUserNameLabel.TabIndex = 21;
            this.newUserNameLabel.Text = "新用户名：";
            // 
            // newLabel
            // 
            this.newLabel.AutoSize = true;
            this.newLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newLabel.ForeColor = System.Drawing.Color.Crimson;
            this.newLabel.Location = new System.Drawing.Point(423, 164);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(120, 16);
            this.newLabel.TabIndex = 23;
            this.newLabel.Text = "新用户名过短！";
            // 
            // oldUserName
            // 
            this.oldUserName.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.oldUserName.Location = new System.Drawing.Point(198, 62);
            this.oldUserName.Name = "oldUserName";
            this.oldUserName.Size = new System.Drawing.Size(219, 26);
            this.oldUserName.TabIndex = 24;
            // 
            // newUserName
            // 
            this.newUserName.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newUserName.Location = new System.Drawing.Point(198, 161);
            this.newUserName.Name = "newUserName";
            this.newUserName.Size = new System.Drawing.Size(219, 26);
            this.newUserName.TabIndex = 25;
            // 
            // ChangeUserName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(585, 310);
            this.Controls.Add(this.newUserName);
            this.Controls.Add(this.oldUserName);
            this.Controls.Add(this.newLabel);
            this.Controls.Add(this.newUserNameLabel);
            this.Controls.Add(this.oldLabel);
            this.Controls.Add(this.oldUserNameLabel);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.change);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeUserName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeUserName";
            this.Load += new System.EventHandler(this.ChangeUserName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label oldUserNameLabel;
        private System.Windows.Forms.Label oldLabel;
        private System.Windows.Forms.Label newUserNameLabel;
        private System.Windows.Forms.Label newLabel;
        private System.Windows.Forms.TextBox oldUserName;
        private System.Windows.Forms.TextBox newUserName;
    }
}