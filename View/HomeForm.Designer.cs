namespace View
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.friendsBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.buttonGetGroups = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.buttonShowPosts = new System.Windows.Forms.Button();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPostStatus = new System.Windows.Forms.Label();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonShowEvents = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.buttonFindLove = new System.Windows.Forms.Button();
            this.listBoxFindLove = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 209);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1075, 405);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.listBoxFindLove);
            this.tabPage1.Controls.Add(this.buttonFindLove);
            this.tabPage1.Controls.Add(this.pictureBoxFriend);
            this.tabPage1.Controls.Add(this.listBoxFriends);
            this.tabPage1.Controls.Add(this.friendsBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1067, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Friends";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.Location = new System.Drawing.Point(403, 43);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(139, 150);
            this.pictureBoxFriend.TabIndex = 2;
            this.pictureBoxFriend.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(188, 43);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(193, 264);
            this.listBoxFriends.TabIndex = 1;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // friendsBtn
            // 
            this.friendsBtn.Location = new System.Drawing.Point(20, 42);
            this.friendsBtn.Name = "friendsBtn";
            this.friendsBtn.Size = new System.Drawing.Size(162, 60);
            this.friendsBtn.TabIndex = 0;
            this.friendsBtn.Text = "Show Friends";
            this.friendsBtn.UseVisualStyleBackColor = true;
            this.friendsBtn.Click += new System.EventHandler(this.showFriendsBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxEvents);
            this.tabPage2.Controls.Add(this.buttonShowEvents);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1067, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Events";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBoxGroups);
            this.tabPage3.Controls.Add(this.buttonGetGroups);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1067, 372);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Groups";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 20;
            this.listBoxGroups.Location = new System.Drawing.Point(41, 101);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(319, 224);
            this.listBoxGroups.TabIndex = 1;
            // 
            // buttonGetGroups
            // 
            this.buttonGetGroups.Location = new System.Drawing.Point(41, 24);
            this.buttonGetGroups.Name = "buttonGetGroups";
            this.buttonGetGroups.Size = new System.Drawing.Size(175, 44);
            this.buttonGetGroups.TabIndex = 0;
            this.buttonGetGroups.Text = "Get Groups";
            this.buttonGetGroups.UseVisualStyleBackColor = true;
            this.buttonGetGroups.Click += new System.EventHandler(this.buttonGetFriends_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listBoxPosts);
            this.tabPage4.Controls.Add(this.buttonShowPosts);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1067, 372);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Posts";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 20;
            this.listBoxPosts.Location = new System.Drawing.Point(238, 47);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(468, 264);
            this.listBoxPosts.TabIndex = 2;
            // 
            // buttonShowPosts
            // 
            this.buttonShowPosts.Location = new System.Drawing.Point(36, 47);
            this.buttonShowPosts.Name = "buttonShowPosts";
            this.buttonShowPosts.Size = new System.Drawing.Size(162, 60);
            this.buttonShowPosts.TabIndex = 1;
            this.buttonShowPosts.Text = "Show Posts";
            this.buttonShowPosts.UseVisualStyleBackColor = true;
            this.buttonShowPosts.Click += new System.EventHandler(this.buttonShowPosts_Click);
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(36, 65);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(158, 118);
            this.pictureBoxProfilePicture.TabIndex = 1;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(210, 71);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(86, 20);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(210, 140);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(86, 20);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Last Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(326, 70);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(133, 26);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(326, 138);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(133, 26);
            this.textBoxLastName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(63, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "About Me";
            // 
            // labelPostStatus
            // 
            this.labelPostStatus.AutoSize = true;
            this.labelPostStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPostStatus.Location = new System.Drawing.Point(711, 63);
            this.labelPostStatus.Name = "labelPostStatus";
            this.labelPostStatus.Size = new System.Drawing.Size(112, 25);
            this.labelPostStatus.TabIndex = 7;
            this.labelPostStatus.Text = "Post Status";
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(513, 104);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(513, 54);
            this.textBoxPost.TabIndex = 8;
            this.textBoxPost.TextChanged += new System.EventHandler(this.textBoxPost_TextChanged);
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(1045, 101);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(83, 32);
            this.buttonPost.TabIndex = 9;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonShowEvents
            // 
            this.buttonShowEvents.Location = new System.Drawing.Point(16, 29);
            this.buttonShowEvents.Name = "buttonShowEvents";
            this.buttonShowEvents.Size = new System.Drawing.Size(162, 60);
            this.buttonShowEvents.TabIndex = 1;
            this.buttonShowEvents.Text = "Show Events";
            this.buttonShowEvents.UseVisualStyleBackColor = true;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 20;
            this.listBoxEvents.Location = new System.Drawing.Point(209, 30);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(193, 264);
            this.listBoxEvents.TabIndex = 2;
            // 
            // buttonFindLove
            // 
            this.buttonFindLove.Location = new System.Drawing.Point(582, 42);
            this.buttonFindLove.Name = "buttonFindLove";
            this.buttonFindLove.Size = new System.Drawing.Size(168, 38);
            this.buttonFindLove.TabIndex = 11;
            this.buttonFindLove.Text = "Find Love";
            this.buttonFindLove.UseVisualStyleBackColor = true;
            this.buttonFindLove.Click += new System.EventHandler(this.buttonFindLove_Click);
            // 
            // listBoxFindLove
            // 
            this.listBoxFindLove.FormattingEnabled = true;
            this.listBoxFindLove.ItemHeight = 20;
            this.listBoxFindLove.Location = new System.Drawing.Point(765, 43);
            this.listBoxFindLove.Name = "listBoxFindLove";
            this.listBoxFindLove.Size = new System.Drawing.Size(193, 264);
            this.listBoxFindLove.TabIndex = 12;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1162, 647);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.labelPostStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Controls.Add(this.tabControl1);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Button friendsBtn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Button buttonGetGroups;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPostStatus;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Button buttonShowPosts;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Button buttonShowEvents;
        private System.Windows.Forms.ListBox listBoxFindLove;
        private System.Windows.Forms.Button buttonFindLove;
    }
}