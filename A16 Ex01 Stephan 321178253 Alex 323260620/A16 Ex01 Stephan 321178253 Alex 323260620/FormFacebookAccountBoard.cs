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
        public User LoggedInUser { get; set; }
        public List<ApplicationPost> AppPostsList { get; }
        public List<ApplicationEvent> AppEventsList { get; }
        public List<ApplicationComment> m_selectedGridItemCommentsList;
        private bool m_isShowMoreInfoOpen = false;
        FormCommentList m_ChosedCommentsForm;
        public FormFacebookAccountBoard(User i_LoggedInUser)
        {
            LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            AppPostsList = new List<ApplicationPost>();
            AppEventsList = new List<ApplicationEvent>();
            Text = i_LoggedInUser == null ? "Not Connected" : string.Format("Logged In as {0}", i_LoggedInUser.Name);
        }
        

    private void buttonLogOut_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (e.CloseReason == CloseReason.UserClosing)
            {
                switch (MessageBox.Show(this, "Are you sure you want to close This Application?", "Closing", MessageBoxButtons.YesNo))
                {
                    case DialogResult.No:
                        e.Cancel = true; 
                        break;
                    default:
                        break;
                }
            }
        }

        private void dataGridViewPosts_SelectionChanged(object sender, EventArgs e)
        {
            m_selectedGridItemCommentsList = new List<ApplicationComment>();
            int rowIndex = dataGridViewPosts.CurrentCell.RowIndex;
            string ItemID = ((List<ApplicationPost>)dataGridViewPosts.DataSource)[rowIndex].GetPublishedItemID();

            foreach (var post in LoggedInUser.WallPosts)
            {
                if(post.Id.Equals(ItemID))
                {
                    foreach (var comment in post.Comments)
                    {
                        m_selectedGridItemCommentsList.Add(new ApplicationComment(comment));
                    }
                    break;
                }
                
            }
            
                buttonComments.Enabled = m_selectedGridItemCommentsList.Count > 0? true : false;
            buttonComments.Text = string.Format("Comments ({0})", m_selectedGridItemCommentsList.Count);
        }

       

        private void buttonShowMoreInfo_Click(object sender, EventArgs e)
        {
            const int k_ShowMoreInfoFormWidthChange = 310;
            if (!m_isShowMoreInfoOpen)
            {
                Height += k_ShowMoreInfoFormWidthChange;
                m_isShowMoreInfoOpen = true;
                buttonShowMoreInfo.Text = "Close Info";

            }
            else
            {
                Height -= k_ShowMoreInfoFormWidthChange;
                m_isShowMoreInfoOpen = false;
                buttonShowMoreInfo.Text = "⇊  ⇊  ShowMoreInfo  ⇊  ⇊";
            }
            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            showAccountBoardStartPageInfo();

        }

        private void showAccountBoardStartPageInfo()
        {
            pictureBoxUserSmallPicture.LoadAsync(LoggedInUser.PictureNormalURL);
            labelUserName.Text = LoggedInUser.Name;
            foreach (User friend in LoggedInUser.Friends)
            {
                listBoxFriends.Items.Add(friend.Name);
            }
            foreach (Checkin checkin in LoggedInUser.Checkins)
            {
                listBoxCheckIns.Items.Add(checkin.Place.Name);
            }
        }


        protected override void OnShown(EventArgs e)
        {
            showPostsOnForm();
            showEventsOnForm();
        }


        private void showPostsOnForm()
        {

            foreach (var post in LoggedInUser.WallPosts)
            {
                AppPostsList.Add(new ApplicationPost(post));

            }
            dataGridViewPosts.DataSource = AppPostsList;

        }
        private void showEventsOnForm()
        {

            foreach (var FBevent in LoggedInUser.Events )
            {
                AppEventsList.Add(new ApplicationEvent(FBevent));

            }
            dataGridViewEvents.DataSource = AppEventsList;

        }

        private void buttonComments_Click(object sender, EventArgs e)
        {

            m_ChosedCommentsForm = new FormCommentList(m_selectedGridItemCommentsList);
           m_ChosedCommentsForm.ShowDialog();
        }


        private void dataGridViewTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridViewTab.SelectedTab.Name.Equals("tabPageEvents"))
            {
                buttonComments.Visible = false;
            }
            else if (dataGridViewTab.SelectedTab.Name.Equals("tabPagePosts"))
            {
                buttonComments.Visible = true;
            }


        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            if (textBoxPostStatus.Text.Length != 0)
            {
                LoggedInUser.PostStatus(textBoxPostStatus.Text);
                textBoxPostStatus.Clear();
            }
        }
    }

}
