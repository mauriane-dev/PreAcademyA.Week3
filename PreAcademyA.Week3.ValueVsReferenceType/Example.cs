using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.ValueVsReferenceType
{
    static class Example
    {
        public static void Esempi()
        {
            //Value type - valore di default predefinito
            int i;
            double d;
            DateTime dt;
            Season season;

            // Reference type - valore di default null
            //string s;      // -> Attenzione al comportamento
            //int[] ilMioArray;
            //Person p;
            //p = new Person();
            //p.Eta = 10;
            //var b = p.Name;

            //Value type - valore di default predefinito -> posso renderli nullabili
            int? iNull;
            double? dNull;
            DateTime? dtNull;
            Season? seasonNull;

            // Divisione
            //int? dividendo;
            //int? divisore;
            //var risultato = dividendo / divisore;


            int ilMioPrimoValore = 100; 
            int ilMioSecondoValore = ilMioPrimoValore;
            Console.WriteLine($"Il valore del mio primo valore è {ilMioPrimoValore}");      // 100
            Console.WriteLine($"Il valore del mio secondo valore è {ilMioSecondoValore}");  // 100
            ilMioPrimoValore = 200;
            Console.WriteLine($"Il valore del mio primo valore è {ilMioPrimoValore}");      // 200
            Console.WriteLine($"Il valore del mio secondo valore è {ilMioSecondoValore}");  // 100

            Person p1 = new Person();
            p1.Name = "Arianna";
            p1.Eta = 30;

            Person p2 = p1;
            Console.WriteLine($"La persona 1 si chiama {p1.Name} e ha {p1.Eta} anni");      // Arianna, 30
            Console.WriteLine($"La persona 2 si chiama {p2.Name} e ha {p2.Eta} anni");      // Arianna, 30

            p1.Name = "Alessandra";
            p1.Eta = 29;
            Console.WriteLine($"La persona 1 si chiama {p1.Name} e ha {p1.Eta} anni");      // Alessandra, 29
            Console.WriteLine($"La persona 2 si chiama {p2.Name} e ha {p2.Eta} anni");      // Alessandra, 29

            // Le stringhe nonostante siano reference type, si comportano con value type per quanto riguarda l'allocazione della memoria
            string s1 = "Ciao a tutte";
            string s2 = s1;
            Console.WriteLine($"La stringa 1 dice: {s1}");      // Ciao a tutte
            Console.WriteLine($"La stringa 2 dice: {s2}");      // Ciao a tutte

            s1 = "Mi hai cambiato il valore";
            Console.WriteLine($"La stringa 1 dice: {s1}");      // Mi hai cambiato il valore
            Console.WriteLine($"La stringa 2 dice: {s2}");      // Ciao a tutte
        }

        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
    }
}
