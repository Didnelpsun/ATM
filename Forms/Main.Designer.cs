
namespace ATM.Forms
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        # region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.login = new System.Windows.Forms.Button();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPsw = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.forgetPsw = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.Color.LimeGreen;
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(209, 227);
            this.login.Margin = new System.Windows.Forms.Padding(0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(171, 43);
            this.login.TabIndex = 0;
            this.login.Text = "登录";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.Login_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxUser.Location = new System.Drawing.Point(199, 67);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(229, 26);
            this.textBoxUser.TabIndex = 2;
            this.textBoxUser.TextChanged += new System.EventHandler(this.TextBoxUser_TextChanged);
            // 
            // textBoxPsw
            // 
            this.textBoxPsw.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPsw.Location = new System.Drawing.Point(199, 148);
            this.textBoxPsw.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPsw.Name = "textBoxPsw";
            this.textBoxPsw.PasswordChar = '*';
            this.textBoxPsw.Size = new System.Drawing.Size(229, 26);
            this.textBoxPsw.TabIndex = 4;
            this.textBoxPsw.TextChanged += new System.EventHandler(this.TextBoxPsw_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATM.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(158, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ATM.Properties.Resources.password;
            this.pictureBox2.Location = new System.Drawing.Point(160, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ATM.Properties.Resources.exit;
            this.pictureBox3.Location = new System.Drawing.Point(545, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.Exit_Click);
            // 
            // forgetPsw
            // 
            this.forgetPsw.AutoSize = true;
            this.forgetPsw.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.forgetPsw.ForeColor = System.Drawing.Color.White;
            this.forgetPsw.Location = new System.Drawing.Point(403, 245);
            this.forgetPsw.Name = "forgetPsw";
            this.forgetPsw.Size = new System.Drawing.Size(65, 12);
            this.forgetPsw.TabIndex = 8;
            this.forgetPsw.Text = "忘记密码？";
            this.forgetPsw.Click += new System.EventHandler(this.ForgetPsw_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 310);
            this.ControlBox = false;
            this.Controls.Add(this.forgetPsw);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxPsw);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自助存取款系统";
            this.TransparencyKey = System.Drawing.Color.Black;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPsw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label forgetPsw;
    }
}

