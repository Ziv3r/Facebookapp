using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace View
{
    public class UI
    {
        public void Start(Action<User> On_Login)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new LoginForm(On_Login);

            Application.Run(loginForm);
            Application.Run(new HomeForm(FaceBookuser));

        }
    }
}
