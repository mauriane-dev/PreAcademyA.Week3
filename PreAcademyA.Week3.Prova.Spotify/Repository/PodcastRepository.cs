using PreAcademyA.Week3.Prova.Spotify.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PreAcademyA.Week3.Prova.Spotify.Repository
{
    class PodcastRepository
    {
        static List<Podcast> podcasts = new List<Podcast>
        {
            new Podcast(
                "Titolo podcast 1",
                new Author(
                    "nome autore podcast 1",
                    "cognome autore podcast 1",
                    1978),
               "descrizione podcast 1",
               new List<Episode>
               {
                   new Episode(
                       "Episodio 1",
                       new Duration(
                                      1,
                                      23,
                                      43)

                       ),
                   new Episode(
                       "Episodio 2",
                       new Duration(
                                      0,
                                      9,
                                      34)

                       )
               }
             ),
             new Podcast(
                "Titolo podcast 2",
                new Author(
                    "nome autore podcast 2",
                    "cognome autore podcast 2",
                    1978),
               "descrizione podcast 2",
               new List<Episode>
               {
                   new Episode(
                       "Episodio 1",
                       new Duration(
                                      1,
                                      23,
                                      43)

                       ),
                   new Episode(
                       "Episodio 2",
                       new Duration(
                                      0,
                                      9,
                                      34)

                       ),
                    new Episode(
                       "Episodio 3",
                       new Duration(
                                      3,
                                      4,
                                      1)

                       )
               }
             ),
        };
        public List<Podcast> Fetch()
        {
            return podcasts;
        }

        internal bool ExistsPodcast(string titolo)
        {
            return podcasts.Exists(p => p.Title == titolo);
        }
        internal Podcast GetEpisodi(string titolo)
        {
            return podcasts.Single(p => p.Title == titolo);
        }
        internal List<Podcast> GetEpisodiByDurations(Duration durata)
        {
            List<Podcast> podcastsCorretti = new List<Podcast>();

            foreach (var podcast in podcasts)
            {
                List<Episode> episodiCorretti = new List<Episode>();
                var episodi = podcast.Episodes;
                foreach (var episodio in episodi)
                {
                    if (episodio.Duration.Hours < durata.Hours)
                    {
                        episodiCorretti.Add(episodio);
                    }
                    else if (episodio.Duration.Hours == durata.Hours)
                    {
                        if (episodio.Duration.Minutes < durata.Minutes)
                        {
                            episodiCorretti.Add(episodio);
                        }
                        else if (episodio.Duration.Minutes == durata.Minutes)
                        {
                            if (episodio.Duration.Seconds <= durata.Seconds)
                            {
                                episodiCorretti.Add(episodio);
                            }
                        }
                    }
                }
                podcast.Episodes = episodiCorretti;
                podcastsCorretti.Add(podcast);

            }

            return podcastsCorretti;
        }
        internal void SetPlayed(string titoloPodcast, string titolo)
        {
            Podcast p = GetEpisodi(titoloPodcast);
            Episode episodio = (Episode)p.Episodes.Single(e => e.Title == titolo);
            episodio.IsPlayed = true;
        }
        internal bool ExistsEpisodio(string titolo)
        {
            return podcasts.All(p => p.Episodes.Any(e => e.Title == titolo));
        }
    }
}
