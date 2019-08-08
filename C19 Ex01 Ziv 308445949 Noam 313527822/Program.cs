using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C19_Ex01_Ziv_308445949_Noam_313527822
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm);
            Application.Run(new HomeForm(loginForm.FaceBookuser));

        }
    }
}


//Seperate ui and logic
//how to get all the details about the homeform window to login form !?

