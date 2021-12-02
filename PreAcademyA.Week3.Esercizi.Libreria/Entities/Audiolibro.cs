using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Esercizi.Libreria.Entities
{
    class Audiolibro : Libro
    {
        public Durata Durata { get; set; }

        public Audiolibro()
        {

        }
        public Audiolibro(double prezzo, string titolo, string autore, Durata durata)
            : base(prezzo, titolo, autore)
        {
            Durata = durata;
        }

        public override string Print()
        {
            return $"Audiolibro -> {base.Print()}, Durata: {Durata.Ore} ore, {Durata.Minuti} minuti, {Durata.Secondi} secondi";
        }

    }
    public struct Durata
    {
        public int Ore { get; set; }
        public int Minuti { get; set; }
        public int Secondi { get; set; }

        public Durata(int ore, int min, int sec)
        {
            Ore = ore;
            Minuti = min;
            Secondi = sec;
        }
    }
}
