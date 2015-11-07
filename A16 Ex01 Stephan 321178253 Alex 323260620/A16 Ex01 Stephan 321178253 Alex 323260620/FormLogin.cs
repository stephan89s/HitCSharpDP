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
        private bool isRememberUsersOpen = false;
        public FormLogin()
        {
            InitializeComponent();
           
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonSlidePanel_Click(object sender, EventArgs e)
        {
            const int k_RememberUsersFormWidthChange = 200;
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }
        private void loginAndInit()
        {
            LoginResult result = FacebookService.Login("909882489077378", "user_birthday", "email", "user_hometown", "user_about_me", "user_photos", "publish_actions", "user_status", "user_tagged_places", "read_stream", "user_groups", "user_friends");
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                LoggedInUser = result.LoggedInUser;
                this.Hide();
                DialogResult facebookAccountResult = new FormFacebookAccountBoard(LoggedInUser).ShowDialog();

            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }
        private void closeOrLogout(DialogResult i_facebookAccountResult)
        {

        }


    }
}
