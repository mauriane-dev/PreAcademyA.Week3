using PreAcademyA.Week3.Esercizi.Prodotti.Entities;
using PreAcademyA.Week3.Esercizi.Prodotti.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PreAcademyA.Week3.Esercizi.Prodotti
{
    /*
  Sviluppare una console app che permetta ad un utente di acquistare prodotti su un e-commerce.

     I prodotti disponibili sono:
                 * classe astratta prodotto
         - prodotti alimentari: 
                 codice prodotto * 
                 prezzo          * 
                 descrizione     *
                 data di scadenza
         - prodotti di abbigliamento
                 codice prodotto
                 prezzo
                 descrizione
                 taglia
                 brand
         - prodotti elettronica
                 codice prodotto
                 prezzo
                 descrizione
                 marca
                 modello

Un utente può:
vedere tutti i prodotti per categoria   -> si nell'IRepo

vedere tutti i prodotti per categoria con prezzo <= al prezzo inserito   -> si nell'IRepo

vedere gli alimenti con una data di scadenza >= alla data inserita

vedere l'abbigliamento con taglia uguale alla taglia inserita

vedere gli elettrodomestici della marca inserita.



Facoltativo. -> ogni volta che l'utente visualizza una lista di prodotti,
gli viene chiesto se e quale prodotto vuole aggiungere al carrello
Se sceglie un prodotto viene aggiunto al carrello.
Quindi tra le opzioni ci sarà: Procedi agli acquisti.
Verrà stampato a video il totale dei prodotti nel carrello

  */
    class Program
    {
        public static RepositoryPAbbigliamento abbigliamentoRepo = new RepositoryPAbbigliamento();
        public static RepositoryPAlimentare alimentareRepo = new RepositoryPAlimentare();
        public static RepositoryPElettronico elettronicoRepo = new RepositoryPElettronico();
        public static RepositoryCarrello carrelloRepo = new RepositoryCarrello();

        static void Main(string[] args)
        {
            bool continuare = true;
            int scelta;

            //DateTime dt = DateTime.Now;
            //DateTime dtPiu30gg = dt.AddDays(30);

            while (continuare)
            {
                Console.Write("Premi un qualunque tasto");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Premi 1 per vedere tutti i prodotti");
                Console.WriteLine("Premi 2 per filtrare i prodotti per prezzo");
                Console.WriteLine("Premi 3 per filtrare gli alimentari per data");
                Console.WriteLine("Premi 4 per filtrare l'abbigliamento per taglia");
                Console.WriteLine("Premi 5 per filtrare gli elettrodomestici per marca");
                Console.WriteLine("Premi 6 per procedere all'acquisto");
                Console.WriteLine("Premi 0 per uscire");

                do
                {
                    Console.WriteLine("Fai la tua scelta");
                } while (!int.TryParse(Console.ReadLine(), out scelta));

                switch (scelta)
                {
                    case 1:
                        {
                            List<Prodotto> prodotti = FetchProdotti();
                            Stampa(prodotti);
                            StampaInserimentoProdotto(prodotti);
                            break;
                        }
                    case 2:
                        {
                            double price = ChiediPrezzo();
                            List<Prodotto> prodotti = GetProdottiByPrice(price);
                            Stampa(prodotti);
                            StampaInserimentoProdotto(prodotti);
                            break;
                        }
                    case 3:
                        {
                            DateTime dt = ChiediData();
                            List<ProdottoAlimentare> prodottoAlimentare = alimentareRepo.GetByDate(dt);
                            Stampa(prodottoAlimentare);
                            break;
                        }
                    case 4:
                        {
                            TagliaEnum taglia = ChiediTaglia();
                            List<ProdottoAbbigliamento> pAbbigliamento = abbigliamentoRepo.GetBySize(taglia);
                            Stampa(pAbbigliamento);
                            break;
                        }
                    case 5:
                        {
                            string marca = ChiediMarca();
                            List<ProdottoElettronico> pElettronico = elettronicoRepo.GetByMarca(marca);
                            Stampa(pElettronico);
                            break;
                        }
                    case 6:
                        {
                            List<Prodotto> prodotti = carrelloRepo.Fetch();
                            Stampa(prodotti);
                            StampaTotale(prodotti);
                            break;
                        }
                    case 0:
                        {
                            continuare = false;
                            break;
                        }
                }
            }
        }

        private static void StampaTotale(List<Prodotto> prodotti)
        {
            var total = prodotti.Sum(p => p.Prezzo);

            Console.WriteLine($"TOTALE    {total}");
        }

        private static List<Prodotto> GetProdottiByPrice(double price)
        {
            List<Prodotto> prodotti = new List<Prodotto>();

            prodotti.AddRange(abbigliamentoRepo.GetByPrice(price));
            prodotti.AddRange(alimentareRepo.GetByPrice(price));
            prodotti.AddRange(elettronicoRepo.GetByPrice(price));

            return prodotti;
        }

        private static List<Prodotto> FetchProdotti()
        {
            List<Prodotto> prodotti = new List<Prodotto>();

            prodotti.AddRange(abbigliamentoRepo.Fetch());
            prodotti.AddRange(alimentareRepo.Fetch());
            prodotti.AddRange(elettronicoRepo.Fetch());

            return prodotti;
        }

        private static double ChiediPrezzo()
        {
            double prezzo;
            do
            {
                Console.WriteLine("Inserisci il prezzo");
            } while (!double.TryParse(Console.ReadLine(), out prezzo));

            return prezzo;
        }

        private static DateTime ChiediData()
        {
            DateTime dt;
            do
            {
                Console.WriteLine("Inserisci una data");
            } while (!DateTime.TryParse(Console.ReadLine(), out dt));

            return dt;
        }

        private static TagliaEnum ChiediTaglia()
        {
            string taglia;
            TagliaEnum tagliaScelta;
            do
            {
                Console.WriteLine("Inserisci una taglia");
                taglia = Console.ReadLine();
            } while (!Enum.TryParse(taglia, out tagliaScelta));

            return tagliaScelta;
        }
        private static string ChiediMarca()
        {
            string marca;
            do
            {
                Console.WriteLine("Inserisci una marca");
                marca = Console.ReadLine();
            } while (String.IsNullOrEmpty(marca));

            return marca;
        }
        private static void Stampa(List<Prodotto> prodotti)
        {
            foreach (var prodotto in prodotti)
            {
                Console.WriteLine(prodotto.Print());
            }
        }
        private static void Stampa(List<ProdottoAlimentare> prodotti)
        {
            foreach (var prodotto in prodotti)
            {
                Console.WriteLine(prodotto.Print());
            }
        }
        private static void Stampa(List<ProdottoAbbigliamento> prodotti)
        {
            foreach (var prodotto in prodotti)
            {
                Console.WriteLine(prodotto.Print());
            }
        }
        private static void Stampa(List<ProdottoElettronico> prodotti)
        {
            foreach (var prodotto in prodotti)
            {
                Console.WriteLine(prodotto.Print());
            }
        }

        private static void StampaInserimentoProdotto(List<Prodotto> prodotti)
        {
            Console.WriteLine("Vuoi aggiungere un prodotto al carrello?");

            //SI o NO
            string risposta = Console.ReadLine();
            string codice;
            if (risposta.ToUpper() == "SI")
            {
                do
                {
                    Console.WriteLine("Inserisci il codice del prodotto");
                    codice = Console.ReadLine();
                } while (!prodotti.Exists(p => p.Codice == codice));

                carrelloRepo.Add(prodotti.First(p => p.Codice == codice));
            }
        }
    }
}
