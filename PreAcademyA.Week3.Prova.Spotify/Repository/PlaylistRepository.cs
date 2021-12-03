using PreAcademyA.Week3.Prova.Spotify.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PreAcademyA.Week3.Prova.Spotify.Repository
{
    class PlaylistRepository
    {
        static SongRepository cr = new SongRepository();
        static List<Song> playlist = new List<Song>();

        public void Add(string titolo)
        {
            playlist.Add(GetCanzoneByTitle(titolo));
        }
        internal bool IsInList(string titolo)
        {
            return playlist.Contains(GetCanzoneByTitle(titolo));
        }
        internal Song GetCanzoneByTitle(string titolo)
        {
            List<Song> canzoni = cr.Fetch();
            return canzoni.Single(c => c.Title == titolo);
        }
    }
}
