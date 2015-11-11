namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRememberedUsers = new System.Windows.Forms.Button();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.labelRememberedUsers = new System.Windows.Forms.Label();
            this.listBoxRememberedUsers = new System.Windows.Forms.ListBox();
            this.buttonDeletFromUsersList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.White;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Tahoma", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(13, 109);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(210, 121);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRememberedUsers
            // 
            this.buttonRememberedUsers.BackColor = System.Drawing.Color.White;
            this.buttonRememberedUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRememberedUsers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRememberedUsers.Location = new System.Drawing.Point(13, 13);
            this.buttonRememberedUsers.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRememberedUsers.Name = "buttonRememberedUsers";
            this.buttonRememberedUsers.Size = new System.Drawing.Size(210, 57);
            this.buttonRememberedUsers.TabIndex = 3;
            this.buttonRememberedUsers.Text = "Remembered Users >>";
            this.buttonRememberedUsers.UseVisualStyleBackColor = false;
            this.buttonRememberedUsers.Click += new System.EventHandler(this.buttonRememberedUsers_Click);
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(146)))));
            this.checkBoxRememberUser.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRememberUser.Location = new System.Drawing.Point(13, 78);
            this.checkBoxRememberUser.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(162, 25);
            this.checkBoxRememberUser.TabIndex = 6;
            this.checkBoxRememberUser.Text = "Remember User";
            this.checkBoxRememberUser.UseVisualStyleBackColor = false;
            // 
            // labelRememberedUsers
            // 
            this.labelRememberedUsers.AutoSize = true;
            this.labelRememberedUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(146)))));
            this.labelRememberedUsers.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRememberedUsers.Location = new System.Drawing.Point(274, 9);
            this.labelRememberedUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRememberedUsers.Name = "labelRememberedUsers";
            this.labelRememberedUsers.Size = new System.Drawing.Size(169, 21);
            this.labelRememberedUsers.TabIndex = 9;
            this.labelRememberedUsers.Text = "Remembered Users";
            // 
            // listBoxRememberedUsers
            // 
            this.listBoxRememberedUsers.FormattingEnabled = true;
            this.listBoxRememberedUsers.ItemHeight = 16;
            this.listBoxRememberedUsers.Location = new System.Drawing.Point(249, 32);
            this.listBoxRememberedUsers.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxRememberedUsers.Name = "listBoxRememberedUsers";
            this.listBoxRememberedUsers.Size = new System.Drawing.Size(244, 132);
            this.listBoxRememberedUsers.TabIndex = 8;
            this.listBoxRememberedUsers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxRememberedUsers_KeyDown);
            this.listBoxRememberedUsers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxRememberedUsers_MouseDoubleClick);
            // 
            // buttonDeletFromUsersList
            // 
            this.buttonDeletFromUsersList.BackColor = System.Drawing.Color.White;
            this.buttonDeletFromUsersList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeletFromUsersList.Font = new System.Drawing.Font("Tahoma", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletFromUsersList.Location = new System.Drawing.Point(249, 172);
            this.buttonDeletFromUsersList.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeletFromUsersList.Name = "buttonDeletFromUsersList";
            this.buttonDeletFromUsersList.Size = new System.Drawing.Size(245, 57);
            this.buttonDeletFromUsersList.TabIndex = 7;
            this.buttonDeletFromUsersList.Text = "Delete From List";
            this.buttonDeletFromUsersList.UseVisualStyleBackColor = false;
            this.buttonDeletFromUsersList.Click += new System.EventHandler(this.buttonDeletFromUsersList_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(235, 243);
            this.Controls.Add(this.labelRememberedUsers);
            this.Controls.Add(this.listBoxRememberedUsers);
            this.Controls.Add(this.buttonDeletFromUsersList);
            this.Controls.Add(this.checkBoxRememberUser);
            this.Controls.Add(this.buttonRememberedUsers);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRememberedUsers;
        private System.Windows.Forms.CheckBox checkBoxRememberUser;
        private System.Windows.Forms.Label labelRememberedUsers;
        private System.Windows.Forms.ListBox listBoxRememberedUsers;
        private System.Windows.Forms.Button buttonDeletFromUsersList;
    }
}

