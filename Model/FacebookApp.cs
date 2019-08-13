using System;
using System.Collections;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Model
{
    public class FacebookApp
    {
        public static AppSettings AppSettings { get; private set; }

        public User FacebookUser { get; set; }

        public Matcher Matcher { get; private set; }

        public EventsFeature EventFeature { get; private set; }

        public AlbumsFeature AlbumsFeature { get; private set; }

        public FacebookApp()
        {
            EventFeature = new EventsFeature();
            AlbumsFeature = new AlbumsFeature();
            AppSettings = AppSettings.LoadFromFile();
        }

        public KeyValuePair<int, User> InitFindLove(User.eGender i_GenderOfInterest)
        {
            Matcher = new Matcher(FacebookUser);
            if (Matcher.FriendsMatch != null)
            {
                throw new ArgumentException("find love feature already initiated");
            }

            Matcher.InitMatches(i_GenderOfInterest);

            if (Matcher.FriendsMatch.Count == 0)
            {
                throw new NotSupportedException("feature doesnt support empty friend list");
            }

            return GetMatch("right");
        }

        public List<Event> GetEventsByDate(DateTime i_Start, DateTime i_EndTime)
        {
            return EventFeature.GetEventsByDate(FacebookUser, i_Start, i_EndTime);
        }

        public List<string> GetImagesByTag(string i_Tag)
        {
            return AlbumsFeature.GetImagesByTag(i_Tag, FacebookUser);
        }

        public KeyValuePair<int, User> GetMatch(string i_NextElement)
        {
            if (!i_NextElement.Equals("left") && !i_NextElement.Equals("right"))
            {
                throw new ArgumentException("next element parameter must be left or right");
            }

            int nextIndexHelper = i_NextElement == "left" ? -1 : 1;
            Matcher.IndexInMatchCollection =
                    (Matcher.IndexInMatchCollection + nextIndexHelper + Matcher.FriendsMatch.Count) % Matcher.FriendsMatch.Count;

            return Matcher.FriendsMatch[Matcher.IndexInMatchCollection];
        }

        public List<Album> Albums() {
            List<Album> res = new  List<Album>();

            foreach(Album album in FacebookUser.Albums)
            {
                res.Add(album);
            }

            return res;
        }
    }
}
