using PreAcademyA.Week3.Prova.Spotify.Entities;
using PreAcademyA.Week3.Prova.Spotify.Repository;
using System;
using System.Collections.Generic;

namespace PreAcademyA.Week3.Prova.Spotify
{
    internal class IterazioneUtente
    {
        static SongRepository cr = new SongRepository();
        static PodcastRepository pr = new PodcastRepository();
        static PlaylistRepository plr = new PlaylistRepository();
        internal static void Menu()
        {
            bool continuare = true;

            while (continuare)
            {
                Console.Write("Premi un qualunque tasto");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Cosa vuoi fare?");
                Console.WriteLine("Premi 1 per visualizzare tutte le canzoni");
                Console.WriteLine("Premi 2 per visualizzare tutti i podcast");
                Console.WriteLine("Premi 3 per visualizzare le canzoni per genere");
                Console.WriteLine("Premi 4 per visualizzare gli episodi di un podcast");
                Console.WriteLine("Premi 5 per visualizzare gli episodi per durata");
                Console.WriteLine("Premi 0 per uscire");

                int scelta;
                do
                {
                    Console.WriteLine("Fai la tua scelta");
                } while (!int.TryParse(Console.ReadLine(), out scelta));

                switch (scelta)
                {
                    case 1:
                        {
                            //Visualizzare canzoni
                            MostraCanzoni();
                            ChiediSeAggiungereAllaPlaylist();
                            break;
                        }
                    case 2:
                        {
                            //Visualizzare podcast
                            MostraPodcast();
                            break;
                        }
                    case 3:
                        {
                            //Scegliere canzoni per genere
                            MostraCanzoniPerGenere();
                            ChiediSeAggiungereAllaPlaylist();
                            break;
                        }
                    case 4:
                        {
                            //Visualizzare episodi podcast
                            //VisualizzaEpisodi();
                            string titoloPodcast = VisualizzaEpisodi();
                            //Chiedi se vuole ascoltare un episodio
                            ChiediAscolto(titoloPodcast);
                            break;
                        }
                    case 5:
                        {
                            //Visualizzare episodi per durata
                            MostraEpisodiPerDurata();
                            break;
                        }
                    case 0:
                        {
                            //Uscita
                            continuare = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Nessuna operazione disponibile per la scelta fatta");
                            break;
                        }
                }

            }
        }

        private static void ChiediSeAggiungereAllaPlaylist()
        {
            string risposta;
            bool chiediAncora = true; ;
            do
            {
                Console.WriteLine("Vuoi aggiunere una canzone alla playlist?");
                risposta = Console.ReadLine();
                if (risposta == "si")
                {
                    string titolo = ScegliCanzone();
                    if (!plr.IsInList(titolo))
                    {
                        plr.Add(titolo);
                    }
                    else
                    {
                        Console.WriteLine("La canzone è già nella tua playlist");
                    }
                }
                else if (risposta == "no")
                {
                    chiediAncora = false;
                }
            } while (chiediAncora);
        }

        private static void ChiediAscolto(string titoloPodcast)
        {
            //Chiedo episodio

            string risposta;
            bool chiediAncora = true;
            string titolo;
            do
            {
                Console.WriteLine("Vuoi ascoltare un podcast?");
                risposta = Console.ReadLine();
                if (risposta == "si")
                {
                    titolo = ChiediEpisodio();

                    //Aggiorno proprietà
                    pr.SetPlayed(titoloPodcast, titolo);
                }
                else if (risposta == "no")
                {
                    chiediAncora = false;
                }
            } while (chiediAncora);
        }

        private static string ChiediEpisodio()
        {
            string titolo;
            bool existsEpisodio;
            do
            {
                Console.WriteLine("Inserisci il titolo dell'episodio");
                titolo = Console.ReadLine();
                existsEpisodio = pr.ExistsEpisodio(titolo);
            } while (!existsEpisodio);

            return titolo;
        }

