using FacebookWrapper.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Model
{
    public class FacebookApp
    {
        public static AppSettings AppSettings { get; private set; }
        public User FacebookUser { get; set; }
        public Matcher Matcher { get; private set; }

        public FacebookApp()
        {
            AppSettings = AppSettings.LoadFromFile();
        }

        public KeyValuePair<int, User> InitFindLove(User.eGender i_GenderOfInterest)
        {
            if (Matcher.m_FriendsMatch != null)
            {
                throw new ArgumentException("find love feature already initiated");
            }

            Matcher = new Matcher(FacebookUser);
            Matcher.m_FriendsMatch = new List<KeyValuePair<int, User>>();
            Matcher.m_FriendsMatch = Matcher.GetMatch(i_GenderOfInterest);
            Matcher.IndexInMatchCollection = -1; // for first increament

            return GetMatch("right");
        }

        public KeyValuePair<int, User> GetMatch(string i_NextElement)
        {
            if (!i_NextElement.Equals("left") && !i_NextElement.Equals("right"))
            {
                throw new ArgumentException("next element parameter must be left or right");
            }

            int nextIndexHelper = i_NextElement == "left" ? -1 : 1;
            Matcher.IndexInMatchCollection =
                    (Matcher.IndexInMatchCollection + nextIndexHelper + Matcher.m_FriendsMatch.Count) % Matcher.m_FriendsMatch.Count;

            return Matcher.m_FriendsMatch[Matcher.IndexInMatchCollection];
        }



    }
}
