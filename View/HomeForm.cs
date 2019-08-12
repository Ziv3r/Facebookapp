using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using Model;
using FacebookWrapper.ObjectModel;

namespace View
{
    public delegate KeyValuePair<int, User> OnFindLove(User.eGender i_GenderOfInterest);

    public delegate KeyValuePair<int, User> OnTinderSlide(string i_Side);

    public delegate List<Event> OnPickEvent(DateTime i_Start, DateTime i_EndTime);

    public delegate List<string> OnSearchImage(string i_Tag);

    public partial class HomeForm : Form
    {
        public event OnFindLove OnFindLove;

        public event OnTinderSlide OnTinderSlide;

        public event OnPickEvent OnPickEventsByDate;

        public event OnSearchImage TextBox_OnImageSearch;

        public User FaceBookUser { get; set; }

        public HomeForm(
            User i_FaceBookUser,
            OnFindLove i_OnFindLove,
            OnTinderSlide i_TinderSlide,
            OnPickEvent i_OnPickEventsByDate,
            OnSearchImage i_OnSearchImages)
        {
            FaceBookUser = i_FaceBookUser;
            OnFindLove += i_OnFindLove;
            OnTinderSlide += i_TinderSlide;
            OnPickEventsByDate += i_OnPickEventsByDate;
            TextBox_OnImageSearch += i_OnSearchImages;

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
                listBoxFriends.Items.Add(friend);

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
            fetchGropus();
        }

        private void fetchGropus()
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
            try
            {
                Status postedStatus = FaceBookUser.PostStatus(textBoxPost.Text);
                textBoxPost.Text = string.Empty;
                MessageBox.Show("Status Posted!");
            }
            catch
            {
                MessageBox.Show("not Posted!");
            }
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
                try
                {
                    loveMatch = radioButtonMale.Checked ?
                        OnFindLove(User.eGender.male) : OnFindLove(User.eGender.female);
                    layOutTinderDetails(loveMatch);
                }
                catch
                {
                    buttonFindLove.Enabled = false;
                    MessageBox.Show("Cannot find love with no friends...");
                }
            }
        }

        private void layOutTinderDetails(KeyValuePair<int, User> i_LoveMatch)
        {
            pictureBoxTinder.LoadAsync(i_LoveMatch.Value.PictureNormalURL);
            labelTinderName.Text = i_LoveMatch.Key.ToString() + " " + i_LoveMatch.Value.Name;
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
            if (FaceBookUser.Events.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
            else
            {
                foreach (Event currentEvent in FaceBookUser.Events)
                {
                    if (currentEvent.Description != null)
                    {
                        listBoxPosts.Items.Add(currentEvent.Description);
                    }
                }
            }
        }

        private void buttonTinderRight_Click(object sender, EventArgs e)
        {
            KeyValuePair<int, User> loveMatch = OnTinderSlide("right");
            layOutTinderDetails(loveMatch);
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedEvent();
        }

        private void displaySelectedEvent()
        {
            if (listBoxEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = listBoxEvents.SelectedItem as Event;

                if (selectedEvent.PictureNormalURL != null)
                {
                    pictureBoxCurrentEvent.LoadAsync(selectedEvent.PictureNormalURL);
                }
                else
                {
                    pictureBoxCurrentEvent.Image = null;
                }

                textBoxEventDescription.Enabled = true;
                textBoxEventDescription.Text = selectedEvent.Description;
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

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePickerEventEnd_ValueChanged(object sender, EventArgs e)
        {
        }

        private void buttonPickEventsByDate_Click(object sender, EventArgs e)
        {
            if (dateTimePickerEventEnd.Value < dateTimePickerEventStart.Value)
            {
                MessageBox.Show("Starting date must be less or equal to ending date");
            }
            else
            {
                OnPickEventsByDate(dateTimePickerEventStart.Value, dateTimePickerEventEnd.Value)
                    .ForEach((i_Event) => listBoxEventsByDate.Items.Add(i_Event.Name));
            }
        }

        private void textBoxImageSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private Image LoadImage(string i_URL)
        {
            System.Net.WebRequest request = System.Net.WebRequest.Create(i_URL);

            System.Net.WebResponse response = request.GetResponse();
            System.IO.Stream responseStream = response.GetResponseStream();

            Bitmap bmp = new Bitmap(responseStream);

            responseStream.Dispose();

            return bmp;
        }

        private void buttonSearchImage_Click(object sender, EventArgs e)
        {
            ImageList imageList = new ImageList();
            TextBox_OnImageSearch(textBoxImageSearch.Text).ForEach(url => imageList.Images.Add(LoadImage(url)));

            // listViewImages.View = View.LargeIcon;
            listViewImages.SmallImageList = imageList;

            for (int i = 0; i < imageList.Images.Count; i++)
            {
                ListViewItem lvi = new ListViewItem("koala " + i.ToString(), i);
                listViewImages.Items.Add(lvi);
            }
        }

        private void tabPageAlbums_Click(object sender, EventArgs e)
        {
        }
    }
}