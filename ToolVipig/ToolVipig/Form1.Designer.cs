namespace ToolVipig
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName_Vipig = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword_Vipig = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtUsername_Instagram = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword_insta = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messenger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.my_username = new System.Windows.Forms.Label();
            this.my_coin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng nhập";
            // 
            // txtUserName_Vipig
            // 
            this.txtUserName_Vipig.Location = new System.Drawing.Point(15, 62);
            this.txtUserName_Vipig.Name = "txtUserName_Vipig";
            this.txtUserName_Vipig.Size = new System.Drawing.Size(149, 22);
            this.txtUserName_Vipig.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NV,
            this.account_username,
            this.Url,
            this.messenger});
            this.dgv.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv.Location = new System.Drawing.Point(12, 183);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1009, 343);
            this.dgv.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStart.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(751, 32);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 53);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // txtPassword_Vipig
            // 
            this.txtPassword_Vipig.Location = new System.Drawing.Point(213, 62);
            this.txtPassword_Vipig.Name = "txtPassword_Vipig";
            this.txtPassword_Vipig.Size = new System.Drawing.Size(149, 22);
            this.txtPassword_Vipig.TabIndex = 5;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStop.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(907, 33);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(114, 52);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtUsername_Instagram
            // 
            this.txtUsername_Instagram.Location = new System.Drawing.Point(15, 140);
            this.txtUsername_Instagram.Name = "txtUsername_Instagram";
            this.txtUsername_Instagram.Size = new System.Drawing.Size(149, 22);
            this.txtUsername_Instagram.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên Đăng nhập Instagram";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mật khẩu Instagram";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPassword_insta
            // 
            this.txtPassword_insta.Location = new System.Drawing.Point(213, 140);
            this.txtPassword_insta.Name = "txtPassword_insta";
            this.txtPassword_insta.Size = new System.Drawing.Size(149, 22);
            this.txtPassword_insta.TabIndex = 10;
            this.txtPassword_insta.UseSystemPasswordChar = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "#";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // NV
            // 
            this.NV.HeaderText = "Loại nhiệm vụ";
            this.NV.MinimumWidth = 6;
            this.NV.Name = "NV";
            this.NV.ReadOnly = true;
            this.NV.Width = 125;
            // 
            // account_username
            // 
            this.account_username.HeaderText = "Tài khoản instagram";
            this.account_username.MinimumWidth = 6;
            this.account_username.Name = "account_username";
            this.account_username.ReadOnly = true;
            this.account_username.Width = 200;
            // 
            // Url
            // 
            this.Url.HeaderText = "Link Nhiệm vụ";
            this.Url.MinimumWidth = 6;
            this.Url.Name = "Url";
            this.Url.ReadOnly = true;
            this.Url.Width = 270;
            // 
            // messenger
            // 
            this.messenger.HeaderText = "Trạng thái";
            this.messenger.MinimumWidth = 6;
            this.messenger.Name = "messenger";
            this.messenger.ReadOnly = true;
            this.messenger.Width = 230;
            // 
            // my_username
            // 
            this.my_username.AutoSize = true;
            this.my_username.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_username.ForeColor = System.Drawing.Color.Red;
            this.my_username.Location = new System.Drawing.Point(500, 66);
            this.my_username.Name = "my_username";
            this.my_username.Size = new System.Drawing.Size(88, 19);
            this.my_username.TabIndex = 12;
            this.my_username.Text = "Username";
            // 
            // my_coin
            // 
            this.my_coin.AutoSize = true;
            this.my_coin.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_coin.ForeColor = System.Drawing.Color.Red;
            this.my_coin.Location = new System.Drawing.Point(500, 107);
            this.my_coin.Name = "my_coin";
            this.my_coin.Size = new System.Drawing.Size(58, 19);
            this.my_coin.TabIndex = 13;
            this.my_coin.Text = "0 VND";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 538);
            this.Controls.Add(this.my_coin);
            this.Controls.Add(this.my_username);
            this.Controls.Add(this.txtPassword_insta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsername_Instagram);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.txtPassword_Vipig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtUserName_Vipig);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToolVipig";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName_Vipig;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword_Vipig;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtUsername_Instagram;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword_insta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url;
        private System.Windows.Forms.DataGridViewTextBoxColumn messenger;
        private System.Windows.Forms.Label my_username;
        private System.Windows.Forms.Label my_coin;
    }
}

