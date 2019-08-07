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
    public partial class MainForm : Form
    {
        User m_FaceBookUser;

        public MainForm(User i_FaceBookUser)
        {
            InitializeComponent();
            m_FaceBookUser = i_FaceBookUser;
            showInfo();
        }

        private void showInfo()
        {
         //   profilePictureBox.LoadAsync(m_FaceBookUser.PictureNormalURL);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void showFriendsBtn_Click(object sender, EventArgs e)
        {
            //foreach()
        }
    }
}
