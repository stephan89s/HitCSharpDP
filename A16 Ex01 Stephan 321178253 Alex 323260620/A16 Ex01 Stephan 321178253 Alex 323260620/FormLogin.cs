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
        public LoginResult result { get; set; }
        public bool isRememberedUsersOpen { get; set; }

        public FormLogin()
        {
            InitializeComponent();
            AccountsStorage.Instance.UserConfigurationsAdded += this.AddAndRefreshRememberedUsersListBox;
            AccountsStorage.Instance.UserConfigurationsRemoved += this.RemoveAndRefreshRememberedUsersListBox;
            FacebookService.s_CollectionLimit = 100;

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (isRememberedUsersOpen && listBoxRememberedUsers.SelectedIndex > -1)
            {

                logInWithRememberedUser();
            }
            else
            {
                logInNewUser();
            }
            
        }

        private void InitAccountBoard()
        {
            if (result.ErrorMessage == null)
            {
                this.Hide();
                DialogResult facebookAccountResult = new FormFacebookAccountBoard(result.LoggedInUser).ShowDialog();
                closeOrLogout(facebookAccountResult);
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void AddAndRefreshRememberedUsersListBox(AccountsStorage.UserConfiguration i_UserConfiguration)
        {
            listBoxRememberedUsers.Items.Add(i_UserConfiguration);
        }
        private void RemoveAndRefreshRememberedUsersListBox(AccountsStorage.UserConfiguration i_UserConfiguration)
        {
            listBoxRememberedUsers.Items.Remove(i_UserConfiguration);
        }

        private void StoreLoggedInUserConfiguration()
        {
            string logedUserEMail = result.LoggedInUser.Email == null ? "No Email" : result.LoggedInUser.Email;
            string uniqName = string.Format("{0} ({1})", result.LoggedInUser.Name, logedUserEMail);
            AccountsStorage.Instance.AddToStorage(uniqName, result.AccessToken);

        }
        private void logInWithRememberedUser()
        {
            string knownAccsesToken = ((AccountsStorage.UserConfiguration)listBoxRememberedUsers.SelectedItem).AccessToken;
            if (knownAccsesToken != null)
            {
                result = FacebookService.Connect(knownAccsesToken);
            }
            InitAccountBoard();
        }

        private void logInNewUser()
        {
            result = FacebookService.Login("909882489077378", "user_birthday", "email", "user_hometown", "user_about_me", "user_photos", "publish_actions", "user_status", "user_tagged_places", "user_friends");
            if (!string.IsNullOrEmpty(result.AccessToken))
            {

                if (checkBoxRememberUser.Checked)
                {
                    StoreLoggedInUserConfiguration();
                }
            }
            InitAccountBoard();
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
            if (!isRememberedUsersOpen)
            {

                Width += k_RememberUsersFormWidthChange;
                isRememberedUsersOpen = true;
                buttonRememberedUsers.Text = "<< Close Remembered Users";

            }
            else
            {
                Width -= k_RememberUsersFormWidthChange;
                isRememberedUsersOpen = false;
                buttonRememberedUsers.Text = "Remembered Users >>";
            }
        }
      
        

        protected override void OnClosed(EventArgs e)
        {
            AccountsStorage.Instance.SaveToFile();
            base.OnClosed(e);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AccountsStorage.Instance.LoadFromFile();
            foreach (var userConfig in AccountsStorage.Instance.StorageList)
            {
                AddAndRefreshRememberedUsersListBox(userConfig);
            }
        }

        private void buttonDeletFromUsersList_Click(object sender, EventArgs e)
        {
            AccountsStorage.Instance.RemoveFromStorage((AccountsStorage.UserConfiguration)listBoxRememberedUsers.SelectedItem);

        }

        private void listBoxRememberedUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logInWithRememberedUser();
            }

        }

        private void listBoxRememberedUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            logInWithRememberedUser();
        }
    }

}