        private static void MostraEpisodiPerDurata()
        {
            //Chiedo la durata
            Duration durata = ChiediDurata();
            // Seleziona episodi
            List<Podcast> podcasts = pr.GetEpisodiByDurations(durata);
            //Stampa
            StampaTitoloPodcast(podcasts);

        }

        private static void StampaTitoloPodcast(List<Podcast> podcasts)
        {
            foreach (var podcast in podcasts)
            {
                Console.WriteLine(podcast.PrintTitle());
                StampaEpisodi(podcast.Episodes);
            }
        }

        private static Duration ChiediDurata()
        {
            Duration d = new Duration();

            int ore;
            do
            {
                Console.WriteLine("Inserisci le ore di durata dell'audiolibro");
            } while (!int.TryParse(Console.ReadLine(), out ore));
            d.Hours = ore;

            int min;
            do
            {
                Console.WriteLine("Inserisci i minuti");
            } while (!int.TryParse(Console.ReadLine(), out min));
            d.Minutes = min;

            int sec;
            do
            {
                Console.WriteLine("Inserisci i secondi");
            } while (!int.TryParse(Console.ReadLine(), out sec));
            d.Seconds = sec;

            return d;
        }

        private static string VisualizzaEpisodi()
        {
            // Mostro i podcast
            MostraPodcast();
            // Faccio scegliere il podcast
            string titolo = ScegliPodcast();
            // Chiedo gli espisodi
            Podcast p = pr.GetEpisodi(titolo);
            //Stampo gli episodi

            StampaEpisodi(p.Episodes);

            return titolo;
        }

        private static void StampaEpisodi(List<Episode> episodi)
        {
            foreach (var episodio in episodi)
            {
                Console.WriteLine(episodio.Print());
            }
        }

        private static string ScegliPodcast()
        {
            string titolo;
            bool existsPodcast;
            do
            {
                Console.WriteLine("Inserisci il titolo");
                titolo = Console.ReadLine();
                existsPodcast = pr.ExistsPodcast(titolo);
            } while (!existsPodcast);

            return titolo;
        }
        private static string ScegliCanzone()
        {
            string titolo;
            bool existsCanzone;
            do
            {
                Console.WriteLine("Inseirsci il titolo");
                titolo = Console.ReadLine();
                existsCanzone = cr.ExistsCanzone(titolo);
            } while (!existsCanzone);

            return titolo;
        }

        private static void MostraPodcast()
        {
            // Fa la fetch
            List<Podcast> podcasts = pr.Fetch();
            //stampa a video
            StampaPodcast(podcasts);
        }

        private static void StampaPodcast(List<Podcast> podcasts)
        {
            foreach (var podcast in podcasts)
            {
                Console.WriteLine(podcast.Print());
            }
        }

        private static void MostraCanzoniPerGenere()
        {
            //Chiedi il genere
            Genre genere = ChiediGenere();
            //Chiedi le canzoni di quel genere
            List<Song> songs = cr.GetByGenre(genere);
            //Stampa canzoni
            StampaCanzoni(songs);
        }

        private static Genre ChiediGenere()
        {
            int genereScelto;
            bool isInt;
            do
            {
                Console.WriteLine("Scegli un genere");
                foreach (var genere in Enum.GetValues(typeof(Genre)))
                {
                    Console.WriteLine($"Premi {(int)genere + 1} per {(Genre)genere}");
                }
                isInt = int.TryParse(Console.ReadLine(), out genereScelto);

            } while (!isInt || genereScelto <= 0 || genereScelto >= 4);

            return (Genre)(genereScelto - 1);
        }

        private static void MostraCanzoni()
        {
            // Fa la fetch
            List<Song> songs = cr.Fetch();
            //stampa a video
            StampaCanzoni(songs);
        }

        private static void StampaCanzoni(List<Song> canzoni)
        {
            foreach (var canzone in canzoni)
            {
                Console.WriteLine(canzone.Print());
            }
        }
    }
}
