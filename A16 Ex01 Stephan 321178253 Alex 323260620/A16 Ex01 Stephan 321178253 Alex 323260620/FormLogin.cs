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
        public User m_LoggedInUser { get; set; }
        public LoginResult m_result { get; set; }
        private bool m_isRememberUsersOpen = false;
        public FormLogin()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 200;
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
            m_result = FacebookService.Login("909882489077378", "user_birthday", "email", "user_hometown", "user_about_me", "user_photos", "publish_actions", "user_status", "user_tagged_places", "user_friends");
            if (!string.IsNullOrEmpty(m_result.AccessToken))
            {
                m_LoggedInUser = m_result.LoggedInUser;
                this.Hide();
                DialogResult facebookAccountResult = new FormFacebookAccountBoard(m_LoggedInUser).ShowDialog();
                closeOrLogout(facebookAccountResult);
            }
            else
            {
                MessageBox.Show(m_result.ErrorMessage);
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
            if (!m_isRememberUsersOpen)
            {
                Width += k_RememberUsersFormWidthChange;
                m_isRememberUsersOpen = true;
                buttonRememberedUsers.Text = "<< Close Remembered Users";

            }
            else
            {
                Width -= k_RememberUsersFormWidthChange;
                m_isRememberUsersOpen = false;
                buttonRememberedUsers.Text = "Remembered Users >>";
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ApplicationSettings.Instance.AutoLogin = this.checkBoxRememberMe.Checked;
            ApplicationSettings.Instance.Save();
        }


        protected override void OnShown(EventArgs e)
        {
            base.OnLoad(e);

            
            this.checkBoxRememberMe.Checked = ApplicationSettings.Instance.AutoLogin;

            if (ApplicationSettings.Instance.AutoLogin)
            {
                autoLogin();
            }
        }

        private void autoLogin()
        {
            LoginResult result = FacebookService.Connect(ApplicationSettings.Instance.AccessToken);
            if (string.IsNullOrEmpty(result.ErrorMessage))
            {
                m_LoggedInUser = result.LoggedInUser;
                
            }
        }
    }

}
