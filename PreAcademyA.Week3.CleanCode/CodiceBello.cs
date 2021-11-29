using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.CleanCode
{
    class CodiceBello
    {
        #region
        // ISBN - International Standard Book Number è un identificatore numerico univoco del libro commerciale.
        // La sua lunghezza è di 13 cifre di cui l'ultima è la cifra di controllo per il rilevamento degli errori.

        // cifra di controllo ISBN-13 è calcolata da Modulo10 con pesi alternati di 1 e 3sulle prime 12 cifre.
        // Esempio: 978300640615?
        // 9×1 + 7×3 + 8×1 + 0×3 + 3×1 + 0×3 + 6×1 + 4×3 + 0×1 + 6×3 + 1×1 + 5×3 = 93.
        // 93 /10 = 9 resto 3.
        // La cifra di controllo è il valore necessario da aggiungere alla somma per renderla divisibile per 10. 
        // Quindi la cifra di controllo è7. L'ISBN valido è 9780306406157 .
        //Il tuo compito è convalidare un elenco di codici ISBN.
        //Un codice ISBN valido dovrebbe contenere le cifre0 per 9 solo,

        #endregion

        const int lunghezzaCartaDiCredito = 13;
        public static void Start()
        {
            var iban = InsertIban();
            var sommaCifre = SumNumbers(iban);
            IsValid(sommaCifre);
        }
        static int[] InsertIban()
        {
            Console.WriteLine("Inserisci numeri della tua carta di credito");

            int[] cartaDiCredito = new int[lunghezzaCartaDiCredito];

            int i = 0;

            do
            {
                int numeroInserito = int.Parse(Console.ReadLine());
                cartaDiCredito[i] = numeroInserito;
                i++;
            } while (i < 13);

            return cartaDiCredito;
        }
        static int SumNumbers(int[] cartaDiCredito)
        {
            var sommaDelleCifre = 0;

            // per verificare se una cdc è valida, sommo le cifre in posizione pari, mentre quelle in posizione
            // dispari le moltiplico per 3 prima di sommarle
            for (int count = 0; count < lunghezzaCartaDiCredito; count++)
            {
                if (count % 2 == 0)
                {
                    sommaDelleCifre = sommaDelleCifre + cartaDiCredito[count];

                }
                else
                {
                    sommaDelleCifre = sommaDelleCifre + cartaDiCredito[count] * 3;
                }
            }
            return sommaDelleCifre;
        }
        static void IsValid(int sommaDelleCifre)
        {
            if (sommaDelleCifre % 10 == 0)
            {
                Console.WriteLine("E' una carta valida");
            }
            else
            {
                Console.WriteLine("Non è una carta valida");
            }
        }
    }
}

