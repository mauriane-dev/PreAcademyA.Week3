using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademiA.Week3.RicorsioneVsIterazione
{
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
    class Esercizi
    {
    }
}
