using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C19_Ex01_Ziv_308445949_Noam_313527822
{
    public partial class HomeForm : Form
    {
        User m_FaceBookUser;
        Matcher m_Matcher;


        public HomeForm(User i_FaceBookUser)
        {
            InitializeComponent();
            m_FaceBookUser = i_FaceBookUser;
            initFrom();

        }

        private void initFrom()
        {
            textBoxFirstName.Text = m_FaceBookUser.Name;
            textBoxLastName.Text = m_FaceBookUser.LastName;
            pictureBoxProfilePicture.LoadAsync(m_FaceBookUser.PictureNormalURL);
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
            
        }


        private void showFriendsBtn_Click(object sender, EventArgs e)
        {
            fetchFriends();
        }

        private void fetchFriends()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";

            foreach (User friend in m_FaceBookUser.Friends)
            {
                foreach (User userFriend in m_FaceBookUser.Friends)
                {
                    listBoxFriends.Items.Add(userFriend.Name.ToString());
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }

                if (m_FaceBookUser.Friends.Count == 0)
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
                    //pictureBoxFriend.ErrorImage
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

            foreach (Group userGroup in m_FaceBookUser.Groups)
            {
                listBoxFriends.Items.Add(userGroup);
            }

            if (m_FaceBookUser.Groups.Count == 0)
            {
                MessageBox.Show("No gropus to retrieve :(");
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            Status postedStatus = m_FaceBookUser.PostStatus(textBoxPost.Text);
            textBoxPost.Text = "";
            MessageBox.Show("Status Posted!");
        }

        private void buttonShowPosts_Click(object sender, EventArgs e)
        {
            fetchPosts();
        }

        private void fetchPosts()
        {
            foreach (Post post in m_FaceBookUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
            }

            if (m_FaceBookUser.Posts.Count == 0)
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
            List<User> loveMatch = m_Matcher.getMatch();
        }

        private void textBoxPost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}