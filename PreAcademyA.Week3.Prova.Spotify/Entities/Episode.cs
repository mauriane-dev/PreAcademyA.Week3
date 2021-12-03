using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Prova.Spotify.Entities
{
    class Episode
    {
        public string Title { get; set; }
        public Duration Duration { get; set; }
        public bool IsPlayed { get; set; }

        public Episode(string title, Duration duration)
        {
            Title = title;
            Duration = duration;
            IsPlayed = false;
        }

        internal string Print()
        {
            return $"{Title} - {Duration.Hours} - {Duration.Minutes} -{Duration.Seconds} - {IsPlayed}";
        }
    }

    public struct Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hour, int min, int sec)
        {
            Hours = hour;
            Minutes = min;
            Seconds = sec;
        }
    }
}
