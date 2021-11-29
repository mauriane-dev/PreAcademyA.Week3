using System;

namespace PreAcademiA.Week3.RicorsioneVsIterazione
{
    class Program
    {
        static void Main(string[] args)
        {
            // Voler stampare tutti i numeri da n a 1
            // StampaNumeri(5);

            /// Dato un numero a e una potenza b
            // stampare a alla b

            //Eleva(3, 4);
            //Console.WriteLine(ElevaRicorsione(3, 4));

            // Fattoriale
            var risultato = Esercizi.FattorialeIterazione(5);
            Console.WriteLine($"Il fattoriale calcolato con l'iterazione è {risultato}");
            risultato = Esercizi.FattorialeRicorsione(5);
            Console.WriteLine($"Il fattoriale calcolato con la ricorsione è {risultato}");

            // Palindroma
            //string s1 = "radar";
            //Console.WriteLine($"Iteazione: la parola {s1} è palindroma? {Esercizi.PalindromaIterazione(s1)}");
            //Console.WriteLine($"Ricorsione: la parola {s1} è palindroma? {Esercizi.PalindromaRicorsione(s1)}");
            //s1 = "academy";
            //Console.WriteLine($"Iteazione: la parola {s1} è palindroma? {Esercizi.PalindromaIterazione(s1)}");
            //Console.WriteLine($"Ricorsione: la parola {s1} è palindroma? {Esercizi.PalindromaRicorsione(s1)}");

            //Fibonacci
            //int numero = 2;
            //Console.WriteLine($"il numero in posizione {numero} della serie di Fibonacci è {Esercizi.FibonacciIterazione(numero)}");
            //Console.WriteLine($"il numero in posizione {numero} della serie di Fibonacci è {Esercizi.FibonacciRicorsione(numero)}");

            //Interessi
            //double capitale = 10000;
            //int anni = 3;
            //Console.WriteLine($"Iterazione: con un capitale di {capitale} euro, dopo {anni} " +
            //    $"anni si avranno {Esercizi.InteressiIterazione(capitale, anni)} euro");
            //Console.WriteLine($"Ricorsione: con un capitale di {capitale} euro, dopo {anni} " +
            //    $"anni si avranno {Esercizi.InteressiRicorsione(capitale, anni)} euro");
        }

        static void Eleva(int a, int b)
        {
            int potenza = 1;

            for (int i = 0; i < b; i++)
            {
                potenza = potenza * a;
            }
            Console.WriteLine(potenza);
        }
        static int ElevaRicorsione(int a, int b)
        {
            if(b == 0)
            {
                a = 1;
            }
            else
            {
                a = a * ElevaRicorsione(a, b -1);
            }

            return a;
        }


        //5
        static void StampaNumeri(int n)
        {
            //for (int i = n; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //while (n > 0)
            //{
            //    Console.WriteLine(n--);
            //}


            //int i = 1;
            //if (i <= n)
            //{
            //    StampaNumeri(i + 1);
            //    Console.WriteLine(n);
            //}
        }
    }
}
