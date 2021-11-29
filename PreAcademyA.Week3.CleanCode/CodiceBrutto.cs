using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.CleanCode
{
    class CodiceBrutto
    {
        public static void Start()
        {
            Console.WriteLine("Inserisci i numeri");
            int a = 13;

            int[] b = new int[a];

            int i = 0;

            do
            {
                int f = int.Parse(Console.ReadLine());
                b[i] = f;
                i++;
            } while (i < 13);
            var d = 0;

            for (int c = 0; c < a; c++)
            {
                if (c % 2 == 0)
                {
                    d = d + b[c];

                }
                else
                {
                    d = d + b[c] * 3;
                }
            }

            if (d % 10 == 0)
            {
                Console.WriteLine("Valido");
            }
            else
            {
                Console.WriteLine("Non valido");
            }
        }
    }
}
