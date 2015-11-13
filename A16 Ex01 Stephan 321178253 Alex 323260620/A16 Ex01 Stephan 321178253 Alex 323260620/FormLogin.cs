using Facebook;
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
        public LoginResult result
        {
            get; set;
        }
        public bool isRememberedUsersOpen
        {
            get; set;
        }
        private ToolTip toolTip;

        public FormLogin()
        {
            InitializeComponent();
            AccountsStorage.Instance.UserConfigurationsAddedToStorage += this.AddAndRefreshRememberedUsersListBox;
            AccountsStorage.Instance.UserConfigurationsRemovedFromStorage += this.RemoveAndRefreshRememberedUsersListBox;
            toolTip = new ToolTip();
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
            if (AccountsStorage.Instance.StorageList.Count == 1)
            {
                buttonRememberedUsers.Enabled = true;
            }
            
        }
        private void RemoveAndRefreshRememberedUsersListBox(AccountsStorage.UserConfiguration i_UserConfiguration)
        {
            listBoxRememberedUsers.Items.Remove(i_UserConfiguration);
            if (AccountsStorage.Instance.isStorageEmpty)
            {
               
               
            }
        }

        private void StoreLoggedInUserConfiguration()
        {
            string logedUserEMail = result.LoggedInUser.Email == null ? "No Email" : result.LoggedInUser.Email;
            string uniqName = string.Format("{0} ({1})", result.LoggedInUser.Name, logedUserEMail);
            
            AccountsStorage.Instance.AddToStorage(uniqName, result.AccessToken);
            if (listBoxRememberedUsers.Items.Count == 1)
            {
                buttonRememberedUsers.Enabled = true;
            }
        }
        private void logInWithRememberedUser()
        {
            string knownAccsesToken = ((AccountsStorage.UserConfiguration)listBoxRememberedUsers.SelectedItem).AccessToken;
            if (knownAccsesToken != null)
            {
                try
                {

                    result = FacebookService.Connect(knownAccsesToken);
                }
                catch (FacebookApiException ex)
                {
                    MessageBox.Show(this, ex.Message, "Ooops...", MessageBoxButtons.OK);
                    AccountsStorage.Instance.RemoveFromStorage((AccountsStorage.UserConfiguration)listBoxRememberedUsers.SelectedItem);

                }
            }
            if (result != null)
            {
                InitAccountBoard();
            }

        }

        private void logInNewUser()
        {
            result = FacebookService.Login("909882489077378", "user_birthday", "email", "user_hometown", "user_about_me", "user_photos", "publish_actions", "user_status", "user_tagged_places", "user_friends", "user_likes");
            if (!string.IsNullOrEmpty(result.AccessToken))
            {

                if (checkBoxRememberUser.Checked)
                {
                    StoreLoggedInUserConfiguration();

                }
                InitAccountBoard();
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
            if (!isRememberedUsersOpen)
            {

                Width += k_RememberUsersFormWidthChange;

                buttonRememberedUsers.Text = "<< Close Remembered Users";
                checkBoxRememberUser.Checked = false;

            }
            else
            {
                Width -= k_RememberUsersFormWidthChange;
                buttonRememberedUsers.Text = "Remembered Users >>";
            }
            isRememberedUsersOpen = !isRememberedUsersOpen;
            checkBoxRememberUser.Enabled = !checkBoxRememberUser.Enabled;

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
            if (AccountsStorage.Instance.isStorageEmpty)
            {
                buttonRememberedUsers.Enabled = false;

            }
            else
            {
                foreach (var userConfig in AccountsStorage.Instance.StorageList)
                {
                    AddAndRefreshRememberedUsersListBox(userConfig);
                }
            }


        }

        private void buttonDeletFromUsersList_Click(object sender, EventArgs e)
        {
            AccountsStorage.Instance.RemoveFromStorage((AccountsStorage.UserConfiguration)listBoxRememberedUsers.SelectedItem);
            if (AccountsStorage.Instance.isStorageEmpty)
            {
                buttonRememberedUsers.PerformClick();
                buttonRememberedUsers.Enabled = false;
            }

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
