﻿namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    partial class FormFacebookAccountBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacebookAccountBoard));
            this.buttonCommentsStatistics = new System.Windows.Forms.Button();
            this.buttonShowMoreInfo = new System.Windows.Forms.Button();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.textBoxPostStatus = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.pictureBoxUserSmallPicture = new System.Windows.Forms.PictureBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonRefreshTable = new System.Windows.Forms.Button();
            this.tabPageEvents = new System.Windows.Forms.TabPage();
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.groupBoxEventsFilter = new System.Windows.Forms.GroupBox();
            this.checkBoxEventStartDateFilter = new System.Windows.Forms.CheckBox();
            this.dateTimePickerEventStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxEventMessageFilter = new System.Windows.Forms.TextBox();
            this.textBoxEventFromFilter = new System.Windows.Forms.TextBox();
            this.tabPagePosts = new System.Windows.Forms.TabPage();
            this.dataGridViewPosts = new System.Windows.Forms.DataGridView();
            this.groupBoxPostFilters = new System.Windows.Forms.GroupBox();
            this.checkBoxPostDateFilter = new System.Windows.Forms.CheckBox();
            this.dateTimePickerPostDate = new System.Windows.Forms.DateTimePicker();
            this.labelContentFilter = new System.Windows.Forms.Label();
            this.labelNameFilter = new System.Windows.Forms.Label();
            this.textBoxPostMessageFilter = new System.Windows.Forms.TextBox();
            this.textBoxPostFromFilter = new System.Windows.Forms.TextBox();
            this.tabControlShowMoreInfo = new System.Windows.Forms.TabControl();
            this.buttonGoToURL = new System.Windows.Forms.Button();
            this.pictureBoxFriendsPic = new System.Windows.Forms.PictureBox();
            this.groupBoxFriends = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserSmallPicture)).BeginInit();
            this.tabPageEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            this.groupBoxEventsFilter.SuspendLayout();
            this.tabPagePosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosts)).BeginInit();
            this.groupBoxPostFilters.SuspendLayout();
            this.tabControlShowMoreInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendsPic)).BeginInit();
            this.groupBoxFriends.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCommentsStatistics
            // 
            this.buttonCommentsStatistics.Enabled = false;
            this.buttonCommentsStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCommentsStatistics.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCommentsStatistics.Location = new System.Drawing.Point(293, 629);
            this.buttonCommentsStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCommentsStatistics.Name = "buttonCommentsStatistics";
            this.buttonCommentsStatistics.Size = new System.Drawing.Size(161, 28);
            this.buttonCommentsStatistics.TabIndex = 24;
            this.buttonCommentsStatistics.Text = "Comments (0)";
            this.buttonCommentsStatistics.UseVisualStyleBackColor = true;
            this.buttonCommentsStatistics.Click += new System.EventHandler(this.buttonCommentsStatistics_Click);
            // 
            // buttonShowMoreInfo
            // 
            this.buttonShowMoreInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShowMoreInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowMoreInfo.Location = new System.Drawing.Point(78, 236);
            this.buttonShowMoreInfo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowMoreInfo.Name = "buttonShowMoreInfo";
            this.buttonShowMoreInfo.Size = new System.Drawing.Size(752, 32);
            this.buttonShowMoreInfo.TabIndex = 21;
            this.buttonShowMoreInfo.Text = "⇊  ⇊  ShowMoreInfo  ⇊  ⇊";
            this.buttonShowMoreInfo.UseVisualStyleBackColor = true;
            this.buttonShowMoreInfo.Click += new System.EventHandler(this.buttonShowMoreInfo_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(101, 22);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(231, 84);
            this.listBoxFriends.TabIndex = 19;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            this.listBoxFriends.Leave += new System.EventHandler(this.listBoxFriends_Leave);
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPostStatus.Location = new System.Drawing.Point(737, 148);
            this.buttonPostStatus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(143, 62);
            this.buttonPostStatus.TabIndex = 18;
            this.buttonPostStatus.Text = "Post New Status";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // textBoxPostStatus
            // 
            this.textBoxPostStatus.Location = new System.Drawing.Point(216, 148);
            this.textBoxPostStatus.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPostStatus.Multiline = true;
            this.textBoxPostStatus.Name = "textBoxPostStatus";
            this.textBoxPostStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPostStatus.Size = new System.Drawing.Size(522, 62);
            this.textBoxPostStatus.TabIndex = 17;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(20, 5);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(120, 27);
            this.labelUserName.TabIndex = 16;
            this.labelUserName.Text = "User Name";
            // 
            // pictureBoxUserSmallPicture
            // 
            this.pictureBoxUserSmallPicture.Location = new System.Drawing.Point(13, 45);
            this.pictureBoxUserSmallPicture.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxUserSmallPicture.Name = "pictureBoxUserSmallPicture";
            this.pictureBoxUserSmallPicture.Size = new System.Drawing.Size(179, 165);
            this.pictureBoxUserSmallPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUserSmallPicture.TabIndex = 15;
            this.pictureBoxUserSmallPicture.TabStop = false;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(814, 11);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(88, 28);
            this.buttonLogOut.TabIndex = 30;
            this.buttonLogOut.Text = "LogOut";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonRefreshTable
            // 
            this.buttonRefreshTable.Location = new System.Drawing.Point(721, 11);
            this.buttonRefreshTable.Name = "buttonRefreshTable";
            this.buttonRefreshTable.Size = new System.Drawing.Size(88, 28);
            this.buttonRefreshTable.TabIndex = 29;
            this.buttonRefreshTable.Text = "Refresh";
            this.buttonRefreshTable.UseVisualStyleBackColor = true;
            this.buttonRefreshTable.Click += new System.EventHandler(this.buttonRefreshTable_Click);
            // 
            // tabPageEvents
            // 
            this.tabPageEvents.Controls.Add(this.dataGridViewEvents);
            this.tabPageEvents.Controls.Add(this.groupBoxEventsFilter);
            this.tabPageEvents.Location = new System.Drawing.Point(4, 26);
            this.tabPageEvents.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageEvents.Name = "tabPageEvents";
            this.tabPageEvents.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageEvents.Size = new System.Drawing.Size(878, 294);
            this.tabPageEvents.TabIndex = 0;
            this.tabPageEvents.Text = "Events";
            this.tabPageEvents.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEvents.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Location = new System.Drawing.Point(9, 86);
            this.dataGridViewEvents.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEvents.MultiSelect = false;
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.RowHeadersVisible = false;
            this.dataGridViewEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEvents.Size = new System.Drawing.Size(861, 193);
            this.dataGridViewEvents.TabIndex = 29;
            // 
            // groupBoxEventsFilter
            // 
            this.groupBoxEventsFilter.Controls.Add(this.checkBoxEventStartDateFilter);
            this.groupBoxEventsFilter.Controls.Add(this.dateTimePickerEventStartDate);
            this.groupBoxEventsFilter.Controls.Add(this.labelMessage);
            this.groupBoxEventsFilter.Controls.Add(this.labelName);
            this.groupBoxEventsFilter.Controls.Add(this.textBoxEventMessageFilter);
            this.groupBoxEventsFilter.Controls.Add(this.textBoxEventFromFilter);
            this.groupBoxEventsFilter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEventsFilter.Location = new System.Drawing.Point(8, 8);
            this.groupBoxEventsFilter.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEventsFilter.Name = "groupBoxEventsFilter";
            this.groupBoxEventsFilter.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEventsFilter.Size = new System.Drawing.Size(862, 70);
            this.groupBoxEventsFilter.TabIndex = 30;
            this.groupBoxEventsFilter.TabStop = false;
            this.groupBoxEventsFilter.Text = "Filters";
            // 
            // checkBoxEventStartDateFilter
            // 
            this.checkBoxEventStartDateFilter.AutoSize = true;
            this.checkBoxEventStartDateFilter.Location = new System.Drawing.Point(590, 34);
            this.checkBoxEventStartDateFilter.Name = "checkBoxEventStartDateFilter";
            this.checkBoxEventStartDateFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxEventStartDateFilter.Size = new System.Drawing.Size(93, 21);
            this.checkBoxEventStartDateFilter.TabIndex = 6;
            this.checkBoxEventStartDateFilter.Text = "Start Date";
            this.checkBoxEventStartDateFilter.UseVisualStyleBackColor = true;
            this.checkBoxEventStartDateFilter.CheckedChanged += new System.EventHandler(this.checkBoxEventStartDateFilter_CheckedChanged);
            // 
            // dateTimePickerEventStartDate
            // 
            this.dateTimePickerEventStartDate.Enabled = false;
            this.dateTimePickerEventStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEventStartDate.Location = new System.Drawing.Point(692, 30);
            this.dateTimePickerEventStartDate.Name = "dateTimePickerEventStartDate";
            this.dateTimePickerEventStartDate.Size = new System.Drawing.Size(163, 24);
            this.dateTimePickerEventStartDate.TabIndex = 4;
            this.dateTimePickerEventStartDate.ValueChanged += new System.EventHandler(this.filterField_ValueChange);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(293, 35);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(64, 17);
            this.labelMessage.TabIndex = 3;
            this.labelMessage.Text = "Message:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(8, 35);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(48, 17);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // textBoxEventMessageFilter
            // 
            this.textBoxEventMessageFilter.Location = new System.Drawing.Point(365, 32);
            this.textBoxEventMessageFilter.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEventMessageFilter.Name = "textBoxEventMessageFilter";
            this.textBoxEventMessageFilter.Size = new System.Drawing.Size(185, 24);
            this.textBoxEventMessageFilter.TabIndex = 1;
            this.textBoxEventMessageFilter.TextChanged += new System.EventHandler(this.filterField_ValueChange);
            // 
            // textBoxEventFromFilter
            // 
            this.textBoxEventFromFilter.Location = new System.Drawing.Point(61, 32);
            this.textBoxEventFromFilter.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEventFromFilter.Name = "textBoxEventFromFilter";
            this.textBoxEventFromFilter.Size = new System.Drawing.Size(191, 24);
            this.textBoxEventFromFilter.TabIndex = 0;
            this.textBoxEventFromFilter.TextChanged += new System.EventHandler(this.filterField_ValueChange);
            // 
            // tabPagePosts
            // 
            this.tabPagePosts.Controls.Add(this.dataGridViewPosts);
            this.tabPagePosts.Controls.Add(this.groupBoxPostFilters);
            this.tabPagePosts.Location = new System.Drawing.Point(4, 26);
            this.tabPagePosts.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagePosts.Name = "tabPagePosts";
            this.tabPagePosts.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagePosts.Size = new System.Drawing.Size(878, 294);
            this.tabPagePosts.TabIndex = 2;
            this.tabPagePosts.Text = "Posts";
            this.tabPagePosts.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPosts
            // 
            this.dataGridViewPosts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPosts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPosts.Location = new System.Drawing.Point(9, 86);
            this.dataGridViewPosts.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPosts.MultiSelect = false;
            this.dataGridViewPosts.Name = "dataGridViewPosts";
            this.dataGridViewPosts.RowHeadersVisible = false;
            this.dataGridViewPosts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPosts.Size = new System.Drawing.Size(861, 193);
            this.dataGridViewPosts.TabIndex = 1;
            this.dataGridViewPosts.SelectionChanged += new System.EventHandler(this.dataGridViewPosts_SelectionChanged);
            // 
            // groupBoxPostFilters
            // 
            this.groupBoxPostFilters.Controls.Add(this.checkBoxPostDateFilter);
            this.groupBoxPostFilters.Controls.Add(this.dateTimePickerPostDate);
            this.groupBoxPostFilters.Controls.Add(this.labelContentFilter);
            this.groupBoxPostFilters.Controls.Add(this.labelNameFilter);
            this.groupBoxPostFilters.Controls.Add(this.textBoxPostMessageFilter);
            this.groupBoxPostFilters.Controls.Add(this.textBoxPostFromFilter);
            this.groupBoxPostFilters.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPostFilters.Location = new System.Drawing.Point(8, 8);
            this.groupBoxPostFilters.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxPostFilters.Name = "groupBoxPostFilters";
            this.groupBoxPostFilters.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxPostFilters.Size = new System.Drawing.Size(862, 70);
            this.groupBoxPostFilters.TabIndex = 28;
            this.groupBoxPostFilters.TabStop = false;
            this.groupBoxPostFilters.Text = "Filters";
            // 
            // checkBoxPostDateFilter
            // 
            this.checkBoxPostDateFilter.AutoSize = true;
            this.checkBoxPostDateFilter.Location = new System.Drawing.Point(593, 34);
            this.checkBoxPostDateFilter.Name = "checkBoxPostDateFilter";
            this.checkBoxPostDateFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxPostDateFilter.Size = new System.Drawing.Size(90, 21);
            this.checkBoxPostDateFilter.TabIndex = 7;
            this.checkBoxPostDateFilter.Text = "Post Date";
            this.checkBoxPostDateFilter.UseVisualStyleBackColor = true;
            this.checkBoxPostDateFilter.CheckedChanged += new System.EventHandler(this.checkBoxPostDateFilter_CheckedChanged);
            // 
            // dateTimePickerPostDate
            // 
            this.dateTimePickerPostDate.Enabled = false;
            this.dateTimePickerPostDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPostDate.Location = new System.Drawing.Point(692, 30);
            this.dateTimePickerPostDate.Name = "dateTimePickerPostDate";
            this.dateTimePickerPostDate.Size = new System.Drawing.Size(163, 24);
            this.dateTimePickerPostDate.TabIndex = 4;
            this.dateTimePickerPostDate.ValueChanged += new System.EventHandler(this.filterField_ValueChange);
            // 
            // labelContentFilter
            // 
            this.labelContentFilter.AutoSize = true;
            this.labelContentFilter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContentFilter.Location = new System.Drawing.Point(293, 35);
            this.labelContentFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContentFilter.Name = "labelContentFilter";
            this.labelContentFilter.Size = new System.Drawing.Size(64, 17);
            this.labelContentFilter.TabIndex = 3;
            this.labelContentFilter.Text = "Message:";
            // 
            // labelNameFilter
            // 
            this.labelNameFilter.AutoSize = true;
            this.labelNameFilter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameFilter.Location = new System.Drawing.Point(8, 35);
            this.labelNameFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameFilter.Name = "labelNameFilter";
            this.labelNameFilter.Size = new System.Drawing.Size(45, 17);
            this.labelNameFilter.TabIndex = 2;
            this.labelNameFilter.Text = "From:";
            // 
            // textBoxPostMessageFilter
            // 
            this.textBoxPostMessageFilter.Location = new System.Drawing.Point(365, 32);
            this.textBoxPostMessageFilter.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPostMessageFilter.Name = "textBoxPostMessageFilter";
            this.textBoxPostMessageFilter.Size = new System.Drawing.Size(185, 24);
            this.textBoxPostMessageFilter.TabIndex = 1;
            this.textBoxPostMessageFilter.TextChanged += new System.EventHandler(this.filterField_ValueChange);
            // 
            // textBoxPostFromFilter
            // 
            this.textBoxPostFromFilter.Location = new System.Drawing.Point(61, 32);
            this.textBoxPostFromFilter.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPostFromFilter.Name = "textBoxPostFromFilter";
            this.textBoxPostFromFilter.Size = new System.Drawing.Size(191, 24);
            this.textBoxPostFromFilter.TabIndex = 0;
            this.textBoxPostFromFilter.TextChanged += new System.EventHandler(this.filterField_ValueChange);
            // 
            // tabControlShowMoreInfo
            // 
            this.tabControlShowMoreInfo.Controls.Add(this.tabPagePosts);
            this.tabControlShowMoreInfo.Controls.Add(this.tabPageEvents);
            this.tabControlShowMoreInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlShowMoreInfo.Location = new System.Drawing.Point(13, 276);
            this.tabControlShowMoreInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlShowMoreInfo.Name = "tabControlShowMoreInfo";
            this.tabControlShowMoreInfo.SelectedIndex = 0;
            this.tabControlShowMoreInfo.Size = new System.Drawing.Size(886, 324);
            this.tabControlShowMoreInfo.TabIndex = 22;
            this.tabControlShowMoreInfo.Visible = false;
            this.tabControlShowMoreInfo.SelectedIndexChanged += new System.EventHandler(this.dataGridViewTab_SelectedIndexChanged);
            // 
            // buttonGoToURL
            // 
            this.buttonGoToURL.Enabled = false;
            this.buttonGoToURL.Location = new System.Drawing.Point(17, 629);
            this.buttonGoToURL.Name = "buttonGoToURL";
            this.buttonGoToURL.Size = new System.Drawing.Size(158, 28);
            this.buttonGoToURL.TabIndex = 31;
            this.buttonGoToURL.Text = "Go To URL";
            this.buttonGoToURL.UseVisualStyleBackColor = true;
            this.buttonGoToURL.Click += new System.EventHandler(this.buttonGoToURL_Click);
            // 
            // pictureBoxFriendsPic
            // 
            this.pictureBoxFriendsPic.Location = new System.Drawing.Point(6, 22);
            this.pictureBoxFriendsPic.Name = "pictureBoxFriendsPic";
            this.pictureBoxFriendsPic.Size = new System.Drawing.Size(88, 88);
            this.pictureBoxFriendsPic.TabIndex = 32;
            this.pictureBoxFriendsPic.TabStop = false;
            // 
            // groupBoxFriends
            // 
            this.groupBoxFriends.Controls.Add(this.pictureBoxFriendsPic);
            this.groupBoxFriends.Controls.Add(this.listBoxFriends);
            this.groupBoxFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFriends.Location = new System.Drawing.Point(216, 24);
            this.groupBoxFriends.Name = "groupBoxFriends";
            this.groupBoxFriends.Size = new System.Drawing.Size(338, 117);
            this.groupBoxFriends.TabIndex = 33;
            this.groupBoxFriends.TabStop = false;
            this.groupBoxFriends.Text = "Friends";
            // 
            // FormFacebookAccountBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 699);
            this.Controls.Add(this.groupBoxFriends);
            this.Controls.Add(this.buttonGoToURL);
            this.Controls.Add(this.buttonRefreshTable);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonCommentsStatistics);
            this.Controls.Add(this.tabControlShowMoreInfo);
            this.Controls.Add(this.buttonShowMoreInfo);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.textBoxPostStatus);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.pictureBoxUserSmallPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormFacebookAccountBoard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserSmallPicture)).EndInit();
            this.tabPageEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            this.groupBoxEventsFilter.ResumeLayout(false);
            this.groupBoxEventsFilter.PerformLayout();
            this.tabPagePosts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosts)).EndInit();
            this.groupBoxPostFilters.ResumeLayout(false);
            this.groupBoxPostFilters.PerformLayout();
            this.tabControlShowMoreInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendsPic)).EndInit();
            this.groupBoxFriends.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCommentsStatistics;
        private System.Windows.Forms.Button buttonShowMoreInfo;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.TextBox textBoxPostStatus;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.PictureBox pictureBoxUserSmallPicture;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonRefreshTable;
        private System.Windows.Forms.TabPage tabPageEvents;
        private System.Windows.Forms.DataGridView dataGridViewEvents;
        private System.Windows.Forms.GroupBox groupBoxEventsFilter;
        private System.Windows.Forms.DateTimePicker dateTimePickerEventStartDate;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxEventMessageFilter;
        private System.Windows.Forms.TextBox textBoxEventFromFilter;
        private System.Windows.Forms.TabPage tabPagePosts;
        private System.Windows.Forms.DataGridView dataGridViewPosts;
        private System.Windows.Forms.GroupBox groupBoxPostFilters;
        private System.Windows.Forms.DateTimePicker dateTimePickerPostDate;
        private System.Windows.Forms.Label labelContentFilter;
        private System.Windows.Forms.Label labelNameFilter;
        private System.Windows.Forms.TextBox textBoxPostMessageFilter;
        private System.Windows.Forms.TextBox textBoxPostFromFilter;
        private System.Windows.Forms.TabControl tabControlShowMoreInfo;
        private System.Windows.Forms.CheckBox checkBoxEventStartDateFilter;
        private System.Windows.Forms.CheckBox checkBoxPostDateFilter;
        private System.Windows.Forms.Button buttonGoToURL;
        private System.Windows.Forms.PictureBox pictureBoxFriendsPic;
        private System.Windows.Forms.GroupBox groupBoxFriends;
    }
}