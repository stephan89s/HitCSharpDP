using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    public partial class FormFacebookAccountBoard : Form
    {
        public User LoggedInUser
        {
            get; set;
        }
        public List<IPublishable> AppPostsList
        {
            get;
        }
        public List<IPublishable> AppEventsList
        {
            get;
        }
        public List<ApplicationComment> SelectedGridItemCommentsList
        {
            get;
        }
        private bool m_isShowMoreInfoOpen = false;

        public FormFacebookAccountBoard(User i_LoggedInUser)
        {
            LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            AppPostsList = new List<IPublishable>();
            AppEventsList = new List<IPublishable>();
            SelectedGridItemCommentsList = new List<ApplicationComment>();
            Text = string.Format("Logged In as {0}", i_LoggedInUser.Name);
        }


        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;

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
            SelectedGridItemCommentsList.Clear();
            int rowIndex = dataGridViewPosts.CurrentCell.RowIndex;
            string ItemID = ((List<ApplicationPost>)dataGridViewPosts.DataSource)[rowIndex].GetPublishedItemID();

            foreach (var post in LoggedInUser.WallPosts)
            {
                if (post.Id.Equals(ItemID))
                {
                    foreach (var comment in post.Comments)
                    {
                        SelectedGridItemCommentsList.Add(new ApplicationComment(comment));
                    }
                    break;
                }

            }
            buttonGoToURL.Enabled = !string.IsNullOrEmpty(((List<ApplicationPost>)dataGridViewPosts.DataSource)[rowIndex].Link);
            buttonCommentsStatistics.Enabled = SelectedGridItemCommentsList.Count > 0 ? true : false;
            buttonCommentsStatistics.Text = string.Format("Comments ({0})", SelectedGridItemCommentsList.Count);
        }



        private void buttonShowMoreInfo_Click(object sender, EventArgs e)
        {
            const int k_ShowMoreInfoFormWidthChange = 300;
            if (!m_isShowMoreInfoOpen)
            {
                Height += k_ShowMoreInfoFormWidthChange;
                buttonShowMoreInfo.Text = "Close Info";
            }
            else
            {
                Height -= k_ShowMoreInfoFormWidthChange;
                buttonShowMoreInfo.Text = "⇊  ⇊  ShowMoreInfo  ⇊  ⇊";
            }
            tabControlShowMoreInfo.Visible = !tabControlShowMoreInfo.Visible;
            m_isShowMoreInfoOpen = !m_isShowMoreInfoOpen;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitializeAccountBoard();

        }

        private void InitializeAccountBoard()
        {
            showFriendsList();
            showPostsOnForm();
            showEventsOnForm();
        }
        private void showFriendsList()
        {
            pictureBoxUserSmallPicture.LoadAsync(LoggedInUser.PictureNormalURL);
            labelUserName.Text = LoggedInUser.Name;
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = nameof(User.Name);
            string g = nameof(Checkin.Name);
            foreach (User friend in LoggedInUser.Friends)
            {
                listBoxFriends.Items.Add(friend);
            }
        }


        private void showPostsOnForm()
        {
            AppPostsList.Clear();
            foreach (var post in LoggedInUser.WallPosts)
            {
                AppPostsList.Add(new ApplicationPost(post));

            }

            dataGridViewPosts.DataSource = AppPostsList.ConvertAll(post => (ApplicationPost)post);

        }
        private void showEventsOnForm()
        {
            AppEventsList.Clear();
            foreach (var FBevent in LoggedInUser.Events)
            {
                AppEventsList.Add(new ApplicationEvent(FBevent));

            }
            dataGridViewEvents.DataSource = AppEventsList.ConvertAll(post => (ApplicationEvent)post);


        }

        private void buttonCommentsStatistics_Click(object sender, EventArgs e)
        {
            if (tabControlShowMoreInfo.SelectedTab.Name.Equals(tabPagePosts.Name))
            {
                new FormCommentList(SelectedGridItemCommentsList).ShowDialog();
            }
            else if (tabControlShowMoreInfo.SelectedTab.Name.Equals(tabPageEvents.Name))
            {
                new FormEventsStatistics(AppEventsList.ConvertAll(post => (ApplicationEvent)(post))).ShowDialog();
            }


        }


        private void dataGridViewTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlShowMoreInfo.SelectedTab.Name.Equals(tabPageEvents.Name))
            {

                buttonCommentsStatistics.Text = "7 Days Statistics";
                buttonCommentsStatistics.Enabled = AppEventsList.Count != 0;
            }
            else if (tabControlShowMoreInfo.SelectedTab.Name.Equals(tabPagePosts.Name))
            {

                dataGridViewPosts.ClearSelection();
                dataGridViewPosts.FirstDisplayedScrollingRowIndex = 0;
                SelectedGridItemCommentsList.Clear();
                buttonCommentsStatistics.Text = "Comments (0)";
                buttonCommentsStatistics.Enabled = false;



            }


        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            if (textBoxPostStatus.Text.Length != 0)
            {
                LoggedInUser.PostStatus(textBoxPostStatus.Text);
                textBoxPostStatus.Clear();
                LoggedInUser.ReFetch();
                showPostsOnForm();
            }

        }




        private void gridFilter()
        {

            if (tabControlShowMoreInfo.SelectedTab.Name.Equals(tabPagePosts.Name))
            {
                refreshPostGrid();
            }
            else if (tabControlShowMoreInfo.SelectedTab.Name.Equals(tabPageEvents.Name))
            {
                refreshEventGrid();
            }
        }

        private void refreshEventGrid()
        {
            string containText = textBoxEventMessageFilter.Text;
            string containsName = textBoxEventFromFilter.Text;
            bool isDateSelectedAndMatch;
            List<IPublishable> filtredList = new List<IPublishable>();
            foreach (IPublishable fbevent in AppEventsList)
            {
                ApplicationEvent appEvent = (ApplicationEvent)fbevent;
                isDateSelectedAndMatch = checkBoxEventStartDateFilter.Checked ? appEvent.StartTime.Value.Date.Equals(dateTimePickerEventStartDate.Value.Date) : true;
                if (appEvent.Name.IndexOf(containsName, StringComparison.OrdinalIgnoreCase) > -1
                    && appEvent.Description.IndexOf(containText, StringComparison.OrdinalIgnoreCase) > -1 && isDateSelectedAndMatch)
                {
                    filtredList.Add(fbevent);

                }
            }

            dataGridViewEvents.DataSource = filtredList.ConvertAll(fbEvent => (ApplicationEvent)(fbEvent));
        }


        private void refreshPostGrid()
        {

            string containText = textBoxPostMessageFilter.Text;
            string containsName = textBoxPostFromFilter.Text;
            bool isDateSelectedAndMatch;
            List<IPublishable> filtredList = new List<IPublishable>();
            foreach (IPublishable post in AppPostsList)
            {
                ApplicationPost appPost = (ApplicationPost)post;
                isDateSelectedAndMatch = checkBoxPostDateFilter.Checked ? appPost.CreatedTime.Value.Date.Equals(dateTimePickerPostDate.Value.Date) : true;
                if (appPost.Message.IndexOf(containText, StringComparison.OrdinalIgnoreCase) > -1 && appPost.From.IndexOf(containsName, StringComparison.OrdinalIgnoreCase) > -1
                    && isDateSelectedAndMatch)

                {
                    filtredList.Add(post);

                }
            }

            dataGridViewPosts.DataSource = filtredList.ConvertAll(post => (ApplicationPost)(post));
        }


        private void buttonRefreshTable_Click(object sender, EventArgs e)
        {
            LoggedInUser.ReFetch();
            textBoxEventFromFilter.Clear();
            textBoxEventMessageFilter.Clear();
            textBoxPostFromFilter.Clear();
            textBoxPostMessageFilter.Clear();
            InitializeAccountBoard();
        }

        private void checkBoxEventStartDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                dateTimePickerFilter(checkBox, dateTimePickerEventStartDate);
            }

        }
        private void dateTimePickerFilter(CheckBox i_CheckBox, DateTimePicker i_DatePicker)
        {

            i_DatePicker.Enabled = i_CheckBox.Checked;

            gridFilter();
            if (!i_CheckBox.Checked)
            {
                i_DatePicker.Value = DateTime.Now;
            }

        }

        private void checkBoxPostDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                dateTimePickerFilter(checkBox, dateTimePickerPostDate);
            }
        }

        private void buttonGoToURL_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewPosts.CurrentCell.RowIndex;

            System.Diagnostics.Process.Start(((List<ApplicationPost>)dataGridViewPosts.DataSource)[rowIndex].Link);
        }

        private void filterField_ValueChange(object sender, EventArgs e)
        {
            gridFilter();
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFriends.SelectedItems.Count == 1)
            {
                if (((User)listBoxFriends.SelectedItem).PictureNormalURL != null)
                {
                    pictureBoxFriendsPic.LoadAsync(((User)listBoxFriends.SelectedItem).PictureNormalURL);

                }
                else
                {
                    pictureBoxFriendsPic.Image = pictureBoxFriendsPic.ErrorImage;
                }
            }
        }

        private void listBoxFriends_Leave(object sender, EventArgs e)
        {
            pictureBoxFriendsPic.Image = null;

        }


    }

}
