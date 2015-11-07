using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    public partial class FormFacebookAccountBoard : Form
    {
        private readonly User m_LoggedInUser;
        public FormFacebookAccountBoard(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();

        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
           
            pictureBoxUserSmallPicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
            labelUserName.Text = m_LoggedInUser.Name;
            foreach (User friend in m_LoggedInUser.Friends)
            {
                listBoxFriends.Items.Add(friend.Name);
            }
            foreach (Checkin checkin in m_LoggedInUser.Checkins)
            {
                listBoxCheckIns.Items.Add(checkin.Place.Name);
            }
        }



    }
}
