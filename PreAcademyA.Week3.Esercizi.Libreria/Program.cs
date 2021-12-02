using PreAcademyA.Week3.Esercizi.Libreria.Entities;
using PreAcademyA.Week3.Esercizi.Libreria.Repository;
using System;
using System.Collections.Generic;

namespace PreAcademyA.Week3.Esercizi.Libreria
{
    /*
        Libri cartacei:
            Prezzo
            Titolo
            Autore

            Numero Di Pagine
            Quantità in magazzino

          Audiolibri
            Prezzo
            Titolo
            Autore

            Durata
        */

    // L'utente può decide se stampare a video tutti i libri cartecei, tutti gli audiolibri o tutti i libri
    // Vorrà stampare tutte le proprietà
    // Nel caso scelga di stampare tutti i libri, oltre alle proprietà stampare se è audiol o libro cart

    // Un utente può decidere di inserire un nuovo audiolibro(Verificare dal titolo che l'audiolibro non sia già presente)
    //un utente può modificare la quantità in magazzino di un libro cartaceo

    // data una durata visualizzare gli audiolibri con durata <= della durata inserita
    // data un prezzo visualizzare i libri cartacei con prezzo > del prezzo inserito


    class Program
    {
        static LibroCartaceoRepository lcr = new LibroCartaceoRepository();
        static AudiolibroRepository ar = new AudiolibroRepository();

        static void Main(string[] args)
        {


            while (true)
            {
                Console.Write("Premi un qualunque tasto");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Premi 1 per vedere i libri cartacei");
                Console.WriteLine("Premi 2 per vedere gli audiolibri");
                Console.WriteLine("Premi 3 per vedere tutti i libri");
                Console.WriteLine("Premi 4 per inserire un nuovo audiolibro");
                Console.WriteLine("Premi 5 per modificare la quantità di un libro cartaceo");
                Console.WriteLine("Premi 6 per filtrare gli audiolibri in base alla durata");
                Console.WriteLine("Premi 7 per filtrare i libri cartacei in base al prezzo");
                // Console.WriteLine("Premi 8 per inserire un nuovo libro cartaceo");
                int scelta;
                do
                {
                    Console.WriteLine("Cosa scegli?");
                } while (!int.TryParse(Console.ReadLine(), out scelta));

                switch (scelta)
                {
                    case 1:
                        {
                            StampaLibriCartacei();
                            break;
                        }
                    case 2:
                        {
                            //Chiedere la lista degli audiolibri
                            List<Audiolibro> audiolibri = ar.Fetch();
                            //Stamparli
                            foreach (var audiolibro in audiolibri)
                            {
                                Console.WriteLine(audiolibro.Print());
                            }
                            break;
                        }
                    case 3:
                        {
                            //Chiedo la lista di libri
                            List<Libro> libri = FetchLibri();
                            //Stampo la lista di libri
                            foreach (var libro in libri)
                            {
                                Console.WriteLine(libro.Print());
                            }
                            break;
                        }
                    case 4:
                        {
                            // Chiedere i dati
                            Audiolibro al = ChiediDati();
                            // Verificare se esiste già
                            if (ar.Exists(al))
                            {
                                Console.WriteLine("Questo audiolibro è già presente in magazzino");
                            }
                            else
                            {
                                // -> se non esiste aggiungere
                                ar.Add(al);
                                Console.WriteLine("Audiolibro aggiunto");
                            }
                            break;
                        }
                    case 5:
                        {
                            //Visualizzazione dei libri cart
                            StampaLibriCartacei();
                            // Scelta libro cart
                            string titolo = SceltaLibroCartaceo();
                            int qnt = SceltaQuantita();

                            lcr.UpdateQuantity(titolo, qnt);


                            // Chiedere la nuova quantità
                            // Modifica dell quantità
                            break;
                        }
                    case 6:
                        {
                            //Chiedere all'utente la durata
                            Durata d = ChiediDurata();
                            //Chiamre il metodo che esegue il filtro
                            List<Audiolibro> audiolibri = ar.GetByDurata(d);
                            //Stampare
                            foreach (var libroCartaceo in audiolibri)
                            {
                                Console.WriteLine(libroCartaceo.Print());
                            }

                            break;
                        }
                    case 7:
                        {
                            //Chiedere all'utente un prezzo
                            double p;
                            do
                            {
                                Console.WriteLine("Inserisci un prezzo");
                            } while (!double.TryParse(Console.ReadLine(), out p));

                            //chiamare un metodo che esegue il filtro

                            List<LibroCartaceo> libriCartacei = lcr.GetByPrice(p);

                            //stampare
                            foreach (var libroCartaceo in libriCartacei)
                            {
                                Console.WriteLine(libroCartaceo.Print());
                            }


                            break;
                        }
                }
            }
        }

