namespace A16_Ex01_Stephan_321178253_Alex_323260620
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
            this.labelCheckIns = new System.Windows.Forms.Label();
            this.listBoxCheckIns = new System.Windows.Forms.ListBox();
            this.buttonCloseTab = new System.Windows.Forms.Button();
            this.buttonComments = new System.Windows.Forms.Button();
            this.buttonLinkToUrl = new System.Windows.Forms.Button();
            this.tabControlAllNews = new System.Windows.Forms.TabControl();
            this.tabPagePosts = new System.Windows.Forms.TabPage();
            this.dataGridViewPosts = new System.Windows.Forms.DataGridView();
            this.groupBoxFFilters = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelContentFilter = new System.Windows.Forms.Label();
            this.labelNameFilter = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPageEvents = new System.Windows.Forms.TabPage();
            this.buttonShowMoreInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.textBoxPostStatus = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.pictureBoxUserSmallPicture = new System.Windows.Forms.PictureBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonRefreshTable = new System.Windows.Forms.Button();
            this.tabControlAllNews.SuspendLayout();
            this.tabPagePosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosts)).BeginInit();
            this.groupBoxFFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserSmallPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCheckIns
            // 
            this.labelCheckIns.AutoSize = true;
            this.labelCheckIns.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckIns.Location = new System.Drawing.Point(456, 20);
            this.labelCheckIns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCheckIns.Name = "labelCheckIns";
            this.labelCheckIns.Size = new System.Drawing.Size(110, 30);
            this.labelCheckIns.TabIndex = 29;
            this.labelCheckIns.Text = "Checkins";
            // 
            // listBoxCheckIns
            // 
            this.listBoxCheckIns.FormattingEnabled = true;
            this.listBoxCheckIns.ItemHeight = 16;
            this.listBoxCheckIns.Location = new System.Drawing.Point(404, 54);
            this.listBoxCheckIns.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCheckIns.Name = "listBoxCheckIns";
            this.listBoxCheckIns.Size = new System.Drawing.Size(209, 164);
            this.listBoxCheckIns.TabIndex = 28;
            // 
            // buttonCloseTab
            // 
            this.buttonCloseTab.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCloseTab.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseTab.Location = new System.Drawing.Point(799, 692);
            this.buttonCloseTab.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCloseTab.Name = "buttonCloseTab";
            this.buttonCloseTab.Size = new System.Drawing.Size(100, 28);
            this.buttonCloseTab.TabIndex = 25;
            this.buttonCloseTab.Text = "button3";
            this.buttonCloseTab.UseVisualStyleBackColor = true;
            // 
            // buttonComments
            // 
            this.buttonComments.Enabled = false;
            this.buttonComments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonComments.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComments.Location = new System.Drawing.Point(154, 692);
            this.buttonComments.Margin = new System.Windows.Forms.Padding(4);
            this.buttonComments.Name = "buttonComments";
            this.buttonComments.Size = new System.Drawing.Size(139, 28);
            this.buttonComments.TabIndex = 24;
            this.buttonComments.Text = "Comments (0)";
            this.buttonComments.UseVisualStyleBackColor = true;
            this.buttonComments.Click += new System.EventHandler(this.buttonComments_Click);
            // 
            // buttonLinkToUrl
            // 
            this.buttonLinkToUrl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLinkToUrl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLinkToUrl.Location = new System.Drawing.Point(13, 692);
            this.buttonLinkToUrl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLinkToUrl.Name = "buttonLinkToUrl";
            this.buttonLinkToUrl.Size = new System.Drawing.Size(100, 28);
            this.buttonLinkToUrl.TabIndex = 23;
            this.buttonLinkToUrl.Text = "button1";
            this.buttonLinkToUrl.UseVisualStyleBackColor = true;
            // 
            // tabControlAllNews
            // 
            this.tabControlAllNews.Controls.Add(this.tabPagePosts);
            this.tabControlAllNews.Controls.Add(this.tabPageEvents);
            this.tabControlAllNews.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAllNews.Location = new System.Drawing.Point(13, 360);
            this.tabControlAllNews.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlAllNews.Name = "tabControlAllNews";
            this.tabControlAllNews.SelectedIndex = 0;
            this.tabControlAllNews.Size = new System.Drawing.Size(886, 324);
            this.tabControlAllNews.TabIndex = 22;
            // 
            // tabPagePosts
            // 
            this.tabPagePosts.Controls.Add(this.dataGridViewPosts);
            this.tabPagePosts.Controls.Add(this.groupBoxFFilters);
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
            // groupBoxFFilters
            // 
            this.groupBoxFFilters.Controls.Add(this.dateTimePicker1);
            this.groupBoxFFilters.Controls.Add(this.labelContentFilter);
            this.groupBoxFFilters.Controls.Add(this.labelNameFilter);
            this.groupBoxFFilters.Controls.Add(this.textBox2);
            this.groupBoxFFilters.Controls.Add(this.textBox1);
            this.groupBoxFFilters.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFFilters.Location = new System.Drawing.Point(8, 8);
            this.groupBoxFFilters.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxFFilters.Name = "groupBoxFFilters";
            this.groupBoxFFilters.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxFFilters.Size = new System.Drawing.Size(862, 70);
            this.groupBoxFFilters.TabIndex = 28;
            this.groupBoxFFilters.TabStop = false;
            this.groupBoxFFilters.Text = "Filters";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(621, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // labelContentFilter
            // 
            this.labelContentFilter.AutoSize = true;
            this.labelContentFilter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContentFilter.Location = new System.Drawing.Point(8, 49);
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
            this.labelNameFilter.Location = new System.Drawing.Point(272, 47);
            this.labelNameFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameFilter.Name = "labelNameFilter";
            this.labelNameFilter.Size = new System.Drawing.Size(45, 17);
            this.labelNameFilter.TabIndex = 2;
            this.labelNameFilter.Text = "From:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 41);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 24);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(325, 42);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 24);
            this.textBox1.TabIndex = 0;
            // 
            // tabPageEvents
            // 
            this.tabPageEvents.Location = new System.Drawing.Point(4, 26);
            this.tabPageEvents.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageEvents.Name = "tabPageEvents";
            this.tabPageEvents.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageEvents.Size = new System.Drawing.Size(878, 294);
            this.tabPageEvents.TabIndex = 0;
            this.tabPageEvents.Text = "Events";
            this.tabPageEvents.UseVisualStyleBackColor = true;
            // 
            // buttonShowMoreInfo
            // 
            this.buttonShowMoreInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShowMoreInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowMoreInfo.Location = new System.Drawing.Point(13, 320);
            this.buttonShowMoreInfo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowMoreInfo.Name = "buttonShowMoreInfo";
            this.buttonShowMoreInfo.Size = new System.Drawing.Size(886, 32);
            this.buttonShowMoreInfo.TabIndex = 21;
            this.buttonShowMoreInfo.Text = "⇊  ⇊  ShowMoreInfo  ⇊  ⇊";
            this.buttonShowMoreInfo.UseVisualStyleBackColor = true;
            this.buttonShowMoreInfo.Click += new System.EventHandler(this.buttonShowMoreInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Friends";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(216, 54);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(177, 164);
            this.listBoxFriends.TabIndex = 19;
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPostStatus.Location = new System.Drawing.Point(756, 250);
            this.buttonPostStatus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(143, 62);
            this.buttonPostStatus.TabIndex = 18;
            this.buttonPostStatus.Text = "Post New Status";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            // 
            // textBoxPostStatus
            // 
            this.textBoxPostStatus.Location = new System.Drawing.Point(13, 250);
            this.textBoxPostStatus.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPostStatus.Multiline = true;
            this.textBoxPostStatus.Name = "textBoxPostStatus";
            this.textBoxPostStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPostStatus.Size = new System.Drawing.Size(733, 61);
            this.textBoxPostStatus.TabIndex = 17;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(34, 22);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(134, 30);
            this.labelUserName.TabIndex = 16;
            this.labelUserName.Text = "User Name";
            // 
            // pictureBoxUserSmallPicture
            // 
            this.pictureBoxUserSmallPicture.Location = new System.Drawing.Point(13, 54);
            this.pictureBoxUserSmallPicture.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxUserSmallPicture.Name = "pictureBoxUserSmallPicture";
            this.pictureBoxUserSmallPicture.Size = new System.Drawing.Size(179, 165);
            this.pictureBoxUserSmallPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUserSmallPicture.TabIndex = 15;
            this.pictureBoxUserSmallPicture.TabStop = false;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(779, 12);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(121, 26);
            this.buttonLogOut.TabIndex = 30;
            this.buttonLogOut.Text = "LogOut";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonRefreshTable
            // 
            this.buttonRefreshTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefreshTable.Location = new System.Drawing.Point(658, 692);
            this.buttonRefreshTable.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefreshTable.Name = "buttonRefreshTable";
            this.buttonRefreshTable.Size = new System.Drawing.Size(88, 28);
            this.buttonRefreshTable.TabIndex = 29;
            this.buttonRefreshTable.Text = "Refresh";
            this.buttonRefreshTable.UseVisualStyleBackColor = true;
            // 
            // FormFacebookAccountBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 731);
            this.Controls.Add(this.buttonRefreshTable);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.labelCheckIns);
            this.Controls.Add(this.listBoxCheckIns);
            this.Controls.Add(this.buttonCloseTab);
            this.Controls.Add(this.buttonComments);
            this.Controls.Add(this.buttonLinkToUrl);
            this.Controls.Add(this.tabControlAllNews);
            this.Controls.Add(this.buttonShowMoreInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.textBoxPostStatus);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.pictureBoxUserSmallPicture);
            this.Name = "FormFacebookAccountBoard";
            this.Text = "FormFacebookAccountBoard";
            this.tabControlAllNews.ResumeLayout(false);
            this.tabPagePosts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosts)).EndInit();
            this.groupBoxFFilters.ResumeLayout(false);
            this.groupBoxFFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserSmallPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCheckIns;
        private System.Windows.Forms.ListBox listBoxCheckIns;
        private System.Windows.Forms.Button buttonCloseTab;
        private System.Windows.Forms.Button buttonComments;
        private System.Windows.Forms.Button buttonLinkToUrl;
        private System.Windows.Forms.TabControl tabControlAllNews;
        private System.Windows.Forms.TabPage tabPagePosts;
        private System.Windows.Forms.DataGridView dataGridViewPosts;
        private System.Windows.Forms.TabPage tabPageEvents;
        private System.Windows.Forms.Button buttonShowMoreInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.TextBox textBoxPostStatus;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.PictureBox pictureBoxUserSmallPicture;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.GroupBox groupBoxFFilters;
        private System.Windows.Forms.Label labelContentFilter;
        private System.Windows.Forms.Label labelNameFilter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonRefreshTable;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}