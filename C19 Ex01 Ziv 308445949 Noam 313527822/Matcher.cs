using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C19_Ex01_Ziv_308445949_Noam_313527822
{
    class Matcher
    {
        User m_FaceBookUser;

        public Matcher(User i_FaceBookUser)
        {
            m_FaceBookUser = i_FaceBookUser;
        }

        public List<User> getMatch()
        {
            List<User> userBestMatches = new List<User>();

            foreach (User userFrined in m_FaceBookUser.Friends)
            {
                int friendScore = 0;
                if (!userFrined.Gender.Equals(m_FaceBookUser.Gender))
                {
                    friendScore++;
                }

            }

            return userBestMatches;
        }
    }
}

