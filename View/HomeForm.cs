using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Model;

namespace View
{
    public delegate KeyValuePair<int, User> OnFindLove(User.eGender i_GenderOfInterest);
    public delegate KeyValuePair<int, User> OnTinderSlide(String i_Side);


    public partial class HomeForm : Form
    {
        public event OnFindLove OnFindLove;
        public event OnTinderSlide OnTinderSlide;

        User FaceBookUser { set; get; }

        public HomeForm(User i_FaceBookUser, OnFindLove i_OnFindLove, OnTinderSlide i_TinderSlide)
        {
            FaceBookUser = i_FaceBookUser;
            OnFindLove += i_OnFindLove;
            OnTinderSlide += i_TinderSlide;

            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;

            AppSettings appSettings = FacebookApp.AppSettings;

            InitializeComponent();
            this.StartPosition = appSettings.LastFormStartPosition;
            this.Width = appSettings.LastWindowsSize.Width;
            this.Height = appSettings.LastWindowsSize.Height;
            this.Location = appSettings.LastWindowLocation;

            initForm();
        }

        private void initForm()
        {
            textBoxFirstName.Text = FaceBookUser.Name;
            textBoxLastName.Text = FaceBookUser.LastName;
            pictureBoxProfilePicture.LoadAsync(FaceBookUser.PictureNormalURL);
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            AppSettings appSettings = FacebookApp.AppSettings;

            appSettings.LastWindowsSize = this.Size;
            appSettings.LastWindowLocation = this.Location;
            appSettings.LastFormStartPosition = FormStartPosition.Manual;

        }


        private void showFriendsBtn_Click(object sender, EventArgs e)
        {
            fetchFriends();
        }

        private void fetchFriends()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";

            foreach (User friend in FaceBookUser.Friends)
            {
                foreach (User userFriend in FaceBookUser.Friends)
                {
                    listBoxFriends.Items.Add(userFriend.Name.ToString());
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }

                if (FaceBookUser.Friends.Count == 0)
                {
                    MessageBox.Show("No Friends to retrieve :(");
                }
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend();
        }

        private void displaySelectedFriend()
        {
            if (listBoxFriends.SelectedItems.Count == 1)
            {
                User selectedFriend = listBoxFriends.SelectedItem as User;
                if (selectedFriend.PictureNormalURL != null)
                {
                    pictureBoxFriend.LoadAsync(selectedFriend.PictureNormalURL);
                }
                else
                {
                    pictureBoxFriend.Image = null;
                }
            }
        }

        private void buttonGetFriends_Click(object sender, EventArgs e)
        {
            fetuchGropus();
        }

        private void fetuchGropus()
        {
            listBoxGroups.Items.Clear();
            listBoxGroups.DisplayMember = "Name";

            foreach (Group userGroup in FaceBookUser.Groups)
            {
                listBoxFriends.Items.Add(userGroup);
            }

            if (FaceBookUser.Groups.Count == 0)
            {
                MessageBox.Show("No gropus to retrieve :(");
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            Status postedStatus = FaceBookUser.PostStatus(textBoxPost.Text);
            textBoxPost.Text = "";
            MessageBox.Show("Status Posted!");
        }

        private void buttonShowPosts_Click(object sender, EventArgs e)
        {
            fetchPosts();
        }

        private void fetchPosts()
        {
            foreach (Post post in FaceBookUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
            }

            if (FaceBookUser.Posts.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTip_Click(object sender, EventArgs e)
        {

        }

        private void buttonFindLove_Click(object sender, EventArgs e)
        {
            KeyValuePair<int, User> loveMatch;
            if (radioButtonFemale.Checked || radioButtonMale.Checked)
            {
                if (radioButtonMale.Checked)
                {
                     loveMatch = OnFindLove(User.eGender.male);
                }
                else
                {
                    loveMatch = OnFindLove(User.eGender.female);
                }
                
                layOutTinderDetails(loveMatch);
            }
        }

        private void layOutTinderDetails(KeyValuePair<int, User> loveMatch)
        {
            pictureBoxTinder.LoadAsync(loveMatch.Value.PictureNormalURL);
            labelTinderName.Text = loveMatch.Key.ToString() + " " + loveMatch.Value.Name;
            buttonTinderLeft.Visible = buttonTinderRight.Visible = true;
            buttonFindLove.Enabled = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }
        private void buttonTinderLeft_Click(object sender, EventArgs e)
        {
            KeyValuePair<int, User> loveMatch = OnTinderSlide("left");
            layOutTinderDetails(loveMatch);
        }

        private void textBoxPost_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonShowEvents_Click(object sender, EventArgs e)
        {
            fetchEvents();
        }
        private void fetchEvents()
        {
            foreach (Event currentEvent in FaceBookUser.Events)
            {
                if (currentEvent.Description != null)
                {
                    listBoxPosts.Items.Add(currentEvent.Description);
                }
            }

            if (FaceBookUser.Posts.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
        }

        private void pictureBoxTinder_Click(object sender, EventArgs e)
        {

        }

        private void labelGenderChoose_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonTinderRight_Click(object sender, EventArgs e)
        {
            KeyValuePair<int, User> loveMatch = OnTinderSlide("right");
            layOutTinderDetails(loveMatch);
        }
    }
}