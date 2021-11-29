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
            
            Eleva(3, 4);
            Console.WriteLine(ElevaRicorsione(3, 4));
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
