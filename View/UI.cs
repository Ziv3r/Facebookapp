using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Model;

namespace View
{
    public class UI
    {
        public void Start()
        {
            FacebookApp fbApp = new FacebookApp();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new LoginForm((User fbUser) => fbApp.FacebookUser = fbUser) ;
                
            Application.Run(loginForm);

            Application.Run(new HomeForm(fbApp.FacebookUser,fbApp.InitFindLove,fbApp.GetMatch));

            FacebookApp.AppSettings.SaveToFile();
        }
    }
}


