using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.CleanCode
{
    class CodiceBello
    {

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