        private static List<Libro> FetchLibri()
        {
            List<Libro> libri = new List<Libro>();

            List<LibroCartaceo> libriCartacei = lcr.Fetch();
            List<Audiolibro> audiolibri = ar.Fetch();

            libri.AddRange(libriCartacei);
            libri.AddRange(audiolibri);

            return libri;
        }

        //private static LibroCartaceo ChiediDatiLc()
        //{
        //    LibroCartaceo lc = new LibroCartaceo();
        //    lc.Titolo = ChiediTitolo();
        //    lc.Autore = ChiediAutore();
        //    lc.Prezzo = ChiediPrezzo();
        //    lc.QuantitaMagazzino = SceltaQuantita();

        //    int numPagine;
        //    do
        //    {
        //        Console.WriteLine("Inserisci il numero di pagine");
        //    } while (!int.TryParse(Console.ReadLine(), out numPagine));
        //    lc.NumeroDiPagine = numPagine;

        //    return lc;
        //}

        private static string SceltaLibroCartaceo()
        {
            string titolo;
            do
            {
                Console.WriteLine("Inserisci il titolo del libro cartaceo di cui vuoi mod la quantità");
                titolo = Console.ReadLine();
            } while (!lcr.Exists(titolo));

            return titolo;
        }

        private static int SceltaQuantita()
        {
            int qnt;

            do
            {
                Console.WriteLine("Inserisci la quantità");
            } while (!int.TryParse(Console.ReadLine(), out qnt));

            return qnt;
        }

        private static Audiolibro ChiediDati()
        {
            Audiolibro al = new Audiolibro();

            al.Titolo = ChiediTitolo();

            al.Autore = ChiediAutore();

            al.Prezzo = ChiediPrezzo();

            al.Durata = ChiediDurata();

            return al;
        }

        private static string ChiediTitolo()
        {
            string titolo;
            do
            {
                Console.WriteLine("Inserisci il titolo del nuovo audiolibro");
                titolo = Console.ReadLine();
            } while (string.IsNullOrEmpty(titolo));

            return titolo;
        }

        private static string ChiediAutore()
        {
            string autore;
            do
            {
                Console.WriteLine("Inserisci l'autore del nuovo audiolibro");
                autore = Console.ReadLine();
            } while (string.IsNullOrEmpty(autore));

            return autore;
        }

        private static double ChiediPrezzo()
        {
            double prezzo;
            do
            {
                Console.WriteLine("Inserisci il prezzo dell'audiolibro");
            } while (!double.TryParse(Console.ReadLine(), out prezzo));
            return prezzo;
        }

        private static Durata ChiediDurata()
        {
            Durata d = new Durata();

            int ore;
            do
            {
                Console.WriteLine("Inserisci le ore di durata dell'audiolibro");
            } while (!int.TryParse(Console.ReadLine(), out ore));
            d.Ore = ore;

            int min;
            do
            {
                Console.WriteLine("Inserisci i minuti");
            } while (!int.TryParse(Console.ReadLine(), out min));
            d.Minuti = min;

            int sec;
            do
            {
                Console.WriteLine("Inserisci i secondi");
            } while (!int.TryParse(Console.ReadLine(), out sec));
            d.Secondi = sec;

            return d;
        }

        private static void StampaLibriCartacei()
        {
            //Chiedere la lista dei libri cartacei
            List<LibroCartaceo> libriCartacei = lcr.Fetch();
            //Stamparli
            foreach (var libroCartaceo in libriCartacei)
            {
                Console.WriteLine(libroCartaceo.Print());
            }
        }
    }
}
