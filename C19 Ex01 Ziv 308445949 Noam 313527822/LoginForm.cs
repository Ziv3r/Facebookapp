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
    public partial class LoginForm : Form
    {
        private AppSettings m_AppSetting;
        private LoginResult m_LoginResult;
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

        public LoginForm()
        {
            InitializeComponent();
            //m_AppSetting = AppSettings.LoadFromFile();

        }

        //protected override void OnShown(EventArgs e)
        //{
        //    base.OnShown(e);

        //    if (m_AppSetting.RememberUser && !string.IsNullOrEmpty(m_AppSetting.LastAccessToken))
        //    {
        //        m_LoginResult = FacebookService.Connect(m_AppSetting.LastAccessToken);
        //    }
        //}

        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //    base.OnFormClosing(e);
        //    m_AppSetting.LastWindowsSize = this.Size;
        //    m_AppSetting.LastWindowLocation = this.Location;
        //    m_AppSetting.RememberUser = this.checkBoxRemmberMe.Checked; 
        //    if (this.checkBoxRemmberMe.Checked)
        //    {
        //        m_AppSetting.LastAccessToken = m_LoginResult.AccessToken;
        //    }
        //    else
        //    {
        //        m_AppSetting.LastAccessToken = null;
        //    }
        //    m_AppSetting.SaveToFile();
        //}

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        public User FaceBookuser { get; set; }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            loginAndInit();
            Close();
        }
        private void loginAndInit()
        {
            m_LoginResult = FacebookService.Login(k_ApplicationId,
               r_RequiredPermissions);

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                FaceBookuser = m_LoginResult.LoggedInUser;
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage);
            }
        }

    }
}

