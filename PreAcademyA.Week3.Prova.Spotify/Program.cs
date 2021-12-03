using System;

namespace PreAcademyA.Week3.Prova.Spotify
{
    class Program
    {
        // 1)
        // string nome = "Mario" -> inizializzazione
        // int i;                -> dichiarazione
        // isInt = true;         -> assegnazione

        // 2) b -> il reference type può essere nullo
        //int i = null;
        //string a = null;

        //3) c

        //int[] arrayDiInteri = { 1, 2, 3 };
        //string[] arrayDiStringhe = { "Pippo", "Pluto", "Paperino" };

        //int i = FaiQualcosa(arrayDiInteri);
        //string parola = FaiQualcosa(arrayDiStringhe);
        //int i2 = FaiQualcosa(arrayDiStringhe);
        //string parola = FaiQualcosa(arrayDiInteri);

        // 4)  c

        //int IlMioMetodo(int i)  //-> metodo che chiama un altro metodo
        //{
        //    //Condizione di stop
        //    int tot = 0;
        //    return tot = tot * IlMioSecondoMetodo(i++);
        //}

        //int IlMioMetodo(int tot)   // -> iterazione
        //{
        //    for (int i = 0; i < tot; i++)
        //    {
        //        tot = tot * i;
        //    }
        //    return tot;
        //}

        //int IlMioMetodo(int i)      // -> ricorsione, metodo che chiama se stesso
        //{
        //    //Condizione di stop
        //    int tot = 0;
        //    return tot = tot * IlMioMetodo(i++);
        //}

        // 5)

        //int i; //-> 0
        //       //Person p // -> p null
        //string s = string.Empty; //s ""
        //double? d; //-> null

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IterazioneUtente.Menu();
        }
        public static int FaiQualcosa(string[] ilMioArray)
        {
            return 1;
        }
    }
}
