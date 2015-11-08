﻿using FacebookWrapper.ObjectModel;
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
        public List<ApplicationPost> AppPostList { get; }
        public List<ApplicationComment> selectedPostCommentsList;
        public FormFacebookAccountBoard(User i_LoggedInUser)
        {
            LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            AppPostList = new List<ApplicationPost>();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);        
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
            showPostsOnForm();

        }

        private void showPostsOnForm()
        {
           
            foreach (var post in LoggedInUser.WallPosts)
            {
                AppPostList.Add(new ApplicationPost(post));

            }
            dataGridViewPosts.DataSource = AppPostList;

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
            selectedPostCommentsList = new List<ApplicationComment>();
            int rowIndex = dataGridViewPosts.CurrentCell.RowIndex;
            string postID = ((List<ApplicationPost>)dataGridViewPosts.DataSource)[rowIndex].getPostID();

            foreach(var post in LoggedInUser.WallPosts)
            {
                if(post.Id.Equals(postID))
                {
                    foreach (var comment in post.Comments)
                    {
                        selectedPostCommentsList.Add(new ApplicationComment(comment));
                    }
                    break;
                }
                
            }
            
                buttonComments.Enabled = selectedPostCommentsList.Count > 0? true : false;
            buttonComments.Text = string.Format("Comments ({0})", selectedPostCommentsList.Count);
        }
    }
}
