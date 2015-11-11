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
        public User LoggedInUser { get; set; }
        public List<IPublishable> AppPostsList { get; }
        public List<IPublishable> AppEventsList { get; }
        public List<ApplicationComment> SelectedGridItemCommentsList { get; }
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
            SelectedGridItemCommentsList.Clear();
            int rowIndex = dataGridViewPosts.CurrentCell.RowIndex;
            string ItemID = ((List<ApplicationPost>)dataGridViewPosts.DataSource)[rowIndex].GetPublishedItemID();

            foreach (var post in LoggedInUser.Posts)
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
            buttonComments.Enabled = SelectedGridItemCommentsList.Count > 0 ? true : false;
            buttonComments.Text = string.Format("Comments ({0})", SelectedGridItemCommentsList.Count);
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
            showAccountBoardStartPageInfo();
            showPostsOnForm();
            showEventsOnForm();
        }
        private void showAccountBoardStartPageInfo()
        {
            pictureBoxUserSmallPicture.LoadAsync(LoggedInUser.PictureNormalURL);
            labelUserName.Text = LoggedInUser.Name;
            listBoxFriends.Items.Clear();
            listBoxCheckIns.Items.Clear();
            foreach (User friend in LoggedInUser.Friends)
            {
                listBoxFriends.Items.Add(friend.Name);
            }
            foreach (Checkin checkin in LoggedInUser.Checkins)
            {
                listBoxCheckIns.Items.Add(checkin.Place.Name);
            }
        }


        private void showPostsOnForm()
        {
            AppPostsList.Clear();
            foreach (var post in LoggedInUser.Posts)
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

        private void buttonComments_Click(object sender, EventArgs e)
        {

            new FormCommentList(SelectedGridItemCommentsList).ShowDialog();

        }


        private void dataGridViewTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlShowMoreInfo.SelectedTab.Name.Equals("tabPageEvents"))
            {
                buttonComments.Visible = false;
            }
            else if (tabControlShowMoreInfo.SelectedTab.Name.Equals("tabPagePosts"))
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
                LoggedInUser.ReFetch();
                showPostsOnForm();
            }

        }



        private void gridFilter()
        {
            string containText;
            string containsName;
            DateTime? dateField = null;
            bool isDateSelectedAndMatch;


            List<IPublishable> filtredList = new List<IPublishable>();
            if (tabControlShowMoreInfo.SelectedTab.Name.Equals(tabPagePosts.Name))
            {

                containText = textBoxPostMessageFilter.Text;
                containsName = textBoxPostFromFilter.Text;
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
            else if (tabControlShowMoreInfo.SelectedTab.Name.Equals(tabPageEvents.Name))
            {

                containText = textBoxEventMessageFilter.Text;
                containsName = textBoxEventFromFilter.Text;
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
        }

        private void textBoxPostMessageFilter_TextChanged(object sender, EventArgs e)
        {
            gridFilter();

        }

        private void textBoxPostFromFilter_TextChanged(object sender, EventArgs e)
        {
            gridFilter();
        }

        private void textBoxEventMessageFilter_TextChanged(object sender, EventArgs e)
        {
            gridFilter();
        }

        private void textBoxEventFromFilter_TextChanged(object sender, EventArgs e)
        {

            gridFilter();
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

        private void dateTimePickerPostDate_ValueChanged(object sender, EventArgs e)
        {
            gridFilter();
        }

        private void dateTimePickerEventStartDate_ValueChanged(object sender, EventArgs e)
        {
            gridFilter();
        }

        private void buttonGoToURL_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewPosts.CurrentCell.RowIndex;

            System.Diagnostics.Process.Start(((List<ApplicationPost>)dataGridViewPosts.DataSource)[rowIndex].Link);
        }
    }

}
