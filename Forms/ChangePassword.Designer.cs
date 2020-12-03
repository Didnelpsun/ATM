
namespace ATM.Forms
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.oldPsw = new System.Windows.Forms.TextBox();
            this.oldPswLabel = new System.Windows.Forms.Label();
            this.newPsw = new System.Windows.Forms.TextBox();
            this.newPswLabel = new System.Windows.Forms.Label();
            this.confirmPsw = new System.Windows.Forms.TextBox();
            this.confirmPswLabel = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.newLabel = new System.Windows.Forms.Label();
            this.oldLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oldPsw
            // 
            this.oldPsw.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.oldPsw.Location = new System.Drawing.Point(198, 35);
            this.oldPsw.Name = "oldPsw";
            this.oldPsw.Size = new System.Drawing.Size(219, 26);
            this.oldPsw.TabIndex = 2;
            // 
            // oldPswLabel
            // 
            this.oldPswLabel.AutoSize = true;
            this.oldPswLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.oldPswLabel.ForeColor = System.Drawing.Color.White;
            this.oldPswLabel.Location = new System.Drawing.Point(127, 38);
            this.oldPswLabel.Name = "oldPswLabel";
            this.oldPswLabel.Size = new System.Drawing.Size(72, 16);
            this.oldPswLabel.TabIndex = 3;
            this.oldPswLabel.Text = "旧密码：";
            // 
            // newPsw
            // 
            this.newPsw.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newPsw.Location = new System.Drawing.Point(198, 118);
            this.newPsw.Name = "newPsw";
            this.newPsw.Size = new System.Drawing.Size(219, 26);
            this.newPsw.TabIndex = 4;
            // 
            // newPswLabel
            // 
            this.newPswLabel.AutoSize = true;
            this.newPswLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newPswLabel.ForeColor = System.Drawing.Color.White;
            this.newPswLabel.Location = new System.Drawing.Point(127, 121);
            this.newPswLabel.Name = "newPswLabel";
            this.newPswLabel.Size = new System.Drawing.Size(72, 16);
            this.newPswLabel.TabIndex = 5;
            this.newPswLabel.Text = "新密码：";
            // 
            // confirmPsw
            // 
            this.confirmPsw.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmPsw.Location = new System.Drawing.Point(198, 202);
            this.confirmPsw.Name = "confirmPsw";
            this.confirmPsw.Size = new System.Drawing.Size(219, 26);
            this.confirmPsw.TabIndex = 6;
            // 
            // confirmPswLabel
            // 
            this.confirmPswLabel.AutoSize = true;
            this.confirmPswLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmPswLabel.ForeColor = System.Drawing.Color.White;
            this.confirmPswLabel.Location = new System.Drawing.Point(111, 205);
            this.confirmPswLabel.Name = "confirmPswLabel";
            this.confirmPswLabel.Size = new System.Drawing.Size(88, 16);
            this.confirmPswLabel.TabIndex = 7;
            this.confirmPswLabel.Text = "确认密码：";
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
            this.change.TabIndex = 15;
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
            this.cancel.TabIndex = 16;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmLabel.ForeColor = System.Drawing.Color.Crimson;
            this.confirmLabel.Location = new System.Drawing.Point(423, 205);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(104, 16);
            this.confirmLabel.TabIndex = 17;
            this.confirmLabel.Text = "密码不一致！";
            // 
            // newLabel
            // 
            this.newLabel.AutoSize = true;
            this.newLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newLabel.ForeColor = System.Drawing.Color.Crimson;
            this.newLabel.Location = new System.Drawing.Point(423, 121);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(88, 16);
            this.newLabel.TabIndex = 18;
            this.newLabel.Text = "密码过短！";
            // 
            // oldLabel
            // 
            this.oldLabel.AutoSize = true;
            this.oldLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.oldLabel.ForeColor = System.Drawing.Color.Crimson;
            this.oldLabel.Location = new System.Drawing.Point(423, 38);
            this.oldLabel.Name = "oldLabel";
            this.oldLabel.Size = new System.Drawing.Size(104, 16);
            this.oldLabel.TabIndex = 19;
            this.oldLabel.Text = "旧密码错误！";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(585, 310);
            this.Controls.Add(this.oldLabel);
            this.Controls.Add(this.newLabel);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.change);
            this.Controls.Add(this.confirmPswLabel);
            this.Controls.Add(this.confirmPsw);
            this.Controls.Add(this.newPswLabel);
            this.Controls.Add(this.newPsw);
            this.Controls.Add(this.oldPswLabel);
            this.Controls.Add(this.oldPsw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oldPsw;
        private System.Windows.Forms.Label oldPswLabel;
        private System.Windows.Forms.TextBox newPsw;
        private System.Windows.Forms.Label newPswLabel;
        private System.Windows.Forms.TextBox confirmPsw;
        private System.Windows.Forms.Label confirmPswLabel;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.Label newLabel;
        private System.Windows.Forms.Label oldLabel;
    }
}