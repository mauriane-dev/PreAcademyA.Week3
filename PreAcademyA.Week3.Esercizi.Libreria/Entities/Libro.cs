using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Esercizi.Libreria.Entities
{
    abstract class Libro
    {
        public double Prezzo { get; set; }
        public string Titolo { get; set; }
        public string Autore { get; set; }

        public Libro()
        {

        }
        public Libro(double prezzo, string titolo, string autore)
        {
            Prezzo = prezzo;
            Titolo = titolo;
            Autore = autore;
        }

        public virtual string Print()
        {
            return $"Titolo: {Titolo}, Autore: {Autore}, Prezzo: {Prezzo}";
        }
    }
}
