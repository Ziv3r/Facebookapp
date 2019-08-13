using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace Model
{
    public class Matcher
    {
        private const int k_SameCity = 5;
        private const int k_AttendigToSameEvent = 4;
        private const int k_samePlaceCheckedIn = 3;

        public User FaceBookUser { get; set; }

        public int IndexInMatchCollection { get; set; }

        internal List<KeyValuePair<int, User>> FriendsMatch { get; set; }

        public Matcher(User i_FaceBookUser)
        {
            FaceBookUser = i_FaceBookUser;
        }

        internal List<KeyValuePair<int, User>> GetMatch(User.eGender i_GenderOfInterest)
        {
            ICollection<User> userBestMatches;

            // this line should be applied for better match, facebook API doesnt provide friends gender though.
            // userBestMatches = FaceBookUser.Friends.Where(friend => friend.Gender == i_GenderOfInterest).ToList<User>();

            userBestMatches = FaceBookUser.Friends;

            foreach (User friend in userBestMatches)
            {
                int friendScore = 0;

                if (friend.Hometown != null &&
                    friend.Hometown.Equals(FaceBookUser.Hometown))
                {
                    friendScore += k_SameCity;
                }

                friendScore += addToScore(friend.Events, FaceBookUser.Events, k_AttendigToSameEvent);
                friendScore += addToScore(friend.Checkins, FaceBookUser.Checkins, k_samePlaceCheckedIn);
                FriendsMatch.Add(new KeyValuePair<int, User>(friendScore, friend));
            }

            return FriendsMatch.OrderByDescending(x => x.Key).ToList();
        }

        public void InitMatches(User.eGender i_GenderOfInterest)
        {
            FriendsMatch = new List<KeyValuePair<int, User>>();
            FriendsMatch = GetMatch(i_GenderOfInterest);
            IndexInMatchCollection = -1;  // for first increament
        }

        private int addToScore<T>(ICollection<T> i_TargetElements, ICollection<T> i_Source, int i_ToAdd)
        {
            int addToScore = 0;
            foreach (T element in i_TargetElements)
            {
                if (i_Source.Contains(element))
                {
                    addToScore += i_ToAdd;
                }
            }

            return addToScore;
        }
    }
}