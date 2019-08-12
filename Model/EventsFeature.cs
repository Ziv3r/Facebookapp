using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Model
{
    public class EventsFeature
    {
        public List<Event> EventsMatch { get; set; }

        public EventsFeature()
        {
            EventsMatch = new List<Event>();
        }

        public List<Event> GetEventsByDate(User i_User, DateTime i_StartTime, DateTime i_EndTime)
        {
            EventsMatch.Clear();

            User faceBookUser = i_User;

            faceBookUser.Events.ToList().ForEach((i_Event) =>
            {
                if (i_Event.StartTime >= i_StartTime && i_Event.EndTime <= i_EndTime)
                {
                    EventsMatch.Add(i_Event);
                }
            });

            return EventsMatch;
        }
    }
}
