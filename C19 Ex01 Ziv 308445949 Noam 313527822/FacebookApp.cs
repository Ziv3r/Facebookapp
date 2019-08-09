using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C19_Ex01_Ziv_308445949_Noam_313527822
{
    class FacebookApp
    {
        public static AppSettings AppSettings { get; private set; }

        public User FaceBookuser { get; set; }


        internal void Run()
        {
            AppSettings = AppSettings.LoadFromFile();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm loginForm = new LoginForm(setUser);
            Application.Run(loginForm);
            Application.Run(new HomeForm(FaceBookuser));

           
            AppSettings.SaveToFile();
        }

        //delegate for set user from login form 
        public void setUser(User i_FaceBookUser)
        {
            FaceBookuser = i_FaceBookUser;
        }
    }
}
