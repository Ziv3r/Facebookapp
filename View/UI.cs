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
            LoginForm loginForm = new LoginForm((User fbUser) => fbApp.FacebookUser = fbUser);
            if (loginForm.ShowDialog() != DialogResult.Abort)
            {
                Application.Run(new HomeForm(
                    fbApp.FacebookUser,
                    fbApp.InitFindLove,
                    fbApp.GetMatch,
                    fbApp.GetEventsByDate,
                    fbApp.GetImagesByTag,
                    fbApp.Albums));

                FacebookApp.AppSettings.SaveToFile();
            }
        }
    }
}