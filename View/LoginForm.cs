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
using Model;

namespace View
{
    public partial class LoginForm : Form
    {
        public event Action<User> OnLogin;

        public LoginResult LoginResult { set; get; }

        
        private const string k_ApplicationId = "1450160541956417";     
        private readonly string[] r_RequiredPermissions =
        {
             "public_profile",
                "email",
                "publish_to_groups",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_tagged_places",
                "user_videos",
                "publish_to_groups",
                "groups_access_member_info",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_hometown"
    };

        public LoginForm(Action<User> i_OnLogin)
        {
            InitializeComponent();
            OnLogin += i_OnLogin;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            AppSettings appSetting = FacebookApp.AppSettings;

            if (appSetting.RememberUser && !string.IsNullOrEmpty(appSetting.LastAccessToken))
            {
                LoginResult = FacebookService.Connect(appSetting.LastAccessToken);
                OnLogin(LoginResult.LoggedInUser);
                Close();
            }
        }

       
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            FacebookApp.AppSettings.RememberUser = checkBoxRememberMe.Checked;

            if (FacebookApp.AppSettings.RememberUser)
            {
                FacebookApp.AppSettings.LastAccessToken = LoginResult.AccessToken;
            }
            else
            {
                FacebookApp.AppSettings.LastAccessToken = null;
            }
        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //desig pass : design.patterns19c
            loginAndInit();
            Close();
        }

        private void loginAndInit()
        {
            LoginResult = FacebookService.Login(k_ApplicationId,
               r_RequiredPermissions);

            if (!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                OnLogin(LoginResult.LoggedInUser);
            }
            else
            {
                MessageBox.Show(LoginResult.ErrorMessage);
            }
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
    }
}

