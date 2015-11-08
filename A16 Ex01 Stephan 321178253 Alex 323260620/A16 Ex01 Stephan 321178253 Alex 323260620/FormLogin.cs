using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    public partial class FormLogin : Form
    {
        public User LoggedInUser { get; set; }
        public LoginResult result { get; set; }
        private bool isRememberUsersOpen = false;
        public FormLogin()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 300;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }
        private void loginAndInit()
        {
            result = FacebookService.Login("909882489077378", "user_birthday", "email", "user_hometown", "user_about_me", "user_photos", "publish_actions", "user_status", "user_tagged_places", "user_friends");
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                LoggedInUser = result.LoggedInUser;
                this.Hide();
                DialogResult facebookAccountResult = new FormFacebookAccountBoard(LoggedInUser).ShowDialog();
                closeOrLogout(facebookAccountResult);
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }
        private void closeOrLogout(DialogResult i_facebookAccountResult)
        {
            FacebookService.Logout(null);
            switch (i_facebookAccountResult)
            {
                case DialogResult.Retry:
                default:
                    Show();
                    break;
                case DialogResult.Cancel:
                    Close();
                    break;
            }


        }

        private void buttonRememberedUsers_Click(object sender, EventArgs e)
        {
            const int k_RememberUsersFormWidthChange = 210;
            if (!isRememberUsersOpen)
            {
                Width += k_RememberUsersFormWidthChange;
                isRememberUsersOpen = true;
                buttonRememberedUsers.Text = "<< Close Remembered Users";

            }
            else
            {
                Width -= k_RememberUsersFormWidthChange;
                isRememberUsersOpen = false;
                buttonRememberedUsers.Text = "Remembered Users >>";
            }
        }
    }
}
