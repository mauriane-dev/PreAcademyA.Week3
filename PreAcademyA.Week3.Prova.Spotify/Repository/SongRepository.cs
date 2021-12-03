using PreAcademyA.Week3.Prova.Spotify.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PreAcademyA.Week3.Prova.Spotify.Repository
{
    class SongRepository
    {
        static List<Song> songs = new List<Song>
        {
            new Song(
                "Titolo canzone 1",
                new Author(
                    "nome autore 1",
                    "cognome autore 1",
                    1990),
                Genre.Classic),
             new Song(
                "Titolo canzone 2",
                new Author(
                    "nome autore 1",
                    "cognome autore 1",
                    1990),
                Genre.Pop),
             new Song(
                "Titolo canzoni 3",
                new Author(
                    "nome autore 2",
                    "cognome autore 2",
                    1985),
                Genre.Rock)
        };
        public List<Song> Fetch()
        {
            return songs;
        }

        internal List<Song> GetByGenre(Genre genere)
        {
            return songs.Where(c => c.Genre == genere).ToList();
        }
        internal bool ExistsCanzone(string titolo)
        {
            return songs.Exists(p => p.Title == titolo);
        }
    }
}
