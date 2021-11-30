using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademiA.Week3.RicorsioneVsIterazione
{
    #region
    // Calcolare il fattoriale di un numero
    // n! = n * (n - 1) * (n - 2) ..... * 1

    //      1 se n == 0    
    // n! = 
    //      n * (n - 1)! altrimenti

    // 5! = 5 * 4!
    // 4! = 4 * 3!
    // 3! = 3 * 2!
    // 2! = 2 * 1!
    // 1! = 1 * 0!
    // 0! = 1



    // una parola è palindroma... se ha al massimo 1 carattere
    // oppure
    // se la prima lettera è uguale all'ultima e
    // il resto della parola è... palindroma
    // "radar"

    //[0] == [lenght -1]  -> x
    //[1] == [x -1]   -> x


    // restituisce l'ennesimo numero della serie di fibonacci
    // 0 1 1 2 3 5 8 13 21 34 55 89 144
    // 0 1 2 3 4 5 6 7  8  9  10 11 12


    // Scrivere una funzione che dato un importo di denaro iniziale,
    // un interesse annuo( 3% )  e un numero di anni permette di calcolare
    // l’importo di denaro accresciuto degli interessi dopo il numero di anni passati

    // Esempio
    // Voglio vincolare 10000 euro per 3 anni con un interesse del 3%
    //                                                         10000
    // Dopo 1 anno : 10000 + (10000 * 3 / 100) = 10000 + 300 = 10300
    // Dopo 2 anni : 10300 + (10300 * 3 / 100) = 10300 + 309 = 10609
    // Dopo 3 anni : 10609 + (10609 * 3 / 100) = 10609 + 318,27 = 10927,27
    #endregion

    class Esercizi
    {
        internal static long FattorialeIterazione(int n)
        {
            long f = 1;
            while (n > 0)
                f *= n--;

            return f;
        }
        internal static long FattorialeRicorsione(int n)
        {
            if (n == 0)
                return 1;
            return n * FattorialeRicorsione(n - 1);

            //return n == 0 ? 1 : n * FattRicorsivo(n - 1);
        }

        // 0 1 2 3 4
        // r a d a r
        // p i p p o
        internal static bool PalindromaIterazione(string s)
        {
            int count = s.Length;

            for(int i = 0; i< (int)s.Length / 2; i++)
            {
                if(s[i] != s[--count])
                {
                    return false;
                }
            }
            return true;
        }
        // 0 1 2 3 4
        // r a d a r
        // X a d a X
        // X X d X X 
        // p i p p o
        internal static bool PalindromaRicorsione(string s)
        {
            if (s.Length <= 1)
                return true;

            if (s[0] == s[s.Length - 1])
                return PalindromaRicorsione(s.Substring(1, s.Length - 2));
            else
                return false;

            //return s.Length <= 1 || (s[0] == s[s.Length - 1] &&
            //    Palindroma(s.Substring(1, s.Length - 2)));
        }

        // 0 1 1 2 3 5 8 13 21 34 55 89 144
        // 0 1 2 3 4 5 6 7  8  9  10 11 12
        internal static int FibonacciIterazione(int n)
        {
            int firstNumber = 0;
            int secondNumber = 1;

            if (n == 0)
                return n;
            if (n == 1)
                return n;

            int somma = firstNumber + secondNumber;  // calcolo il primo valore della serie

            for (int i = 2; i < n; i++)
            {
                firstNumber = secondNumber;
                secondNumber = somma;
                somma = firstNumber + secondNumber;
            }

            return somma;
        }
        internal static int FibonacciRicorsione(int n)
        {
            //if(n <= 1)
            //{
            //    return n;
            //}
            //else
            //{
            //    return FibonacciRicorsione(n - 2) + FibonacciRicorsione(n - 1);
            //}

            return n <= 1 ? n : FibonacciRicorsione(n - 2) + FibonacciRicorsione(n - 1);
        }

        internal static double InteressiIterazione(double capitale, int anni)
        {
            for (var i = 0; i < anni; i++)
            {
                capitale = capitale + (capitale * 3 / 100);
            }
            return capitale;
        }
        internal static double InteressiRicorsione(double capitale, int anni)
        {
            if (anni > 0)
            {
                return InteressiRicorsione(capitale + (capitale * 3 / 100), --anni);
            }
            else
            {
                return capitale;
            }
        }
    }
}
