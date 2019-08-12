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
            this.tabControlGroups = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.labelGenderChoose = new System.Windows.Forms.Label();
            this.buttonTinderLeft = new System.Windows.Forms.Button();
            this.labelTinderName = new System.Windows.Forms.Label();
            this.buttonTinderRight = new System.Windows.Forms.Button();
            this.pictureBoxTinder = new System.Windows.Forms.PictureBox();
            this.buttonFindLove = new System.Windows.Forms.Button();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.friendsBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.buttonShowEvents = new System.Windows.Forms.Button();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
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
            this.pictureBoxCurrentEvent = new System.Windows.Forms.PictureBox();
            this.textBoxEventDescription = new System.Windows.Forms.TextBox();
            this.dateTimePickerEventStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEventEnd = new System.Windows.Forms.DateTimePicker();
            this.labelEventStart = new System.Windows.Forms.Label();
            this.labelEventEnd = new System.Windows.Forms.Label();
            this.listBoxEventsByDate = new System.Windows.Forms.ListBox();
            this.buttonPickEventsByDate = new System.Windows.Forms.Button();
            this.tabControlGroups.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTinder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPageGroups.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlGroups
            // 
            this.tabControlGroups.Controls.Add(this.tabPage1);
            this.tabControlGroups.Controls.Add(this.tabPage2);
            this.tabControlGroups.Controls.Add(this.tabPageGroups);
            this.tabControlGroups.Controls.Add(this.tabPage4);
            this.tabControlGroups.Location = new System.Drawing.Point(11, 167);
            this.tabControlGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlGroups.Name = "tabControlGroups";
            this.tabControlGroups.SelectedIndex = 0;
            this.tabControlGroups.Size = new System.Drawing.Size(956, 324);
            this.tabControlGroups.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.labelGenderChoose);
            this.tabPage1.Controls.Add(this.buttonTinderLeft);
            this.tabPage1.Controls.Add(this.labelTinderName);
            this.tabPage1.Controls.Add(this.buttonTinderRight);
            this.tabPage1.Controls.Add(this.pictureBoxTinder);
            this.tabPage1.Controls.Add(this.buttonFindLove);
            this.tabPage1.Controls.Add(this.pictureBoxFriend);
            this.tabPage1.Controls.Add(this.listBoxFriends);
            this.tabPage1.Controls.Add(this.friendsBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(948, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Friends";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonFemale);
            this.groupBox2.Controls.Add(this.radioButtonMale);
            this.groupBox2.Location = new System.Drawing.Point(780, 60);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(139, 94);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(32, 47);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(75, 21);
            this.radioButtonFemale.TabIndex = 18;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(32, 14);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(59, 21);
            this.radioButtonMale.TabIndex = 17;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // labelGenderChoose
            // 
            this.labelGenderChoose.AutoSize = true;
            this.labelGenderChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGenderChoose.Location = new System.Drawing.Point(776, 26);
            this.labelGenderChoose.Name = "labelGenderChoose";
            this.labelGenderChoose.Size = new System.Drawing.Size(127, 18);
            this.labelGenderChoose.TabIndex = 16;
            this.labelGenderChoose.Text = "Choose Gender";
            this.labelGenderChoose.Click += new System.EventHandler(this.labelGenderChoose_Click);
            // 
            // buttonTinderLeft
            // 
            this.buttonTinderLeft.Location = new System.Drawing.Point(505, 85);
            this.buttonTinderLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTinderLeft.Name = "buttonTinderLeft";
            this.buttonTinderLeft.Size = new System.Drawing.Size(47, 48);
            this.buttonTinderLeft.TabIndex = 14;
            this.buttonTinderLeft.Text = "<";
            this.buttonTinderLeft.UseVisualStyleBackColor = true;
            this.buttonTinderLeft.Visible = false;
            this.buttonTinderLeft.Click += new System.EventHandler(this.buttonTinderLeft_Click);
            // 
            // labelTinderName
            // 
            this.labelTinderName.AutoSize = true;
            this.labelTinderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTinderName.Location = new System.Drawing.Point(564, 218);
            this.labelTinderName.Name = "labelTinderName";
            this.labelTinderName.Size = new System.Drawing.Size(0, 20);
            this.labelTinderName.TabIndex = 15;
            // 
            // buttonTinderRight
            // 
            this.buttonTinderRight.Location = new System.Drawing.Point(712, 85);
            this.buttonTinderRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTinderRight.Name = "buttonTinderRight";
            this.buttonTinderRight.Size = new System.Drawing.Size(47, 48);
            this.buttonTinderRight.TabIndex = 13;
            this.buttonTinderRight.Text = ">";
            this.buttonTinderRight.UseVisualStyleBackColor = true;
            this.buttonTinderRight.Visible = false;
            this.buttonTinderRight.Click += new System.EventHandler(this.buttonTinderRight_Click);
            // 
            // pictureBoxTinder
            // 
            this.pictureBoxTinder.Location = new System.Drawing.Point(557, 78);
            this.pictureBoxTinder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxTinder.Name = "pictureBoxTinder";
            this.pictureBoxTinder.Size = new System.Drawing.Size(149, 120);
            this.pictureBoxTinder.TabIndex = 12;
            this.pictureBoxTinder.TabStop = false;
            this.pictureBoxTinder.Click += new System.EventHandler(this.pictureBoxTinder_Click);
            // 
            // buttonFindLove
            // 
            this.buttonFindLove.Location = new System.Drawing.Point(556, 33);
            this.buttonFindLove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFindLove.Name = "buttonFindLove";
            this.buttonFindLove.Size = new System.Drawing.Size(149, 34);
            this.buttonFindLove.TabIndex = 11;
            this.buttonFindLove.Text = "Find Love";
            this.buttonFindLove.UseVisualStyleBackColor = true;
            this.buttonFindLove.Click += new System.EventHandler(this.buttonFindLove_Click);
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.Location = new System.Drawing.Point(214, 76);
            this.pictureBoxFriend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(124, 120);
            this.pictureBoxFriend.TabIndex = 2;
            this.pictureBoxFriend.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(27, 77);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(172, 212);
            this.listBoxFriends.TabIndex = 1;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // friendsBtn
            // 
            this.friendsBtn.Location = new System.Drawing.Point(26, 19);
            this.friendsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.friendsBtn.Name = "friendsBtn";
            this.friendsBtn.Size = new System.Drawing.Size(172, 48);
            this.friendsBtn.TabIndex = 0;
            this.friendsBtn.Text = "Show Friends";
            this.friendsBtn.UseVisualStyleBackColor = true;
            this.friendsBtn.Click += new System.EventHandler(this.showFriendsBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.buttonPickEventsByDate);
            this.tabPage2.Controls.Add(this.listBoxEventsByDate);
            this.tabPage2.Controls.Add(this.labelEventEnd);
            this.tabPage2.Controls.Add(this.labelEventStart);
            this.tabPage2.Controls.Add(this.dateTimePickerEventEnd);
            this.tabPage2.Controls.Add(this.dateTimePickerEventStart);
            this.tabPage2.Controls.Add(this.textBoxEventDescription);
            this.tabPage2.Controls.Add(this.pictureBoxCurrentEvent);
            this.tabPage2.Controls.Add(this.listBoxEvents);
            this.tabPage2.Controls.Add(this.buttonShowEvents);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(948, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Events";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(6, 87);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(172, 196);
            this.listBoxEvents.TabIndex = 2;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // buttonShowEvents
            // 
            this.buttonShowEvents.Location = new System.Drawing.Point(14, 23);
            this.buttonShowEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowEvents.Name = "buttonShowEvents";
            this.buttonShowEvents.Size = new System.Drawing.Size(144, 48);
            this.buttonShowEvents.TabIndex = 1;
            this.buttonShowEvents.Text = "All Events";
            this.buttonShowEvents.UseVisualStyleBackColor = true;
            this.buttonShowEvents.Click += new System.EventHandler(this.buttonShowEvents_Click);
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageGroups.BackgroundImage")));
            this.tabPageGroups.Controls.Add(this.listBoxGroups);
            this.tabPageGroups.Controls.Add(this.buttonGetGroups);
            this.tabPageGroups.Location = new System.Drawing.Point(4, 25);
            this.tabPageGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Size = new System.Drawing.Size(948, 295);
            this.tabPageGroups.TabIndex = 2;
            this.tabPageGroups.Text = "Groups";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 16;
            this.listBoxGroups.Location = new System.Drawing.Point(36, 81);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(284, 180);
            this.listBoxGroups.TabIndex = 1;
            // 
            // buttonGetGroups
            // 
            this.buttonGetGroups.Location = new System.Drawing.Point(36, 19);
            this.buttonGetGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGetGroups.Name = "buttonGetGroups";
            this.buttonGetGroups.Size = new System.Drawing.Size(156, 35);
            this.buttonGetGroups.TabIndex = 0;
            this.buttonGetGroups.Text = "Get Groups";
            this.buttonGetGroups.UseVisualStyleBackColor = true;
            this.buttonGetGroups.Click += new System.EventHandler(this.buttonGetFriends_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.Controls.Add(this.listBoxPosts);
            this.tabPage4.Controls.Add(this.buttonShowPosts);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(948, 295);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Posts";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(212, 38);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(416, 212);
            this.listBoxPosts.TabIndex = 2;
            // 
            // buttonShowPosts
            // 
            this.buttonShowPosts.Location = new System.Drawing.Point(32, 38);
            this.buttonShowPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowPosts.Name = "buttonShowPosts";
            this.buttonShowPosts.Size = new System.Drawing.Size(144, 48);
            this.buttonShowPosts.TabIndex = 1;
            this.buttonShowPosts.Text = "Show Posts";
            this.buttonShowPosts.UseVisualStyleBackColor = true;
            this.buttonShowPosts.Click += new System.EventHandler(this.buttonShowPosts_Click);
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(32, 52);
            this.pictureBoxProfilePicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(140, 94);
            this.pictureBoxProfilePicture.TabIndex = 1;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(187, 57);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(76, 17);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(187, 112);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(76, 17);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Last Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(290, 56);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(119, 22);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(290, 110);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(119, 22);
            this.textBoxLastName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(56, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "About Me";
            // 
            // labelPostStatus
            // 
            this.labelPostStatus.AutoSize = true;
            this.labelPostStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPostStatus.Location = new System.Drawing.Point(632, 50);
            this.labelPostStatus.Name = "labelPostStatus";
            this.labelPostStatus.Size = new System.Drawing.Size(96, 20);
            this.labelPostStatus.TabIndex = 7;
            this.labelPostStatus.Text = "Post Status";
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(456, 83);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(456, 44);
            this.textBoxPost.TabIndex = 8;
            this.textBoxPost.TextChanged += new System.EventHandler(this.textBoxPost_TextChanged);
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(929, 81);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(74, 26);
            this.buttonPost.TabIndex = 9;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // pictureBoxCurrentEvent
            // 
            this.pictureBoxCurrentEvent.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCurrentEvent.Location = new System.Drawing.Point(239, 87);
            this.pictureBoxCurrentEvent.Name = "pictureBoxCurrentEvent";
            this.pictureBoxCurrentEvent.Size = new System.Drawing.Size(100, 89);
            this.pictureBoxCurrentEvent.TabIndex = 3;
            this.pictureBoxCurrentEvent.TabStop = false;
            // 
            // textBoxEventDescription
            // 
            this.textBoxEventDescription.Location = new System.Drawing.Point(219, 201);
            this.textBoxEventDescription.Multiline = true;
            this.textBoxEventDescription.Name = "textBoxEventDescription";
            this.textBoxEventDescription.Size = new System.Drawing.Size(140, 59);
            this.textBoxEventDescription.TabIndex = 4;
            this.textBoxEventDescription.Visible = false;
            // 
            // dateTimePickerEventStart
            // 
            this.dateTimePickerEventStart.Location = new System.Drawing.Point(720, 23);
            this.dateTimePickerEventStart.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEventStart.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEventStart.Name = "dateTimePickerEventStart";
            this.dateTimePickerEventStart.Size = new System.Drawing.Size(222, 22);
            this.dateTimePickerEventStart.TabIndex = 5;
            this.dateTimePickerEventStart.Tag = "Start";
            // 
            // dateTimePickerEventEnd
            // 
            this.dateTimePickerEventEnd.Location = new System.Drawing.Point(720, 73);
            this.dateTimePickerEventEnd.Name = "dateTimePickerEventEnd";
            this.dateTimePickerEventEnd.Size = new System.Drawing.Size(222, 22);
            this.dateTimePickerEventEnd.TabIndex = 6;
            this.dateTimePickerEventEnd.Tag = "End";
            this.dateTimePickerEventEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEventEnd_ValueChanged);
            // 
            // labelEventStart
            // 
            this.labelEventStart.AutoSize = true;
            this.labelEventStart.BackColor = System.Drawing.Color.Transparent;
            this.labelEventStart.Location = new System.Drawing.Point(645, 23);
            this.labelEventStart.Name = "labelEventStart";
            this.labelEventStart.Size = new System.Drawing.Size(42, 17);
            this.labelEventStart.TabIndex = 7;
            this.labelEventStart.Text = "Start:";
            this.labelEventStart.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelEventEnd
            // 
            this.labelEventEnd.AutoSize = true;
            this.labelEventEnd.BackColor = System.Drawing.Color.Transparent;
            this.labelEventEnd.Location = new System.Drawing.Point(650, 73);
            this.labelEventEnd.Name = "labelEventEnd";
            this.labelEventEnd.Size = new System.Drawing.Size(37, 17);
            this.labelEventEnd.TabIndex = 8;
            this.labelEventEnd.Text = "End:";
            // 
            // listBoxEventsByDate
            // 
            this.listBoxEventsByDate.FormattingEnabled = true;
            this.listBoxEventsByDate.ItemHeight = 16;
            this.listBoxEventsByDate.Location = new System.Drawing.Point(720, 119);
            this.listBoxEventsByDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEventsByDate.Name = "listBoxEventsByDate";
            this.listBoxEventsByDate.Size = new System.Drawing.Size(200, 132);
            this.listBoxEventsByDate.TabIndex = 9;
            // 
            // buttonPickEventsByDate
            // 
            this.buttonPickEventsByDate.Location = new System.Drawing.Point(614, 116);
            this.buttonPickEventsByDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPickEventsByDate.Name = "buttonPickEventsByDate";
            this.buttonPickEventsByDate.Size = new System.Drawing.Size(73, 60);
            this.buttonPickEventsByDate.TabIndex = 10;
            this.buttonPickEventsByDate.Text = "Pick";
            this.buttonPickEventsByDate.UseVisualStyleBackColor = true;
            this.buttonPickEventsByDate.Click += new System.EventHandler(this.buttonPickEventsByDate_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1040, 753);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.labelPostStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Controls.Add(this.tabControlGroups);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.tabControlGroups.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTinder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPageGroups.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlGroups;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Button friendsBtn;
        private System.Windows.Forms.TabPage tabPageGroups;
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
        private System.Windows.Forms.Button buttonFindLove;
        private System.Windows.Forms.Label labelTinderName;
        private System.Windows.Forms.Button buttonTinderLeft;
        private System.Windows.Forms.Button buttonTinderRight;
        private System.Windows.Forms.PictureBox pictureBoxTinder;
        private System.Windows.Forms.Label labelGenderChoose;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelEventEnd;
        private System.Windows.Forms.Label labelEventStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEventEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerEventStart;
        private System.Windows.Forms.TextBox textBoxEventDescription;
        private System.Windows.Forms.PictureBox pictureBoxCurrentEvent;
        private System.Windows.Forms.ListBox listBoxEventsByDate;
        private System.Windows.Forms.Button buttonPickEventsByDate;
    }
}